using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using UnityEngine.Audio;
using System.Linq;
using UnityEditor.Callbacks;

namespace Muse.Editors.Popups
{
    [Serializable]
    public class PopupEditorMementoStack
    {
        [SerializeField]
        private List<PopupEditorMemento> _undo = new List<PopupEditorMemento>();
        [SerializeField]
        private List<PopupEditorMemento> _redo = new List<PopupEditorMemento>();

        public int UndoCount { get { return _undo.Count; } }
        public int RedoCount { get { return _redo.Count; } }

        public Action<PopupEditorMemento> Restore = (T) => { Debug.Log("default Restore"); };
        public Func<PopupEditorMemento> GetMementoData = () => { Debug.Log("default getmementodata"); return null; };
        public Action OnChange = () => { };

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
    public class PopupEditorMemento
    {

    }

    public class PopupEditorData : ScriptableObject
    {
        public PopupEditorMementoStack MementoStack = new PopupEditorMementoStack();
        public List<Type> Templates = new List<Type>();
        public Vector2 Pan;
        public bool IsDirty;

        public int CreateIndex;

        public PopupTemplateList Entries = new PopupTemplateList();

        public int TemplateIndex;
        public int SelectedIndex = -1;

        public Vector2 ScrollPos;

        public PopupEditorData()
        {
        }

    }

    [Serializable]
    public class PopupTemplateList : List<PopupTemplate>, ISerializationCallbackReceiver
    {
        private List<string> _serialized = new List<string>();

        const string DELIMITER = "~~~~~";

        public void OnBeforeSerialize()
        {
            _serialized.Clear();
            for (var i = 0; i < this.Count; i++)
            {
                _serialized.Add(this[i].GetType().Name + DELIMITER + this[i].IsDeleted + DELIMITER + this[i].OriginalHash + DELIMITER + this[i].OriginalId + DELIMITER + this[i].Serialize());
            }
        }//

        public void OnAfterDeserialize()
        {
            for (var i = 0; i < _serialized.Count; i++)
            {
                var data = _serialized[i];
                var split = data.Split(new string[] { DELIMITER }, StringSplitOptions.None);
                var type = Type.GetType("Muse.Editors.Popups." + split[0]);
                // Debug.Log(split[0] + ", " + type.Name);
                this[i] = (PopupTemplate)type.GetConstructor(new Type[] { }).Invoke(new object[] { });
                //Debug.Log(this[i]);
                this[i].IsDeleted = bool.Parse(split[1]);
                this[i].OriginalHash = int.Parse(split[2]);
                this[i].OriginalId = split[3];
                this[i].Deserialize(split[4]);
            }
        }
    }

    public class PopupEditor : EditorWindow
    {
        public static PopupEditor Instance { get; private set; }

        public const string POPUP_PATH = MuseEditor.GameDataPathRaw + "Popups/";

        public PopupEditorData Data;


        [SerializeField]
        private Vector2 _scrollPosition;

        public static void Setup()
        {
            if (!System.IO.Directory.Exists(POPUP_PATH))
                System.IO.Directory.CreateDirectory(POPUP_PATH);
        }

        [MenuItem("Muse/Editors/Data/Popups")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<PopupEditor>();
            window.titleContent = new GUIContent("Popups");
            window.Show();

            Instance = window;
            window.Data = ScriptableObject.CreateInstance<PopupEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "PopupsEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            LoadPopupTemplates();
            OnSetupMementoStack();

            Instance.Load();
        }

        [DidReloadScripts]
        static void OnReloadScripts()
        {
            var windows = Resources.FindObjectsOfTypeAll<PopupEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];

            LoadPopupTemplates();
            OnSetupMementoStack();
        }

        static void LoadPopupTemplates()
        {
            Instance.Data.Templates = Utils.GetTypesWith<PopupTemplateAttribute>().ToList();
        }

        static void OnSetupMementoStack()
        {
            Instance.Data.MementoStack.Restore = (memento) =>
            {

            };
            Instance.Data.MementoStack.GetMementoData = () =>
            {
                return null;
            };
        }

        void OnDestroy()
        {
            Instance = null;
        }

        void Load()
        {
            Data.Entries.Clear();
            var files = Directory.GetFiles(POPUP_PATH).ToList().FindAll(x => !x.Contains(".meta") && !x.Contains("PopupIds.cs"));
            for (var i = 0; i < files.Count; i++)
            {
                 //Debug.Log(files[i]);
                var classWriter = ClassWriter.Load(files[i]);
                
                var method = classWriter.GetMethod(classWriter.Name);
                var bodyLines = method.Lines.ToList();
                var popupType = bodyLines.Find(x => x.Contains("///Type")).Replace("///Type", "").Trim();


                //var dataType = Type.GetType(classWriter.Name + ", Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
                //var data = (PopupData)dataType.GetConstructor(new Type[0]).Invoke(new object[0]);

                //Debug.Log(classWriter.Name + ", " + dataType + ", " + data.Type);

                var type = "Muse.Editors.Popups." + popupType;
                var popup = (PopupTemplate)Type.GetType(type).GetConstructor(new Type[0]).Invoke(new object[0]);
                popup.FromClassWriter(classWriter);

                popup.OriginalHash = popup.GetHashCode();
                popup.OriginalId = popup.Id;

                Data.Entries.Add(popup);
            }
        }

        void Save()
        {
            var popupIds = "public enum PopupIds {\n";

            var files = Directory.GetFiles(POPUP_PATH).ToList().FindAll(x => !x.Contains(".meta") && !x.Contains("PopupIds.cs"));

            var count = 0;
            for (var i = 0; i < Data.Entries.Count; i++)
            {
                var entry = Data.Entries[i];
                var filename = POPUP_PATH + "PopupData_" + entry.Id + ".cs";
                var originalAudioPath = AudioManager.GetStreamingPath().Replace("file:", "") + "/Audio/VO/Popups/" + entry.OriginalId + "/";
                var audioPath = AudioManager.GetStreamingPath().Replace("file:", "") + "/Audio/VO/Popups/" + entry.Id + "/";

                //Debug.Log("remove: " + filename);
                files.Remove(filename);


                if (entry.IsDeleted)
                {
                    if (File.Exists(filename))
                        File.Delete(filename);

                    if (Directory.Exists(audioPath))
                        Directory.Delete(audioPath, true);

                    Data.Entries.RemoveAt(i);
                    i--;
                    entry.OnDelete();

                    if (Directory.Exists(originalAudioPath))
                        Directory.Delete(originalAudioPath, true);

                    continue;
                }


                if (count > 0)
                    popupIds += ", ";
                popupIds += entry.Id + "\n";
                count++;

                if (entry.OriginalHash != entry.GetHashCode())
                {
                    entry.OnSave();
                  //  Debug.Log("onSaveComplete: " + entry.Id);
                    var classWriter = entry.GetClassWriter().WritePath(filename);

                   // if (Directory.Exists(originalAudioPath))
                  //      Directory.Delete(originalAudioPath, true);

                   // Directory.CreateDirectory(audioPath);
                   // entry.GenerateVO(audioPath);
                }//

                entry.OriginalHash = entry.GetHashCode();
                entry.OriginalId = entry.Id;
            }

            popupIds += "};";

            File.WriteAllText(POPUP_PATH + "/PopupIds.cs", popupIds);

            for (var i = 0; i < files.Count; i++)
            {
                File.Delete(files[i]);
            }

            AssetDatabase.Refresh();
        }

        void OnGUI()
        {//
            if (Data == null)
                Init();
            Instance = this;
            Texture2D bg = Resources.Load<Texture2D>("EditorBackground");
            GUI.DrawTextureWithTexCoords(new Rect(0, 0, Screen.width, Screen.height), bg, new Rect(0, 0, Screen.width / bg.width, Screen.height / bg.height));


            OnDrawMainArea();
            OnDrawTopBar();
        }

        private void OnDrawTopBar()
        {
            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));

            if (GUILayout.Button("Save", EditorStyles.toolbarButton, GUILayout.Width(75)))
            {
                Save();
            }
            if (GUILayout.Button("Edit", EditorStyles.toolbarDropDown, GUILayout.Width(50)))
            {
                GenericMenu fileMenu = new GenericMenu();
                if (Data.MementoStack.UndoCount > 0)
                {
                    fileMenu.AddItem(new GUIContent("Undo"), false, () =>
                    {
                        Debug.Log("Undo");
                        Data.MementoStack.Undo();
                    });
                }
                if (Data.MementoStack.RedoCount > 0)
                {
                    fileMenu.AddItem(new GUIContent("Redo"), false, () =>
                    {
                        Data.MementoStack.Redo();
                    });
                }
                fileMenu.DropDown(new Rect(5, -5, 0, 30));
                EditorGUIUtility.ExitGUI();
            }
            GUILayout.Space(10);

            EditorGUILayout.EndHorizontal();

        }

        public bool FirstDraw = true;
        private void OnDrawMainArea()
        {
            if (Data == null)
                Init();

            BeginWindows();
            var height = 50f;


            if (Data.SelectedIndex > -1)
                GUILayout.Window(100, new Rect(Screen.width - 700, 50 - Data.Pan.y, 650, 400), DrawPopup, Data.Entries[Data.SelectedIndex].Id);

            GUILayout.Window(1001, new Rect(50, 50, 615, Screen.height * 0.65f), DrawPopupList, "Popup List");
            //GUILayout.Window(1003, new Rect(50, Mathf.RoundToInt(50 + Screen.height * 0.65f + 25), 615, Screen.height - (50 + Screen.height * 0.65f + 25) - 50), DrawErrors, "Error Messages");

            using (new GUILayout.AreaScope(new Rect(Screen.width - 20, 18, Screen.width / 2, Screen.height)))
            {
                if (Data.Pan.y + height > Screen.height)
                    Data.Pan = new Vector2(0, Mathf.RoundToInt(GUILayout.VerticalScrollbar(Data.Pan.y, 100, 0, height - (Screen.height - 300), GUILayout.Height(Screen.height - 36))));
            }

            Repaint();
            EndWindows();
        }

        void DrawPopup(int id)
        {
            var entry = Data.Entries[Data.SelectedIndex];

            entry.OnGUI(Data.MementoStack.CreateMemento, InfoButton, (newId)=> Data.Entries.Find(x => x.Id.ToLower() == newId.ToLower()) == null);
        }

        string GetUniqueId()
        {
            var id = 0;
            while (Data.Entries.Find(x => x.Id == "popup_" + id) != null)
                id++;
            return "popup_" + id;
        }

        public void Sort()
        {
            var entry = Data.SelectedIndex > -1 ? Data.Entries[Data.SelectedIndex] : null;
            Data.Entries.Sort((x, y) => x.Id.CompareTo(y.Id));
            if (entry != null)
                Data.SelectedIndex = Data.Entries.IndexOf(entry);
        }

        void DrawPopupList(int id)
        {
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar))
            {
                using (new EditorGUILayout.HorizontalScope())
                {
                    InfoButton(new Vector2(400, 50), "Generate VO files for all popups.");
                    GUI.enabled = !Data.IsDirty;
                    if (GUILayout.Button("Generate VO", EditorStyles.toolbarButton, GUILayout.Width(125)))
                    {
                        if (EditorUtility.DisplayDialog("Generate VO?", "Are you sure you want to generate VO for all popups? This will cost time and money.", "Generate VO", "Cancel"))
                        {
                            for (var i = 0; i < Data.Entries.Count; i++)
                            {
                                var entry = Data.Entries[i];
                                var filename = POPUP_PATH + "PopupData_" + entry.Id + ".cs";
                                var originalAudioPath = AudioManager.GetStreamingPath().Replace("file:", "") + "/Audio/VO/Popups/" + entry.OriginalId + "/";
                                var audioPath = AudioManager.GetStreamingPath().Replace("file:", "") + "/Audio/VO/Popups/" + entry.Id + "/";


                                if (Directory.Exists(originalAudioPath))
                                {
                                    Debug.Log("Delete vo directory for " + originalAudioPath);
                                    Directory.Delete(originalAudioPath, true);
                                }

                                Debug.Log("Create VO directory for " + originalAudioPath);
                                Directory.CreateDirectory(originalAudioPath);
                                Debug.Log("generate vo for : " + originalAudioPath);
                                entry.GenerateVO(originalAudioPath);
                            }
                            AssetDatabase.Refresh();
                            EditorUtility.DisplayDialog("Generate VO Complete", "Thank you. Come again.", "Close");
                        }
                    }
                    GUI.enabled = true;
                }
                using (new EditorGUILayout.HorizontalScope())
                {
                    InfoButton(new Vector2(400, 50), "Creates a new popup with the specified template type.");
                    if (GUILayout.Button("Create", EditorStyles.toolbarButton, GUILayout.Width(60)))
                    {
                        var entry = (PopupTemplate)Data.Templates[Data.CreateIndex].GetConstructor(new Type[] { }).Invoke(new object[] { });
                        entry.Id = GetUniqueId();
                        Data.Entries.Add(entry);
                        Data.SelectedIndex = Data.Entries.IndexOf(entry);
                    }

                    var names = Data.Templates.ConvertAll<string>(x => x.Name.Replace("Template", "")).ToArray();
                    Data.CreateIndex = EditorGUILayout.Popup(Data.CreateIndex, names, EditorStyles.toolbarDropDown, GUILayout.Width(200));
                    
                }
            }

            GUI.backgroundColor = Color.clear;
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
            {
                GUI.backgroundColor = Color.white;
                InfoButton(new Vector2(400, 70), "The Id of the popup must be unique. This is used to launch the popup.\n\nClick on the \"GO\" column to jump to the corresponding state window.\n\nThe type of popup. This cannot be changed.");

                GUI.backgroundColor = Color.clear;
                if (GUILayout.Button("Popup Id", EditorStyles.toolbarButton, GUILayout.Width(200)))
                {
                }
                if (GUILayout.Button("Go", EditorStyles.toolbarButton, GUILayout.Width(40)))
                {
                }

                if (GUILayout.Button("Popup Type", EditorStyles.toolbarButton, GUILayout.Width(200)))
                {

                }
                GUI.backgroundColor = Color.white;
            }

            Data.IsDirty = false;
            Data.ScrollPos = EditorGUILayout.BeginScrollView(Data.ScrollPos, false, true, new GUIStyle(), GUI.skin.verticalScrollbar, new GUIStyle());
            for (var i = 0; i < Data.Entries.Count; i++)
            {
                var entry = Data.Entries[i];

                var isDirty = entry.GetHashCode() != entry.OriginalHash;
                if (isDirty)
                    Data.IsDirty = true;
                // if (isDirty)
                //  Debug.Log(entry.Id + ": " + entry.GetHashCode() + ", " + entry.OriginalHash);
                if (Data.SelectedIndex == i)
                    GUI.backgroundColor = Color.cyan;
                else if (entry.IsDeleted)
                    GUI.backgroundColor = Color.red;
                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
                {
                    GUILayout.Space(25);
                    if (GUILayout.Button((isDirty ? "*" : "") + entry.Id, EditorStyles.toolbarButton, GUILayout.Width(200)))
                    {
                        var window = new PopupIdWindowEditor(entry.Id, (newId) => Data.Entries.Find(x => x.Id.ToLower() == newId.ToLower()) == null, (newId) => entry.ChangeId(newId, Data.MementoStack.CreateMemento));
                        PopupWindow.Show(new Rect(25, i * 18 - 82, 100, 100), window);
                    }
                    if (GUILayout.Button(Data.SelectedIndex == i ? "<-" : "->", EditorStyles.toolbarButton, GUILayout.Width(40)))
                    {
                        if (!entry.IsDeleted)
                        {
                            Data.SelectedIndex = Data.SelectedIndex == i ? -1 : i;
                            GUI.FocusControl(null);
                        }
                    }

                    if (GUILayout.Button(entry.GetType().Name.Replace("Template", ""), EditorStyles.toolbarButton, GUILayout.Width(200)))
                    {

                    }
                    GUILayout.FlexibleSpace();
                    if (GUILayout.Button(entry.IsDeleted ? "+" : "-", EditorStyles.toolbarButton, GUILayout.Width(25)))
                    {
                        Data.MementoStack.CreateMemento();
                        entry.IsDeleted = !entry.IsDeleted;
                        if (Data.SelectedIndex == i)
                            Data.SelectedIndex = -1;
                    }
                }
                GUI.backgroundColor = Color.white;
            }
            EditorGUILayout.EndScrollView();
        }

        Dictionary<int, Rect> _infoButtonRects = new Dictionary<int, Rect>();
        void InfoButton(Vector2 size, string message, Vector2 offset = default(Vector2))
        {

            var id = GUIUtility.GetControlID(FocusType.Passive);
            bool show = GUILayout.Button("?", EditorStyles.toolbarButton, GUILayout.Width(25));

            var rect = GUILayoutUtility.GetLastRect();
            var screenPoint = GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y));

            if (rect.x != 0 && rect.y != 0)
            {
                if (!_infoButtonRects.ContainsKey(id))
                    _infoButtonRects.Add(id, rect);
                else
                    _infoButtonRects[id] = rect;
            }
            else if (_infoButtonRects.ContainsKey(id))
                rect = _infoButtonRects[id];


            if (show)
            {
                var window = new InfoPopup(message, size);
                rect.x += offset.x;
                rect.y += offset.y;
                PopupWindow.Show(rect, window);
            }

        }

        class InfoPopup : PopupWindowContent
        {
            string _message;
            Vector2 _size;

            public override Vector2 GetWindowSize()
            {
                return _size;
            }

            public InfoPopup(string message, Vector2 size)
            {
                _message = message;
                _size = size;
            }

            public override void OnGUI(Rect rect)
            {
                EditorGUILayout.HelpBox(_message, MessageType.Info);
            }
        }
    }


}