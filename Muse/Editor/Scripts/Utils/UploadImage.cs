using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

[System.Serializable]
public class UploadImage
{
    public string TemporaryImagePath = "";
    public string ImagePath = "";
    public Texture2D Texture;

    public string PathKey = "UploadImage";

    public override int GetHashCode()
    {
        return Utils.CombineHash(TemporaryImagePath.GetHashCode(), ImagePath.GetHashCode());
    }

    public void OnGUI(float width)
    {
        using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(width)))
        {
            GUILayout.Space(5);
            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.LabelField("Image:", GUILayout.Width(150));
                EditorGUILayout.LabelField(ImagePath);

            }
            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Space(155);
                if (GUILayout.Button(string.IsNullOrEmpty(ImagePath) ? "Add Image" : "Replace Image", EditorStyles.toolbarButton, GUILayout.Width(200)))
                {
                    AddImage();
                }
                if ((!string.IsNullOrEmpty(ImagePath) || !string.IsNullOrEmpty(TemporaryImagePath)) && GUILayout.Button("Delete", EditorStyles.toolbarButton, GUILayout.Width(100)))
                {
                    DeleteImage();
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
                RefreshImage();
            }
            GUILayout.Space(5);
        }
    }

    public void MakePermanent(string folderPrepend, string originalId, string newId)
    {
        if (!Directory.Exists(Application.streamingAssetsPath + "/Images/" + folderPrepend))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath + "/Images/" + folderPrepend);
        }

        if (string.IsNullOrEmpty(TemporaryImagePath) && string.IsNullOrEmpty(ImagePath))
        {
            var image = "/Images/" + folderPrepend + originalId + "_image.png";

            if (File.Exists(Application.streamingAssetsPath + image))
                File.Delete(Application.streamingAssetsPath + image);
        }

        if (originalId != newId)
        {
            var image = "/Images/" + folderPrepend + originalId + "_image.png";
            var newImagePath = "/Images/" + folderPrepend + newId + "_image.png";

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
            var name = newId + "_image.png";
            ImagePath = "/Images/" + folderPrepend + name;
            Debug.Log(ImagePath);
            var newPath = Application.streamingAssetsPath + "/Images/" + folderPrepend + name;
            File.Copy(TemporaryImagePath, newPath, true);

            TemporaryImagePath = "";
        }
    }

    public void AddImage()
    {
        var path = EditorUtility.OpenFilePanel("Select Image", EditorPrefs.HasKey(PathKey) ? EditorPrefs.GetString(PathKey) : Application.dataPath, "png").Replace("\\", "/");
        EditorPrefs.SetString(PathKey, path);

        if (!string.IsNullOrEmpty(path))
        {
            TemporaryImagePath = path;
            ImagePath = "";
            
            var tWWW = new WWW("file:" + TemporaryImagePath);
            while (!tWWW.isDone) ;
            Texture = tWWW.texture;
            AssetDatabase.Refresh();
        }
    }

    public void DeleteImage()
    {
        TemporaryImagePath = "";
        ImagePath = "";
        Texture = null;
    }

    public void RefreshImage()
    {
        var rect = GUILayoutUtility.GetLastRect();
        EditorGUI.DrawPreviewTexture(new Rect(165, rect.y + 20, 200, 200), Texture);
        GUILayout.Space(210);
        using (new EditorGUILayout.HorizontalScope())
        {
            EditorGUILayout.LabelField("Resolution:", GUILayout.Width(150));
            EditorGUILayout.LabelField(Texture.width + "x" + Texture.height + " px");
        }
    }
}
