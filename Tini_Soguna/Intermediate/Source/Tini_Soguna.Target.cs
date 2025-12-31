using UnrealBuildTool;

public class Tini_SogunaTarget : TargetRules
{
	public Tini_SogunaTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Tini_Soguna");
	}
}
