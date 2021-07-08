//USING
using UnityEngine;
//USING
using System;
//USING
using System.Linq;
//USING
using System.Collections;
//USING
using System.Collections.Generic;
//USING
using DG.Tweening;
//CLASS GlobalScripts
public static partial class GlobalScripts {
    ///METHOD P1NightMapAfterSpot
    public static IEnumerator P1NightMapAfterSpot ( string hotSpotName ) {
        ///METHOD_BODY_START P1NightMapAfterSpot
        if (GameFlags.P1NightLocationsVisited > 4){
             yield return Actions.LoadScene("p1_end");
        }
        Actions.SetHotspotVisible(hotSpotName,false);
        ///METHOD_BODY_END P1NightMapAfterSpot
    }
}
//CLASS_END GlobalScripts
