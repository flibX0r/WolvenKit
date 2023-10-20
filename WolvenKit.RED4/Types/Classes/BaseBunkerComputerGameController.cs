using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseBunkerComputerGameController : gameuiBaseBunkerComputerGameController
	{
		[Ordinal(2)] 
		[RED("factsSet")] 
		public BunkerSystemsFactsSet FactsSet
		{
			get => GetPropertyValue<BunkerSystemsFactsSet>();
			set => SetPropertyValue<BunkerSystemsFactsSet>(value);
		}

		[Ordinal(3)] 
		[RED("gateClosedFact")] 
		public CName GateClosedFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public BaseBunkerComputerGameController()
		{
			FactsSet = new BunkerSystemsFactsSet { ALPHA_FACT = "q305_server_01_offline", BRAVO_FACT = "q305_server_02_offline", SIERRA_FACT = "q305_server_backup_01_offline", VICTOR_FACT = "q305_server_backup_02_offline" };
			GateClosedFact = "q305_gate_closed";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
