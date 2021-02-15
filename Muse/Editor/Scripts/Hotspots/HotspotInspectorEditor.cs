using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Linq;

namespace Muse.Editors.Hotspots
{

    //[CustomEditor(typeof(Hotspot))]
    public class HotspotInspectorEditor : Editor
    {

        private StateAttribute _stateAttribute;

        void OnEnable()
        {
            var sceneId = EditorSceneManager.GetActiveScene().name;
            var states = Utils.GetTypesWith<StateAttribute>().ToList();
            var state = states.Find(x => x.Name == "State_" + sceneId);
            if (state == null)
                Debug.LogError("Hotspot Component added in scene without a state: " + sceneId);//
            _stateAttribute = (StateAttribute)state.GetCustomAttributes(typeof(StateAttribute), true)[0];
        }

        public override void OnInspectorGUI()
        {
            var hotspot = (Hotspot)target;

            if (_stateAttribute.HotspotIds.Count == 0)
                return;

            var index = _stateAttribute.HotspotIds.IndexOf(hotspot.Id);
            if (index == -1)
                index = 0;

            hotspot.Id = _stateAttribute.HotspotIds[EditorGUILayout.Popup("Id:", index, _stateAttribute.HotspotIds.ToArray())];
        }
    }
}