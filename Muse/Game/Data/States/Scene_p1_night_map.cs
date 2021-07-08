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
[State("p1_night_map", "woodshedHotspot", "smokehouseHotspot", "pin_jon_2k", "map_plantation_night", "laundryHotspot", "kingsGardenHotspot", "henhouseHotspot")]
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
        OnHotspotClickBlocking.Add("henhouseHotspot", OnhenhouseHotspotClickCallback);
        OnHotspotClickBlocking.Add("kingsGardenHotspot", OnkingsGardenHotspotClickCallback);
        OnHotspotClickBlocking.Add("laundryHotspot", OnlaundryHotspotClickCallback);
        OnHotspotClickBlocking.Add("pin_jon_2k", Onpin_jon_2kClickCallback);
        OnHotspotClickBlocking.Add("smokehouseHotspot", OnsmokehouseHotspotClickCallback);
        OnHotspotClickBlocking.Add("woodshedHotspot", OnwoodshedHotspotClickCallback);
        ///METHOD_BODY_END Scene_p1_night_map
    }

    ///METHOD OnhenhouseHotspotClickCallback
    public IEnumerator OnhenhouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnhenhouseHotspotClickCallback
        GameFlags.P1NightLocationsVisited++;
        yield return GlobalScripts.P1NightMapAfterSpot("henhouseHotspot");
        ///METHOD_BODY_END OnhenhouseHotspotClickCallback
    }

    ///METHOD OnkingsGardenHotspotClickCallback
    public IEnumerator OnkingsGardenHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnkingsGardenHotspotClickCallback
        GameFlags.P1NightLocationsVisited++;
        yield return GlobalScripts.P1NightMapAfterSpot("kingsGardenHotspot");
        ///METHOD_BODY_END OnkingsGardenHotspotClickCallback
    }

    ///METHOD OnlaundryHotspotClickCallback
    public IEnumerator OnlaundryHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnlaundryHotspotClickCallback
        GameFlags.P1NightLocationsVisited++;
        yield return GlobalScripts.P1NightMapAfterSpot("laundryHotspot");
        ///METHOD_BODY_END OnlaundryHotspotClickCallback
    }

    ///METHOD Onpin_jon_2kClickCallback
    public IEnumerator Onpin_jon_2kClickCallback ( State Scene ) {
        ///METHOD_BODY_START Onpin_jon_2kClickCallback
        GameFlags.P1NightLocationsVisited++;
        yield return Actions.DialogOpenBlocking("p1_jon_002");
        yield return GlobalScripts.P1NightMapAfterSpot("pin_jon_2k");
        ///METHOD_BODY_END Onpin_jon_2kClickCallback
    }

    ///METHOD OnsmokehouseHotspotClickCallback
    public IEnumerator OnsmokehouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnsmokehouseHotspotClickCallback
        GameFlags.P1NightLocationsVisited++;
        yield return GlobalScripts.P1NightMapAfterSpot("smokehouseHotspot");
        ///METHOD_BODY_END OnsmokehouseHotspotClickCallback
    }

    ///METHOD OnwoodshedHotspotClickCallback
    public IEnumerator OnwoodshedHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnwoodshedHotspotClickCallback
        GameFlags.P1NightLocationsVisited++;
        yield return GlobalScripts.P1NightMapAfterSpot("woodshedHotspot");
        ///METHOD_BODY_END OnwoodshedHotspotClickCallback
    }
}
//CLASS_END Scene_p1_night_map : State
