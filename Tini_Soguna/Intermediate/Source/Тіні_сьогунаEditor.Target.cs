using UnrealBuildTool;

public class Тіні_сьогунаEditorTarget : TargetRules
{
	public Тіні_сьогунаEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Тіні_сьогуна");
	}
}
