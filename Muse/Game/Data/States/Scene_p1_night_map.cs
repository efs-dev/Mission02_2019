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
[State("p1_night_map", "map_plantation_night")]
//CLASS Scene_p1_night_map : State
public class Scene_p1_night_map : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_night_map
    public Scene_p1_night_map (  ) {
        ///METHOD_BODY_START Scene_p1_night_map
        Id = "p1_night_map";
        ///METHOD_BODY_END Scene_p1_night_map
    }
}
//CLASS_END Scene_p1_night_map : State
