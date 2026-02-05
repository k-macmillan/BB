// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BB : ModuleRules
{
	public BB(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"BB",
			"BB/Variant_Platforming",
			"BB/Variant_Platforming/Animation",
			"BB/Variant_Combat",
			"BB/Variant_Combat/AI",
			"BB/Variant_Combat/Animation",
			"BB/Variant_Combat/Gameplay",
			"BB/Variant_Combat/Interfaces",
			"BB/Variant_Combat/UI",
			"BB/Variant_SideScrolling",
			"BB/Variant_SideScrolling/AI",
			"BB/Variant_SideScrolling/Gameplay",
			"BB/Variant_SideScrolling/Interfaces",
			"BB/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
