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
[State("p1_yard", "woodshedHotspot", "washHotspot", "smokehouseHotspot", "jonahHotspot", "bigHouseHotspot")]
//CLASS Scene_p1_yard : State
public class Scene_p1_yard : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_yard
    public Scene_p1_yard (  ) {
        ///METHOD_BODY_START Scene_p1_yard
        Id = "p1_yard";
        OnHotspotClickBlocking.Add("bigHouseHotspot", OnbigHouseHotspotClickCallback);
        OnHotspotClickBlocking.Add("jonahHotspot", OnjonahHotspotClickCallback);
        OnHotspotClickBlocking.Add("smokehouseHotspot", OnsmokehouseHotspotClickCallback);
        OnHotspotClickBlocking.Add("washHotspot", OnwashHotspotClickCallback);
        OnHotspotClickBlocking.Add("woodshedHotspot", OnwoodshedHotspotClickCallback);
        ///METHOD_BODY_END Scene_p1_yard
    }

    ///METHOD OnbigHouseHotspotClickCallback
    public IEnumerator OnbigHouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnbigHouseHotspotClickCallback
        yield return Actions.LoadScene("p1_big_house_kitchen");
        ///METHOD_BODY_END OnbigHouseHotspotClickCallback
    }

    ///METHOD OnjonahHotspotClickCallback
    public IEnumerator OnjonahHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnjonahHotspotClickCallback
        yield return Actions.DialogOpenBlocking("p1_jon_001");
        ///METHOD_BODY_END OnjonahHotspotClickCallback
    }

    ///METHOD OnsmokehouseHotspotClickCallback
    public IEnumerator OnsmokehouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnsmokehouseHotspotClickCallback
        yield return Actions.DialogOpenBlocking("");
        ///METHOD_BODY_END OnsmokehouseHotspotClickCallback
    }

    ///METHOD OnwashHotspotClickCallback
    public IEnumerator OnwashHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnwashHotspotClickCallback
        yield return Actions.DialogOpenBlocking("p1_washing_basin_001");
        if (!GameFlags.CancelTask){
        	yield return Actions.DialogOpenBlocking("p1_wash_creek");
        yield return Actions.DialogOpenBlocking("p1_washing_basin_002");
        }
        else{
        	GameFlags.CancelTask = false;
        }
        yield return GlobalScripts.P1TimeCheck();
        ///METHOD_BODY_END OnwashHotspotClickCallback
    }

    ///METHOD OnwoodshedHotspotClickCallback
    public IEnumerator OnwoodshedHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnwoodshedHotspotClickCallback
        yield return Actions.DialogOpenBlocking("");
        ///METHOD_BODY_END OnwoodshedHotspotClickCallback
    }
}
//CLASS_END Scene_p1_yard : State
