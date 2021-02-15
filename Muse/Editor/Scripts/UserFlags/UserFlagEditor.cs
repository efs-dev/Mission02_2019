using UnityEngine;
using UnityEditor;
using System.IO;

using System;
using System.Collections.Generic;

using UnityEditor.Callbacks;

using Muse.Editors.GameFlags;

namespace Muse.Editors.UserFlags
{

    [Serializable]
    public class UserFlagEditorMementoStack
    {
        [SerializeField]
        private List<UserFlagEditorMemento> _undo = new List<UserFlagEditorMemento>();
        [SerializeField]
        private List<UserFlagEditorMemento> _redo = new List<UserFlagEditorMemento>();

        public Action<UserFlagEditorMemento> Restore = (T) => { Debug.Log("default Restore"); };
        public Func<UserFlagEditorMemento> GetMementoData = () => { Debug.Log("default getmementodata"); return null; };
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
    public class UserFlagEditorMemento
    {
        public List<GameFlagData> Data = new List<GameFlagData>();
    }

    public class UserFlagEditorData : ScriptableObject
    {
        public UserFlagEditorMementoStack MementoStack = new UserFlagEditorMementoStack();
        public GameFlagEditorDrawer UserFlags = new GameFlagEditorDrawer();

        public UserFlagEditorData()
        {
        }

    }

    public class UserFlagEditor : EditorWindow
    {
        public static UserFlagEditor Instance { get; private set; }

        public const string USERFLAGS_PATH = MuseEditor.GameDataPathRaw + "UserFlags/";

        public UserFlagEditorData Data;

        public static void Setup()
        {
            if (!System.IO.Directory.Exists(USERFLAGS_PATH))
                System.IO.Directory.CreateDirectory(USERFLAGS_PATH);

            if (!System.IO.Directory.Exists(MuseEditor.GameDataPathCompiled + "UserFlags/"))
                System.IO.Directory.CreateDirectory(MuseEditor.GameDataPathCompiled + "UserFlags/");

            if (!File.Exists(MuseEditor.GameDataPathRaw + "UserFlags/UserFlags.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "UserFlags";
                classWriter.IsPartial = true;
                classWriter.IsStatic = true;
                classWriter.IsPublic = true;

                classWriter.WritePath(MuseEditor.GameDataPathRaw + "UserFlags/UserFlags.cs");
            }

            if (!File.Exists(MuseEditor.GameDataPathCompiled + "UserFlags/UserFlags.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "UserFlags";
                classWriter.IsPartial = true;
                classWriter.IsStatic = true;
                classWriter.IsPublic = true;

                classWriter.WritePath(MuseEditor.GameDataPathCompiled + "UserFlags/UserFlags.cs");
            }
        }

        [MenuItem("Muse/Editors/Data/UserFlags")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<UserFlagEditor>();
            window.titleContent = new GUIContent("UserFlags");
            window.Show();

            
            Instance = window;
            window.Data = ScriptableObject.CreateInstance<UserFlagEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "UserFlagsEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Data.UserFlags.FromClassWriter(ClassWriter.Load(USERFLAGS_PATH + "UserFlags.cs"));


            OnSetupMementoStack();
        }

        [DidReloadScripts]
        static void OnReload()
        {
            var windows = Resources.FindObjectsOfTypeAll<UserFlagEditor>();
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
                Instance.Data.UserFlags.Variables.Clear();
                for (var i = 0; i < memento.Data.Count; i++)
                {
                    Instance.Data.UserFlags.Variables.Add(memento.Data[i].Clone());
                }
            };
            Instance.Data.MementoStack.GetMementoData = () =>
            {
                Debug.Log("GetMementoData");
                var memento = new UserFlagEditorMemento();
                for (var i = 0; i < Instance.Data.UserFlags.Variables.Count; i++)
                {
                    var flag = Instance.Data.UserFlags.Variables[i];
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

            Data.UserFlags.OnGUI(Screen.width, () =>
            {
                if (GUILayout.Button("File", EditorStyles.toolbarDropDown, GUILayout.Width(50)))
                {
                    GenericMenu fileMenu = new GenericMenu();
                    fileMenu.AddItem(new GUIContent("Save"), false, () =>
                    {
                        Debug.Log("save user flags");
                        Data.UserFlags.GetClassWriter("UserFlags", true, true, true, false).WritePath(USERFLAGS_PATH + "UserFlags.cs");
                    });
                    fileMenu.AddItem(new GUIContent("Reload"), false, () =>
                    {
                        if (!EditorUtility.DisplayDialog("Reload UserFlags?",
                                   "Are you sure you want to reload all UserFlag data? Any unsaved changes will be lost!", "Reload Data",
                                   "Cancel"))
                            return;

                        Data.UserFlags.FromClassWriter(ClassWriter.Load(USERFLAGS_PATH + "UserFlags.cs"));
                        Data.MementoStack.Clear();
                    });

                    fileMenu.DropDown(new Rect(5, -5, 0, 30));
                    EditorGUIUtility.ExitGUI();
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