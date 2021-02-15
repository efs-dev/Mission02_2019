using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Muse;

public class SurvivalSceneObject : MonoBehaviour {

  


    static SurvivalSceneObject _instance = null;
    public static SurvivalSceneObject GetInstance()
    {
        return _instance;
    }

    void Awake()
    {
        // this is actually getting called
        _instance = this;
    }

    public GameObject topbar;
    public GameObject peopleText;
    public GameObject seasonText;
    public GameObject suppliesText;

    public GameObject springBG;
    public GameObject summerBG;
    public GameObject fallBG;
    public GameObject winterBG;

    public GameObject otter_creek;
    public GameObject fort_kearny;
    public GameObject fort_lincoln;
    public GameObject fort_sully;
    public GameObject fort_thompson;
    public GameObject black_hills;
    public GameObject agency;
    public GameObject fort_laramie;
    public GameObject hunting_grounds;
    public GameObject bighorn;
    public GameObject little_bighorn;
    public GameObject rosebud;
    public GameObject powder_river;
    public GameObject sioux;

    // public List<Hotspot> springCamps = new List<Hotspot>(); 

   

    public static void HideAllCamps()
    {
        SurvivalSceneObject inst = _instance;

        inst.otter_creek.SetActive(false);
        inst.black_hills.SetActive(false);
        //inst.agency.SetActive(false);
        inst.hunting_grounds.SetActive(false);
        inst.bighorn.SetActive(false);
        inst.little_bighorn.SetActive(false);
        inst.rosebud.SetActive(false);
        inst.powder_river.SetActive(false);
        inst.sioux.SetActive(false);
    }


    public static void DisplaySeason()
    {
        int season = GameFlags.GetGameFlagValue<int>("P4Season");

        Debug.Log("DisplaySeason " + season);
        switch (season)
        {
            case 1: // winter
                _instance.springBG.SetActive(false);
                _instance.summerBG.SetActive(false);
                _instance.fallBG.SetActive(false);
                _instance.winterBG.SetActive(true);
                break;
            case 2:
                _instance.springBG.SetActive(true);
                _instance.summerBG.SetActive(false);
                _instance.fallBG.SetActive(false);
                _instance.winterBG.SetActive(false);
                break;
            case 3:
                _instance.springBG.SetActive(false);
                _instance.summerBG.SetActive(true);
                _instance.fallBG.SetActive(false);
                _instance.winterBG.SetActive(false);
                break;
            case 4:
                _instance.springBG.SetActive(false);
                _instance.summerBG.SetActive(false);
                _instance.fallBG.SetActive(true);
                _instance.winterBG.SetActive(false);
                break;
            default:
                throw new Exception("displaying unknown season: " + season);

        }
    }

    public static void DisplayGoodCamps(int season)
    {
        // turn on camps for this season
        // and set the seasonal bg
        switch (season) {
            case 1:   // winter

                Debug.Log("*** WINTER ***");

                GameFlags.SetGameFlagValue("P4Temp", "winter");
                GameFlags.SetGameFlagValue("P4SeasonStr", "winter");

                _instance.sioux.SetActive(true);
                _instance.agency.SetActive(true);
                _instance.little_bighorn.SetActive(true);

                GameFlags.SetGameFlagValue("P4Camp1", "sioux");
                GameFlags.SetGameFlagValue("P4Camp2", "little_bighorn");
                GameFlags.SetGameFlagValue("P4Camp4", "agency");
                    break;
            case 2:   // spring

                Debug.Log("*** SPRING ***");

                GameFlags.SetGameFlagValue("P4Temp", "spring");
                GameFlags.SetGameFlagValue("P4SeasonStr", "spring");


                _instance.black_hills.SetActive(true);
                _instance.otter_creek.SetActive(true);
                _instance.hunting_grounds.SetActive(true);

                GameFlags.SetGameFlagValue("P4Camp1", "black_hills");
                GameFlags.SetGameFlagValue("P4Camp2", "otter_creek");
                GameFlags.SetGameFlagValue("P4Camp4", "hunting_grounds");
                    break;
            case 3:   // summer

                Debug.Log("*** SUMMER ***");

                GameFlags.SetGameFlagValue("P4Temp", "summer");
                GameFlags.SetGameFlagValue("P4SeasonStr", "summer");

                _instance.bighorn.SetActive(true);
                _instance.powder_river.SetActive(true);
                _instance.rosebud.SetActive(true);

                GameFlags.SetGameFlagValue("P4Camp1", "bighorn");
                GameFlags.SetGameFlagValue("P4Camp2", "powder_river");
                GameFlags.SetGameFlagValue("P4Camp4", "rosebud");
                break;
            case 4:   // fall

                Debug.Log("*** FALL ***");

                GameFlags.SetGameFlagValue("P4Temp", "fall");
                GameFlags.SetGameFlagValue("P4SeasonStr", "fall");


                _instance.black_hills.SetActive(true);
                _instance.hunting_grounds.SetActive(true);
                _instance.otter_creek.SetActive(true);
                //_instance.agency.SetActive(true);

                GameFlags.SetGameFlagValue("P4Camp1", "black_hills");
                GameFlags.SetGameFlagValue("P4Camp2", "otter_creek");
                GameFlags.SetGameFlagValue("P4Camp4", "hunting_grounds");
                break;
            }



            /*
             * // do train
                if (GameFlags.P4SeasonCount < 9) { 
					$scratch = "train" + GameFlags.P4SeasonCount

                    updateScene($scratch + "|SHOW")

                }
                */

    } // Displaygood
   
} // class

