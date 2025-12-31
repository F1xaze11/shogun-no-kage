using UnrealBuildTool;

public class Tini_SogunaClientTarget : TargetRules
{
	public Tini_SogunaClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Tini_Soguna");
	}
}
