
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterWeaponList_Record
	{
		[RED("data")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Data
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
