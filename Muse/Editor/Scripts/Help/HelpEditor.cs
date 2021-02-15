using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Muse.Editors.Help
{
    public static class HelpEditor
    {

        [MenuItem("Muse/Help/API Documentation")]
        static void APIDocumentation()
        {
        }


        [MenuItem("Muse/Help/Tutorials/Getting Started")]
        static void GettingStarted()
        {
            EditorUtility.DisplayDialog("Getting Started", "This is the getting started dialog.", "Okay");
        }

        [MenuItem("Muse/Help/Videos/Getting Started")]
        static void GettingStartedVideo()
        {

        }

    }
}

