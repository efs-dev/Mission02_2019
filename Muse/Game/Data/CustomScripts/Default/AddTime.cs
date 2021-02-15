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
    ///METHOD AddTime
    public static void AddTime ( int minutes ) {
        ///METHOD_BODY_START AddTime
        var MapDisplayHours = 0;
        
        GameFlags.MapMinutes = GameFlags.MapMinutes + minutes;
        
        GameFlags.MapHours = GameFlags.MapMinutes/60;
        MapDisplayHours = GameFlags.MapHours;
        
        if (MapDisplayHours > 12)
        MapDisplayHours = MapDisplayHours - 12;
        
        GameFlags.MapDisplayMinutes = GameFlags.MapMinutes % 60;
        
        if (GameFlags.MapDisplayMinutes < 10)
             SceneResources.FindComponent<TMPro.TextMeshPro>("time").text = MapDisplayHours+":"+"0"+GameFlags.MapDisplayMinutes;
        else
             SceneResources.FindComponent<TMPro.TextMeshPro>("time").text = MapDisplayHours+":"+GameFlags.MapDisplayMinutes;
        
        
        
        
        ///METHOD_BODY_END AddTime
    }
}
//CLASS_END GlobalScripts
