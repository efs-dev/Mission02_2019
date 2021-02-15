using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Linq;
using UnityEngine.Timeline;
using UnityEngine.Playables;

namespace Muse.Editors.SceneHelpers
{
    [CustomEditor(typeof(SceneTimelines))]
    public class SceneTimelinesInspectorEditor : Editor
    {

        void OnEnable()
        {
        }

        public override void OnInspectorGUI()
        {
            var st = (SceneTimelines)target;

            EditorGUILayout.HelpBox("Create timelines that can be called from script.", MessageType.None);

            GUILayout.Space(5);
            if (GUILayout.Button("Create", EditorStyles.toolbarButton, GUILayout.Width(200)))
            {
                var ste = new SceneTimelines.SceneTimelineEntry();
                st.Entries.Add(ste);

                //var timeline = new TimelineAsset();
                //Debug.Log(timeline); 
               // var go = new GameObject();
               // go.transform.SetParent(st.transform);
                //go.name = "SceneTimeline - ";
               // go.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
                //var dir = go.AddComponent<PlayableDirector>();
                //dir.playableAsset = timeline;

                //ste.InternalTimeline = dir;
                //ste.Timeline = dir;
            }

            for (var i = 0; i < st.Entries.Count; i++)
            {
                var ste = st.Entries[i];

                EditorGUILayout.BeginVertical(EditorStyles.toolbar);
                GUILayout.Space(5);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Id:", GUILayout.Width(25));
                var id = EditorGUILayout.TextField(ste.Id);
                if (id != ste.Id)
                {
                    Undo.RecordObject(st, "SceneTimelines Id");
                    ste.Id = id;
                    //ste.Timeline.name = "SceneTimeline - " + id;
                }

                if (GUILayout.Button("Edit", EditorStyles.toolbarButton, GUILayout.Width(50)))
                {
                    if (ste.Timeline != null)
                        Selection.activeGameObject = ste.Timeline.gameObject;
                }
                ste.CustomTimeline = (PlayableDirector) EditorGUILayout.ObjectField(ste.CustomTimeline, typeof(PlayableDirector), true);

                if (ste.CustomTimeline != null)
                    ste.Timeline = ste.CustomTimeline;
                else
                    ste.Timeline = ste.InternalTimeline;

                /*GUI.backgroundColor = ste.AutoStart ? Color.yellow : Color.white;
                if (GUILayout.Button("Auto Start", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    ste.AutoStart = !ste.AutoStart;
                }
                GUI.backgroundColor = Color.white;
                */

                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                {
                    st.Entries.Remove(ste);
                    DestroyImmediate(ste.Timeline.gameObject);
                    i--;
                    continue;
                }
                
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(5);
                EditorGUILayout.EndVertical();
            }

            GUILayout.Space(5);
        }
    }
}