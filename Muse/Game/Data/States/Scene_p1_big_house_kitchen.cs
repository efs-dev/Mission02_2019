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
[State("p1_big_house_kitchen")]
//CLASS Scene_p1_big_house_kitchen : State
public class Scene_p1_big_house_kitchen : State {
    //CLASS SceneScriptsClass
    public class SceneScriptsClass {
    }
    //CLASS_END SceneScriptsClass

    //PROPERTY Scripts
    private SceneScriptsClass Scripts = new SceneScriptsClass();

    ///METHOD Scene_p1_big_house_kitchen
    public Scene_p1_big_house_kitchen (  ) {
        ///METHOD_BODY_START Scene_p1_big_house_kitchen
        Id = "p1_big_house_kitchen";
        OnShowBlocking = OnShowCallback;
        ///METHOD_BODY_END Scene_p1_big_house_kitchen
    }

    ///METHOD OnShowCallback
    public IEnumerator OnShowCallback ( State Scene ) {
        ///METHOD_BODY_START OnShowCallback
        if (!GameFlags.P1SpokeEstherOnce){
        	GameFlags.P1SpokeEstherOnce = true;
        yield return Actions.DialogOpenBlocking("p1_est_001");
        yield return Actions.LoadScene("p1_sarah");
        }
        else{
        	yield return Actions.DialogOpenBlocking("p1_est_002");
        	yield return Actions.OpenPopupBlocking(PopupIds.placeholder_fire);
        	yield return Actions.LoadScene("p1_after_fire");
        }
        ///METHOD_BODY_END OnShowCallback
    }
}
//CLASS_END Scene_p1_big_house_kitchen : State
