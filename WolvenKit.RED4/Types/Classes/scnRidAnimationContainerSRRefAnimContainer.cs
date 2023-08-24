using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRidAnimationContainerSRRefAnimContainer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animation")] 
		public scnRidAnimationSRRefId Animation
		{
			get => GetPropertyValue<scnRidAnimationSRRefId>();
			set => SetPropertyValue<scnRidAnimationSRRefId>(value);
		}

		[Ordinal(1)] 
		[RED("context")] 
		public scnRidAnimationContainerSRRefAnimContainerContext Context
		{
			get => GetPropertyValue<scnRidAnimationContainerSRRefAnimContainerContext>();
			set => SetPropertyValue<scnRidAnimationContainerSRRefAnimContainerContext>(value);
		}

		public scnRidAnimationContainerSRRefAnimContainer()
		{
			Animation = new scnRidAnimationSRRefId { Id = uint.MaxValue };
			Context = new scnRidAnimationContainerSRRefAnimContainerContext { GenderMask = new scnGenderMask { Mask = 128 } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
