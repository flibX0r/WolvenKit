using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerfectDischargePrereq : StatPoolPrereq
	{
		[Ordinal(6)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PerfectDischargePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
