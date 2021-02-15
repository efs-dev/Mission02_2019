using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Efs.Dialogs;
using Muse;

using randomlist;

public partial class SurvivalGame  {

    #region vars
 		
		// how many 'starves' in a row you have
		static int starveCount;
		//static int _turn; 
		
		//static int _baseProcessing;
		//static int _supplyMod;
		
		static int _bigRaidCount;
        static int season;

		
        static int curBuffaloChance;
        static int curGameChance;
        static int curBuffaloSizeChance = 100;

        static int curBuffaloDrop;

		
		static int _stealChance;
		static int _fastChance;
		
		// +2 to -2  Very healthy, healthy, surviving, hungry, starving
		//static int _tribeHealth;
		
		// 0 xs, 1 s, m 2, l 3, xl 4
		static int _lastHerdSize = -1;
		
		
		static float archeryMod;
		static float rifleryMod;
		static float fastHorseMod;
		static float gunMod;
		static float braveryMod;
		static float crazyMod;
		static float horseSkillMod;
		
		static int horsesStolen;
		static int newFastHorse;
		static bool hadFight;
		static int killCount;
		static bool countedCoup;
		
		static int success; // overall season success // 1,2,3,4

        static double foodRatio;
        static bool healthDown;
        static bool healthUp;
        static bool popDown;
        static bool popUp;


        static RandomList _herdList;

        static RandomList _season1List;
		static RandomList _season2List;
		static RandomList _season3List;
		static RandomList _season4List;
		static RandomList _season5List;
		static RandomList _season6List;
		static RandomList _season7List;

    static bool gotHorse = false;
    static int newFood = 0;
    static int newSupply = 0;

    static bool bowUp;
    static bool rifleUp;
    static bool horseUp;

    static int newWarriors;
    static int newWarriorsWives;
    static int totalNew;
    static int totalShrink;

    static bool dance = false;

    static List<float> _herdWeights;

    public static bool firstHunt
    {
        get { return GameFlags.GetGameFlagValue<bool>("P4FirstHunt"); }
        set { GameFlags.SetGameFlagValue("P4FirstHunt", value); }
    }
    //public static int buffaloChance;
    public static int buffaloDrop;


    private static string herdSizeString = "";

    // food multiplier for each size type
    static List<float> herdMods;
    /*public static int turn
    {
        get { return _turn; }

        set
        {
            _turn = value;

            GameFlags.SetGameFlagValue("P4SupplyTurn", "" + value);
        }
    }*/
    #endregion


    // # horses available to trade
    public static int upForTrade
    {
        get {
            return GameFlags.GetGameFlagValue<int>("P4UpForTrade");
        }

        set
        {
            GameFlags.SetGameFlagValue("P4UpForTrade", "" + value);
            GameFlags.SetGameFlagValue("P4FoodTrade", "" + (value * 8));   // each horse is worse 8 food
        }
    }
    #region tribe info

    /*
    public static int warriorCount
     {
         get { return GameFlags.GetGameFlagValue<int>("P4WarriorCount");  }

         set
         {
             GameFlags.SetGameFlagValue("P4WarriorCount", "" + value);
             CalcPopulation();
         }
     }

    public static int femaleCount
    {
        get { return GameFlags.GetGameFlagValue<int>("P4FemaleCount"); }

        set
        {
            GameFlags.SetGameFlagValue("P4FemaleCount", "" + value);
            CalcPopulation();
        }
    }

    public static int elderCount
    {
        get { return GameFlags.GetGameFlagValue<int>("P4ElderCount"); }

        set
        {
            GameFlags.SetGameFlagValue("P4ElderCount", "" + value );
            CalcPopulation();
        }
    }

    public static int childCount
    {
        get { return GameFlags.GetGameFlagValue<int>("P4ChildCount"); }

        set
        {
            GameFlags.SetGameFlagValue("P4ChildCount", "" + value);
            CalcPopulation();
        }
    }
    */



    public static string condition
    {
        get
        {
            int c = GameFlags.GetGameFlagValue<int>("P4TribeHealth");
               switch (c)
                {
                    case -2: return "starving";
                    case -1: return "hungry";
                    case 0: return "surviving";
                    case 1: return "healthy";
                    case 2: return "very healthy";
                }
                
            return "<bad health string>";
        }
    }
    #endregion

    





    public static string GetSeasonString()
    {
        switch (GameFlags.GetGameFlagValue<int>("P4Season"))
        {
            case 1: return "winter";
            case 2: return "spring";
            case 3: return "summer";
            case 4: return "fall";
            default: return "null";
        }
    }

    // 1 based
    public static int Random(int max)
    {

        int ret = (int)Mathf.Ceil(UnityEngine.Random.value * max);

        //M3Tools.Out("random: " + ret);
        return ret;
    }

    /*

    // NOTE: this shouuld replace any direct setting of season in script!!!
    // 1 - winter, 2 - spring, 3 - summer, 4 - fall
    public static void NextSeason()
    {
        M3.Out("NextSeason()");

        int curSeason = M3.GetInt("P4Season");

        curSeason++;
        if (curSeason > 4)
        { // if greater than FALL wrap around to winter
            curSeason = 1;
            // winter
        }

        M3.Out("new season: " + curSeason);
        GameFlags.SetGameFlagValue("P4Season", "" + curSeason);

        M3.IncFlag("P4SeasonCount", 1);   // inc the absolute season

        // reset the season turn
        // every time season changes the #p3_season_turn is reset to 1 (1st turn)
        GameFlags.SetGameFlagValue("P4SeasonTurn", "1");

        if ( GameFlags.GetGameFlagValue<int>("P4SeasonCount") > 1 )
        {
            curBuffaloChance -= buffaloDrop;
            M3.Out("...dropping buffaloChange due to change in season, it's now " + curBuffaloChance);
            curBuffaloSizeChance -= buffaloDrop;
            GameFlags.P4CurrentBuffaloSizeChance -= buffaloDrop;
        }

        GameFlags.SetGameFlagValue("P4HuntedBufThisSeason", "false");  // reset
    }
    */

    

    /*

    #region Init
    public static void Init()
    {
        M3.Out("surv game init() ");

        // misc
        GameFlags.SetGameFlagValue("P4AutoTrip", "");

        // chokeberries etc
        GameFlags.SetGameFlagValue("P4Berries", "");

        // sundance
        GameFlags.SetGameFlagValue("P4Attended", "false");


        //			scriptMgr.setPropertyValue("#p3_reprisal_type", 0 );  // 0 none, 1 other, 2 self 
        //			scriptMgr.setPropertyValue("$p3_reprisal_string", "" );  //

        //turn = GameFlags.GetGameFlagValue<int>("P4SupplyTurn");



        //season = GameFlags.GetGameFlagValue<int>("P4StartSeason");

        GameFlags.SetGameFlagValue("P4WhiteBuf", "false");
        GameFlags.SetGameFlagValue("P4WhiteBuffaloHides", "0");

        M3.SetInt("P4StarveCount", 0);

        herdSizeString = "X";  // didn't hunt

        _bigRaidCount = 0;

        curGameChance = GameFlags.GetGameFlagValue<int>("P4BaseGameChance");

        curBuffaloChance = GameFlags.GetGameFlagValue<int>("P4BaseBuffaloChance");
        GameFlags.SetGameFlagValue("P4CurrentBuffaloChance", GameFlags.GetGameFlagValue<int>("P4BaseBuffaloChance"));

        // read in herd size chances
        List<string>herdWeights = new List<string>( GameFlags.GetGameFlagValue<string>("P4HerdSizeChanceStart").Split('|') );
        var weight = 0f;
        _herdWeights = herdWeights.ConvertAll<float>(x =>
        {
            weight += float.Parse(x);
            return weight;
        });

        for (var i = 0; i < _herdWeights.Count; i++)
        {
            Debug.Log("herd weight " + i + " -- " + _herdWeights[i]);
        }

        List<string> tmp  = new List<string>(GameFlags.GetGameFlagValue<string>("P4HerdMods").Split('|') );
        herdMods = new List<float>();

        for (var i = 0; i < tmp.Count; i++)
        {
            var mod = float.Parse(tmp[i]);
            //M3.Out("Herd mod: " + mod );
            herdMods.Add(mod);
        }


        _herdList = new RandomList("HERD_LIST");

        _herdList.Add("XS", "XS", (uint) int.Parse(herdWeights[0]), -1, 0, 3);
        _herdList.Add("S", "S", (uint) int.Parse(herdWeights[1]), -1, 5, 3);
        _herdList.Add("M", "M", (uint) int.Parse(herdWeights[2]), -1, 5);
        _herdList.Add("L", "L", (uint) int.Parse(herdWeights[3]), -1, 5);
        _herdList.Add("XL", "XL", (uint) int.Parse(herdWeights[4]), 1);

        archeryMod = GameFlags.GetGameFlagValue<float>("P4ArcheryMod");
        rifleryMod = GameFlags.GetGameFlagValue<float>("P4RifleryMod");
        fastHorseMod = GameFlags.GetGameFlagValue<float>("P4FastHorseMod");
        gunMod = GameFlags.GetGameFlagValue<float>("P4GunMod");
        braveryMod = GameFlags.GetGameFlagValue<float>("P4BraveryMod");
        crazyMod = GameFlags.GetGameFlagValue<float>("P4CrazyMod");
        horseSkillMod = GameFlags.GetGameFlagValue<float>("P4HorseSkillMod");

        _stealChance = GameFlags.GetGameFlagValue <int>("P4StealChance");
        _fastChance = GameFlags.GetGameFlagValue <int>("P4FastChance");

        newWarriors = 0;
        newWarriorsWives = 0;
        totalNew = 0;
        totalShrink = 0;

        bowUp = false;
        rifleUp = false;
        horseUp = false;

        #region Init Personal details
        _season1List = new RandomList("SEASON1_LIST");
        _season2List = new RandomList("SEASON2_LIST");
        _season3List = new RandomList("SEASON3_LIST");
        _season4List = new RandomList("SEASON4_LIST");
        _season5List = new RandomList("SEASON5_LIST");
        _season6List = new RandomList("SEASON6_LIST");
        _season7List = new RandomList("SEASON7_LIST");

        _season1List.Add("1", "Your niece is getting bigger. Sometimes she climbs trees and no one can find her.", 100, 1);
        _season1List.Add("2", "Your niece is getting bigger. She likes to hide in berry bushes and stuff her mouth full.", 100, 1);

        _season2List.Add("1", "You continue courting Blue Feather. You give a gift of two horses to Blue Feather’s father.", 100, 1);
        //_season2List.add("2", "season 2: You ...", 100, 1);

        var tutor = "You spent time this season teaching the younger men how to";

        // TODO badges
        
        // check lev 3's
        if (Quest.GetQuest("horse_sense").Rank == 3)
        {
            tutor += " ride and train horses.";
        }
        else if (Quest.GetQuest("archery").Rank == 3)
        {
            tutor += " improve their skill with bow and arrow.";
        }
        else if (Quest.GetQuest("riflery").Rank == 3)
        {
            tutor += " improve their skill with a rifle.";
        }
        else if (Quest.GetQuest("horse_sense").Rank == 2)
        {
            tutor += " ride and train horses.";
        }
        else if (Quest.GetQuest("archery").Rank == 2)
        {
            tutor += " improve their skill with bow and arrow.";
        }
        else if (Quest.GetQuest("riflery").Rank == 2)
        {
            tutor += " improve their skill with a rifle.";
        }
        else if (Quest.GetQuest("horse_sense").Rank == 1)
        {
            tutor += " ride and train horses.";
        }
        else if (Quest.GetQuest("archery").Rank == 1)
        {
            tutor += " improve their skill with bow and arrow.";
        }
        else if (Quest.GetQuest("riflery").Rank == 1)
        {
            tutor += " improve their skill with a rifle.";
        }
        else
        {
            tutor += " ride and train horses.";
        }
        

        _season3List.Add("1", tutor, 100, 1);
        //_season3List.add("2", "season 3: You ...", 100, 1);

        _season4List.Add("1", "You and Crooked Rabbit made a sled out of buffalo ribs and took some of the younger boys sledding.", 100, 1);
        //_season4List.add("2", "season 4: You ...", 100, 1);

        _season5List.Add("1", "You continue courting Blue Feather. You give a gift to her brother.", 100, 1);
        _season5List.Add("2", "You see more white people in your lands. Many miners are breaking the treaty.", 100, 1);

        _season6List.Add("1", "You see more white soldiers than usual. Fort Robinson, near the Red Cloud Agency, is as busy as you’ve ever seen.", 100, 1);
        _season6List.Add("2", "You hear that huge numbers of white soldiers are exploring the Black Hills in search of gold.", 100, 1);

        _season7List.Add("1", "Many of our people had burning fevers, but the medicine men healed most of them.", 100, 1);
        _season7List.Add("2", "You discover that Blue Feather is a better rider than you and she can tame any horse.", 100, 1);
        #endregion

    } // Init
    #endregion

 
    public static void OneTimeInit()
    {
        if( GameFlags.GetGameFlagValue<bool>("P4DidOnetimeInit") )
        {
            M3.Out("skipping one time init");
            return;
        }

        M3.Out("one time init ");

        GameFlags.SetGameFlagValue("P4DidOnetimeInit", "true");

        GameFlags.SetGameFlagValue("P4MetMiners", "false");
        GameFlags.SetGameFlagValue("P4MetHunters", "false");
        GameFlags.SetGameFlagValue("P4MetSettlers", "false");
        GameFlags.SetGameFlagValue("P4DoReprisal", "false");

        // init social flags
        GameFlags.SetGameFlagValue("P4DullKnife", "false");
        GameFlags.SetGameFlagValue("P4CrazyHorse", "false");
        GameFlags.SetGameFlagValue("P4LittleWolf", "false");
        GameFlags.SetGameFlagValue("P4SittingBull", "false");

        // have we already commented on you meeting them?
        GameFlags.SetGameFlagValue("P4DullKnifeMsg", "false");
        GameFlags.SetGameFlagValue("P4CrazyHorseMsg", "false");
        GameFlags.SetGameFlagValue("P4LittleWolfMsg", "false");
        GameFlags.SetGameFlagValue("P4SittingBullMsg", "false");

        // gets inc'ed after this
        GameFlags.SetGameFlagValue("P4SeasonCount", "0");

        // resetting population values 
        childCount = GameFlags.GetGameFlagValue<int>("P4ChildStart");
        elderCount = GameFlags.GetGameFlagValue<int>("P4ElderStart");
        femaleCount = GameFlags.GetGameFlagValue<int>("P4FemaleStart");
        warriorCount = GameFlags.GetGameFlagValue<int>("P4WarriorStart");

        GameFlags.SetGameFlagValue("P4TribeHealth", "" + 0);

        //firstHunt = true;


        //buffaloChance = GameFlags.GetGameFlagValue<int>("P4BaseBuffaloChance");
        buffaloDrop = GameFlags.GetGameFlagValue<int>("P4SeasonDrop");
        firstHunt = true;
    }

    */

} // class

