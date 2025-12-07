// Demo.Target.cs
using UnrealBuildTool;
using System.Collections.Generic;

public class Demo : TargetRules
{
    public Demo(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V4;

        ExtraModuleNames.AddRange(new string[] { "Demo" });
    }
}
