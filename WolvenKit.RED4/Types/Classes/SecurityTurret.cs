using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityTurret : SensorDevice
	{
		[Ordinal(200)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SecurityTurretData> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SecurityTurretData>>();
			set => SetPropertyValue<CHandle<AnimFeature_SecurityTurretData>>(value);
		}

		[Ordinal(201)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(202)] 
		[RED("lookAtSlot")] 
		public CHandle<entSlotComponent> LookAtSlot
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(203)] 
		[RED("laserMesh")] 
		public CHandle<entMeshComponent> LaserMesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(204)] 
		[RED("targetingComp")] 
		public CHandle<gameTargetingComponent> TargetingComp
		{
			get => GetPropertyValue<CHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CHandle<gameTargetingComponent>>(value);
		}

		[Ordinal(205)] 
		[RED("triggerSideOne")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(206)] 
		[RED("triggerSideTwo")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(207)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(208)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(209)] 
		[RED("laserGameEffect")] 
		public CHandle<gameEffectInstance> LaserGameEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(210)] 
		[RED("laserFXSlotName")] 
		public CName LaserFXSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(211)] 
		[RED("burstDelayEvtID")] 
		public gameDelayID BurstDelayEvtID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(212)] 
		[RED("isBurstDelayOngoing")] 
		public CBool IsBurstDelayOngoing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(213)] 
		[RED("nextShootCycleDelayEvtID")] 
		public gameDelayID NextShootCycleDelayEvtID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(214)] 
		[RED("isShootingOngoing")] 
		public CBool IsShootingOngoing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(215)] 
		[RED("timeToNextShot")] 
		public CFloat TimeToNextShot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(216)] 
		[RED("optim_CheckTargetParametersShots")] 
		public CInt32 Optim_CheckTargetParametersShots
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(217)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetPropertyValue<CHandle<gamedataWeaponItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataWeaponItem_Record>>(value);
		}

		[Ordinal(218)] 
		[RED("weaponTDBID")] 
		public TweakDBID WeaponTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(219)] 
		[RED("netClientCurrentlyAppliedState")] 
		public CHandle<SecurityTurretReplicatedState> NetClientCurrentlyAppliedState
		{
			get => GetPropertyValue<CHandle<SecurityTurretReplicatedState>>();
			set => SetPropertyValue<CHandle<SecurityTurretReplicatedState>>(value);
		}

		public SecurityTurret()
		{
			ControllerTypeName = "SecurityTurretController";
			DefaultSensePreset = "Senses.BasicTurret";
			IdleSound = "idleStart";
			IdleSoundStop = "idleStop";
			SoundDeviceON = "activated";
			SoundDeviceOFF = "deactivated";
			SoundDeviceDestroyed = "destroyed";
			AnimFeatureName = "SecurityTurretData";
			ItemID = new gameItemID();
			LaserFXSlotName = "laser";
			BurstDelayEvtID = new gameDelayID();
			NextShootCycleDelayEvtID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
