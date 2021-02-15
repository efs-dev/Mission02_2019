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
[State("map_greenwood", "starling_home", "st_francis", "renos_cafe", "player", "map_up")]
//CLASS Scene_map_greenwood : State
public class Scene_map_greenwood : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_map_greenwood
    public Scene_map_greenwood (  ) {
        ///METHOD_BODY_START Scene_map_greenwood
        Id = "map_greenwood";
        Modules.Add("p1");
        OnShow = OnShowCallback;
        OnHotspotClickBlocking.Add("map_up", Onmap_upClickCallback);
        ///METHOD_BODY_END Scene_map_greenwood
    }

    ///METHOD OnShowCallback
    public void OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        GlobalScripts.AddTime(0);
        
        
        ///METHOD_BODY_END OnShowCallback
    }

    ///METHOD Onmap_upClickCallback
    public IEnumerator Onmap_upClickCallback ( State Scene ) {
        ///METHOD_BODY_START Onmap_upClickCallback
        yield return Actions.MoveToHotspotBlocking("player", "map_up", 3.0f, 1.0f, 1.0f);
        yield return Actions.LoadScene("map_greenwood_uptown");
        ///METHOD_BODY_END Onmap_upClickCallback
    }
}
//CLASS_END Scene_map_greenwood : State
