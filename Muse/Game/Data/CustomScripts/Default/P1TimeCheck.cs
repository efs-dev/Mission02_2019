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
    ///METHOD P1TimeCheck
    public static IEnumerator P1TimeCheck (  ) {
        ///METHOD_BODY_START P1TimeCheck
        // If it's time for Master King to assign the smokehouse task, does so
        if (GameFlags.P1TotalTasks >= 8 && !GameFlags.P1SmokehouseAssigned){
        	GameFlags.P1SmokehouseAssigned = true;
        	yield return Actions.DialogOpenBlocking("p1_ovr_002");
        }
        
        ///METHOD_BODY_END P1TimeCheck
    }
}
//CLASS_END GlobalScripts
