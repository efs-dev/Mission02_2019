using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalGameDlgHack : MonoBehaviour {

    static SurvivalGameDlgHack instance;

    //static RectTransform original;

    public RectTransform originalParent;
    public RectTransform lowerParent;

    public RectTransform prompt1;
    public RectTransform prompt2;


    // Use this for initialization
    void Start () {
        instance = this;	
	}
	
    public static void LowerPrompt()
    {

        //Debug.Log("lower prompt 06");
        //original = instance.prompt.GetComponent<RectTransform>();

        instance.lowerParent.gameObject.SetActive(true);

        //original.Translate(0, 100f, 0);
        //instance.prompt.transform.Translate(0, -350f, 0);
        instance.prompt1.SetParent(instance.lowerParent, false);
        instance.prompt2.SetParent(instance.lowerParent, false);
    }
	
    public static void ResetPrompt()
    {
        instance.prompt1.SetParent(instance.originalParent, false);
        instance.prompt2.SetParent(instance.lowerParent, false);
        instance.lowerParent.gameObject.SetActive(false);
    }
}
