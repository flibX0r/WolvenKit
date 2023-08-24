
namespace WolvenKit.RED4.Types
{
	public partial class gameEntityStubComponentPlacedProxy : entIPlacedComponent
	{
		public gameEntityStubComponentPlacedProxy()
		{
			Name = "entityStubPlacedProxy";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
