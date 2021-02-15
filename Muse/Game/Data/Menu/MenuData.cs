//USING
using UnityEngine;
//USING
using System;
//USING
using System.Collections;
//USING
using System.Collections.Generic;
//CLASS MenuData
public static partial class MenuData {
    ///METHOD Init
    public static void Init (  ) {
        ///METHOD_BODY_START Init
        OnLoginValidate = LoginCallback;
        ///Games 1
        OnGameConditions.Add(GameCondition_0);
        ///PartName Prologue
        PartNames.Add("Prologue");
        ///PartSubName 
        PartSubNames.Add("");
        ///PartModulesToLoad 
        ModulesToLoad.Add(new List<string>() {  });
        ///PartModulesToUnload 
        ModulesToUnload.Add(new List<string>() {  });
        OnPartConditions.Add(PartCondition_0);
        PartImagesOverride.Add(false);
        OnPartActionsBlocking.Add(PartAction_0);
        OnPartActionsNonBlocking.Add(null);
        ///PartName Part 1
        PartNames.Add("Part 1");
        ///PartSubName Greenwood
        PartSubNames.Add("Greenwood");
        ///PartModulesToLoad 
        ModulesToLoad.Add(new List<string>() {  });
        ///PartModulesToUnload 
        ModulesToUnload.Add(new List<string>() {  });
        OnPartConditions.Add(PartCondition_1);
        PartImagesOverride.Add(false);
        OnPartActionsBlocking.Add(PartAction_1);
        OnPartActionsNonBlocking.Add(null);
        ///PartName Part 2
        PartNames.Add("Part 2");
        ///PartSubName SNIC
        PartSubNames.Add("SNIC");
        ///PartModulesToLoad 
        ModulesToLoad.Add(new List<string>() {  });
        ///PartModulesToUnload 
        ModulesToUnload.Add(new List<string>() {  });
        OnPartConditions.Add(PartCondition_2);
        PartImagesOverride.Add(false);
        OnPartActionsBlocking.Add(PartAction_2);
        OnPartActionsNonBlocking.Add(null);
        ///PartName Part 3
        PartNames.Add("Part 3");
        ///PartSubName Voting
        PartSubNames.Add("Voting");
        ///PartModulesToLoad 
        ModulesToLoad.Add(new List<string>() {  });
        ///PartModulesToUnload 
        ModulesToUnload.Add(new List<string>() {  });
        OnPartConditions.Add(PartCondition_3);
        PartImagesOverride.Add(false);
        OnPartActionsBlocking.Add(PartAction_3);
        OnPartActionsNonBlocking.Add(null);
        ///PartName Epilogue
        PartNames.Add("Epilogue");
        ///PartSubName 
        PartSubNames.Add("");
        ///PartModulesToLoad 
        ModulesToLoad.Add(new List<string>() {  });
        ///PartModulesToUnload 
        ModulesToUnload.Add(new List<string>() {  });
        OnPartConditions.Add(PartCondition_4);
        PartImagesOverride.Add(false);
        OnPartActionsBlocking.Add(PartAction_4);
        OnPartActionsNonBlocking.Add(null);
        OnEnterState = RunEnterState;
        OnShowState = RunShowState;
        OnExitState = RunExitState;
        ///METHOD_BODY_END Init
    }

    ///METHOD LoginCallback
    public static IEnumerator LoginCallback (  ) {
        ///METHOD_BODY_START LoginCallback
        yield break;
        ///METHOD_BODY_END LoginCallback
    }

    ///METHOD GameCondition_0
    public static bool GameCondition_0 (  ) {
        ///METHOD_BODY_START GameCondition_0
        return true;
        ///METHOD_BODY_END GameCondition_0
    }

    ///METHOD PartCondition_0
    public static bool PartCondition_0 (  ) {
        ///METHOD_BODY_START PartCondition_0
        return true;
        ///METHOD_BODY_END PartCondition_0
    }

    ///METHOD PartAction_0
    public static IEnumerator PartAction_0 (  ) {
        ///METHOD_BODY_START PartAction_0
        Actions.IncrementData(6, 2);
        GameFlags.CurrentPart = 0;
        yield return Actions.LoadScene("anim_prologue1", "prologue");
        ///METHOD_BODY_END PartAction_0
    }

    ///METHOD PartCondition_1
    public static bool PartCondition_1 (  ) {
        ///METHOD_BODY_START PartCondition_1
        return GameFlags.UnlockedPart1;
        ///METHOD_BODY_END PartCondition_1
    }

    ///METHOD PartAction_1
    public static IEnumerator PartAction_1 (  ) {
        ///METHOD_BODY_START PartAction_1
        Actions.IncrementData(7, 2);
        GameFlags.CurrentPart = 1;
        yield return Actions.LoadScene("loc_camp_night", "p1");
        ///METHOD_BODY_END PartAction_1
    }

    ///METHOD PartCondition_2
    public static bool PartCondition_2 (  ) {
        ///METHOD_BODY_START PartCondition_2
        return GameFlags.UnlockedPart2;
        ///METHOD_BODY_END PartCondition_2
    }

    ///METHOD PartAction_2
    public static IEnumerator PartAction_2 (  ) {
        ///METHOD_BODY_START PartAction_2
        GameFlags.CurrentPart = 2;
        yield return Actions.LoadScene("anim_p2_intro", "p2");
        ///METHOD_BODY_END PartAction_2
    }

    ///METHOD PartCondition_3
    public static bool PartCondition_3 (  ) {
        ///METHOD_BODY_START PartCondition_3
        return GameFlags.UnlockedPart3;
        ///METHOD_BODY_END PartCondition_3
    }

    ///METHOD PartAction_3
    public static IEnumerator PartAction_3 (  ) {
        ///METHOD_BODY_START PartAction_3
        Actions.IncrementData(9, 2);
        GameFlags.CurrentPart = 3;
        yield return Actions.LoadScene("loc_camp_p3", "p3");
        ///METHOD_BODY_END PartAction_3
    }

    ///METHOD PartCondition_4
    public static bool PartCondition_4 (  ) {
        ///METHOD_BODY_START PartCondition_4
        return GameFlags.UnlockedEpilogue;
        ///METHOD_BODY_END PartCondition_4
    }

    ///METHOD PartAction_4
    public static IEnumerator PartAction_4 (  ) {
        ///METHOD_BODY_START PartAction_4
        yield return Actions.LoadScene("epilogue", "epilogue");
        ///METHOD_BODY_END PartAction_4
    }

    ///METHOD RunEnterState
    public static void RunEnterState (  ) {
        ///METHOD_BODY_START RunEnterState
        Actions.SmartwordsButtonHide();
        Actions.BadgesButtonHide();
        //Actions.AudioPlay("coming_home", true);
        Actions.HideQuests();
        if (SaveGames.IsDemoMode)
        {
        Actions.ExitDemoMode();
        GameFlags.MenuScreen = MenuScreens.Demo;
        }
        
        Actions.ShowMenuScreen();
        Actions.QuestDeactivateAll(QuestTypes.Task);
        //MenuParts.UnlockAllParts = true;
        ///METHOD_BODY_END RunEnterState
    }

    ///METHOD RunShowState
    public static void RunShowState (  ) {
        ///METHOD_BODY_START RunShowState
        
        ///METHOD_BODY_END RunShowState
    }

    ///METHOD RunExitState
    public static void RunExitState (  ) {
        ///METHOD_BODY_START RunExitState
        //AudioManager.Stop("coming_home");
        Actions.ShowQuests();
        Actions.SmartwordsButtonShow();
        Actions.BadgesButtonShow();
        Actions.HideMenuScreen();
        ///METHOD_BODY_END RunExitState
    }
}
//CLASS_END MenuData
