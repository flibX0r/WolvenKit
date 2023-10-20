using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerInputActionsNames : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CName ButtonHold
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CName ButtonToggle
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("driverCombatButtonHold")] 
		public CName DriverCombatButtonHold
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("driverCombatButtonActivate")] 
		public CName DriverCombatButtonActivate
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PlayerVisionModeControllerInputActionsNames()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
