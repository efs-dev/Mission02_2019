using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using System.IO;
using System;

namespace Muse.Editors.Modules
{
    public class ModulesEditorData : ScriptableObject
    {
        public List<string> Modules = new List<string>();
    }

    public class ModulesEditor : EditorWindow
    {

        public static ModulesEditor Instance { get; private set; }
        

        public ModulesEditorData Data;


        [SerializeField]
        private Vector2 _scrollPosition;

        public static void Setup()
        {

        }

        [MenuItem("Muse/Editors/Data/Modules")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<ModulesEditor>();
            window.titleContent = new GUIContent("Modules");
            window.Show();

            Instance = window;
            window.Data = ScriptableObject.CreateInstance<ModulesEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "ModulesEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Data.Modules.Clear();
            var type = System.Type.GetType("ModuleIds");
            if (type != null)
                window.Data.Modules.AddRange(Enum.GetNames(type));
        }

        void OnGUI()
        {
            if (Data == null)
                Init();

            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width)))
            {
                if (GUILayout.Button("Save", EditorStyles.toolbarButton, GUILayout.Width(60)))
                {
                    var modules = "";
                    if (Data.Modules.Count > 0)
                        modules = Data.Modules.Aggregate((x, next) => x + ", " + next);
                    var file = "public enum ModuleIds { " + modules + " };";
                    
                    File.WriteAllText("Assets/Muse/Game/Data/Modules/ModuleIds.cs", file);
                }
            }

            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition);
            for (var i = 0; i < Data.Modules.Count; i++)
            {
                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width)))
                {
                    Data.Modules[i] = EditorGUILayout.TextField(Data.Modules[i], EditorStyles.toolbarTextField, GUILayout.ExpandWidth(true));

                    if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                    {
                        Data.Modules.RemoveAt(i);
                        i--;
                    }
                }
            }
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width)))
            {
                if (GUILayout.Button("+", EditorStyles.toolbarButton, GUILayout.Width(25)))
                {
                    Data.Modules.Add("");
                }
            }
            EditorGUILayout.EndScrollView();
        }
    }
}