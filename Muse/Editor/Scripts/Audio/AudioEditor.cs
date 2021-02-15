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
    public class AudioEditorData : ScriptableObject
    {
        public List<AudioEditorEntry> AudioEntries = new List<AudioEditorEntry>();

        public AudioMixer Mixer;
        public List<string> Groups = new List<string>();

        public AudioEditorEntry.AudioTypes SelectedType = AudioEditorEntry.AudioTypes.Persistant;

        public string Filter;

        public AudioEditorData()
        {
        }

    }

    [System.Serializable]
    public class AudioEditorEntry
    {
        public string Id;
        public string Group;
        public string MixerId;
        public enum AudioTypes { Persistant, Streaming };
        public AudioTypes AudioType;
        public string Path;
        public float Volume = 1;
        public float NewVolume = 1;
        public bool IsDeleted;

        public AudioSource source;

        public AudioEditorEntry Clone()
        {
            var clone = new AudioEditorEntry();
            clone.Id = Id;
            clone.Group = Group;
            clone.MixerId = MixerId;
            clone.AudioType = AudioType;
            clone.Path = Path;
            clone.Volume = Volume;
            return clone;
        }
    }

    public class AudioEditor : EditorWindow
    {
        public static AudioEditor Instance { get; private set; }

        public const string AUDIO_PATH = MuseEditor.GameDataPathRaw + "Audio/";

        public AudioEditorData Data;

        public static void Setup()
        {
            if (!System.IO.Directory.Exists(MuseEditor.GameDataPathRaw + "Audio"))
                System.IO.Directory.CreateDirectory(MuseEditor.GameDataPathRaw + "Audio");

            if (!System.IO.Directory.Exists(MuseEditor.GameDataPathCompiled + "Audio"))
                System.IO.Directory.CreateDirectory(MuseEditor.GameDataPathCompiled + "Audio");

            if (!File.Exists(MuseEditor.GameDataPathRaw + "Audio/AudioManager.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "AudioManager";
                classWriter.IsPartial = true;
                classWriter.IsPublic = true;

                classWriter.WritePath(MuseEditor.GameDataPathRaw + "Audio/AudioManager.cs");
            }

            if (!File.Exists(MuseEditor.GameDataPathCompiled + "Audio/AudioManager.cs"))
            {
                var classWriter = new ClassWriter();
                classWriter.Name = "AudioManager";
                classWriter.IsPartial = true;
                classWriter.IsPublic = true;

                classWriter.WritePath(MuseEditor.GameDataPathCompiled + "Audio/AudioManager.cs");
            }
        }

        [SerializeField]
        private Vector2 _scrollPosition;

        [MenuItem("Muse/Editors/Assets/Audio Files")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<AudioEditor>();
            window.titleContent = new GUIContent("Audio Files");
            window.Show();



            Instance = window;
            window.Data = ScriptableObject.CreateInstance<AudioEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "AudioEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Reload();
            window.Data.Mixer = Resources.Load<AudioMixer>("audiomanagermixer");
            window.RefreshStreamingAssets();
            //OnSetupMementoStack();
        }

        [DidReloadScripts]
        static void OnReloadScripts()
        {
            var windows = Resources.FindObjectsOfTypeAll<AudioEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];
        }

        void OnDestroy()
        {
            Instance = null;
        }

        public void RefreshStreamingAssets()
        {
            //Debug.Log("refresh streaming assets");
            string[] files = Directory.GetFiles("Assets/StreamingAssets/Audio", "*", SearchOption.AllDirectories).Where(x => (x.Contains(".mp3") || x.Contains(".ogg")) && !x.Contains(".meta")).ToArray();
            // Debug.Log("files: " + files.Length);

            var paths = new Dictionary<string, string>();
            var types = new Dictionary<string, string>();

            for (var i = 0; i < files.Length; i++)
            {
                var path = files[i].Replace("Assets/StreamingAssets/Audio\\", "").Replace("\\", "/");

                // Debug.Log(path);

                var lastSlashIndex = path.LastIndexOf("/") + 1;
                var lastDotIndex = path.LastIndexOf(".");
                var name = path.Substring(lastSlashIndex, lastDotIndex - lastSlashIndex);
                var cleanPath = "Audio/" + path.Replace(".mp3", "").Replace(".ogg", "");

                if (!paths.ContainsKey(name))
                {
                    paths.Add(name, cleanPath);
                    if (path.IndexOf("VO") == 0)
                        types.Add(name, "VO");
                    else if (path.IndexOf("MUSIC") == 0)
                        types.Add(name, "MUSIC");
                    else if (path.IndexOf("SFX") == 0)
                        types.Add(name, "SFX");
                }

            }

            foreach (var name in paths.Keys)
            {
                var entry = Data.AudioEntries.Find(x => x.Id.ToUpper() == name.ToUpper());

                if (entry == null)
                {
                    entry = new AudioEditorEntry();
                    Data.AudioEntries.Add(entry);
                }

                //Debug.Log("adding entry: " + name);
                entry.Id = name;
                entry.Path = paths[name];
                entry.AudioType = AudioEditorEntry.AudioTypes.Streaming;
                entry.Group = types[name];
            }

            Data.AudioEntries.RemoveAll(x => x.AudioType == AudioEditorEntry.AudioTypes.Streaming && !paths.ContainsKey(x.Id.ToLower()));
            Save();
        }

        public void Reload()
        {
            var classWriter = ClassWriter.Load(AUDIO_PATH + "AudioManager.cs");

            var method = classWriter.GetMethod("Start");

            if (method == null)
                return;

            var linesRaw = method.GetText().Split(new string[] { "\n" }, StringSplitOptions.None);
            var lines = new List<string>(linesRaw);

            var ids = lines.FindAll(x => x.Contains("//Id "));
            var groups = lines.FindAll(x => x.Contains("//Group "));
            var mixers = lines.FindAll(x => x.Contains("//MixerId "));
            var paths = lines.FindAll(x => x.Contains("//Path "));
            var volumes = lines.FindAll(x => x.Contains("//Volume "));
            var audioTypes = lines.FindAll(x => x.Contains("//AudioType "));

            Data.AudioEntries.Clear();
            for (var i = 0; i < ids.Count; i++)
            {
                var id = ids[i].Split(' ')[1];
                var groupTokens = groups.Find(x => x.Split(' ')[1] == id).Split(' ');
                var group = groupTokens.Length > 2 ? groupTokens[2] : "";
                var mixerTokens = mixers.Find(x => x.Split(' ')[1] == id).Split(' ');
                var mixer = mixerTokens.Length > 2 ? mixerTokens[2] : "";
                var pathTokens = paths.Find(x => x.Split(' ')[1] == id).Split(' ');
                var path = pathTokens.Length > 2 ? pathTokens[2] : "";
                var volume = float.Parse(volumes.Find(x => x.Split(' ')[1] == id).Split(' ')[2]);
                var audioType = (AudioEditorEntry.AudioTypes)Enum.Parse(typeof(AudioEditorEntry.AudioTypes), audioTypes.Find(x => x.Split(' ')[1] == id).Split(' ')[2]);

                Data.AudioEntries.Add(new AudioEditorEntry() { Id = id, Group = group, MixerId = mixer, Path = path, Volume = volume, NewVolume = volume, AudioType = audioType });
            }


            classWriter = ClassWriter.Load(AUDIO_PATH + "AudioGroups.cs");

            var groupProperties = classWriter.GetPropertyWriters();
            Data.Groups.Clear();
            for (var i = 0; i < groupProperties.Count; i++)
            {
                Data.Groups.Add(groupProperties[i].Name);
            }
        }

        public void Save()
        {
            var classWriter = new ClassWriter();
            classWriter.Name = "AudioManager";
            classWriter.IsPublic = true;
            classWriter.IsPartial = true;
            classWriter.AddTopLine("using UnityEngine;");
            classWriter.AddTopLine("using System;");


            var method = classWriter.CreateMethodWriter();
            method.Name = "Start";
            method.ReturnType = "void";

            for (var i = 0; i < Data.AudioEntries.Count; i++)
            {
                var entry = Data.AudioEntries[i];

                if (entry.IsDeleted)
                {
                    if (entry.AudioType == AudioEditorEntry.AudioTypes.Streaming)
                    {
                        if (File.Exists(Application.streamingAssetsPath + "/" + entry.Path + ".mp3"))
                            File.Delete(Application.streamingAssetsPath + "/" + entry.Path + ".mp3");
                        if (File.Exists(Application.streamingAssetsPath + "/" + entry.Path + ".ogg"))
                            File.Delete(Application.streamingAssetsPath + "/" + entry.Path + ".ogg");
                    }
                    else
                    {
                        if (File.Exists(Application.dataPath + "/Muse/Game/Audio/Resources/" + entry.Id + ".mp3"))
                            File.Delete(Application.dataPath + "/Muse/Game/Audio/Resources/" + entry.Id + ".mp3");
                        if (File.Exists(Application.dataPath + "/Muse/Game/Audio/Resources/" + entry.Id + ".ogg"))
                            File.Delete(Application.dataPath + "/Muse/Game/Audio/Resources/" + entry.Id + ".ogg");
                    }
                    continue;
                }

                method.AddLine("//Id " + entry.Id);
                method.AddLine("//Group " + entry.Id + " " + entry.Group);
                method.AddLine("//MixerId " + entry.Id + " " + entry.MixerId);
                method.AddLine("//Path " + entry.Id + " " + entry.Path);
                method.AddLine("//Volume " + entry.Id + " " + entry.Volume);
                method.AddLine("//AudioType " + entry.Id + " " + entry.AudioType);

                if (entry.AudioType == AudioEditorEntry.AudioTypes.Persistant)
                {
                    method.AddLine("RegisterAudio(\"" + entry.Id + "\", \"" + entry.Group + "\", \"" + entry.MixerId + "\", Resources.Load<AudioClip>(\"" + entry.Path.Replace("\\", "/") + "\"), " + entry.Volume + "f);");
                }
                else
                {
                    method.AddLine("#if UNITY_EDITOR || UNITY_STANDALONE");
                    method.AddLine("RegisterStreamingAudio(\"" + entry.Id + "\", \"" + entry.Group + "\", \"" + entry.MixerId + "\", \"" + entry.Path.Replace("\\", "/") + ".ogg\", " + entry.Volume + "f);");
                    method.AddLine("#else");
                    method.AddLine("RegisterStreamingAudio(\"" + entry.Id + "\", \"" + entry.Group + "\", \"" + entry.MixerId + "\", \"" + entry.Path.Replace("\\", "/") + ".mp3\", " + entry.Volume + "f);");
                    method.AddLine("#endif");
                }
            }

            classWriter.WritePath(AUDIO_PATH + "AudioManager.cs");

            classWriter = new ClassWriter();
            classWriter.Name = "AudioIds";
            classWriter.IsPublic = true;
            classWriter.IsPartial = true;
            for (var i = 0; i < Data.AudioEntries.Count; i++)
            {
                var entry = Data.AudioEntries[i];

                if (entry.IsDeleted)
                    continue;

                var propertyWriter = classWriter.CreatePropertyWriter();
                propertyWriter.IsConst = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                propertyWriter.Name = entry.Id;
                propertyWriter.Value = "\"" + entry.Id + "\"";
                propertyWriter.Type = "string";
            }
            classWriter.WritePath(AUDIO_PATH + "AudioIds.cs");

            classWriter = new ClassWriter();
            classWriter.Name = "AudioGroups";
            classWriter.IsPublic = true;
            classWriter.IsPartial = true;
            for (var i = 0; i < Data.Groups.Count; i++)
            {
                var group = Data.Groups[i];

                var propertyWriter = classWriter.CreatePropertyWriter();
                propertyWriter.IsConst = true;
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                propertyWriter.Name = group;
                propertyWriter.Value = "\"" + group + "\"";
                propertyWriter.Type = "string";
            }
            classWriter.WritePath(AUDIO_PATH + "AudioGroups.cs");
        }

        void OnGUI()
        {//
            if (Data == null || Data.Mixer == null)
                Init();
            Instance = this;


            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar))
            {
                using (new EditorGUILayout.HorizontalScope(GUILayout.Width(Screen.width)))
                {
                    if (Data.SelectedType == AudioEditorEntry.AudioTypes.Persistant)
                        GUI.backgroundColor = Color.yellow;
                    if (GUILayout.Button("Persistant", EditorStyles.toolbarButton, GUILayout.Width(100)))
                    {
                        Data.SelectedType = AudioEditorEntry.AudioTypes.Persistant;
                    }
                    GUI.backgroundColor = Color.white;

                    if (Data.SelectedType == AudioEditorEntry.AudioTypes.Streaming)
                        GUI.backgroundColor = Color.yellow;
                    if (GUILayout.Button("Streaming", EditorStyles.toolbarButton, GUILayout.Width(100)))
                    {
                        Data.SelectedType = AudioEditorEntry.AudioTypes.Streaming;
                    }
                    GUI.backgroundColor = Color.white;
                    Data.Filter = EditorGUILayout.TextField(Data.Filter);
                }


                using (new EditorGUILayout.HorizontalScope(GUILayout.Width(Screen.width)))
                {
                    if (Data.SelectedType == AudioEditorEntry.AudioTypes.Persistant)
                    {
                        int addIndex = -1;
                        if (GUILayout.Button("Add Music", EditorStyles.toolbarButton, GUILayout.Width(75)))
                        {
                            addIndex = 0;
                        }
                        if (GUILayout.Button("Add Sfx", EditorStyles.toolbarButton, GUILayout.Width(75)))
                        {
                            addIndex = 1;
                        }
                        if (GUILayout.Button("Add VO", EditorStyles.toolbarButton, GUILayout.Width(75)))
                        {
                            addIndex = 2;
                        }

                        if (addIndex > -1 && EditorUtility.DisplayDialog("Add Persistant " + (addIndex == 0 ? "Music" : addIndex == 1 ? "Sfx" : "VO"), "Select a .mp3 file to add.\n\nUse Persistant audio for any audio which remains in memory for the entire game, ie: gui sfx.\n\nIf there is no corresponding .ogg in the same directory, an .ogg will be automatically generated. This costs time and money, so feel free to generate this yourself with something like www.convertio.com.", "Continue", "Cancel"))
                        {
                            var path = EditorUtility.OpenFilePanel("Add Persistant " + (addIndex == 0 ? "Music" : addIndex == 1 ? "Sfx" : "VO"), Application.dataPath, "mp3");

                            if (!string.IsNullOrEmpty(path))
                            {
                                var startIndex = path.LastIndexOf("/") + 1;
                                var lastIndex = path.LastIndexOf(".");
                                var name = path.Substring(startIndex, lastIndex - startIndex).ToLower();
                                var group = (addIndex == 0 ? "MUSIC" : addIndex == 1 ? "SFX" : "VO");


                                var existingEntry = Data.AudioEntries.Find(x => x.Id == name);
                                if (existingEntry != null)
                                {
                                    EditorUtility.DisplayDialog("Existing Entry!", "An entry with that name already exists. Please rename the .mp3 and try again.", "Ok");
                                }
                                else if (name.Contains(" "))
                                {
                                    EditorUtility.DisplayDialog("Cannot Contain Whitespace!", "Filenames cannot contain whitespace. Please rename the .mp3 and try again.", "Ok");
                                }
                                else
                                {
                                    var newPath = "/Muse/Game/Audio/Resources/" + name;
                                    var copyTo = Application.dataPath + newPath;
                                    File.Copy(path, copyTo + ".mp3");

                                    Data.AudioEntries.Add(new AudioEditorEntry() { Id = name, Group = group, AudioType = AudioEditorEntry.AudioTypes.Persistant, Path = newPath });
                                    AssetDatabase.Refresh();
                                    Save();
                                }
                            }
                        }
                    }
                    else
                    {
                        int addIndex = -1;
                        if (GUILayout.Button("Add Music", EditorStyles.toolbarButton, GUILayout.Width(75)))
                        {
                            addIndex = 0;
                        }
                        if (GUILayout.Button("Add Sfx", EditorStyles.toolbarButton, GUILayout.Width(75)))
                        {
                            addIndex = 1;
                        }
                        if (GUILayout.Button("Add VO", EditorStyles.toolbarButton, GUILayout.Width(75)))
                        {
                            addIndex = 2;
                        }

                        if (addIndex > -1 && EditorUtility.DisplayDialog("Add Streaming " + (addIndex == 0 ? "Music" : addIndex == 1 ? "Sfx" : "VO"), "Select a .mp3 file to add.\n\nUse Streaming audio for any audio which should not persist throughout the entire game.\n\nIf there is no corresponding .ogg in the same directory, an .ogg will be automatically generated. This costs time and money, so feel free to generate this yourself with something like www.convertio.com.", "Continue", "Cancel"))
                        {
                            var path = EditorUtility.OpenFilePanel("Add Streaming " + (addIndex == 0 ? "Music" : addIndex == 1 ? "Sfx" : "VO"), EditorPrefs.HasKey("MuseAudioEditorLastStreaming") ? EditorPrefs.GetString("MuseAudioEditorLastStreaming") : Application.dataPath, "mp3");

                            EditorPrefs.SetString("MuseAudioEditorLastStreaming", path);

                            if (!string.IsNullOrEmpty(path))
                            {
                                var startIndex = path.LastIndexOf("/") + 1;
                                var lastIndex = path.LastIndexOf(".");
                                var name = path.Substring(startIndex, lastIndex - startIndex).ToLower();
                                var group = (addIndex == 0 ? "MUSIC" : addIndex == 1 ? "SFX" : "VO");


                                var existingEntry = Data.AudioEntries.Find(x => x.Id == name);
                                if (existingEntry != null)
                                {
                                    EditorUtility.DisplayDialog("Existing Entry!", "An entry with that name already exists. Please rename the .mp3 and try again.", "Ok");
                                }
                                else if (name.Contains(" "))
                                {
                                    EditorUtility.DisplayDialog("Cannot Contain Whitespace!", "Filenames cannot contain whitespace. Please rename the .mp3 and try again.", "Ok");
                                }
                                else
                                {
                                    if (!Directory.Exists(Application.streamingAssetsPath + "/Audio/" + group))
                                        Directory.CreateDirectory(Application.streamingAssetsPath + "/Audio/" + group);
                                    if (!Directory.Exists(Application.streamingAssetsPath + "/Audio/" + group + "/Custom/"))
                                        Directory.CreateDirectory(Application.streamingAssetsPath + "/Audio/" + group + "/Custom/");

                                    var newDir = "/Audio/" + group + "/Custom/";
                                    var newPath = newDir + name;
                                    var copyTo = Application.streamingAssetsPath + newPath;
                                    File.Copy(path, copyTo + ".mp3");

                                    ConvertIOServices.ConvertMp3(path, Application.streamingAssetsPath + newDir, null, () =>
                                    {
                                        AssetDatabase.Refresh();
                                        Save();
                                    });

                                    
                                }
                            }
                        }

                        if (GUILayout.Button("Refresh", EditorStyles.toolbarButton, GUILayout.Width(80)))
                        {
                            RefreshStreamingAssets();
                        }
                    }
                    /*
                    if (GUILayout.Button("Groups", EditorStyles.toolbarButton, GUILayout.Width(100)))
                    {
                        TagEditorPopup window = new TagEditorPopup(Data.Groups, (groups) => true, (groups) =>
                        {
                            Data.MementoStack.CreateMemento();
                            Data.Groups = groups;
                        });
                        PopupWindow.Show(new Rect(75, -1, 100, 18), window);
                    }
                    */

                }
            }



            GUI.backgroundColor = Color.clear;
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width)))
            {
                if (GUILayout.Button("Id", EditorStyles.toolbarButton, GUILayout.Width(250)))
                {
                }

                if (GUILayout.Button("Group", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                }

                if (GUILayout.Button("Mixer", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                }


                if (GUILayout.Button("Path", EditorStyles.toolbarButton, GUILayout.Width(410)))
                {
                }

                if (GUILayout.Button("Volume", EditorStyles.toolbarButton, GUILayout.Width(170)))
                {
                }

                if (GUILayout.Button("Test", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                }
            }
            GUI.backgroundColor = Color.white;

            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition, GUIStyle.none, GUI.skin.verticalScrollbar);



            for (var i = 0; i < Data.AudioEntries.Count; i++)
            {
                var audio = Data.AudioEntries[i];
                if (!string.IsNullOrEmpty(Data.Filter) && !audio.Id.StartsWith(Data.Filter))
                    continue;

                if (Data.SelectedType == AudioEditorEntry.AudioTypes.Persistant && audio.AudioType != AudioEditorEntry.AudioTypes.Persistant)
                    continue;
                else if (Data.SelectedType == AudioEditorEntry.AudioTypes.Streaming && audio.AudioType != AudioEditorEntry.AudioTypes.Streaming)
                    continue;


                GUI.color = audio.IsDeleted ? Color.red : Color.white;
                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width)))
                {

                    GUI.enabled = audio.AudioType == AudioEditorEntry.AudioTypes.Persistant || audio.Path.Contains("/Custom/");
                    if (GUILayout.Button(audio.Id, EditorStyles.toolbarButton, GUILayout.Width(250)))
                    {
                        StringEditorPopup window = new StringEditorPopup(audio.Id, (id) => Data.AudioEntries.Find(x => x.Id.ToLower() == id.ToLower()) == null, (id) =>
                        {
                            var path = "";
                            var newPath = "";

                            if (audio.AudioType == AudioEditorEntry.AudioTypes.Streaming)
                            {
                                path = Application.streamingAssetsPath + "/" + audio.Path;
                                newPath = path.Substring(0, path.LastIndexOf("/") + 1) + id;
                                audio.Path = newPath.Replace(Application.streamingAssetsPath + "/", "");
                            }
                            else
                            {
                                path = Application.dataPath + "/Muse/Game/Audio/Resources/" + audio.Path;
                                newPath = Application.dataPath + "/Muse/Game/Audio/Resources/" + id;
                                audio.Path = id;
                            }

                        //Data.MementoStack.CreateMemento();
                        audio.Id = id;
                            if (File.Exists(path + ".mp3"))
                            {
                                File.Move(path + ".mp3", newPath + ".mp3");
                            }

                            if (File.Exists(path + ".ogg"))
                            {
                                File.Move(path + ".ogg", newPath + ".ogg");
                            }
                            Data.AudioEntries.Sort((x, y) => x.Id.CompareTo(y.Id));

                            AssetDatabase.Refresh();
                            Save();
                        });
                        PopupWindow.Show(new Rect(0, i * 18 + 18 - 100, 100, 100), window);
                    }
                    GUI.enabled = true;

                    {
                        //Debug.Log(audio.Id + ", " + audio.Group);
                        GUI.enabled = audio.AudioType == AudioEditorEntry.AudioTypes.Persistant || audio.Path.Contains("/Custom/");
                        var groupIndex = Mathf.Max(0, Data.Groups.IndexOf(audio.Group));
                        var newGroupIndex = EditorGUILayout.Popup(groupIndex, Data.Groups.ToArray(), EditorStyles.toolbarButton, GUILayout.Width(100));

                        audio.Group = newGroupIndex > -1 && Data.Groups.Count > 0 ? Data.Groups[newGroupIndex] : null;

                        if (groupIndex != newGroupIndex)
                        {
                            var path = "";
                            var newPath = "";

                            if (audio.AudioType == AudioEditorEntry.AudioTypes.Streaming)
                            {
                                path = Application.streamingAssetsPath + "/" + audio.Path;
                                newPath = path.Replace("/" + Data.Groups[groupIndex] + "/", "/" + Data.Groups[newGroupIndex] + "/");
                                audio.Path = newPath.Replace(Application.streamingAssetsPath + "/", "");

                                if (File.Exists(path + ".mp3"))
                                {
                                    File.Move(path + ".mp3", newPath + ".mp3");
                                }

                                if (File.Exists(path + ".ogg"))
                                {
                                    File.Move(path + ".ogg", newPath + ".ogg");
                                }
                                Data.AudioEntries.Sort((x, y) => x.Id.CompareTo(y.Id));
                                AssetDatabase.Refresh();
                            }
                            Save();
                        }
                        GUI.enabled = true;
                    }

                    {
                        var mixerGroups = new List<AudioMixerGroup>(Data.Mixer.FindMatchingGroups("")).ConvertAll(x => x.name).FindAll(x => x != "Master");
                        mixerGroups.Insert(0, "Master");
                        var mixerIndex = Mathf.Max(0, mixerGroups.IndexOf(audio.MixerId));
                        var newMixerIndex = EditorGUILayout.Popup(mixerIndex, mixerGroups.ToArray(), EditorStyles.toolbarButton, GUILayout.Width(100));


                        if (newMixerIndex > 0)
                            audio.MixerId = mixerGroups[newMixerIndex];
                        else
                            audio.MixerId = null;


                        if (newMixerIndex != mixerIndex)
                            Save();
                    }

                    if (audio.AudioType == AudioEditorEntry.AudioTypes.Streaming)
                        EditorGUILayout.LabelField(audio.Path, GUILayout.Width(400));
                    else
                        EditorGUILayout.LabelField("Muse/Game/Audio/Resources/" + audio.Path, GUILayout.Width(400));

                    GUILayout.Space(10);
                    {
                        var volume = audio.NewVolume;
                        var newAudioVolume = GUILayout.HorizontalSlider(audio.NewVolume, 0, 1, GUILayout.Width(100));
                        newAudioVolume = Mathf.Clamp(EditorGUILayout.FloatField(newAudioVolume, GUILayout.Width(50)), 0f, 1f);
                        audio.NewVolume = newAudioVolume;
                        if (audio.NewVolume != audio.Volume)
                        {
                            if (GUILayout.Button("Save", EditorStyles.toolbarButton, GUILayout.Width(50)))
                            {
                                audio.Volume = audio.NewVolume;
                                Save();
                            }
                        }

                    }
                    GUILayout.Space(4);
                    if (GUILayout.Button("Play", EditorStyles.toolbarButton, GUILayout.Width(50)))
                    {
                        if (audio.source != null)
                        {
                            audio.source.Stop();
                            GameObject.DestroyImmediate(audio.source.gameObject);
                            audio.source = null;
                        }
                        if (audio.AudioType == AudioEditorEntry.AudioTypes.Persistant)
                        {
                            var go = new GameObject();
                            go.hideFlags = HideFlags.HideAndDontSave;
                            audio.source = go.AddComponent<AudioSource>();
                            audio.source.outputAudioMixerGroup = Data.Mixer.FindMatchingGroups(audio.Group.ToUpper())[0];
                            audio.source.clip = Resources.Load<AudioClip>(audio.Path);
                            audio.source.volume = audio.Volume;
                            audio.source.Play();
                        }
                        else
                        {
                            var www = new WWW(AudioManager.GetStreamingPath() + "/" + audio.Path + ".ogg");
                            WaitForWWW(audio, www);
                        }
                    }

                    if (GUILayout.Button("Stop", EditorStyles.toolbarButton, GUILayout.Width(50)))
                    {
                        if (audio.source != null)
                        {
                            audio.source.Stop();
                            GameObject.DestroyImmediate(audio.source.gameObject);
                            audio.source = null;
                        }
                    }

                    if (audio.source != null && !audio.source.isPlaying)
                    {
                        audio.source.Stop();
                        GameObject.DestroyImmediate(audio.source.gameObject);
                        audio.source = null;
                    }


                    GUILayout.FlexibleSpace();
                    GUI.enabled = audio.AudioType == AudioEditorEntry.AudioTypes.Persistant || audio.Path.Contains("/Custom/");
                    if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(25)))
                    {
                        if (EditorUtility.DisplayDialog("Delete Audio?", "Delete the audio entry with id \"" + audio.Id + "\"?", "Delete", "Cancel"))
                        {
                            Debug.Log("delete: " + Application.streamingAssetsPath + "/" + audio.Path);
                            File.Delete(Application.streamingAssetsPath + "/" + audio.Path + ".mp3");
                            File.Delete(Application.streamingAssetsPath + "/" + audio.Path + ".ogg");
                            Data.AudioEntries.Remove(audio);
                            AssetDatabase.Refresh();
                            i--;
                        }
                    }
                    GUI.enabled = true;
                    GUILayout.Space(10);
                }
                GUI.color = Color.white;
            }

            EditorGUILayout.EndScrollView();
        }

        private void WaitForWWW(AudioEditorEntry audio, WWW www)
        {
            EditorApplication.CallbackFunction updateFunc = null;
            updateFunc = () =>
            {
                if (!www.isDone)
                    return;

                Debug.Log(www.url);
                EditorApplication.update -= updateFunc;

                if (www.error != null)
                    Debug.Log(www.error);

                AudioClip audioClip = www.GetAudioClip(false, false, AudioType.OGGVORBIS);

                audioClip.LoadAudioData();

                var go = new GameObject();
                go.hideFlags = HideFlags.HideAndDontSave;
                audio.source = go.AddComponent<AudioSource>();
                audio.source.outputAudioMixerGroup = Resources.Load<AudioMixer>("audiomanagermixer").FindMatchingGroups(audio.Group.ToUpper())[0];
                audio.source.clip = audioClip;
                audio.source.volume = audio.Volume;
                audio.source.Play();
            };
            EditorApplication.update += updateFunc;
        }
    }


}