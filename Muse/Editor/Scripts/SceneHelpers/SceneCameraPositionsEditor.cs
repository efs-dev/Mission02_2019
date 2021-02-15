using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Linq;

namespace Muse.Editors.SceneHelpers
{
    [CustomEditor(typeof(SceneCameraPositions))]
    public class SceneCameraPositionsInspectorEditor : Editor
    {
        private RenderTexture _renderTexture;

        void OnEnable()
        {
        }

        public override void OnInspectorGUI()
        {
            if (_renderTexture == null)
                _renderTexture = new RenderTexture(130, 100, 24, RenderTextureFormat.ARGB32);

            var camPositions = (SceneCameraPositions)target;

            EditorGUILayout.HelpBox("Create camera views which can be tweened between.", MessageType.None);

            GUILayout.Space(5);
            if (GUILayout.Button("Create", EditorStyles.toolbarButton, GUILayout.Width(200)))
            {
                var camPos = new SceneCameraPositionEntry();
                camPos.Camera = new GameObject().AddComponent<Camera>();
                camPos.Camera.gameObject.hideFlags = HideFlags.HideInHierarchy;
                camPos.Camera.gameObject.SetActive(false);
                camPositions.CameraEntries.Add(camPos);
            }

            GUILayout.Space(5);

            for (var i = 0; i < camPositions.CameraEntries.Count; i++)
            {
                var camPos = camPositions.CameraEntries[i];

                Rect rect;
                EditorGUILayout.BeginVertical(EditorStyles.toolbar);
                GUILayout.Space(5);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Id:", GUILayout.Width(25));
                var id = EditorGUILayout.TextField(camPos.Id);
                if (id != camPos.Id)
                {
                    Undo.RecordObject(camPositions, "SceneCameraPosition Id");
                    camPos.Id = id;
                }

                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                {
                    camPositions.CameraEntries.Remove(camPos);
                    i--;
                    continue;
                }

                rect = GUILayoutUtility.GetLastRect();
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                camPos.Camera.targetTexture = _renderTexture;

                camPos.Camera.Render();

                GUI.DrawTexture(new Rect(50, rect.y + 25, _renderTexture.width, _renderTexture.height), camPos.Camera.targetTexture);
                GUILayout.Space(50 + _renderTexture.width);
                EditorGUILayout.BeginVertical();
                GUILayout.Space(10);

                camPos.Camera.transform.position = EditorGUILayout.Vector3Field("Position:", camPos.Camera.transform.position);
                camPos.Camera.transform.eulerAngles = EditorGUILayout.Vector3Field("Rotation:", camPos.Camera.transform.eulerAngles);
                camPos.Camera.transform.localScale = EditorGUILayout.Vector3Field("Scale:", camPos.Camera.transform.eulerAngles);
                camPos.Camera.orthographic = EditorGUILayout.Toggle("Orthographic:", camPos.Camera.orthographic);
                camPos.Camera.orthographicSize = EditorGUILayout.FloatField("Orthographic Size:", camPos.Camera.orthographicSize);
                camPos.Camera.fieldOfView = EditorGUILayout.FloatField("Field of View:", camPos.Camera.fieldOfView);
                camPos.Camera.nearClipPlane = EditorGUILayout.FloatField("Near Clip Plane:", camPos.Camera.nearClipPlane);
                camPos.Camera.farClipPlane = EditorGUILayout.FloatField("Far Clip Plane:", camPos.Camera.farClipPlane);

                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();


                GUILayout.Space(10);

                EditorGUILayout.BeginHorizontal();

                if (GUILayout.Button("Save From Main Camera", EditorStyles.toolbarButton))
                {
                    var cam = Camera.main;
                    camPos.Camera.transform.position = cam.transform.position;
                    camPos.Camera.transform.eulerAngles = cam.transform.eulerAngles;
                    camPos.Camera.transform.localScale = cam.transform.localScale;
                    camPos.Camera.orthographic = cam.orthographic;
                    camPos.Camera.orthographicSize = cam.orthographicSize;
                    camPos.Camera.fieldOfView = cam.fieldOfView;
                    camPos.Camera.nearClipPlane = cam.nearClipPlane;
                    camPos.Camera.farClipPlane = cam.farClipPlane;
                }
                if (GUILayout.Button("Apply To Main Camera", EditorStyles.toolbarButton))
                {
                    var cam = Camera.main;
                    cam.transform.position = camPos.Camera.transform.position;
                    cam.transform.eulerAngles = camPos.Camera.transform.eulerAngles;
                    cam.transform.localScale = camPos.Camera.transform.localScale;
                    cam.orthographic = camPos.Camera.orthographic;
                    cam.orthographicSize = camPos.Camera.orthographicSize;
                    cam.fieldOfView = camPos.Camera.fieldOfView;
                    cam.nearClipPlane = camPos.Camera.nearClipPlane;
                    cam.farClipPlane = camPos.Camera.farClipPlane;
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