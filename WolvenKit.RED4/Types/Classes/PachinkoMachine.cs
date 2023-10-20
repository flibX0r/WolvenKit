using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PachinkoMachine : ArcadeMachine
	{
		[Ordinal(109)] 
		[RED("distractionFXName")] 
		public CName DistractionFXName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PachinkoMachine()
		{
			ArcadeMachineType = Enums.ArcadeMachineType.Pachinko;
			DistractionFXName = "effect_distraction";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
