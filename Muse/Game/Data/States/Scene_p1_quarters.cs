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
[State("p1_quarters", "yourHouseHotspot", "yardHotspot", "toMap", "smokehouseHotspot", "henrysHouseHotspot", "gardenHotspot", "bigHouseHotspot")]
//CLASS Scene_p1_quarters : State
public class Scene_p1_quarters : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_quarters
    public Scene_p1_quarters (  ) {
        ///METHOD_BODY_START Scene_p1_quarters
        Id = "p1_quarters";
        OnShowBlocking = OnShowCallback;
        OnHotspotClickBlocking.Add("bigHouseHotspot", OnbigHouseHotspotClickCallback);
        OnHotspotClickBlocking.Add("gardenHotspot", OngardenHotspotClickCallback);
        OnHotspotClickBlocking.Add("henrysHouseHotspot", OnhenrysHouseHotspotClickCallback);
        OnHotspotClickBlocking.Add("smokehouseHotspot", OnsmokehouseHotspotClickCallback);
        OnHotspotClickBlocking.Add("toMap", OntoMapClickCallback);
        OnHotspotClickBlocking.Add("yardHotspot", OnyardHotspotClickCallback);
        OnHotspotClickBlocking.Add("yourHouseHotspot", OnyourHouseHotspotClickCallback);
        ///METHOD_BODY_END Scene_p1_quarters
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p1_mom_001","n04");
        ///METHOD_BODY_END OnShowCallback
    }

    ///METHOD OnbigHouseHotspotClickCallback
    public IEnumerator OnbigHouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnbigHouseHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_big_house);
        ///METHOD_BODY_END OnbigHouseHotspotClickCallback
    }

    ///METHOD OngardenHotspotClickCallback
    public IEnumerator OngardenHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OngardenHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_community_garden);
        ///METHOD_BODY_END OngardenHotspotClickCallback
    }

    ///METHOD OnhenrysHouseHotspotClickCallback
    public IEnumerator OnhenrysHouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnhenrysHouseHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_henrys_house);
        ///METHOD_BODY_END OnhenrysHouseHotspotClickCallback
    }

    ///METHOD OnsmokehouseHotspotClickCallback
    public IEnumerator OnsmokehouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnsmokehouseHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_smokehouse);
        ///METHOD_BODY_END OnsmokehouseHotspotClickCallback
    }

    ///METHOD OntoMapClickCallback
    public IEnumerator OntoMapClickCallback ( State Scene ) {
        ///METHOD_BODY_START OntoMapClickCallback
        yield return Actions.LoadScene("p1_map");
        ///METHOD_BODY_END OntoMapClickCallback
    }

    ///METHOD OnyardHotspotClickCallback
    public IEnumerator OnyardHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnyardHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_yard);
        ///METHOD_BODY_END OnyardHotspotClickCallback
    }

    ///METHOD OnyourHouseHotspotClickCallback
    public IEnumerator OnyourHouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnyourHouseHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_your_house);
        ///METHOD_BODY_END OnyourHouseHotspotClickCallback
    }
}
//CLASS_END Scene_p1_quarters : State
