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
[State("anim_prologue")]
//CLASS Scene_anim_prologue : State
public class Scene_anim_prologue : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_anim_prologue
    public Scene_anim_prologue (  ) {
        ///METHOD_BODY_START Scene_anim_prologue
        Id = "anim_prologue";
        Modules.Add("prologue");
        ///METHOD_BODY_END Scene_anim_prologue
    }
}
//CLASS_END Scene_anim_prologue : State
