using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System.Linq;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Text;

namespace Muse.Editors.CSharpRuntime
{
    [Serializable]
    public class CSharpRuntimeEditorSnippet
    {
        public string Id;
        public string Text;
    }

    [Serializable]
    public class CSharpRuntimeEditorHistoryEntry
    {
        public string Logs;
        public string Text;
    }


    public class CSharpRuntimeEditorData : ScriptableObject
    {
        public Vector2 ScrollPos;
        public string Text;
        public enum Modes { Code, History, Snippets }
        public Modes Mode;

        public List<CSharpRuntimeEditorHistoryEntry> History = new List<CSharpRuntimeEditorHistoryEntry>();
        public List<CSharpRuntimeEditorSnippet> Snippets = new List<CSharpRuntimeEditorSnippet>();
    }

    public class CSharpRuntimeEditor : EditorWindow
    {
        public static CSharpRuntimeEditor Instance { get; private set; }
        

        public CSharpRuntimeEditorData Data;



        [MenuItem("Muse/Editors/Utils/C# Runtime")]
        static void Init()
        {
            var window = EditorWindow.GetWindow<CSharpRuntimeEditor>();
            window.titleContent = new GUIContent("C# Runtime");
            window.Show();
            Instance = window;


            Instance.Data = ScriptableObject.CreateInstance<CSharpRuntimeEditorData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "CSharpRuntimeEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        void OnDestroy()
        {
            Instance = null;
        }

        void OnGUI()
        {
            Instance = this;
            if (Data == null)
                return;



            //EditorGUILayout.BeginVertical(EditorStyles.toolbar);

            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(Screen.width));

            if (GUILayout.Button("Code", EditorStyles.toolbarButton))
            {
                EditorGUI.FocusTextInControl(null);
                Data.Mode = CSharpRuntimeEditorData.Modes.Code;
            }
            if (GUILayout.Button("History", EditorStyles.toolbarButton))
            {
                EditorGUI.FocusTextInControl(null);
                Data.Mode = CSharpRuntimeEditorData.Modes.History;
            }
            if (GUILayout.Button("Snippets", EditorStyles.toolbarButton))
            {
                EditorGUI.FocusTextInControl(null);
                Data.Mode = CSharpRuntimeEditorData.Modes.Snippets;
            }
            EditorGUILayout.EndHorizontal();

            GUILayout.Space(5);
            switch (Data.Mode)
            {
                case CSharpRuntimeEditorData.Modes.Code:
                    OnGUICodeEditor();
                    break;
                case CSharpRuntimeEditorData.Modes.History:
                    OnGUIHistory();
                    break;
                case CSharpRuntimeEditorData.Modes.Snippets:
                    OnGUISnippets();
                    break;
            }
            GUILayout.Space(5);
        }

        private Vector2 _codePos;
        void OnGUICodeEditor()
        {
            _codePos = EditorGUILayout.BeginScrollView(_codePos);
            Data.Text = EditorGUILayout.TextArea(Data.Text, GUILayout.ExpandHeight(true));
            EditorGUILayout.EndScrollView();
            GUILayout.Space(5);
            if (GUILayout.Button("Run", EditorStyles.toolbarButton) && !string.IsNullOrEmpty(Data.Text))
            {
                Data.History.Add(Run(Data.Text));
                Data.Text = "";
                EditorGUI.FocusTextInControl(null);
            }
        }

        CSharpRuntimeEditorHistoryEntry Run(string text)
        {
            var historyEntry = new CSharpRuntimeEditorHistoryEntry() { Text = text, Logs = "" };
            UnityEngine.Application.LogCallback onLog = (condition, stackTrace, type) => { historyEntry.Logs += condition; };
            if (Application.isPlaying)
            {
                Application.logMessageReceived += onLog;  
                
                MuseEngine.GetInstance().StartCoroutine(RunCodeCoroutine(text, () => Application.logMessageReceived -= onLog));
            }
            else
            {
                Application.logMessageReceived += onLog;
                RunCode(text);
                Application.logMessageReceived -= onLog;
            }

            return historyEntry;
        }

        void OnGUIHistory()
        {

            Data.ScrollPos = EditorGUILayout.BeginScrollView(Data.ScrollPos);
            for (var i = Data.History.Count - 1; i >= 0; i--)
            {
                EditorGUILayout.BeginVertical(EditorStyles.toolbar);
                GUILayout.Space(5);
                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
                var entry = Data.History[i];
                if (GUILayout.Button("Run", EditorStyles.toolbarButton, GUILayout.Width(50)) && !string.IsNullOrEmpty(entry.Text))
                {
                    Data.History.Add(Run(entry.Text));
                }
                if (GUILayout.Button("Snippet", EditorStyles.toolbarButton, GUILayout.Width(100)) && !string.IsNullOrEmpty(entry.Text))
                {
                    var snippet = new CSharpRuntimeEditorSnippet() { Id = "Snippet", Text = entry.Text };
                    Data.Snippets.Add(snippet);
                }
                if (GUILayout.Button("Code", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    Data.Text = entry.Text;
                    Data.Mode = CSharpRuntimeEditorData.Modes.Code;
                    EditorGUI.FocusTextInControl(null);
                }
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                {
                    Data.History.RemoveAt(i);
                }
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(5);
                EditorGUILayout.LabelField("Code", EditorStyles.boldLabel);
                EditorGUILayout.LabelField(entry.Text, EditorStyles.wordWrappedLabel);
                EditorGUILayout.LabelField("Logs", EditorStyles.boldLabel);
                EditorGUILayout.LabelField(entry.Logs, EditorStyles.wordWrappedLabel);
                EditorGUILayout.EndVertical();



            }
            EditorGUILayout.EndScrollView();
            GUILayout.Space(5);
            if (GUILayout.Button("Clear", EditorStyles.toolbarButton))
            {
                Data.History.Clear();
            }
        }

        void OnGUISnippets()
        {
            Data.ScrollPos = EditorGUILayout.BeginScrollView(Data.ScrollPos);
            //var rect = GUILayoutUtility.GetLastRect();

            for (var i = Data.Snippets.Count - 1; i >= 0; i--)
            {
                GUI.backgroundColor = (i - Data.History.Count) % 2 == 0 ? new Color(0.9f, 0.9f, 0.9f) : Color.white;
                EditorGUILayout.BeginVertical(EditorStyles.toolbar);
                GUI.backgroundColor = Color.white;
                GUILayout.Space(5);
                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
                var snippet = Data.Snippets[i];
                var entry = snippet.Text;
                if (GUILayout.Button("Run", EditorStyles.toolbarButton, GUILayout.Width(50)) && !string.IsNullOrEmpty(entry))
                {
                    Data.History.Add(Run(entry));
                }
                if (GUILayout.Button("Code", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    Data.Text = entry;
                    Data.Mode = CSharpRuntimeEditorData.Modes.Code;
                    EditorGUI.FocusTextInControl(null);
                }
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                {
                    Data.Snippets.RemoveAt(i);
                }
                EditorGUILayout.EndHorizontal();
                GUILayout.Space(5);
                EditorGUILayout.LabelField("Code", EditorStyles.boldLabel);
                EditorGUILayout.LabelField(entry, EditorStyles.wordWrappedLabel);
                EditorGUILayout.EndVertical();



            }
            EditorGUILayout.EndScrollView();
        }

        IEnumerator RunCodeCoroutine(string text, Action callback)
        {
            var assembly = Compile(@"using UnityEngine;
                using UnityEngine.UI;
                using UnityEditor;
                using System.Collections;
                using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.IO;
                class RuntimeScript {
                  public static IEnumerator Execute(string[] args) {" + text + @"
                    " + (Application.isPlaying ? "yield return null;" : "") + @"}
                }");


            var method = assembly.GetType("RuntimeScript").GetMethod("Execute");
            var del = (Func<IEnumerator>)Delegate.CreateDelegate(typeof(Func<IEnumerator>), method);
            yield return del.Invoke();
            callback();
        }

        void RunCode(string text)
        {
            var assembly = Compile(@"using UnityEngine;
                using UnityEngine.UI;
                using UnityEditor;
                using System.Collections;
                using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.IO;
                class RuntimeScript {
                  public static void Execute(string[] args) {" + text + @"}
                }");

            var method = assembly.GetType("RuntimeScript").GetMethod("Execute");
            var del = (Action)Delegate.CreateDelegate(typeof(Action), method);
            del.Invoke();
        }

        public Assembly Compile(string source)
        {
            var provider = new CSharpCodeProvider();
            var param = new CompilerParameters();

            // Add ALL of the assembly references
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                param.ReferencedAssemblies.Add(assembly.Location);
            }

            // Generate a dll in memory
            param.GenerateExecutable = false;
            param.GenerateInMemory = true;

            // Compile the source
            var result = provider.CompileAssemblyFromSource(param, source);

            if (result.Errors.Count > 0)
            {
                var msg = new StringBuilder();
                foreach (CompilerError error in result.Errors)
                {
                    msg.AppendFormat("Error ({0}): {1}\n",
                        error.ErrorNumber, error.ErrorText);
                }
                throw new Exception(msg.ToString());
            }

            // Return the assembly
            return result.CompiledAssembly;
        }

    }
}