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
[State("p1_end")]
//CLASS Scene_p1_end : State
public class Scene_p1_end : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_end
    public Scene_p1_end (  ) {
        ///METHOD_BODY_START Scene_p1_end
        Id = "p1_end";
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_p1_end
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.OpenPopupBlocking(PopupIds.placeholder_p1_end_anim);
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_p1_end : State
