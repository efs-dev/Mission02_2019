using UnityEditor;
using System;
using UnityEngine;

namespace Muse.Editors.Popups
{

    [Serializable]
    public class PopupTemplate
    {
        public string OriginalId;
        public int OriginalHash;

        public bool RunCloseFirst;

        public const string DELIMITER = "^^^^^";

        public string Id;

        public bool IsDeleted;

        public virtual void GenerateVO(string path)
        {

        }

        public virtual void OnSave()
        {

        }

        public virtual void ChangeId(string newId, Action createMemento)
        {

        }

        public virtual void OnGUI(Action createMemento, Action<Vector2, string, Vector2> infoButton, Func<string, bool> isValidId)
        {

        }

        public virtual string Serialize()
        {
            return "";
        }

        public virtual void Deserialize(string data)
        {

        }

        public virtual void OnDelete()
        {

        }

        public virtual void FromClassWriter(ClassWriter classWriter) { }

        public virtual ClassWriter GetClassWriter()
        {
            return null;
        }

    }
    public class PopupTemplateAttribute : System.Attribute
    {
    }

    public class PopupIdWindowEditor : PopupWindowContent
    {
        private string _originalId;
        private string _id;
        private Func<string, bool> _isValidCallback;
        private Action<string> _onSaveCallback;

        public override Vector2 GetWindowSize()
        {
            return new Vector2(250, 100);
        }

        public PopupIdWindowEditor(string id, Func<string, bool> isValidCallback, Action<string> onSaveCallback)
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
                    PopupEditor.Instance.Sort();
                    editorWindow.Close();
                }
            }

        }
    }
}