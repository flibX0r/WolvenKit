using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionsSequencerControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("sequenceDuration")] 
		public CFloat SequenceDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(109)] 
		[RED("sequencerMode")] 
		public CEnum<EActionsSequencerMode> SequencerMode
		{
			get => GetPropertyValue<CEnum<EActionsSequencerMode>>();
			set => SetPropertyValue<CEnum<EActionsSequencerMode>>(value);
		}

		[Ordinal(110)] 
		[RED("actionTypeToForward")] 
		public SActionTypeForward ActionTypeToForward
		{
			get => GetPropertyValue<SActionTypeForward>();
			set => SetPropertyValue<SActionTypeForward>(value);
		}

		[Ordinal(111)] 
		[RED("ongoingSequence")] 
		public ActionsSequence OngoingSequence
		{
			get => GetPropertyValue<ActionsSequence>();
			set => SetPropertyValue<ActionsSequence>(value);
		}

		public ActionsSequencerControllerPS()
		{
			RevealDevicesGrid = false;
			SequenceDuration = 2.000000F;
			ActionTypeToForward = new SActionTypeForward { QHack = true };
			OngoingSequence = new ActionsSequence { SequenceInitiator = new entEntityID(), DelayIDs = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
