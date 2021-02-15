using UnityEngine;
using UnityEditor;

using Muse.Editors.Dialogs;
using Muse.Editors.States;
using Muse.Editors.Quests;
using Muse.Editors.Audio;
using Muse.Editors.Popups;
using Muse.Editors.Smartword;
using Muse.Editors.GameFlags;
using Muse.Editors.SaveGames;
using Muse.Editors.Modules;
using Muse.Editors.StreamingImages;
using Muse.Editors.UserFlags;

using System.IO;
using System;

using UnityEditor.Callbacks;

namespace Muse.Editors
{

    [InitializeOnLoad]
    public class MuseEditor
    {
        public const string EditorDataPath = "Assets/Muse/Editor/Data/";

        public const string GamePathRaw = "Muse/Game/";
        public const string GameDataPathRaw = "Muse/Game/Data/";
        public const string GamePathCompiledRaw = "Assets/Muse/Game/";
        public const string GameDataPathCompiled = "Assets/Muse/Game/Data/";

        public delegate void EditorEvent();
        public static EditorEvent OnStateEditorCreateScene;


        static MuseEditor()
        {
            // init all editors
            if (DialogEditor.Instance != null)
                DialogEditor.Init();
            if (StateEditor.Instance != null)
                StateEditor.Init();
            if (QuestEditor.Instance != null)
                QuestEditor.Init();
            if (AudioEditor.Instance != null)
                AudioEditor.Init();
            if (PopupEditor.Instance != null)
                PopupEditor.Init();
            if (SmartwordsEditor.Instance != null)
                SmartwordsEditor.Init();
            if (GameFlagEditor.Instance != null)
                GameFlagEditor.Init();

            Debug.Log("Top Level Muse Editor ctor - ??? is this ever called ???");

            if (!System.IO.Directory.Exists(EditorDataPath))
                System.IO.Directory.CreateDirectory(EditorDataPath);

            if (!System.IO.Directory.Exists(GamePathRaw))
                System.IO.Directory.CreateDirectory(GamePathRaw);

            if (!System.IO.Directory.Exists(GameDataPathRaw))
                System.IO.Directory.CreateDirectory(GameDataPathRaw);

            if (!System.IO.Directory.Exists(GamePathCompiledRaw))
                System.IO.Directory.CreateDirectory(GamePathCompiledRaw);

            if (!System.IO.Directory.Exists(GameDataPathCompiled))
                System.IO.Directory.CreateDirectory(GameDataPathCompiled);

            DialogEditor.Setup();
            GameFlagEditor.Setup();
            ModulesEditor.Setup();
            PopupEditor.Setup();
            QuestEditor.Setup();
            SaveGameEditor.Setup();
            SmartwordsEditor.Setup();
            StateEditor.Setup();
            StreamingImageEditor.Setup();
            UserFlagEditor.Setup();
            AudioEditor.Setup();
        }

        [MenuItem("Muse/Compiler/Compile Data")]
        static void Compile()
        {
            if (Directory.Exists(GameDataPathCompiled))
            {
                Directory.Delete(GameDataPathCompiled, true);
            }

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(GameDataPathRaw, "*",
                SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(GameDataPathRaw, GameDataPathCompiled));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(GameDataPathRaw, "*.*",
                SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(GameDataPathRaw, GameDataPathCompiled), true);
            }

            AssetDatabase.Refresh();
        }

        [DidReloadScripts]
        static void OnReloadScripts()
        {
            var classes = Utils.GetDerivedTypes<BaseMuseEditorWindow>();
            //
            for (var i = 1; i < classes.Count; i++)
            {
                var clz = classes[i];
                var c = (BaseMuseEditorWindow) System.Activator.CreateInstance(clz);
                
                c.ReloadScript();
            }
                
        }
    }

    public class ReloadScriptsAttribute : Attribute
    {

    }

    public class SetupEditorDirectoriesAttribute : Attribute
    {

    }
}