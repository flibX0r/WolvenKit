using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNodeSourceChannel_TransformVector : animIAnimNodeSourceChannel_Vector
	{
		[Ordinal(0)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animAnimNodeSourceChannel_TransformVector()
		{
			TransformIndex = new animTransformIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
