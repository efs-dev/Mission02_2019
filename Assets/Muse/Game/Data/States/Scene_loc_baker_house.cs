//USING
using UnityEngine;
//USING
using System;
//USING
using System.Collections;
//USING
using System.Collections.Generic;
//USING
using System.Linq;
//USING
using NodeMaps;
//USING

//USING
[State("loc_baker_house", "SisOld")]
//CLASS Scene_loc_baker_house : State
public class Scene_loc_baker_house : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_loc_baker_house
    public Scene_loc_baker_house (  ) {
        ///METHOD_BODY_START Scene_loc_baker_house
        Id = "loc_baker_house";
        Modules.Add("prologue");
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_loc_baker_house
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p0_gma_001");
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_loc_baker_house : State
