using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questLookAtDrivenTurnsNode : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<questLookAtDrivenTurnsMode> Mode
		{
			get => GetPropertyValue<CEnum<questLookAtDrivenTurnsMode>>();
			set => SetPropertyValue<CEnum<questLookAtDrivenTurnsMode>>(value);
		}

		[Ordinal(3)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(4)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(5)] 
		[RED("canLookAtDrivenTurnsInterruptGesture")] 
		public CBool CanLookAtDrivenTurnsInterruptGesture
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questLookAtDrivenTurnsNode()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			PuppetRef = new gameEntityReference { Names = new() };
			TargetRef = new gameEntityReference { Names = new() };
			CanLookAtDrivenTurnsInterruptGesture = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
