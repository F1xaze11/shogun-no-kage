using UnrealBuildTool;

public class Тіні_сьогунаTarget : TargetRules
{
	public Тіні_сьогунаTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Тіні_сьогуна");
	}
}
