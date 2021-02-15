//a hierarchy colorization tool to ease finding things in the Unity Hierarchy
//

#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Muse.Editors.Hierarchy
{

    //[InitializeOnLoad]
    static public class HierarchyEditor
    {


        static HierarchyEditor()
        {
            EditorApplication.hierarchyWindowItemOnGUI -= InspectHierarchyItem;
            EditorApplication.hierarchyWindowItemOnGUI += InspectHierarchyItem;
        }

        private static void InspectHierarchyItem(int instanceID, Rect selectionRect)
        {
            //var idInFile = EditorUtility.InstanceIDToObject(instanceID)
            if (!EditorApplication.isPlaying)
            {
                //http://forum.unity3d.com/threads/how-to-get-the-local-identifier-in-file-for-scene-objects.265686/
                //var so = new SerializedObject(EditorUtility.InstanceIDToObject(instanceID));
                //typeof(SerializedObject).GetProperty("inspectorMode", BindingFlags.NonPublic | BindingFlags.Instance)
                //	.SetValue(so, InspectorMode.Debug, null);



                var color = Color.red;
                color.a = 0.25f;
                GUI.backgroundColor = color;
                //	GUI.Box(selectionRect, "");
                GUI.backgroundColor = Color.white;
            }
        }
    }
#endif
}