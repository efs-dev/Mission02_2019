using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using UnityEditor.Callbacks;

namespace Muse.Editors.Smartword
{

    [Serializable]
    public class SmartwordEditorMementoStack
    {
        [SerializeField]
        private List<SmartwordEditorMemento> _undo = new List<SmartwordEditorMemento>();
        [SerializeField]
        private List<SmartwordEditorMemento> _redo = new List<SmartwordEditorMemento>();

        public Action<SmartwordEditorMemento> Restore = (T) => { Debug.Log("default Restore"); };
        public Func<SmartwordEditorMemento> GetMementoData = () => { Debug.Log("default getmementodata"); return null; };
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
    public class SmartwordEditorMemento
    {
        public List<SmartwordsEditorData> Data = new List<SmartwordsEditorData>();
        public List<string> FilterByTags = new List<string>();
    }


    [Serializable]
    public class SmartwordsEditorData
    {//
        public List<string> Tags = new List<string>();
        public string TagText
        {
            get
            {
                if (Tags.Count == 0)
                    return "";
                return Tags.Aggregate((next, tag) => next += ", " + tag);
            }
        }
        public string Id = "";
        public string OriginalId = "";
        public string DisplayName;
        public string Description;
        public bool IsCollectable;
        public string OnCollectText;
        public Rect EditorPosition = new Rect(400, 50, 650, 150);

        public UploadImage SmallImage = new UploadImage();
        public UploadImage LargeImage = new UploadImage();

        public SmartwordsEditorData Clone()
        {
            var clone = new SmartwordsEditorData();
            clone.Tags = Tags.ToList();
            clone.Id = Id;
            clone.OriginalId = OriginalId;
            clone.DisplayName = DisplayName;
            clone.Description = Description;
            clone.IsCollectable = IsCollectable;
            clone.OnCollectText = OnCollectText;

            return clone;
        }
    }

    public class SmartwordsEditorPersistentData : ScriptableObject
    {
        public List<string> FilterByTags = new List<string>();
        public List<SmartwordsEditorData> Smartwords = new List<SmartwordsEditorData>();
        public SmartwordEditorMementoStack MementoStack = new SmartwordEditorMementoStack();

        public SmartwordsEditorPersistentData()
        {
        }
    }

    public class SmartwordsEditor : EditorWindow
    {
        public static SmartwordsEditor Instance { get; private set; }

        public const string SMARTWORDS_PATH = MuseEditor.GameDataPathRaw + "Smartwords/";

        public SmartwordsEditorPersistentData Data;
        private static List<List<string>> _errorTags = new List<List<string>>();

        public Vector2 Pan;

        public static void Setup()
        {
            if (!System.IO.Directory.Exists(SMARTWORDS_PATH))
                System.IO.Directory.CreateDirectory(SMARTWORDS_PATH);
            
            if (!System.IO.Directory.Exists(MuseEditor.GameDataPathCompiled + "Smartwords/"))
                System.IO.Directory.CreateDirectory(MuseEditor.GameDataPathCompiled + "Smartwords/");

            if (!File.Exists(MuseEditor.GameDataPathRaw + "Smartwords/Smartwords.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "Smartwords";
                classWriter.IsPartial = true;
                classWriter.IsPublic = true;

                var mw = classWriter.CreateMethodWriter();
                mw.Name = classWriter.Name;
                mw.VisibilityType = MethodWriter.VisibilityTypes.Public;

                classWriter.WritePath(MuseEditor.GameDataPathRaw + "Smartwords/Smartwords.cs");
            }

            if (!File.Exists(MuseEditor.GameDataPathCompiled + "Smartwords/Smartwords.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "Smartwords";
                classWriter.IsPartial = true;
                classWriter.IsPublic = true;
                
                var mw = classWriter.CreateMethodWriter();
                mw.Name = classWriter.Name;
                mw.VisibilityType = MethodWriter.VisibilityTypes.Public;

                classWriter.WritePath(MuseEditor.GameDataPathCompiled + "Smartwords/Smartwords.cs");
            }
            

        }

        [MenuItem("Muse/Editors/Data/Smartwords")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<SmartwordsEditor>();
            window.titleContent = new GUIContent("Smartwords");
            window.Show();



            Instance = window;
            window.Data = ScriptableObject.CreateInstance<SmartwordsEditorPersistentData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "SmartwordsEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Reload();
            OnSetupMementoStack();
        }

        [DidReloadScripts]
        static void OnReloadScripts()
        {
            var windows = Resources.FindObjectsOfTypeAll<SmartwordsEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];

            OnSetupMementoStack();
        }

        static void OnSetupMementoStack()
        {
            Instance.Data.MementoStack.Restore = (memento) =>
            {
                Instance.Data.Smartwords.Clear();
                for (var i = 0; i < memento.Data.Count; i++)
                {
                    Instance.Data.Smartwords.Add(memento.Data[i].Clone());
                }
                Instance.Data.FilterByTags = memento.FilterByTags.ToList();
            };
            Instance.Data.MementoStack.GetMementoData = () =>
            {
                var memento = new SmartwordEditorMemento();
                for (var i = 0; i < Instance.Data.Smartwords.Count; i++)
                {
                    var smartwordData = Instance.Data.Smartwords[i];
                    memento.Data.Add(smartwordData.Clone());
                }
                memento.FilterByTags = Instance.Data.FilterByTags.ToList();
                return memento;
            };
        }


        void OnDestroy()
        {
            Instance = null;
        }

        void Save()
        {
            var gameflagWriter = new ClassWriter();
            gameflagWriter.Name = "GameFlags";
            gameflagWriter.IsPartial = true;
            gameflagWriter.IsStatic = true;
            gameflagWriter.IsPublic = true;

            var classWriter = new ClassWriter();

            classWriter.AddTopLine("using UnityEngine;");
            classWriter.AddTopLine("using System;");
            classWriter.AddTopLine("using System.Collections;");
            classWriter.AddTopLine("using System.Collections.Generic;");
            classWriter.AddTopLine("");
            classWriter.Name = "Smartwords";
            classWriter.IsPublic = true;
            classWriter.IsPartial = true;


            var methodWriter = classWriter.CreateMethodWriter();
            methodWriter.Name = "Smartwords";
            methodWriter.VisibilityType = MethodWriter.VisibilityTypes.Public;
            methodWriter.AddLine("Smartword smartword = null;");

            var collectCallbacks = new Dictionary<string, string>();

            for (var i = 0; i < Data.Smartwords.Count; i++)
            {
                var smartword = Data.Smartwords[i];

                PropertyWriter propertyWriter;

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = "_" + Smartwords.GetSmartwordVariableId(smartword.Id);
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
                propertyWriter.Type = "bool";

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = Smartwords.GetSmartwordVariableId(smartword.Id);
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                propertyWriter.Type = "bool";
                propertyWriter.AddGetterLine("return _" + Smartwords.GetSmartwordVariableId(smartword.Id) + ";");
                propertyWriter.AddSetterLine("_" + Smartwords.GetSmartwordVariableId(smartword.Id) + " = value;");

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = "_" + Smartwords.GetShowSmartwordVariableId(smartword.Id);
                propertyWriter.Value = "true";
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
                propertyWriter.Type = "bool";

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = Smartwords.GetShowSmartwordVariableId(smartword.Id);
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                propertyWriter.Type = "bool";
                propertyWriter.AddGetterLine("return _" + Smartwords.GetShowSmartwordVariableId(smartword.Id) + ";");
                propertyWriter.AddSetterLine("_" + Smartwords.GetShowSmartwordVariableId(smartword.Id) + " = value;");

                methodWriter.AddLine("///Id " + smartword.Id);
                methodWriter.AddLine("///SmallImagePath " + smartword.SmallImage.ImagePath);
                methodWriter.AddLine("///LargeImagePath " + smartword.LargeImage.ImagePath);
                methodWriter.AddLine("///DisplayName " + smartword.Id + " " + smartword.DisplayName);
                methodWriter.AddLine("///Description " + smartword.Id + " " + smartword.Description);
                methodWriter.AddLine("///IsCollectable " + smartword.Id + " " + smartword.IsCollectable.ToString().ToLower());
                methodWriter.AddLine("///Tags " + smartword.Id + " " + (smartword.Tags.Count == 0 ? "" : smartword.Tags.Aggregate((tag, next) => next += ";" + tag)));
                methodWriter.AddLine("smartword = new Smartword();");
                methodWriter.AddLine("smartword.Id = \"" + smartword.Id + "\";");
                methodWriter.AddLine("smartword.SmallImagePath = \"" + smartword.SmallImage.ImagePath + "\";");
                methodWriter.AddLine("smartword.LargeImagePath = \"" + smartword.LargeImage.ImagePath + "\";");
                methodWriter.AddLine("smartword.DisplayName = \"" + smartword.DisplayName + "\";");
                methodWriter.AddLine("smartword.Description = \"" + smartword.Description + "\";");
                methodWriter.AddLine("smartword.IsCollectable = " + smartword.IsCollectable.ToString().ToLower() + ";");
                methodWriter.AddLine("smartword.Tags = new List<string>() {" + (smartword.Tags.Count == 0 ? "" : smartword.Tags.ConvertAll(x => "\"" + x + "\"").Aggregate((tag, next) => next += "," + tag)) + "};");

                smartword.SmallImage.MakePermanent("Smartwords/", smartword.OriginalId + "_small", smartword.Id + "_small");
                smartword.LargeImage.MakePermanent("Smartwords/", smartword.OriginalId + "_large", smartword.Id + "_large");

                smartword.OriginalId = smartword.Id;
                var callbackId = "OnCollectCallback_" + smartword.Id;

                if (!string.IsNullOrEmpty(smartword.OnCollectText))
                {
                    collectCallbacks.Add(callbackId, smartword.OnCollectText);
                    methodWriter.AddLine("smartword." + (smartword.OnCollectText.Contains("yield") ? "OnCollectBlocking" : "OnCollect") + " = " + callbackId + ";");
                }

                methodWriter.AddLine("AddSmartwordData(smartword);");

            }

            foreach (var callbackId in collectCallbacks.Keys)
            {
                var callbackText = collectCallbacks[callbackId];

                methodWriter = classWriter.CreateMethodWriter();
                methodWriter.Name = callbackId;
                methodWriter.AddArg(new MethodArg() { Name = "smartword", Type = "Smartword" });
                methodWriter.ReturnType = callbackText.Contains("yield") ? "IEnumerator" : "void";
                methodWriter.AddLines(callbackText.Split('\n'));
            }

            gameflagWriter.WritePath(SMARTWORDS_PATH + "GameFlags.cs");
            classWriter.WritePath(SMARTWORDS_PATH + "Smartwords.cs");
            AssetDatabase.Refresh();
        }

        void Reload()
        {
            Data.Smartwords.Clear();
            var classWriter = ClassWriter.Load(SMARTWORDS_PATH + "Smartwords.cs");

            var body = classWriter.GetMethod(classWriter.Name);
            var bodyLines = body.Lines.ToList();

            var ids = bodyLines.FindAll(x => x.Contains("///Id"));
            var smallImagePaths = bodyLines.FindAll(x => x.Contains("///SmallImagePath"));
            var largeImagePaths = bodyLines.FindAll(x => x.Contains("///LargeImagePath"));
            var displayNames = bodyLines.FindAll(x => x.Contains("///DisplayName"));
            var descriptions = bodyLines.FindAll(x => x.Contains("///Description"));
            var isCollectables = bodyLines.FindAll(x => x.Contains("///IsCollectable"));
            var tags = bodyLines.FindAll(x => x.Contains("///Tags"));

            for (var i = 0; i < ids.Count; i++)
            {
                var smartword = new SmartwordsEditorData();

                smartword.Id = ids[i].Split(' ')[1];
                smartword.OriginalId = smartword.Id;

                var smallImageTokens = smallImagePaths[i].Split(' ');
                smartword.SmallImage.ImagePath = smallImageTokens.Length > 1 ? smallImageTokens[1] : "";
                var largeImageTokens = largeImagePaths[i].Split(' ');
                smartword.LargeImage.ImagePath = largeImageTokens.Length > 1 ? largeImageTokens[1] : "";

                var displayNameTokens = displayNames.Find(x => x.Split(' ')[1] == smartword.Id).Split(' ');
                smartword.DisplayName = displayNameTokens.Length > 2 ? displayNameTokens.ToList().Skip(2).Aggregate((x, y)=>x + " " + y) : "";
                var descriptionTokens = descriptions.Find(x => x.Split(' ')[1] == smartword.Id).Split(' ');
                smartword.Description = descriptionTokens.Length > 2 ? descriptionTokens.ToList().Skip(2).Aggregate((x, y) => x + " " + y) : "";
                var isCollectableTokens = isCollectables.Find(x => x.Split(' ')[1] == smartword.Id).Split(' ');
                smartword.IsCollectable = bool.Parse(isCollectableTokens[2]);

                var tagsText = tags.Find(x => x.Split(' ')[1] == smartword.Id).Replace("///Tags " + smartword.Id, "").Trim();
                if (tagsText.Length == 0)
                    smartword.Tags = new List<string>();
                else
                    smartword.Tags = new List<string>(tagsText.Split(';'));

                var callbackId = "OnCollectCallback_" + smartword.Id;

                if (classWriter.GetMethod(callbackId) != null)
                    smartword.OnCollectText = classWriter.GetMethod(callbackId).GetText();

                Data.Smartwords.Add(smartword);
            }
        }

        void OnGUI()
        {//
            Instance = this;
            Texture2D bg = Resources.Load<Texture2D>("EditorBackground");
            GUI.DrawTextureWithTexCoords(new Rect(0, 0, Screen.width, Screen.height), bg, new Rect(0, 0, Screen.width / bg.width, Screen.height / bg.height));

            OnDrawMainArea();
            OnDrawTopBar();
        }

        private void OnDrawTopBar()
        {
            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));
            /*
            if (GUILayout.Button("File", EditorStyles.toolbarDropDown, GUILayout.Width(50)))
            {
                GenericMenu fileMenu = new GenericMenu();

                fileMenu.AddItem(new GUIContent("Reload"), false, () =>
                {
                    if (!EditorUtility.DisplayDialog("Reload Smartwords?",
                               "Are you sure you want to reload all smartword data? Any unsaved changes will be lost!", "Reload Data",
                               "Cancel"))
                        return;
                    Data.MementoStack.CreateMemento();
                    Reload();
                });
                fileMenu.AddItem(new GUIContent("Save"), false, () =>
                {
                    Save();
                });

                fileMenu.DropDown(new Rect(5, -5, 0, 30));
                EditorGUIUtility.ExitGUI();
            }
            */
            if (GUILayout.Button("Save", EditorStyles.toolbarButton, GUILayout.Width(60)))
            {
                Save();
            }
            if (GUILayout.Button("Edit", EditorStyles.toolbarDropDown, GUILayout.Width(50)))
            {
                GenericMenu fileMenu = new GenericMenu();
                fileMenu.AddItem(new GUIContent("Undo"), false, () =>
                {
                    Debug.Log("Undo");
                    Data.MementoStack.Undo();
                });
                fileMenu.AddItem(new GUIContent("Redo"), false, () =>
                {
                    Data.MementoStack.Redo();
                });

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

            //GUI.skin = AdventureEngineSkin.Skin;
            BeginWindows();
            var height = 100f;
            using (new GUILayout.AreaScope(new Rect(0, 100, Screen.width, Screen.height / 2)))
            {
                var smartwords = Data.Smartwords;
                if (Data.FilterByTags.Count > 0)
                    smartwords = smartwords.FindAll(x =>
                    {
                        for (var i = 0; i < Data.FilterByTags.Count; i++)
                        {
                            if (!x.Tags.Contains(Data.FilterByTags[i]))
                                return false;
                        }
                        return true;
                    });
                for (int i = 0; i < smartwords.Count; i++)
                {
                    var smartword = smartwords[i];

                    smartword.EditorPosition.y = height;
                    var name = smartword.Id;
                    if (smartword.Tags.Count > 0)
                        name += " (" + smartword.TagText + ")";

                    smartword.EditorPosition = GUILayout.Window(i, new Rect(Screen.width - 750, smartword.EditorPosition.y - Pan.y, smartword.EditorPosition.width, smartword.EditorPosition.height), DrawSmartwords, smartword.Id);

                    height += smartword.EditorPosition.height + 50;
                }

            }

            GUILayout.Window(1001, new Rect(50, 50, 615, Screen.height * 0.65f), DrawSmartwordsList, "Smartwords Panel");
            GUILayout.Window(1003, new Rect(50, 50 + Screen.height * 0.65f + 25, 615, Screen.height - (50 + Screen.height * 0.65f + 25) - 50), DrawErrors, "Error Messages");

            using (new GUILayout.AreaScope(new Rect(Screen.width - 50, 100, Screen.width / 2, Screen.height)))
            {
                if (Pan.y + height > Screen.height)
                    Pan = new Vector2(0, Mathf.RoundToInt(GUILayout.VerticalScrollbar(Pan.y, 100, 0, height - (Screen.height - 300), GUILayout.Height(Screen.height - 300))));
            }

            if (FirstDraw)
            {
                FirstDraw = false;
                RefreshSmartwords();
            }

            Repaint();
            EndWindows();
        }

        private void DrawSmartwords(int windowId)
        {
            var smartwords = Data.Smartwords;
            if (Data.FilterByTags.Count > 0)
                smartwords = smartwords.FindAll(x =>
                {
                    for (var i = 0; i < Data.FilterByTags.Count; i++)
                    {
                        if (!x.Tags.Contains(Data.FilterByTags[i]))
                            return false;
                    }
                    return true;
                });

            var fixedHeight = EditorStyles.toolbar.fixedHeight;
            EditorStyles.toolbar.fixedHeight = 0;

            var wordWrap = EditorStyles.textArea.wordWrap;
            EditorStyles.textArea.wordWrap = true;
            EditorStyles.textField.wordWrap = true;

            var smartword = smartwords[windowId];

            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
            {
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                {
                    Data.MementoStack.CreateMemento();
                    Data.Smartwords.Remove(smartword);
                }
            }

            GUILayout.Space(50);


            Rect lastRect;




            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    EditorGUILayout.GetControlRect();
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(smartword.EditorPosition.width / 2 - 25, lastRect.y, smartword.EditorPosition.width, 18), "Data", EditorStyles.boldLabel);
            GUILayout.Space(1);

            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(25);
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                GUILayout.Space(5);
                using (new EditorGUILayout.HorizontalScope())
                {
                    EditorGUILayout.LabelField("Id:", GUILayout.Width(150));
                    if (GUILayout.Button(smartword.Id, EditorStyles.toolbarButton, GUILayout.Width(350)))
                    {
                        StringEditorPopup window = new StringEditorPopup(smartword.Id, (id) => Data.Smartwords.Find(x => x.Id.ToLower() == id.ToLower()) == null, (id) =>
                        {
                            Data.MementoStack.CreateMemento();
                            smartword.Id = id;
                        });
                        PopupWindow.Show(new Rect(0, 21, 100, 18), window);
                    }
                }

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Display Name: ", GUILayout.Width(150));
                {
                    var newDisplayName = EditorGUILayout.TextField(smartword.DisplayName, GUILayout.Width(350));
                    if (newDisplayName != smartword.DisplayName)
                        Data.MementoStack.CreateMemento();
                    smartword.DisplayName = newDisplayName;
                }
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Description: ", GUILayout.Width(150));
                {
                    var newDescription = EditorGUILayout.TextArea(smartword.Description, GUILayout.Width(350));
                    if (newDescription != smartword.Description)
                        Data.MementoStack.CreateMemento();
                    smartword.Description = newDescription;
                }
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("IsCollectable: ", GUILayout.Width(150));
                {
                    var newIsCollectable = EditorGUILayout.Toggle(smartword.IsCollectable, GUILayout.Width(350));
                    if (newIsCollectable != smartword.IsCollectable)
                        Data.MementoStack.CreateMemento();
                    smartword.IsCollectable = newIsCollectable;
                }
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                GUILayout.Space(5);
            }
            EditorGUILayout.EndHorizontal();

            GUILayout.Space(25);



            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    EditorGUILayout.GetControlRect();
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(smartword.EditorPosition.width / 2 - 25, lastRect.y, smartword.EditorPosition.width, 18), "Callbacks", EditorStyles.boldLabel);
            GUILayout.Space(1);

            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(25);
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                GUILayout.Space(5);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("On Collect: ", GUILayout.Width(150));
                {
                    var newOnCollectText = EditorGUILayout.TextArea(smartword.OnCollectText, GUILayout.Width(350));
                    if (smartword.OnCollectText != newOnCollectText)
                        Data.MementoStack.CreateMemento();
                    smartword.OnCollectText = newOnCollectText;
                }
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                GUILayout.Space(5);
            }
            EditorGUILayout.EndHorizontal();

            GUILayout.Space(25);

            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);

                var rect = GUILayoutUtility.GetLastRect();
                rect.x += 30;
                rect.y += 20;
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    if (GUILayout.Button("Edit", EditorStyles.toolbarButton, GUILayout.Width(60)))
                    {
                        TagEditorPopup window = new TagEditorPopup(smartword.Tags, (tags) => true, (tags) =>
                        {
                            Data.MementoStack.CreateMemento();
                            smartword.Tags = tags;
                        });
                        PopupWindow.Show(rect, window);
                    }
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(smartword.EditorPosition.width / 2 - 25, lastRect.y, smartword.EditorPosition.width, 18), "Tags", EditorStyles.boldLabel);
            GUILayout.Space(1);

            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(25);
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                GUILayout.Space(5);
                EditorGUILayout.LabelField(smartword.TagText);
                GUILayout.Space(5);
            }
            EditorGUILayout.EndHorizontal();


            GUILayout.Space(25);
            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);

                var rect = GUILayoutUtility.GetLastRect();
                rect.x += 30;
                rect.y += 20;
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    EditorGUILayout.GetControlRect();
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(smartword.EditorPosition.width / 2 - 25, lastRect.y, smartword.EditorPosition.width, 18), "Small Image", EditorStyles.boldLabel);
            GUILayout.Space(1);
            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(25);
            smartword.SmallImage.OnGUI(610);
            EditorGUILayout.EndHorizontal();

            GUILayout.Space(25);
            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);

                var rect = GUILayoutUtility.GetLastRect();
                rect.x += 30;
                rect.y += 20;
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    EditorGUILayout.GetControlRect();
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(smartword.EditorPosition.width / 2 - 25, lastRect.y, smartword.EditorPosition.width, 18), "Large Image", EditorStyles.boldLabel);
            GUILayout.Space(1);
            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(25);
            smartword.LargeImage.OnGUI(610);
            EditorGUILayout.EndHorizontal();

            GUILayout.Space(50);

        }

        private void RefreshSmartwords()
        {
            for (var i = 0; i < Data.Smartwords.Count; i++)
            {
                RefreshSmartword(Data.Smartwords[i]);
            }
        }

        private void RefreshSmartword(SmartwordsEditorData smartword)
        {
            var pos = smartword.EditorPosition;
            pos.width = 650;
            pos.height = 150;
            smartword.EditorPosition = pos;
        }

        private Vector2 _errorPos;
        void DrawErrors(int id)
        {
            var wordwrap = EditorStyles.label.wordWrap;
            EditorStyles.label.wordWrap = true;

            _errorPos = EditorGUILayout.BeginScrollView(_errorPos);
            for (var i = 0; i < _errorTags.Count; i++)
            {
                var tags = _errorTags[i];

                EditorGUILayout.LabelField("Location: " + tags[0] + "->" + tags[1] + "->" + tags[2]);
                EditorGUILayout.LabelField("Error: " + tags[3].Trim(), GUILayout.Width(350));
                if (GUILayout.Button("Go", GUILayout.Width(40)))
                {
                    Pan = new Vector2(0, Mathf.RoundToInt(Data.Smartwords.Find(x => x.Id == tags[0]).EditorPosition.y + Pan.y - 200));
                }
                EditorGUILayout.LabelField("----------------------------");
            }
            EditorGUILayout.EndScrollView();

            EditorStyles.label.wordWrap = wordwrap;
        }

        private Vector2 _smartwordListPosition;
        void DrawSmartwordsList(int windowId)
        {
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                if (GUILayout.Button("Add", EditorStyles.toolbarButton, GUILayout.Width(60)))
                {
                    Data.MementoStack.CreateMemento();
                    var smartword = new SmartwordsEditorData();
                    Data.Smartwords.Add(smartword);
                }
                GUILayout.Space(20);
                if (GUILayout.Button("Filter By Tags: " + (Data.FilterByTags.Count > 0 ? Data.FilterByTags.Aggregate((next, line) => next += ", " + line) : ""), EditorStyles.toolbarButton))
                {
                    TagEditorPopup window = new TagEditorPopup(Data.FilterByTags, (tags) => true, (tags) =>
                    {
                        Data.MementoStack.CreateMemento();
                        Data.FilterByTags = tags;
                    });
                    PopupWindow.Show(new Rect(200, 21, 100, 18), window);
                }
            }
            GUILayout.Space(25);

            _smartwordListPosition = EditorGUILayout.BeginScrollView(_smartwordListPosition, GUIStyle.none, GUI.skin.verticalScrollbar);
            var smartwords = Data.Smartwords;

            if (Data.FilterByTags.Count > 0)
                smartwords = smartwords.FindAll(x =>
                {
                    for (var i = 0; i < Data.FilterByTags.Count; i++)
                    {
                        if (!x.Tags.Contains(Data.FilterByTags[i]))
                            return false;
                    }
                    return true;
                });

            for (var i = 0; i < smartwords.Count; i++)
            {
                var smartword = smartwords[i];

                using (new EditorGUILayout.HorizontalScope())
                {
                    using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(610 - 75)))
                    {
                        if (GUILayout.Button(smartword.Id, EditorStyles.toolbarButton, GUILayout.Width(100)))
                        {
                            StringEditorPopup window = new StringEditorPopup(smartword.Id, (id) => Data.Smartwords.Find(x => x.Id.ToLower() == id.ToLower()) == null, (id) =>
                            {
                                Data.MementoStack.CreateMemento();
                                smartword.Id = id;
                            });
                            PopupWindow.Show(new Rect(0, -75, 100, 100), window);
                        }
                        if (GUILayout.Button("Go", EditorStyles.toolbarButton, GUILayout.Width(40)))
                        {
                            Pan = new Vector2(0, Mathf.RoundToInt(Data.Smartwords.Find(x => x.Id == smartword.Id).EditorPosition.y + Pan.y - 200));
                        }

                        if (GUILayout.Button(smartword.TagText, EditorStyles.toolbarButton))
                        {
                            TagEditorPopup window = new TagEditorPopup(smartword.Tags, (tags) => true, (tags) =>
                            {
                                Data.MementoStack.CreateMemento();
                                smartword.Tags = tags;
                            });
                            PopupWindow.Show(new Rect(200, 21, 100, 18), window);
                        }
                    }
                    using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(75)))
                    {
                        if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                        {
                            Data.MementoStack.CreateMemento();
                            Data.Smartwords.Remove(smartword);
                        }
                    }
                }

            }
            EditorGUILayout.EndScrollView();
        }
    }

    public class TagEditorPopup : PopupWindowContent
    {
        private List<string> _tags;
        private Func<List<string>, bool> _isValidCallback;
        private Action<List<string>> _onSaveCallback;

        public float Height(List<string> tags)
        {
            return tags.Count * 18 + 80;
        }

        public override Vector2 GetWindowSize()
        {
            return new Vector2(250, Height(_tags));
        }

        public TagEditorPopup(List<string> tags, Func<List<string>, bool> isValidCallback, Action<List<string>> onSaveCallback)
        {
            _tags = tags.ToList();
            _isValidCallback = isValidCallback;
            _onSaveCallback = onSaveCallback;
        }

        public override void OnGUI(Rect rect)
        {
            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));
            if (GUILayout.Button("Add", EditorStyles.toolbarButton, GUILayout.Width(100)))
            {
                _tags.Add("");
            }
            EditorGUILayout.EndHorizontal();


            for (var i = 0; i < _tags.Count; i++)
            {
                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
                _tags[i] = EditorGUILayout.TextField(_tags[i], EditorStyles.toolbarTextField);
                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                {
                    _tags.RemoveAt(i);
                    i--;
                }
                EditorGUILayout.EndHorizontal();
            }




            if (!_isValidCallback(_tags))
            {
                EditorGUILayout.HelpBox("There is an error with the list of tags.", MessageType.Warning);
            }
            else
            {
                GUILayout.Space(43);
                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));
                if (GUILayout.Button("Save", EditorStyles.toolbarButton))
                {
                    _onSaveCallback(_tags);
                    editorWindow.Close();
                }
                EditorGUILayout.EndHorizontal();
            }

        }
    }
}