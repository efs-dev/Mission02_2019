//USING
using UnityEngine;
//USING
using System;
//USING
using System.Collections;
//USING
using System.Collections.Generic;
//CLASS InitScripts
public static partial class InitScripts {
    ///METHOD Init
    public static void Init (  ) {
        ///METHOD_BODY_START Init
        ///Id Default
        Ids.Add("Default");
        ActionsBlocking.Add(Action_Default);
        ActionsNonBlocking.Add(null);
        Conditions.Add(Condition_Default);
        ///METHOD_BODY_END Init
    }

    ///METHOD Action_Default
    public static IEnumerator Action_Default (  ) {
        ///METHOD_BODY_START Action_Default
        Debug.Log("init script default");
        #if UNITY_WEBGL
        
        #if BRAINPOP
        yield return SaveGames.CheckBrainPopLogin();
        Debug.Log("skip login");
        yield return SaveGames.RetrieveSaveData();
        SaveGames.LoadUserFlags();
        yield return Actions.LoadGameMenu();
        #else
        if (UserData.RequiresLogin())
        {
        Debug.Log("requires login");
        yield return Actions.LoadLoginMenu();
        }
        else
        {
        Debug.Log("skip login");
        yield return SaveGames.RetrieveSaveData();
        SaveGames.LoadUserFlags();
        yield return Actions.LoadGameMenu();
        }
        #endif
        #elif UNITY_IOS
        yield return SaveGames.RetrieveSaveData();
        SaveGames.LoadUserFlags();
        yield return Actions.LoadGameMenu();
        #else
        yield return Actions.LoadLoginMenu();
        //yield return SaveGames.RetrieveSaveData();
        //SaveGames.LoadUserFlags();
        //yield return Actions.LoadGameMenu();
        #endif
        
        
        
        ///METHOD_BODY_END Action_Default
    }

    ///METHOD Condition_Default
    public static bool Condition_Default (  ) {
        ///METHOD_BODY_START Condition_Default
        return true;
        ///METHOD_BODY_END Condition_Default
    }
}
//CLASS_END InitScripts
