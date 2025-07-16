// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HadyCrushSaga : ModuleRules
{
	public HadyCrushSaga(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PrivateDependencyModuleNames.AddRange(new string[] {  });

		PublicDependencyModuleNames.AddRange(new string[] 
        { 
            "Core", "CoreUObject", "Engine", 
            "InputCore", "EnhancedInput", 
            
            // added
            "UMG",
            /*"MoviePlayer", */"AIModule", "Paper2D",
            /*"PhysicsCore", */"RenderCore", "RHI", "Niagara",
            "MediaAssets", "Slate", "SlateCore",
        });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true


        PublicIncludePaths.AddRange(new string[]
        {
            this.Name
        });



    }
}
