using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEditor;

namespace Muse.Editors.GameFlags
{

    [Serializable]
    public class GameFlagEditorDrawer
    {
        public string CopyPrefix = "GameFlags.";

        [SerializeField]
        public List<GameFlagData> Variables = new List<GameFlagData>();

        [SerializeField]
        public string Filter = "";


        public void Reset()
        {
            Variables.Clear();
        }

        [SerializeField]
        private Vector2 _scrollPosition;
        public void OnGUI(float width, Action toolbarPrepend = null, Action toolbarAppend = null, Action OnChanging = null)
        {
            //GUI.backgroundColor = Color.yellow;
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(width)))
            {
                if (toolbarPrepend != null)
                    toolbarPrepend();
                if (GUILayout.Button("Add", EditorStyles.toolbarButton, GUILayout.Width(60)))
                {
                    if (OnChanging != null)
                        OnChanging();
                    var uniqueId = 0;

                    while (Variables.Find(x => x.Name == "variable_" + uniqueId) != null)
                        uniqueId++;

                    Variables.Add(new GameFlagData() { Name = "variable_" + uniqueId });
                }

                Filter = EditorGUILayout.TextField(Filter);
                if (toolbarAppend != null)
                    toolbarAppend();
            }
            //GUI.backgroundColor = Color.white;



            GUI.backgroundColor = Color.clear;
            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
            if (GUILayout.Button("Name", EditorStyles.toolbarButton, GUILayout.Width(100)))
            {
            }
            if (GUILayout.Button("Type", EditorStyles.toolbarButton, GUILayout.Width(50)))
            {
            }
            if (GUILayout.Button("Value", EditorStyles.toolbarButton, GUILayout.ExpandWidth(true)))
            {
            }
            if (GUILayout.Button("", EditorStyles.toolbarButton, GUILayout.Width(40)))
            {
            }
            EditorGUILayout.EndHorizontal();
            GUI.backgroundColor = Color.white;

            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition, GUIStyle.none, GUI.skin.verticalScrollbar);

            for (var i = 0; i < Variables.Count; i++)
            {
                var variable = Variables[i];

                if (!string.IsNullOrEmpty(Filter))
                {
                    if (!variable.Name.ToLower().StartsWith(Filter.ToLower()))
                        continue;
                }

                using (new EditorGUILayout.HorizontalScope())
                {
                    using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar, GUILayout.Width(width)))
                    {
                        if (GUILayout.Button("Copy", EditorStyles.toolbarButton, GUILayout.Width(50)))
                        {
                            GUIUtility.systemCopyBuffer = CopyPrefix + variable.Name;
                        }
                        if (GUILayout.Button(variable.Name, EditorStyles.toolbarButton, GUILayout.Width(200)))
                        {
                            StringEditorPopup window = new StringEditorPopup(variable.Name, (id) => Variables.Find(x => x.Name.ToLower() == id.ToLower()) == null, (id) =>
                            {
                                OnChanging();
                                variable.Name = id;
                                Variables.Sort((x, y) => x.Name.CompareTo(y.Name));
                            });
                            PopupWindow.Show(new Rect(0, i*18, 100, 100), window);
                        }

                        var variableType = variable.VariableType;
                        var newVariableType = (GameFlagData.FlagTypes)EditorGUILayout.EnumPopup(variable.VariableType, EditorStyles.toolbarPopup, GUILayout.Width(50));

                        if (variableType != variable.VariableType)
                            OnChanging();

                        variable.VariableType = newVariableType;

                        var value = variable.Value;
                        var newValue = value;
                        switch (variable.VariableType)
                        {
                            case GameFlagData.FlagTypes.String:
                                if (variableType != variable.VariableType)
                                    newValue = "";
                                newValue = EditorGUILayout.TextField(variable.Value.ToString(), EditorStyles.toolbarTextField, GUILayout.ExpandWidth(true));
                                break;
                            case GameFlagData.FlagTypes.Bool:
                                if (variableType != variable.VariableType)
                                    newValue = "false";
                                var boolList = new string[] { "False", "True" };
                                newValue = (EditorGUILayout.Popup(bool.Parse(newValue) == true ? 1 : 0, boolList, EditorStyles.toolbarPopup) == 1).ToString();
                                break;
                            case GameFlagData.FlagTypes.Int:
                                if (variableType != variable.VariableType)
                                    newValue = "0";
                                newValue = EditorGUILayout.IntField(int.Parse(newValue), EditorStyles.toolbarTextField, GUILayout.ExpandWidth(true)).ToString();
                                break;
                            case GameFlagData.FlagTypes.Float:
                                if (variableType != variable.VariableType)
                                    newValue = "0";
                                newValue = EditorGUILayout.FloatField(float.Parse(newValue), EditorStyles.toolbarTextField, GUILayout.ExpandWidth(true)).ToString();
                                break;
                        }

                        if (value != newValue)
                            OnChanging();

                        variable.Value = newValue;

                        GUILayout.FlexibleSpace();
                        if (GUILayout.Button("X", EditorStyles.toolbarButton, GUILayout.Width(30)))
                        {
                            if (OnChanging != null)
                                OnChanging();
                            Variables.Remove(variable);
                            i--;
                        }
                        GUILayout.Space(15);
                    }
                }
            }

            EditorGUILayout.EndScrollView();

        }

        public void FromClassWriter(ClassWriter classWriter)
        {
            Reset();

            var properties = classWriter.GetPropertyWriters().FindAll(x => x.IsGetterSetter);

            for (var i = 0; i < properties.Count; i++)
            {
                var property = properties[i];

                var internalProperty = classWriter.GetProperty("_" + property.Name);

                object value = null;
                GameFlagData.FlagTypes type = default(GameFlagData.FlagTypes);

                switch (internalProperty.Type)
                {
                    case "string":
                        value = internalProperty.Value.Replace(";", "").Replace("\"", "");
                        type = GameFlagData.FlagTypes.String;
                        break;
                    case "bool":
                        value = bool.Parse(internalProperty.Value.Replace(";", ""));
                        type = GameFlagData.FlagTypes.Bool;
                        break;
                    case "int":
                        value = int.Parse(internalProperty.Value.Replace(";", ""));
                        type = GameFlagData.FlagTypes.Int;
                        break;
                    case "float":
                        value = float.Parse(internalProperty.Value.Replace(";", "").Replace("f", ""));
                        type = GameFlagData.FlagTypes.Float;
                        break;
                }

                var variableData = new GameFlagData { Name = property.Name, Value = value.ToString(), VariableType = type, Watch = false };
                Variables.Add(variableData);
            }
        }

        public ClassWriter GetClassWriter(string className, bool isPublic = false, bool isPartial = false, bool isStatic = false, bool useChangedHandle = true)
        {
            var classWriter = new ClassWriter();
            classWriter.Name = className;
            classWriter.IsPartial = isPartial;
            classWriter.IsStatic = isStatic;
            classWriter.IsPublic = true;

            for (var i = 0; i < Variables.Count; i++)
            {
                var variable = Variables[i];

                var internalName = "_" + variable.Name;

                // Debug.Log("variable: " + variable + " , " + variable.Name);

                var val = variable.Value.ToString();

                switch (variable.VariableType)
                {
                    case GameFlagData.FlagTypes.String:
                        val = "\"" + variable.Value + "\"";
                        break;
                    case GameFlagData.FlagTypes.Bool:
                        val = variable.Value.ToString().ToLower();
                        break;
                    case GameFlagData.FlagTypes.Float:
                        val = variable.Value.ToString() + "f";
                        break;
                }

                string valType = Enum.GetName(typeof(GameFlagData.FlagTypes), variable.VariableType).ToLower();
                //Debug.Log("prop value: " + variable.Value.GetType().Name);

                var propertyWriter = classWriter.CreatePropertyWriter();
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Private;
                propertyWriter.Type = valType;
                propertyWriter.Name = internalName;
                propertyWriter.Value = val;
                propertyWriter.IsStatic = isStatic;

                propertyWriter = classWriter.CreatePropertyWriter();
                propertyWriter.VisibilityType = PropertyWriter.VisibilityTypes.Public;
                propertyWriter.Type = valType;
                propertyWriter.Name = variable.Name;
                propertyWriter.AddGetterLine("return " + internalName + ";");
                if (useChangedHandle)
                {
                    propertyWriter.AddSetterLine("var oldValue = value;\n" + internalName + " = value;\nGameFlagChanged(\"" + variable.Name + "\", oldValue, value);");
                }
                else
                {
                    propertyWriter.AddSetterLine(internalName + " = value;");
                }
                propertyWriter.IsStatic = isStatic;
            }

            return classWriter;
        }
    }

    [Serializable]
    public class GameFlagData
    {
        public string Name = "";
        public string Value = "";
        public enum FlagTypes { String, Int, Float, Bool };
        public FlagTypes VariableType;
        public bool Watch;

        public GameFlagData Clone()
        {
            var clone = new GameFlagData();
            clone.Name = Name;
            clone.Value = Value;
            clone.VariableType = VariableType;
            clone.Watch = Watch;
            return clone;
        }
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