using UnrealBuildTool;

public class CampanTarget : TargetRules
{
	public CampanTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Campan");
	}
}
