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
[State("p5_auction")]
//CLASS Scene_p5_auction : State
public class Scene_p5_auction : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p5_auction
    public Scene_p5_auction (  ) {
        ///METHOD_BODY_START Scene_p5_auction
        Id = "p5_auction";
        Modules.Add("p5");
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_p5_auction
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p4_auc_001");
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_p5_auction : State
