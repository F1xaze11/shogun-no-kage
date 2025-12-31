using UnrealBuildTool;

public class Tini_SogunaServerTarget : TargetRules
{
	public Tini_SogunaServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Tini_Soguna");
	}
}
