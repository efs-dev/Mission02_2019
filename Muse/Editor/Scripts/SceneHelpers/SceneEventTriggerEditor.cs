using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Linq;

namespace Muse.Editors.SceneHelpers
{

    [CustomEditor(typeof(SceneEventTriggers))]
    public class SceneEventTriggerInspectorEditor : Editor
    {

        void OnEnable()
        {
        }

        public override void OnInspectorGUI()
        {
            var sceneLinker = (SceneEventTriggers)target;

            var duplicateId = false;
            var ids = new List<string>();
            for (var i = 0; i < sceneLinker.Entries.Count; i++)
            {
                var entry = sceneLinker.Entries[i];

                if (ids.Contains(entry.Id))
                {
                    duplicateId = true;
                    break;
                }

                ids.Add(entry.Id);
            }

            if (!duplicateId)
                EditorGUILayout.HelpBox("Create events (such as animations) which will be called through scripting.", MessageType.Info);
            else
                EditorGUILayout.HelpBox("Create events (such as animations) which will be called through scripting.\n\nEvents should have unique ids ... fix this!", MessageType.Error);

            serializedObject.Update();
            SerializedProperty entries = serializedObject.FindProperty("Entries"); // <-- UnityEvent
            
            if (GUILayout.Button("Add Event", EditorStyles.toolbarButton, GUILayout.Width(250)))
            {
                Undo.RecordObject(sceneLinker, "Added SceneStateLinker Event");
                sceneLinker.Entries.Add(new SceneEventTriggerEntry());
            }
           

            GUILayout.Space(10);

            for (var i = 0; i < sceneLinker.Entries.Count; i++)
            {
                var entry = sceneLinker.Entries[i];

                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(Screen.width - 40));
                EditorGUILayout.BeginHorizontal();

                SerializedProperty id = serializedObject.FindProperty("Entries.Array.data[" + i + "].Id");

                //Debug.Log("prop id: " + id);

                EditorGUILayout.PropertyField(id, new GUIContent("Id:"));
                //entry.Id = EditorGUILayout.TextField("Id:", entry.Id);
                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                {
                    sceneLinker.Entries.Remove(entry);
                    i--;
                    continue;
                }
                EditorGUILayout.EndHorizontal();
                while (entries.type != "UnityEvent")
                    entries.NextVisible(true);
                EditorGUILayout.PropertyField(entries);
                EditorGUILayout.EndVertical();
                GUILayout.Space(10);
                entries.NextVisible(true);
            }

            serializedObject.ApplyModifiedProperties();


            GUILayout.Space(25);
        }
    }
}