using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerDevelopmentSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("playerData")] 
		public CArray<CHandle<PlayerDevelopmentData>> PlayerData
		{
			get => GetPropertyValue<CArray<CHandle<PlayerDevelopmentData>>>();
			set => SetPropertyValue<CArray<CHandle<PlayerDevelopmentData>>>(value);
		}

		[Ordinal(1)] 
		[RED("ownerData")] 
		public CArray<CHandle<PlayerDevelopmentData>> OwnerData
		{
			get => GetPropertyValue<CArray<CHandle<PlayerDevelopmentData>>>();
			set => SetPropertyValue<CArray<CHandle<PlayerDevelopmentData>>>(value);
		}

		[Ordinal(2)] 
		[RED("playerDevelopmentUpdated")] 
		public CBool PlayerDevelopmentUpdated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("progressionBuildUpdated")] 
		public CBool ProgressionBuildUpdated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerDevelopmentSystem()
		{
			PlayerData = new();
			OwnerData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
