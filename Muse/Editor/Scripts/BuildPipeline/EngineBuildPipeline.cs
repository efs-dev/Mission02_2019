using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using System.IO;
using System;

using Muse.Editors.States;
namespace Muse.Editors.Build
{
    public class EngineBuildPipeline
    {

        static List<string> GetNonEngineScenes()
        {
            return Utils.GetTypesWith<StateAttribute>().ToList().ConvertAll(x => "Assets/Muse/Game/Scenes/" + x.Name.Replace("State_", "") + ".unity");
        }

        static string[] GetScenes()
        {
            var scenes = GetNonEngineScenes();

            scenes.Insert(0, "Assets/Muse/Game/Scenes/Preloader.unity");
            scenes.Insert(1, "Assets/Muse/Game/Scenes/Engine.unity");

            return scenes.ToArray();
        }

        [MenuItem("Muse/Build/PC64")]
        public static void BuildPC64()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = GetScenes();
            buildPlayerOptions.locationPathName = "Build/PC64/Mission01";
            buildPlayerOptions.target = BuildTarget.StandaloneWindows64;
            buildPlayerOptions.options = BuildOptions.None;
            BuildPipeline.BuildPlayer(buildPlayerOptions);
        }

        [MenuItem("Muse/Build/PC")]
        public static void BuildPC()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = GetScenes();
            buildPlayerOptions.locationPathName = "Build/PC/Mission01";
            buildPlayerOptions.target = BuildTarget.StandaloneWindows;
            buildPlayerOptions.options = BuildOptions.None;
            BuildPipeline.BuildPlayer(buildPlayerOptions);
        }

        [MenuItem("Muse/Build/Mac")]
        public static void BuildMac()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = GetScenes();
            buildPlayerOptions.locationPathName = "Build/Mac/Mission01";
            buildPlayerOptions.target = BuildTarget.StandaloneOSXUniversal;
            buildPlayerOptions.options = BuildOptions.None;
            BuildPipeline.BuildPlayer(buildPlayerOptions);
        }

        [MenuItem("Muse/Build/iOS")]
        public static void BuildiOS()
        {
            PlayerSettings.applicationIdentifier = "com.efs.missionOne";
            PlayerSettings.bundleVersion = "0.0.1";
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = GetScenes();
            buildPlayerOptions.locationPathName = "Build/iOS/Mission01";
            buildPlayerOptions.target = BuildTarget.iOS;
            buildPlayerOptions.options = BuildOptions.AutoRunPlayer;
            BuildPipeline.BuildPlayer(buildPlayerOptions);
        }

        [MenuItem("Muse/Build/WebGL")]
        public static void BuildWebGL()
        {
            if (Directory.Exists("Build/WebGL/Mission01"))
                Directory.Delete("Build/WebGL/Mission01", true);

            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebGL, "USE_MODULES; DOTWEEN_TMP;");
            PlayerSettings.defaultWebScreenWidth = 800;
            PlayerSettings.defaultWebScreenHeight = 600;
            PlayerSettings.WebGL.memorySize = 512;

            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = new string[1] { "Assets/Muse/Game/Scenes/Preloader.unity" };
            buildPlayerOptions.locationPathName = "Build/WebGL/Mission01";
            buildPlayerOptions.target = BuildTarget.WebGL;
            buildPlayerOptions.options = BuildOptions.None;
            
            BuildPipeline.BuildPlayer(buildPlayerOptions);
            
            //////////////////////////////////
            // BUILD THE ASSSET BUNDLES
            //////////////////////////////////

            var stateEditorOpen = StateEditor.Instance != null;
            StateEditor.Init();


            var states = StateEditor.Instance.Data.States;


            if (!stateEditorOpen)
                StateEditor.Instance.Close();

            var buildList = new List<AssetBundleBuild[]>();

			Type type = null; // typeof(ModuleIds)
            var moduleNames = System.Enum.GetNames(type);
            var modules = new Dictionary<string, AssetBundleBuild>();
            var moduleAssets = new Dictionary<string, List<string>>();

            for (var i = 0; i < moduleNames.Length + 2; i++)
            {
                buildList.Add(new AssetBundleBuild[] { new AssetBundleBuild() });
            }


            for (var i = 0; i < buildList.Count - 2; i++)
            {
                buildList[i][0].assetBundleName = moduleNames[i];
                modules.Add(moduleNames[i], buildList[i][0]);
                moduleAssets.Add(moduleNames[i], new List<string>());
                //Debug.Log(i + ", " + buildList[i][0].assetBundleName);
            }

            buildList[buildList.Count - 2][0].assetBundleName = "default";
            buildList[buildList.Count - 1][0].assetBundleName = "scenes";


            for (var i = 0; i < states.Count; i++)
            {
                var state = states[i];

                //Debug.Log("state: " + state.Id);

                for (var j = 0; j < state.ModuleIds.Count; j++)
                {
                    var moduleId = state.ModuleIds[j];
                    var assets = moduleAssets[moduleId];

                    var path = Application.dataPath + "/Muse/Game/States/" + state.Id;
                    var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(file => file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".anim") || file.ToLower().EndsWith(".controller") || file.ToLower().EndsWith(".mat") || file.ToLower().EndsWith(".ttf") || file.ToLower().EndsWith(".asset") || file.ToLower().EndsWith(".wav") || file.ToLower().EndsWith(".ogg") || file.ToLower().EndsWith(".mp3")).ToArray();

                    for (var k = 0; k < files.Length; k++)
                    {
                        var file = files[k].Replace(Application.dataPath, "Assets").Replace("\\", "/");
                        assets.Add(file);
                        //Debug.Log("   - file: " + file);
                    }



                    for (var k = 0; k < state.Characters.Count; k++)
                    {
                        var character = state.Characters[k];
                        var characterName = character.Substring(0, character.LastIndexOf(" ("));
                        path = Application.dataPath + "/Muse/Game/Npcs/" + characterName;

                        files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(file => file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".anim") || file.ToLower().EndsWith(".controller") || file.ToLower().EndsWith(".mat") || file.ToLower().EndsWith(".ttf") || file.ToLower().EndsWith(".asset") || file.ToLower().EndsWith(".wav") || file.ToLower().EndsWith(".ogg") || file.ToLower().EndsWith(".mp3")).ToArray();

                        for (var l = 0; l < files.Length; l++)
                        {
                            var file = files[l].Replace(Application.dataPath, "Assets").Replace("\\", "/");
                            if (assets.Find(x => x == file) == null)
                                assets.Add(file);
                            //Debug.Log("   - file: " + file);
                        }
                    }
                }
            }

            for (var i = 0; i < buildList.Count - 2; i++)
            {
                buildList[i][0].assetNames = moduleAssets[buildList[i][0].assetBundleName].ToArray();
            }


            var guiFiles = Directory.GetFiles(Application.dataPath + "/Muse/Gui", "*.*", SearchOption.AllDirectories).Where(file => file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".anim") || file.ToLower().EndsWith(".controller") || file.ToLower().EndsWith(".mat") || file.ToLower().EndsWith(".ttf") || file.ToLower().EndsWith(".asset") || file.ToLower().EndsWith(".wav") || file.ToLower().EndsWith(".ogg") || file.ToLower().EndsWith(".mp3")).ToArray();
            buildList[buildList.Count - 2][0].assetNames = new string[guiFiles.Length];

            for (var i = 0; i < guiFiles.Length; i++)
            {
                buildList[buildList.Count - 2][0].assetNames[i] = guiFiles[i].Replace(Application.dataPath, "Assets").Replace("\\", "/");
            }

            var scenes = GetNonEngineScenes();
            scenes.Insert(0, "Assets/Muse/Game/Scenes/Engine.unity");
            buildList[buildList.Count - 1][0].assetNames = new string[scenes.Count];
            for (var i = 0; i < scenes.Count; i++)
            {
               // Debug.Log("adding scene to bundle: " + scenes[i]);
                buildList[buildList.Count - 1][0].assetNames[i] = scenes[i];
            }



            var assetBundlePath = "Build/WebGL/Mission01/AssetBundles";
            if (!Directory.Exists(assetBundlePath))
                Directory.CreateDirectory(assetBundlePath);

            for (var i = 0; i < buildList.Count; i++)
            {
                //Debug.Log(buildList[i][0].assetBundleName + ", " + buildList[i][0].assetNames);
                for (var j = 0; j < buildList[i][0].assetNames.Length; j++)
                {
                    //Debug.Log("   - " + buildList[i][0].assetNames[j]);
                }

                var bundlePath = assetBundlePath + "/" + buildList[i][0].assetBundleName + "_bundle";
                if (!Directory.Exists(bundlePath))
                    Directory.CreateDirectory(bundlePath);
                Debug.Log("Creating bundle at path: " + bundlePath + ", " + buildList[i].Length);
                BuildPipeline.BuildAssetBundles(bundlePath, buildList[i], BuildAssetBundleOptions.None, BuildTarget.WebGL);
            }
            
        }

    }
}