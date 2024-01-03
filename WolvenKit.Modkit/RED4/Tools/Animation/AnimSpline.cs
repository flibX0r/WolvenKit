using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using SharpGLTF.Schema2;

using WolvenKit.RED4.Types;

using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

using static WolvenKit.RED4.Types.Enums;
using static WolvenKit.Modkit.RED4.Animation.Fun;
using static WolvenKit.Modkit.RED4.Animation.Gltf;

namespace WolvenKit.Modkit.RED4.Animation
{
    public class CompressedBuffer
    {
        public static void ExportAsAnimationToModel(ref ModelRoot model, animAnimation animAnimDes, bool incRootMotion = true)
        {
            if (animAnimDes.AnimBuffer.GetValue() is not animAnimationBufferCompressed blob)
            {
                throw new ArgumentNullException();
            }
            blob.ReadBuffer();

            // boneidx time value
            var positions = new Dictionary<ushort, Dictionary<float, Vec3>>();
            var rotations = new Dictionary<ushort, Dictionary<float, Quat>>();
            var scales = new Dictionary<ushort, Dictionary<float, Vec3>>();

            if (animAnimDes.MotionExtraction != null && animAnimDes.MotionExtraction.Chunk != null && incRootMotion)
            {
                ROOT_MOTION.AddRootMotion(ref positions, ref rotations, animAnimDes);
            }

            foreach (var key in blob.AnimKeys)
            {
                if (key is animKeyPosition p)
                {
                    if (!positions.ContainsKey(p.Idx))
                    {
                        positions[p.Idx] = new Dictionary<float, Vec3>();
                    }
                    positions[p.Idx][p.Time] = TRVectorYupRhs(p.Position);
                }
                else if (key is animKeyRotation r)
                {
                    if (!rotations.ContainsKey(r.Idx))
                    {
                        rotations[r.Idx] = new Dictionary<float, Quat>();
                    }
                    rotations[r.Idx][r.Time] = RQuaternionYupRhs(r.Rotation);
                }
                else if (key is animKeyScale s)
                {
                    if (!scales.ContainsKey(s.Idx))
                    {
                        scales[s.Idx] = new Dictionary<float, Vec3>();
                    }
                    scales[s.Idx][s.Time] = SVectorYupRhs(s.Scale);
                }
            }

            foreach (var key in blob.AnimKeysRaw)
            {
                if (key is animKeyPosition p)
                {
                    if (!positions.ContainsKey(p.Idx))
                    {
                        positions[p.Idx] = new Dictionary<float, Vec3>();
                    }
                    positions[p.Idx][p.Time] = TRVectorYupRhs(p.Position);
                }
                else if (key is animKeyRotation r)
                {
                    if (!rotations.ContainsKey(r.Idx))
                    {
                        rotations[r.Idx] = new Dictionary<float, Quat>();
                    }
                    rotations[r.Idx][r.Time] = RQuaternionYupRhs(r.Rotation);
                }
                else if (key is animKeyScale s)
                {
                    if (!scales.ContainsKey(s.Idx))
                    {
                        scales[s.Idx] = new Dictionary<float, Vec3>();
                    }
                    scales[s.Idx][s.Time] = SVectorYupRhs(s.Scale);
                }
            }

            foreach (var key in blob.ConstAnimKeys)
            {
                if (key is animKeyPosition p)
                {
                    if (!positions.ContainsKey(p.Idx))
                    {
                        positions[p.Idx] = new Dictionary<float, Vec3>();
                    }
                    positions[p.Idx][p.Time] = TRVectorYupRhs(p.Position);
                }
                else if (key is animKeyRotation r)
                {
                    if (!rotations.ContainsKey(r.Idx))
                    {
                        rotations[r.Idx] = new Dictionary<float, Quat>();
                    }
                    rotations[r.Idx][r.Time] = RQuaternionYupRhs(r.Rotation);
                }
                else if (key is animKeyScale s)
                {
                    if (!scales.ContainsKey(s.Idx))
                    {
                        scales[s.Idx] = new Dictionary<float, Vec3>();
                    }
                    scales[s.Idx][s.Time] = SVectorYupRhs(s.Scale);
                }
            }

            // Can switch to system Json when SharpGLTF support released (maybe in .31)
            // Right now it's not possible to add an empty array to a JsonContent.
            // Can work around that elsewhere but... just don't implement your own
            // JSON parser, kids.
            var animExtras = new AnimationExtrasForGltf(
                CurrentSchema(),
                animAnimDes.AnimationType.ToString(),
                animAnimDes.FrameClamping,
                animAnimDes.FrameClampingStartFrame,
                animAnimDes.FrameClampingEndFrame,
                blob.NumExtraJoints,
                blob.NumExtraTracks,
                blob.ConstTrackKeys.Select(_ => new AnimConstTrackKeySerializable(_.TrackIndex, _.Time, _.Value)).ToList(),
                blob.TrackKeys.Select(_ => new AnimTrackKeySerializable(_.TrackIndex, _.Time, _.Value)).ToList(),
                blob.FallbackFrameIndices.Select(_ => (ushort)_).ToList(),
                new AnimationOptimizationHints(
                    false,
                    blob.HasRawRotations ? AnimationEncoding.Uncompressed : AnimationEncoding.QuaternionAsFixed3x16bit
                )
            );

            // All the data is gathered, stitch it together

            var anim = model.CreateAnimation(animAnimDes.Name);
            var skin = model.LogicalSkins.FirstOrDefault(_ => _.Name is "Armature");
            if (skin is null)
            {
                ArgumentNullException.ThrowIfNull(nameof(skin));
                return;
            }

            // -.-
            anim.Extras = SharpGLTF.IO.JsonContent.Parse(JsonSerializer.Serialize(animExtras, SerializationOptions()));

            var exportAdditiveToBind = animAnimDes.AnimationType != animAnimationType.Normal;

            for (ushort i = 0; i < blob.NumJoints - blob.NumExtraJoints; i++)
            {
                var node = skin.GetJoint(i).Joint;
                if (rotations.ContainsKey(i))
                {
                    var isLinear = rotations[i].Count > 1;

                    if (exportAdditiveToBind)
                    {
                        foreach (var (t, r) in rotations[i])
                        {
                            rotations[i][t] = node.LocalTransform.Rotation * r;
                        }
                    }

                    anim.CreateRotationChannel(node, rotations[i], isLinear);
                }
                if (positions.ContainsKey(i))
                {
                    var isLinear = positions[i].Count > 1;

                    if (exportAdditiveToBind)
                    {
                        foreach (var (t, p) in positions[i])
                        {
                            positions[i][t] = node.LocalTransform.Translation + p;
                        }
                    }

                    anim.CreateTranslationChannel(node, positions[i], isLinear);
                }
                if (scales.ContainsKey(i))
                {
                    var isLinear = scales[i].Count > 1;

                    if (exportAdditiveToBind)
                    {
                        foreach (var (t, s) in scales[i])
                        {
                            scales[i][t] = node.LocalTransform.Scale * s;
                        }
                    }

                    anim.CreateScaleChannel(node, scales[i], isLinear);
                }
            }
        }
    }
}
