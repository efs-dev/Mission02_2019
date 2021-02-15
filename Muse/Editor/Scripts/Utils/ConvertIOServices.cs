using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using System.IO;

using System;

using Muse.Editors.Audio;

public class ConvertIOServices  {

    [Serializable]
    public class ConvertIOFilesData
    {
        public enum Steps { Process, AddToAudio, GeneratePromptMeta };
        public Steps CurrentStep;
        public enum Processes { SendMp3, WaitForConvert, Download, Complete };
        public Dictionary<string, Processes> FilesToProcess = new Dictionary<string, Processes>();
        public string Error;
    }

    class ConvertIOPost
    {
        public string apikey;
        public string input;
        public string file;
        public string filename;
        public string outputformat;
    }

    class ConvertIOResult
    {
        public string id;
    }

    static void WaitForWWW(WWW www, Action<WWW> callback)
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

            callback(www);
        };
        EditorApplication.update += updateFunc;
    }

    static void ProcessFile(string mp3Name, string mp3Path, string oggPath, ConvertIOFilesData data)
    {
        data.FilesToProcess.Add(mp3Name, ConvertIOFilesData.Processes.SendMp3);

        var post = new ConvertIOPost();
        post.apikey = "eb7d0c5a7166fa719253f8e51c854ef1";
        post.input = "upload";
        post.filename = mp3Name;
        // post.file = File.ReadAllBytes(mp3Path).ToList().ConvertAll<string>(x=>x.ToString()).Aggregate((x, next)=>x + next);
        post.outputformat = "ogg";

        var json = JsonUtility.ToJson(post);
        var postBytes = System.Text.Encoding.UTF8.GetBytes(json);


        WaitForWWW(new WWW("https://api.convertio.co/convert", postBytes), (www) =>
        {
            if (!string.IsNullOrEmpty(www.error))
                Debug.LogError(www.error + ", " + www.text);
            else
            {
                var dataIndex = www.text.IndexOf("\"data") + 7;
                var dataText = www.text.Substring(dataIndex, www.text.Length - 1 - dataIndex);
                //  Debug.Log(dataText);
                var result = JsonUtility.FromJson<ConvertIOResult>(dataText);
                // Debug.Log("result: " + result);
                //  Debug.Log(result.id);
                byte[] myData = File.ReadAllBytes(mp3Path);// System.Text.Encoding.UTF8.GetBytes(newMp3Name);

                var putURL = "https://api.convertio.co/convert/" + result.id + "/" + mp3Name;
                var headers = new Dictionary<string, string>();
                headers.Add("X-HTTP-Method-Override", "PUT");
                WaitForWWW(new WWW(putURL, myData, headers), (putWWW) =>
                {
                    Debug.Log(mp3Name + "  putWWW: " + putWWW.text);
                    var resultId = result.id;

                    data.FilesToProcess[mp3Name] = ConvertIOFilesData.Processes.WaitForConvert;
                    Action<WWW> waitForFinish = null;
                    waitForFinish = (www2) =>
                    {
                        www = www2;
                        if (www.text.IndexOf("finish") == -1)
                        {
                            Debug.Log(mp3Name + ": " + www.text);
                            WaitForWWW(new WWW("https://api.convertio.co/convert/" + resultId + "/status"), waitForFinish);
                        }
                        else
                        {
                            Debug.Log(www.text);
                            var urlIndex = www.text.IndexOf("url");
                            var url = www.text.Substring(urlIndex, www.text.Length - urlIndex).Replace("url\":\"", "");
                            url = url.Substring(0, url.IndexOf("\"")).Replace("\\", "");

                            Debug.Log(url);

                            data.FilesToProcess[mp3Name] = ConvertIOFilesData.Processes.Download;
                            WaitForWWW(new WWW(url), (www3) =>
                            {
                                www = www3;
                                Debug.Log(www.text);
                                Debug.Log(www.bytes.Length);
                                File.WriteAllBytes(oggPath, www.bytes);
                                data.FilesToProcess[mp3Name] = ConvertIOFilesData.Processes.Complete;
                            });
                        }
                    };
                    WaitForWWW(new WWW("https://api.convertio.co/convert/" + resultId + "/status"), waitForFinish);
                });
            };
        });
    }

    public static void ConvertMp3(string mp3Path, string folderPath, Func<string, string> cleanName, Action onComplete = null)
    {
        ConvertMp3s(new string[1] { mp3Path }, folderPath, cleanName, onComplete);
    }

    public static void ConvertMp3s(string[] mp3Paths, string folderPath, Func<string, string> cleanName, Action onComplete = null)
    {
        var data = new ConvertIOFilesData();

        ConvertIOWindow.Start(data);

        var mp3Count = mp3Paths.Length;
        var mp3sToProcess = mp3Count;

        data.CurrentStep = ConvertIOFilesData.Steps.Process;

        for (var i = 0; i < mp3Count; i++)
        {
            var mp3Path = mp3Paths[i].Replace("\\", "/");
            var nameIndex = mp3Path.LastIndexOf("/") + 1;
            var mp3Name = mp3Path.Substring(nameIndex, mp3Path.Length - nameIndex);

            var newMp3Name = mp3Name;
            if (cleanName != null)
                newMp3Name = cleanName(newMp3Name);

            var newMp3Path = folderPath + "/" + newMp3Name;
            var newOggPath = newMp3Path.Replace(".mp3", ".ogg");


            File.Copy(mp3Path, newMp3Path, true);

            ProcessFile(newMp3Name, newMp3Path, newOggPath, data);
        }


        EditorApplication.CallbackFunction waitUntilFilesComplete = null;
        waitUntilFilesComplete = () =>
        {
            foreach (var status in data.FilesToProcess.Values)
            {
                if (status != ConvertIOFilesData.Processes.Complete)
                    return;
            }
            EditorApplication.update -= waitUntilFilesComplete;

            data.CurrentStep = ConvertIOFilesData.Steps.AddToAudio;

            var isAudioEditorOpen = AudioEditor.Instance != null;
            if (!isAudioEditorOpen)
                AudioEditor.Init();

            AudioEditor.Instance.Reload();
            AudioEditor.Instance.RefreshStreamingAssets();
            AudioEditor.Instance.Save();

            if (!isAudioEditorOpen)
                AudioEditor.Instance.Close();

            ConvertIOWindow.End();

            if (onComplete != null)
                onComplete();
        };
        EditorApplication.update += waitUntilFilesComplete;
    }

    class ConvertIOWindow : EditorWindow
    {
        private static ConvertIOWindow _instance;
        public static void Start(ConvertIOFilesData data)
        {
            ConvertIOWindow window = ScriptableObject.CreateInstance<ConvertIOWindow>();
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 800, 600);
            window.ShowUtility();
            window.Data = data;
            _instance = window;
        }

        public static void End()
        {
            _instance.Data = null;
            _instance.Close();
            _instance = null;
        }


        public ConvertIOFilesData Data;

        private void OnGUI()
        {
            switch (Data.CurrentStep)
            {
                case ConvertIOFilesData.Steps.Process:
                    EditorGUILayout.LabelField("Copying .mp3s to directory and generating .oggs.");

                    foreach (var mp3Name in Data.FilesToProcess.Keys)
                    {
                        EditorGUILayout.LabelField(mp3Name + ": " + Data.FilesToProcess[mp3Name]);
                    }

                    break;
                case ConvertIOFilesData.Steps.AddToAudio:
                    EditorGUILayout.LabelField("All .mp3s have been moved and generated. Adding audio files to the Audio Editor.");
                    break;
                case ConvertIOFilesData.Steps.GeneratePromptMeta:
                    EditorGUILayout.LabelField("Generating the prompt meta data (lip flap data) for audio files (per audio1 meta, 1 mp3, 1 ogg)");
                    break;
            }
        }
    }

    private void DrawVOModalWindow(int id)
    {
        

    }

}
