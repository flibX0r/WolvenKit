using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Output : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("node")] 
		public animPoseLink Node
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_Output()
		{
			Id = uint.MaxValue;
			Node = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
