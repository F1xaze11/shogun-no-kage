using UnrealBuildTool;

public class Тіні_сьогунаServerTarget : TargetRules
{
	public Тіні_сьогунаServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Тіні_сьогуна");
	}
}
