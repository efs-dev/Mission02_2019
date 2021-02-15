using UnityEditor;
using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

using Muse.Editors.Utility;
namespace Muse.Editors.Popups
{
    [System.Serializable]
    [PopupTemplate]
    public class TitlePopupTemplate : PopupTemplate
    {
        public string Text = "";

        public string OnOpen = "";
        public string OnClose = "";
        
        public override void GenerateVO(string path)
        {
            AmazonServices.GenerateAudio(path, new List<AmazonAudioRequest>() { new AmazonAudioRequest() { Id = Id + "_Text", Text = Text } });
        }

        public override int GetHashCode()
        {
            return Utils.CombineHash(Id.GetHashCode(), Text.GetHashCode(), RunCloseFirst.GetHashCode(), OnOpen.GetHashCode(), OnClose.GetHashCode());
        }

        public override string Serialize()
        {
            return Id + DELIMITER + Text + DELIMITER + OnOpen + DELIMITER + OnClose + DELIMITER + RunCloseFirst.ToString().ToLower();
        }

        public override void Deserialize(string data)
        {
            var items = data.Split(new string[] { DELIMITER }, StringSplitOptions.None);

            Id = items[0];
            Text = items[1];
            OnOpen = items[2];
            OnClose = items[3];
            RunCloseFirst = bool.Parse(items[4]);
        }

        public override void ChangeId(string newId, Action createMemento)
        {
            createMemento();
            Id = newId;
        }

        public override void OnGUI(Action createMemento, Action<Vector2, string, Vector2> infoButton, Func<string, bool> isValidId)
        {
            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar))
            {
                GUILayout.Space(5);
                using (new EditorGUILayout.HorizontalScope())
                {
                    infoButton(new Vector2(400, 50), "The Id of the popup must be unique. This is used to launch the popup.", Vector2.zero);
                    EditorGUILayout.LabelField("Id:", GUILayout.Width(150));
                    if (GUILayout.Button(Id, EditorStyles.toolbarButton))
                    {
                        var window = new PopupIdWindowEditor(Id, isValidId, (newId) => ChangeId(newId, createMemento));
                        PopupWindow.Show(new Rect(175, -55, 100, 100), window);
                    }
                }
                using (new EditorGUILayout.HorizontalScope())
                {
                    infoButton(new Vector2(400, 50), "The main text of the popup.", Vector2.zero);
                    EditorGUILayout.LabelField("Text:", GUILayout.Width(150));
                    var newText = EditorGUILayout.TextArea(Text);

                    if (newText != Text)
                        createMemento();

                    Text = newText;
                }

                using (new EditorGUILayout.HorizontalScope())
                {
                    infoButton(new Vector2(400, 50), "Runs when the popup is open.", Vector2.zero);
                    EditorGUILayout.LabelField("OnOpen:", GUILayout.Width(150));
                    var newOnOpen = EditorGUILayout.TextArea(OnOpen);
                    EditorGUILayout.LabelField("C#", GUILayout.Width(25));
                    if (newOnOpen != OnOpen)
                        createMemento();

                    OnOpen = newOnOpen;
                }

                using (new EditorGUILayout.HorizontalScope())
                {
                    infoButton(new Vector2(400, 50), "Close the popup and then run the onCloses script, or run the script and then close the popup?", Vector2.zero);
                    EditorGUILayout.LabelField("Close Before Script:", GUILayout.Width(150));

                    var newRunCloseFirst = EditorGUILayout.Toggle(RunCloseFirst);
                    if (newRunCloseFirst != RunCloseFirst)
                        createMemento();

                    RunCloseFirst = newRunCloseFirst;
                }
                using (new EditorGUILayout.HorizontalScope())
                {
                    infoButton(new Vector2(400, 50), "Runs when the popup is closed.", Vector2.zero);
                    EditorGUILayout.LabelField("OnClose:", GUILayout.Width(150));
                    var newOnClose = EditorGUILayout.TextArea(OnClose);
                    EditorGUILayout.LabelField("C#", GUILayout.Width(25));
                    if (newOnClose != OnClose)
                        createMemento();

                    OnClose = newOnClose;
                }

                GUILayout.Space(5);
            }
        }

        public override void FromClassWriter(ClassWriter classWriter)
        {
            var method = classWriter.GetMethod(classWriter.Name);
            var bodyLines = method.Lines.ToList();
            Id = bodyLines.Find(x => x.Contains("///Id")).Replace("///Id", "").Trim();
            Text = bodyLines.Find(x => x.Contains("///Text")).Replace("///Text", "").Replace("\\n", "\n").Trim();
            try
            {
                RunCloseFirst = bool.Parse(bodyLines.Find(x => x.Contains("///RunCloseFirst")).Replace("///RunCloseFirst", "").Trim());
            }
            catch (Exception ex)
            {
                Debug.LogError(Id + ", " + ex.Message);
            }
            
            if (classWriter.GetMethod("OnOpenMethod") != null)
                OnOpen = classWriter.GetMethod("OnOpenMethod").GetText();
            if (classWriter.GetMethod("OnCloseMethod") != null)
                OnClose = classWriter.GetMethod("OnCloseMethod").GetText();
        }

        public override ClassWriter GetClassWriter()
        {
            var classWriter = new ClassWriter();
            classWriter.Name = "PopupData_" + Id + " : PopupData";
            classWriter.IsPublic = true;

            classWriter.AddTopLine("using UnityEngine;");
            classWriter.AddTopLine("using System;");
            classWriter.AddTopLine("using System.Collections;");
            classWriter.AddTopLine("using System.Collections.Generic;");

            var constructor = classWriter.CreateMethodWriter();
            constructor.Name = "PopupData_" + Id;
            constructor.VisibilityType = MethodWriter.VisibilityTypes.Public;
            constructor.AddLine("///Id " + Id);
            constructor.AddLine("Id = \"" + Id + "\";");
            constructor.AddLine("///Type " + GetType().Name);
            constructor.AddLine("Type = \"" + GetType().Name + "\";");
            constructor.AddLine("///Text " + Text.Replace("\n", "\\n"));
            constructor.AddLine("Text = \"" + Text.Replace("\n", "\\n") + "\";");
            constructor.AddLine("///RunCloseFirst " + RunCloseFirst.ToString().ToLower());
            constructor.AddLine("RunCloseFirst = " + RunCloseFirst.ToString().ToLower() + ";");

            if (!string.IsNullOrEmpty(OnOpen))
            {
                if (OnOpen.Contains("yield"))
                {
                    constructor.AddLine("OnOpenBlocking = OnOpenMethod;");

                    var selectionFunc = classWriter.CreateMethodWriter();
                    selectionFunc.Name = "OnOpenMethod";
                    selectionFunc.ReturnType = "IEnumerator";
                    selectionFunc.VisibilityType = MethodWriter.VisibilityTypes.Public;

                    selectionFunc.AddLines(OnOpen.Split('\n'));
                }
                else
                {
                    constructor.AddLine("OnOpen = OnOpenMethod;");

                    var selectionFunc = classWriter.CreateMethodWriter();
                    selectionFunc.Name = "OnOpenMethod";
                    selectionFunc.ReturnType = "void";
                    selectionFunc.VisibilityType = MethodWriter.VisibilityTypes.Public;
                    selectionFunc.AddLines(OnOpen.Split('\n'));
                }
            }

            if (!string.IsNullOrEmpty(OnClose))
            {
                if (OnClose.Contains("yield"))
                {
                    constructor.AddLine("OnCloseBlocking = OnCloseMethod;");

                    var selectionFunc = classWriter.CreateMethodWriter();
                    selectionFunc.Name = "OnCloseMethod";
                    selectionFunc.ReturnType = "IEnumerator";
                    selectionFunc.VisibilityType = MethodWriter.VisibilityTypes.Public;

                    selectionFunc.AddLines(OnClose.Split('\n'));
                }
                else
                {
                    constructor.AddLine("OnClose = OnCloseMethod;");

                    var selectionFunc = classWriter.CreateMethodWriter();
                    selectionFunc.Name = "OnCloseMethod";
                    selectionFunc.ReturnType = "void";
                    selectionFunc.VisibilityType = MethodWriter.VisibilityTypes.Public;
                    selectionFunc.AddLines(OnClose.Split('\n'));
                }
            }

            return classWriter;
        }
    }
}