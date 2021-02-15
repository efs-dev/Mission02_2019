using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

using System;
using System.IO;

using Efs.Dialogs;
using UnityEditor.Callbacks;
using System.Linq;
using System.Text;

using Amazon.Polly;
using Amazon.Polly.Model;
using System.Collections;

using Muse.Editors.Audio;
using Muse.Editors.GameFlags;

namespace Muse.Editors.Dialogs
{

    [Serializable]
    public class DialogEditorMementoStack
    {
        [SerializeField]
        private List<DialogEditorMemento> _undo = new List<DialogEditorMemento>();
        [SerializeField]
        private List<DialogEditorMemento> _redo = new List<DialogEditorMemento>();

        public int UndoCount { get { return _undo.Count; } }
        public int RedoCount { get { return _redo.Count; } }

        public Action<DialogEditorMemento> Restore = (T) => { Debug.Log("default Restore"); };
        public Func<DialogEditorMemento> GetMementoData = () => { return null; };
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
    public class DialogEditorMemento
    {
        public Dialog Dialog;
        public List<GameFlagData> GameFlags = new List<GameFlagData>();
        public DialogEditorPage.EditorStates EditorState;
        public Vector2 Pan;
    }

    [Serializable]
    public class DialogEditorPage
    {
        public string Title
        {
            get
            {
                return Dialog.Id;
            }
        }
        public Dialog Dialog;
        public List<GameFlagData> GameFlags = new List<GameFlagData>();
        public List<DialogNode> Nodes;
        public Vector2 Pan;

        public List<GameFlagData> CloneGameFlags()
        {
            List<GameFlagData> gameFlags = new List<GameFlagData>();
            for (var i = 0; i < GameFlags.Count; i++)
            {
                var gf = GameFlags[i];
                var newGf = new GameFlagData();
                newGf.Name = gf.Name;
                newGf.Value = gf.Value;
                newGf.VariableType = gf.VariableType;
                gameFlags.Add(newGf);
            }
            return gameFlags;
        }

        public enum EditorStates { NodeList, DialogGameFlags };
        public EditorStates EditorState;

        public List<DialogError> Errors = new List<DialogError>();

        public int GameFlagsHash;

        public DialogEditorMementoStack MementoStack = new DialogEditorMementoStack();

        public int GetGameFlagsHash()
        {
            return GameFlags.Count == 0 ? 0 : Utils.CombineHash(GameFlags.Count.GetHashCode(), GameFlags.ConvertAll<int>(x => Utils.CombineHash(x.Name.GetHashCode(), x.Value.GetHashCode(), x.VariableType.GetHashCode())).Aggregate((x, next) => Utils.CombineHash(x, next)));
        }

        public bool IsDirty()
        {
            return Dialog.GetHashCode() != Dialog.Hash || GetGameFlagsHash() != GameFlagsHash;
        }

    }

    [Serializable]
    public class DialogAddVOFilesData
    {
        public enum Steps { Process, AddToAudio, GeneratePromptMeta };
        public Steps CurrentStep;
        public enum Processes { SendMp3, WaitForConvert, Download, Complete };
        public Dictionary<string, Processes> FilesToProcess = new Dictionary<string, Processes>();
        public string Error;
    }

    public class DialogError
    {
        public string DialogId;
        public string NodeId;
        public string Message;
        public MessageType Type = MessageType.Error;
    }

    public class DialogEditorData : ScriptableObject
    {
        public GameFlagEditorDrawer GameFlags = new GameFlagEditorDrawer();
        public List<DialogEditorPage> Pages = new List<DialogEditorPage>();
        public int CurrentPageIndex;

        public List<DialogEditorPage> Dialogs = new List<DialogEditorPage>();
        public List<DialogEditorPage> OriginalDialogs = new List<DialogEditorPage>();
        public List<string> DialogsWithErrors = new List<string>();


        public Vector2 ScrollPos;

        public Texture2D ErrorImage;
        //public List<string> Npcs = new List<string>() { "Maw", "Paw", "Mse", "Mre", "Roy", "The", "Lan", "Whi" };

        public System.Reflection.Assembly Assembly;
        public Type LogEntries;
        public Type LogEntry;
        public Texture2D Background;

        public DialogAddVOFilesData AddVOFilesData;
    }

    public class DialogEditor : EditorWindow
    {
        public static DialogEditor Instance { get; private set; }

        public const string DialogDataPath = MuseEditor.GameDataPathRaw + "Dialogs/";

        public const float TopBarHeight = 25f;

        public DialogEditorPage CurrentPage
        {
            get
            {
                if (Data.Pages.Count == 0 || Data.CurrentPageIndex == -1)
                    return null;
                return Data.Pages[Data.CurrentPageIndex];
            }
        }

        public Dialog Dialog { get { return CurrentPage != null ? CurrentPage.Dialog : null; } }

        private List<DialogNode> Nodes { get { return CurrentPage != null ? CurrentPage.Nodes : null; } set { if (CurrentPage == null) return; CurrentPage.Nodes = value; } }

        private enum Modes { Read, Write };
        private Modes _mode;

        private bool _saveAs;
        private string _saveAsId;

        private bool AddVOModalWindow;


        private static List<List<string>> _errorTags = new List<List<string>>();

        public DialogEditorData Data;

        public static void Setup()
        {
            if (!System.IO.Directory.Exists(DialogDataPath))
                System.IO.Directory.CreateDirectory(DialogDataPath);
        }

        [MenuItem("Muse/Editors/Data/Dialogs")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<DialogEditor>();
            window.titleContent = new GUIContent("Dialogs");
           // window.minSize = new Vector2(1280, 768);
            window.Show();

            Instance = window;
            window.Data = ScriptableObject.CreateInstance<DialogEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "DialogEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Setup();

            window.Data.ErrorImage = Resources.Load<Texture2D>("error");

            window.LoadAllDialogs();
            window.Data.Pages.Clear();
            window.Data.CurrentPageIndex = -1;

            OnSetupMementoStack();

            window.Data.Assembly = System.Reflection.Assembly.GetAssembly(typeof(UnityEditor.SceneView));
            window.Data.LogEntries = window.Data.Assembly.GetType("UnityEditorInternal.LogEntries");
            window.Data.LogEntry = window.Data.Assembly.GetType("UnityEditorInternal.LogEntry");


            window.Data.Background = Resources.Load<Texture2D>("EditorBackground");

            RefreshErrors();

        }

        static void OnEnable()
        {
            Debug.Log("DialogEditor OnEnable");
        }

        [DidReloadScripts]
        static void OnDidReloadScripts()
        {
            var windows = Resources.FindObjectsOfTypeAll<DialogEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];

            OnSetupMementoStack();

            for (var i = 0; i < Instance.Data.Pages.Count; i++)
            {
                var page = Instance.Data.Pages[i];

                Instance.Data.Pages.RemoveAt(i);
                Instance.Data.Pages.Insert(i, Instance.Data.Dialogs.Find(x => x.Dialog.Id == page.Dialog.Id));
            }
        }

        static void OnSetupMementoStack()
        {
            for (var i = 0; i < Instance.Data.Pages.Count; i++)
            {
                Instance.Data.Pages[i].MementoStack.Restore = (memento) =>
                {
                    Instance.CurrentPage.Dialog = memento.Dialog.Clone();
                    Instance.CurrentPage.Nodes.Clear();
                    var nodes = Instance.CurrentPage.Dialog.GetNodes();

                    for (var j = 0; j < nodes.Count; j++)
                    {
                        Instance.CurrentPage.Nodes.Add(nodes[j]);
                    }

                    Instance.CurrentPage.Pan = memento.Pan;
                    Instance.CurrentPage.EditorState = memento.EditorState;

                    Instance.CurrentPage.GameFlags.Clear();
                    for (var j = 0; j < memento.GameFlags.Count; j++)
                    {
                        Instance.CurrentPage.GameFlags.Add(memento.GameFlags[j].Clone());
                    }
                };
                Instance.Data.Pages[i].MementoStack.GetMementoData = () =>
                {
                    var memento = new DialogEditorMemento();
                    memento.Dialog = Instance.CurrentPage.Dialog.Clone();
                    memento.EditorState = Instance.CurrentPage.EditorState;
                    memento.Pan = Instance.CurrentPage.Pan;

                    for (var j = 0; j < Instance.CurrentPage.GameFlags.Count; j++)
                    {
                        var flag = Instance.CurrentPage.GameFlags[j];
                        memento.GameFlags.Add(flag.Clone());
                    }

                    return memento;
                };
            }

        }


        void OnDestroy()
        {
            Instance = null;
        }

        private void RefreshConnections()
        {
            var connections = new List<ConnectionData>();
            for (int i = 0; i < Nodes.Count; i++)
            {
                var node = Nodes[i];
                if (node.From == null)
                    node.From = new Dictionary<string, float>();
            }

            for (int i = 0; i < Nodes.Count; i++)
            {
                var node = Nodes[i];

                var removeFromList = new List<string>();
                foreach (var fromId in node.From.Keys)
                {
                    if (!Dialog.ContainsNode(fromId))
                    {
                        removeFromList.Add(fromId);
                        continue;
                    }

                    var fromNode = Dialog.GetNode(fromId);

                    bool found = false;
                    var fromResponses = fromNode.GetResponses();
                    for (int j = 0; j < fromResponses.Length; j++)
                    {
                        var response = fromResponses[j];

                        if (response.NextNodeId == node.Id)
                            found = true;
                    }
                    if (!found)
                    {
                        //Debug.Log("didnt find from: " + fromId + " for node: " + node.Id);
                        removeFromList.Add(fromId);
                        continue;
                    }

                    if (connections.Find((x) => (x.From == node.Id && x.To == fromId) || (x.From == fromId && x.To == node.Id)) == null)
                        connections.Add(new ConnectionData() { From = node.Id, To = fromId });
                }

                for (int j = 0; j < removeFromList.Count; j++)
                    node.From.Remove(removeFromList[j]);

                var responses = node.GetResponses();
                for (int j = 0; j < responses.Length; j++)
                {
                    var response = responses[j];
                    if (!Dialog.ContainsNode(response.NextNodeId))
                        continue;

                    var nextNode = Dialog.GetNode(response.NextNodeId);

                    if (nextNode.Id == node.Id)
                        continue;

                    if (nextNode.From != null && !nextNode.From.ContainsKey(node.Id))
                        nextNode.From.Add(node.Id, 0);
                }
            }
        }

        void OnGUI()
        {
            if (Data == null)
            {
                Init();
            }

            Instance = this;
            GUI.DrawTextureWithTexCoords(new Rect(0, 0, Screen.width, Screen.height), Data.Background, new Rect(0, 0, Screen.width / Data.Background.width, Screen.height / Data.Background.height));

            if (Dialog != null)
            {
                Nodes = Dialog.GetNodes();
                Nodes.Sort((x, y) => x.Id.CompareTo(y.Id));
                RefreshConnections();
            }
            else if (Nodes == null)
                Nodes = new List<DialogNode>();


            OnDrawMainArea();
            OnDrawTopBar();

            CheckUndoRedo();
        }

        void CheckUndoRedo()
        {
            bool doesThisWinHaveFocus = EditorWindow.focusedWindow == this;
            bool wasUndoRedoPerformed = Event.current.type == EventType.ValidateCommand && Event.current.commandName == "UndoRedoPerformed";

            if (Event.current.type == EventType.keyUp && Event.current.control && Event.current.keyCode == KeyCode.U)
            {
                CurrentPage.MementoStack.Undo();
                Event.current.Use();
            }
            else if (Event.current.type == EventType.keyUp && Event.current.control && Event.current.keyCode == KeyCode.R)
            {
                CurrentPage.MementoStack.Redo();
                Event.current.Use();
            }
        }

        static void RefreshErrors()
        {
            if (Instance == null)
                Init();

            /*
            if (Instance.Data.Assembly == null)
            {
                Instance.Data.Assembly = System.Reflection.Assembly.GetAssembly(typeof(UnityEditor.SceneView));
                Instance.Data.LogEntries = Instance.Data.Assembly.GetType("UnityEditorInternal.LogEntries");
                Instance.Data.LogEntry = Instance.Data.Assembly.GetType("UnityEditorInternal.LogEntry");
            }

            var assembly = Instance.Data.Assembly;
            var logEntries = Instance.Data.LogEntries;
            var logEntry = Instance.Data.LogEntry;

            var numEntries = (int)logEntries.GetMethod("GetCount").Invoke(new object[] { }, null);

            _errorTags = new List<List<string>>();
            logEntries.GetMethod("StartGettingEntries").Invoke(null, new object[] { });
            for (var i = 0; i < numEntries; i++)
            {
                var logEntryInstance = logEntry.GetConstructor(new Type[] { }).Invoke(new object[] { });
                logEntries.GetMethod("GetEntryInternal").Invoke(null, new object[] { i, logEntryInstance });

                var file = logEntryInstance.GetType().GetField("file").GetValue(logEntryInstance).ToString();
                var line = (int)logEntryInstance.GetType().GetField("line").GetValue(logEntryInstance) - 1;
                var errorNum = logEntryInstance.GetType().GetField("errorNum").GetValue(logEntryInstance);
                var condition = logEntryInstance.GetType().GetField("condition").GetValue(logEntryInstance).ToString();

                var message = condition.Substring(condition.IndexOf(":") + 2, condition.Length - condition.IndexOf(":") - 2).Replace("error ", "");

                bool isError = condition.IndexOf("error") > -1;
                bool isDialog = Instance.Data.CurrentPageIndex == -1 ? file.IndexOf("dialog_") > -1 : file.IndexOf("dialog_" + Instance.CurrentPage.Dialog.Id) > -1;
                //Debug.Log("row " + i + " has entry: " + hasEntry);

                if (isError && isDialog)
                {
                    // Debug.Log(file);

                    // Debug.Log(line);
                    // Debug.Log(condition);

                    var lines = File.ReadAllLines(file);

                    for (var j = line; j > -1; j--)
                    {
                        var classLine = lines[j];


                        var errorTagIndex = classLine.IndexOf("///");

                        if (errorTagIndex == -1)
                            continue;


                        var startIndex = errorTagIndex + 3;
                        var errorTag = classLine.Substring(startIndex, classLine.Length - startIndex);



                        // Debug.Log("line: " + classLine);
                        // Debug.Log("errortag: " + errorTag);
                        var tags = errorTag.Split(' ');

                        switch (tags[0])
                        {
                            case "METHOD":
                            case "METHOD_BODY_START":
                            case "METHOD_BODY_END":
                                var parsed = tags[1].Split('_');
                                _errorTags.Add(new List<string>() { parsed[0], parsed[1], parsed[2], message });
                                break;
                            case "NODE_START":
                                _errorTags.Add(new List<string>() { tags[1], "Id", "", message });
                                break;
                            case "NODE_NPC":
                                _errorTags.Add(new List<string>() { tags[1], "Npc", "", message });
                                break;
                            case "PROMPT":
                                _errorTags.Add(new List<string>() { tags[1], "p" + tags[2], "Index", message });
                                break;
                            case "PROMPT_TEXT":
                                _errorTags.Add(new List<string>() { tags[1], "p" + tags[2], "Text", message });
                                break;
                            case "PROMPT_IGNORE_VO":
                                _errorTags.Add(new List<string>() { tags[1], "p" + tags[2], "IgnoreVO", message });
                                break;
                            case "RESPONSE":
                                _errorTags.Add(new List<string>() { tags[1], "r" + tags[2], "Index", message });
                                break;
                            case "RESPONSE_TEXT":
                                _errorTags.Add(new List<string>() { tags[1], "r" + tags[2], "Text", message });
                                break;
                            case "RESPONSE_NEXT_NODE_ID":
                                _errorTags.Add(new List<string>() { tags[1], "r" + tags[2], "NextNodeId", message });
                                break;
                            case "RESPONSE_NEXT_NODE_TYPE":
                                _errorTags.Add(new List<string>() { tags[1], "r" + tags[2], "NextNodeType", message });
                                break;
                        }



                        // Debug.Log(tags[0] + ", " + tags[1] + ", " + tags[2]);
                        break;
                    }

                    //Debug.Log("error: " + message);
                }
            }
            logEntries.GetMethod("EndGettingEntries").Invoke(null, new object[] { });
            */

        }

        void GeneratePromptVOFiles()
        {
            // TODO: add back 
            var path = Application.dataPath + "/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id;
            var files = Directory.GetFiles(path, "*.ogg", SearchOption.AllDirectories);

            for (var i = 0; i < files.Length; i++)
            {
                var file = files[i];
                Debug.Log(file);

                var www = new WWW("file:///" + file);
                while (!www.isDone) ;

                if (www.error != null)
                    Debug.Log(www.error);

                AudioClip audioClip = www.GetAudioClip(false, false, AudioType.OGGVORBIS);

                audioClip.LoadAudioData();

                var scale = 400;
                var numSamples = audioClip.samples / scale;
                var volumes = new float[numSamples];
                var samples = new float[audioClip.samples];
                audioClip.GetData(samples, 0);

                for (var j = 0; j < numSamples; j++)
                {
                    var vol = Mathf.Max(Mathf.Abs(samples[j * scale]), Mathf.Abs(samples[j * scale + 1]));
                    //Debug.Log(vol);
                    volumes[j] = vol;
                }

                // var filenameStart = file.LastIndexOf("\\");
                var filenameEnd = file.LastIndexOf(".");
                var filename = file.Substring(0, filenameEnd) + ".txt";
                // var sr = File.CreateText(Application.dataPath + "/Game/Data/DialogVolumes/" + filename);
                var bytes = new byte[volumes.Length];
                for (var j = 0; j < volumes.Length; j++)
                {
                    var vol = volumes[j];
                    byte val = byte.Parse((vol <= 0.0002f ? 0 : 1).ToString());
                    bytes[j] = val;
                }

                File.WriteAllBytes(filename, bytes);
            }
        }

        private void OnDrawTopBar()
        {
            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));

            if (Data.CurrentPageIndex == -1)
            {
                if (GUILayout.Button("Save All", EditorStyles.toolbarButton, GUILayout.Width(80)))
                    SaveAll();
            }
            else
            {
                GUI.enabled = CurrentPage.IsDirty();
                if (GUILayout.Button("Save Current", EditorStyles.toolbarButton, GUILayout.Width(80)))
                    SaveAll();

                GUI.enabled = CurrentPage.MementoStack.UndoCount > 0;
                if (GUILayout.Button("Undo", EditorStyles.toolbarButton, GUILayout.Width(50)))
                {
                    CurrentPage.MementoStack.Undo();
                    EditorGUI.FocusTextInControl(null);
                }

                GUI.enabled = CurrentPage.MementoStack.RedoCount > 0;
                if (GUILayout.Button("Redo", EditorStyles.toolbarButton, GUILayout.Width(50)))
                {
                    CurrentPage.MementoStack.Redo();
                    EditorGUI.FocusTextInControl(null);
                }
                GUI.enabled = true;


            }




            GUILayout.Space(10);

            EditorGUILayout.EndHorizontal();
            /*
            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
            for (var i = 0; i < Data.Pages.Count; i++)
            {
                var page = Data.Pages[i];

                var rect = EditorGUILayout.GetControlRect(GUILayout.Width(230), GUILayout.Height(EditorGUIUtility.singleLineHeight+4));
                var color = i == Data.CurrentPageIndex ? Color.yellow : Color.white;
                GUI.backgroundColor = color;

                if (GUI.Button(new Rect(rect.x, rect.y, 200, rect.height), page.Dialog.Id, EditorStyles.toolbarButton))
                {
                    Data.CurrentPageIndex = i;
                }
                if (GUI.Button(new Rect(rect.x + 200, rect.y, 30, rect.height), "X", EditorStyles.toolbarButton))
                {
                    if (!EditorUtility.DisplayDialog("Close Dialog?",
                               "Are you sure you want to close this dialog? Any unsaved changes will be lost!", "Close",
                               "Cancel"))
                        return;

                    if (Data.CurrentPageIndex > i)
                        Data.CurrentPageIndex--;
                    else if (Data.CurrentPageIndex == i && i == Data.Pages.Count - 1)
                        Data.CurrentPageIndex--;

                    Data.Pages.RemoveAt(i);
                    i--;

                }
            }
            GUI.backgroundColor = Color.white;
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
            */
        }

        private bool HasDialogErrors(Dialog dialog)
        {
            if (Event.current.type != EventType.layout)
                return false;

            var nodes = dialog.GetNodes();

            for (var i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];

                var compileErrors = _errorTags.FindAll(x => x[0] == node.Id);

                var prompts = node.GetPrompts();
                for (var j = 0; j < prompts.Length; j++)
                {
                    var prompt = prompts[j];

                    if (string.IsNullOrEmpty(prompt.Text))
                    {
                        return true;
                    }
                    var promptTextError = compileErrors.Find(x => x[1] == ("p" + j) && x[2] == "Text");
                    if (promptTextError != null)
                    {
                        return true;
                    }

                    var promptConditionText = compileErrors.Find(x => x[1] == ("p" + j) && x[2] == "condition");
                    if (promptConditionText != null)
                    {
                        return true;
                    }

                    if (string.IsNullOrEmpty(prompt.ConditionsText) && j != prompts.Length - 1)
                    {
                        return true;
                    }

                    if (!string.IsNullOrEmpty(prompt.ConditionsText) && !prompt.ConditionsText.Contains("return"))
                    {
                        return true;
                    }
                    var promptShowText = compileErrors.Find(x => x[1] == ("p" + j) && x[2] == "show");
                    if (promptShowText != null)
                    {
                        return true;
                    }

                    if (!prompt.IgnoreVO)
                    {
                        bool mp3Exists = File.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + dialog.Id + "/" + dialog.Id + "_" + node.Id + "_p" + j + ".mp3");
                        bool oggExists = File.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + dialog.Id + "/" + dialog.Id + "_" + node.Id + "_p" + j + ".ogg");
                        if (!oggExists && !mp3Exists)
                        {
                            return true;
                        }
                        else if (!oggExists)
                        {
                            return true;
                        }
                        else if (!mp3Exists)
                        {
                            return true;
                        }
                    }

                }
                var responses = node.GetResponses();
                for (var j = 0; j < responses.Length; j++)
                {
                    var response = responses[j];

                    var responseTextError = compileErrors.Find(x => x[1] == ("r" + j) && x[2] == "Text");
                    if (responseTextError != null)
                    {
                        return true;
                    }

                    if (string.IsNullOrEmpty(response.Text))
                    {
                        return true;
                    }
                    var responseConditionError = compileErrors.Find(x => x[1] == ("r" + j) && x[2] == "condition");
                    if (responseConditionError != null)
                    {
                        return true;
                    }

                    if (!string.IsNullOrEmpty(response.ConditionsText) && !response.ConditionsText.Contains("return"))
                    {
                        return true;
                    }
                    var responseNextNodeIdError = compileErrors.Find(x => x[1] == ("r" + j) && x[2].ToLower() == "nextnodeid");
                    if (responseNextNodeIdError != null)
                    {
                        return true;
                    }


                    var responseNextNodeTypeError = compileErrors.Find(x => x[1] == ("r" + j) && x[2] == "NextNodeType");
                    if (responseNextNodeTypeError != null)
                    {
                        return true;
                    }

                    if (response.NextNodeType == DialogResponse.NextNodeTypes.Id)
                    {
                        if (string.IsNullOrEmpty(response.NextNodeId))
                        {
                            return true;
                        }
                        else if (response.NextNodeId.ToLower() != "end" && !dialog.ContainsNode(response.NextNodeId))
                        {
                            return true;
                        }
                        else if (response.NextNodeId == node.Id)
                        {
                            return true;
                        }
                        else if (response.NextNodeId.ToLower() != "end" && dialog.GetNode(response.NextNodeId).IsDeleted)
                        {
                            return true;
                        }
                    }
                    else if (response.NextNodeType == DialogResponse.NextNodeTypes.Script)
                    {
                        if (string.IsNullOrEmpty(response.NextNodeText))
                        {
                            return true;
                        }
                        else if (!response.NextNodeText.Contains("return"))
                        {
                            return true;
                        }
                    }
                    var responseSelectError = compileErrors.Find(x => x[1] == ("r" + j) && x[2].ToLower() == "select");
                    if (responseSelectError != null)
                    {
                        return true;
                    }
                    var responseShowError = compileErrors.Find(x => x[1] == ("r" + j) && x[2].ToLower() == "show");
                    if (responseShowError != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void FindNodeErrors(DialogNode node)
        {
            if (Event.current.type != EventType.layout)
                return;
            var compileErrors = _errorTags.FindAll(x => x[0] == node.Id);

            var prompts = node.GetPrompts();
            for (var j = 0; j < prompts.Length; j++)
            {
                var prompt = prompts[j];

                if (string.IsNullOrEmpty(prompt.Text))
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Prompt text cannot be blank!" });
                }
                var promptTextError = compileErrors.Find(x => x[1] == ("p" + j) && x[2] == "Text");
                if (promptTextError != null)
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = promptTextError[3] });
                }

                var promptConditionText = compileErrors.Find(x => x[1] == ("p" + j) && x[2] == "condition");
                if (promptConditionText != null)
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = promptConditionText[3] });
                }

                if (string.IsNullOrEmpty(prompt.ConditionsText) && j != prompts.Length - 1)
                {
                    //Debug.Log(node.Id + ", " + j + ", " + prompt.ConditionsText);
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Empty conditions automatically return true. Any prompts below will never be shown." });
                }

                if (!string.IsNullOrEmpty(prompt.ConditionsText) && !prompt.ConditionsText.Contains("return"))
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Prompt conditions must return a value equals to true or false." });
                }
                var promptShowText = compileErrors.Find(x => x[1] == ("p" + j) && x[2] == "show");
                if (promptShowText != null)
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = promptShowText[3] });
                }

                if (!prompt.IgnoreVO)
                {
                    bool mp3Exists = File.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + j + ".mp3");
                    bool oggExists = File.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + j + ".ogg");
                    if (!oggExists && !mp3Exists)
                    {
                        CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "The VO files \"Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + j + ".ogg" + "\" and \"Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + j + ".mp3" + "\" do not exist." });
                    }
                    else if (!oggExists)
                    {
                        CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "The VO file \"Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + j + ".ogg" + "\" does not exist." });
                    }
                    else if (!mp3Exists)
                    {
                        CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "The VO file \"Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + j + ".mp3" + "\" does not exist." });
                    }
                }

            }
            var responses = node.GetResponses();
            for (var j = 0; j < responses.Length; j++)
            {
                var response = responses[j];

                var responseTextError = compileErrors.Find(x => x[1] == ("r" + j) && x[2] == "Text");
                if (responseTextError != null)
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = responseTextError[3] });
                }

                if (string.IsNullOrEmpty(response.Text))
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Response text cannot be blank!" });
                }
                var responseConditionError = compileErrors.Find(x => x[1] == ("r" + j) && x[2] == "condition");
                if (responseConditionError != null)
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = responseConditionError[3] });
                }

                if (!string.IsNullOrEmpty(response.ConditionsText) && !response.ConditionsText.Contains("return"))
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Response conditions must return a value equals to true or false." });
                }
                var responseNextNodeIdError = compileErrors.Find(x => x[1] == ("r" + j) && x[2].ToLower() == "nextnodeid");
                if (responseNextNodeIdError != null)
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = responseNextNodeIdError[3] });
                }


                var responseNextNodeTypeError = compileErrors.Find(x => x[1] == ("r" + j) && x[2] == "NextNodeType");
                if (responseNextNodeTypeError != null)
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = responseNextNodeTypeError[3] });
                }

                if (response.NextNodeType == DialogResponse.NextNodeTypes.Id)
                {
                    if (string.IsNullOrEmpty(response.NextNodeId))
                    {
                        CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Response NextNodeId cannot be blank!" });
                    }
                    else if (response.NextNodeId.ToLower() != "end" && !Dialog.ContainsNode(response.NextNodeId))
                    {
                        CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Response NextNodeId must be a valid node Id!" });
                    }
                    else if (response.NextNodeId == node.Id)
                    {
                        CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Response NextNodeId is pointing to itself! Make sure this is not a mistake.", Type = MessageType.Warning });
                    }
                    else if (response.NextNodeId.ToLower() != "end" && Dialog.GetNode(response.NextNodeId).IsDeleted)
                    {
                        CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Response NextNodeId is pointing to a node flagged for deletion!" });
                    }
                }
                else if (response.NextNodeType == DialogResponse.NextNodeTypes.Script)
                {
                    if (string.IsNullOrEmpty(response.NextNodeText))
                    {
                        CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Response NextNodeId cannot be blank" });
                    }
                    else if (!response.NextNodeText.Contains("return"))
                    {
                        CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = "Response NextNodeId cannot be blank" });
                    }
                }
                var responseSelectError = compileErrors.Find(x => x[1] == ("r" + j) && x[2].ToLower() == "select");
                if (responseSelectError != null)
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = responseSelectError[3] });
                }
                var responseShowError = compileErrors.Find(x => x[1] == ("r" + j) && x[2].ToLower() == "show");
                if (responseShowError != null)
                {
                    CurrentPage.Errors.Add(new DialogError() { NodeId = node.Id, Message = responseShowError[3] });
                }
            }
        }


        private bool _didScrollLastFrame;
        private bool FirstDraw { get; set; }
        private void OnDrawMainArea()
        {
            BeginWindows();
            var height = 50f;

            if (Data.CurrentPageIndex > -1)
            {
                if (AddVOModalWindow)
                {
                    GUI.Window(1005, new Rect(50, 50, 800, 600), DrawVOModalWindow, "Add VO Files");
                }
                else
                {
                    if (Event.current.type == EventType.layout)
                        CurrentPage.Errors.Clear();
                    using (new GUILayout.AreaScope(new Rect(0, 100, Screen.width, Screen.height / 2)))
                    {
                        if (Nodes != null)
                        {
                            for (int i = 0; i < Nodes.Count; i++)
                            {
                                var node = Nodes[i];
                                if (node.IsDeleted)
                                    continue;

                                node.EditorPosition.y = height;

                                if (node.EditorPosition.y + node.EditorPosition.height >= CurrentPage.Pan.y && node.EditorPosition.y <= CurrentPage.Pan.y + Screen.height)
                                {
                                    node.IsNodeVisible = true;
                                    node.EditorPosition = GUILayout.Window(i, new Rect(Screen.width - 700, node.EditorPosition.y - CurrentPage.Pan.y, node.EditorPosition.width, node.EditorPosition.height), DrawNode, node.Id);
                                    //Debug.Log("node on screen: " + node.Id);
                                }
                                else
                                    node.IsNodeVisible = false;
                                 //   GUILayout.Window(i, new Rect(Screen.width - 700, node.EditorPosition.y - CurrentPage.Pan.y, node.EditorPosition.width, node.EditorPosition.height), (id)=> { }, node.Id);

                                height += node.EditorPosition.height + 50;

                                FindNodeErrors(node);
                            }
                        }

                    }
                }


            }
            else if (Event.current.type == EventType.layout)
            {
                Data.DialogsWithErrors.Clear();
                for (var i = 0; i < Data.Dialogs.Count; i++)
                {
                    var dialog = Data.Dialogs[i].Dialog;
                    if (HasDialogErrors(dialog))
                    {
                        Data.DialogsWithErrors.Add(dialog.Id);
                    }
                }
            }

            if (!AddVOModalWindow)
                GUILayout.Window(1001, new Rect(50, 50, 750, Screen.height * 0.65f), DrawMainPanel, Data.CurrentPageIndex == -1 ? "Dialog List" : CurrentPage.EditorState == DialogEditorPage.EditorStates.NodeList ? "Node List" : "Dialog GameFlags");
            // GUILayout.Window(1002, new Rect(460, 50, 340, Screen.height * 0.65f), DrawDialogGameFlags, "Dialog GameFlags");
            GUILayout.Window(1003, new Rect(50, Mathf.RoundToInt(50 + Screen.height * 0.65f + 25), 750, Screen.height - (50 + Screen.height * 0.65f + 25) - 50), DrawErrors, "Error Messages");

            if (Data.CurrentPageIndex > -1)
            {
                var curX = Event.current.mousePosition.x;
                using (new GUILayout.AreaScope(new Rect(Screen.width - 20, 18 + 20, Screen.width / 2, Screen.height)))
                {
                    if (CurrentPage.Pan.y + height > Screen.height)
                    {
                        //CurrentPage.Pan += Input.mouseScrollDelta;
                        //  Debug.Log(Input.mouseScrollDelta + ", " + Event.current.pressure + ", " + Event.current.delta);

                        if (curX > 810 && Event.current.isScrollWheel)
                            CurrentPage.Pan += Event.current.delta*6;

                        var newPan = new Vector2(0, Mathf.RoundToInt(GUILayout.VerticalScrollbar(CurrentPage.Pan.y, 100, 0, height - (Screen.height - 300), GUILayout.Height(Screen.height - 36 - 20))));

                        
                        /* if (!newPan.Equals(CurrentPage.Pan))
                         {
                             if (!_didScrollLastFrame)
                                 CurrentPage.MementoStack.CreateMemento();
                             _didScrollLastFrame = true;
                         }
                         else
                         {
                             _didScrollLastFrame = false;
                         }
                         */
                        CurrentPage.Pan = newPan;
                    }
                }

                if (FirstDraw)
                {
                    FirstDraw = false;
                    RefreshNodes();
                }
            }

            //if (AddVOModalWindow)

            Repaint();
            EndWindows();
        }

        private void DrawVOModalWindow(int id)
        {
            switch (Data.AddVOFilesData.CurrentStep)
            {
                case DialogAddVOFilesData.Steps.Process:
                    EditorGUILayout.LabelField("Copying .mp3s to directory and generating .oggs.");

                    foreach (var mp3Name in Data.AddVOFilesData.FilesToProcess.Keys)
                    {
                        EditorGUILayout.LabelField(mp3Name + ": " + Data.AddVOFilesData.FilesToProcess[mp3Name]);
                    }

                    break;
                case DialogAddVOFilesData.Steps.AddToAudio:
                    EditorGUILayout.LabelField("All .mp3s have been moved and generated. Adding audio files to the Audio Editor.");
                    break;
                case DialogAddVOFilesData.Steps.GeneratePromptMeta:
                    EditorGUILayout.LabelField("Generating the prompt meta data (lip flap data) for audio files (per audio1 meta, 1 mp3, 1 ogg)");
                    break;
            }

        }

        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }

        private void RefreshNodes()
        {
            for (var i = 0; i < Nodes.Count; i++)
            {
                RefreshNode(Nodes[i]);
            }
        }

        private void RefreshNode(DialogNode node)
        {
            var pos = node.EditorPosition;
            pos.width = 650;
            pos.height = 150;
            node.EditorPosition = pos;
        }

        private void LoadAllDialogs()
        {
            Debug.Log("files path: " + DialogDataPath);//
            var files = Directory.GetFiles(DialogDataPath, "*.cs");
            //  Debug.Log("num dialogs: " + files.Length);
            Data.CurrentPageIndex = -1;
            Data.Pages.Clear();
            Data.Dialogs.Clear();
            Data.OriginalDialogs.Clear();
            for (var i = 0; i < files.Length; i++)
            {
                var page = new DialogEditorPage();
                Data.Pages.Add(page);
                Data.CurrentPageIndex = 0;
                Data.GameFlags.Variables = page.GameFlags;
                var dialog = LoadDialog(files[i].Replace("\\", "/"));

                //Debug.Log(dialog.Id + ", " + page.GameFlags.Count);
                page.Dialog = dialog;
                dialog.OriginalId = dialog.Id;
                Data.Dialogs.Add(page);
                dialog.Hash = dialog.GetHashCode();
                page.GameFlagsHash = page.GameFlags.Count == 0 ? 0 : Utils.CombineHash(page.GameFlags.Count.GetHashCode(), page.GameFlags.ConvertAll<int>(x => Utils.CombineHash(x.Name.GetHashCode(), x.Value.GetHashCode(), x.VariableType.GetHashCode())).Aggregate((x, next) => Utils.CombineHash(x, next)));

                page = new DialogEditorPage();
                Data.Pages.Add(page);
                Data.CurrentPageIndex = 0;
                Data.GameFlags.Variables = page.GameFlags;
                dialog = LoadDialog(files[i].Replace("\\", "/"));
                page.Dialog = dialog;
                dialog.OriginalId = dialog.Id;
                Data.OriginalDialogs.Add(page);
                dialog.Hash = dialog.GetHashCode();
                page.GameFlagsHash = page.GameFlags.Count == 0 ? 0 : Utils.CombineHash(page.GameFlags.Count.GetHashCode(), page.GameFlags.ConvertAll<int>(x => Utils.CombineHash(x.Name.GetHashCode(), x.Value.GetHashCode(), x.VariableType.GetHashCode())).Aggregate((x, next) => Utils.CombineHash(x, next)));

            }

        }

        private Dialog LoadDialog(string path, string text = null)
        {
            var classWriter = new ClassWriter();
            if (text == null)
                classWriter.ReadPath(path);
            else
                classWriter.Read(text);

            //Debug.Log("path: " + path);

            //Debug.Log(classWriter.Name);

            Data.GameFlags.FromClassWriter(classWriter.GetClass("DialogGameFlagsClass"));
            var dialog = new Dialog();

            dialog.Id = classWriter.Name.Substring(7, classWriter.Name.Length - 7);
            dialog.DefaultNpc = classWriter.GetProperty("DefaultNpc").Value.Replace(";", "").Replace("\"", "");

            var lines = classWriter.GetMethod("CreateDialog").Lines;
            var nodeStartLines = lines.FindAll(x => x.Contains("//NODE_START "));
            var nodeNpcLines = lines.FindAll(x => x.Contains("//NODE_NPC "));
            var nodeRandomResponseLines = lines.FindAll(x => x.Contains("//NODE_RANDOM_RESPONSES "));
            var promptLines = lines.FindAll(x => x.Contains("//PROMPT "));
            var promptTextLines = lines.FindAll(x => x.Contains("//PROMPT_TEXT "));
            var promptIgnoreVOLines = lines.FindAll(x => x.Contains("//PROMPT_IGNORE_VO "));
            var responseLines = lines.FindAll(x => x.Contains("//RESPONSE "));
            var responseTextLines = lines.FindAll(x => x.Contains("//RESPONSE_TEXT "));
            var responseNextNodeIdLines = lines.FindAll(x => x.Contains("//RESPONSE_NEXT_NODE_ID "));
            var responseNextNodeTypeLines = lines.FindAll(x => x.Contains("//RESPONSE_NEXT_NODE_TYPE "));
            var methodStartLines = lines.FindAll(x => x.Contains("//METHOD_BODY_START "));
            var methodEndLines = lines.FindAll(x => x.Contains("//METHOD_BODY_END "));


            for (var i = 0; i < nodeStartLines.Count; i++)
            {
                var node = dialog.CreateNode();
                node.Id = nodeStartLines[i].Split(' ')[1];
                try
                {
                    node.Npc = nodeNpcLines.Find(x => x.Split(' ')[1] == node.Id).Split(' ')[2];
                }
                catch (Exception ex) { }

                try
                {
                    node.RandomizeResponseOrder = bool.Parse(nodeRandomResponseLines.Find(x => x.Split(' ')[1] == node.Id).Split(' ')[2]);
                }
                catch (Exception ex) { }

                var nodePrompts = promptLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodePromptsText = promptTextLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodePromptsVO = promptIgnoreVOLines.FindAll(x => x.Split(' ')[1] == node.Id);

                for (var j = 0; j < nodePrompts.Count; j++)
                {
                    var nodePromptTextLine = nodePromptsText.Find(x => x.Split(' ')[2] == j.ToString());
                    var nodePromptTextSplit = nodePromptTextLine.Split(' ');

                    var conditionMethod = classWriter.GetMethod(node.Id + "_p" + j + "_condition");
                    var showMethod = classWriter.GetMethod(node.Id + "_p" + j + "_show");

                    var prompt = node.AddPrompt();
                    prompt.Text = nodePromptTextLine.Replace(nodePromptTextSplit[0] + " " + nodePromptTextSplit[1] + " " + nodePromptTextSplit[2] + " ", "").Replace(nodePromptTextSplit[0] + " " + nodePromptTextSplit[1] + " " + nodePromptTextSplit[2], "");
                    prompt.IgnoreVO = bool.Parse(promptIgnoreVOLines.Find(x => x.Split(' ')[2] == j.ToString()).Split(' ')[3]);
                    if (conditionMethod != null)
                        prompt.ConditionsText = conditionMethod.GetText();
                    if (showMethod != null)
                        prompt.ShowText = showMethod.GetText();
                }

                var nodeResponses = responseLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodeResponsesText = responseTextLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodeResponsesNextNodeId = responseNextNodeIdLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodeResponsesNextNodeType = responseNextNodeTypeLines.FindAll(x => x.Split(' ')[1] == node.Id);

                for (var j = 0; j < nodeResponses.Count; j++)
                {
                    var nodeResponseTextLine = nodeResponsesText.Find(x => x.Split(' ')[2] == j.ToString());
                    var nodeResponseTextSplit = nodeResponseTextLine.Split(' ');

                    var conditionMethod = classWriter.GetMethod(node.Id + "_r" + j + "_condition");
                    var showMethod = classWriter.GetMethod(node.Id + "_r" + j + "_show");
                    var selectMethod = classWriter.GetMethod(node.Id + "_r" + j + "_select");
                    var nextNodeMethod = classWriter.GetMethod(node.Id + "_r" + j + "_nextnodeid");

                    var response = node.AddResponse();
                    response.Text = nodeResponseTextLine.Replace(nodeResponseTextSplit[0] + " " + nodeResponseTextSplit[1] + " " + nodeResponseTextSplit[2] + " ", "");
                    var nextNodeIdSplit = nodeResponsesNextNodeId.Find(x => x.Split(' ')[2] == j.ToString()).Split(' ');
                    response.NextNodeId = nextNodeIdSplit != null && nextNodeIdSplit.Length > 3 ? nextNodeIdSplit[3] : "";
                    response.NextNodeType = (DialogResponse.NextNodeTypes)Enum.Parse(typeof(DialogResponse.NextNodeTypes), nodeResponsesNextNodeType.Find(x => x.Split(' ')[2] == j.ToString()).Split(' ')[3]);
                    if (conditionMethod != null)
                        response.ConditionsText = conditionMethod.GetText();
                    if (showMethod != null)
                        response.ShowText = showMethod.GetText();
                    if (selectMethod != null)
                        response.SelectText = selectMethod.GetText();
                    if (nextNodeMethod != null)
                        response.NextNodeText = nextNodeMethod.GetText();
                }
            }
            return dialog;
        }

        public void Load(string dialogId, string text = null)
        {
            var classWriter = new ClassWriter();
            if (text == null)
                classWriter.ReadPath(DialogDataPath + "/" + dialogId + ".cs");
            else
                classWriter.Read(text);
            Debug.Log("read class at: " + (DialogDataPath + "/dialog_" + dialogId + ".cs"));

            Data.GameFlags.FromClassWriter(classWriter.GetClass("DialogGameFlagsClass"));

            var page = new DialogEditorPage();
            page.Dialog = new Dialog();
            Data.Pages.Add(page);
            Data.CurrentPageIndex = Data.Pages.Count - 1;

            page.Dialog.Id = classWriter.Name.Substring(7, classWriter.Name.Length - 7);
            page.Dialog.DefaultNpc = classWriter.GetProperty("DefaultNpc").Value.Replace(";", "").Replace("\"", "");
            Debug.Log("dialog id: " + page.Dialog.Id);

            var lines = classWriter.GetMethod("CreateDialog").Lines;
            var nodeStartLines = lines.FindAll(x => x.Contains("//NODE_START "));
            var nodeNpcLines = lines.FindAll(x => x.Contains("//NODE_NPC "));
            var promptLines = lines.FindAll(x => x.Contains("//PROMPT "));
            var promptTextLines = lines.FindAll(x => x.Contains("//PROMPT_TEXT "));
            var promptIgnoreVOLines = lines.FindAll(x => x.Contains("//PROMPT_IGNORE_VO "));
            var responseLines = lines.FindAll(x => x.Contains("//RESPONSE "));
            var responseTextLines = lines.FindAll(x => x.Contains("//RESPONSE_TEXT "));
            var responseNextNodeIdLines = lines.FindAll(x => x.Contains("//RESPONSE_NEXT_NODE_ID "));
            var responseNextNodeTypeLines = lines.FindAll(x => x.Contains("//RESPONSE_NEXT_NODE_TYPE "));
            var methodStartLines = lines.FindAll(x => x.Contains("//METHOD_BODY_START "));
            var methodEndLines = lines.FindAll(x => x.Contains("//METHOD_BODY_END "));


            Debug.Log("node start lines: " + nodeStartLines.Count);
            for (var i = 0; i < nodeStartLines.Count; i++)
            {
                var node = page.Dialog.CreateNode();
                node.Id = nodeStartLines[i].Split(' ')[1];
                try
                {
                    node.Npc = nodeNpcLines.Find(x => x.Split(' ')[1] == node.Id).Split(' ')[2];
                }
                catch (Exception ex) { }

                var nodePrompts = promptLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodePromptsText = promptTextLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodePromptsVO = promptIgnoreVOLines.FindAll(x => x.Split(' ')[1] == node.Id);

                for (var j = 0; j < nodePrompts.Count; j++)
                {
                    var nodePromptTextLine = nodePromptsText.Find(x => x.Split(' ')[2] == j.ToString());
                    var nodePromptTextSplit = nodePromptTextLine.Split(' ');

                    var conditionMethod = classWriter.GetMethod(node.Id + "_p" + j + "_condition");
                    var showMethod = classWriter.GetMethod(node.Id + "_p" + j + "_show");

                    var prompt = node.AddPrompt();
                    prompt.Text = nodePromptTextLine.Replace(nodePromptTextSplit[0] + " " + nodePromptTextSplit[1] + " " + nodePromptTextSplit[2] + " ", "");
                    prompt.IgnoreVO = bool.Parse(promptIgnoreVOLines.Find(x => x.Split(' ')[2] == j.ToString()).Split(' ')[3]);
                    if (conditionMethod != null)
                        prompt.ConditionsText = conditionMethod.GetText();
                    prompt.ShowText = showMethod.GetText();
                }

                var nodeResponses = responseLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodeResponsesText = responseTextLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodeResponsesNextNodeId = responseNextNodeIdLines.FindAll(x => x.Split(' ')[1] == node.Id);
                var nodeResponsesNextNodeType = responseNextNodeTypeLines.FindAll(x => x.Split(' ')[1] == node.Id);

                for (var j = 0; j < nodeResponses.Count; j++)
                {
                    var nodeResponseTextLine = nodeResponsesText.Find(x => x.Split(' ')[2] == j.ToString());
                    var nodeResponseTextSplit = nodeResponseTextLine.Split(' ');

                    var conditionMethod = classWriter.GetMethod(node.Id + "_r" + j + "_condition");
                    var showMethod = classWriter.GetMethod(node.Id + "_r" + j + "_show");
                    var selectMethod = classWriter.GetMethod(node.Id + "_r" + j + "_select");
                    var nextNodeMethod = classWriter.GetMethod(node.Id + "_r" + j + "_nextnodeid");

                    var response = node.AddResponse();
                    response.Text = nodeResponseTextLine.Replace(nodeResponseTextSplit[0] + " " + nodeResponseTextSplit[1] + " " + nodeResponseTextSplit[2] + " ", "");
                    response.NextNodeId = nodeResponsesNextNodeId.Find(x => x.Split(' ')[2] == j.ToString()).Split(' ')[3];
                    response.NextNodeType = (DialogResponse.NextNodeTypes)Enum.Parse(typeof(DialogResponse.NextNodeTypes), nodeResponsesNextNodeType.Find(x => x.Split(' ')[2] == j.ToString()).Split(' ')[3]);
                    if (conditionMethod != null)
                        response.ConditionsText = conditionMethod.GetText();
                    response.ShowText = showMethod.GetText();
                    response.SelectText = selectMethod.GetText();
                    if (nextNodeMethod != null)
                        response.NextNodeText = nextNodeMethod.GetText();
                }

            }

            /*
            var className = "Dialog_" + dialogId;
            var dialogType = Type.GetType(className + ", Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
            if (dialogType != null)
            {
                var DialogGameFlags = dialogType.GetNestedType("DialogGameFlagsClass", System.Reflection.BindingFlags.NonPublic);
                _variableEditor.FromClass(DialogGameFlags, false);
            }
            */
            FirstDraw = true;

            OnSetupMementoStack();
        }

        public void SaveAll()
        {

            var files = Directory.GetFiles(DialogDataPath, "*.cs").ToList().ConvertAll(x => x.Replace("\\", "/"));//.ConvertAll(x => x.Replace(Data.DialogDataPath, "").Replace("dialog_", "").Replace(".cs", ""));
                                                                                                                  // for (var i = 0; i < files.Count; i++)
                                                                                                                  //      Debug.Log("file: " + files[i]);

            for (var i = 0; i < Data.Dialogs.Count; i++)
            {
                var page = Data.Dialogs[i];

                if (Data.CurrentPageIndex > -1 && page != CurrentPage)
                    continue;

                var dialog = page.Dialog;
                var path = DialogDataPath + "dialog_" + dialog.Id + ".cs";

                Debug.Log("path: " + path);
                if (files.Contains(path))
                    files.Remove(path);

                if (dialog.IsDeleted)
                {
                    if (Data.Pages.Contains(page))
                        Data.Pages.Remove(page);
                    Data.Dialogs.Remove(page);
                    var origDialog = Data.OriginalDialogs.Find(x => x.Dialog.Id == page.Dialog.OriginalId);
                    if (origDialog != null)
                        Data.OriginalDialogs.Remove(origDialog);
                    if (File.Exists(path))
                        File.Delete(path);
                    i--;
                }
                else if (page.IsDirty())
                {
                    var index = Data.CurrentPageIndex;
                    var dialogPage = Data.Pages.Find(x => x.Dialog.Id == dialog.Id);
                    var isOpened = dialogPage != null;

                    if (!isOpened)
                    {
                        dialogPage = page;
                        Data.Pages.Add(dialogPage);
                        Data.CurrentPageIndex = Data.Pages.Count - 1;
                    }
                    else
                    {
                        Data.CurrentPageIndex = Data.Pages.IndexOf(dialogPage);
                    }

                    dialog.OriginalId = dialog.Id;
                    dialog.Hash = dialog.GetHashCode();
                    page.GameFlagsHash = page.GameFlags.Count == 0 ? 0 : Utils.CombineHash(page.GameFlags.Count.GetHashCode(), page.GameFlags.ConvertAll<int>(x => Utils.CombineHash(x.Name.GetHashCode(), x.Value.GetHashCode(), x.VariableType.GetHashCode())).Aggregate((x, next) => Utils.CombineHash(x, next)));

                    Debug.Log("save file: " + dialog.Id);
                    File.WriteAllText(DialogDataPath + "/dialog_" + dialog.Id + ".cs", CreateClassFile());

                    if (!isOpened)
                    {
                        Data.Pages.Remove(dialogPage);
                    }
                    Data.CurrentPageIndex = index;

                    var orig = Data.OriginalDialogs.Find(x => x.Dialog.Id == page.Dialog.Id);
                    var origIndex = Data.OriginalDialogs.IndexOf(orig);
                    Data.OriginalDialogs.Remove(orig);
                    var origPage = new DialogEditorPage();
                    origPage.Dialog = page.Dialog.Clone();
                    origPage.Dialog.OriginalId = origPage.Dialog.Id;
                    origPage.Dialog.Hash = origPage.Dialog.GetHashCode();
                    origPage.GameFlags = page.CloneGameFlags();
                    origPage.GameFlagsHash = origPage.GameFlags.Count == 0 ? 0 : Utils.CombineHash(page.GameFlags.Count.GetHashCode(), page.GameFlags.ConvertAll<int>(x => Utils.CombineHash(x.Name.GetHashCode(), x.Value.GetHashCode(), x.VariableType.GetHashCode())).Aggregate((x, next) => Utils.CombineHash(x, next)));

                    Data.OriginalDialogs.Add(origPage);


                }

                dialog.Hash = dialog.GetHashCode();
                page.GameFlagsHash = page.GetGameFlagsHash();

                page.MementoStack.Clear();
            }

            if (Data.CurrentPageIndex == -1)
            {
                for (var i = 0; i < files.Count; i++)
                {
                    Debug.Log("files to delete: " + files[i]);
                    //    File.Delete(files[i]);
                }
            }


            AssetDatabase.Refresh();
        }

        public void Save()
        {
            File.WriteAllText(DialogDataPath + "/dialog_" + Dialog.Id + ".cs", CreateClassFile());
            AssetDatabase.Refresh();
        }

        private string CreateClassFile()
        {
            var promptConditions = new Dictionary<string, string>();
            var promptShowActions = new Dictionary<string, string>();
            var responseConditions = new Dictionary<string, string>();
            var responseSelectActions = new Dictionary<string, string>();
            var responseShowActions = new Dictionary<string, string>();
            var responseNextNodeIds = new Dictionary<string, string>();


            var classWriter = new ClassWriter();



            classWriter.AddTopLine("using UnityEngine;");
            classWriter.AddTopLine("using System;");
            classWriter.AddTopLine("using System.Collections;");
            classWriter.AddTopLine("using System.Collections.Generic;");
            classWriter.AddTopLine("using DarkChariotStudios.Dialogs;");
            classWriter.Name = "Dialog_" + Dialog.Id;
            classWriter.IsPublic = true;

            Data.GameFlags.Variables = CurrentPage.GameFlags;
            classWriter.AddClass(Data.GameFlags.GetClassWriter("DialogGameFlagsClass", false, false, false, false));

            var propertyWriter = classWriter.CreatePropertyWriter();
            propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
            propertyWriter.Name = "DialogGameFlags";
            propertyWriter.Type = "DialogGameFlagsClass";
            propertyWriter.Value = "new DialogGameFlagsClass()";


            propertyWriter = classWriter.CreatePropertyWriter();
            propertyWriter.Type = "string";
            propertyWriter.Name = "DefaultNpc";
            propertyWriter.Value = "\"" + Dialog.DefaultNpc + "\"";


            var methodWriter = classWriter.CreateMethodWriter();
            methodWriter.Name = "CreateDialog";
            methodWriter.ReturnType = "Dialog";

            methodWriter.AddLine("///DIALOG_ID " + Dialog.Id);
            methodWriter.AddLine("var dialog = new Dialog();");
            methodWriter.AddLine("dialog.Id = \"" + Dialog.Id + "\";");
            methodWriter.AddLine("DialogNode node = null;");
            methodWriter.AddLine("DialogPrompt prompt = null;");
            methodWriter.AddLine("DialogResponse response = null;");
            methodWriter.AddLine("");
            var nodes = CurrentPage.Dialog.GetNodes();
            for (var i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];

                methodWriter.AddLine("///NODE_START " + node.Id);
                methodWriter.AddLine("node = dialog.CreateNode(\"" + node.Id + "\");");
                methodWriter.AddLine("///NODE_NPC " + node.Id + " " + node.Npc);
                methodWriter.AddLine("node.Npc = \"" + node.Npc + "\";");
                methodWriter.AddLine("///NODE_RANDOM_RESPONSES " + node.Id + " " + node.RandomizeResponseOrder);
                methodWriter.AddLine("node.RandomizeResponseOrder = " + node.RandomizeResponseOrder.ToString().ToLower() + ";");

                var prompts = node.GetPrompts();
                for (var j = 0; j < prompts.Length; j++)
                {
                    var prompt = prompts[j];

                    var text = prompt.Text.Replace("\n", "\\n");

                    methodWriter.AddLine("///PROMPT " + node.Id + " " + j);
                    methodWriter.AddLine("prompt = node.AddPrompt();");
                    methodWriter.AddLine("///PROMPT_TEXT " + node.Id + " " + j + " " + text);
                    methodWriter.AddLine("prompt.Text = \"" + text + "\";");
                    methodWriter.AddLine("///PROMPT_IGNORE_VO " + node.Id + " " + j + " " + prompt.IgnoreVO.ToString().ToLower());
                    methodWriter.AddLine("prompt.IgnoreVO = " + prompt.IgnoreVO.ToString().ToLower() + ";");
                    if (!string.IsNullOrEmpty(prompt.ConditionsText))
                    {
                        var conditionName = node.Id + "_p" + prompt.Index + "_condition";
                        methodWriter.AddLine("prompt.SetCondition(" + conditionName + ");");
                        promptConditions.Add(conditionName, string.IsNullOrEmpty(prompt.ConditionsText) ? "return true;" : prompt.ConditionsText);
                    }
                    if (!string.IsNullOrEmpty(prompt.ShowText))
                    {
                        var showMethodName = node.Id + "_p" + prompt.Index + "_show";
                        methodWriter.AddLine("prompt." + (prompt.ShowText.IndexOf("yield") > -1 ? "OnShowBlocking" : "OnShow") + "(" + showMethodName + ");");
                        promptShowActions.Add(showMethodName, prompt.ShowText);
                    }
                    methodWriter.AddLine("");
                }


                var responses = node.GetResponses();
                for (var j = 0; j < responses.Length; j++)
                {
                    var response = responses[j];

                    var text = response.Text.Replace("\n", "\\n");

                    var nextNodeId = response.NextNodeId;
                    if (response.NextNodeType == DialogResponse.NextNodeTypes.End)
                        nextNodeId = "end";


                    methodWriter.AddLine("///RESPONSE " + node.Id + " " + j);
                    methodWriter.AddLine("response = node.AddResponse();");
                    methodWriter.AddLine("///RESPONSE_TEXT " + node.Id + " " + j + " " + text);
                    methodWriter.AddLine("response.Text = \"" + response.Text + "\";");

                    methodWriter.AddLine("///RESPONSE_NEXT_NODE_TYPE " + node.Id + " " + j + " " + Enum.GetName(typeof(DialogResponse.NextNodeTypes), response.NextNodeType));
                    switch (response.NextNodeType)
                    {
                        case DialogResponse.NextNodeTypes.End:
                            methodWriter.AddLine("response.NextNodeType = DialogResponse.NextNodeTypes.End;");
                            methodWriter.AddLine("///RESPONSE_NEXT_NODE_ID " + node.Id + " " + j + " end");
                            methodWriter.AddLine("response.NextNodeId = \"end\";");
                            break;
                        case DialogResponse.NextNodeTypes.Id:
                            methodWriter.AddLine("response.NextNodeType = DialogResponse.NextNodeTypes.Id;");
                            methodWriter.AddLine("///RESPONSE_NEXT_NODE_ID " + node.Id + " " + j + " " + nextNodeId);
                            methodWriter.AddLine("response.NextNodeId = \"" + nextNodeId + "\";");
                            break;
                        case DialogResponse.NextNodeTypes.Script:
                            methodWriter.AddLine("response.NextNodeType = DialogResponse.NextNodeTypes.Script;");
                            methodWriter.AddLine("///RESPONSE_NEXT_NODE_ID " + node.Id + " " + j + " ");
                            methodWriter.AddLine("response.NextNodeId = \"\";");
                            break;
                    }

                    if (!string.IsNullOrEmpty(response.ConditionsText))
                    {
                        var conditionName = node.Id + "_r" + response.Index + "_condition";
                        methodWriter.AddLine("response.SetCondition(" + conditionName + ");");
                        responseConditions.Add(conditionName, response.ConditionsText);
                    }
                    if (!string.IsNullOrEmpty(response.ShowText))
                    {
                        var showMethodName = node.Id + "_r" + response.Index + "_show";
                        methodWriter.AddLine("response." + (response.ShowText.IndexOf("yield") > -1 ? "OnShowBlocking" : "OnShow") + "(" + showMethodName + ");");
                        responseShowActions.Add(showMethodName, response.ShowText);
                    }
                    if (!string.IsNullOrEmpty(response.SelectText))
                    {
                        var selectionMethodName = node.Id + "_r" + response.Index + "_select";
                        methodWriter.AddLine("response." + (response.SelectText.IndexOf("yield") > -1 ? "OnSelectBlocking" : "OnSelect") + "(" + selectionMethodName + ");");
                        responseSelectActions.Add(selectionMethodName, response.SelectText);
                    }
                    if (response.NextNodeType == DialogResponse.NextNodeTypes.Script)
                    {
                        var nextNodeIdScript = node.Id + "_r" + response.Index + "_nextnodeid";
                        methodWriter.AddLine("response.OnSelectNextNodeId(" + nextNodeIdScript + ");");
                        responseNextNodeIds.Add(nextNodeIdScript, response.NextNodeText);
                    }

                    methodWriter.AddLine("");
                }

                methodWriter.AddLine("///NODE_END " + node.Id);
            }
            methodWriter.AddLine("return dialog;");

            foreach (var methodName in promptConditions.Keys)
            {
                methodWriter = classWriter.CreateMethodWriter();
                methodWriter.Name = methodName;
                methodWriter.ReturnType = "bool";

                var lines = promptConditions[methodName].Split('\n');
                methodWriter.AddLines(lines);
            }

            foreach (var methodName in promptShowActions.Keys)
            {
                methodWriter = classWriter.CreateMethodWriter();
                methodWriter.Name = methodName;
                methodWriter.ReturnType = promptShowActions[methodName].IndexOf("yield") > -1 ? "IEnumerator" : "void";
                methodWriter.AddArg(new MethodArg() { Name = "prompt", Type = "DialogPrompt" });

                var lines = promptShowActions[methodName].Split('\n');
                methodWriter.AddLines(lines);
            }

            foreach (var methodName in responseConditions.Keys)
            {
                methodWriter = classWriter.CreateMethodWriter();
                methodWriter.Name = methodName;
                methodWriter.ReturnType = "bool";

                var lines = responseConditions[methodName].Split('\n');
                methodWriter.AddLines(lines);
            }

            foreach (var methodName in responseShowActions.Keys)
            {
                methodWriter = classWriter.CreateMethodWriter();
                methodWriter.Name = methodName;
                methodWriter.ReturnType = responseShowActions[methodName].IndexOf("yield") > -1 ? "IEnumerator" : "void";
                methodWriter.AddArg(new MethodArg() { Name = "response", Type = "DialogResponse" });

                var lines = responseShowActions[methodName].Split('\n');
                methodWriter.AddLines(lines);
            }

            foreach (var methodName in responseSelectActions.Keys)
            {
                methodWriter = classWriter.CreateMethodWriter();
                methodWriter.Name = methodName;
                methodWriter.ReturnType = responseSelectActions[methodName].IndexOf("yield") > -1 ? "IEnumerator" : "void";
                methodWriter.AddArg(new MethodArg() { Name = "response", Type = "DialogResponse" });

                var lines = responseSelectActions[methodName].Split('\n');
                methodWriter.AddLines(lines);
            }

            foreach (var methodName in responseNextNodeIds.Keys)
            {
                methodWriter = classWriter.CreateMethodWriter();
                methodWriter.Name = methodName;
                methodWriter.ReturnType = "string";
                methodWriter.AddArg(new MethodArg() { Name = "response", Type = "DialogResponse" });

                var lines = responseNextNodeIds[methodName].Split('\n');
                methodWriter.AddLines(lines);
            }


            return classWriter.Write();
        }

        public void SaveAs()
        {
            var path = EditorUtility.SaveFilePanel("Save Dialog", Application.dataPath + "/Muse/Core/Dialogs/Data/", Dialog.Id, "cs");
            var startIndex = path.LastIndexOf("/") + 1;
            var endIndex = path.LastIndexOf(".");
            var name = path.Substring(startIndex, endIndex - startIndex);
            Dialog.Id = name;
            //Debug.Log("name: " + name + ", path: " + path);
            Save();
        }

        void EditorNodeId(DialogNode node, Rect rect)
        {
            var oldId = node.Id;
            StringEditorPopup window = new StringEditorPopup(node.Id, (id) => Nodes.Find(x => x.Id.ToLower() == id.ToLower()) == null && id.ToLower() != "end", (id) =>
            {
                CurrentPage.MementoStack.CreateMemento();
                node.Id = id;
                for (var i = 0; i < CurrentPage.Nodes.Count; i++)
                {
                    var n = CurrentPage.Nodes[i];

                    var responses = n.GetResponses();
                    for (var j = 0; j < responses.Length; j++)
                    {
                        var response = responses[j];

                        if (response.NextNodeId == oldId)
                            response.NextNodeId = id;
                    }
                }
            });
            PopupWindow.Show(rect, window);
        }

        class ConvertIOPost
        {
            public string apikey;
            public string input;
            public string file;
            public string filename;
            public string outputformat;
        }

        class ConvertIOResult
        {
            public string id;
        }

        private Vector2 _nodeListPosition;
        void DrawMainPanel(int id)
        {
             using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(740)))
            {
                InfoButton(new Vector2(400, 50), "Filter the state list to only show states with the specified tags.");

                if (Data.CurrentPageIndex == -1)
                    GUI.backgroundColor = Color.yellow;
                if (GUILayout.Button("Dialog List", EditorStyles.toolbarButton, GUILayout.Width(70)))
                {
                    Data.CurrentPageIndex = -1;
                    RefreshErrors();
                }
                GUI.backgroundColor = Color.white;


                for (var i = 0; i < Data.Pages.Count; i++)
                {
                    EditorGUILayout.BeginHorizontal();
                    var page = Data.Pages[i];
                    if (page == null)
                    {
                        Data.Pages.RemoveAt(i);
                        i--;
                    }
                    if (Data.CurrentPageIndex == i)
                    {
                        GUI.backgroundColor = Color.yellow;
                        // Debug.Log(page.Dialog.Hash + ", " + page.Dialog.GetHashCode());
                    }
                    if (GUILayout.Button((page.IsDirty() ? "*" : "") + page.Dialog.Id, EditorStyles.toolbarButton))
                    {
                        Data.CurrentPageIndex = i;
                        RefreshErrors();
                    }
                    if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                    {
                        Data.Pages.Remove(page);
                        Data.CurrentPageIndex = -1;
                        RefreshErrors();
                    }
                    GUI.backgroundColor = Color.white;
                    EditorGUILayout.EndHorizontal();
                }
            }

            if (Data.CurrentPageIndex == -1)
            {
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(740)))
                {
                    EditorGUILayout.BeginHorizontal();
                    InfoButton(new Vector2(400, 90), "Refresh Compile Errors will check for any code errors.");

                    if (GUILayout.Button("Refresh Compile Errors", EditorStyles.toolbarButton, GUILayout.Width(150)))
                    {
                        RefreshErrors();
                    }
                    if (GUILayout.Button("Generate All Response VO", EditorStyles.toolbarButton, GUILayout.Width(150)))
                    {
                        if (EditorUtility.DisplayDialog("Generate All Response VO?", "Are you sure you want to generate response VO for all dialogs? This may take a while and costs money from Amazon Polly services.\n\nThe directory to generate into is: Assets/StreamingAssets/Audio/VO/Dialogs/[DIALOG_ID]/Responses", "Yes, generate away!", "No thanks, I like time and money."))
                        {
                            var validationCB = System.Net.ServicePointManager.ServerCertificateValidationCallback;
                            System.Net.ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => { return true; };


                            var client = new AmazonPollyClient("AKIAJBQ47ON5OVOVCHQQ", "b/BngZp5MJ/X1iKXQhqQ2ydmP6AmMDI0NjeP7y7F", Amazon.RegionEndpoint.USEast1);
                            var describeVoicesRequest = new DescribeVoicesRequest();
                            var describeVoicesResult = client.DescribeVoices(describeVoicesRequest);
                            var voices = describeVoicesResult.Voices;

                            for (var i = 0; i < Data.Dialogs.Count; i++)
                            {
                                var nodes = Data.Dialogs[i].Nodes;

                                for (var j = 0; j < nodes.Count; j++)
                                {
                                    var node = nodes[j];

                                    var responses = node.GetResponses();

                                    for (var k = 0; k < responses.Length; k++)
                                    {
                                        var response = responses[k];

                                        var text = response.Text.Replace("[", "").Replace("]", "");

                                        var speechRequest = new SynthesizeSpeechRequest();
                                        speechRequest.Text = text;
                                        speechRequest.VoiceId = voices[0].Id;
                                        speechRequest.OutputFormat = OutputFormat.Mp3;
                                        var speechUrl = client.SynthesizeSpeech(speechRequest);

                                        if (!Directory.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id))
                                            Directory.CreateDirectory("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id);
                                        if (!Directory.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id + "/Responses"))
                                            Directory.CreateDirectory("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id + "/Responses");

                                        using (FileStream output = File.OpenWrite("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id + "/Responses/" + Dialog.Id + "_" + node.Id + "_r" + j + ".mp3"))
                                        {
                                            CopyStream(speechUrl.AudioStream, output);
                                        }

                                        speechRequest = new SynthesizeSpeechRequest();
                                        speechRequest.Text = text;
                                        speechRequest.VoiceId = voices[0].Id;
                                        speechRequest.OutputFormat = OutputFormat.Ogg_vorbis;
                                        speechUrl = client.SynthesizeSpeech(speechRequest);

                                        using (FileStream output = File.OpenWrite("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id + "/Responses/" + Dialog.Id + "_" + node.Id + "_r" + j + ".ogg"))
                                        {
                                            CopyStream(speechUrl.AudioStream, output);
                                        }
                                        System.Net.ServicePointManager.ServerCertificateValidationCallback = validationCB;
                                    }
                                }
                            }

                            AssetDatabase.Refresh();
                            Debug.Log("Completed Response Audio");
                        }

                    }
                    EditorGUILayout.EndHorizontal();
                }

                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(740)))
                {
                    EditorGUILayout.BeginHorizontal();
                    InfoButton(new Vector2(400, 90), "Write me.");

                    if (GUILayout.Button("Create Dialog", EditorStyles.toolbarButton, GUILayout.Width(150)))
                    {
                        var page = new DialogEditorPage();
                        page.Dialog = new Dialog();
                        var newId = "";
                        var newIdInt = 0;
                        do
                        {
                            newId = "untitled_" + ++newIdInt;
                        } while (Data.Dialogs.Find(x => x.Dialog.Id == newId) != null);
                        page.Dialog.Id = newId;
                        var node = page.Dialog.CreateNode(page.Dialog.GetUniqueId());
                        node.Npc = page.Dialog.DefaultNpc;
                        node.AddPrompt("");
                        var response = node.AddResponse("");
                        response.NextNodeType = DialogResponse.NextNodeTypes.End;
                        page.Nodes = page.Dialog.GetNodes();
                        Data.Dialogs.Add(page);
                        FirstDraw = true;

                        OnSetupMementoStack();
                    }
                    if (GUILayout.Button("Create From Spreadsheet", EditorStyles.toolbarButton, GUILayout.Width(150)))
                    {
                        LoadFromSpreadsheetEditorPopup window = new LoadFromSpreadsheetEditorPopup((dialogId, text, reversePromptOrder) =>
                        {
                            var cancel = false;
                            var existingDialog = Data.Dialogs.Find(x => x.Dialog.Id == dialogId);
                            if (existingDialog != null)
                            {
                                if (EditorUtility.DisplayDialog("Overwrite Dialog?", "A dialog with the Id \"" + dialogId + "\" already exists. Do you want to overwrite it? This will delete any assets linked to the dialog as well (ie: vo)", "Delete", "Cancel"))
                                {
                                    Data.Dialogs.Remove(existingDialog);
                                    Data.Pages.Remove(existingDialog);
                                    Data.OriginalDialogs.Remove(Data.OriginalDialogs.Find(x => x.Dialog.Id == existingDialog.Dialog.OriginalId));

                                    var voPath = Application.streamingAssetsPath + "/Audio/VO/Dialogs/" + existingDialog.Dialog.OriginalId;
                                    Debug.Log("delete voPath: " + voPath);
                                    if (Directory.Exists(voPath))
                                        Directory.Delete(voPath, true);
                                }
                                else
                                {
                                    cancel = true;
                                }
                            }

                            if (!cancel)
                            {
                                var page = new DialogEditorPage();
                                Data.Pages.Insert(0, page);
                                Data.CurrentPageIndex = 0;
                                Data.GameFlags.Variables = page.GameFlags;
                                var dialog = LoadDialog(dialogId, text);
                                dialog.Id = dialogId;
                                page.Dialog = dialog;
                                dialog.OriginalId = dialog.Id;
                                Data.Dialogs.Add(page);

                                // REVERSE PROMPTS
                                var nodes = dialog.GetNodes();

                                for (var i = 0; i < nodes.Count; i++)
                                {
                                    nodes[i].ReversePrompts();
                                }


                                page.GameFlagsHash = page.GameFlags.Count == 0 ? 0 : Utils.CombineHash(page.GameFlags.Count.GetHashCode(), page.GameFlags.ConvertAll<int>(x => Utils.CombineHash(x.Name.GetHashCode(), x.Value.GetHashCode(), x.VariableType.GetHashCode())).Aggregate((x, next) => Utils.CombineHash(x, next)));

                            }
                        });
                        PopupWindow.Show(new Rect(0, -75, 100, 100), window);
                    }
                    EditorGUILayout.EndHorizontal();
                }

                GUI.backgroundColor = Color.clear;
                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
                {
                    GUI.backgroundColor = Color.white;
                    InfoButton(new Vector2(400, 80), "Per State:\nClick on the \"State Id\" column to edit the ID.\nClick on the \"GO\" column to jump to the corresponding state window.\nClick on the \"Starting State\" column to make it the starting state.\nClick on the \"Tags\" column to edit the state's tags.\nClick on the \"X\" button to delete the state.", new Vector2(0, 18));
                    GUI.backgroundColor = Color.clear;
                    if (GUILayout.Button("Dialog Id", EditorStyles.toolbarButton, GUILayout.Width(300)))
                    {
                    }

                    if (GUILayout.Button("Go", EditorStyles.toolbarButton, GUILayout.Width(40)))
                    {
                    }
                    GUILayout.Space(30);
                }
                GUI.backgroundColor = Color.white;


                Data.ScrollPos = EditorGUILayout.BeginScrollView(Data.ScrollPos, false, true);
                for (var i = 0; i < Data.Dialogs.Count; i++)
                {
                    var page = Data.Dialogs[i];
                    var dialog = page.Dialog;

                    if (dialog.IsDeleted)
                        GUI.backgroundColor = Color.red;

                    EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(725));
                    GUILayout.Space(25);

                    if (Data.DialogsWithErrors.Contains(dialog.Id))
                    {
                        GUI.DrawTexture(new Rect(12, i * 18 + 56 + 18 * 2, 18, 18), Data.ErrorImage);
                    }

                    if (GUILayout.Button((page.IsDirty() ? "*" : "") + dialog.Id, EditorStyles.toolbarButton, GUILayout.Width(300)))
                    {
                        var dialogPage = Data.Pages.Find(x => x.Dialog.Id == dialog.Id);
                        if (dialogPage == null)
                        {
                            StringEditorPopup window = new StringEditorPopup(dialog.Id, (dialogId) => Data.Dialogs.Find(x => x.Dialog.Id.ToLower() == dialogId.ToLower()) == null, (dialogId) =>
                            {
                                dialog.Id = dialogId;
                            });
                            PopupWindow.Show(new Rect(25, i * 18 - 80, 100, 100), window);
                        }
                        else
                        {
                            EditorUtility.DisplayDialog("Rename Dialog", "The dialog \"" + dialog.Id + "\" must be closed before renaming it.", "Ok");
                        }

                    }
                    if (GUILayout.Button("->", EditorStyles.toolbarButton, GUILayout.Width(40)))
                    {
                        var dialogPage = Data.Pages.Find(x => x.Dialog.Id == dialog.Id);
                        if (dialogPage == null)
                        {
                            Data.Pages.Add(Data.Dialogs.Find(x => x.Dialog.Id == dialog.Id));
                            Data.CurrentPageIndex = Data.Pages.Count - 1;
                        }
                        else
                        {
                            Data.CurrentPageIndex = Data.Pages.IndexOf(dialogPage);
                        }
                        OnSetupMementoStack();
                    }
                    GUILayout.FlexibleSpace();
                    if (GUILayout.Button(dialog.IsDeleted ? "+" : "-", EditorStyles.toolbarButton, GUILayout.Width(25)))
                    {
                        dialog.IsDeleted = !dialog.IsDeleted;
                    }
                    GUILayout.Space(10);
                    EditorGUILayout.EndHorizontal();

                    GUI.backgroundColor = Color.white;
                }
                EditorGUILayout.EndScrollView();
            }
            else
            {
                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(740)))
                {
                    InfoButton(new Vector2(400, 50), "Filter the state list to only show states with the specified tags.");

                    if (CurrentPage.EditorState == DialogEditorPage.EditorStates.NodeList)
                        GUI.backgroundColor = Color.yellow;
                    if (GUILayout.Button("Node List", EditorStyles.toolbarButton, GUILayout.Width(70)))
                    {
                        CurrentPage.MementoStack.CreateMemento();
                        CurrentPage.EditorState = DialogEditorPage.EditorStates.NodeList;
                    }
                    if (CurrentPage.EditorState == DialogEditorPage.EditorStates.NodeList)
                        GUI.backgroundColor = Color.white;
                    if (CurrentPage.EditorState == DialogEditorPage.EditorStates.DialogGameFlags)
                        GUI.backgroundColor = Color.yellow;
                    if (GUILayout.Button("Dialog GameFlags", EditorStyles.toolbarButton, GUILayout.Width(120)))
                    {
                        CurrentPage.MementoStack.CreateMemento();
                        CurrentPage.EditorState = DialogEditorPage.EditorStates.DialogGameFlags;
                    }
                    if (CurrentPage.EditorState == DialogEditorPage.EditorStates.DialogGameFlags)
                        GUI.backgroundColor = Color.white;
                }
                if (CurrentPage.EditorState == DialogEditorPage.EditorStates.NodeList)
                {
                    using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(740)))
                    {

                        EditorGUILayout.BeginHorizontal();
                        InfoButton(new Vector2(400, 90), "Read mode minimizes all node boxes.\n\nEdit mode maximizes the prompt and response node boxes.\n\nReset clears all changes, reseting the dialog back to its original loaded state.");
                        if (GUILayout.Button("Read Mode", EditorStyles.toolbarButton, GUILayout.Width(100)))
                        {
                            for (var i = 0; i < CurrentPage.Nodes.Count; i++)
                            {
                                var node = CurrentPage.Nodes[i];
                                node.EditorShowData = false;
                                node.EditorShowPrompts = false;
                                node.EditorShowResponses = false;
                            }
                            RefreshNodes();
                            CurrentPage.Pan.y = 0;
                        }
                        if (GUILayout.Button("Edit Mode", EditorStyles.toolbarButton, GUILayout.Width(100)))
                        {
                            for (var i = 0; i < CurrentPage.Nodes.Count; i++)
                            {
                                var node = CurrentPage.Nodes[i];
                                node.EditorShowPrompts = true;
                                node.EditorShowResponses = true;
                            }
                            RefreshNodes();
                            CurrentPage.Pan.y = 0;
                        }
                        if (Data.OriginalDialogs.Find(x => x.Dialog.Id == CurrentPage.Dialog.Id) != null)
                        {
                            if (GUILayout.Button("Reload Dialog", EditorStyles.toolbarButton, GUILayout.Width(100)))
                            {
                                if (EditorUtility.DisplayDialog("Reload Dialog", "Are you sure you want to reload the dialog? You will lose all unsaved changed.", "Reload", "Cancel"))
                                {
                                    var originalPage = Data.OriginalDialogs.Find(x => x.Dialog.Id == CurrentPage.Dialog.OriginalId);
                                    CurrentPage.Dialog = originalPage.Dialog.Clone();
                                    CurrentPage.GameFlags = originalPage.CloneGameFlags();
                                }
                            }
                        }

                        if (GUILayout.Button("Refresh Compile Errors", EditorStyles.toolbarButton, GUILayout.Width(150)))
                        {
                            RefreshErrors();
                        }


                        if (GUILayout.Button("Add Prompt VO", EditorStyles.toolbarButton, GUILayout.Width(110)))
                        {
                            if (EditorUtility.DisplayDialog("Add Prompt VO?", "Select a folder containing .mp3 files. This will add the .mp3s in the folder to the dialog, overwriting any .mp3 files already added with the same name. This will not clear any files already added.\n\nThe directory to copy into is: Assets/StreamingAssets/Audio/VO/Dialogs/[DIALOG_ID]\n\nNote that this will also generate a .ogg file for each supplied .mp3 through the convertio api. This takes time and money, so make sure you don't do this over and over for fun.", "Continue", "Cancel"))
                            {
                                var path = EditorUtility.OpenFolderPanel("Prompt VO Mp3s", "", "");

                                if (!string.IsNullOrEmpty(path))
                                {
                                    var mp3Paths = Directory.GetFiles(path, "*.mp3");

                                    if (mp3Paths.Length > 0)
                                    {
                                        var folderPath = Application.streamingAssetsPath + "/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id;
                                        if (!Directory.Exists(folderPath))
                                            Directory.CreateDirectory(folderPath);

                                        ConvertIOServices.ConvertMp3s(mp3Paths, folderPath, 
                                        (name) => {
                                            if (name[0] == 'd')
                                                name = "p" + name.Substring(1, name.Length - 1);

                                            return name;
                                        }, 
                                        () =>
                                        {
                                            GeneratePromptVOFiles();
                                            AssetDatabase.Refresh();
                                        });
                                    }
                                }
                            }
                        }

                        if (GUILayout.Button("Generate Response VO", EditorStyles.toolbarButton, GUILayout.Width(130)))
                        {
                            if (EditorUtility.DisplayDialog("Generate Response VO?", "Are you sure you want to generate this dialog's response VO? This may take a while and costs money from Amazon Polly services.\n\nThe directory to generate into is: Assets/StreamingAssets/Audio/VO/Dialogs/[DIALOG_ID]/Responses", "Yes, generate away!", "No thanks, I like time and money."))
                            {
                                var validationCB = System.Net.ServicePointManager.ServerCertificateValidationCallback;
                                System.Net.ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => { return true; };


                                var client = new AmazonPollyClient("AKIAJBQ47ON5OVOVCHQQ", "b/BngZp5MJ/X1iKXQhqQ2ydmP6AmMDI0NjeP7y7F", Amazon.RegionEndpoint.USEast1);


                                var describeVoicesRequest = new DescribeVoicesRequest();
                                var describeVoicesResult = client.DescribeVoices(describeVoicesRequest);
                                var voices = describeVoicesResult.Voices;

                                for (var i = 0; i < Nodes.Count; i++)
                                {
                                    var node = Nodes[i];

                                    var responses = node.GetResponses();

                                    for (var j = 0; j < responses.Length; j++)
                                    {
                                        var response = responses[j];

                                        var text = response.Text.Replace("[", "").Replace("]", "");

                                        var speechRequest = new SynthesizeSpeechRequest();
                                        speechRequest.Text = text;
                                        speechRequest.VoiceId = voices[0].Id;
                                        speechRequest.OutputFormat = OutputFormat.Mp3;
                                        var speechUrl = client.SynthesizeSpeech(speechRequest);

                                        if (!Directory.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id))
                                            Directory.CreateDirectory("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id);
                                        if (!Directory.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id + "/Responses"))
                                            Directory.CreateDirectory("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id + "/Responses");

                                        using (FileStream output = File.OpenWrite("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id + "/Responses/" + Dialog.Id + "_" + node.Id + "_r" + j + ".mp3"))
                                        {
                                            CopyStream(speechUrl.AudioStream, output);
                                        }

                                        speechRequest = new SynthesizeSpeechRequest();
                                        speechRequest.Text = text;
                                        speechRequest.VoiceId = voices[0].Id;
                                        speechRequest.OutputFormat = OutputFormat.Ogg_vorbis;
                                        speechUrl = client.SynthesizeSpeech(speechRequest);

                                        using (FileStream output = File.OpenWrite("Assets/StreamingAssets/Audio/VO/Dialogs/" + Dialog.Id + "/Responses/" + Dialog.Id + "_" + node.Id + "_r" + j + ".ogg"))
                                        {
                                            CopyStream(speechUrl.AudioStream, output);
                                        }
                                        System.Net.ServicePointManager.ServerCertificateValidationCallback = validationCB;
                                    }
                                }

                                AssetDatabase.Refresh();
                                Debug.Log("Completed Response Audio");
                            }

                        }
                        EditorGUILayout.EndHorizontal();


                        EditorGUILayout.BeginHorizontal();
                        InfoButton(new Vector2(400, 50), "Filter the state list to only show states with the specified tags.");

                        if (GUILayout.Button("Default Npc:", EditorStyles.toolbarButton, GUILayout.Width(100)))
                        {
                            for (var i = 0; i < CurrentPage.Nodes.Count; i++)
                                CurrentPage.Nodes[i].Npc = CurrentPage.Dialog.DefaultNpc;
                        }
                        var newDefaultNPC = EditorGUILayout.TextField(CurrentPage.Dialog.DefaultNpc, GUILayout.Width(150));
                        if (newDefaultNPC != CurrentPage.Dialog.DefaultNpc)
                        {
                            CurrentPage.MementoStack.CreateMemento();
                            CurrentPage.Dialog.DefaultNpc = newDefaultNPC;
                        }
                        if (GUILayout.Button("Reverse Prompt Order", EditorStyles.toolbarButton, GUILayout.Width(125)))
                        {
                            var nodes = CurrentPage.Dialog.GetNodes();

                            for (var i = 0; i < nodes.Count; i++)
                            {
                                nodes[i].ReversePrompts();
                            }
                        }
                        if (GUILayout.Button("Generate PDF", EditorStyles.toolbarButton, GUILayout.Width(125)))
                        {
                            
                        }
                        EditorGUILayout.EndHorizontal();


                        EditorGUILayout.BeginHorizontal();
                        InfoButton(new Vector2(400, 50), "Creates a new state. This will still need a corresponding Unity scene which can be created from the Visual Scenes box in the state window.");
                        if (GUILayout.Button("Create Node", EditorStyles.toolbarButton, GUILayout.Width(100)))
                        {
                            CurrentPage.MementoStack.CreateMemento();
                            var node = Dialog.CreateNode(Dialog.GetUniqueId());
                            node.Npc = Dialog.DefaultNpc;
                            node.AddPrompt("");
                            var response = node.AddResponse("");
                            response.NextNodeType = DialogResponse.NextNodeTypes.End;
                        }
                        EditorGUILayout.EndHorizontal();
                    }


                    GUI.backgroundColor = Color.clear;
                    using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
                    {
                        GUI.backgroundColor = Color.white;
                        InfoButton(new Vector2(400, 80), "Per State:\nClick on the \"State Id\" column to edit the ID.\nClick on the \"GO\" column to jump to the corresponding state window.\nClick on the \"Starting State\" column to make it the starting state.\nClick on the \"Tags\" column to edit the state's tags.\nClick on the \"X\" button to delete the state.", new Vector2(0, 18));
                        GUI.backgroundColor = Color.clear;
                        if (GUILayout.Button("Node Id", EditorStyles.toolbarButton, GUILayout.Width(70)))
                        {
                        }

                        if (GUILayout.Button("Go", EditorStyles.toolbarButton, GUILayout.Width(40)))
                        {
                        }

                        if (GUILayout.Button("Npc", EditorStyles.toolbarButton, GUILayout.Width(60)))
                        {
                        }

                        if (GUILayout.Button("First Prompt", EditorStyles.toolbarButton, GUILayout.Width(295 - 120)))
                        {
                        }
                        if (GUILayout.Button("From", EditorStyles.toolbarButton, GUILayout.Width(160)))
                        {
                        }
                        if (GUILayout.Button("To", EditorStyles.toolbarButton, GUILayout.Width(160)))
                        {
                        }
                        GUILayout.Space(30);
                    }
                    GUI.backgroundColor = Color.white;

                    _nodeListPosition = EditorGUILayout.BeginScrollView(_nodeListPosition, GUIStyle.none, GUI.skin.verticalScrollbar);
                    for (var i = 0; i < Nodes.Count; i++)
                    {
                        var node = Nodes[i];

                        if (node.IsDeleted)
                            GUI.backgroundColor = Color.red;

                        using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
                        {
                            GUILayout.Space(25);
                            if (GUILayout.Button(node.Id, EditorStyles.toolbarButton, GUILayout.Width(70)))
                            {
                                EditorNodeId(node, new Rect(0, i * 18 - 75, 100, 100));
                            }
                            if (GUILayout.Button("->", EditorStyles.toolbarButton, GUILayout.Width(40)))
                            {
                                if (!node.IsNodeVisible)
                                    CurrentPage.Pan = new Vector2(0, Mathf.RoundToInt(Dialog.GetNode(node.Id).EditorPosition.y));
                            }
                            var newNpc = EditorGUILayout.TextField(node.Npc, GUILayout.Width(60));
                            if (newNpc != node.Npc)
                            {
                                CurrentPage.MementoStack.CreateMemento();
                                node.Npc = newNpc;
                            }

                            EditorGUILayout.LabelField(node.NumPrompts > 0 ? node.GetPrompts()[0].Text : "", GUILayout.Width(295 - 120));


                            if (GUILayout.Button(node.From.Count > 0 ? node.From.Keys.ToList().Aggregate((x, next) => x += ", " + next) : "", EditorStyles.toolbarButton, GUILayout.Width(160)))
                            {
                            }
                            if (GUILayout.Button(node.To.Count > 0 ? node.To.Aggregate((x, next) => x += ", " + next) : "", EditorStyles.toolbarButton, GUILayout.Width(160)))
                            {
                            }

                            GUILayout.FlexibleSpace();
                            if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                            {
                                CurrentPage.MementoStack.CreateMemento();
                                CurrentPage.Dialog.RemoveNode(node.Id);
                            }
                        }
                        GUI.backgroundColor = Color.white;

                        //Debug.Log(CurrentPage.Errors.Count);
                        if (CurrentPage.Errors.Find(x => x.NodeId == node.Id) != null || _errorTags.Find(x => x[0] == node.Id) != null)
                        {
                            GUI.DrawTexture(new Rect(7, i * 18, 18, 18), Data.ErrorImage);
                        }
                    }
                    EditorGUILayout.EndScrollView();

                }
                else if (CurrentPage.EditorState == DialogEditorPage.EditorStates.DialogGameFlags)
                {
                    using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(740)))
                    {
                        EditorGUILayout.BeginHorizontal();
                        InfoButton(new Vector2(400, 90), "Reload Dialog clears all changes, reseting the dialog back to its original loaded state.\n\nRefresh Compile Errors will check for any code errors.");

                        if (GUILayout.Button("Reload Dialog", EditorStyles.toolbarButton, GUILayout.Width(120)))
                        {
                            if (EditorUtility.DisplayDialog("Reload Dialog", "Are you sure you want to reload the dialog? You will lose all unsaved changed.", "Reload", "Cancel"))
                            {
                                var originalPage = Data.OriginalDialogs.Find(x => x.Dialog.Id == CurrentPage.Dialog.OriginalId);
                                CurrentPage.Dialog = originalPage.Dialog.Clone();
                                CurrentPage.GameFlags = originalPage.CloneGameFlags();
                            }
                        }
                        if (GUILayout.Button("Refresh Compile Errors", EditorStyles.toolbarButton, GUILayout.Width(150)))
                        {
                            RefreshErrors();
                        }
                        EditorGUILayout.EndHorizontal();
                    }

                    Data.GameFlags.CopyPrefix = "DialogGameFlags.";
                    Data.GameFlags.Variables = CurrentPage.GameFlags;
                   // Debug.Log(CurrentPage.Dialog.Id + ", " + Data.GameFlags.Variables.Count);
                    Data.GameFlags.OnGUI(740, null, null, () =>
                    {
                        CurrentPage.MementoStack.CreateMemento();
                    });
                }
            }

        }
        

        private Vector2 _errorPos;
        void DrawErrors(int id)
        {

            _errorPos = EditorGUILayout.BeginScrollView(_errorPos);

            if (Data.CurrentPageIndex > -1)
            {
                for (var i = 0; i < _errorTags.Count; i++)
                {
                    var tags = _errorTags[i];
                    using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(720)))
                    {
                        //EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(720));
                        GUILayout.Space(5);
                        EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.LabelField("Location: " + tags[0] + "->" + tags[1] + "->" + tags[2], GUILayout.Width(680));
                        EditorGUILayout.EndHorizontal();
                        EditorGUILayout.LabelField(tags[3].Trim(), EditorStyles.wordWrappedLabel, GUILayout.Width(680));
                        GUILayout.Space(5);
                    }
                    //EditorGUILayout.EndVertical();
                }

                // Debug.Log(CurrentPage.Errors.Count + " " + Event.current.type);
                for (var i = 0; i < CurrentPage.Errors.Count; i++)
                {
                    var error = CurrentPage.Errors[i];

                    using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(720)))
                    {
                        GUILayout.Space(5);
                        EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.LabelField("Location: " + error.NodeId, GUILayout.Width(680));
                        EditorGUILayout.EndHorizontal();
                        EditorGUILayout.LabelField(error.Message, EditorStyles.wordWrappedLabel, GUILayout.Width(680));
                        GUILayout.Space(5);
                    }
                }
            }


            EditorGUILayout.EndScrollView();
        }

        void DrawNode(int nodeIndex)
        {
            var fixedHeight = EditorStyles.toolbar.fixedHeight;
            EditorStyles.toolbar.fixedHeight = 0;

            var wordWrap = EditorStyles.textArea.wordWrap;
            EditorStyles.textArea.wordWrap = true;
            EditorStyles.textField.wordWrap = true;

            var node = Nodes[nodeIndex];

            var compileErrors = _errorTags.FindAll(x => x[0] == node.Id);

            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(650)))
            {
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                {
                    CurrentPage.MementoStack.CreateMemento();
                    CurrentPage.Dialog.RemoveNode(node.Id);
                }
            }


            //GUI.Label(new Rect(node.EditorPosition.width / 2 - 25, 15, node.EditorPosition.width, TopBarHeight), node.Id, EditorStyles.largeLabel);



            GUILayout.Space(25);


            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(2);
                    EditorGUILayout.BeginHorizontal(GUILayout.Width(30));
                    var newEditorShowData = EditorGUILayout.Foldout(node.EditorShowData, "");
                    if (node.EditorShowData != newEditorShowData)
                        RefreshNode(node);
                    node.EditorShowData = newEditorShowData;
                    EditorGUILayout.EndHorizontal();
                }
            }

            var lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(node.EditorPosition.width / 2 - 25, lastRect.y, node.EditorPosition.width, TopBarHeight), "Data", EditorStyles.boldLabel);
            GUILayout.Space(1);


            if (node.EditorShowData)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    //   EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(610), GUILayout.Height(25));
                    GUILayout.Space(5);
                    EditorGUILayout.BeginHorizontal();
                    InfoButton(new Vector2(400, 50), "Assign a unique Id to the node. This is used by the Response's \"NextNode\" id field.");
                    EditorGUILayout.LabelField("Node Id:", GUILayout.Width(150));
                    if (GUILayout.Button(node.Id, EditorStyles.toolbarButton, GUILayout.Width(350)))
                    {
                        EditorNodeId(node, new Rect(250, 15, 100, 100));
                    }
                    EditorGUILayout.EndHorizontal();
                    GUILayout.Space(2);
                    EditorGUILayout.BeginHorizontal();
                    InfoButton(new Vector2(400, 50), "Assign which Npc is speaking during this node.");
                    EditorGUILayout.LabelField("Npc:", GUILayout.Width(150));
                    var newNpc = EditorGUILayout.TextField(node.Npc, GUILayout.Width(350));
                    if (newNpc != node.Npc)
                    {
                        CurrentPage.MementoStack.CreateMemento();
                        node.Npc = newNpc;
                    }
                    EditorGUILayout.EndHorizontal();
                    GUILayout.Space(5);
                    //  EditorGUILayout.EndVertical();
                }
                EditorGUILayout.EndHorizontal();
            }

            GUILayout.Space(25);

            //EditorGUI.indentLevel++;

            var promptColor = Color.cyan;
            GUI.backgroundColor = promptColor;
            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(2);
                    EditorGUILayout.BeginHorizontal(GUILayout.Width(30));
                    var newEditorShowPrompts = EditorGUILayout.Foldout(node.EditorShowPrompts, "");
                    if (node.EditorShowPrompts != newEditorShowPrompts)
                        RefreshNode(node);
                    node.EditorShowPrompts = newEditorShowPrompts;

                    EditorGUILayout.EndHorizontal();

                }
            }
            GUI.backgroundColor = Color.white;
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(node.EditorPosition.width / 2 - 25, lastRect.y, node.EditorPosition.width, TopBarHeight), "PROMPTS", EditorStyles.boldLabel);

            if (node.EditorShowPrompts)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(610), GUILayout.Height(25));
                GUILayout.Space(3);
                EditorGUILayout.BeginHorizontal();
                InfoButton(new Vector2(400, 50), "Create a new prompt.");
                if (GUILayout.Button("Create Prompt", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    CurrentPage.MementoStack.CreateMemento();
                    node.AddPrompt("");

                    RefreshNode(node);
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();
            }

            GUILayout.Space(1);
            var prompts = node.GetPrompts();
            for (int i = prompts.Length-1; i > -1; i--)
            {
                var prompt = prompts[i];
                var startY = GUILayoutUtility.GetLastRect().y + GUILayoutUtility.GetLastRect().height;

                //EditorGUI.DrawTextureTransparent(new Rect(10, startY, 650, prompt.EditorTextHeight), EditorStyles.toolbarButton.normal.background);


                if (node.EditorShowPrompts)
                {
                    EditorGUILayout.BeginHorizontal();
                    GUILayout.Space(25);
                    using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                    {
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            EditorGUILayout.LabelField("P" + i, EditorStyles.boldLabel);
                            GUILayout.FlexibleSpace();
                            InfoButton(new Vector2(400, 90), "The first prompt whose condition evaluates to true (no condition text evaluates to true) is shown. This is in order of top to bottom.\n\nUse the \"^\" and \"v\" buttons to move a prompt up and down.\n\nUse the \"X\" button to immediately delete the prompt. This can be undone.");

                            if (GUILayout.Button("^", EditorStyles.toolbarButton, GUILayout.Width(30)))
                            {
                                if (i != 0 && prompts.Length > 1)
                                {
                                    CurrentPage.MementoStack.CreateMemento();
                                    node.MoveUp(prompt);
                                }
                            }

                            if (GUILayout.Button("v", EditorStyles.toolbarButton, GUILayout.Width(30)))
                            {
                                if (i != prompts.Length - 1 && prompts.Length > 1)
                                {
                                    CurrentPage.MementoStack.CreateMemento();
                                    node.MoveDown(prompt);
                                }
                            }
                            if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                            {
                                CurrentPage.MementoStack.CreateMemento();
                                node.RemovePrompt(prompt);
                                RefreshNode(node);
                            }
                        }

                    }
                    EditorGUILayout.EndHorizontal();
                }

                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(5);

                    using (new EditorGUILayout.HorizontalScope())
                    {
                        //prompt.ShowContents = EditorGUILayout.Foldout(prompt.ShowContents, "");
                        InfoButton(new Vector2(400, 50), "The text which is shown in the prompt area.");
                        if (node.EditorShowPrompts)
                            EditorGUILayout.LabelField("Text:", GUILayout.Width(70));
                        {
                            var fontSize = GUI.skin.textArea.fontSize;
                            //var lh = GUI.skin.textArea.lineHeight;
                            // GUI.skin.textArea.fontSize = 16; 
                            // GUI.skin.textArea
                            var newPromptText = EditorGUILayout.TextArea(prompt.Text, GUI.skin.textArea, GUILayout.Width(410));
                            if (prompt.Text != newPromptText)
                                CurrentPage.MementoStack.CreateMemento();
                            prompt.Text = newPromptText;
                            GUI.skin.textArea.fontSize = fontSize;
                        }
                        EditorGUILayout.LabelField("(" + prompt.Text.Length + ")", GUILayout.Width(45));
                        if (!node.EditorShowPrompts)
                        {
                            var types = "";

                            if (!string.IsNullOrEmpty(prompt.ShowText))
                                types += " SH";
                            if (!string.IsNullOrEmpty(prompt.ConditionsText))
                                types += " C";
                            if (prompt.IgnoreVO)
                                types += " NO_VO";

                            EditorGUILayout.LabelField(types, GUILayout.Width(85));
                        }

                    }
                    if (string.IsNullOrEmpty(prompt.Text))
                    {
                        EditorGUILayout.HelpBox("Prompt text cannot be blank!", MessageType.Error);
                    }
                    var promptTextError = compileErrors.Find(x => x[1] == ("p" + i) && x[2] == "Text");
                    if (promptTextError != null)
                    {
                        EditorGUILayout.HelpBox(promptTextError[3], MessageType.Error);
                    }



                    // GUILayout.Space(2);
                    GUILayout.Space(2);

                    if (node.EditorShowPrompts)
                    {

                        using (new EditorGUILayout.HorizontalScope())
                        {
                            InfoButton(new Vector2(400, 50), "Determines if the prompt is shown. Return true to show.\n\nExample: return true");
                            EditorGUILayout.LabelField("Conditions:", GUILayout.Width(70));
                            {
                                var newPromptConditionsText = EditorGUILayout.TextArea(prompt.ConditionsText, GUILayout.Width(400));
                                if (prompt.ConditionsText != newPromptConditionsText)
                                    CurrentPage.MementoStack.CreateMemento();
                                prompt.ConditionsText = newPromptConditionsText;
                            }
                            EditorGUILayout.LabelField("C#", GUILayout.Width(25));

                        }
                        var promptConditionText = compileErrors.Find(x => x[1] == ("p" + i) && x[2] == "condition");
                        if (promptConditionText != null)
                        {
                            EditorGUILayout.HelpBox(promptConditionText[3], MessageType.Error);
                        }

                        if (string.IsNullOrEmpty(prompt.ConditionsText) && i != 0)
                        {
                            EditorGUILayout.HelpBox("Empty conditions automatically return true. Any prompts below will never be shown.", MessageType.Error);
                            //Debug.Log("adding error for: " + node.Id);
                        }

                        if (!string.IsNullOrEmpty(prompt.ConditionsText) && !prompt.ConditionsText.Contains("return"))
                        {
                            EditorGUILayout.HelpBox("Prompt conditions must return a value equals to true or false.", MessageType.Error);
                        }




                        GUILayout.Space(2);
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            InfoButton(new Vector2(400, 50), "Triggered when the prompt is shown.");
                            EditorGUILayout.LabelField("OnShow:", GUILayout.Width(70));
                            {
                                var newPromptShowText = EditorGUILayout.TextArea(prompt.ShowText, GUILayout.Width(400));
                                if (prompt.ShowText != newPromptShowText)
                                {
                                    CurrentPage.MementoStack.CreateMemento();
                                   // Debug.Log("prompt.showText: " + prompt.ShowText + ", " + prompt.ShowText.Length + ", " + prompt.ShowText.GetHashCode() + ", newPromptShowText: " + newPromptShowText + ", " + newPromptShowText.Length + ", " + newPromptShowText.GetHashCode());
                                }
                                prompt.ShowText = newPromptShowText;
                            }
                            EditorGUILayout.LabelField("C#", GUILayout.Width(25));
                        }
                        var promptShowText = compileErrors.Find(x => x[1] == ("p" + i) && x[2] == "show");
                        if (promptShowText != null)
                        {
                            EditorGUILayout.HelpBox(promptShowText[3], MessageType.Error);
                        }
                        GUILayout.Space(2);
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            InfoButton(new Vector2(400, 80), "True if there is VO associated with this prompt.\n\nVO must be in both .ogg format for the editor and .mp3 for WebGL.\n\nFiles must be placed under Assets/StreamingAssets/Dialogs/DIALOG_ID.");
                            EditorGUILayout.LabelField("Is Spoken:", GUILayout.Width(70));
                            var boolList = new string[] { "False", "True" };
                            {
                                var newPromptIgnoreVO = EditorGUILayout.Popup(prompt.IgnoreVO ? 0 : 1, boolList, EditorStyles.toolbarPopup, GUILayout.Width(100)) == 0;
                                if (prompt.IgnoreVO != newPromptIgnoreVO)
                                    CurrentPage.MementoStack.CreateMemento();
                                prompt.IgnoreVO = newPromptIgnoreVO;
                            }
                        }



                        if (!prompt.IgnoreVO)
                        {
                            bool mp3Exists = File.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + i + ".mp3");
                            bool oggExists = File.Exists("Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + i + ".ogg");
                            if (!oggExists && !mp3Exists)
                            {
                                EditorGUILayout.HelpBox("The VO files \"Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + i + ".ogg" + "\" and \"Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + i + ".mp3" + "\" do not exist.", MessageType.Error);
                            }
                            else if (!oggExists)
                            {
                                EditorGUILayout.HelpBox("The VO file \"Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + i + ".ogg" + "\" does not exist.", MessageType.Error);
                            }
                            else if (!mp3Exists)
                            {
                                EditorGUILayout.HelpBox("The VO file \"Assets/StreamingAssets/Audio/VO/Dialogs/" + CurrentPage.Dialog.Id + "/" + CurrentPage.Dialog.Id + "_" + node.Id + "_p" + i + ".mp3" + "\" does not exist.", MessageType.Error);
                            }
                        }
                    }

                    GUILayout.Space(5);
                }
                EditorGUILayout.EndHorizontal();



                GUILayout.Space(1);

                var endY = GUILayoutUtility.GetLastRect().y + GUILayoutUtility.GetLastRect().height;

                //Debug.Log("y: " + startY + ", " + endY);
                if (endY - startY > 0)
                    prompt.EditorTextHeight = endY - startY;
            }




            var endPromptsY = EditorGUILayout.GetControlRect().y;
            if (endPromptsY > 0)
                node.EditorPromptsHeight = endPromptsY - lastRect.y;
            // }

            GUILayout.Space(25);


            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
            }

            var responseColor = Color.green;
            GUI.backgroundColor = responseColor;
            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(2);
                    EditorGUILayout.BeginHorizontal(GUILayout.Width(30));

                    var newEditorShowResponses = EditorGUILayout.Foldout(node.EditorShowResponses, "");
                    if (node.EditorShowResponses != newEditorShowResponses)
                        RefreshNode(node);
                    node.EditorShowResponses = newEditorShowResponses;
                    EditorGUILayout.EndHorizontal();
                }
            }
            GUI.backgroundColor = Color.white;
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(node.EditorPosition.width / 2 - 25, lastRect.y, node.EditorPosition.width, TopBarHeight), "RESPONSES", EditorStyles.boldLabel);

            if (node.EditorShowResponses)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(610), GUILayout.Height(25));
                GUILayout.Space(3);


                EditorGUILayout.BeginHorizontal();
                InfoButton(new Vector2(400, 50), "Responses will be shown in a random order if value is \"On\".");
                if (GUILayout.Button(node.RandomizeResponseOrder ? "Random On" : "Randomize Off", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    CurrentPage.MementoStack.CreateMemento();
                    node.RandomizeResponseOrder = !node.RandomizeResponseOrder;
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.BeginHorizontal();
                InfoButton(new Vector2(400, 50), "Create a new response.");
                if (GUILayout.Button("Create Response", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    CurrentPage.MementoStack.CreateMemento();
                    node.AddResponse("");
                }
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(3);
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();
            }

            GUILayout.Space(1);
            node.To.Clear();
            var responses = node.GetResponses();
            for (int i = 0; i < responses.Length; i++)
            {
                var response = responses[i];

                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    if (node.EditorShowResponses)
                    {
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            EditorGUILayout.LabelField("R" + i, EditorStyles.boldLabel);
                            GUILayout.FlexibleSpace();
                            InfoButton(new Vector2(400, 90), "Use the \"^\" and \"v\" buttons to move a response up and down.\n\nUse the \"X\" button to immediately delete the response. This can be undone.");

                            if (GUILayout.Button("^", EditorStyles.toolbarButton, GUILayout.Width(30)))
                            {
                                if (i != 0 && prompts.Length > 1)
                                {
                                    CurrentPage.MementoStack.CreateMemento();
                                    node.MoveUp(response);
                                }
                            }

                            if (GUILayout.Button("v", EditorStyles.toolbarButton, GUILayout.Width(30)))
                            {
                                if (i != prompts.Length - 1 && prompts.Length > 1)
                                {
                                    CurrentPage.MementoStack.CreateMemento();
                                    node.MoveDown(response);
                                }
                            }

                            if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                            {
                                CurrentPage.MementoStack.CreateMemento();
                                node.RemoveResponse(response);
                                RefreshNode(node);
                            }
                        }

                    }
                    EditorGUILayout.EndHorizontal();
                }


                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(5);
                    using (new EditorGUILayout.HorizontalScope())
                    {

                        InfoButton(new Vector2(400, 50), "The text shown in the response area.");
                        //EditorGUILayout.LabelField("R" + i, GUILayout.Width(45));
                        {
                            var newResponseText = EditorGUILayout.TextArea(response.Text, GUILayout.Width(420));
                            if (response.Text != newResponseText)
                                CurrentPage.MementoStack.CreateMemento();
                            response.Text = newResponseText;
                        }
                        EditorGUILayout.LabelField("(" + response.Text.Length + ")", GUILayout.Width(45));



                        if (!node.EditorShowResponses)
                        {
                            var types = "";

                            if (response.NextNodeType == DialogResponse.NextNodeTypes.Id)
                                types += response.NextNodeId;
                            else if (response.NextNodeType == DialogResponse.NextNodeTypes.End)
                                types += " end";

                            if (!string.IsNullOrEmpty(response.ShowText))
                                types += " SH";
                            if (!string.IsNullOrEmpty(response.SelectText))
                                types += " SL";
                            if (!string.IsNullOrEmpty(response.ConditionsText))
                                types += " C";
                            if (!string.IsNullOrEmpty(response.NextNodeText))
                                types += " N";
                            EditorGUILayout.LabelField(types, GUILayout.Width(105));
                        }
                    }

                    var responseTextError = compileErrors.Find(x => x[1] == ("r" + i) && x[2] == "Text");
                    if (responseTextError != null)
                    {
                        EditorGUILayout.HelpBox(responseTextError[3], MessageType.Error);
                    }

                    if (string.IsNullOrEmpty(response.Text))
                    {
                        EditorGUILayout.HelpBox("Response text cannot be blank!", MessageType.Error);
                    }








                    if (node.EditorShowResponses)
                    {
                        GUILayout.Space(2);

                        using (new EditorGUILayout.HorizontalScope())
                        {
                            InfoButton(new Vector2(400, 50), "Determines if the response is shown. Return true to show.\n\nExample: return true");
                            EditorGUILayout.LabelField("Conditions:", GUILayout.Width(70));
                            {
                                var newResponseConditionsText = EditorGUILayout.TextArea(response.ConditionsText, GUILayout.Width(400));
                                if (response.ConditionsText != newResponseConditionsText)
                                    CurrentPage.MementoStack.CreateMemento();
                                response.ConditionsText = newResponseConditionsText;
                            }
                            EditorGUILayout.LabelField("C#", GUILayout.Width(25));
                        }
                        var responseConditionError = compileErrors.Find(x => x[1] == ("r" + i) && x[2] == "condition");
                        if (responseConditionError != null)
                        {
                            EditorGUILayout.HelpBox(responseConditionError[3], MessageType.Error);
                        }

                        if (!string.IsNullOrEmpty(response.ConditionsText) && !response.ConditionsText.Contains("return"))
                        {
                            EditorGUILayout.HelpBox("Response conditions must return a value equals to true or false.", MessageType.Error);
                        }

                        GUILayout.Space(2);
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            InfoButton(new Vector2(400, 125), "Determines which node the response travels to. There are three input types: Id, End, and Script.\n\n-Id: Input the id of the node. Automatically ends the dialog after the OnSelect script if the value is \"end\".\n\n-End: Automatically ends the dialog after the OnSelect script.\n\n-Script: C-sharp code that returns the node id as a string (ie: return \"n03\").");
                            EditorGUILayout.LabelField("Next Node:", GUILayout.Width(70));
                            {
                                var newResponseNextNodeType = (DialogResponse.NextNodeTypes)EditorGUILayout.EnumPopup(response.NextNodeType, EditorStyles.toolbarPopup, GUILayout.Width(100));
                                if (response.NextNodeType != newResponseNextNodeType)
                                {
                                    CurrentPage.MementoStack.CreateMemento();
                                    /*switch (newResponseNextNodeType)
                                    {
                                        case DialogResponse.NextNodeTypes.Id:
                                            response.NextNodeText = "";
                                            break;
                                        case DialogResponse.NextNodeTypes.End:
                                            response.NextNodeId = "";
                                            response.NextNodeText = "";
                                            break;
                                        case DialogResponse.NextNodeTypes.Script:
                                            response.NextNodeId = "";
                                            break;
                                    }*/
                                }
                                response.NextNodeType = newResponseNextNodeType;
                            }

                            switch (response.NextNodeType)
                            {
                                case DialogResponse.NextNodeTypes.Id:
                                    // var nodeIds = Dialog.GetNodes().ConvertAll<string>((x) => x.Id);
                                    //int indexOfId = 0;
                                    //if (nodeIds.Contains(response.NextNodeId))
                                    //     indexOfId = nodeIds.IndexOf(response.NextNodeId);

                                    {
                                        var newNextNodeId = EditorGUILayout.TextField(response.NextNodeId, GUILayout.Width(296)); //nodeIds[EditorGUILayout.Popup(indexOfId, nodeIds.ToArray(), EditorStyles.toolbarPopup, GUILayout.Width(298))];
                                        if (response.NextNodeId != newNextNodeId)
                                        {
                                            CurrentPage.MementoStack.CreateMemento();
                                        }
                                        response.NextNodeId = newNextNodeId;
                                        if (!node.To.Contains(newNextNodeId))
                                            node.To.Add(newNextNodeId);
                                    }

                                    break;
                                case DialogResponse.NextNodeTypes.End:
                                    break;
                                case DialogResponse.NextNodeTypes.Script:
                                    {
                                        var newResponseNextNodeText = EditorGUILayout.TextArea(response.NextNodeText, GUILayout.Width(296));
                                        if (response.NextNodeText != newResponseNextNodeText)
                                            CurrentPage.MementoStack.CreateMemento();
                                        response.NextNodeText = newResponseNextNodeText;
                                    }
                                    EditorGUILayout.LabelField("C#", GUILayout.Width(25));
                                    break;
                            }
                        }


                        var responseNextNodeIdError = compileErrors.Find(x => x[1] == ("r" + i) && x[2].ToLower() == "nextnodeid");
                        if (responseNextNodeIdError != null)
                        {
                            EditorGUILayout.HelpBox(responseNextNodeIdError[3], MessageType.Error);
                        }


                        var responseNextNodeTypeError = compileErrors.Find(x => x[1] == ("r" + i) && x[2] == "NextNodeType");
                        if (responseNextNodeTypeError != null)
                        {
                            EditorGUILayout.HelpBox(responseNextNodeTypeError[3], MessageType.Error);
                        }

                        if (response.NextNodeType == DialogResponse.NextNodeTypes.Id)
                        {
                            if (string.IsNullOrEmpty(response.NextNodeId))
                            {
                                EditorGUILayout.HelpBox("Response NextNodeId cannot be blank!", MessageType.Error);
                            }
                            else if (response.NextNodeId.ToLower() != "end" && !Dialog.ContainsNode(response.NextNodeId))
                            {
                                EditorGUILayout.HelpBox("Response NextNodeId must be a valid node Id!", MessageType.Error);
                            }
                            else if (response.NextNodeId == node.Id)
                            {
                                EditorGUILayout.HelpBox("Response NextNodeId is pointing to itself! Make sure this is not a mistake.", MessageType.Warning);
                            }
                            else if (response.NextNodeId.ToLower() != "end" && Dialog.GetNode(response.NextNodeId).IsDeleted)
                            {
                                EditorGUILayout.HelpBox("Response NextNodeId is pointing to a node flagged for deletion!", MessageType.Error);
                            }
                        }
                        else if (response.NextNodeType == DialogResponse.NextNodeTypes.Script)
                        {
                            if (string.IsNullOrEmpty(response.NextNodeText))
                            {
                                EditorGUILayout.HelpBox("Response NextNodeId cannot be blank!", MessageType.Error);
                            }
                            else if (!response.NextNodeText.Contains("return"))
                            {
                                EditorGUILayout.HelpBox("Response NextNodeId must return a value!", MessageType.Error);
                            }
                        }
                        GUILayout.Space(2);
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            InfoButton(new Vector2(400, 50), "Triggered when the response is shown.");
                            EditorGUILayout.LabelField("OnShow:", GUILayout.Width(70));
                            {
                                var newResponseShowText = EditorGUILayout.TextArea(response.ShowText, GUILayout.Width(400));
                                if (newResponseShowText != response.ShowText)
                                    CurrentPage.MementoStack.CreateMemento();
                                response.ShowText = newResponseShowText;
                            }
                            EditorGUILayout.LabelField("C#", GUILayout.Width(25));
                        }


                        var responseShowError = compileErrors.Find(x => x[1] == ("r" + i) && x[2].ToLower() == "show");
                        if (responseShowError != null)
                        {
                            EditorGUILayout.HelpBox(responseShowError[3], MessageType.Error);
                        }

                        using (new EditorGUILayout.HorizontalScope())
                        {
                            InfoButton(new Vector2(400, 50), "Triggered when the response is selected.");
                            EditorGUILayout.LabelField("OnSelect:", GUILayout.Width(70));
                            {
                                var newResponseSelectText = EditorGUILayout.TextArea(response.SelectText, GUILayout.Width(400));
                                if (newResponseSelectText != response.SelectText)
                                    CurrentPage.MementoStack.CreateMemento();
                                response.SelectText = newResponseSelectText;
                            }
                            EditorGUILayout.LabelField("C#", GUILayout.Width(25));
                        }


                        var responseSelectError = compileErrors.Find(x => x[1] == ("r" + i) && x[2].ToLower() == "select");
                        if (responseSelectError != null)
                        {
                            EditorGUILayout.HelpBox(responseSelectError[3], MessageType.Error);
                        }

                    }
                    else
                    {
                        switch (response.NextNodeType)
                        {
                            case DialogResponse.NextNodeTypes.Id:
                                if (!node.To.Contains(response.NextNodeId))
                                    node.To.Add(response.NextNodeId);
                                break;
                        }
                    }
                    GUILayout.Space(5);
                }
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(1);

            }
            var endResponsesY = EditorGUILayout.GetControlRect().y;
            if (endResponsesY > 0)
                node.EditorResponsesHeight = endResponsesY - lastRect.y;

            //EditorGUI.indentLevel--;



            var fromIds = node.From.Keys.ToList();

            if (fromIds.Count > 0 || node.To.Count > 0)
                GUILayout.Space(15);

            if (fromIds.Count > 0)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                EditorGUILayout.BeginVertical(EditorStyles.toolbar);
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(5);
                EditorGUILayout.LabelField("From", GUILayout.Width(35));
                for (var i = 0; i < fromIds.Count; i++)
                {
                    var id = fromIds[i];

                    if (i > 0 && i % 10 == 0)
                    {
                        EditorGUILayout.EndHorizontal();
                        EditorGUILayout.BeginHorizontal();
                        GUILayout.Space(45);
                    }

                    if (GUILayout.Button(id, EditorStyles.toolbarButton, GUILayout.Width(50)))
                    {
                        CurrentPage.Pan = new Vector2(0, Mathf.RoundToInt(Dialog.GetNode(id).EditorPosition.y + CurrentPage.Pan.y - 200));
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();
            }

            if (node.To.Count > 0)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                EditorGUILayout.BeginVertical(EditorStyles.toolbar);
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(10);
                EditorGUILayout.LabelField("To", GUILayout.Width(30));
                for (var i = 0; i < node.To.Count; i++)
                {
                    var id = node.To[i];

                    if (i > 0 && i % 10 == 0)
                    {
                        EditorGUILayout.EndHorizontal();
                        EditorGUILayout.BeginHorizontal();
                        GUILayout.Space(45);
                    }

                    if (GUILayout.Button(id, EditorStyles.toolbarButton, GUILayout.Width(50)))
                    {
                        CurrentPage.Pan = new Vector2(0, Mathf.RoundToInt(Dialog.GetNode(id).EditorPosition.y + CurrentPage.Pan.y - 200));
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();
                //EditorGUILayout.LabelField(string.Join(", ", toIds.ToArray()));
            }


            if (node.To.Count > 0 || fromIds.Count > 0)
                GUILayout.Space(20);

            //   GUI.DragWindow();

            EditorStyles.textField.wordWrap = wordWrap;
            EditorStyles.textArea.wordWrap = wordWrap;
            EditorStyles.toolbar.fixedHeight = fixedHeight;


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

    public class StringEditorPopup : PopupWindowContent
    {
        private string _originalId;
        private string _id;
        private Func<string, bool> _isValidCallback;
        private Action<string> _onSaveCallback;

        public override Vector2 GetWindowSize()
        {
            return new Vector2(250, 100);
        }

        public StringEditorPopup(string id, Func<string, bool> isValidCallback, Action<string> onSaveCallback)
        {
            _originalId = id;
            _id = id;
            _isValidCallback = isValidCallback;
            _onSaveCallback = onSaveCallback;
        }

        public override void OnGUI(Rect rect)
        {
            EditorGUILayout.LabelField("Edit Id: " + _originalId);
            _id = EditorGUILayout.TextField(_id);

            if (!_isValidCallback(_id))
            {
                EditorGUILayout.HelpBox("The given id already exists.\nPlease choose a new id.", MessageType.Error);
            }
            else
            {
                GUILayout.Space(25);
                if (GUILayout.Button("Save"))
                {
                    _onSaveCallback(_id);
                    editorWindow.Close();
                }
            }

        }
    }



    public class LoadFromSpreadsheetEditorPopup : PopupWindowContent
    {
        private string _spreadsheetURL = "";
        private string _sheetId = "";
        private string _dialogId = "";
        private bool _reversePromptOrder;
        private Action<string, string, bool> _onCallback;
        private WWW _www;

        public override Vector2 GetWindowSize()
        {
            return new Vector2(500, 100);
        }

        public LoadFromSpreadsheetEditorPopup(Action<string, string, bool> onCallback)
        {
            _onCallback = onCallback;
            _spreadsheetURL = EditorPrefs.GetString("MUSE_DialogEditor_SpreadsheetURL");
            if (_spreadsheetURL == null)
                _spreadsheetURL = "";
            _sheetId = EditorPrefs.GetString("MUSE_DialogEditor_SheetId");
            if (_sheetId == null)
                _sheetId = "";
        }

        public override void OnGUI(Rect rect)
        {
            EditorGUILayout.LabelField("Load Description Spreadsheet");
            _spreadsheetURL = EditorGUILayout.TextField("Spreadsheet URL:", _spreadsheetURL);
            _sheetId = EditorGUILayout.TextField("Sheet Id:", _sheetId);
            _dialogId = EditorGUILayout.TextField("Dialog Id:", _dialogId);
            //_reversePromptOrder = EditorGUILayout.Toggle("Reverse Prompt Order:", _reversePromptOrder);

            EditorPrefs.SetString("MUSE_DialogEditor_SpreadsheetURL", _spreadsheetURL);
            EditorPrefs.SetString("MUSE_DialogEditor_SheetId", _sheetId);

            GUILayout.Space(5);
            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(150);
            if (GUILayout.Button("Load", EditorStyles.toolbarButton))
            {
                _www = new WWW("https://script.google.com/macros/s/AKfycbx7egNEDkhXIN0ISop_1uFaMlGYfPU6SCLeK-VVUcwzxiETeaA/exec?doc=" + _spreadsheetURL + "&sheet=" + _sheetId);

                EditorApplication.update -= OnUpdate;
                EditorApplication.update += OnUpdate;
            }
            EditorGUILayout.EndHorizontal();
        }

        void OnUpdate()
        {
            if (!_www.isDone)
                return;

            EditorApplication.update -= OnUpdate;
            var text = System.Text.Encoding.UTF8.GetString(_www.bytes, 3, _www.bytes.Length - 3);
            Debug.Log(_www.error);
            Debug.Log("text: " + text);
            Debug.Log("dialog id: " + _dialogId);
            _onCallback(!string.IsNullOrEmpty(_dialogId) ? _dialogId : _sheetId, text, _reversePromptOrder);
            editorWindow.Close();
        }
    }

    [Serializable]
    public class ConnectionData
    {
        public string From;
        public string To;
    }

}