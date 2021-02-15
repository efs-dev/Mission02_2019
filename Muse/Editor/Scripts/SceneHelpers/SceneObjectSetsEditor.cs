using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Linq;

namespace Muse.Editors.SceneHelpers
{
    [CustomEditor(typeof(SceneObjectSets))]
    public class SceneObjectSetsInspectorEditor : Editor
    {
        private RenderTexture _renderTexture;

        void OnEnable()
        {
        }

        public override void OnInspectorGUI()
        {
            if (_renderTexture == null)
                _renderTexture = new RenderTexture(130, 100, 24, RenderTextureFormat.ARGB32);

            var objects = (SceneObjectSets)target;

            EditorGUILayout.HelpBox("Create object sets which can be activated through script.", MessageType.None);

            GUILayout.Space(5);
            if (GUILayout.Button("Create", EditorStyles.toolbarButton, GUILayout.Width(200)))
            {
                var obj = new SceneObjectSetEntry();
                objects.Entries.Add(obj);
            }

            GUILayout.Space(5);

            for (var i = 0; i < objects.Entries.Count; i++)
            {
                var obj = objects.Entries[i];

                Rect rect;
                EditorGUILayout.BeginVertical(EditorStyles.toolbar);
                GUILayout.Space(5);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Id:", GUILayout.Width(25));
                var id = EditorGUILayout.TextField(obj.Id);
                if (id != obj.Id)
                {
                    Undo.RecordObject(objects, "SceneObjectSet Id");
                    obj.Id = id;
                }

                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                {
                    objects.Entries.Remove(obj);
                    i--;
                    continue;
                }

                rect = GUILayoutUtility.GetLastRect();
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();

                var targets = new Dictionary<GameObject, bool>();


                for (var j = 0; j < obj.ActiveTargets.Count; j++)
                {
                    var target = obj.ActiveTargets[j];
                    if (target != null)
                        targets.Add(target, target.activeSelf);
                }

                for (var j = 0; j < obj.InactiveTargets.Count; j++)
                {
                    var target = obj.InactiveTargets[j];
                    if (target != null)
                        targets.Add(target, target.activeSelf);
                }

                obj.Execute();

                var oldTargetTexture = Camera.main.targetTexture;
                Camera.main.targetTexture = _renderTexture;
                Camera.main.Render();
                GUI.DrawTexture(new Rect(50, rect.y + 25, _renderTexture.width, _renderTexture.height), Camera.main.targetTexture);
                Camera.main.targetTexture = oldTargetTexture;

                foreach (var target in targets.Keys)
                {
                    target.SetActive(targets[target]);
                }

                GUILayout.Space(50 + _renderTexture.width);
                EditorGUILayout.BeginVertical();
                GUILayout.Space(10);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(175));
                if (GUILayout.Button("Add Visible Object", EditorStyles.toolbarButton))
                {
                    obj.ActiveTargets.Add(null);
                }
                for (var j = 0; j < obj.ActiveTargets.Count; j++)
                {
                    EditorGUILayout.BeginHorizontal();
                    obj.ActiveTargets[j] = (GameObject) EditorGUILayout.ObjectField(obj.ActiveTargets[j], typeof(GameObject), true);
                    if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                    {
                        obj.ActiveTargets.RemoveAt(j);
                        j--;
                        continue;
                    }
                    EditorGUILayout.EndHorizontal();
                }
                GUILayout.FlexibleSpace();
                EditorGUILayout.EndVertical();
                GUILayout.Space(25);
                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(175));
                if (GUILayout.Button("Add Invisible Object", EditorStyles.toolbarButton))
                {
                    obj.InactiveTargets.Add(null);
                }
                for (var j = 0; j < obj.InactiveTargets.Count; j++)
                {
                    EditorGUILayout.BeginHorizontal();
                    obj.InactiveTargets[j] = (GameObject)EditorGUILayout.ObjectField(obj.InactiveTargets[j], typeof(GameObject), true);
                    if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                    {
                        obj.InactiveTargets.RemoveAt(j);
                        j--;
                        continue;
                    }
                    EditorGUILayout.EndHorizontal();
                }



                GUILayout.FlexibleSpace();
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();

                //GUILayout.Space(_renderTexture.height-25);
                GUILayout.Space(18 + 18 * (Mathf.Max(0, 5 - Mathf.Max(obj.ActiveTargets.Count, obj.InactiveTargets.Count))));
                EditorGUILayout.EndVertical();

            }
            

            GUILayout.Space(5);
        }
    }
}