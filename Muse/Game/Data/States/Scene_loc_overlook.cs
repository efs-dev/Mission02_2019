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
[State("loc_overlook", "sis", "CrkRbt")]
//CLASS Scene_loc_overlook : State
public class Scene_loc_overlook : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_loc_overlook
    public Scene_loc_overlook (  ) {
        ///METHOD_BODY_START Scene_loc_overlook
        Id = "loc_overlook";
        Modules.Add("p1");
        OnEnter = OnEnterCallback;
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_loc_overlook
    }

    ///METHOD OnEnterCallback
    public void OnEnterCallback ( State Scene ) {
        ///METHOD_BODY_START OnEnterCallback
        Actions.SetHotspotVisible("sis", false);
        Actions.SetHotspotVisible("CrkRbt", false);
        ///METHOD_BODY_END OnEnterCallback
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p0_rob_sal_001");
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_loc_overlook : State
