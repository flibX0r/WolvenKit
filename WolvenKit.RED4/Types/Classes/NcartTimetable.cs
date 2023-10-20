using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NcartTimetable : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(99)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public NcartTimetable()
		{
			ControllerTypeName = "NcartTimetableController";
			ShortGlitchDelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
