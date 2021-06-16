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
[State("loc_auction")]
//CLASS Scene_loc_auction : State
public class Scene_loc_auction : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_loc_auction
    public Scene_loc_auction (  ) {
        ///METHOD_BODY_START Scene_loc_auction
        Id = "loc_auction";
        Modules.Add("p5");
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_loc_auction
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p4_auc_001");
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_loc_auction : State
