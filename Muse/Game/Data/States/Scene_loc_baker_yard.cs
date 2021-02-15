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
[State("loc_baker_yard")]
//CLASS Scene_loc_baker_yard : State
public class Scene_loc_baker_yard : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_loc_baker_yard
    public Scene_loc_baker_yard (  ) {
        ///METHOD_BODY_START Scene_loc_baker_yard
        Id = "loc_baker_yard";
        Modules.Add("prologue");
        ///METHOD_BODY_END Scene_loc_baker_yard
    }
}
//CLASS_END Scene_loc_baker_yard : State
