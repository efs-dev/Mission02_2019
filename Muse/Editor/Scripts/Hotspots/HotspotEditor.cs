using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

using System.Linq;
using System.IO;

using Muse.Editors.States;
namespace Muse.Editors.Hotspots
{

    public class HotspotEditorEditorPersistentData : ScriptableObject
    {
        public Texture2D ErrorImage;
        public int SelectedIndex = -1;
    }

    public class HotspotEditor : EditorWindow
    {

        public static HotspotEditor Instance { get; private set; }


        public const string HOTSPOTS_RESOURCES_PATH = "Assets/Muse/Editor/Resources";

        public HotspotEditorEditorPersistentData Data;

        [MenuItem("Muse/Editors/Visuals/Hotspots")]
        public static void Init()
        {
            var window = EditorWindow.GetWindow<HotspotEditor>();
            window.titleContent = new GUIContent("Hotspots");
            window.Show();
            Instance = window;

            window.Data = ScriptableObject.CreateInstance<HotspotEditorEditorPersistentData>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + "HotspotEditor.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            var characters = Directory.GetFiles(Application.dataPath + "/Muse/Game/Npcs", "*.prefab", SearchOption.AllDirectories).ToList().ConvertAll(x => "Assets" + x.Replace("\\", "/").Replace(Application.dataPath, "")).ConvertAll<Character>(x => AssetDatabase.LoadAssetAtPath<Character>(x));

            window.Data.ErrorImage = Resources.Load<Texture2D>("error");
        }

        private string _loadedState = "";
        private State _state;

        private Vector2 _listHotspotScrollPos;
        private Vector2 _createHotspotScrollPos;

        private void OnGUI()
        {
            var sceneName = EditorSceneManager.GetActiveScene().name;

            if (sceneName != _loadedState || _state == null)
            {
                _state = State.CreateState(sceneName);
                _loadedState = sceneName;
            }

            if (_state == null)
                return;

            var hotspots = FindObjectsOfType<Hotspot>().ToList();

            var totalHotspots = new List<string>();
            totalHotspots.AddRange(hotspots.ConvertAll<string>(x => x.Id));
            totalHotspots.AddRange(_state.HotspotIds);
            totalHotspots = totalHotspots.Distinct().ToList();

            EditorGUILayout.HelpBox("Hotspots have two aspects: the visuals and the data. The visuals are created in the scene using this editor and the data is created in the StateEditor.", MessageType.Info);

            using (new EditorGUILayout.HorizontalScope(GUILayout.Width(Screen.width)))
            {
                using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar, GUILayout.Width(400)))
                {
                    EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(400));
                    GUILayout.Space(40);
                    EditorGUILayout.LabelField("Hotspots", EditorStyles.boldLabel, GUILayout.Width(150));
                    EditorGUILayout.EndHorizontal();

                    GUI.backgroundColor = Color.clear;
                    EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
                    GUILayout.Space(25);
                    if (GUILayout.Button("Scene Hotpot Id", EditorStyles.toolbarButton, GUILayout.Width(120)))
                    {
                    }
                    if (GUILayout.Button("StateEditor Hotpot Id", EditorStyles.toolbarButton, GUILayout.Width(120)))
                    {
                    }
                    if (GUILayout.Button("Select", EditorStyles.toolbarButton, GUILayout.Width(40)))
                    {
                    }
                    EditorGUILayout.EndHorizontal();
                    GUI.backgroundColor = Color.white;

                    _listHotspotScrollPos = EditorGUILayout.BeginScrollView(_listHotspotScrollPos, false, false, new GUIStyle(), GUI.skin.verticalScrollbar, GUI.skin.scrollView, GUILayout.Width(400));
                    using (new EditorGUILayout.VerticalScope(GUILayout.Width(400)))
                    {

                        for (var i = 0; i < totalHotspots.Count; i++)
                        {
                            var hotspotId = totalHotspots[i];
                            var stateHotspot = _state.HotspotIds.Find(x => x == hotspotId);

                            var declaredState = -1;
                            declaredState = hotspots.Find(x => x.Id == hotspotId) != null ? (_state.HotspotIds.Find(x => x == hotspotId) != null ? 0 : 2) : 1;

                            GUI.backgroundColor = Data.SelectedIndex != i ? Color.white : Color.cyan;
                            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.Width(400));

                            GUILayout.Space(25);
                            if (declaredState != 0)
                                GUI.DrawTexture(new Rect(7, i * 18, 18, 18), Data.ErrorImage);

                            if (GUILayout.Button((declaredState == 0 || declaredState == 2) ? hotspotId : "", EditorStyles.toolbarButton, GUILayout.Width(120)))
                            {
                                if (GUI.color != Color.red)
                                {
                                }
                                else
                                {
                                    if (StateEditor.Instance == null)
                                        StateEditor.Init();
                                    StateEditor.Instance.Data.SelectedIndex = StateEditor.Instance.Data.States.IndexOf(StateEditor.Instance.Data.States.Find(x => x.Id == sceneName));
                                }
                            }


                            if (GUILayout.Button((declaredState == 0 || declaredState == 1) ? hotspotId : "", EditorStyles.toolbarButton, GUILayout.Width(120)))
                            {
                            }

                            GUI.enabled = declaredState != 1;
                            var gameObject = GUI.enabled ? GameObject.FindObjectsOfType<Hotspot>().ToList().Find(x => x.Id == hotspotId).gameObject : null;
                            if (GUILayout.Button(GUI.enabled ? (Selection.activeGameObject == gameObject ? "<-" : "->") : "", EditorStyles.toolbarButton, GUILayout.Width(40)))
                            {
                                if (Selection.activeGameObject == gameObject)
                                {
                                    Data.SelectedIndex = -1;
                                    Selection.activeGameObject = null;
                                }
                                else
                                {
                                    Data.SelectedIndex = i;
                                    Selection.activeGameObject = gameObject;
                                }
                            }
                            GUI.enabled = true;


                            EditorGUILayout.EndHorizontal();
                            GUI.backgroundColor = Color.white;
                        }
                    }
                    EditorGUILayout.EndScrollView();
                    EditorGUILayout.HelpBox("The combined hotspots defined in the StateEditor and the scene.", MessageType.None);
                }


                using (new EditorGUILayout.VerticalScope())
                {
                    if (Data.SelectedIndex == -1)
                    {
                        GUILayout.FlexibleSpace();
                        using (new EditorGUILayout.VerticalScope(EditorStyles.toolbar))
                        {
                            var hotspotNames = new List<string>() { "2D Sprite", "UGUI Button", "VideoPlayer" };

                            var characters = Directory.GetFiles(Application.dataPath + "/Muse/Game/Npcs", "*.prefab", SearchOption.AllDirectories).ToList().ConvertAll(x => "Assets" + x.Replace("\\", "/").Replace(Application.dataPath, "")).ConvertAll<Character>(x => AssetDatabase.LoadAssetAtPath<Character>(x));

                            hotspotNames.AddRange(characters.ConvertAll<string>(x => x.name + " (" + x.Id + ")"));

                            var selection = GUILayout.SelectionGrid(-1, hotspotNames.ToArray(), 4);

                            switch (selection)
                            {
                                case -1:
                                    break;
                                case 0:
                                    Hotspot.CreateHotspotSprite();
                                    break;
                                case 1:
                                    Hotspot.CreateHotspotUGUIButton();
                                    break;
                                case 2:
                                    Hotspot.CreateHotspotVideoPlayer();
                                    break;
                                default:
                                    var go = GameObject.Instantiate<GameObject>(characters[selection - 3].gameObject);
                                    if (go.GetComponent<Hotspot>() == null)
                                        go.AddComponent<Hotspot>();

                                    Selection.activeGameObject = go;
                                    break;
                            }
                            EditorGUILayout.HelpBox("This box allows you to create a new hotspot.", MessageType.None);
                        }
                    }
                    else
                    {

                    }

                }
            }


        }

        public static List<GameObject> LoadPrefabsContaining<T>(string path) where T : UnityEngine.Component
        {
            List<GameObject> result = new List<GameObject>();

            var allFiles = Resources.LoadAll<UnityEngine.Object>(path);
            foreach (var obj in allFiles)
            {
                if (obj is GameObject)
                {
                    GameObject go = obj as GameObject;
                    if (go.GetComponent<T>() != null)
                    {
                        result.Add(go);
                    }
                }
            }
            return result;
        }

    }
}