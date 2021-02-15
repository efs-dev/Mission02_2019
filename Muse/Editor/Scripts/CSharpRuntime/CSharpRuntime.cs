using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Muse.Editors.CSharpRuntime
{
    public class CSharpRuntime : MonoBehaviour
    {

        private static CSharpRuntime _instance;
        public static CSharpRuntime GetInstance() { return _instance; }

        // Use this for initialization
        void Awake()
        {
            gameObject.hideFlags = HideFlags.HideInHierarchy;
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}