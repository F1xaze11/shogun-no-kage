using UnrealBuildTool;

public class Tini_SogunaEditorTarget : TargetRules
{
	public Tini_SogunaEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Tini_Soguna");
	}
}
