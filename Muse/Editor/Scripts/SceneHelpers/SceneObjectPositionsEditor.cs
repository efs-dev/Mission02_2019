using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Linq;

namespace Muse.Editors.SceneHelpers
{
    [CustomEditor(typeof(SceneObjectPositions))]
    public class SceneObjectPositionsInspectorEditor : Editor
    {
        private RenderTexture _renderTexture;

        void OnEnable()
        {
        }

        public override void OnInspectorGUI()
        {
            if (_renderTexture == null)
                _renderTexture = new RenderTexture(130, 100, 24, RenderTextureFormat.ARGB32);

            var objPositions = (SceneObjectPositions)target;

            EditorGUILayout.HelpBox("Create object positions which can be tweened between.", MessageType.None);

            GUILayout.Space(5);
            if (GUILayout.Button("Create", EditorStyles.toolbarButton, GUILayout.Width(200)))
            {
                var objPos = new SceneObjectPositions.SceneObjectPositionEntry();
                objPositions.Entries.Add(objPos);
            }

            GUILayout.Space(5);

            for (var i = 0; i < objPositions.Entries.Count; i++)
            {
                var objPos = objPositions.Entries[i];

                Rect rect;
                EditorGUILayout.BeginVertical(EditorStyles.toolbar);
                GUILayout.Space(5);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Id:", GUILayout.Width(25));
                var id = EditorGUILayout.TextField(objPos.Id);
                if (id != objPos.Id)
                {
                    Undo.RecordObject(objPositions, "SceneObjectPosition Id");
                    objPos.Id = id;
                }

                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                {
                    objPositions.Entries.Remove(objPos);
                    i--;
                    continue;
                }

                rect = GUILayoutUtility.GetLastRect();
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();

                if (objPos.Target != null)
                {
                    var oldPos = objPos.Target.position;
                    var oldRot = objPos.Target.eulerAngles;
                    var oldScale = objPos.Target.localScale;

                    objPos.Target.position = objPos.Position;
                    objPos.Target.eulerAngles = objPos.Rotation;
                    objPos.Target.localScale = objPos.Scale;

                    var oldTargetTexture = Camera.main.targetTexture;
                    Camera.main.targetTexture = _renderTexture;
                    Camera.main.Render();
                    GUI.DrawTexture(new Rect(50, rect.y + 25, _renderTexture.width, _renderTexture.height), Camera.main.targetTexture);
                    Camera.main.targetTexture = oldTargetTexture;

                    objPos.Target.position = oldPos;
                    objPos.Target.eulerAngles = oldRot;
                    objPos.Target.localScale = oldScale;
                }
                

                GUILayout.Space(50 + _renderTexture.width);
                EditorGUILayout.BeginVertical();
                GUILayout.Space(10);

                objPos.Target = (Transform) EditorGUILayout.ObjectField(objPos.Target, typeof(Transform), true);

                if (objPos.Target != null)
                {
                    objPos.Position = EditorGUILayout.Vector3Field("Position:", objPos.Position);
                    objPos.Rotation = EditorGUILayout.Vector3Field("Rotation:", objPos.Rotation);
                    objPos.Scale = EditorGUILayout.Vector3Field("Scale:", objPos.Scale);
                }

                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();


                GUILayout.Space(30);

                EditorGUILayout.BeginHorizontal();

                if (objPos.Target != null)
                {
                    if (GUILayout.Button("Save From Object", EditorStyles.toolbarButton))
                    {
                        objPos.Position = objPos.Target.position;
                        objPos.Rotation = objPos.Target.eulerAngles;
                        objPos.Scale = objPos.Target.localScale;
                    }
                    if (GUILayout.Button("Apply To Object", EditorStyles.toolbarButton))
                    {
                        objPos.Target.position = objPos.Position;
                        objPos.Target.eulerAngles = objPos.Rotation;
                        objPos.Target.localScale = objPos.Scale;
                    }
                }
                
                EditorGUILayout.EndHorizontal();

                GUILayout.Space(5);
                //GUILayout.Space(_renderTexture.height-25);
                EditorGUILayout.EndVertical();

            }
            

            GUILayout.Space(5);
        }
    }
}