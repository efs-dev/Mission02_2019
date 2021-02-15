using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using UnityEngine.Audio;
using System.Linq;
using UnityEditor.Callbacks;
using UnityEditor.SceneManagement;

namespace Muse.Editors.ActionsAPI
{
    public class ActionsEditorData : ScriptableObject
    {
        public Vector2 ScrollPos;

        public List<ActionsAttribute> Actions;
        public string SearchFilter = "";
    }

    public class ActionsEditor : EditorWindow
    {
        public static ActionsEditor Instance { get; private set; }
        
        public ActionsEditorData Data;


        [SerializeField]
        private Vector2 _scrollPosition;

        [MenuItem("Muse/Editors/Help/Actions")]
        static void Init()
        {
            var window = EditorWindow.GetWindow<ActionsEditor>();
            window.titleContent = new GUIContent("Actions");
            window.Show();

            Instance = window;
            window.Data = ScriptableObject.CreateInstance<ActionsEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "ActionsEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Reload();
        }

        [DidReloadScripts]
        static void OnReloadScripts()
        {
            var windows = Resources.FindObjectsOfTypeAll<ActionsEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];
            //Instance.Reload();
        }

        void OnDestroy()
        {
            Instance = null;
        }


        void Reload()
        {
            Data.Actions = Utils.GetMethodAttributeTypesWith<ActionsAttribute>(typeof(Actions), true).ToList();
            Debug.Log(Data.Actions);
        }

        void OnGUI()
        {
            if (Data == null)
                Init();

            Instance = this;

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Search:", GUILayout.Width(150));
            Data.SearchFilter = EditorGUILayout.TextField(Data.SearchFilter);
            EditorGUILayout.EndHorizontal();
            GUILayout.Space(25);
            Data.ScrollPos = EditorGUILayout.BeginScrollView(Data.ScrollPos, GUIStyle.none, GUI.skin.verticalScrollbar);

            var actions = Data.Actions;
            if (!string.IsNullOrEmpty(Data.SearchFilter))
            {
                actions = actions.FindAll(x => x.Name.ToLower().Contains(Data.SearchFilter.ToLower()));
            }

            for (var i = 0; i < actions.Count; i++)
            {
                var action = actions[i];



                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(Screen.width));

                GUILayout.Label(action.Name, EditorStyles.boldLabel, GUILayout.Width(200));
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                EditorGUILayout.LabelField(action.Description, EditorStyles.wordWrappedLabel, GUILayout.Width(Screen.width - 50));
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(5);
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                if (GUILayout.Button(action.Signiture, EditorStyles.toolbarButton, GUILayout.Width(Screen.width - 50)))
                {
                    GUIUtility.systemCopyBuffer = action.Signiture;
                }
                EditorGUILayout.EndHorizontal();

                GUILayout.Space(5);
                EditorGUILayout.EndVertical();
            }

            EditorGUILayout.EndScrollView();
        }

    }
}