using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Callbacks;

namespace Muse.Editors.States
{
    [Serializable]
    public class StateEditorMementoStack
    {
        [SerializeField]
        private List<StateEditorMemento> _undo = new List<StateEditorMemento>();
        [SerializeField]
        private List<StateEditorMemento> _redo = new List<StateEditorMemento>();

        public Action<StateEditorMemento> Restore = (T) => { Debug.Log("default Restore"); };
        public Func<StateEditorMemento> GetMementoData = () => { Debug.Log("default getmementodata"); return null; };
        public Action OnChange = () => { };

        public int UndoCount { get { return _undo.Count; } }
        public int RedoCount { get { return _redo.Count; } }

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
    public class StateEditorMemento
    {
        public List<StateEditorData> Data = new List<StateEditorData>();
        public List<string> FilterByTags = new List<string>();
        public List<StateHash> StateHashes = new List<StateHash>();
        public string StartingState = "";
    }

    [Serializable]
    public class HotspotEditorData
    {
        public enum HotspotTypes { Button, VideoPlayer, Animator };
        public string Id = "";
        public HotspotTypes HotspotType;

        public HotspotEditorData Clone()
        {
            var clone = new HotspotEditorData();
            clone.Id = Id;
            clone.HotspotType = HotspotType;
            return clone;
        }

        public override int GetHashCode()
        {
            return Utils.CombineHash(Id.GetHashCode(), HotspotType.GetHashCode());
        }
    }

    [Serializable]
    public class StateEditorData
    {

        public bool Delete;
        public List<string> Tags = new List<string>();
        public List<string> SoundTriggers = new List<string>();
        public string TagText
        {
            get
            {
                if (Tags.Count == 0)
                    return "";
                return Tags.Aggregate((next, tag) => next += ", " + tag);
            }
        }

        public string OriginalId = "";
        public string Id = "";
        public string ModuleId = "";
        public List<HotspotEditorData> Hotspots = new List<HotspotEditorData>();
        public string OnEnterText = "";
        public string OnShowText = "";
        public string OnExitText = "";
        public List<string> OnHotspotClickText = new List<string>();
        public List<string> OnHotspotCompleteText = new List<string>();

        public Rect EditorPosition = new Rect(400, 50, 650, 150);
        public bool EditorShowData = true;
        public bool EditorShowHotspots = true;
        public bool EditorShowCallbacks = true;
        public bool EditorShowVisuals = true;
        public bool EditorShowTags = true;
        public bool EditorShowAudio = true;

        public List<string> ModuleIds = new List<string>();
        public List<string> Characters = new List<string>();

        public bool AutoSave = true;

        public StateEditorData Clone()
        {
            var clone = new StateEditorData();
            clone.Tags = Tags.ToList();
            clone.SoundTriggers = SoundTriggers.ToList();
            clone.Id = Id;
            clone.ModuleId = ModuleId;
            clone.Hotspots = Hotspots.ToList().ConvertAll<HotspotEditorData>(x => x.Clone());
            clone.OnEnterText = OnEnterText;
            clone.OnShowText = OnShowText;
            clone.OnExitText = OnExitText;
            clone.OnHotspotClickText = OnHotspotClickText.ToList();
            clone.OnHotspotCompleteText = OnHotspotCompleteText.ToList();
            clone.Delete = Delete;
            clone.AutoSave = AutoSave;

            clone.EditorPosition = EditorPosition;
            return clone;
        }

        public override int GetHashCode()
        {
            //Debug.Log("state: " + Id);
            var tagHash = Tags.Count == 0 ? 0 : Utils.CombineHash(Tags.Count.GetHashCode(), Tags.ConvertAll<int>(x => x.GetHashCode()).Aggregate((x, next) => Utils.CombineHash(x, next)));
            var modulesHash = ModuleIds.Count == 0 ? 0 : Utils.CombineHash(ModuleIds.Count.GetHashCode(), ModuleIds.ConvertAll<int>(x => x.GetHashCode()).Aggregate((x, next) => Utils.CombineHash(x, next)));
            var charactersHash = Characters.Count == 0 ? 0 : Utils.CombineHash(Characters.Count.GetHashCode(), Characters.ConvertAll<int>(x => x.GetHashCode()).Aggregate((x, next) => Utils.CombineHash(x, next)));
            var soundHash = SoundTriggers.Count == 0 ? 0 : Utils.CombineHash(SoundTriggers.Count.GetHashCode(), SoundTriggers.ConvertAll<int>(x => x.GetHashCode()).Aggregate((x, next) => Utils.CombineHash(x, next)));
            var hotspotsHash = Hotspots.Count == 0 ? 0 : Utils.CombineHash(Hotspots.Count.GetHashCode(), Hotspots.ConvertAll<int>(x => x.GetHashCode()).Aggregate((x, next) => Utils.CombineHash(x, next)));
            var hotspotsClickHash = OnHotspotClickText.Count == 0 ? 0 : Utils.CombineHash(OnHotspotClickText.Count.GetHashCode(), OnHotspotClickText.ConvertAll<int>(x => x.GetHashCode()).Aggregate((x, next) => Utils.CombineHash(x, next)));
            var hotspotsCompleteHash = OnHotspotCompleteText.Count == 0 ? 0 : Utils.CombineHash(OnHotspotCompleteText.Count.GetHashCode(), OnHotspotCompleteText.ConvertAll<int>(x => x.GetHashCode()).Aggregate((x, next) => Utils.CombineHash(x, next)));

            //Debug.Log("state hash " + Id + " " + tagHash + ", " + soundHash + ", " + hotspotsHash + ", " + hotspotsClickHash + ", " + hotspotsCompleteHash);
            return Utils.CombineHash(tagHash, modulesHash, charactersHash, soundHash, Id.GetHashCode(), hotspotsHash, OnEnterText.GetHashCode(), OnShowText.GetHashCode(), OnExitText.GetHashCode(),
                hotspotsClickHash, hotspotsCompleteHash, Delete.GetHashCode(), AutoSave.GetHashCode());
        }

    }

    public class StateEditorPersistentData : ScriptableObject
    {
        public List<string> FilterByTags = new List<string>();
        public List<StateEditorData> States = new List<StateEditorData>();
        public string StartingState = "";
        public List<HotspotSceneData> ScenesFound = new List<HotspotSceneData>();
        public List<HotspotSceneData> HotspotsFoundInScenes = new List<HotspotSceneData>();
        public StateEditorMementoStack MementoStack = new StateEditorMementoStack();
        public List<Character> Characters = new List<Character>();

        public string HotspotGUID;

        public int SelectedIndex = -1;
        public bool AutomaticallyOpenVisualScenes;

        public Texture2D ErrorImage;

        public List<StateEditorErrors> Errors = new List<StateEditorErrors>();
        public List<string> StatesWithErrors = new List<string>();

        public List<StateHash> StateHashes = new List<StateHash>();

        public StateEditorPersistentData()
        {
        }
    }

    [Serializable]
    public class StateHash
    {
        public string Id;
        public int Hash;
    }

    public class StateEditorErrors
    {
        public string Message;
        public string StateId;
        public string Location;
    }

    public class HotspotSceneData
    {
        public string StateId;
        public string HotspotId;
        public string Path;
    }

    public class StateEditor : EditorWindow
    {

        public static StateEditor Instance { get; private set; }

        public const string STATES_PATH = MuseEditor.GameDataPathRaw + "States/";


        public StateEditorPersistentData Data;
        private static List<List<string>> _errorTags = new List<List<string>>();

        public Vector2 Pan;

        public static void Setup()
        {
            Debug.Log("setup");
            if (!System.IO.Directory.Exists(STATES_PATH))
                System.IO.Directory.CreateDirectory(STATES_PATH);

            if (!System.IO.Directory.Exists(MuseEditor.GameDataPathCompiled + "States"))
                System.IO.Directory.CreateDirectory(MuseEditor.GameDataPathCompiled + "States");

            if (!System.IO.Directory.Exists(MuseEditor.GamePathRaw + "Npcs/"))
                System.IO.Directory.CreateDirectory(MuseEditor.GamePathRaw + "Npcs/");

            if (!System.IO.Directory.Exists(MuseEditor.GamePathCompiledRaw + "Npcs/"))
                System.IO.Directory.CreateDirectory(MuseEditor.GamePathCompiledRaw + "Npcs/");

            if (!File.Exists(MuseEditor.GameDataPathRaw + "States/GameFlags.cs"))
            {
                Debug.Log("create gameflags");
                var classWriter = new ClassWriter();
                classWriter.Name = "GameFlags";
                classWriter.IsPartial = true;
                classWriter.IsStatic = true;
                classWriter.IsPublic = true;
                var gameflagPropertyWriter = classWriter.CreatePropertyWriter();
                gameflagPropertyWriter.Name = "_StartingState";
                gameflagPropertyWriter.IsStatic = true;
                gameflagPropertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
                gameflagPropertyWriter.Type = "string";
                gameflagPropertyWriter.Value = "\"\"";

                gameflagPropertyWriter = classWriter.CreatePropertyWriter();
                gameflagPropertyWriter.Name = "StartingState";
                gameflagPropertyWriter.IsStatic = true;
                gameflagPropertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                gameflagPropertyWriter.Type = "string";
                gameflagPropertyWriter.AddGetterLine("return _StartingState;");
                gameflagPropertyWriter.AddSetterLine("_StartingState = value;");

                classWriter.WritePath(MuseEditor.GameDataPathRaw + "States/GameFlags.cs");
            }

            if (!File.Exists(MuseEditor.GameDataPathCompiled + "States/GameFlags.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "GameFlags";
                classWriter.IsPartial = true;
                classWriter.IsStatic = true;
                classWriter.IsPublic = true;
                var gameflagPropertyWriter = classWriter.CreatePropertyWriter();
                gameflagPropertyWriter.Name = "_StartingState";
                gameflagPropertyWriter.IsStatic = true;
                gameflagPropertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
                gameflagPropertyWriter.Type = "string";
                gameflagPropertyWriter.Value = "\"\"";

                gameflagPropertyWriter = classWriter.CreatePropertyWriter();
                gameflagPropertyWriter.Name = "StartingState";
                gameflagPropertyWriter.IsStatic = true;
                gameflagPropertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                gameflagPropertyWriter.Type = "string";
                gameflagPropertyWriter.AddGetterLine("return _StartingState;");
                gameflagPropertyWriter.AddSetterLine("_StartingState = value;");

                classWriter.WritePath(MuseEditor.GameDataPathCompiled + "States/GameFlags.cs");
            }
        }

        [MenuItem("Muse/Editors/Data/States")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<StateEditor>();
            window.titleContent = new GUIContent("States");
            window.Show();
            
            Instance = window;
            window.Data = ScriptableObject.CreateInstance<StateEditorPersistentData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "StateEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Reload();


            window.Data.ErrorImage = Resources.Load<Texture2D>("error");

            OnSetupMementoStack();
            Instance.ParseStateScenes();
            EditorApplication.update += OnUpdate;

            window.Data.Characters = Directory.GetFiles(Application.dataPath + "/Muse/Game/Npcs", "*.prefab", SearchOption.AllDirectories).ToList().ConvertAll(x => "Assets" + x.Replace("\\", "/").Replace(Application.dataPath, "")).ConvertAll<Character>(x => AssetDatabase.LoadAssetAtPath<Character>(x));

        }

        [DidReloadScripts]
        static void OnReloadScripts()
        {
            var windows = Resources.FindObjectsOfTypeAll<StateEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];
            Instance.Data.HotspotsFoundInScenes.Clear();

            Instance.Data.Characters = Directory.GetFiles(Application.dataPath + "/Muse/Game/Npcs", "*.prefab", SearchOption.AllDirectories).ToList().ConvertAll(x => "Assets" + x.Replace("\\", "/").Replace(Application.dataPath, "")).ConvertAll<Character>(x => AssetDatabase.LoadAssetAtPath<Character>(x));

            OnSetupMementoStack();
            Instance.ParseStateScenes();
            EditorApplication.update += OnUpdate;
        }

        static void OnSetupMementoStack()
        {
            Instance.Data.MementoStack.Restore = (memento) =>
            {
                Instance.Data.States.Clear();
                for (var i = 0; i < memento.Data.Count; i++)
                {
                    Instance.Data.States.Add(memento.Data[i].Clone());
                }
                Instance.Data.FilterByTags = memento.FilterByTags.ToList();
                Instance.Data.StartingState = memento.StartingState;

                Instance.Data.StateHashes.Clear();
                for (var i = 0; i < memento.StateHashes.Count; i++)
                {
                    Instance.Data.StateHashes.Add(new StateHash() { Id = memento.StateHashes[i].Id, Hash = memento.StateHashes[i].Hash });
                }

            };
            Instance.Data.MementoStack.GetMementoData = () =>
            {
                var memento = new StateEditorMemento();
                for (var i = 0; i < Instance.Data.States.Count; i++)
                {
                    var stateData = Instance.Data.States[i];
                    memento.Data.Add(stateData.Clone());
                }
                memento.FilterByTags = Instance.Data.FilterByTags.ToList();
                memento.StartingState = Instance.Data.StartingState;
                memento.StateHashes = new List<StateHash>();
                for (var i = 0; i < Instance.Data.StateHashes.Count; i++)
                {
                    memento.StateHashes.Add(new StateHash() { Id = Instance.Data.StateHashes[i].Id, Hash = Instance.Data.StateHashes[i].Hash });
                }
                return memento;
            };
        }

        void OnDestroy()
        {
            Instance = null;
        }


        void Save()
        {
            var stateFiles = Directory.GetFiles(STATES_PATH).ToList().FindAll(x => x.Contains("state_") && !x.Contains(".meta") && !x.Contains("_GameFlags"));
            var gameflagFiles = Directory.GetFiles(STATES_PATH).ToList().FindAll(x => x.Contains("state_") && !x.Contains(".meta") && x.Contains("_GameFlags"));
            
            var gameflagWriter = new ClassWriter();
            gameflagWriter.Name = "GameFlags";
            gameflagWriter.IsPartial = true;
            gameflagWriter.IsStatic = true;
            gameflagWriter.IsPublic = true;

            var gameflagPropertyWriter = gameflagWriter.CreatePropertyWriter();
            gameflagPropertyWriter.Name = "_StartingState";
            gameflagPropertyWriter.IsStatic = true;
            gameflagPropertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
            gameflagPropertyWriter.Type = "string";
            gameflagPropertyWriter.Value = "\"" + Data.StartingState + "\"";

            gameflagPropertyWriter = gameflagWriter.CreatePropertyWriter();
            gameflagPropertyWriter.Name = "StartingState";
            gameflagPropertyWriter.IsStatic = true;
            gameflagPropertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
            gameflagPropertyWriter.Type = "string";
            gameflagPropertyWriter.AddGetterLine("return _StartingState;");
            gameflagPropertyWriter.AddSetterLine("_StartingState = value;");
            gameflagWriter.WritePath(STATES_PATH + "GameFlags.cs");


            var stateFileNames = stateFiles.ConvertAll<string>(x =>
            {
                var index = x.IndexOf("state_");
                x = x.Substring(index, x.Length - index);
                return x.Substring(6, x.Length - 6).Replace(".cs", "");
            });

            for (var i = 0; i < Data.States.Count; i++)
            {
                var state = Data.States[i];

                var stateHashData = Data.StateHashes.Find(x => x.Id == state.Id.ToUpper());
                var isDirty = stateHashData == null || stateHashData.Hash != state.GetHashCode();
                // Debug.Log(state.Id + ", " + isDirty + ", " + stateHashData + ", " + (stateHashData != null ? stateHashData.Hash + " " + state.GetHashCode() : ""));

                if (state.Delete)
                {
                    if (File.Exists(Application.dataPath + "/Muse/Game/Scenes/" + state.OriginalId + ".unity") && EditorUtility.DisplayDialog("Delete Scene and Assets?", "Delete the visual scene and asset folder corresponding to the state \"" + state.Id + "\"? Deleting the visual scene and asset folder cannot be undone.", "Delete", "Ignore"))
                    {
                        var scenePath = Application.dataPath + "/Muse/Game/Scenes/" + state.OriginalId + ".unity";
                        Debug.Log("delete " + scenePath);
                        if (File.Exists(scenePath))
                            File.Delete(scenePath);

                        var assetFolderPath = Application.dataPath + "/Muse/Game/States/" + state.OriginalId;
                        if (Directory.Exists(assetFolderPath))
                            Directory.Delete(assetFolderPath, true);
                    }
                    var file = stateFiles.Find(x => x.Contains("state_" + state.Id + ".cs"));
                    var gameFlagFile = gameflagFiles.Find(x => x.Contains("state_" + state.Id + "_GameFlags.cs"));
                    if (File.Exists(file))
                        File.Delete(file);
                    if (File.Exists(gameFlagFile))
                        File.Delete(gameFlagFile);
                    Data.States.Remove(state);
                    Data.StateHashes.Remove(Data.StateHashes.Find(x => x.Id == state.Id.ToUpper()));
                    i--;



                    continue;
                }




                if (stateHashData == null)
                    Data.StateHashes.Add(new StateHash() { Id = state.Id.ToUpper(), Hash = state.GetHashCode() });
                else
                    stateHashData.Hash = state.GetHashCode();

                if (!isDirty)
                    continue;

                if (!string.IsNullOrEmpty(state.OriginalId) && state.OriginalId != state.Id)
                {
                    Debug.Log("id changed: " + state.OriginalId + ", " + state.Id);
                    Debug.Log("does file exist? " + Application.dataPath + "/Muse/Game/Scenes/" + state.OriginalId + ".unity" + ", " + File.Exists(Application.dataPath + "/Muse/Game/Scenes/" + state.OriginalId + ".unity"));
                    if (File.Exists(Application.dataPath + "/Muse/Game/Scenes/" + state.OriginalId + ".unity"))
                    {
                        Debug.Log("moving scene from: " + state.OriginalId + ", " + state.Id);
                        File.Move(Application.dataPath + "/Muse/Game/Scenes/" + state.OriginalId + ".unity", Application.dataPath + "/Muse/Game/Scenes/" + state.Id + ".unity");
                    }


                    var assetFolderPath = Application.dataPath + "/Muse/Game/States/" + state.OriginalId;
                    var newAssetFolderPath = Application.dataPath + "/Muse/Game/States/" + state.Id;
                    if (Directory.Exists(assetFolderPath))
                        Directory.Move(assetFolderPath, newAssetFolderPath);
                }

                if (!File.Exists(Application.dataPath + "/Muse/Game/Scenes/" + state.Id + ".unity"))
                {
                    Debug.Log("new scene for : " + state.Id);
                    var scene = UnityEditor.SceneManagement.EditorSceneManager.NewScene(UnityEditor.SceneManagement.NewSceneSetup.EmptyScene, UnityEditor.SceneManagement.NewSceneMode.Single);

                    var go = new GameObject();
                    go.name = "SceneHelper";
                    go.AddComponent<SceneCameraPositions>();
                    go.AddComponent<SceneObjectPositions>();
                    go.AddComponent<SceneObjectSets>();
                    go.AddComponent<SceneTimelines>();
                    go.AddComponent<SceneEventTriggers>();

                    if (MuseEditor.OnStateEditorCreateScene != null)
                        MuseEditor.OnStateEditorCreateScene();

                    UnityEditor.SceneManagement.EditorSceneManager.SaveScene(scene, "Assets/Muse/Game/Scenes/" + state.Id + ".unity");
                }

                if (!Directory.Exists(Application.dataPath + "/Muse/Game/States/" + state.Id))
                {
                    Directory.CreateDirectory(Application.dataPath + "/Muse/Game/States/" + state.Id);
                    File.CreateText(Application.dataPath + "/Muse/Game/States/" + state.Id + "/.keep");
                }
                state.OriginalId = state.Id;

                Debug.Log("save: " + state.Id);
                if (Data.StateHashes.Find(x => x.Id == state.Id.ToUpper()) != null)
                    Data.StateHashes.Find(x => x.Id == state.Id.ToUpper()).Hash = state.GetHashCode();
                else
                    Data.StateHashes.Add(new StateHash() { Id = state.Id.ToUpper(), Hash = state.GetHashCode() });

                gameflagWriter = new ClassWriter();
                gameflagWriter.Name = "GameFlags";
                gameflagWriter.IsPartial = true;
                gameflagWriter.IsStatic = true;
                gameflagWriter.IsPublic = true;

                for (var j = 0; j < state.Hotspots.Count; j++)
                {
                    var hotspot = state.Hotspots[j];
                    var hotspotId = hotspot.Id;
                    var hotspotActiveName = "HotspotActive_" + state.Id + "_" + hotspotId;
                    gameflagPropertyWriter = gameflagWriter.CreatePropertyWriter();
                    gameflagPropertyWriter.Name = "_" + hotspotActiveName;
                    gameflagPropertyWriter.IsStatic = true;
                    gameflagPropertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
                    gameflagPropertyWriter.Type = "int";
                    gameflagPropertyWriter.Value = "1";

                    gameflagPropertyWriter = gameflagWriter.CreatePropertyWriter();
                    gameflagPropertyWriter.Name = hotspotActiveName;
                    gameflagPropertyWriter.IsStatic = true;
                    gameflagPropertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                    gameflagPropertyWriter.Type = "int";
                    gameflagPropertyWriter.AddGetterLine("return _" + hotspotActiveName + ";");
                    gameflagPropertyWriter.AddSetterLine("var oldValue = _" + hotspotActiveName + ";");
                    gameflagPropertyWriter.AddSetterLine("_" + hotspotActiveName + " = value;");
                    gameflagPropertyWriter.AddSetterLine("GameFlagChanged(\"" + hotspotActiveName + "\", oldValue, value);");
                }
                gameflagWriter.WritePath(STATES_PATH + "state_" + state.Id + "_GameFlags.cs");

                //stateHashData = Data.StateHashes.Find(x => x.Id == state.Id.ToUpper());
                //Debug.Log("saved hash: " + stateHashData.Hash + " " + state.GetHashCode());


                var classWriter = new ClassWriter();
                classWriter.AddTopLine("using UnityEngine;");
                classWriter.AddTopLine("using System;");
                classWriter.AddTopLine("using System.Collections;");
                classWriter.AddTopLine("using System.Collections.Generic;");
                for (var j = 0; j < state.SoundTriggers.Count; j++)
                {
                    classWriter.AddTopLine("[AudioTrigger(\"" + state.SoundTriggers[j] + "\", \"Called from the state: " + state.Id + "\")]");
                }
                classWriter.AddTopLine("");

                classWriter.AddTopLine("[State(\"" + state.Id + "\"" + (state.Hotspots.Count == 0 ? "" : ", " + state.Hotspots.ConvertAll(x => "\"" + x.Id + "\"").Aggregate((hotspotId, next) => next += ", " + hotspotId)) + ")]");

                classWriter.Name = "State_" + state.Id + " : State";
                classWriter.IsPublic = true;


                var method = classWriter.CreateMethodWriter();
                method.Name = "State_" + state.Id;
                method.VisibilityType = MethodWriter.VisibilityTypes.Public;
                method.AddLine("///Id " + state.Id);
                method.AddLine("Id = \"" + state.Id + "\";");
                method.AddLine("///ModuleId " + state.ModuleId);
                method.AddLine("ModuleId = \"" + state.ModuleId + "\";");
                method.AddLine("///Autosave " + state.AutoSave.ToString().ToLower());
                method.AddLine("Autosave = " + state.AutoSave.ToString().ToLower() + ";");
                method.AddLine("///Tags " + (state.Tags.Count == 0 ? "" : state.Tags.Aggregate((next, tag) => next += ";" + tag)));
                method.AddLine("Tags = new List<string>() {" + (state.Tags.Count == 0 ? "" : state.Tags.ConvertAll(x => "\"" + x + "\"").Aggregate((tag, next) => next += "," + tag)) + "};");
                method.AddLine("///HotspotIds " + (state.Hotspots.Count == 0 ? "" : state.Hotspots.ConvertAll<string>(x => x.Id).Aggregate((next, hotspotId) => next += ";" + hotspotId)));
                method.AddLine("HotspotIds = new List<string>() {" + (state.Hotspots.Count == 0 ? "" : state.Hotspots.ConvertAll<string>(x => "\"" + x.Id + "\"").Aggregate((hotspotId, next) => next += "," + hotspotId)) + "};");
                method.AddLine("///HotspotTypes " + (state.Hotspots.Count == 0 ? "" : state.Hotspots.ConvertAll<string>(x => Enum.GetName(typeof(HotspotEditorData.HotspotTypes), x.HotspotType)).Aggregate((next, hasOnClick) => next += ";" + hasOnClick)));
                method.AddLine("///SoundTriggers " + (state.SoundTriggers.Count == 0 ? "" : state.SoundTriggers.Aggregate((next, soundTrigger) => next += ";" + soundTrigger)));
                method.AddLine("///Modules " + (state.ModuleIds.Count == 0 ? "" : state.ModuleIds.Aggregate((next, module) => next += ";" + module)));
                method.AddLine("Modules = new List<string>() {" + (state.ModuleIds.Count == 0 ? "" : state.ModuleIds.ConvertAll<string>(x => "\"" + x + "\"").Aggregate((module, next) => next += "," + module)) + "};");
                method.AddLine("///Characters " + (state.Characters.Count == 0 ? "" : state.Characters.Aggregate((next, character) => next += ";" + character)));
                method.AddLine("Characters = new List<string>() {" + (state.Characters.Count == 0 ? "" : state.Characters.ConvertAll<string>(x => "\"" + x + "\"").Aggregate((character, next) => next += "," + character)) + "};");

                if (!string.IsNullOrEmpty(state.OnEnterText))
                    method.AddLine((state.OnEnterText.Contains("yield") ? "OnEnterBlocking" : "OnEnter") + " = OnEnterCallback;");
                if (!string.IsNullOrEmpty(state.OnShowText))
                    method.AddLine((state.OnShowText.Contains("yield") ? "OnShowBlocking" : "OnShow") + " = OnShowCallback;");
                if (!string.IsNullOrEmpty(state.OnExitText))
                    method.AddLine((state.OnExitText.Contains("yield") ? "OnExitBlocking" : "OnExit") + " = OnExitCallback;");

                for (var j = 0; j < state.Hotspots.Count; j++)
                {
                    var hotspotId = state.Hotspots[j].Id;
                    var hotspotClickText = state.OnHotspotClickText[j];
                    if (!string.IsNullOrEmpty(hotspotClickText))
                        method.AddLine((hotspotClickText.Contains("yield") ? "OnHotspotClickBlocking" : "OnHotspotClick") + ".Add(\"" + hotspotId + "\", On" + hotspotId + "ClickCallback);");
                    if (state.OnHotspotCompleteText.Count <= j)
                        state.OnHotspotCompleteText.Add("");
                    var hotspotCompleteText = state.OnHotspotCompleteText[j];
                    if (!string.IsNullOrEmpty(hotspotCompleteText))
                        method.AddLine((hotspotCompleteText.Contains("yield") ? "OnHotspotCompleteBlocking" : "OnHotspotComplete") + ".Add(\"" + hotspotId + "\", On" + hotspotId + "CompleteCallback);");
                }

                if (!string.IsNullOrEmpty(state.OnEnterText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "OnEnterCallback";
                    method.AddArg(new MethodArg() { Name = "state", Type = "State" });
                    method.ReturnType = state.OnEnterText.Contains("yield") ? "IEnumerator" : "void";
                    method.AddLines(state.OnEnterText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(state.OnShowText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "OnShowCallback";
                    method.AddArg(new MethodArg() { Name = "state", Type = "State" });
                    method.ReturnType = state.OnShowText.Contains("yield") ? "IEnumerator" : "void";
                    method.AddLines(state.OnShowText.Split('\n'));
                }

                if (!string.IsNullOrEmpty(state.OnExitText))
                {
                    method = classWriter.CreateMethodWriter();
                    method.Name = "OnExitCallback";
                    method.AddArg(new MethodArg() { Name = "state", Type = "State" });
                    method.ReturnType = state.OnExitText.Contains("yield") ? "IEnumerator" : "void";
                    method.AddLines(state.OnExitText.Split('\n'));
                }

                for (var j = 0; j < state.Hotspots.Count; j++)
                {
                    var hotspotId = state.Hotspots[j].Id;
                    var hotspotClickText = state.OnHotspotClickText[j];

                    if (!string.IsNullOrEmpty(hotspotClickText))
                    {
                        method = classWriter.CreateMethodWriter();
                        method.Name = "On" + hotspotId + "ClickCallback";
                        method.AddArg(new MethodArg() { Name = "state", Type = "State" });
                        method.ReturnType = hotspotClickText.Contains("yield") ? "IEnumerator" : "void";
                        method.AddLines(hotspotClickText.Split('\n'));
                    }

                    var hotspotCompleteText = state.OnHotspotCompleteText[j];

                    if (!string.IsNullOrEmpty(hotspotCompleteText))
                    {
                        method = classWriter.CreateMethodWriter();
                        method.Name = "On" + hotspotId + "CompleteCallback";
                        method.AddArg(new MethodArg() { Name = "state", Type = "State" });
                        method.ReturnType = hotspotCompleteText.Contains("yield") ? "IEnumerator" : "void";
                        method.AddLines(hotspotCompleteText.Split('\n'));
                    }
                }

                classWriter.WritePath(STATES_PATH + "state_" + state.Id + ".cs");
                AssetDatabase.Refresh();
            }

            for (var i = 0; i < stateFileNames.Count; i++)
            {
                var deleted = Data.States.Find(x => x.Id.ToLower() == stateFileNames[i].ToLower()) == null;
                if (deleted)
                {
                    File.Delete(stateFiles[i]);
                    File.Delete(stateFiles[i].Replace(".cs", "_GameFlags.cs"));
                }
            }

            Data.MementoStack.Clear();
            AssetDatabase.Refresh();
            ParseStateScenes();
        }

        void ReloadState(string stateId)
        {
            var stateFiles = Directory.GetFiles(STATES_PATH).ToList();

            var existingState = Data.States.Find(x => x.Id == stateId);
            if (existingState != null)
            {
                Data.States.Remove(existingState);
                Data.StateHashes.Remove(Data.StateHashes.Find(x => x.Id == stateId));
            }
            var path = stateFiles.Find(x => x.Contains("state_" + stateId) && !x.Contains(".meta") && !x.Contains("_GameFlags"));


            // Debug.Log("path: " + path);
            var classWriter = ClassWriter.Load(path);

            var state = new StateEditorData();
            Data.States.Add(state);

            var body = classWriter.GetMethod(classWriter.Name.Replace(" : Quest", ""));
            var bodyLines = body.Lines.ToList();

            state.Id = bodyLines.Find(x => x.Contains("///Id")).Replace("///Id", "").Trim();
            state.ModuleId = bodyLines.Find(x => x.Contains("///ModuleId")).Replace("///ModuleId", "").Trim();
            state.AutoSave = bool.Parse(bodyLines.Find(x => x.Contains("///Autosave")).Replace("///Autosave", "").Trim());

            var tagsText = bodyLines.Find(x => x.Contains("///Tags")).Replace("///Tags", "").Trim();
            if (tagsText.Length == 0)
                state.Tags = new List<string>();
            else
                state.Tags = new List<string>(tagsText.Split(';'));

            var hotspotIdsText = bodyLines.Find(x => x.Contains("///HotspotIds")).Replace("///HotspotIds", "").Trim();
            if (hotspotIdsText.Length == 0)
            {
                state.Hotspots = new List<HotspotEditorData>();
                state.OnHotspotClickText = new List<string>();
                state.OnHotspotCompleteText = new List<string>();
            }
            else
            {
                var hotspotTypesText = bodyLines.Find(x => x.Contains("///HotspotTypes")).Replace("///HotspotTypes", "").Trim().Split(';');
                state.Hotspots = new List<string>(hotspotIdsText.Split(';')).ConvertAll<HotspotEditorData>(x => new HotspotEditorData() { Id = x });
                state.OnHotspotClickText = new List<string>();
                state.OnHotspotCompleteText = new List<string>();
                for (var j = 0; j < state.Hotspots.Count; j++)
                {
                    state.OnHotspotClickText.Add("");
                    state.OnHotspotCompleteText.Add("");
                    state.Hotspots[j].HotspotType = (HotspotEditorData.HotspotTypes)Enum.Parse(typeof(HotspotEditorData.HotspotTypes), hotspotTypesText[j]);
                }
            }

            var soundTriggers = bodyLines.Find(x => x.Contains("///SoundTriggers")).Replace("///SoundTriggers", "").Trim();
            if (soundTriggers.Length == 0)
                state.SoundTriggers = new List<string>();
            else
                state.SoundTriggers = new List<string>(soundTriggers.Split(';'));

            if (classWriter.GetMethod("OnEnterCallback") != null)
                state.OnEnterText = classWriter.GetMethod("OnEnterCallback").GetText();
            if (classWriter.GetMethod("OnShowCallback") != null)
                state.OnShowText = classWriter.GetMethod("OnShowCallback").GetText();
            if (classWriter.GetMethod("OnExitCallback") != null)
                state.OnExitText = classWriter.GetMethod("OnExitCallback").GetText();

            for (var j = 0; j < state.Hotspots.Count; j++)
            {
                var hotspotId = state.Hotspots[j].Id;
                var clickMethod = classWriter.GetMethod("On" + hotspotId + "ClickCallback");
                if (clickMethod != null)
                    state.OnHotspotClickText[j] = clickMethod.GetText();
                var completeMethod = classWriter.GetMethod("On" + hotspotId + "CompleteCallback");
                if (completeMethod != null)
                    state.OnHotspotCompleteText[j] = completeMethod.GetText();
            }

            //Debug.Log("State Hash: " + state.Id.ToUpper());
            Data.StateHashes.Add(new StateHash() { Id = state.Id.ToUpper(), Hash = state.GetHashCode() });
        }

        void Reload()
        {
            Data.StateHashes.Clear();
            var stateFiles = Directory.GetFiles(STATES_PATH);

            Data.States.Clear();

            var gameFlagsWriter = ClassWriter.Load(STATES_PATH + "GameFlags.cs");
            Data.StartingState = gameFlagsWriter.GetProperty("_StartingState").Value.Replace(";", "").Replace("\"", "");

            Debug.Log(stateFiles.Length);
            for (var i = 0; i < stateFiles.Length; i++)
            {
                var path = stateFiles[i];
                if (!path.Contains("state") || path.Contains(".meta") || path.Contains("_GameFlags"))
                    continue;


                // Debug.Log("path: " + path);
                var classWriter = ClassWriter.Load(path);

                var state = new StateEditorData();
                Data.States.Add(state);

                var body = classWriter.GetMethod(classWriter.Name.Replace(" : Quest", ""));
                var bodyLines = body.Lines.ToList();

                state.Id = bodyLines.Find(x => x.Contains("///Id")).Replace("///Id", "").Trim();
                state.OriginalId = state.Id;
                state.ModuleId = bodyLines.Find(x => x.Contains("///ModuleId")).Replace("///ModuleId", "").Trim();
                if (bodyLines.Find(x => x.Contains("///Autosave")) != null)
                    state.AutoSave = bool.Parse(bodyLines.Find(x => x.Contains("///Autosave")).Replace("///Autosave", "").Trim());

                var tagsText = bodyLines.Find(x => x.Contains("///Tags")).Replace("///Tags", "").Trim();
                if (tagsText.Length == 0)
                    state.Tags = new List<string>();
                else
                    state.Tags = new List<string>(tagsText.Split(';'));

                if (bodyLines.Find(x => x.Contains("///Modules")) != null)
                {
                    var modulesText = bodyLines.Find(x => x.Contains("///Modules")).Replace("///Modules", "").Trim();
                    if (modulesText.Length == 0)
                        state.ModuleIds = new List<string>();
                    else
                        state.ModuleIds = new List<string>(modulesText.Split(';'));
                }

                if (bodyLines.Find(x => x.Contains("///Characters")) != null)
                {
                    var charactersText = bodyLines.Find(x => x.Contains("///Characters")).Replace("///Characters", "").Trim();
                    if (charactersText.Length == 0)
                        state.Characters = new List<string>();
                    else
                        state.Characters = new List<string>(charactersText.Split(';'));
                }
                

                var hotspotIdsText = bodyLines.Find(x => x.Contains("///HotspotIds")).Replace("///HotspotIds", "").Trim();
                if (hotspotIdsText.Length == 0)
                {
                    state.Hotspots = new List<HotspotEditorData>();
                    state.OnHotspotClickText = new List<string>();
                    state.OnHotspotCompleteText = new List<string>();
                }
                else
                {
                    var hotspotTypesText = bodyLines.Find(x => x.Contains("///HotspotTypes")).Replace("///HotspotTypes", "").Trim().Split(';');
                    state.Hotspots = new List<string>(hotspotIdsText.Split(';')).ConvertAll<HotspotEditorData>(x => new HotspotEditorData() { Id = x });
                    state.OnHotspotClickText = new List<string>();
                    state.OnHotspotCompleteText = new List<string>();
                    for (var j = 0; j < state.Hotspots.Count; j++)
                    {
                        state.OnHotspotClickText.Add("");
                        state.OnHotspotCompleteText.Add("");
                        state.Hotspots[j].HotspotType = (HotspotEditorData.HotspotTypes)Enum.Parse(typeof(HotspotEditorData.HotspotTypes), hotspotTypesText[j]);
                    }
                }

                var soundTriggers = bodyLines.Find(x => x.Contains("///SoundTriggers")).Replace("///SoundTriggers", "").Trim();
                if (soundTriggers.Length == 0)
                    state.SoundTriggers = new List<string>();
                else
                    state.SoundTriggers = new List<string>(soundTriggers.Split(';'));

                if (classWriter.GetMethod("OnEnterCallback") != null)
                    state.OnEnterText = classWriter.GetMethod("OnEnterCallback").GetText();
                if (classWriter.GetMethod("OnShowCallback") != null)
                    state.OnShowText = classWriter.GetMethod("OnShowCallback").GetText();
                if (classWriter.GetMethod("OnExitCallback") != null)
                    state.OnExitText = classWriter.GetMethod("OnExitCallback").GetText();

                for (var j = 0; j < state.Hotspots.Count; j++)
                {
                    var hotspotId = state.Hotspots[j].Id;
                    var clickMethod = classWriter.GetMethod("On" + hotspotId + "ClickCallback");
                    if (clickMethod != null)
                        state.OnHotspotClickText[j] = clickMethod.GetText();
                    var completeMethod = classWriter.GetMethod("On" + hotspotId + "CompleteCallback");
                    if (completeMethod != null)
                        state.OnHotspotCompleteText[j] = completeMethod.GetText();
                }

                //Debug.Log("State Hash: " + state.Id.ToUpper());
                Data.StateHashes.Add(new StateHash() { Id = state.Id.ToUpper(), Hash = state.GetHashCode() });
            }
        }

        public void ParseStateScenes()
        {
            Instance.Data.HotspotGUID = AssetDatabase.AssetPathToGUID("Assets/Muse/Core/Hotspots/Hotspot.cs");
            var thread = new System.Threading.Thread(new System.Threading.ThreadStart(RunParseStateScenes));
            thread.Start();
        }

        void RunParseStateScenes()
        {
            Data.ScenesFound.Clear();
            Data.HotspotsFoundInScenes.Clear();
            
            var newScenes = new List<HotspotSceneData>();
            var newHotspots = new List<HotspotSceneData>();

            var count = Data.States.Count;
            for (var i = 0; i < count; i++)
            {
                var state = Data.States[i];
                
                var files = Directory.GetFiles("Assets/", state.OriginalId + ".unity", SearchOption.AllDirectories);
                if (files.Length == 0)
                    continue;

                var path = files[0].Replace("\\", "/");
                

                if (newScenes.Find(x => x.StateId == state.OriginalId) == null)
                    newScenes.Add(new HotspotSceneData() { StateId = state.OriginalId, Path = path });

                var linesRaw = File.ReadAllLines(path);
                
                var linesParsed = new List<ParsedLine>();
                for (var j = 0; j < linesRaw.Length; j++)
                {
                    linesParsed.Add(new ParsedLine() { Text = linesRaw[j], LineIndex = j });
                }
                
                //  var lines = linesRaw.ToList().ConvertAll<ParsedLine>(x=>new ParsedLine() { Text=x,})
                var componentLines = linesParsed.FindAll(x => x.Text.Contains("guid: " + Instance.Data.HotspotGUID));
                
                for (var j = 0; j < componentLines.Count; j++)
                {
                    var compLine = componentLines[j];
                    var lineIndex = compLine.LineIndex;
                    var id = linesParsed[lineIndex + 3].Text.Replace("Id: ", "").Trim();
                    newHotspots.Add(new HotspotSceneData() { StateId = state.Id, HotspotId = id, Path = path });
                }
            }

            lock (Data.ScenesFound)
            {
                for (var i = 0; i < newScenes.Count; i++)
                    Data.ScenesFound.Add(newScenes[i]);
            }
            lock (Data.ScenesFound)
            {
                for (var i = 0; i < newHotspots.Count; i++)
                    Data.HotspotsFoundInScenes.Add(newHotspots[i]);
            }
        }

        void OnGUI()
        {//
         //Debug.Log("ongui");
            if (Data == null)
                Init();
            Data.Errors.Clear();
            Instance = this;
            Texture2D bg = Resources.Load<Texture2D>("EditorBackground");
            if (bg != null)
                GUI.DrawTextureWithTexCoords(new Rect(0, 0, Screen.width, Screen.height), bg, new Rect(0, 0, Screen.width / bg.width, Screen.height / bg.height));

            OnDrawMainArea();
            OnDrawTopBar();
        }

        private void OnDrawTopBar()
        {
            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));


            GUI.enabled = true; // TODO: hook this to determine if really dirty
            if (GUILayout.Button("Save All", EditorStyles.toolbarButton, GUILayout.Width(80)))
            {
                Save();
            }


            GUI.enabled = Data.MementoStack.UndoCount > 0;
            if (GUILayout.Button("Undo", EditorStyles.toolbarButton, GUILayout.Width(50)))
            {
                Data.MementoStack.Undo();
            }

            GUI.enabled = Data.MementoStack.RedoCount > 0;
            if (GUILayout.Button("Redo", EditorStyles.toolbarButton, GUILayout.Width(50)))
            {
                Data.MementoStack.Redo();
            }
            GUI.enabled = true;

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
            using (new GUILayout.AreaScope(new Rect(0, 100, Screen.width, Screen.height / 2)))
            {
                var states = Data.States;

                // cull any characters that are in a state that do not exist anymore
                for (var i = 0; i < states.Count; i++)
                {
                    var state = states[i];

                    state.Characters.RemoveAll(x => Data.Characters.Find(y => (y.name + " (" + y.Id + ")") == x) == null);
                }

                if (Data.FilterByTags.Count > 0)
                    states = states.FindAll(x =>
                    {
                        for (var i = 0; i < Data.FilterByTags.Count; i++)
                        {
                            if (!x.Tags.Contains(Data.FilterByTags[i]))
                                return false;
                        }
                        return true;
                    });

                if (Data.SelectedIndex > -1 && Data.SelectedIndex < Data.States.Count)
                {
                    var state = states[Data.SelectedIndex];

                    state.EditorPosition.y = height;
                    var name = state.Id;
                    if (state.Tags.Count > 0)
                        name += " (" + state.TagText + ")";

                    var stateHashData = Data.StateHashes.Find(x => x.Id == state.Id.ToUpper());
                    state.EditorPosition = GUILayout.Window(Data.SelectedIndex, new Rect(Screen.width - 690, state.EditorPosition.y - Pan.y, state.EditorPosition.width, state.EditorPosition.height), DrawState, stateHashData != null && stateHashData.Hash == state.GetHashCode() ? state.Id : "*" + state.Id);

                    height += state.EditorPosition.height + 50;
                }

            }
            
            var type = System.Type.GetType("ModuleIds, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
            bool modulesDefined = type != null && Enum.GetNames(type).Length > 0;
            for (var i = 0; i < Data.States.Count; i++)
            {
                var state = Data.States[i];
                if (string.IsNullOrEmpty(state.Id))
                {
                    Data.Errors.Add(new StateEditorErrors() { Message = "Assign a unique ID to the state.\n\nThis will be used for loading the state in game as well as linking the data to visuals for error-checking.", StateId = state.Id, Location = "Data" });
                }
                if (state.ModuleIds.Count == 0 && modulesDefined)
                {
                    Data.Errors.Add(new StateEditorErrors() { Message = "Assign a module ID to the state.\n\nAll states with the same module ID will have their assets loaded together.", StateId = state.Id, Location = "Data" });
                }

                for (var j = 0; j < state.Hotspots.Count; j++)
                {
                    var hotspot = state.Hotspots[j];
                    if (string.IsNullOrEmpty(hotspot.Id))
                    {
                        Data.Errors.Add(new StateEditorErrors() { Message = "Assign a unique ID to the hotspot.\n\nThis will be used for referencing the hotspot through Actions and generating the callback script name. A visual hotspot component with the same ID must exist within the corresponding unity scene.", StateId = state.Id, Location = "hotspots" });
                    }

                    var hotspotsNotFound = new List<string>();
                    var hotspotsNotDeclared = new List<string>();
                    var hotspotsFound = new List<string>();

                    var hotspotIds = state.Hotspots.ConvertAll<string>(x => x.Id);

                    var sceneHotspots = Data.HotspotsFoundInScenes.FindAll(x => x.StateId == state.Id).ConvertAll(x => x.HotspotId);
                    if (sceneHotspots == null)
                        hotspotsNotFound = hotspotIds;
                    else
                    {
                        hotspotsNotFound = hotspotIds.Except(sceneHotspots).ToList();
                        hotspotsNotDeclared = sceneHotspots.Except(hotspotIds).ToList();
                        hotspotsFound = hotspotIds.Except(hotspotsNotFound).Except(hotspotsNotDeclared).ToList();
                    }


                    if (hotspotsNotFound.Count > 0)
                    {
                        Data.Errors.Add(new StateEditorErrors() { Message = "Hotspots are declared in the state editor but not in the visual scene.", StateId = state.Id, Location = "Scene Visuals" });

                    }


                    if (hotspotsNotDeclared.Count > 0)
                    {
                        Data.Errors.Add(new StateEditorErrors() { Message = "Hotspots are declared in the visual scene but not in the state editor.", StateId = state.Id, Location = "Scene Visuals" });

                    }
                }

            }

            GUILayout.Window(1001, new Rect(50, 50, 615, Screen.height * 0.65f), DrawStateList, "State List");
            GUILayout.Window(1003, new Rect(50, Mathf.RoundToInt(50 + Screen.height * 0.65f + 25), 615, Screen.height - (50 + Screen.height * 0.65f + 25) - 50), DrawErrors, "Error Messages");

            using (new GUILayout.AreaScope(new Rect(Screen.width - 20, 18, Screen.width / 2, Screen.height)))
            {
                if (Pan.y + height > Screen.height)
                    Pan = new Vector2(0, Mathf.RoundToInt(GUILayout.VerticalScrollbar(Pan.y, 100, 0, height - (Screen.height - 300), GUILayout.Height(Screen.height - 36))));
            }

            if (FirstDraw)
            {
                FirstDraw = false;
                RefreshStates();
            }

            Repaint();
            EndWindows();
        }

        private void DrawState(int windowId)
        {
            var states = Data.States;
            if (Data.FilterByTags.Count > 0)
                states = states.FindAll(x =>
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

            var state = states[windowId];

            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
            {
                if (GUILayout.Button("File", EditorStyles.toolbarDropDown, GUILayout.Width(50)))
                {
                    GenericMenu fileMenu = new GenericMenu();

                    fileMenu.AddItem(new GUIContent("Reload State"), false, () =>
                    {
                        if (
                            !EditorUtility.DisplayDialog("Reload States?",
                                "Are you sure you want to reload this state's data? Any unsaved changes will be lost!", "Reload Data",
                                "Cancel"))
                            return;
                        Data.MementoStack.CreateMemento();
                        ReloadState(state.Id);
                    });
                    fileMenu.DropDown(new Rect(5, -5, 0, 30));
                    EditorGUIUtility.ExitGUI();
                }
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("-", EditorStyles.toolbarButton, GUILayout.Width(30)))
                {
                    Data.MementoStack.CreateMemento();
                    //Data.States.Remove(state);
                    state.Delete = true;
                    Data.SelectedIndex = -1;
                }
            }

            GUILayout.Space(25);



            Rect lastRect;

            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    state.EditorShowData = EditorGUILayout.Foldout(state.EditorShowData, "");
                    //EditorGUILayout.GetControlRect();
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(state.EditorPosition.width / 2 - 25, lastRect.y, state.EditorPosition.width, 18), "Data", EditorStyles.boldLabel);
            GUILayout.Space(1);

            if (state.EditorShowData)
            {
                EditorGUILayout.BeginHorizontal();

                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(5);

                    EditorGUILayout.BeginHorizontal();
                    InfoButton(new Vector2(400, 50), "The unique Id which will be used for loading the state in game as well as linking the data to visuals for error-checking.");

                    EditorGUILayout.LabelField("State Id: ", GUILayout.Width(150));
                    var rect = GUILayoutUtility.GetLastRect();
                    if (GUILayout.Button(state.Id, EditorStyles.toolbarButton, GUILayout.Width(350)))
                    {
                        StringEditorPopup window = new StringEditorPopup(state.Id, (id) => Data.States.Find(x => x.Id.ToLower() == id.ToLower()) == null, (id) =>
                        {
                            Data.MementoStack.CreateMemento();
                            state.Id = id;
                            Data.States.Sort((x, y) => x.Id.CompareTo(y.Id));
                            Data.StateHashes.Add(new StateHash() { Id = state.Id.ToUpper(), Hash = int.MinValue });
                            
                            Data.SelectedIndex = Data.States.IndexOf(state);
                            ParseStateScenes();
                        });
                        PopupWindow.Show(new Rect(rect.x + rect.width + 15, rect.y, rect.width, rect.height), window);
                    }
                    EditorGUILayout.EndHorizontal();
                    if (string.IsNullOrEmpty(state.Id))
                    {
                        EditorGUILayout.HelpBox("Assign a unique ID to the state.\n\nThis will be used for loading the state in game as well as linking the data to visuals for error-checking.", MessageType.Error);
                    }
                    GUILayout.Space(2);

                    // if the module system is being used ...

                    var type = System.Type.GetType("ModuleIds, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
                    if (type != null && Enum.GetNames(type).Length > 0)
                    {
                        var moduleNames = Enum.GetNames(type);

                        EditorGUILayout.BeginHorizontal();
                        InfoButton(new Vector2(400, 50), "All states with the same module ID will have their assets loaded together.");
                        EditorGUILayout.LabelField("Modules: ", GUILayout.Width(150));

                        EditorGUILayout.BeginVertical();
                        for (var i = 0; i < moduleNames.Length; i+=2)
                        {
                            var moduleName = moduleNames[i];
                            var moduleName2 = moduleNames.Length > i+1 ? moduleNames[i+1] : null;

                            using (new EditorGUILayout.HorizontalScope())
                            {
                                var isModuleSelected = EditorGUILayout.Toggle(state.ModuleIds.Contains(moduleName), GUILayout.Width(25));
                                if (isModuleSelected && !state.ModuleIds.Contains(moduleName))
                                {
                                    Data.MementoStack.CreateMemento();
                                    state.ModuleIds.Add(moduleName);
                                }
                                else if (!isModuleSelected && state.ModuleIds.Contains(moduleName))
                                {
                                    Data.MementoStack.CreateMemento();
                                    state.ModuleIds.Remove(moduleName);
                                }
                                EditorGUILayout.LabelField(moduleName, GUILayout.Width(150));

                                if (!string.IsNullOrEmpty(moduleName2))
                                {
                                    isModuleSelected = EditorGUILayout.Toggle(state.ModuleIds.Contains(moduleName2), GUILayout.Width(25));
                                    if (isModuleSelected && !state.ModuleIds.Contains(moduleName2))
                                    {
                                        Data.MementoStack.CreateMemento();
                                        state.ModuleIds.Add(moduleName2);
                                    }
                                    else if (!isModuleSelected && state.ModuleIds.Contains(moduleName2))
                                    {
                                        Data.MementoStack.CreateMemento();
                                        state.ModuleIds.Remove(moduleName2);
                                    }
                                    EditorGUILayout.LabelField(moduleName2, GUILayout.Width(150));
                                }
                            }
                        }
                        EditorGUILayout.EndVertical();

                        
                        EditorGUILayout.EndHorizontal();
                        if (state.ModuleIds.Count == 0 && type != null && Enum.GetNames(type).Length > 0)
                        {
                            EditorGUILayout.HelpBox("Assign a module ID to the state.\n\nAll states with the same module ID will have their assets loaded together.", MessageType.Error);
                        }
                        GUILayout.Space(2);
                    }

                    

                    EditorGUILayout.BeginHorizontal();
                    InfoButton(new Vector2(400, 50), "Loading this state triggers an autosave if true.");
                    EditorGUILayout.LabelField("Autosave:", GUILayout.Width(150));
                    {
                        var newAutoSave = EditorGUILayout.Toggle(state.AutoSave);
                        if (newAutoSave != state.AutoSave)
                            Data.MementoStack.CreateMemento();
                        state.AutoSave = newAutoSave;
                    }
                    EditorGUILayout.EndHorizontal();

                    // if any characters have been added to the game
                    if (Data.Characters.Count > 0)
                    {
                        EditorGUILayout.BeginHorizontal();
                        InfoButton(new Vector2(400, 50), "Select all characters that are potentially used at any point in any way within the state. This includes showing up in popups, or any other system which may have a character embedded in it ... not just hotspots.");
                        EditorGUILayout.LabelField("Characters: ", GUILayout.Width(150));

                        EditorGUILayout.BeginVertical();

                        for (var i = 0; i < Data.Characters.Count; i += 2)
                        {
                            var characterName = Data.Characters[i].name + " (" + Data.Characters[i].Id + ")";
                            var characterName2 = Data.Characters.Count > i + 1 ? Data.Characters[i + 1].name + " (" + Data.Characters[i+1].Id + ")" : null;

                            using (new EditorGUILayout.HorizontalScope())
                            {
                                var isCharacterSelected = EditorGUILayout.Toggle(state.Characters.Contains(characterName), GUILayout.Width(25));
                                if (isCharacterSelected && !state.Characters.Contains(characterName))
                                {
                                    Data.MementoStack.CreateMemento();
                                    state.Characters.Add(characterName);
                                }
                                else if (!isCharacterSelected && state.Characters.Contains(characterName))
                                {
                                    Data.MementoStack.CreateMemento();
                                    state.Characters.Remove(characterName);
                                }
                                EditorGUILayout.LabelField(characterName, GUILayout.Width(150));

                                if (!string.IsNullOrEmpty(characterName2))
                                {
                                    isCharacterSelected = EditorGUILayout.Toggle(state.Characters.Contains(characterName2), GUILayout.Width(25));
                                    if (isCharacterSelected && !state.Characters.Contains(characterName2))
                                    {
                                        Data.MementoStack.CreateMemento();
                                        state.Characters.Add(characterName2);
                                    }
                                    else if (!isCharacterSelected && state.Characters.Contains(characterName2))
                                    {
                                        Data.MementoStack.CreateMemento();
                                        state.Characters.Remove(characterName2);
                                    }
                                    EditorGUILayout.LabelField(characterName2, GUILayout.Width(150));
                                }
                                /*
                                var newModuleId = EditorGUILayout.TextField(state.ModuleId, GUILayout.Width(350));
                                if (state.ModuleId != newModuleId)
                                    Data.MementoStack.CreateMemento();
                                state.ModuleId = newModuleId;
                                */
                            }
                        }
                        EditorGUILayout.EndVertical();


                        EditorGUILayout.EndHorizontal();
                        GUILayout.Space(2);
                    }



                    GUILayout.Space(5);
                }
                EditorGUILayout.EndHorizontal();
            }


            GUILayout.Space(25);



            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(2);
                    EditorGUILayout.BeginHorizontal(GUILayout.Width(30));
                    state.EditorShowHotspots = EditorGUILayout.Foldout(state.EditorShowHotspots, "");
                    EditorGUILayout.EndHorizontal();
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(state.EditorPosition.width / 2 - 70, lastRect.y, state.EditorPosition.width, 18), "Hotspots", EditorStyles.boldLabel);
            GUILayout.Space(1);

            if (state.EditorShowHotspots)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(610), GUILayout.Height(25));
                GUILayout.Space(3);
                EditorGUILayout.BeginHorizontal();
                InfoButton(new Vector2(400, 75), "Create a new hotspot data object. The actual visual of the hotspot must be created in the associated Unity scene. This can be either a 2D sprite/collider or a UGUI button with a hotspot component attached to it. The scene can be created and/or found in the \"Scene Visuals\" box below.");
                if (GUILayout.Button("Create Hotspot", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    Data.MementoStack.CreateMemento();
                    state.Hotspots.Add(new HotspotEditorData());
                    state.OnHotspotClickText.Add("");
                    state.OnHotspotCompleteText.Add("");
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();


                for (var i = 0; i < state.Hotspots.Count; i++)
                {
                    EditorGUILayout.BeginHorizontal();
                    GUILayout.Space(25);
                    var hotspot = state.Hotspots[i];
                    var rect = GUILayoutUtility.GetLastRect();

                    using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                    {
                        GUILayout.Space(5);
                        EditorGUILayout.BeginHorizontal();
                        InfoButton(new Vector2(400, 50), "The unique ID which will be used for referencing the hotspot through Actions and generating the callback script name. No other hotspot within the state can have the same name.");
                        EditorGUILayout.LabelField("Hotspot Id:", GUILayout.Width(150));
                        {
                            var newHotspotId = EditorGUILayout.TextField(hotspot.Id, GUILayout.Width(250));
                            if (hotspot.Id != newHotspotId)
                                Data.MementoStack.CreateMemento();
                            hotspot.Id = newHotspotId;
                        }

                        GUILayout.FlexibleSpace();
                        if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                        {
                            Data.MementoStack.CreateMemento();
                            state.Hotspots.RemoveAt(i);
                            state.OnHotspotClickText.RemoveAt(i);
                            state.OnHotspotCompleteText.RemoveAt(i);
                            i--;
                        }
                        EditorGUILayout.EndHorizontal();
                        if (string.IsNullOrEmpty(hotspot.Id))
                        {
                            //  EditorGUILayout.HelpBox("Assign a unique ID to the hotspot.\n\nThis will be used for referencing the hotspot through Actions and generating the callback script name. A visual hotspot component with the same ID must exist within the corresponding unity scene.", MessageType.Error);
                        }

                        EditorGUILayout.BeginHorizontal();
                        InfoButton(new Vector2(400, 110), "Type controls what callbacks are available to the hotspot.\n\nButton: OnClick - triggered when the user clicks the visual component. Unless the visual hotspot is a UGUI button, the hotspot must have a collider attached to it.\n\nVideoPlayer: OnComplete - triggered when the video reaches the end or is skipped.");
                        EditorGUILayout.LabelField("Type:", GUILayout.Width(150));
                        {
                            var newHotspotSelectedType = (HotspotEditorData.HotspotTypes)EditorGUILayout.EnumPopup(hotspot.HotspotType, EditorStyles.toolbarDropDown, GUILayout.Width(250));
                            if (hotspot.HotspotType != newHotspotSelectedType)
                            {
                                Data.MementoStack.CreateMemento();
                            }
                            hotspot.HotspotType = newHotspotSelectedType;
                        }
                        EditorGUILayout.EndHorizontal();
                        GUILayout.Space(5);

                    }
                    EditorGUILayout.EndHorizontal();
                }
            }
            GUILayout.Space(25);


            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    state.EditorShowCallbacks = EditorGUILayout.Foldout(state.EditorShowCallbacks, "");
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(state.EditorPosition.width / 2 - 25, lastRect.y, state.EditorPosition.width, 18), "Callbacks", EditorStyles.boldLabel);
            GUILayout.Space(1);

            if (state.EditorShowCallbacks)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(5);


                    EditorGUILayout.BeginHorizontal();
                    InfoButton(new Vector2(400, 75), "This is triggered after the state is loaded but before the transition effect has exited.\n\nNOTE: The transition effect cannot end until after the script completes. Use blocking actions with caution!");
                    EditorGUILayout.LabelField("OnStateEnter: ", GUILayout.Width(150));
                    {
                        var newOnEnterText = EditorGUILayout.TextArea(state.OnEnterText, GUILayout.Width(370));
                        if (state.OnEnterText != newOnEnterText)
                            Data.MementoStack.CreateMemento();
                        state.OnEnterText = newOnEnterText;
                    }
                    EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                    EditorGUILayout.EndHorizontal();
                    if (!string.IsNullOrEmpty(state.OnEnterText) && state.OnEnterText.ToLower().Contains("blocking"))
                    {
                        EditorGUILayout.HelpBox("The transition effect cannot end until after the script completes. Although allowed, use blocking actions with caution!", MessageType.Warning);
                    }
                    var onEnterError = _errorTags.Find(x => x[0] == state.Id && x[1] == "OnEnterCallback");
                    if (onEnterError != null)
                    {
                        EditorGUILayout.HelpBox(onEnterError[3].Trim(), MessageType.Error);
                    }
                    GUILayout.Space(2);

                    EditorGUILayout.BeginHorizontal();
                    InfoButton(new Vector2(400, 50), "This is triggered after the state is loaded and the transition effect has exited.");
                    EditorGUILayout.LabelField("OnStateShow: ", GUILayout.Width(150));
                    {
                        var newOnStateShow = EditorGUILayout.TextArea(state.OnShowText, GUILayout.Width(370));
                        if (state.OnShowText != newOnStateShow)
                            Data.MementoStack.CreateMemento();
                        state.OnShowText = newOnStateShow;
                    }
                    EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                    EditorGUILayout.EndHorizontal();
                    var onShowError = _errorTags.Find(x => x[0] == state.Id && x[1] == "OnShowCallback");
                    if (onShowError != null)
                    {
                        EditorGUILayout.HelpBox(onShowError[3].Trim(), MessageType.Error);
                    }
                    GUILayout.Space(2);

                    EditorGUILayout.BeginHorizontal();
                    InfoButton(new Vector2(400, 75), "This is triggered after the state before the state unloads but after the transition effect has begun.\n\nNOTE: The transition effect cannot end until after the script completes. Use blocking actions with caution!");
                    EditorGUILayout.LabelField("OnStateExit: ", GUILayout.Width(150));
                    {
                        var newOnExitText = EditorGUILayout.TextArea(state.OnExitText, GUILayout.Width(370));
                        if (state.OnExitText != newOnExitText)
                            Data.MementoStack.CreateMemento();
                        state.OnExitText = newOnExitText;
                    }
                    EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                    EditorGUILayout.EndHorizontal();
                    if (!string.IsNullOrEmpty(state.OnExitText) && state.OnExitText.ToLower().Contains("blocking"))
                    {
                        EditorGUILayout.HelpBox("The transition effect cannot end until after the script completes. Although allowed, use blocking actions with caution!", MessageType.Warning);
                    }
                    var onExitError = _errorTags.Find(x => x[0] == state.Id && x[1] == "OnExitCallback");
                    if (onExitError != null)
                    {
                        EditorGUILayout.HelpBox(onExitError[3].Trim(), MessageType.Error);
                    }
                    GUILayout.Space(2);//

                    for (var i = 0; i < state.Hotspots.Count; i++)
                    {
                        var hotspot = state.Hotspots[i];
                        var hotspotId = hotspot.Id;

                        if (string.IsNullOrEmpty(hotspotId))
                            continue;

                        if (hotspot.HotspotType == HotspotEditorData.HotspotTypes.Button)
                        {
                            EditorGUILayout.BeginHorizontal();
                            InfoButton(new Vector2(400, 50), "This is triggered by clicking (or tapping) the visual hotspot. Unless the hotspot is a UGUI button, the hotspot must have a collider attached to it.");
                            EditorGUILayout.LabelField("On" + hotspotId + "Click: ", GUILayout.Width(150));
                            {
                                var newOnHotspotClickText = EditorGUILayout.TextArea(state.OnHotspotClickText[i], GUILayout.Width(370));
                                if (state.OnHotspotClickText[i] != newOnHotspotClickText)
                                    Data.MementoStack.CreateMemento();
                                state.OnHotspotClickText[i] = newOnHotspotClickText;
                            }
                            EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                            EditorGUILayout.EndHorizontal();
                            var onHotspotClickError = _errorTags.Find(x => x[0] == state.Id && x[1] == "On" + hotspot.Id + "ClickCallback");
                            if (onHotspotClickError != null)
                            {
                                EditorGUILayout.HelpBox(onHotspotClickError[3].Trim(), MessageType.Error);
                            }
                            GUILayout.Space(2);
                        }
                        else if (hotspot.HotspotType == HotspotEditorData.HotspotTypes.VideoPlayer)
                        {
                            EditorGUILayout.BeginHorizontal();
                            InfoButton(new Vector2(400, 50), "This is triggered when the video reaches the end or is skipped.");
                            EditorGUILayout.LabelField("On" + hotspotId + "Complete: ", GUILayout.Width(150));
                            {
                                var newOnHotspotCompleteText = EditorGUILayout.TextArea(state.OnHotspotCompleteText[i], GUILayout.Width(370));
                                if (state.OnHotspotCompleteText[i] != newOnHotspotCompleteText)
                                    Data.MementoStack.CreateMemento();
                                state.OnHotspotCompleteText[i] = newOnHotspotCompleteText;
                            }
                            EditorGUILayout.LabelField("C#", GUILayout.Width(30));
                            EditorGUILayout.EndHorizontal();
                            var onHotspotCompleteError = _errorTags.Find(x => x[0] == state.Id && x[1] == "On" + hotspot.Id + "CompleteCallback");
                            if (onHotspotCompleteError != null)
                            {
                                EditorGUILayout.HelpBox(onHotspotCompleteError[3].Trim(), MessageType.Error);
                            }
                            GUILayout.Space(2);
                        }
                    }

                    GUILayout.Space(5);
                }
                EditorGUILayout.EndHorizontal();
            }


            GUILayout.Space(25);


            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);
                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    state.EditorShowVisuals = EditorGUILayout.Foldout(state.EditorShowVisuals, "");
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(state.EditorPosition.width / 2 - 70, lastRect.y, state.EditorPosition.width, 18), "Scene Visuals", EditorStyles.boldLabel);
            GUILayout.Space(1);


            if (state.EditorShowVisuals)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(5);

                    if (string.IsNullOrEmpty(state.Id))
                    {
                        EditorGUILayout.HelpBox("A valid ID must be assigned to the state before it can link to a visual scene.", MessageType.Error);
                    }
                    else
                    {
                        var sceneHotspots = Data.HotspotsFoundInScenes.FindAll(x => x.StateId == state.OriginalId).ConvertAll(x => x.HotspotId);
                        var stateData = Data.ScenesFound.Find(x => x.StateId == state.OriginalId);
                        if (stateData != null)
                        {
                            EditorGUILayout.BeginHorizontal();
                            InfoButton(new Vector2(400, 50), "Open the unity scene which contains the visual elements.", new Vector2(150, 0));
                            EditorGUILayout.LabelField("Scene:", GUILayout.Width(150));
                            EditorGUILayout.LabelField(stateData.Path);
                            EditorGUILayout.EndHorizontal();


                            var hotspotsNotFound = new List<string>();
                            var hotspotsNotDeclared = new List<string>();
                            var hotspotsFound = new List<string>();

                            var hotspotIds = state.Hotspots.ConvertAll<string>(x => x.Id);

                            if (sceneHotspots == null)
                                hotspotsNotFound = hotspotIds;
                            else
                            {
                                hotspotsNotFound = hotspotIds.Except(sceneHotspots).ToList();
                                hotspotsNotDeclared = sceneHotspots.Except(hotspotIds).ToList();
                                hotspotsFound = hotspotIds.Except(hotspotsNotFound).Except(hotspotsNotDeclared).ToList();
                            }

                            EditorGUILayout.BeginHorizontal();
                            InfoButton(new Vector2(400, 75), "The following checks each hotspot to make sure it has been declared both in the state and in Unity scene with a visual element. Each hotspot can be incomplete (only-in-state or only-in-visual-scene) or complete (in-state and in-visual-scene).");
                            EditorGUILayout.LabelField("Hotspots:", GUILayout.Width(150));
                            using (new EditorGUILayout.VerticalScope())
                            {
                                if (hotspotsFound.Count > 0)
                                {
                                    EditorGUILayout.HelpBox("The following hotspots have been linked successfully between the editor and the visual scene.", MessageType.Info);

                                    for (var i = 0; i < hotspotsFound.Count; i++)
                                    {
                                        EditorGUILayout.LabelField(hotspotsFound[i], GUILayout.Width(150));
                                    }
                                }

                                if (hotspotsNotFound.Count > 0)
                                {
                                    EditorGUILayout.HelpBox("The following hotspots are declared in the state editor but not in the visual scene.\n\nGenerate a visual hotspot by using the buttons below. The type of hotspot is determined by the hotspot type defined by the hotspot data above.", MessageType.Error);

                                    for (var i = 0; i < hotspotsNotFound.Count; i++)
                                    {
                                        EditorGUILayout.BeginHorizontal();
                                        if (GUILayout.Button(hotspotsNotFound[i], EditorStyles.toolbarButton) && EditorUtility.DisplayDialog("Create Hotspot?", "Are you sure you want to generate a new hotspot for id \"" + hotspotsNotFound[i] + "\"? Affecting a visual scene through the StateEditor cannot be undone.", "Continue", "Cancel"))
                                        {
                                            var hotspot = state.Hotspots.Find(x => x.Id == hotspotsNotFound[i]);
                                            GameObject go = null;
                                            switch (hotspot.HotspotType)
                                            {
                                                case HotspotEditorData.HotspotTypes.Animator:
                                                    go = Hotspot.CreateHotspotSprite();
                                                    break;
                                                case HotspotEditorData.HotspotTypes.Button:
                                                    go = Hotspot.CreateHotspotSprite();
                                                    break;
                                                case HotspotEditorData.HotspotTypes.VideoPlayer:
                                                    go = Hotspot.CreateHotspotVideoPlayer();
                                                    break;
                                            }
                                            go.name = go.GetComponent<Hotspot>().Id = hotspot.Id;
                                            UnityEditor.SceneManagement.EditorSceneManager.SaveScene(UnityEditor.SceneManagement.EditorSceneManager.GetSceneByPath(stateData.Path));
                                        }
                                        //EditorGUILayout.LabelField(hotspotsNotFound[i], GUILayout.Width(25));
                                        EditorGUILayout.EndHorizontal();
                                    }
                                }


                                if (hotspotsNotDeclared.Count > 0)
                                {
                                    EditorGUILayout.HelpBox("The following hotspots are declared in the visual scene but not in the state editor.", MessageType.Error);
                                    for (var i = 0; i < hotspotsNotDeclared.Count; i++)
                                    {
                                        EditorGUILayout.LabelField(hotspotsNotDeclared[i], GUILayout.Width(150));
                                    }
                                }


                            }
                            EditorGUILayout.EndHorizontal();
                        }
                        else
                        {
                            EditorGUILayout.HelpBox("A visual scene will automatically be created for this state when it is saved.", MessageType.Info);
                        }



                        GUILayout.Space(5);
                    }
                }
                EditorGUILayout.EndHorizontal();
            }




            GUILayout.Space(25);

            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);

                var rect = GUILayoutUtility.GetLastRect();
                rect.x += 30;
                rect.y += 20;
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(2);
                    EditorGUILayout.BeginHorizontal(GUILayout.Width(30));
                    state.EditorShowTags = EditorGUILayout.Foldout(state.EditorShowTags, "");
                    EditorGUILayout.EndHorizontal();
                }
            }
            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(state.EditorPosition.width / 2 - 25, lastRect.y, state.EditorPosition.width, 18), "Tags", EditorStyles.boldLabel);
            GUILayout.Space(1);



            if (state.EditorShowTags)
            {

                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(610), GUILayout.Height(25));
                GUILayout.Space(3);
                EditorGUILayout.BeginHorizontal();
                InfoButton(new Vector2(400, 50), "Tags are used to filter states in the state list to the left of the editor. It can also be used at run-time as needed.");
                if (GUILayout.Button("Create Tag", EditorStyles.toolbarButton, GUILayout.Width(75)))
                {
                    Data.MementoStack.CreateMemento();
                    state.Tags.Add("tag");
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();


                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(5);

                    for (var i = 0; i < state.Tags.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            EditorGUILayout.BeginHorizontal();
                            GUILayout.Space(40);
                        }
                        var rect = GUILayoutUtility.GetLastRect();
                        EditorGUILayout.BeginHorizontal();
                        if (GUILayout.Button(state.Tags[i], EditorStyles.toolbarButton, GUILayout.Width(200)))
                        {
                            StringEditorPopup window = new StringEditorPopup(state.Tags[i], (id) => state.Tags.Find(x => x.ToLower() == id.ToLower()) == null, (id) =>
                            {
                                Data.MementoStack.CreateMemento();
                                state.Tags[i] = id;
                            });
                            PopupWindow.Show(new Rect(rect.x, rect.y + 21, rect.width, rect.height), window);
                        }
                        if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                        {
                            Data.MementoStack.CreateMemento();
                            state.Tags.RemoveAt(i);
                            i--;
                        }
                        EditorGUILayout.EndHorizontal();
                        GUILayout.Space(2);

                        if (i % 2 == 1 || i == state.Tags.Count - 1)
                        {
                            EditorGUILayout.EndHorizontal();
                            GUILayout.Space(2);
                        }
                    }

                    //EditorGUILayout.LabelField(state.TagText);
                    GUILayout.Space(5);
                }
                EditorGUILayout.EndHorizontal();
            }



            GUILayout.Space(25);

            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(25);

                var rect = GUILayoutUtility.GetLastRect();
                rect.x += 30;
                rect.y += 20;
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(2);
                    EditorGUILayout.BeginHorizontal(GUILayout.Width(30));
                    state.EditorShowAudio = EditorGUILayout.Foldout(state.EditorShowAudio, "");
                    EditorGUILayout.EndHorizontal();
                }
            }

            lastRect = GUILayoutUtility.GetLastRect();
            GUI.Label(new Rect(state.EditorPosition.width / 2 - 25, lastRect.y, state.EditorPosition.width, 18), "Audio Triggers", EditorStyles.boldLabel);
            GUILayout.Space(1);

            if (state.EditorShowAudio)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(610), GUILayout.Height(25));
                GUILayout.Space(3);
                EditorGUILayout.BeginHorizontal();
                InfoButton(new Vector2(400, 60), "Define the audio triggers which are called by a script in this state. Each audio trigger has an actual sound assigned to it in the AudioTrigger editor. This is layer of abstraction allows all sounds in game to be changed in a single place.");
                if (GUILayout.Button("Create Audio Trigger", EditorStyles.toolbarButton, GUILayout.Width(125)))
                {
                    Data.MementoStack.CreateMemento();
                    state.SoundTriggers.Add("");
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(25);
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(5);

                    for (var i = 0; i < state.SoundTriggers.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            EditorGUILayout.BeginHorizontal();
                            GUILayout.Space(40);
                        }
                        var rect = GUILayoutUtility.GetLastRect();
                        EditorGUILayout.BeginHorizontal();
                        if (GUILayout.Button(state.SoundTriggers[i], EditorStyles.toolbarButton, GUILayout.Width(200)))
                        {
                            StringEditorPopup window = new StringEditorPopup(state.SoundTriggers[i], (id) => state.SoundTriggers.Find(x => x.ToLower() == id.ToLower()) == null, (id) =>
                            {
                                Data.MementoStack.CreateMemento();
                                state.SoundTriggers[i] = id;
                            });
                            PopupWindow.Show(new Rect(rect.x, rect.y + 21, rect.width, rect.height), window);
                        }
                        if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                        {
                            Data.MementoStack.CreateMemento();
                            state.SoundTriggers.RemoveAt(i);
                            i--;
                        }
                        EditorGUILayout.EndHorizontal();
                        GUILayout.Space(2);

                        if (i % 2 == 1 || i == state.SoundTriggers.Count - 1)
                        {
                            EditorGUILayout.EndHorizontal();
                            GUILayout.Space(2);
                        }
                    }

                    //EditorGUILayout.LabelField(state.TagText);
                    GUILayout.Space(5);
                }
                EditorGUILayout.EndHorizontal();
            }


            GUILayout.Space(50);
        }

        private void RefreshStates()
        {
            for (var i = 0; i < Data.States.Count; i++)
            {
                RefreshState(Data.States[i]);
            }
        }

        private void RefreshState(StateEditorData state)
        {
            var pos = state.EditorPosition;
            pos.width = 650;
            pos.height = 150;
            state.EditorPosition = pos;
        }

        private Vector2 _errorPos;
        void DrawErrors(int id)
        {
            Data.StatesWithErrors.Clear();
            var wordwrap = EditorStyles.label.wordWrap;
            EditorStyles.label.wordWrap = true;
            // Debug.Log("errortags: " + _errorTags.Count);
            _errorPos = EditorGUILayout.BeginScrollView(_errorPos);
            for (var i = 0; i < _errorTags.Count; i++)
            {
                var tags = _errorTags[i];

                var stateId = tags[0];


                if (!Data.StatesWithErrors.Contains(stateId))
                    Data.StatesWithErrors.Add(stateId);

                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(590));
                GUILayout.Space(5);
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Location: " + tags[0] + " -> " + tags[1]);
                GUILayout.FlexibleSpace();
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.LabelField(tags[3].Trim(), GUILayout.Width(350));
                GUILayout.Space(5);
                EditorGUILayout.EndVertical();
                //EditorGUILayout.LabelField("----------------------------");
            }

            /*
            // match hotspots in scenes to states
            for (var i = 0; i < Data.States.Count; i++)
            {
                var state = Data.States[i];
                var sceneHotspots = Data.HotspotsFoundInScenes.FindAll(x => x.StateId == state.Id).ConvertAll(x=>x.HotspotId);
                var hotspotsNotFound = new List<string>();
                var hotspotsNotDeclared = new List<string>();

                var hotspotIds = state.Hotspots.ConvertAll<string>(x => x.Id);

                if (sceneHotspots == null)
                    hotspotsNotFound = hotspotIds;
                else
                {
                    hotspotsNotFound = hotspotIds.Except(sceneHotspots).ToList();
                    hotspotsNotDeclared = sceneHotspots.Except(hotspotIds).ToList();
                }

                for (var j = 0; j < hotspotsNotFound.Count; j++)
                {
                    EditorGUILayout.LabelField("Location: " + state.Id + "-> hotspots");
                    EditorGUILayout.LabelField("Error: Hotspot \"" + hotspotsNotFound[j] + "\" is declared in the state but not connected to a hotspot component in the associated scene!", GUILayout.Width(350));
                    if (GUILayout.Button("Go", GUILayout.Width(40)))
                    {
                        Pan = new Vector2(0, Mathf.RoundToInt(Data.States.Find(x => x.Id == state.Id).EditorPosition.y + Pan.y - 200));
                    }
                    EditorGUILayout.LabelField("----------------------------");
                }

                for (var j = 0; j < hotspotsNotDeclared.Count; j++)
                {
                    EditorGUILayout.LabelField("Location: " + state.Id + "-> hotspots");
                    EditorGUILayout.LabelField("Error: Hotspot \"" + hotspotsNotDeclared[j] + "\" is connected to a hotspot component in the associated scene but not declared in the state!", GUILayout.Width(350));
                    if (GUILayout.Button("Go", GUILayout.Width(40)))
                    {
                        Pan = new Vector2(0, Mathf.RoundToInt(Data.States.Find(x => x.Id == state.Id).EditorPosition.y + Pan.y - 200));
                    }
                    EditorGUILayout.LabelField("----------------------------");
                }
            }
            */

            for (var i = 0; i < Data.Errors.Count; i++)
            {
                var error = Data.Errors[i];
                if (!Data.StatesWithErrors.Contains(error.StateId))
                    Data.StatesWithErrors.Add(error.StateId);

                EditorGUILayout.BeginVertical(EditorStyles.toolbar, GUILayout.Width(590));
                GUILayout.Space(5);
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Location: " + error.StateId + " -> " + error.Location);
                GUILayout.FlexibleSpace();
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.LabelField(error.Message, GUILayout.Width(350));
                GUILayout.Space(5);
                EditorGUILayout.EndVertical();
                //EditorGUILayout.LabelField("----------------------------");
            }

            EditorGUILayout.EndScrollView();

            EditorStyles.label.wordWrap = wordwrap;
        }

        private Vector2 _questListPosition;
        void DrawStateList(int windowId)
        {
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                EditorGUILayout.BeginHorizontal();
                InfoButton(new Vector2(400, 50), "Filter the state list to only show states with the specified tags.");
                if (GUILayout.Button("Filter By Tags", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    TagEditorPopup window = new TagEditorPopup(Data.FilterByTags, (tags) => true, (tags) =>
                    {
                        Data.MementoStack.CreateMemento();
                        Data.FilterByTags = tags;
                        Data.SelectedIndex = -1;
                    });
                    PopupWindow.Show(new Rect(200, 21, 100, 18), window);
                }
                EditorGUILayout.LabelField(Data.FilterByTags.Count > 0 ? Data.FilterByTags.Aggregate((next, line) => next += ", " + line) : "");
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                InfoButton(new Vector2(400, 50), "If selected, will automatically open the state's corresponding visual scene when the state is selected.");
                GUI.backgroundColor = Data.AutomaticallyOpenVisualScenes ? Color.yellow : Color.white;
                if (GUILayout.Button("Automatically Open Visual Scene", EditorStyles.toolbarButton, GUILayout.Width(200)))
                {
                    Data.AutomaticallyOpenVisualScenes = !Data.AutomaticallyOpenVisualScenes;
                }
                GUI.backgroundColor = Color.white;
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                InfoButton(new Vector2(400, 50), "Creates a new state. This will still need a corresponding Unity scene which can be created from the Visual Scenes box in the state window.");
                if (GUILayout.Button("Create State", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    var state = new StateEditorData();

                    var stateId = "";
                    var id = 0;
                    do
                    {
                        stateId = "untitled_" + ++id;
                    } while (Data.States.Find(x => x.Id.ToLower() == stateId) != null);

                    state.Id = stateId;

                    Data.States.Add(state);
                    Data.States.Sort((x, y) => x.Id.CompareTo(y.Id));
                    Data.SelectedIndex = Data.States.IndexOf(state);
                }
                EditorGUILayout.EndHorizontal();
            }
            _questListPosition = EditorGUILayout.BeginScrollView(_questListPosition, GUIStyle.none, GUI.skin.verticalScrollbar);
            var states = Data.States;

            if (Data.FilterByTags.Count > 0)
                states = states.FindAll(x =>
                {
                    for (var i = 0; i < Data.FilterByTags.Count; i++)
                    {
                        if (!x.Tags.Contains(Data.FilterByTags[i]))
                            return false;
                    }
                    return true;
                });


            states.Sort((x, y) =>
            {
                return x.Id.CompareTo(y.Id);
            });

            // GUILayout.Space(18);
            GUI.backgroundColor = Color.clear;
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(610)))
            {
                GUI.backgroundColor = Color.white;
                InfoButton(new Vector2(400, 80), "Per State:\nClick on the \"State Id\" column to edit the ID.\nClick on the \"GO\" column to jump to the corresponding state window.\nClick on the \"Starting State\" column to make it the starting state.\nClick on the \"Tags\" column to edit the state's tags.\nClick on the \"X\" button to delete the state.", new Vector2(0, 18));
                GUI.backgroundColor = Color.clear;
                if (GUILayout.Button("State Id", EditorStyles.toolbarButton, GUILayout.Width(200)))
                {
                }

                if (GUILayout.Button("Go", EditorStyles.toolbarButton, GUILayout.Width(40)))
                {
                }

                if (GUILayout.Button("Is Starting State", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                }

                if (GUILayout.Button("Tags", EditorStyles.toolbarButton))
                {
                }
                GUILayout.Space(30);
            }
            GUI.backgroundColor = Color.white;

            for (var i = 0; i < states.Count; i++)
            {
                var state = states[i];


                var index = Data.States.IndexOf(Data.States.Find(x => x.Id == state.Id));

                if (index == Data.SelectedIndex)
                    GUI.backgroundColor = Color.cyan;
                else
                    GUI.backgroundColor = Color.white;

                if (state.Delete)
                    GUI.backgroundColor = Color.red;

                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(610)))
                {
                    GUILayout.Space(25);


                    var cid = GUIUtility.GetControlID(FocusType.Passive);
                    var rect = GUILayoutUtility.GetLastRect();
                    if (rect.x != 0 && rect.y != 0)
                    {
                        if (!_infoButtonRects.ContainsKey(cid))
                            _infoButtonRects.Add(cid, rect);
                        else
                            _infoButtonRects[cid] = rect;
                    }
                    else if (_infoButtonRects.ContainsKey(cid))
                        rect = _infoButtonRects[cid];
                    rect.y += 18;


                    var stateHashData = Data.StateHashes.Find(x => x.Id == state.Id.ToUpper());
                    var isDirty = stateHashData == null || stateHashData.Hash != state.GetHashCode();

                    //GUI.DrawTextureWithTexCoords(new Rect(0, 0, 128, 128), Data.ErrorImage, new Rect(0, 0, 64, 64));

                    var style = EditorStyles.toolbarButton;
                    if (isDirty)
                    {
                        style.fontStyle = FontStyle.Bold;
                    }
                    else
                        style.fontStyle = FontStyle.Normal;

                    //Debug.Log(state.Id + ": " + Data.StateHashes.Find(x => x.Id == state.Id.ToUpper()).Hash + " " + state.GetHashCode());
                    var showButton = GUILayout.Button(isDirty ? "*" + state.Id : state.Id, style, GUILayout.Width(200));
                    style.fontStyle = FontStyle.Normal;

                    if (showButton)
                    {
                        if (!state.Delete)
                        {
                            StringEditorPopup window = new StringEditorPopup(state.Id, (id) => Data.States.Find(x => x.Id.ToLower() == id.ToLower()) == null, (id) =>
                            {
                                Data.MementoStack.CreateMemento();
                                state.Id = id;
                                Data.States.Sort((x, y) => x.Id.CompareTo(y.Id));
                                Data.StateHashes.Add(new StateHash() { Id = state.Id.ToUpper(), Hash = int.MinValue });
                                Data.SelectedIndex = Data.States.IndexOf(state);
                                ParseStateScenes();
                            });
                            PopupWindow.Show(rect, window);
                        }
                    }
                    if (Data.SelectedIndex == index)
                    {
                        if (GUILayout.Button("<-", EditorStyles.toolbarButton, GUILayout.Width(40)))
                        {
                            Data.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        if (GUILayout.Button(!state.Delete ? "->" : "", EditorStyles.toolbarButton, GUILayout.Width(40)))
                        {
                            if (!state.Delete)
                            {
                                Data.SelectedIndex = index;
                                Pan.y = 0;

                                if (Data.AutomaticallyOpenVisualScenes)
                                {
                                    var stateData = Data.ScenesFound.Find(x => x.StateId == state.OriginalId);
                                    if (stateData != null)
                                    {
                                        UnityEditor.SceneManagement.EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
                                        UnityEditor.SceneManagement.EditorSceneManager.OpenScene(stateData.Path);
                                    }
                                }
                            }
                        }
                    }


                    if (GUILayout.Button(Data.StartingState == state.Id ? "Yes" : "", EditorStyles.toolbarButton, GUILayout.Width(100)))
                    {
                        Data.MementoStack.CreateMemento();
                        Data.StartingState = state.Id;
                    }

                    cid = GUIUtility.GetControlID(FocusType.Passive);
                    showButton = GUILayout.Button(state.TagText, EditorStyles.toolbarButton);
                    rect = GUILayoutUtility.GetLastRect();
                    if (rect.x != 0 && rect.y != 0)
                    {
                        if (!_infoButtonRects.ContainsKey(cid))
                            _infoButtonRects.Add(cid, rect);
                        else
                            _infoButtonRects[cid] = rect;
                    }
                    else if (_infoButtonRects.ContainsKey(cid))
                        rect = _infoButtonRects[cid];

                    if (showButton)
                    {
                        if (!state.Delete)
                        {
                            TagEditorPopup window = new TagEditorPopup(state.Tags, (tags) => true, (tags) =>
                            {
                                Data.MementoStack.CreateMemento();
                                state.Tags = tags;
                            });
                            PopupWindow.Show(rect, window);
                        }
                    }
                    if (GUILayout.Button(!state.Delete ? "-" : "+", EditorStyles.toolbarButton, GUILayout.Width(20)))
                    {
                        if (!state.Delete)
                        {
                            Data.MementoStack.CreateMemento();
                            state.Delete = true;
                            //Data.States.Remove(state);
                            Data.SelectedIndex = -1;
                        }
                        else
                        {
                            Data.MementoStack.CreateMemento();
                            state.Delete = false;
                        }

                    }
                    GUILayout.Space(10);
                }
                GUI.backgroundColor = Color.white;

                if (Data.StatesWithErrors.Contains(state.Id))
                    GUI.DrawTexture(new Rect(7, i * 18 + 18, 18, 18), Data.ErrorImage);
            }
            EditorGUILayout.EndScrollView();

            var originalHash = Data.StateHashes.Count == 0 ? 0 : Utils.CombineHash(Data.StateHashes.Count, Data.StateHashes.ConvertAll<int>(x => x.Hash).Aggregate((x, next) => Utils.CombineHash(x, next)));
            var currentHash = states.Count == 0 ? 0 : Utils.CombineHash(states.Count, states.ConvertAll<int>(x => x.GetHashCode()).Aggregate((x, next) => Utils.CombineHash(x, next)));

            //Debug.Log(currentHash + ", " + originalHash);
            titleContent = new GUIContent(currentHash != originalHash ? "*States" : "States");
        }

        static void OnUpdate()
        {
            if (!Application.isPlaying && EditorWindow.focusedWindow == Instance)
                RefreshErrors();
        }

        static void RefreshErrors()
        {//
            return;
         // Debug.Log("refresh errors");
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetAssembly(typeof(UnityEditor.SceneView));
            Type logEntries = assembly.GetType("UnityEditorInternal.LogEntries");
            Type logEntry = assembly.GetType("UnityEditorInternal.LogEntry");

            var numEntries = (int)logEntries.GetMethod("GetCount").Invoke(new object[] { }, null);

            //Debug.Log("woohoo");
            // Debug.Log("num entries: " + numEntries);

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
                int indexOf = file.IndexOf("state_");
                bool IsState = indexOf > -1;
                //Debug.Log("row " + i + " has entry: " + hasEntry);

                if (isError && IsState)
                {
                    var stateId = file.Substring(indexOf + 6, file.Length - (indexOf + 6));
                    stateId = stateId.Substring(0, stateId.IndexOf("."));
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
                        var tags = errorTag.Split(' ');
                        switch (tags[0])
                        {
                            case "METHOD":
                            case "METHOD_BODY_START":
                            case "METHOD_BODY_END":
                                _errorTags.Add(new List<string>() { stateId, tags[1], "", message });
                                break;
                        }



                        // Debug.Log(tags[0] + ", " + tags[1] + ", " + tags[2]);
                        break;
                    }

                    //Debug.Log("error: " + message);
                }
            }
            logEntries.GetMethod("EndGettingEntries").Invoke(null, new object[] { });
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

        class ParsedLine
        {
            public string Text;
            public int LineIndex;
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


    public class StateModificationProcessor : UnityEditor.AssetModificationProcessor
    {
        public static string[] OnWillSaveAssets(string[] paths)
        {
            bool isStateSaved = false;

            foreach (string path in paths)
            {
                if (path.Contains(".unity"))
                {
                    isStateSaved = true;
                }
            }

            if (isStateSaved)
                StateEditor.Instance.ParseStateScenes();

            return paths;
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