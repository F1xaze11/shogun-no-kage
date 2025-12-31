using UnrealBuildTool;

public class Тіні_сьогунаClientTarget : TargetRules
{
	public Тіні_сьогунаClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Тіні_сьогуна");
	}
}
