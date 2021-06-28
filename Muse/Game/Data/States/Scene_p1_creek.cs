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
[State("p1_creek")]
//CLASS Scene_p1_creek : State
public class Scene_p1_creek : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_creek
    public Scene_p1_creek (  ) {
        ///METHOD_BODY_START Scene_p1_creek
        Id = "p1_creek";
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_p1_creek
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p1_ovr_001");
        yield return Actions.LoadScene("p1_map");
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_p1_creek : State
