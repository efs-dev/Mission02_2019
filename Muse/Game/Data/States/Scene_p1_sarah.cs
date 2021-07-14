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
[State("p1_sarah", "Sarah")]
//CLASS Scene_p1_sarah : State
public class Scene_p1_sarah : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_sarah
    public Scene_p1_sarah (  ) {
        ///METHOD_BODY_START Scene_p1_sarah
        Id = "p1_sarah";
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_p1_sarah
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p1_sar_001");
        yield return Actions.DialogOpenBlocking("p1_dress_fix");
        yield return Actions.DialogOpenBlocking("p1_sar_002");
        yield return Actions.LoadScene("p1_big_house_kitchen");
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_p1_sarah : State
