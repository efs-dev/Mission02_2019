using UnityEngine;
using UnityEditor;
using System.IO;

using System;
using System.Collections.Generic;

using UnityEditor.Callbacks;

namespace Muse.Editors.GameFlags
{
    [Serializable]
    public class GameFlagEditorMementoStack
    {
        [SerializeField]
        private List<GameFlagEditorMemento> _undo = new List<GameFlagEditorMemento>();
        [SerializeField]
        private List<GameFlagEditorMemento> _redo = new List<GameFlagEditorMemento>();

        public Action<GameFlagEditorMemento> Restore = (T) => { Debug.Log("default Restore"); };
        public Func<GameFlagEditorMemento> GetMementoData = () => { Debug.Log("default getmementodata"); return null; };
        public Action OnChange = () => { Debug.Log("default OnChange"); };

        public void Clear()
        {
            _undo.Clear();
            _redo.Clear();
        }

        public void CreateMemento()
        {
            _undo.Add(GetMementoData());
            _redo.Clear();

            OnChange();
        }

        public void Undo()
        {
            if (_undo.Count == 0)
                return;

            var memento = _undo[_undo.Count - 1];
            _undo.Remove(memento);

            _redo.Add(GetMementoData());

            Restore(memento);
            OnChange();
        }

        public void Redo()
        {
            if (_redo.Count == 0)
                return;

            var memento = _redo[_redo.Count - 1];
            _redo.Remove(memento);

            _undo.Add(GetMementoData());
            Restore(memento);
            OnChange();
        }
    }

    [Serializable]
    public class GameFlagEditorMemento
    {
        public List<GameFlagData> Data = new List<GameFlagData>();
    }

    public class GameFlagEditorData : ScriptableObject
    {
        public GameFlagEditorMementoStack MementoStack = new GameFlagEditorMementoStack();
        public GameFlagEditorDrawer GameFlags = new GameFlagEditorDrawer();


        public GameFlagEditorData()
        {
        }

    }

    public class GameFlagEditor : EditorWindow
    {
        public static GameFlagEditor Instance { get; private set; }

        public const string GAMEFLAGS_PATH = MuseEditor.GameDataPathRaw + "GameFlags/";

        public GameFlagEditorData Data;

        public static void Setup()
        {
            if (!System.IO.Directory.Exists(GAMEFLAGS_PATH))
                System.IO.Directory.CreateDirectory(GAMEFLAGS_PATH);

            if (!System.IO.Directory.Exists(MuseEditor.GameDataPathCompiled + "GameFlags/"))
                System.IO.Directory.CreateDirectory(MuseEditor.GameDataPathCompiled + "GameFlags/");

            if (!File.Exists(MuseEditor.GameDataPathRaw + "GameFlags/GameFlags.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "GameFlags";
                classWriter.IsPartial = true;
                classWriter.IsStatic = true;
                classWriter.IsPublic = true;

                classWriter.WritePath(MuseEditor.GameDataPathRaw + "GameFlags/GameFlags.cs");
            }

            if (!File.Exists(MuseEditor.GameDataPathCompiled + "GameFlags/GameFlags.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "GameFlags";
                classWriter.IsPartial = true;
                classWriter.IsStatic = true;
                classWriter.IsPublic = true;

                classWriter.WritePath(MuseEditor.GameDataPathCompiled + "GameFlags/GameFlags.cs");
            }
        }

        [MenuItem("Muse/Editors/Data/GameFlags")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<GameFlagEditor>();
            window.titleContent = new GUIContent("GameFlags");
            window.Show();

            Setup();

            Instance = window;
            window.Data = ScriptableObject.CreateInstance<GameFlagEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "GameFlagEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Data.GameFlags.FromClassWriter(ClassWriter.Load(GAMEFLAGS_PATH + "GameFlags.cs"));


            OnSetupMementoStack();
        }

        [DidReloadScripts]
        static void OnReload()
        {
            var windows = Resources.FindObjectsOfTypeAll<GameFlagEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];

            OnSetupMementoStack();
        }

        static void OnSetupMementoStack()
        {
            Instance.Data.MementoStack.Restore = (memento) =>
            {
                Debug.Log("Restore");
                Instance.Data.GameFlags.Variables.Clear();
                for (var i = 0; i < memento.Data.Count; i++)
                {
                    Instance.Data.GameFlags.Variables.Add(memento.Data[i].Clone());
                }
            };
            Instance.Data.MementoStack.GetMementoData = () =>
            {
                Debug.Log("GetMementoData");
                var memento = new GameFlagEditorMemento();
                for (var i = 0; i < Instance.Data.GameFlags.Variables.Count; i++)
                {
                    var flag = Instance.Data.GameFlags.Variables[i];
                    memento.Data.Add(flag.Clone());
                }
                return memento;
            };
        }

        void OnDestroy()
        {
            Instance = null;
        }

        void OnGUI()
        {//
            if (Data == null)
                Init();

            Instance = this;

            Data.GameFlags.CopyPrefix = "GameFlags.";
            Data.GameFlags.OnGUI(Screen.width, () =>
            {
                if (GUILayout.Button("Save", EditorStyles.toolbarButton, GUILayout.Width(50)))
                {
                    Data.GameFlags.GetClassWriter("GameFlags", true, true, true).WritePath(GAMEFLAGS_PATH + "GameFlags.cs");
                }
                if (GUILayout.Button("Edit", EditorStyles.toolbarDropDown, GUILayout.Width(50)))
                {
                    GenericMenu fileMenu = new GenericMenu();
                    fileMenu.AddItem(new GUIContent("Undo"), false, () =>
                    {
                        Data.MementoStack.Undo();
                    });
                    fileMenu.AddItem(new GUIContent("Redo"), false, () =>
                    {
                        Data.MementoStack.Redo();
                    });

                    fileMenu.DropDown(new Rect(5, -5, 0, 30));
                    EditorGUIUtility.ExitGUI();
                }
            }, null,
            () =>
            {
                Data.MementoStack.CreateMemento();
            });
        }
    }

}