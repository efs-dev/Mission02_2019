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
[State("p1_yard")]
//CLASS Scene_p1_yard : State
public class Scene_p1_yard : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_yard
    public Scene_p1_yard (  ) {
        ///METHOD_BODY_START Scene_p1_yard
        Id = "p1_yard";
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_p1_yard
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p1_jon_001");
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_p1_yard : State
