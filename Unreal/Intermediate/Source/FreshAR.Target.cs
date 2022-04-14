using UnrealBuildTool;

public class FreshARTarget : TargetRules
{
	public FreshARTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FreshAR");
	}
}
