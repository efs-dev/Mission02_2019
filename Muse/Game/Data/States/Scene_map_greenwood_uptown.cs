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
[State("map_greenwood_uptown", "woolworths", "w1", "player", "greyhound", "goldbergs", "crystal_grill", "cotton_row", "city_hall")]
//CLASS Scene_map_greenwood_uptown : State
public class Scene_map_greenwood_uptown : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_map_greenwood_uptown
    public Scene_map_greenwood_uptown (  ) {
        ///METHOD_BODY_START Scene_map_greenwood_uptown
        Id = "map_greenwood_uptown";
        Modules.Add("p1");
        OnShowBlocking = OnShowCallback;
        OnHotspotClickBlocking.Add("goldbergs", OngoldbergsClickCallback);
        ///METHOD_BODY_END Scene_map_greenwood_uptown
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        GlobalScripts.AddTime(22);
        yield return Actions.MoveToHotspotBlocking("player", "w1", 1.0f, 1.0f, 1.0f);
        
        ///METHOD_BODY_END OnShowCallback
    }

    ///METHOD OngoldbergsClickCallback
    public IEnumerator OngoldbergsClickCallback ( State Scene ) {
        ///METHOD_BODY_START OngoldbergsClickCallback
        yield return Actions.MoveToHotspotBlocking("player", "goldbergs", 3.0f, 1.0f, 1.0f);
        yield return Actions.DialogOpenBlocking("p1_map_goldbergs");
        GlobalScripts.AddTime(17);
        ///METHOD_BODY_END OngoldbergsClickCallback
    }
}
//CLASS_END Scene_map_greenwood_uptown : State
