using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using UnityEngine.Audio;
using System.Linq;
using UnityEditor.Callbacks;

namespace Muse.Editors.StreamingImages
{
    public class StreamingImageEditorData : ScriptableObject
    {
        public StreamingImagesData SavedData;

        public Dictionary<string, Texture> Textures = new Dictionary<string, Texture>();
    }


    public class StreamingImageEditor : EditorWindow
    {
        public static StreamingImageEditor Instance { get; private set; }


        public StreamingImageEditorData Data;


        [SerializeField]
        private Vector2 _scrollPosition;

        [MenuItem("Muse/Editors/Assets/Streaming Images")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<StreamingImageEditor>();
            window.titleContent = new GUIContent("Streaming Img");
            window.Show();
            
            Instance = window;
            window.Data = ScriptableObject.CreateInstance<StreamingImageEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "StreamingImagesEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            window.Reload();
            
        }

        [DidReloadScripts]
        static void OnReloadScripts()
        {
            var windows = Resources.FindObjectsOfTypeAll<StreamingImageEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];
            Instance.Reload();
        }


        void OnDestroy()
        {
            Instance = null;
        }

        public void Reload()
        {
            Data.SavedData = Resources.Load<StreamingImagesData>("StreamingImages/StreamingImagesData");
        }

        public static void Setup()
        {
            if (!Directory.Exists(Application.streamingAssetsPath + "/Images/StreamingImgs"))
            {
                Directory.CreateDirectory(Application.streamingAssetsPath + "/Images/StreamingImgs");
            }


            if (!Directory.Exists(MuseEditor.GameDataPathCompiled + "../Resources"))
            {
                Directory.CreateDirectory(MuseEditor.GameDataPathCompiled + "../Resources");
            }

            if (!Directory.Exists(MuseEditor.GameDataPathCompiled + "../Resources/StreamingImages"))
            {
                Directory.CreateDirectory(MuseEditor.GameDataPathCompiled + "../Resources/StreamingImages");
            }

            if (!File.Exists(MuseEditor.GameDataPathCompiled + "../Resources/StreamingImages/StreamingImagesData.asset"))
            {
                var data = ScriptableObject.CreateInstance<StreamingImagesData>();
                AssetDatabase.CreateAsset(data, MuseEditor.GameDataPathCompiled + "../Resources/StreamingImages/StreamingImagesData.asset");
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }

        void OnGUI()
        {
            if (Data == null)
                Init();
            Instance = this;

            
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width)))
            {
                if (GUILayout.Button("Add Image", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    var path = EditorUtility.OpenFilePanel("Select Image", EditorPrefs.HasKey("MuseStreamingImageEditorPath") ? EditorPrefs.GetString("MuseStreamingImageEditorPath") : Application.dataPath, "png").Replace("\\", "/");
                    EditorPrefs.SetString("MuseStreamingImageEditorPath", path);

                    if (!string.IsNullOrEmpty(path))
                    {
                        var slashIndex = path.LastIndexOf("/") + 1;
                        var dotIndex = path.IndexOf(".");

                        var id = path.Substring(slashIndex, dotIndex - slashIndex).ToLower();

                        bool cancel = false;

                        if (!Data.SavedData.Data.ContainsKey(id))
                            Data.SavedData.Data.Add(id, "/Images/StreamingImgs/" + id + ".png");
                        else
                        {
                            cancel = !EditorUtility.DisplayDialog("Overwrite Streaming Image?", "There is already a streaming image with the id \"" + id + "\". Are you sure you want to overwrite the image?", "Overwrite", "Cancel");
                        }

                        if (!cancel)
                        {
                            File.Copy(path, Application.streamingAssetsPath + "/Images/StreamingImgs/" + id + ".png", true);
                            AssetDatabase.Refresh();
                        }
                    }
                }
                GUI.enabled = true;
            }

            GUI.backgroundColor = Color.clear;
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width)))
            {
                if (GUILayout.Button("Id", EditorStyles.toolbarButton, GUILayout.Width(250)))
                {
                }

                if (GUILayout.Button("Path", EditorStyles.toolbarButton, GUILayout.Width(250)))
                {
                }

            }
            GUI.backgroundColor = Color.white;

            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition, GUIStyle.none, GUI.skin.verticalScrollbar);
            var keys = Data.SavedData.Data.Keys.ToList();
            for (var i = 0; i < keys.Count; i++)
            {
                var id = keys[i];
                var path = Data.SavedData.Data[id];
                var texture = Data.Textures.ContainsKey(id) ? Data.Textures[id] : null;



                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(Screen.width), GUILayout.Height(120)))
                {
                    if (texture != null)
                    {
                        EditorGUI.DrawPreviewTexture(new Rect(7, i * 120 + 5, 90, 90), texture);
                    }
                    GUILayout.Space(5);
                    using (new EditorGUILayout.HorizontalScope())
                    {
                        GUILayout.Space(100);
                        EditorGUILayout.LabelField("Id:", GUILayout.Width(150));
                        if (GUILayout.Button(id, EditorStyles.toolbarButton, GUILayout.Width(250)))
                        {
                            var entryId = id;
                            StringEditorPopup window = new StringEditorPopup(id, (newId) =>
                            {
                                return Data.SavedData.Data.Where(x => x.Key.ToLower() == newId.ToLower()).ToList().Count == 0;
                            }, (newId) =>
                            {
                                newId = newId.ToLower();
                                Data.SavedData.Data.Remove(entryId);
                                var newPath = "/Images/StreamingImgs/" + newId + ".png";
                                Data.SavedData.Data.Add(newId, newPath);



                                if (File.Exists(Application.streamingAssetsPath + path))
                                {
                                    Debug.Log("move from : " + Application.streamingAssetsPath + path + ", " + Application.streamingAssetsPath + newPath);
                                    File.Move(Application.streamingAssetsPath + path, Application.streamingAssetsPath + newPath);
                                    AssetDatabase.Refresh();
                                }
                                if (Data.Textures.ContainsKey(id))
                                    Data.Textures.Remove(id);
                            });
                            PopupWindow.Show(new Rect(260, i * 120 + 5, 100, 18), window);
                        }
                        GUILayout.FlexibleSpace();
                        if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                        {
                            keys.RemoveAt(i);
                            i--;
                            Data.SavedData.Data.Remove(id);
                            if (Data.Textures.ContainsKey(id))
                                Data.Textures.Remove(id);

                            if (File.Exists(Application.streamingAssetsPath + path))
                            {
                                File.Delete(Application.streamingAssetsPath + path);
                                AssetDatabase.Refresh();
                            }
                        }
                        GUILayout.Space(5);
                    }

                    using (new EditorGUILayout.HorizontalScope())
                    {
                        GUILayout.Space(100);
                        EditorGUILayout.LabelField("Path:", GUILayout.Width(150));
                        EditorGUILayout.LabelField(path);
                    }

                    using (new EditorGUILayout.HorizontalScope())
                    {
                        GUILayout.Space(100);
                        EditorGUILayout.LabelField("Resolution:", GUILayout.Width(150));
                        EditorGUILayout.LabelField(texture != null ? texture.width + "x" + texture.height + " px" : "", GUILayout.Width(100));
                    }

                    GUILayout.Space(35);
                    using (new EditorGUILayout.HorizontalScope())
                    {
                        if (GUILayout.Button("Replace", EditorStyles.toolbarButton, GUILayout.Width(90)))
                        {
                            path = EditorUtility.OpenFilePanel("Select Image", EditorPrefs.HasKey("MuseStreamingImageEditorPath") ? EditorPrefs.GetString("MuseStreamingImageEditorPath") : Application.dataPath, "png").Replace("\\", "/");
                            EditorPrefs.SetString("MuseStreamingImageEditorPath", path);

                            if (!string.IsNullOrEmpty(path))
                            {
                                File.Copy(path, Application.streamingAssetsPath + "/Images/StreamingImgs/" + id + ".png", true);
                                AssetDatabase.Refresh();
                                if (Data.Textures.ContainsKey(id))
                                    Data.Textures.Remove(id);
                            }
                        }
                    }
                }
                
                if (!Data.Textures.ContainsKey(id))
                {
                    var tWWW = new WWW(AudioManager.GetStreamingPath() + path);
                    while (!tWWW.isDone) ;
                    if (tWWW.texture != null)
                        Data.Textures.Add(id, tWWW.texture);
                }
            }
            EditorGUILayout.EndScrollView();
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
}