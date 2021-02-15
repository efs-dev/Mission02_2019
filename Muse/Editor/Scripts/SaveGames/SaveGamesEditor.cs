using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

namespace Muse.Editors.SaveGames
{

    public class SaveGameEditorData : ScriptableObject
    {
        public List<SaveGameData> Saves = new List<SaveGameData>();
    }

    [System.Serializable]
    public class SaveGameData
    {
        public string Id = "";
        public string Description = "";
        public string TriggerState = "";
        public string Condition = "";
    }

    public class SaveGameEditor : EditorWindow
    {
        public static SaveGameEditor Instance { get; private set; }

        public const string SAVEGAME_PATH = MuseEditor.GameDataPathRaw + "SaveGames/";

        public SaveGameEditorData Data;

        public static void Setup()
        {

            if (!System.IO.Directory.Exists(SAVEGAME_PATH))
                System.IO.Directory.CreateDirectory(SAVEGAME_PATH);


            if (!System.IO.Directory.Exists(MuseEditor.GameDataPathCompiled + "SaveGames/"))
                System.IO.Directory.CreateDirectory(MuseEditor.GameDataPathCompiled + "SaveGames/");


            if (!File.Exists(MuseEditor.GameDataPathRaw + "SaveGames/SaveGamesData.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "SaveGamesData";
                classWriter.IsPartial = true;
                classWriter.IsStatic = true;
                classWriter.IsPublic = true;

                var mw = classWriter.CreateMethodWriter();
                mw.IsStatic = true;
                mw.Name = "Init";
                mw.ReturnType = "void";
                classWriter.WritePath(MuseEditor.GameDataPathRaw + "SaveGames/SaveGamesData.cs");
            }

            if (!File.Exists(MuseEditor.GameDataPathCompiled + "SaveGames/SaveGamesData.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "SaveGamesData";
                classWriter.IsPartial = true;
                classWriter.IsStatic = true;
                classWriter.IsPublic = true;

                var mw = classWriter.CreateMethodWriter();
                mw.IsStatic = true;
                mw.Name = "Init";
                mw.ReturnType = "void";
                classWriter.WritePath(MuseEditor.GameDataPathCompiled + "SaveGames/SaveGamesData.cs");
            }
        }

        [MenuItem("Muse/Editors/Data/SaveGames")]
        static void Init()
        {
            var window = EditorWindow.GetWindow<SaveGameEditor>();
            window.titleContent = new GUIContent("SaveGames");
            window.Show();

            Setup();

            Instance = window;
            window.Data = ScriptableObject.CreateInstance<SaveGameEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "SaveGameEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Load();
        }

        void OnDestroy()
        {
            Instance = null;
        }

        void Load()
        {
            var classWriter = ClassWriter.Load(SAVEGAME_PATH + "/SaveGamesData.cs");

            Data.Saves.Clear();
            typeof(SaveGamesData).GetMethod("Init", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy | BindingFlags.Static).Invoke(null, new object[0]);
            for (var i = 0; i < SaveGamesData.Ids.Count; i++)
            {
                var save = new SaveGameData();
                save.Id = SaveGamesData.Ids[i];
                save.Description = SaveGamesData.Descriptions[i];
                save.TriggerState = SaveGamesData.TriggerStates[i];
                save.Condition = classWriter.GetMethod("Condition_" + save.Id).GetText();
                Data.Saves.Add(save);
            }
        }

        void Save()
        {
            var classWriter = new ClassWriter();

            classWriter.Name = "SaveGamesData";
            classWriter.IsStatic = true;
            classWriter.IsPublic = true;
            classWriter.IsPartial = true;
            classWriter.AddTopLine("using UnityEngine;");
            classWriter.AddTopLine("using System;");
            classWriter.AddTopLine("using System.Collections.Generic;");
            
            var methodWriter = classWriter.CreateMethodWriter();
            methodWriter.Name = "Initialize";
            methodWriter.VisibilityType = MethodWriter.VisibilityTypes.Public;
            methodWriter.IsStatic = true;
            methodWriter.ReturnType = "void";


            methodWriter.AddLine("Ids.Clear();");
            methodWriter.AddLine("Descriptions.Clear();");
            methodWriter.AddLine("TriggerStates.Clear();");
            methodWriter.AddLine("Conditions.Clear();");
            methodWriter.AddLine("");

            for (var i = 0; i < Data.Saves.Count; i++)
            {
                var save = Data.Saves[i];

                methodWriter.AddLine("Ids.Add(\"" + save.Id + "\");");
                methodWriter.AddLine("Descriptions.Add(\"" + save.Description.Replace("\n", "\\n") + "\");");
                methodWriter.AddLine("TriggerStates.Add(\"" + save.TriggerState + "\");");
                methodWriter.AddLine("Conditions.Add(Condition_" + save.Id + ");");

                var conditionMethodWriter = classWriter.CreateMethodWriter();
                conditionMethodWriter.Name = "Condition_" + save.Id;
                conditionMethodWriter.ReturnType = "bool";
                conditionMethodWriter.VisibilityType = MethodWriter.VisibilityTypes.Public;
                conditionMethodWriter.AddLines(save.Condition.Split('\n'));
                conditionMethodWriter.IsStatic = true;
            }

            classWriter.WritePath(SAVEGAME_PATH + "SaveGamesData.cs");
        }

        void OnGUI()
        {
            Instance = this;
            Texture2D bg = Resources.Load<Texture2D>("EditorBackground");
            GUI.DrawTextureWithTexCoords(new Rect(0, 0, Screen.width, Screen.height), bg, new Rect(0, 0, Screen.width / bg.width, Screen.height / bg.height));


            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));
            if (GUILayout.Button("File", EditorStyles.toolbarDropDown, GUILayout.Width(50)))
            {
                GenericMenu fileMenu = new GenericMenu();

                fileMenu.AddItem(new GUIContent("Reload"), false, () =>
                {
                    if (
                        !EditorUtility.DisplayDialog("Reload saveGames?",
                            "Are you sure you want to reload all save game data? Any unsaved changes will be lost!", "Reload Data",
                            "Cancel"))
                        return;
                    Load();
                });
                fileMenu.AddItem(new GUIContent("Save"), false, () =>
                {
                    Save();
                });

                fileMenu.DropDown(new Rect(5, -5, 0, 30));
                EditorGUIUtility.ExitGUI();
            }
            GUILayout.Space(10);
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));
            if (GUILayout.Button("Create Save Point", EditorStyles.toolbarButton, GUILayout.Width(135)))
            {
                Data.Saves.Add(new SaveGameData());
            }
            EditorGUILayout.EndHorizontal();


            for (var i = 0; i < Data.Saves.Count; i++)
            {
                var save = Data.Saves[i];

                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(40)))
                {
                    Data.Saves.RemoveAt(i);
                    i--;
                }
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(Screen.width));

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Id:", GUILayout.Width(150));
                save.Id = EditorGUILayout.TextField(save.Id, EditorStyles.toolbarTextField, GUILayout.Width(300));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Description:", GUILayout.Width(150));
                save.Description = EditorGUILayout.TextArea(save.Description, GUILayout.Width(300));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Trigger State:", GUILayout.Width(150));
                save.TriggerState = EditorGUILayout.TextField(save.TriggerState, EditorStyles.toolbarTextField, GUILayout.Width(300));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Condition:", GUILayout.Width(150));
                save.Condition = EditorGUILayout.TextArea(save.Condition, GUILayout.Width(300));
                EditorGUILayout.LabelField("C#", GUILayout.Width(40));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.EndVertical();
            }
        }
    }
}