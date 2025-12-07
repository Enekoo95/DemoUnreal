// DemoEditor.Target.cs
using UnrealBuildTool;
using System.Collections.Generic;

public class DemoEditorTarget : TargetRules
{
    public DemoEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor; 
        DefaultBuildSettings = BuildSettingsVersion.V4;

        ExtraModuleNames.AddRange(new string[] { "Demo" });
    }
}