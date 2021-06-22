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
[State("p1_map", "map_plantation_night", "map_plantation_2k", "map_plantation")]
//CLASS Scene_p1_map : State
public class Scene_p1_map : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_map
    public Scene_p1_map (  ) {
        ///METHOD_BODY_START Scene_p1_map
        Id = "p1_map";
        ///METHOD_BODY_END Scene_p1_map
    }
}
//CLASS_END Scene_p1_map : State
