using UnityEditor;
using System;
using System.IO;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

using Muse.Editors.Utility;
namespace Muse.Editors.Popups
{

    [System.Serializable]
    [PopupTemplate]
    public class ImagePopupTemplate : PopupTemplate
    {
        public string Header = "";
        public string Text = "";
        public string ImagePath = "";
        public string OnOpen = "";
        public string OnClose = "";

        public List<string> Responses = new List<string>() { "Close" };
        public List<string> ResponsesConditions = new List<string>() { "" };
        public List<string> ResponsesOnSelect = new List<string>() { "Actions.ClosePopup();" };

        private Texture2D Texture;
        private string TemporaryImagePath = "";

        public override void GenerateVO(string path)
        {
            var requests = new List<AmazonAudioRequest>() { new AmazonAudioRequest() { Id = Id + "_Header", Text = Header }, new AmazonAudioRequest() { Id = Id + "_Text", Text = Text } };

            for (var i = 0; i < Responses.Count; i++)
            {
                if (string.IsNullOrEmpty(Responses[i]))
                    continue;

                requests.Add(new AmazonAudioRequest() { Id = Id + "_r" + i, Text = Responses[i] });
            }
            AmazonServices.GenerateAudio(path, requests);
        }


        public override int GetHashCode()
        {
            var rHash = Responses.Hash();
            var rcHash = ResponsesConditions.Hash();
            var rosHash = ResponsesOnSelect.Hash();

            return Utils.CombineHash(Id.GetHashCode(), Header.GetHashCode(), Text.GetHashCode(), RunCloseFirst.GetHashCode(), ImagePath.GetHashCode(), rHash, rcHash, rosHash, TemporaryImagePath.GetHashCode(), OnOpen.GetHashCode(), OnClose.GetHashCode());
        }

        public override string Serialize()
        {
            var data = Id + DELIMITER + Text + DELIMITER + ImagePath + DELIMITER + Header + DELIMITER + TemporaryImagePath;

            for (var i = 0; i < Responses.Count; i++)
            {
                data += DELIMITER + Responses[i] + DELIMITER + ResponsesConditions[i] + DELIMITER + ResponsesOnSelect[i];
            }

            data += DELIMITER + OnOpen + DELIMITER + OnClose + DELIMITER + RunCloseFirst.ToString().ToLower();
            return data;
        }

        public override void Deserialize(string data)
        {
            var items = data.Split(new string[] { DELIMITER }, StringSplitOptions.None);

            Id = items[0];
            Text = items[1];
            ImagePath = items[2];
            Header = items[3];
            TemporaryImagePath = items[4];

            Responses.Clear();
            ResponsesConditions.Clear();
            ResponsesOnSelect.Clear();

            var index = 0;
            for (var i = 5; i < items.Length-3; i += 3)
            {
                Responses.Add(items[i]);
                ResponsesConditions.Add(items[i + 1]);
                ResponsesOnSelect.Add(items[i + 2]);
                index++;
            }//


            OnOpen = items[items.Length-3];
            OnClose = items[items.Length-2];
            RunCloseFirst = bool.Parse(items[items.Length - 1]);
        }

        public override void OnDelete()
        {
            var image = "/Images/Popups/" + OriginalId + "_image.png";
            if (File.Exists(Application.streamingAssetsPath + image))
                File.Delete(Application.streamingAssetsPath + image);
        }

        public override void OnSave()
        {
            if (string.IsNullOrEmpty(TemporaryImagePath) && string.IsNullOrEmpty(ImagePath))
            {
                var image = "/Images/Popups/" + OriginalId + "_image.png";

                if (File.Exists(Application.streamingAssetsPath + image))
                    File.Delete(Application.streamingAssetsPath + image);
            }

            if (OriginalId != Id)
            {
                var image = "/Images/Popups/" + OriginalId + "_image.png";
                var newImagePath = "/Images/Popups/" + Id + "_image.png";

                Debug.Log("original image path: " + image + ", " + File.Exists(Application.streamingAssetsPath + image));
                Debug.Log("new image path: " + newImagePath);
                if (File.Exists(Application.streamingAssetsPath + image))
                {
                    File.Move(Application.streamingAssetsPath + image, Application.streamingAssetsPath + newImagePath);
                }
                if (!string.IsNullOrEmpty(ImagePath))
                    ImagePath = newImagePath;
            }

            if (!string.IsNullOrEmpty(TemporaryImagePath))
            {
                var index = TemporaryImagePath.LastIndexOf("/") + 1;
                var name = Id + "_image.png";
                ImagePath = "/Images/Popups/" + name;
                Debug.Log(ImagePath);
                var newPath = Application.streamingAssetsPath + "/Images/Popups/" + name;
                File.Copy(TemporaryImagePath, newPath, true);

                TemporaryImagePath = "";
            }



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
                        PopupWindow.Show(new Rect(190, -55, 100, 100), window);
                    }
                }

                using (new EditorGUILayout.HorizontalScope())
                {
                    infoButton(new Vector2(400, 50), "The header is an optional label above the text.", Vector2.zero);
                    EditorGUILayout.LabelField("Header [optional]:", GUILayout.Width(150));
                    var newHeader = EditorGUILayout.TextArea(Header);

                    if (newHeader != Header)
                        createMemento();

                    Header = newHeader;
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

                GUILayout.Space(2);

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


            GUILayout.Space(18);

            using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar))
            {
                GUILayout.Space(5);
                using (new EditorGUILayout.HorizontalScope())
                {
                    infoButton(new Vector2(400, 50), "Select the popup's image. The selected file will be copied to the appropriate directory (StreamingAssets/Images/Popups) and renamed [Id]_image.png.", Vector2.zero);
                    EditorGUILayout.LabelField("Image:", GUILayout.Width(150));
                    EditorGUILayout.LabelField(ImagePath);

                }
                using (new EditorGUILayout.HorizontalScope())
                {
                    GUILayout.Space(155);
                    if (GUILayout.Button(string.IsNullOrEmpty(ImagePath) ? "Add Image" : "Replace Image", EditorStyles.toolbarButton, GUILayout.Width(200)))
                    {
                        var path = EditorUtility.OpenFilePanel("Select Image", EditorPrefs.HasKey("MuseImagePopupTemplatePath") ? EditorPrefs.GetString("MuseImagePopupTemplatePath") : Application.dataPath, "png").Replace("\\", "/");
                        EditorPrefs.SetString("MuseImagePopupTemplatePath", path);

                        if (!string.IsNullOrEmpty(path))
                        {
                            TemporaryImagePath = path;
                            ImagePath = "";

                            Debug.Log(TemporaryImagePath);
                            var tWWW = new WWW("file:" + TemporaryImagePath);
                            while (!tWWW.isDone) ;
                            Texture = tWWW.texture;
                            AssetDatabase.Refresh();
                        }
                    }
                    if ((!string.IsNullOrEmpty(ImagePath) || !string.IsNullOrEmpty(TemporaryImagePath)) && GUILayout.Button("Delete", EditorStyles.toolbarButton, GUILayout.Width(100)))
                    {
                        TemporaryImagePath = "";
                        ImagePath = "";
                        Texture = null;
                    }
                }
                if (!string.IsNullOrEmpty(ImagePath) && Texture == null)
                {
                    var tWWW = new WWW(AudioManager.GetStreamingPath() + ImagePath);
                    while (!tWWW.isDone) ;
                    Texture = tWWW.texture;
                }

                if (Texture != null)
                {
                    var rect = GUILayoutUtility.GetLastRect();
                    EditorGUI.DrawPreviewTexture(new Rect(165, rect.y + 20, 200, 200), Texture);
                    GUILayout.Space(210);
                    using (new EditorGUILayout.HorizontalScope())
                    {
                        infoButton(new Vector2(400, 50), "The resolution of the image will directory affect the layout of the popup.", Vector2.zero);
                        EditorGUILayout.LabelField("Resolution:", GUILayout.Width(150));
                        EditorGUILayout.LabelField(Texture.width + "x" + Texture.height + " px");
                    }
                }
                GUILayout.Space(5);
            }

            GUILayout.Space(18);

            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
            {
                infoButton(new Vector2(400, 50), "A response is an option the user can select. There must be at least one response (ie: Done)", Vector2.zero);
                if (GUILayout.Button("Create Response", EditorStyles.toolbarButton, GUILayout.Width(150)))
                {
                    createMemento();
                    Responses.Add("");
                    ResponsesConditions.Add("");
                    ResponsesOnSelect.Add("");
                }
                GUILayout.FlexibleSpace();
            }

            for (var i = 0; i < Responses.Count; i++)
            {
                var response = Responses[i];
                var responseCondition = ResponsesConditions[i];
                var responseSelect = ResponsesOnSelect[i];

                using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
                {
                    EditorGUILayout.LabelField("R" + i, EditorStyles.boldLabel, GUILayout.Width(150));
                    GUILayout.FlexibleSpace();
                    if (i > 0 && GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(40)))
                    {
                        createMemento();
                        Responses.RemoveAt(i);
                        ResponsesConditions.RemoveAt(i);
                        ResponsesOnSelect.RemoveAt(i);

                        i--;
                        continue;
                    }
                }

                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar))
                {
                    GUILayout.Space(5);
                    using (new EditorGUILayout.HorizontalScope())
                    {
                        infoButton(new Vector2(400, 50), "The text of the user's choice.", Vector2.zero);
                        EditorGUILayout.LabelField("Text:", GUILayout.Width(150));
                        var newResponseText = EditorGUILayout.TextArea(response);

                        if (newResponseText != response)
                            createMemento();

                        Responses[i] = newResponseText;
                    }
                    if (i > 0 || Responses.Count > 1)
                    {
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            infoButton(new Vector2(400, 50), "Whether or not this response is displayed. Return true or false.", Vector2.zero);
                            EditorGUILayout.LabelField("Condition:", GUILayout.Width(150));
                            var newResponseCondition = EditorGUILayout.TextArea(responseCondition);

                            if (newResponseCondition != responseCondition)
                                createMemento();

                            ResponsesConditions[i] = newResponseCondition;

                            EditorGUILayout.LabelField("C#", GUILayout.Width(25));
                        }
                    }

                    using (new EditorGUILayout.HorizontalScope())
                    {
                        infoButton(new Vector2(400, 50), "The code to run if this response is selected.", Vector2.zero);
                        EditorGUILayout.LabelField("OnSelect:", GUILayout.Width(150));
                        var newResponseSelect = EditorGUILayout.TextArea(responseSelect);

                        if (newResponseSelect != responseSelect)
                            createMemento();

                        ResponsesOnSelect[i] = newResponseSelect;
                        EditorGUILayout.LabelField("C#", GUILayout.Width(25));
                    }
                    GUILayout.Space(5);
                }
            }
        }

        public override void FromClassWriter(ClassWriter classWriter)
        {
            var method = classWriter.GetMethod(classWriter.Name);
            var bodyLines = method.Lines.ToList();

            Id = bodyLines.Find(x => x.Contains("///Id")).Replace("///Id", "").Trim();
            Text = bodyLines.Find(x => x.Contains("///Text")).Replace("///Text", "").Replace("\\n", "\n").Trim();
            Header = bodyLines.Find(x => x.Contains("///Header")).Replace("///Header", "").Trim();
            ImagePath = bodyLines.Find(x => x.Contains("///ImagePath")).Replace("///ImagePath", "").Trim();
            RunCloseFirst = bool.Parse(bodyLines.Find(x => x.Contains("///RunCloseFirst")).Replace("///RunCloseFirst", "").Trim());


            if (classWriter.GetMethod("OnOpenMethod") != null)
                OnOpen = classWriter.GetMethod("OnOpenMethod").GetText();
            if (classWriter.GetMethod("OnCloseMethod") != null)
                OnClose = classWriter.GetMethod("OnCloseMethod").GetText();

            Responses.Clear();
            ResponsesConditions.Clear();
            ResponsesOnSelect.Clear();
            /*
            for (var i = 0; i < data.Responses.Count; i++)
            {
                var response = data.Responses[i];
                
                if (data.ResponseConditions[i] != null)
                    Debug.Log("response cond: " + i + ", " + data.ResponseConditions[i].Method.Name);
                var condMethod = data.ResponseConditions[i] != null ? classWriter.GetMethod(data.ResponseConditions[i].Method.Name) : null;
                var selMethod = data.ResponseSelections[i] != null ? classWriter.GetMethod(data.ResponseSelections[i].Method.Name) : data.ResponseSelectionsBlocking[i] != null ? classWriter.GetMethod(data.ResponseSelectionsBlocking[i].Method.Name) : null;

                var responseCondition = condMethod != null ? condMethod.GetText() : "";
                var responseSelection = selMethod != null ? selMethod.GetText() : "";

                Responses.Add(response);
                ResponsesConditions.Add(responseCondition);
                ResponsesOnSelect.Add(responseSelection);
            }
            */

            var responsesText = bodyLines.Find(x => x.Contains("///Responses")).Replace("///Responses", "").Trim();
            List<string> responses = null;
            if (responsesText.Length == 0)
                responses = new List<string>();
            else
                responses = new List<string>(responsesText.Split(';'));

            for (var i = 0; i < responses.Count; i++)
            {
                var response = responses[i];
                var responseCondition = classWriter.GetMethod("OnResponseCondition" + i);
                var responseConditionText = responseCondition == null ? "" : responseCondition.GetText();
                var responseSelect = classWriter.GetMethod("OnResponseSelection" + i);
                var responseSelectText = responseSelect == null ? "" : responseSelect.GetText();

                //Debug.Log("response " + i);
                //Debug.Log(response);
                //Debug.Log(responseConditionText);
                //Debug.Log(responseSelectText);


                Responses.Add(response);
                ResponsesConditions.Add(responseConditionText);
                ResponsesOnSelect.Add(responseSelectText);
            }
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
            // Debug.Log("GetClassWriter " + this + ", " + this.Id + ", " + GetType());
            constructor.AddLine("///Type " + GetType().Name);
            constructor.AddLine("Type = \"" + GetType().Name + "\";");
            constructor.AddLine("///Text " + Text.Replace("\n", "\\n"));
            constructor.AddLine("Text = \"" + Text.Replace("\n", "\\n") + "\";");
            constructor.AddLine("///Header " + Header);
            constructor.AddLine("Header = \"" + Header + "\";");
            constructor.AddLine("///ImagePath " + ImagePath);
            constructor.AddLine("ImagePath = \"" + ImagePath + "\";");
            // Debug.Log("responses: " + Responses.Count);
            constructor.AddLine("///Responses " + (Responses.Count == 0 ? "" : Responses.Aggregate((x, next) => x += ";" + next)));
            constructor.AddLine("Responses = new List<string>() {" + Responses.ConvertAll(x => "\"" + x + "\"").Aggregate((x, next) => x + ", " + next) + "};");

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


            for (var i = 0; i < Responses.Count; i++)
            {
                if (!string.IsNullOrEmpty(ResponsesConditions[i]))
                {
                    constructor.AddLine("ResponseConditions.Add(OnResponseCondition" + i + ");");

                    var conditionFunc = classWriter.CreateMethodWriter();
                    conditionFunc.Name = "OnResponseCondition" + i;
                    conditionFunc.VisibilityType = MethodWriter.VisibilityTypes.Public;
                    conditionFunc.ReturnType = "bool";
                    if (!string.IsNullOrEmpty(ResponsesConditions[i]))
                        conditionFunc.AddLines(ResponsesConditions[i].Split('\n'));
                }
                else
                {
                    constructor.AddLine("ResponseConditions.Add(null);");
                }

                if (!string.IsNullOrEmpty(ResponsesOnSelect[i]))
                {
                    if (ResponsesOnSelect[i].Contains("yield"))
                    {
                        constructor.AddLine("ResponseSelectionsBlocking.Add(OnResponseSelection" + i + ");");
                        constructor.AddLine("ResponseSelections.Add(null);");

                        var selectionFunc = classWriter.CreateMethodWriter();
                        selectionFunc.Name = "OnResponseSelection" + i;
                        selectionFunc.ReturnType = "IEnumerator";
                        selectionFunc.VisibilityType = MethodWriter.VisibilityTypes.Public;
                        if (!string.IsNullOrEmpty(ResponsesOnSelect[i]))
                            selectionFunc.AddLines(ResponsesOnSelect[i].Split('\n'));
                    }
                    else
                    {
                        constructor.AddLine("ResponseSelections.Add(OnResponseSelection" + i + ");");
                        constructor.AddLine("ResponseSelectionsBlocking.Add(null);");

                        var selectionFunc = classWriter.CreateMethodWriter();
                        selectionFunc.Name = "OnResponseSelection" + i;
                        selectionFunc.ReturnType = "void";
                        selectionFunc.VisibilityType = MethodWriter.VisibilityTypes.Public;
                        if (!string.IsNullOrEmpty(ResponsesOnSelect[i]))
                            selectionFunc.AddLines(ResponsesOnSelect[i].Split('\n'));
                    }

                }
                else
                {
                    constructor.AddLine("ResponseSelections.Add(null);");
                    constructor.AddLine("ResponseSelectionsBlocking.Add(null);");
                }
            }


            return classWriter;
        }
    }
}