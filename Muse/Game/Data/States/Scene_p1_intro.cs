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
[State("p1_intro")]
//CLASS Scene_p1_intro : State
public class Scene_p1_intro : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_intro
    public Scene_p1_intro (  ) {
        ///METHOD_BODY_START Scene_p1_intro
        Id = "p1_intro";
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_p1_intro
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p1_prologue");
        yield return Actions.LoadScene("p1_quarters");
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_p1_intro : State
