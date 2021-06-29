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
[State("p1_after_fire")]
//CLASS Scene_p1_after_fire : State
public class Scene_p1_after_fire : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_after_fire
    public Scene_p1_after_fire (  ) {
        ///METHOD_BODY_START Scene_p1_after_fire
        Id = "p1_after_fire";
        ///METHOD_BODY_END Scene_p1_after_fire
    }
}
//CLASS_END Scene_p1_after_fire : State
