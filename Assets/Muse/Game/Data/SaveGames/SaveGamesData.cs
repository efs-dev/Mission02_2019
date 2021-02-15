//USING
using UnityEngine;
//USING
using System;
//USING
using System.Collections.Generic;
//CLASS SaveGamesData
public static partial class SaveGamesData {
    ///METHOD Initialize
    public static void Initialize (  ) {
        ///METHOD_BODY_START Initialize
        Ids.Clear();
        Names.Clear();
        Descriptions.Clear();
        TriggerStates.Clear();
        TargetStates.Clear();
        TargetModules.Clear();
        Conditions.Clear();
        DemoFiles.Clear();
        ThumbnailIds.Clear();
        
        Ids.Add("prologue_start");
        Names.Add("Prologue");
        Descriptions.Add("The story of the Northern Cheyenne.");
        TriggerStates.Add("anim_prologue1");
        TargetStates.Add("anim_prologue1");
        TargetModules.Add("prologue");
        Conditions.Add(Condition_prologue_start);
        DemoFiles.Add("");
        ThumbnailIds.Add("save_p0_start");
        BlockingActions.Add(null);
        Actions.Add(Action_prologue_start);
        ///METHOD_BODY_END Initialize
    }

    ///METHOD Condition_prologue_start
    public static bool Condition_prologue_start (  ) {
        ///METHOD_BODY_START Condition_prologue_start
        return true;
        ///METHOD_BODY_END Condition_prologue_start
    }

    ///METHOD Action_prologue_start
    public static void Action_prologue_start (  ) {
        ///METHOD_BODY_START Action_prologue_start
        
        ///METHOD_BODY_END Action_prologue_start
    }
}
//CLASS_END SaveGamesData
