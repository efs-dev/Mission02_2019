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
[State("p1_map", "yardHotspot", "quartersHotspot", "map_plantation_night", "map_plantation_2k", "map_plantation", "iceHouseHotspot", "hogPenHotspot", "hempRightHotspot", "hempLeftHotspot", "hempBreaksHotspot", "hempBotHotspot", "creekHotspot", "cornfieldHotspot", "chickenCoopHotspot", "bigHouseHotspot")]
//CLASS Scene_p1_map : State
public class Scene_p1_map : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_map
    public Scene_p1_map (  ) {
        ///METHOD_BODY_START Scene_p1_map
        Id = "p1_map";
        OnHotspotClickBlocking.Add("bigHouseHotspot", OnbigHouseHotspotClickCallback);
        OnHotspotClickBlocking.Add("chickenCoopHotspot", OnchickenCoopHotspotClickCallback);
        OnHotspotClickBlocking.Add("cornfieldHotspot", OncornfieldHotspotClickCallback);
        OnHotspotClickBlocking.Add("creekHotspot", OncreekHotspotClickCallback);
        OnHotspotClickBlocking.Add("hempBotHotspot", OnhempBotHotspotClickCallback);
        OnHotspotClickBlocking.Add("hempBreaksHotspot", OnhempBreaksHotspotClickCallback);
        OnHotspotClickBlocking.Add("hempLeftHotspot", OnhempLeftHotspotClickCallback);
        OnHotspotClickBlocking.Add("hempRightHotspot", OnhempRightHotspotClickCallback);
        OnHotspotClickBlocking.Add("hogPenHotspot", OnhogPenHotspotClickCallback);
        OnHotspotClickBlocking.Add("iceHouseHotspot", OniceHouseHotspotClickCallback);
        OnHotspotClickBlocking.Add("quartersHotspot", OnquartersHotspotClickCallback);
        OnHotspotClickBlocking.Add("yardHotspot", OnyardHotspotClickCallback);
        ///METHOD_BODY_END Scene_p1_map
    }

    ///METHOD OnbigHouseHotspotClickCallback
    public IEnumerator OnbigHouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnbigHouseHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_big_house);
        ///METHOD_BODY_END OnbigHouseHotspotClickCallback
    }

    ///METHOD OnchickenCoopHotspotClickCallback
    public IEnumerator OnchickenCoopHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnchickenCoopHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_chicken_coop);
        ///METHOD_BODY_END OnchickenCoopHotspotClickCallback
    }

    ///METHOD OncornfieldHotspotClickCallback
    public IEnumerator OncornfieldHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OncornfieldHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_cornfield);
        ///METHOD_BODY_END OncornfieldHotspotClickCallback
    }

    ///METHOD OncreekHotspotClickCallback
    public IEnumerator OncreekHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OncreekHotspotClickCallback
        if (GameFlags.P1CreekVisits == 0){
        	GameFlags.P1CreekVisits++;
        	yield return Actions.LoadScene("p1_creek");
        }
        else if (GameFlags.P1CreekVisits == 1){
        	// TODO: replace the above task with a quest-related conditional
        	GameFlags.P1CreekVisits++;
        	yield return Actions.DialogOpenBlocking("p1_wash_creek");
        }
        else{
        	yield return Actions.OpenPopupBlocking(PopupIds.p1_creek);
        }
        ///METHOD_BODY_END OncreekHotspotClickCallback
    }

    ///METHOD OnhempBotHotspotClickCallback
    public IEnumerator OnhempBotHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnhempBotHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_hemp_bot);
        ///METHOD_BODY_END OnhempBotHotspotClickCallback
    }

    ///METHOD OnhempBreaksHotspotClickCallback
    public IEnumerator OnhempBreaksHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnhempBreaksHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_hemp_break);
        ///METHOD_BODY_END OnhempBreaksHotspotClickCallback
    }

    ///METHOD OnhempLeftHotspotClickCallback
    public IEnumerator OnhempLeftHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnhempLeftHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_hemp_left);
        ///METHOD_BODY_END OnhempLeftHotspotClickCallback
    }

    ///METHOD OnhempRightHotspotClickCallback
    public IEnumerator OnhempRightHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnhempRightHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_hemp_right);
        ///METHOD_BODY_END OnhempRightHotspotClickCallback
    }

    ///METHOD OnhogPenHotspotClickCallback
    public IEnumerator OnhogPenHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnhogPenHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_hog_pen);
        ///METHOD_BODY_END OnhogPenHotspotClickCallback
    }

    ///METHOD OniceHouseHotspotClickCallback
    public IEnumerator OniceHouseHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OniceHouseHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_icehouse);
        ///METHOD_BODY_END OniceHouseHotspotClickCallback
    }

    ///METHOD OnquartersHotspotClickCallback
    public IEnumerator OnquartersHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnquartersHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_no_back_to_quarters);
        ///METHOD_BODY_END OnquartersHotspotClickCallback
    }

    ///METHOD OnyardHotspotClickCallback
    public IEnumerator OnyardHotspotClickCallback ( State Scene ) {
        ///METHOD_BODY_START OnyardHotspotClickCallback
        yield return Actions.OpenPopupBlocking(PopupIds.p1_yard2);
        ///METHOD_BODY_END OnyardHotspotClickCallback
    }
}
//CLASS_END Scene_p1_map : State
