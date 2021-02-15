using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using UnityEngine.Audio;
using System.Linq;
using UnityEditor.Callbacks;
using UnityEditor.SceneManagement;

namespace Muse.Editors.Scenes
{

    [InitializeOnLoad]
    public static class ScenesEditorLauncher
    {
        static ScenesEditorLauncher()
        {
            EditorApplication.playmodeStateChanged -= ScenesEditor.OnPlayModeChanged;
	        EditorApplication.playmodeStateChanged += ScenesEditor.OnPlayModeChanged;
	        //Debug.Log("listening for playmodestatechanged");
        }
    }

    [Serializable]
    public class ScenesEditorEntry
    {
        public bool Autoplay;
        public string Path;
        public string Name;
    }

    public class ScenesEditorData : ScriptableObject
    {
        public bool AutoAddScenes;
        public List<ScenesEditorEntry> Entries = new List<ScenesEditorEntry>();
        public List<ScenesEditorEntry> AllEntries = new List<ScenesEditorEntry>();
        public string PreviousScene;


        public List<string> EditorBuildScenes;

        public Vector2 ScrollPos;
    }

    public class ScenesEditor : EditorWindow
    {
        public static ScenesEditor Instance { get; private set; }

        public static void OnPlayModeChanged()
	    {
		    //Debug.Log("OnPlayModeChanged " + Instance + ", " + Instance.LaunchedThroughEditor);
            if (Instance == null || !Instance.LaunchedThroughEditor)
	            return;
	        

            if (EditorApplication.isPlaying && !EditorApplication.isPlayingOrWillChangePlaymode)
            {
	            //Debug.Log("Starting Play");
                EditorApplication.update += ReloadLastScene;
            }
        }

        static void ReloadLastScene()
        {
            if (EditorApplication.isPlaying)
                return;

	        //Debug.Log("Ending Play");

	        //Debug.Log("active scene: " + EditorSceneManager.GetActiveScene().name + ", " + Instance.Data.PreviousScene);
            EditorApplication.update -= ReloadLastScene;
            if (EditorSceneManager.GetActiveScene().name != Instance.Data.PreviousScene)
            {
                Instance.LaunchedThroughEditor = false;
                if (Instance.Data.AutoAddScenes)
                    EditorBuildSettings.scenes = Instance.Data.EditorBuildScenes.ConvertAll<EditorBuildSettingsScene>(x => new EditorBuildSettingsScene(x, true)).ToArray();

                Debug.Log(Instance.Data.PreviousScene);
                EditorSceneManager.OpenScene(Instance.Data.PreviousScene);
            }
        }

        

        public bool LaunchedThroughEditor;
        public ScenesEditorData Data;

        public Func<string, string, bool> ValidateScenePath = (name, path) => true;

        [MenuItem("Muse/Editors/Utils/Scene Selection")]
        static void Init()
        {
            var window = EditorWindow.GetWindow<ScenesEditor>();
            window.titleContent = new GUIContent("Scene Selection");
            window.Show();

            Instance = window;
            window.Data = ScriptableObject.CreateInstance<ScenesEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "ScenesEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();



            window.FindScenes();
        }

        [DidReloadScripts]
        static void OnReloadScripts()
        {
            var windows = Resources.FindObjectsOfTypeAll<ScenesEditor>();
            if (windows.Length == 0)
                return;
            Instance = windows[0];
            Instance.FindScenes();
        }

        private void FindScenes()
        {
            var files = Directory.GetFiles(Application.dataPath + "/Muse/Game/Scenes", "*.unity", SearchOption.AllDirectories);
            Data.AllEntries = new List<string>(files).ConvertAll<ScenesEditorEntry>(x => new ScenesEditorEntry() { Path = x.Replace(Application.dataPath + "\\", "").Replace("\\", "/"), Name = x.Replace("\\", "/").Substring(x.Replace("\\", "/").LastIndexOf("/") + 1, x.Length - x.Replace("\\", "/").LastIndexOf("/") - 1).Replace(".unity", "") }).FindAll(x => ValidateScenePath(x.Name, x.Path));
        }

        void OnGUI()
        {
            if (Data == null)
                Init();

            Data.ScrollPos = EditorGUILayout.BeginScrollView(Data.ScrollPos);
            // if (!EditorApplication.isPlaying)
            //  Data.AutoAddScenes = GUILayout.Toggle(Data.AutoAddScenes, "Automatically Add All Scenes to Build");

#if USE_MODULES
            Data.AutoAddScenes = false;
#else
            Data.AutoAddScenes = true;
#endif

            var assetBundleNames = new List<string>(AssetDatabase.GetAllAssetBundleNames());
            assetBundleNames.Insert(0, "None");
            for (var i = 0; i < Data.AllEntries.Count; i++)
            {
                var entry = Data.AllEntries[i];
                var path = "Assets/" + entry.Path;
                var assetIndex = path.LastIndexOf("Assets/");
                path = path.Substring(assetIndex, path.Length - assetIndex);

                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
                if (GUILayout.Button("Select", EditorStyles.toolbarButton, GUILayout.Width(40)))
                {
                    Selection.activeObject = AssetDatabase.LoadMainAssetAtPath(path);
                }
                if (!Application.isPlaying && GUILayout.Button("Open", EditorStyles.toolbarButton, GUILayout.Width(40)))
                {
                    if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                    {
                        EditorSceneManager.OpenScene(path);
                    }
                }

                if (!Application.isPlaying && GUILayout.Button("Play", EditorStyles.toolbarButton, GUILayout.Width(40)))
                {
                    // User pressed play -- autoload master scene.
                    Data.PreviousScene = EditorSceneManager.GetActiveScene().path;
                    if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                    {
                        EditorSceneManager.OpenScene(path);
                    }
                    LaunchedThroughEditor = true;
                    if (Data.AutoAddScenes)
                    {
                        Data.EditorBuildScenes = new List<EditorBuildSettingsScene>(EditorBuildSettings.scenes).ConvertAll<string>(x => x.path);
                        EditorBuildSettings.scenes = Data.AllEntries.ConvertAll<EditorBuildSettingsScene>(x =>
                        {
                            var assetPath = "Assets/" + x.Path;
                            var assetPathIndex = assetPath.LastIndexOf("Assets/");
                            assetPath = assetPath.Substring(assetPathIndex, assetPath.Length - assetPathIndex);
                            return new EditorBuildSettingsScene(assetPath, true);
                        }).ToArray();
                        EditorApplication.isPlaying = true;
                    }
                }
                EditorGUILayout.LabelField(entry.Name, GUILayout.Width(200));
                EditorGUILayout.LabelField(path);

                /*
                            Debug.Log(path);
                            var sceneAsset = AssetImporter.GetAtPath(path);
                            int index = assetBundleNames.IndexOf(sceneAsset.assetBundleName);
                            if (index == -1)
                                index = 0;
                            var newIndex = EditorGUILayout.Popup(index, assetBundleNames.ToArray(), GUILayout.Width(100));
                            sceneAsset.assetBundleName = newIndex > 0 ? assetBundleNames[newIndex] : null;
                            */
                EditorGUILayout.EndHorizontal();
            }
            EditorGUILayout.EndScrollView();
        }

        [MenuItem("Assets/Build AssetBundles")]
        public static void BuildAssetBundles()
        {
            BuildPipeline.BuildAssetBundles("Assets/AssetBundles/WebGL", BuildAssetBundleOptions.None, BuildTarget.WebGL);
        }

        public static void BuildPlayer()
        {

        }
    }
}