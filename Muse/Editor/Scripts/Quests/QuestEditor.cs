using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using UnityEditor.Callbacks;

namespace Muse.Editors.Quests
{

    [Serializable]
    public class QuestEditorMementoStack
    {
        [SerializeField]
        private List<QuestEditorMemento> _undo = new List<QuestEditorMemento>();
        [SerializeField]
        private List<QuestEditorMemento> _redo = new List<QuestEditorMemento>();

        public Action<QuestEditorMemento> Restore = (T) => { Debug.Log("default Restore"); };
        public Func<QuestEditorMemento> GetMementoData = () => { Debug.Log("default getmementodata"); return null; };
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
    public class QuestEditorMemento
    {
        public List<QuestEditorData> Data = new List<QuestEditorData>();
        public List<string> FilterByTags = new List<string>();
    }

    [Serializable]
    public class QuestEditorData
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
        public List<string> GameFlagTriggers = new List<string>();
        public string TitleText = "";
        public string ActiveDescriptionText = "";
        public string CompleteDescriptionText = "";
        public string FailDescriptionText = "";
        public string RankDescriptionText = "";

        public enum TextTypes { Text, CSharp };
        public TextTypes TitleTextType = TextTypes.CSharp;
        public TextTypes ActiveDescriptionTextType = TextTypes.CSharp;
        public TextTypes CompleteDescriptionTextType = TextTypes.CSharp;
        public TextTypes FailDescriptionTextType = TextTypes.CSharp;
        public TextTypes RankDescriptionTextType;

        public string OnTriggeredText = "";
        public string OnActivateText = "";
        public string OnCompleteText = "";
        public string OnFailText = "";
        public uint MaxRank;
        public string OnRankChangeText = "";
        public string GetProgressText = "";
        public Rect EditorPosition = new Rect(400, 50, 650, 150);

        public QuestEditorData Clone()
        {
            QuestEditorData clone = new QuestEditorData();

            clone.Tags = Tags.ToList();
            clone.Id = Id;
            clone.GameFlagTriggers = GameFlagTriggers.ToList();
            clone.TitleText = TitleText;
            clone.ActiveDescriptionText = ActiveDescriptionText;
            clone.CompleteDescriptionText = CompleteDescriptionText;
            clone.FailDescriptionText = FailDescriptionText;
            clone.RankDescriptionText = RankDescriptionText;

            clone.TitleTextType = TitleTextType;
            clone.ActiveDescriptionTextType = ActiveDescriptionTextType;
            clone.CompleteDescriptionTextType = CompleteDescriptionTextType;
            clone.FailDescriptionTextType = FailDescriptionTextType;
            clone.RankDescriptionTextType = RankDescriptionTextType;

            clone.OnTriggeredText = OnTriggeredText;
            clone.OnActivateText = OnActivateText;
            clone.OnCompleteText = OnCompleteText;
            clone.OnFailText = OnFailText;
            clone.MaxRank = MaxRank;
            clone.OnRankChangeText = OnRankChangeText;
            clone.GetProgressText = GetProgressText;
            clone.EditorPosition = EditorPosition;

            return clone;
        }
    }

    public class QuestEditorPersistentData : ScriptableObject
    {
        public List<string> FilterByTags = new List<string>();
        public List<QuestEditorData> Quests = new List<QuestEditorData>();
        public QuestEditorMementoStack MementoStack = new QuestEditorMementoStack();

        public QuestEditorPersistentData()
        {
        }
    }

    public class QuestEditor : EditorWindow
    {
        public static QuestEditor Instance { get; private set; }

        public const string QUESTS_PATH = MuseEditor.GameDataPathRaw + "Quests/";

        public QuestEditorPersistentData Data;
        private static List<List<string>> _errorTags = new List<List<string>>();

        public Vector2 Pan;

        public static void Setup()
        {
            if (!System.IO.Directory.Exists(QUESTS_PATH))
                System.IO.Directory.CreateDirectory(QUESTS_PATH);
        }

        [MenuItem("Muse/Editors/Data/Quests")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<QuestEditor>();
            window.titleContent = new GUIContent("Quests");
            window.Show();

            Setup();

            Instance = window;
            window.Data = ScriptableObject.CreateInstance<QuestEditorPersistentData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "QuestEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Reload();
        }

        [DidReloadScripts]
        static void OnReload()
        {
            var windows = Resources.FindObjectsOfTypeAll<QuestEditor>();
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
                Instance.Data.Quests.Clear();
                for (var i = 0; i < memento.Data.Count; i++)
                {
                    Instance.Data.Quests.Add(memento.Data[i].Clone());
                }
                Instance.Data.FilterByTags = memento.FilterByTags.ToList();
            };
            Instance.Data.MementoStack.GetMementoData = () =>
            {
                Debug.Log("GetMementoData");
                var memento = new QuestEditorMemento();
                for (var i = 0; i < Instance.Data.Quests.Count; i++)
                {
                    var questData = Instance.Data.Quests[i];
                    memento.Data.Add(questData.Clone());
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
            var questFiles = Directory.GetFiles(QUESTS_PATH);

            var gameflagWriter = new ClassWriter();
            gameflagWriter.Name = "GameFlags";
            gameflagWriter.IsPartial = true;
            gameflagWriter.IsStatic = true;
            gameflagWriter.IsPublic = true;

            for (var i = 0; i < questFiles.Length; i++)
            {
                if (questFiles[i].Contains("quest"))
                    File.Delete(questFiles[i]);
            }

            for (var i = 0; i < Data.Quests.Count; i++)
            {
                var quest = Data.Quests[i];

                PropertyWriter propertyWriter;

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = "_Quest" + quest.Id + "Active";
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
                propertyWriter.Type = "bool";

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = "_Quest" + quest.Id + "Complete";
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
                propertyWriter.Type = "bool";

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = "_Quest" + quest.Id + "Fail";
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
                propertyWriter.Type = "bool";

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = "Quest" + quest.Id + "Active";
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                propertyWriter.Type = "bool";
                propertyWriter.AddGetterLine("return _Quest" + quest.Id + "Active;");
                propertyWriter.AddSetterLine("_Quest" + quest.Id + "Active = value;");

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = "Quest" + quest.Id + "Complete";
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                propertyWriter.Type = "bool";
                propertyWriter.AddGetterLine("return _Quest" + quest.Id + "Complete;");
                propertyWriter.AddSetterLine("_Quest" + quest.Id + "Complete = value;");

                propertyWriter = gameflagWriter.CreatePropertyWriter();
                propertyWriter.Name = "Quest" + quest.Id + "Fail";
                propertyWriter.IsStatic = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                propertyWriter.Type = "bool";
                propertyWriter.AddGetterLine("return _Quest" + quest.Id + "Fail;");
                propertyWriter.AddSetterLine("_Quest" + quest.Id + "Fail = value;");

                var classWriter = new ClassWriter();

                classWriter.AddTopLine("using UnityEngine;");
                classWriter.AddTopLine("using System;");
                classWriter.AddTopLine("using System.Collections;");
                classWriter.AddTopLine("using System.Collections.Generic;");
                classWriter.AddTopLine("");
                classWriter.AddTopLine("[Quest]");

                classWriter.Name = "Quest_" + quest.Id + " : Quest";
                classWriter.IsPublic = true;


                var method = classWriter.CreateMethodWriter();
                method.Name = "Quest_" + quest.Id;
                method.VisibilityType = MethodWriter.VisibilityTypes.Public;
                method.AddLine("///Id " + quest.Id);
                method.AddLine("Id = \"" + quest.Id + "\";");
                method.AddLine("///MaxRank " + quest.MaxRank);
                method.AddLine("MaxRank = " + quest.MaxRank + ";");
                method.AddLine("///Tags " + (quest.Tags.Count == 0 ? "" : quest.Tags.Aggregate((tag, next) => next += ";" + tag)));
                method.AddLine("Tags = new List<string>() {" + (quest.Tags.Count == 0 ? "" : quest.Tags.ConvertAll(x => "\"" + x + "\"").Aggregate((tag, next) => next += "," + tag)) + "};");
                method.AddLine("///GameFlagTriggers " + (quest.GameFlagTriggers.Count == 0 ? "" : quest.GameFlagTriggers.Aggregate((tag, next) => next += ";" + tag)));
                method.AddLine("GameFlagTriggers = new List<string>() {" + (quest.GameFlagTriggers.Count == 0 ? "" : quest.GameFlagTriggers.ConvertAll(x => "\"" + x + "\"").Aggregate((gameFlagTrigger, next) => next += "," + gameFlagTrigger)) + "};");

                method.AddLine("///TitleType " + Enum.GetName(typeof(QuestEditorData.TextTypes), quest.TitleTextType));
                //method.AddLine("///TitleText " + quest.TitleText);
                if (!string.IsNullOrEmpty(quest.TitleText))
                    method.AddLine("DynamicTitle = GetTitle;");
                method.AddLine("///ActiveType " + Enum.GetName(typeof(QuestEditorData.TextTypes), quest.ActiveDescriptionTextType));
                //method.AddLine("///ActiveText " + quest.ActiveDescriptionText);
                if (!string.IsNullOrEmpty(quest.ActiveDescriptionText))
                    method.AddLine("DynamicActiveDescription = GetActiveDescription;");
                method.AddLine("///CompleteType " + Enum.GetName(typeof(QuestEditorData.TextTypes), quest.CompleteDescriptionTextType));
                //method.AddLine("///CompleteText " + quest.CompleteDescriptionText);
                if (!string.IsNullOrEmpty(quest.CompleteDescriptionText))
                    method.AddLine("DynamicCompleteDescription = GetCompleteDescription;");
                method.AddLine("///FailType " + Enum.GetName(typeof(QuestEditorData.TextTypes), quest.FailDescriptionTextType));
                // method.AddLine("///FailText " + quest.FailDescriptionText);
                if (!string.IsNullOrEmpty(quest.FailDescriptionText))
                    method.AddLine("DynamicFailDescription = GetFailDescription;");
                method.AddLine("///RankDescriptionText " + quest.RankDescriptionText);
                if (!string.IsNullOrEmpty(quest.RankDescriptionText))
                    method.AddLine("DynamicRankDescription = GetRankDescription;");

                if (!string.IsNullOrEmpty(quest.OnTriggeredText))
                    method.AddLine((quest.OnTriggeredText.Contains("yield") ? "OnTriggeredBlocking" : "OnTriggered") + " = OnTriggeredCallback;");
                if (!string.IsNullOrEmpty(quest.OnActivateText))
                    method.AddLine((quest.OnActivateText.Contains("yield") ? "OnActivateBlocking" : "OnActivate") + " = OnActivateCallback;");
                if (!string.IsNullOrEmpty(quest.OnCompleteText))
                    method.AddLine((quest.OnCompleteText.Contains("yield") ? "OnCompleteBlocking" : "OnComplete") + " = OnCompleteCallback;");
                if (!string.IsNullOrEmpty(quest.OnFailText))
                    method.AddLine((quest.OnFailText.Contains("yield") ? "OnFailBlocking" : "OnFail") + " = OnFailCallback;");
                if (!string.IsNullOrEmpty(quest.OnRankChangeText))
                    method.AddLine((quest.OnRankChangeText.Contains("yield") ? "OnRankChangeBlocking" : "OnRankChange") + " = OnRankChangeCallback;");
                if (!string.IsNullOrEmpty(quest.GetProgressText))
                    method.AddLine("GetProgress = GetProgressCallback;");

                if (!string.IsNullOrEmpty(quest.TitleText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "GetTitle";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = "string";
                    if (quest.TitleTextType == QuestEditorData.TextTypes.Text)
                        method.AddLine("return \"" + quest.TitleText + "\";");
                    else
                        method.AddLines(quest.TitleText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(quest.ActiveDescriptionText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "GetActiveDescription";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = "string";
                    if (quest.ActiveDescriptionTextType == QuestEditorData.TextTypes.Text)
                        method.AddLine("return \"" + quest.ActiveDescriptionText + "\";");
                    else
                    {
                        var lines = quest.ActiveDescriptionText.Split('\n');
                        method.AddLines(lines);
                    }
                }

                if (!string.IsNullOrEmpty(quest.CompleteDescriptionText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "GetCompleteDescription";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = "string";
                    if (quest.CompleteDescriptionTextType == QuestEditorData.TextTypes.Text)
                        method.AddLine("return \"" + quest.CompleteDescriptionText + "\";");
                    else
                        method.AddLines(quest.CompleteDescriptionText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(quest.FailDescriptionText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "GetFailDescription";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = "string";
                    if (quest.FailDescriptionTextType == QuestEditorData.TextTypes.Text)
                        method.AddLine("return \"" + quest.FailDescriptionText + "\";");
                    else
                        method.AddLines(quest.FailDescriptionText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(quest.RankDescriptionText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "GetRankDescription";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = "string";
                    method.AddLines(quest.RankDescriptionText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(quest.OnTriggeredText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "OnTriggeredCallback";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = quest.OnTriggeredText.Contains("yield") ? "IEnumerator" : "void";
                    method.AddLines(quest.OnTriggeredText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(quest.OnActivateText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "OnActivateCallback";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = quest.OnActivateText.Contains("yield") ? "IEnumerator" : "void";
                    method.AddLines(quest.OnActivateText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(quest.OnCompleteText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "OnCompleteCallback";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = quest.OnCompleteText.Contains("yield") ? "IEnumerator" : "void";
                    method.AddLines(quest.OnCompleteText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(quest.OnFailText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "OnFailCallback";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = quest.OnFailText.Contains("yield") ? "IEnumerator" : "void";
                    method.AddLines(quest.OnFailText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(quest.OnRankChangeText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "OnRankChangeCallback";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.AddArg(new MethodArg() { Name = "oldRank", Type = "int" });
                    method.AddArg(new MethodArg() { Name = "newRank", Type = "int" });
                    method.ReturnType = quest.OnRankChangeText.Contains("yield") ? "IEnumerator" : "void";
                    method.AddLines(quest.OnRankChangeText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(quest.GetProgressText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "GetProgressCallback";
                    method.AddArg(new MethodArg() { Name = "quest", Type = "Quest" });
                    method.ReturnType = "float";
                    method.AddLine(quest.GetProgressText);
                }


                classWriter.WritePath(QUESTS_PATH + "quest_" + quest.Id + ".cs");
            }
            gameflagWriter.WritePath(QUESTS_PATH + "GameFlags.cs");

            AssetDatabase.Refresh();
        }

        void Reload()
        {
            var questFiles = Directory.GetFiles(QUESTS_PATH);

            Data.Quests.Clear();

            for (var i = 0; i < questFiles.Length; i++)
            {
                var path = questFiles[i];
                if (!path.Contains("quest") || path.Contains(".meta"))
                    continue;

                Debug.Log("path: " + path);
                var classWriter = ClassWriter.Load(path);

                Debug.Log(classWriter.Name);

                var quest = new QuestEditorData();
                Data.Quests.Add(quest);

                var body = classWriter.GetMethod(classWriter.Name.Replace(" : Quest", ""));
                var bodyLines = body.Lines.ToList();

                Debug.Log(body.GetText());
                quest.Id = bodyLines.Find(x => x.Contains("///Id")).Replace("///Id", "").Trim();
                Debug.Log(quest.Id);
                quest.MaxRank = uint.Parse(bodyLines.Find(x => x.Contains("///MaxRank")).Replace("///MaxRank", "").Trim());
                Debug.Log(quest.MaxRank);
                Debug.Log(quest.Id);

                var tagsText = bodyLines.Find(x => x.Contains("///Tags")).Replace("///Tags", "").Trim();
                if (tagsText.Length == 0)
                    quest.Tags = new List<string>();
                else
                    quest.Tags = new List<string>(tagsText.Split(';'));

                var gameFlagsText = bodyLines.Find(x => x.Contains("///GameFlagTriggers")).Replace("///GameFlagTriggers", "").Trim();
                if (gameFlagsText.Length == 0)
                    quest.GameFlagTriggers = new List<string>();
                else
                    quest.GameFlagTriggers = new List<string>(gameFlagsText.Split(';'));

                if (classWriter.GetMethod("GetTitle") != null)
                    quest.TitleText = classWriter.GetMethod("GetTitle").GetText();
                if (classWriter.GetMethod("GetActiveDescription") != null)
                    quest.ActiveDescriptionText = classWriter.GetMethod("GetActiveDescription").GetText();
                if (classWriter.GetMethod("GetCompleteDescription") != null)
                    quest.CompleteDescriptionText = classWriter.GetMethod("GetCompleteDescription").GetText();
                if (classWriter.GetMethod("GetFailDescription") != null)
                    quest.FailDescriptionText = classWriter.GetMethod("GetFailDescription").GetText();
                ////quest.ActiveDescriptionText = bodyLines.Find(x => x.Contains("///ActiveText")).Replace("///ActiveText", "").Trim();
                // quest.CompleteDescriptionText = bodyLines.Find(x => x.Contains("///CompleteText")).Replace("///CompleteText", "").Trim();
                //quest.FailDescriptionText = bodyLines.Find(x => x.Contains("///FailText" )).Replace("///FailText", "").Trim();
                quest.RankDescriptionText = bodyLines.Find(x => x.Contains("///RankDescriptionText")).Replace("///RankDescriptionText", "").Trim();
                if (classWriter.GetMethod("OnTriggeredCallback") != null)
                    quest.OnTriggeredText = classWriter.GetMethod("OnTriggeredCallback").GetText();
                if (classWriter.GetMethod("OnActivateCallback") != null)
                    quest.OnActivateText = classWriter.GetMethod("OnActivateCallback").GetText();
                if (classWriter.GetMethod("OnCompleteCallback") != null)
                    quest.OnCompleteText = classWriter.GetMethod("OnCompleteCallback").GetText();
                if (classWriter.GetMethod("OnFailCallback") != null)
                    quest.OnFailText = classWriter.GetMethod("OnFailCallback").GetText();
                if (classWriter.GetMethod("OnRankChangeCallback") != null)
                    quest.OnRankChangeText = classWriter.GetMethod("OnRankChangeCallback").GetText();
                if (classWriter.GetMethod("OnGetProgressCallback") != null)
                    quest.GetProgressText = classWriter.GetMethod("GetProgressCallback").GetText();

                quest.TitleTextType = (QuestEditorData.TextTypes)Enum.Parse(typeof(QuestEditorData.TextTypes), bodyLines.Find(x => x.Contains("///TitleType")).Replace("///TitleType", "").Trim());
                quest.ActiveDescriptionTextType = (QuestEditorData.TextTypes)Enum.Parse(typeof(QuestEditorData.TextTypes), bodyLines.Find(x => x.Contains("///ActiveType")).Replace("///ActiveType", "").Trim());
                quest.CompleteDescriptionTextType = (QuestEditorData.TextTypes)Enum.Parse(typeof(QuestEditorData.TextTypes), bodyLines.Find(x => x.Contains("///CompleteType")).Replace("///CompleteType", "").Trim());
                quest.FailDescriptionTextType = (QuestEditorData.TextTypes)Enum.Parse(typeof(QuestEditorData.TextTypes), bodyLines.Find(x => x.Contains("///FailType")).Replace("///FailType", "").Trim());
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

            if (GUILayout.Button("File", EditorStyles.toolbarDropDown, GUILayout.Width(50)))
            {
                GenericMenu fileMenu = new GenericMenu();

                fileMenu.AddItem(new GUIContent("Reload"), false, () =>
                {
                    if (!EditorUtility.DisplayDialog("Reload Quests?",
                               "Are you sure you want to reload all quest data? Any unsaved changes will be lost!", "Reload Data",
                               "Cancel"))
                        return;
                    Reload();
                });
                fileMenu.AddItem(new GUIContent("Save"), false, () =>
                {
                    Save();
                });

                fileMenu.DropDown(new Rect(5, -5, 0, 30));
                EditorGUIUtility.ExitGUI();
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
                var quests = Data.Quests;
                if (Data.FilterByTags.Count > 0)
                    quests = quests.FindAll(x =>
                    {
                        for (var i = 0; i < Data.FilterByTags.Count; i++)
                        {
                            if (!x.Tags.Contains(Data.FilterByTags[i]))
                                return false;
                        }
                        return true;
                    });
                for (int i = 0; i < quests.Count; i++)
                {
                    var quest = quests[i];

                    quest.EditorPosition.y = height;
                    var name = quest.Id;
                    if (quest.Tags.Count > 0)
                        name += " (" + quest.TagText + ")";

                    quest.EditorPosition = GUILayout.Window(i, new Rect(Screen.width - 690, quest.EditorPosition.y - Pan.y, quest.EditorPosition.width, quest.EditorPosition.height), DrawQuest, quest.Id);

                    height += quest.EditorPosition.height + 50;
                }

            }

            GUILayout.Window(1001, new Rect(50, 50, 615, Screen.height * 0.65f), DrawQuestList, "Quest Panel");
            GUILayout.Window(1003, new Rect(50, 50 + Screen.height * 0.65f + 25, 615, Screen.height - (50 + Screen.height * 0.65f + 25) - 50), DrawErrors, "Error Messages");

            using (new GUILayout.AreaScope(new Rect(Screen.width - 20, 18, Screen.width / 2, Screen.height)))
            {
                if (Pan.y + height > Screen.height)
                    Pan = new Vector2(0, Mathf.RoundToInt(GUILayout.VerticalScrollbar(Pan.y, 100, 0, height - (Screen.height - 300), GUILayout.Height(Screen.height - 36))));
            }

            if (FirstDraw)
            {
                FirstDraw = false;
                RefreshQuests();
            }

            Repaint();
            EndWindows();
        }

        private void DrawQuest(int windowId)
        {
            var quests = Data.Quests;
            if (Data.FilterByTags.Count > 0)
                quests = quests.FindAll(x =>
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

            var quest = quests[windowId];

            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
            {
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                {
                    Data.MementoStack.CreateMemento();
                    Data.Quests.Remove(quest);
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
            GUI.Label(new Rect(quest.EditorPosition.width / 2 - 25, lastRect.y, quest.EditorPosition.width, 18), "Data", EditorStyles.boldLabel);
            GUILayout.Space(1);

            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(25);
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                GUILayout.Space(5);



                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.LabelField("Id: ", GUILayout.Width(150));
                if (GUILayout.Button(quest.Id, EditorStyles.toolbarButton, GUILayout.Width(350)))
                {
                    StringEditorPopup window = new StringEditorPopup(quest.Id, (id) => Data.Quests.Find(x => x.Id.ToLower() == id.ToLower()) == null, (id) =>
                    {
                        Data.MementoStack.CreateMemento();
                        quest.Id = id;
                    });
                    PopupWindow.Show(new Rect(200, 35, 100, 100), window);
                }
                
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.LabelField("Title: ", GUILayout.Width(150));
                {
                    var newTitleText = EditorGUILayout.TextArea(quest.TitleText, GUILayout.Width(350));
                    if (newTitleText != quest.TitleText)
                        Data.MementoStack.CreateMemento();
                    quest.TitleText = newTitleText;
                }
                EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                /*
                {
                    var newTitleTextType = (QuestEditorData.TextTypes)EditorGUILayout.EnumPopup(quest.TitleTextType, EditorStyles.toolbarDropDown);
                    if (newTitleTextType != quest.TitleTextType)
                        Data.MementoStack.CreateMemento();
                    quest.TitleTextType = newTitleTextType;
                }*/
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);


                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Active Description: ", GUILayout.Width(150));
                {
                    var newActiveDescriptionText = EditorGUILayout.TextArea(quest.ActiveDescriptionText, GUILayout.Width(350));
                    if (newActiveDescriptionText != quest.ActiveDescriptionText)
                        Data.MementoStack.CreateMemento();
                    quest.ActiveDescriptionText = newActiveDescriptionText;
                }
                EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                /*
                {
                    var newActiveDescriptionTextType = (QuestEditorData.TextTypes)EditorGUILayout.EnumPopup(quest.ActiveDescriptionTextType, EditorStyles.toolbarDropDown);
                    if (newActiveDescriptionTextType != quest.ActiveDescriptionTextType)
                        Data.MementoStack.CreateMemento();
                    quest.ActiveDescriptionTextType = newActiveDescriptionTextType;
                }*/
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Completed Description: ", GUILayout.Width(150));
                {
                    var newCompleteDescriptionText = EditorGUILayout.TextArea(quest.CompleteDescriptionText, GUILayout.Width(350));
                    if (newCompleteDescriptionText != quest.CompleteDescriptionText)
                        Data.MementoStack.CreateMemento();
                    quest.CompleteDescriptionText = newCompleteDescriptionText;
                }
                EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                /*
                {
                    var newCompletedDescriptionTextType = (QuestEditorData.TextTypes)EditorGUILayout.EnumPopup(quest.CompleteDescriptionTextType, EditorStyles.toolbarDropDown);
                    if (newCompletedDescriptionTextType != quest.CompleteDescriptionTextType)
                        Data.MementoStack.CreateMemento();
                    quest.CompleteDescriptionTextType = newCompletedDescriptionTextType;
                }*/
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Failed Description: ", GUILayout.Width(150));
                {
                    var newFailDescriptionText = EditorGUILayout.TextArea(quest.FailDescriptionText, GUILayout.Width(350));
                    if (newFailDescriptionText != quest.FailDescriptionText)
                        Data.MementoStack.CreateMemento();
                    quest.FailDescriptionText = newFailDescriptionText;
                }
                EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                /*
                {
                    var newFailDescriptionTextType = (QuestEditorData.TextTypes)EditorGUILayout.EnumPopup(quest.FailDescriptionTextType, EditorStyles.toolbarDropDown);
                    if (newFailDescriptionTextType != quest.FailDescriptionTextType)
                        Data.MementoStack.CreateMemento();
                    quest.FailDescriptionTextType = newFailDescriptionTextType;
                }*/
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Max Rank: ", GUILayout.Width(150));
                {
                    var newMaxRank = (uint)EditorGUILayout.IntField((int)quest.MaxRank, GUILayout.Width(350));
                    if (newMaxRank != quest.MaxRank)
                        Data.MementoStack.CreateMemento();
                    quest.MaxRank = newMaxRank;
                }
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);


                if (quest.MaxRank > 0)
                {
                    EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Rank Description: ", GUILayout.Width(150));
                    {
                        var rankDescriptionText = EditorGUILayout.TextArea(quest.RankDescriptionText, GUILayout.Width(350));
                        if (rankDescriptionText != quest.RankDescriptionText)
                            Data.MementoStack.CreateMemento();
                        quest.RankDescriptionText = rankDescriptionText;
                    }
                    EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                    EditorGUILayout.EndHorizontal();
                    GUILayout.Space(2);
                }



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
            GUI.Label(new Rect(quest.EditorPosition.width / 2 - 25, lastRect.y, quest.EditorPosition.width, 18), "Callbacks", EditorStyles.boldLabel);
            GUILayout.Space(1);

            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(25);
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                GUILayout.Space(5);


                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("OnTriggered: ", GUILayout.Width(150));
                {
                    var newOnTriggeredText = EditorGUILayout.TextArea(quest.OnTriggeredText, GUILayout.Width(400));
                    if (newOnTriggeredText != quest.OnTriggeredText)
                        Data.MementoStack.CreateMemento();
                    quest.OnTriggeredText = newOnTriggeredText;
                }
                EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("OnActivate: ", GUILayout.Width(150));
                {
                    var newOnActivateText = EditorGUILayout.TextArea(quest.OnActivateText, GUILayout.Width(400));
                    if (newOnActivateText != quest.OnActivateText)
                        Data.MementoStack.CreateMemento();
                    quest.OnActivateText = newOnActivateText;
                }
                EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("OnComplete: ", GUILayout.Width(150));
                {
                    var newOnCompleteText = EditorGUILayout.TextArea(quest.OnCompleteText, GUILayout.Width(400));
                    if (newOnCompleteText != quest.OnCompleteText)
                        Data.MementoStack.CreateMemento();
                    quest.OnCompleteText = newOnCompleteText;
                }
                EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("OnFailed: ", GUILayout.Width(150));
                {
                    var newOnFailText = EditorGUILayout.TextArea(quest.OnFailText, GUILayout.Width(400));
                    if (newOnFailText != quest.OnFailText)
                        Data.MementoStack.CreateMemento();
                    quest.OnFailText = newOnFailText;//
                }
                EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("GetProgress: ", GUILayout.Width(150));
                {
                    var newGetProgressText = EditorGUILayout.TextArea(quest.GetProgressText, GUILayout.Width(400));
                    if (newGetProgressText != quest.GetProgressText)
                        Data.MementoStack.CreateMemento();
                    quest.GetProgressText = newGetProgressText;
                }
                EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(2);

                if (quest.MaxRank > 0)
                {
                    EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("OnRankChanged: ", GUILayout.Width(150));
                    {
                        var newOnRankChangeText = EditorGUILayout.TextArea(quest.OnRankChangeText, GUILayout.Width(400));
                        if (newOnRankChangeText != quest.OnRankChangeText)
                            Data.MementoStack.CreateMemento();
                        quest.OnRankChangeText = newOnRankChangeText;
                    }
                    EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                    EditorGUILayout.EndHorizontal();
                    GUILayout.Space(2);
                }


                GUILayout.Space(5);
            }
            EditorGUILayout.EndHorizontal();

            GUILayout.Space(25);

            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    if (GUILayout.Button("Add", EditorStyles.toolbarButton, GUILayout.Width(60)))
                    {
                        Data.MementoStack.CreateMemento();
                        quest.GameFlagTriggers.Add("");
                        //RefreshQuest(quest);
                    }
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(quest.EditorPosition.width / 2 - 70, lastRect.y, quest.EditorPosition.width, 18), "GameFlag Triggers", EditorStyles.boldLabel);
            GUILayout.Space(1);

            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(25);
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                GUILayout.Space(5);
                for (var i = 0; i < quest.GameFlagTriggers.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        EditorGUILayout.BeginHorizontal();
                        GUILayout.Space(40);
                    }
                    EditorGUILayout.BeginHorizontal();
                    {
                        var newGameFlagTrigger = EditorGUILayout.TextField(quest.GameFlagTriggers[i], EditorStyles.toolbarTextField, GUILayout.Width(200));
                        if (newGameFlagTrigger != quest.GameFlagTriggers[i])
                            Data.MementoStack.CreateMemento();
                        quest.GameFlagTriggers[i] = newGameFlagTrigger;
                    }
                    if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                    {
                        Data.MementoStack.CreateMemento();
                        quest.GameFlagTriggers.RemoveAt(i);
                        i--;
                        //RefreshQuest(quest);
                    }
                    EditorGUILayout.EndHorizontal();
                    GUILayout.Space(2);

                    if (i % 2 == 1 || i == quest.GameFlagTriggers.Count - 1)
                        EditorGUILayout.EndHorizontal();
                }
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
                        TagEditorPopup window = new TagEditorPopup(quest.Tags, (tags) => true, (tags) =>
                        {
                            Data.MementoStack.CreateMemento();
                            quest.Tags = tags;
                        });
                        PopupWindow.Show(rect, window);
                    }
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(quest.EditorPosition.width / 2 - 25, lastRect.y, quest.EditorPosition.width, 18), "Tags", EditorStyles.boldLabel);
            GUILayout.Space(1);

            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(25);
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                GUILayout.Space(5);
                EditorGUILayout.LabelField(quest.TagText);
                GUILayout.Space(5);
            }
            EditorGUILayout.EndHorizontal();


            GUILayout.Space(50);

        }

        private void RefreshQuests()
        {
            for (var i = 0; i < Data.Quests.Count; i++)
            {
                RefreshQuest(Data.Quests[i]);
            }
        }

        private void RefreshQuest(QuestEditorData quest)
        {
            var pos = quest.EditorPosition;
            pos.width = 650;
            pos.height = 150;
            quest.EditorPosition = pos;
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
                    Pan = new Vector2(0, Data.Quests.Find(x => x.Id == tags[0]).EditorPosition.y + Pan.y - 200);
                }
                EditorGUILayout.LabelField("----------------------------");
            }
            EditorGUILayout.EndScrollView();

            EditorStyles.label.wordWrap = wordwrap;
        }

        private Vector2 _questListPosition;
        void DrawQuestList(int windowId)
        {
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                if (GUILayout.Button("Add", EditorStyles.toolbarButton, GUILayout.Width(60)))
                {
                    Data.MementoStack.CreateMemento();
                    var quest = new QuestEditorData();
                    Data.Quests.Add(quest);
                }
                GUILayout.Space(20);
                if (GUILayout.Button("Filter By Tags: " + (Data.FilterByTags.Count > 0 ? Data.FilterByTags.Aggregate((next, line) => next += ", " + line) : ""), EditorStyles.toolbarButton))
                {
                    TagEditorPopup window = new TagEditorPopup(Data.FilterByTags, (tags) => true, (tags) =>
                    {
                        Data.FilterByTags = tags;
                    });
                    PopupWindow.Show(new Rect(200, 21, 100, 18), window);
                }
            }
            GUILayout.Space(25);

            _questListPosition = EditorGUILayout.BeginScrollView(_questListPosition, GUIStyle.none, GUI.skin.verticalScrollbar);
            var quests = Data.Quests;

            if (Data.FilterByTags.Count > 0)
                quests = quests.FindAll(x =>
                {
                    for (var i = 0; i < Data.FilterByTags.Count; i++)
                    {
                        if (!x.Tags.Contains(Data.FilterByTags[i]))
                            return false;
                    }
                    return true;
                });

            for (var i = 0; i < quests.Count; i++)
            {
                var quest = quests[i];

                using (new EditorGUILayout.HorizontalScope())
                {
                    using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(610 - 75)))
                    {
                        if (GUILayout.Button(quest.Id, EditorStyles.toolbarButton, GUILayout.Width(100)))
                        {
                            StringEditorPopup window = new StringEditorPopup(quest.Id, (id) => Data.Quests.Find(x => x.Id.ToLower() == id.ToLower()) == null, (id) =>
                            {
                                Data.MementoStack.CreateMemento();
                                quest.Id = id;
                            });
                            PopupWindow.Show(new Rect(25, i * 18 - 82, 100, 100), window);
                        }
                        if (GUILayout.Button("Go", EditorStyles.toolbarButton, GUILayout.Width(40)))
                        {
                            Pan = new Vector2(0, Data.Quests.Find(x => x.Id == quest.Id).EditorPosition.y + Pan.y - 200);
                        }

                        if (GUILayout.Button(quest.TagText, EditorStyles.toolbarButton))
                        {
                            TagEditorPopup window = new TagEditorPopup(quest.Tags, (tags) => true, (tags) =>
                            {
                                Data.MementoStack.CreateMemento();
                                quest.Tags = tags;
                            });
                            PopupWindow.Show(new Rect(200, 21, 100, 18), window);
                        }
                    }
                    using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(75)))
                    {
                        if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                        {
                            Data.MementoStack.CreateMemento();
                            Data.Quests.Remove(quest);
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