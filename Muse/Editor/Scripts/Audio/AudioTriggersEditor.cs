using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using UnityEngine.Audio;
using System.Linq;
using UnityEditor.Callbacks;

namespace Muse.Editors.Audio
{

    [Serializable]
    public class AudioTriggersEditorMementoStack
    {
        [SerializeField]
        private List<AudioTriggersEditorMemento> _undo = new List<AudioTriggersEditorMemento>();
        [SerializeField]
        private List<AudioTriggersEditorMemento> _redo = new List<AudioTriggersEditorMemento>();

        public Action<AudioTriggersEditorMemento> Restore = (T) => { Debug.Log("default Restore"); };
        public Func<AudioTriggersEditorMemento> GetMementoData = () => { Debug.Log("default getmementodata"); return null; };
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
    public class AudioTriggersEditorMemento
    {
        public List<AudioTriggerEditorEntry> Data = new List<AudioTriggerEditorEntry>();
    }

    public class AudioTriggerEditorData : ScriptableObject
    {
        public List<AudioTriggerEditorEntry> AudioTriggerEntries = new List<AudioTriggerEditorEntry>();
        public AudioTriggersEditorMementoStack MementoStack = new AudioTriggersEditorMementoStack();
        public List<AudioTriggerAttribute> AudioTriggers = new List<AudioTriggerAttribute>();
        public AudioTriggerEditorData()
        {
        }

    }

    [System.Serializable]
    public class AudioTriggerEditorEntry
    {
        public string Id;
        public List<string> AudioIds = new List<string>();

        public AudioTriggerEditorEntry Clone()
        {
            var clone = new AudioTriggerEditorEntry();
            clone.Id = Id;
            clone.AudioIds = AudioIds.ToList();
            return clone;
        }
    }

    public class AudioTriggersEditor : EditorWindow
    {
        public static AudioTriggersEditor Instance { get; private set; }

        public const string AUDIO_PATH = "Assets/Muse/Game/Data/Audio/";
        public const string AUDIO_RESOURCES_PATH = "Assets/Muse/Editor/Resources";

        public AudioTriggerEditorData Data;


        [SerializeField]
        private Vector2 _scrollPosition;

        //[MenuItem("Muse/Editors/Audio Triggers")]
        static void Init()
        {
            var window = EditorWindow.GetWindow<AudioTriggersEditor>();
            window.titleContent = new GUIContent("Audio Triggers");
            window.Show();

            Instance = window;
            window.Data = ScriptableObject.CreateInstance<AudioTriggerEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "AudioTriggersEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            
            window.Reload();
            OnSetupMementoStack();
            OnSetupAudioTriggers();
        }

        [DidReloadScripts]
        static void OnReloadScripts()
        {
            var windows = Resources.FindObjectsOfTypeAll<AudioTriggersEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];

            OnSetupMementoStack();
            OnSetupAudioTriggers();
        }

        static void OnSetupMementoStack()
        {
            Instance.Data.MementoStack.Restore = (memento) =>
            {
                Instance.Data.AudioTriggerEntries.Clear();
                for (var i = 0; i < memento.Data.Count; i++)
                {
                    Instance.Data.AudioTriggerEntries.Add(memento.Data[i].Clone());
                }
            };
            Instance.Data.MementoStack.GetMementoData = () =>
            {
                var memento = new AudioTriggersEditorMemento();
                for (var i = 0; i < Instance.Data.AudioTriggerEntries.Count; i++)
                {
                    var entry = Instance.Data.AudioTriggerEntries[i];
                    memento.Data.Add(entry.Clone());
                }
                return memento;
            };
        }

        static void OnSetupAudioTriggers()
        {
            Instance.Data.AudioTriggers = Utils.GetAttributeTypesWith<AudioTriggerAttribute>().ToList();
        }

        void OnDestroy()
        {
            Instance = null;
        }

        void Reload()
        {

        }

        void Save()
        {

        }

        void OnGUI()
        {//
            Instance = this;
            Texture2D bg = Resources.Load<Texture2D>("EditorBackground");
            GUI.DrawTextureWithTexCoords(new Rect(0, 0, Screen.width, Screen.height), bg, new Rect(0, 0, Screen.width / bg.width, Screen.height / bg.height));

            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width)))
            {
                if (GUILayout.Button("File", EditorStyles.toolbarDropDown, GUILayout.Width(50)))
                {
                    GenericMenu fileMenu = new GenericMenu();

                    fileMenu.AddItem(new GUIContent("Reload"), false, () =>
                    {
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
            }

            GUI.backgroundColor = Color.yellow;
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width)))
            {
                if (GUILayout.Button("Trigger", EditorStyles.toolbarButton, GUILayout.Width(150)))
                {
                }

                if (GUILayout.Button("Description", EditorStyles.toolbarButton, GUILayout.Width(400)))
                {
                }

                if (GUILayout.Button("Audio Id", EditorStyles.toolbarButton, GUILayout.Width(150)))
                {
                }
            }
            GUI.backgroundColor = Color.white;
            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition, GUIStyle.none, GUI.skin.verticalScrollbar);

            for (var i = 0; i < Data.AudioTriggers.Count; i++)
            {
                var audioTrigger = Data.AudioTriggers[i];

                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));
                EditorGUILayout.LabelField(audioTrigger.Id, EditorStyles.boldLabel, GUILayout.Width(150));
                EditorGUILayout.LabelField(audioTrigger.Description, GUILayout.Width(400));
                var triggerEntry = Data.AudioTriggerEntries.Find(x => x.Id == audioTrigger.Id);
                if (triggerEntry == null)
                {
                    Data.AudioTriggerEntries.Add(triggerEntry = new AudioTriggerEditorEntry() { Id = audioTrigger.Id });
                    triggerEntry.AudioIds.Add("");
                }
                for (var j = 0; j < triggerEntry.AudioIds.Count; j++)
                {
                    var entry = triggerEntry.AudioIds[j];

                    var newEntry = EditorGUILayout.TextField(entry, GUILayout.Width(150));
                    if (newEntry != entry)
                        Data.MementoStack.CreateMemento();
                    triggerEntry.AudioIds[j] = newEntry;
                }
                EditorGUILayout.EndHorizontal();
            }

            EditorGUILayout.EndScrollView();
        }
    }


}