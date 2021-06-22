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
        OnHotspotClickBlocking.Add("toMap", OntoMapClickCallback);
        ///METHOD_BODY_END Scene_p1_quarters
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        yield return Actions.DialogOpenBlocking("p1_mom_001","n04");
        ///METHOD_BODY_END OnShowCallback
    }

    ///METHOD OntoMapClickCallback
    public IEnumerator OntoMapClickCallback ( State Scene ) {
        ///METHOD_BODY_START OntoMapClickCallback
        yield return Actions.LoadScene("p1_map");
        ///METHOD_BODY_END OntoMapClickCallback
    }
}
//CLASS_END Scene_p1_quarters : State
