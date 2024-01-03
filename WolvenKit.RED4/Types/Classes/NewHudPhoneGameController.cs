using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewHudPhoneGameController : gameuiNewHudPhoneGameController
	{
		[Ordinal(17)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(18)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(19)] 
		[RED("questsSystem")] 
		public CWeakHandle<questQuestsSystem> QuestsSystem
		{
			get => GetPropertyValue<CWeakHandle<questQuestsSystem>>();
			set => SetPropertyValue<CWeakHandle<questQuestsSystem>>(value);
		}

		[Ordinal(20)] 
		[RED("uiSystem")] 
		public CWeakHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CWeakHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CWeakHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(21)] 
		[RED("fact1ListenerId")] 
		public CUInt32 Fact1ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(22)] 
		[RED("fact2ListenerId")] 
		public CUInt32 Fact2ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("fact3ListenerId")] 
		public CUInt32 Fact3ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(24)] 
		[RED("onNotificationsQueueChanged")] 
		public CHandle<redCallbackObject> OnNotificationsQueueChanged
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("currActiveQueueId")] 
		public CInt32 CurrActiveQueueId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("CurrentFunction")] 
		public CEnum<EHudPhoneFunction> CurrentFunction
		{
			get => GetPropertyValue<CEnum<EHudPhoneFunction>>();
			set => SetPropertyValue<CEnum<EHudPhoneFunction>>(value);
		}

		[Ordinal(27)] 
		[RED("gameplayRestrictions")] 
		public CArray<CName> GameplayRestrictions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(28)] 
		[RED("buttonPressed")] 
		public CBool ButtonPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("repeatingScrollActionEnabled")] 
		public CBool RepeatingScrollActionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("TimeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("activePhoneElements")] 
		public CUInt32 ActivePhoneElements
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(32)] 
		[RED("bbSystem")] 
		public CWeakHandle<gameBlackboardSystem> BbSystem
		{
			get => GetPropertyValue<CWeakHandle<gameBlackboardSystem>>();
			set => SetPropertyValue<CWeakHandle<gameBlackboardSystem>>(value);
		}

		[Ordinal(33)] 
		[RED("bbUiSystemDef")] 
		public CHandle<UI_SystemDef> BbUiSystemDef
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(34)] 
		[RED("bbUiSystem")] 
		public CWeakHandle<gameIBlackboard> BbUiSystem
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(35)] 
		[RED("isInMenuCallback")] 
		public CHandle<redCallbackObject> IsInMenuCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("bbUiComDeviceDef")] 
		public CHandle<UI_ComDeviceDef> BbUiComDeviceDef
		{
			get => GetPropertyValue<CHandle<UI_ComDeviceDef>>();
			set => SetPropertyValue<CHandle<UI_ComDeviceDef>>(value);
		}

		[Ordinal(37)] 
		[RED("bbUiComDevice")] 
		public CWeakHandle<gameIBlackboard> BbUiComDevice
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(38)] 
		[RED("phoneCallInformationCallback")] 
		public CHandle<redCallbackObject> PhoneCallInformationCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(39)] 
		[RED("phoneStatusChangedCallback")] 
		public CHandle<redCallbackObject> PhoneStatusChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("phoneMinimizedCallback")] 
		public CHandle<redCallbackObject> PhoneMinimizedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("contactsActiveCallback")] 
		public CHandle<redCallbackObject> ContactsActiveCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("messageToOpenCallback")] 
		public CHandle<redCallbackObject> MessageToOpenCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("phoneEnabledBBId")] 
		public CHandle<redCallbackObject> PhoneEnabledBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(44)] 
		[RED("bbUiQuickSlotsDataDef")] 
		public CHandle<UI_QuickSlotsDataDef> BbUiQuickSlotsDataDef
		{
			get => GetPropertyValue<CHandle<UI_QuickSlotsDataDef>>();
			set => SetPropertyValue<CHandle<UI_QuickSlotsDataDef>>(value);
		}

		[Ordinal(45)] 
		[RED("bbUiQuickSlotsData")] 
		public CWeakHandle<gameIBlackboard> BbUiQuickSlotsData
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(46)] 
		[RED("bbUiPlayerStatsDef")] 
		public CHandle<UI_PlayerStatsDef> BbUiPlayerStatsDef
		{
			get => GetPropertyValue<CHandle<UI_PlayerStatsDef>>();
			set => SetPropertyValue<CHandle<UI_PlayerStatsDef>>(value);
		}

		[Ordinal(47)] 
		[RED("bbUiPlayerStats")] 
		public CWeakHandle<gameIBlackboard> BbUiPlayerStats
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(48)] 
		[RED("DelaySystem")] 
		public CWeakHandle<gameDelaySystem> DelaySystem
		{
			get => GetPropertyValue<CWeakHandle<gameDelaySystem>>();
			set => SetPropertyValue<CWeakHandle<gameDelaySystem>>(value);
		}

		[Ordinal(49)] 
		[RED("DelayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(50)] 
		[RED("PhoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		[Ordinal(51)] 
		[RED("CurrentCallInformation")] 
		public questPhoneCallInformation CurrentCallInformation
		{
			get => GetPropertyValue<questPhoneCallInformation>();
			set => SetPropertyValue<questPhoneCallInformation>(value);
		}

		[Ordinal(52)] 
		[RED("CurrentPhoneCallContact")] 
		public CWeakHandle<gameJournalContact> CurrentPhoneCallContact
		{
			get => GetPropertyValue<CWeakHandle<gameJournalContact>>();
			set => SetPropertyValue<CWeakHandle<gameJournalContact>>(value);
		}

		[Ordinal(53)] 
		[RED("holoAudioCallLogicController")] 
		public CWeakHandle<HoloAudioCallLogicController> HoloAudioCallLogicController
		{
			get => GetPropertyValue<CWeakHandle<HoloAudioCallLogicController>>();
			set => SetPropertyValue<CWeakHandle<HoloAudioCallLogicController>>(value);
		}

		[Ordinal(54)] 
		[RED("contactListLogicController")] 
		public CWeakHandle<PhoneDialerLogicController> ContactListLogicController
		{
			get => GetPropertyValue<CWeakHandle<PhoneDialerLogicController>>();
			set => SetPropertyValue<CWeakHandle<PhoneDialerLogicController>>(value);
		}

		[Ordinal(55)] 
		[RED("phoneIconAnimProxy")] 
		public CHandle<inkanimProxy> PhoneIconAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(56)] 
		[RED("backgroundAnimProxy")] 
		public CHandle<inkanimProxy> BackgroundAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(57)] 
		[RED("screenType")] 
		public CEnum<PhoneScreenType> ScreenType
		{
			get => GetPropertyValue<CEnum<PhoneScreenType>>();
			set => SetPropertyValue<CEnum<PhoneScreenType>>(value);
		}

		[Ordinal(58)] 
		[RED("messagesPanelVisible")] 
		public CBool MessagesPanelVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("messagesPanelSpawned")] 
		public CBool MessagesPanelSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("threadsVisible")] 
		public CBool ThreadsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("messageToOpenHash")] 
		public CInt32 MessageToOpenHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(62)] 
		[RED("indexToSelect")] 
		public CUInt32 IndexToSelect
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(63)] 
		[RED("isSingleThread")] 
		public CBool IsSingleThread
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("isShowingAllMessages")] 
		public CBool IsShowingAllMessages
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("keepOpenWhenInHubMenu")] 
		public CBool KeepOpenWhenInHubMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("audioSystem")] 
		public CWeakHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetPropertyValue<CWeakHandle<gameGameAudioSystem>>();
			set => SetPropertyValue<CWeakHandle<gameGameAudioSystem>>(value);
		}

		[Ordinal(67)] 
		[RED("isRemoteControllingDevice")] 
		public CBool IsRemoteControllingDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("psmIsControllingDeviceCallback")] 
		public CHandle<redCallbackObject> PsmIsControllingDeviceCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(69)] 
		[RED("vehicleEnterCallback")] 
		public CHandle<redCallbackObject> VehicleEnterCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public NewHudPhoneGameController()
		{
			CurrActiveQueueId = -1;
			GameplayRestrictions = new();
			TimeoutPeroid = 8.000000F;
			DelayedTimeoutCallbackId = new gameDelayID();
			CurrentCallInformation = new questPhoneCallInformation();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
