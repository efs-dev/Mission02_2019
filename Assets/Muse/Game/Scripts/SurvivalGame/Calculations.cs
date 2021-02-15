using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using randomlist;

#if THIS_IS_DEPRECATED
public partial class SurvivalGame
{
    /*
    public static int CalcAgencyFood()
    {
        float percent = 75 + SurvivalGame.Random(20);

        percent *= .01f;

        var total = percent * GameFlags.GetGameFlagValue<int>("P4Population");
        total /= 3;

        M3.Out("calcAgencyFood total " + total);
        return (int)total;
    }
    */



    public static int CalcGame()
    {
        //System.Random rnd = new System.Random();

        var gchance = curGameChance / 100f;
        M3.Out("base game chance: " + gchance);
        var percent = gchance + (UnityEngine.Random.value * .10);
        M3.Out("calcGame " + (int)percent);

        var total = percent * GameFlags.GetGameFlagValue<int>("P4Population");
        M3.Out("...game hunt yields: " + total);
        return (int)total;
    }


    static int CalcPopulation()
    {
        var ret = childCount + elderCount + femaleCount + warriorCount;
        //M3.Out("calcPopulation(): " + ret);
        GameFlags.SetGameFlagValue("P4Population", "" + ret);

        return ret;
    }

    public static double CalcFoodRatio()
    {
        int food = GameFlags.GetGameFlagValue<int>("P4Food");
        int pop = GameFlags.GetGameFlagValue<int>("P4Population");

        double ret = Mathf.Ceil((food / pop));
        M3.Out("Food:Pop ratio=" + ret);

        foodRatio = ret;

        return ret;
    }

    // calculate how much food you need on an average turn : 1/3 season
    public static double CalcTurnFood()
    {
        M3.Out("calc turn food");

        var ret = CalcPopulation() / 3;

        return ret;
    }

#region CalcHealth, starve, etc
    static void CalcHealthUpDown(double foodRatio)
    {
        healthUp = false;
        healthDown = false;

        // CALC HEALTH LEVELS
        // health levs
        // -2, -1, 0, 1, 2

        var origHealth = GameFlags.GetGameFlagValue<int>("P4TribeHealth");

        int healthAdj;
        if (foodRatio >= 1.26)
        {
            healthAdj = 2;
        }
        else if (foodRatio >= 1.06)
        {
            healthAdj = 1;
        }
        else if (foodRatio >= .90)
        {
            healthAdj = 0;
        }
        else if (foodRatio >= .75)
        {
            healthAdj = -1;
        }
        else
        {
            healthAdj = -2;
        }


        int h = M3.GetInt("P4TribeHealth");

        if (healthAdj == 2)
        {
            h = M3.IncFlag("P4TribeHealth", 2);
            if (h > 2) GameFlags.SetGameFlagValue("P4TribeHealth", "" + 2); // cap it
        }
        else if (healthAdj == 1)
        {
            h = M3.GetInt("P4TribeHealth");
            if (h == -2) M3.IncFlag("P4TribeHealth", 2);
            else if (h < 1) M3.IncFlag("P4TribeHealth", 1);
        }
        else if (healthAdj == 0)
        {
            if (h < 0) M3.IncFlag("P4TribeHealth", 1);
            else if (h > 0) M3.IncFlag("P4TribeHealth", -1);
        }
        else if (healthAdj == -1)
        {
            if (h == -2) M3.IncFlag("P4TribeHealth", 1);
            else if (h > -1) M3.IncFlag("P4TribeHealth", -1);
        }
        else if (healthAdj == -2)
        {
            h = M3.IncFlag("P4TribeHealth", -2);
            if (h < -2) M3.SetInt("P4TribeHealth", -2); // cap it
        }

        if (origHealth > M3.GetInt("P4TribeHealth")) healthDown = true;
        else if (origHealth < M3.GetInt("P4TribeHealth")) healthUp = true;
    }

    static void CalcJoiningLeavingStarving(int food)
    {
        popDown = false;
        popUp = false;

        // check joining / leaving / staarving
        int h = M3.GetInt("P4TribeHealth");

        if ((h == -1) || (h == -2))
        {
            // if hungry or starving 

            var shortage = Mathf.Abs(food); // turn shortfall into positive number
            if (food < 0) food = 0;
            var shrinkage = 0;

            for (int i = 0; i < shortage; i++)
            {
                if (h == -1 || h == -2)
                {

                    shrinkage += CheckHungryStarving();
                }
            }
        }
        else if ((h == 1) || (h == 2))
        {
            // if healthy or very healthy
            var bonus = 0;
            for (var i = 0; i < food; i++)
            {
                bonus += CheckBonusPeople();  // check for extra ppl
            }
        }

        // deal with starve count
        if (M3.GetInt("P4TribeHealth") == -2)
        {
            // keep track of consecutive 'starves'
            starveCount++;
            M3.Out("incrementing starve count to " + starveCount);
            GameFlags.SetGameFlagValue("P4StarveCount", "" + starveCount);
        }
        else
        {
            // reset the starve count to break a 'streak'
            starveCount = 0;
        }
    }

#endregion


    // returns delta
    private static int CheckBonusPeople()
    {
        var roll = Random(100);

        if (roll > 4) return 0;  // 3% chance 1 - 3

        M3.Out("checking for bonus people: rolled: " + roll);

        roll = Random(4);


        switch (roll)
        {
            case 1: // warrior joins
                warriorCount++;
                totalNew++;
                popUp = true;
                return 1;
            case 2: // warrior and wife joins
                warriorCount++;
                femaleCount++;
                totalNew += 2;
                popUp = true;
                return 2;
            case 3: // warrior wife and child
                warriorCount++;
                femaleCount++;
                childCount++;
                totalNew += 3;
                popUp = true;
                return 3;
            case 4: // child becomes warrior
                childCount--;
                warriorCount++;
                return 0;
        }
        return 0;
    }

#region CalcSummary
    public static void CalcSummary()
    {
        M3.Out("end of season - CalcSummary()");


        int startPop = GameFlags.GetGameFlagValue<int>("P4Population");

        int population = startPop;

        int curFood = GameFlags.GetGameFlagValue<int>("P4Food");

        //M3.Out("cur node: " + GameFlags.GetGameFlagValue <string> ("P4CurNode"));

        //foodRatio = (int) CalcFoodRatio();

        var newFood = curFood - population;
        //var testFood = newFood;

        //M3.Out("food - pop: " + testFood);


        CalcHealthUpDown(CalcFoodRatio());

        CalcJoiningLeavingStarving(newFood);

        // unused?
        // reprisal points
        var rPoints = GameFlags.GetGameFlagValue<int>("P4Reprisal");



        CalcSuccessFB();
        CalcPopulationFB();



        CalcGoalFB();


        // SG these were commented out
        CalcPersonalFB();
        CalcDetailFB();

    }

    public static void CalcPersonalFB()
    {
        //string ret = "";

        var season = GameFlags.GetGameFlagValue<int>("P4SeasonCount");

        RandomList list = null;

        switch (season)
        {
            case 1: list = _season1List; break;
            case 2: list = _season2List; break;
            case 3: list = _season3List; break;
            case 4: list = _season4List; break;
            case 5: list = _season5List; break;
            case 6: list = _season6List; break;
            case 7: list = _season7List; break;
            default:
                M3.Out("CalcPersonalFB() unknown season: " + season);
                break;

        }

        // revisit this, doesn't seem properly populated
        string personal = "";


        try
        {
            personal = (string)list.Pick();
        }
        catch (System.Exception ex)
        {
            M3.Out("PersonalFB caught exception");
            personal = "Nothing unusual happened to you this season.";
        }


        GameFlags.SetGameFlagValue("P4PersonalFb", personal);


        // SG these were commented out...
        /*if( rifleUp ) {
            ret += "You are getting better at using rifles. "
            rifleUp = false;
        } else if( bowUp ) {
            ret += "Many people remarked that your accuracy with the bow has much improved. ";
            bowUp = false;
        } else if( horseUp ) {
            horseUp = false;
            ret += "Your skill with horses has increased. ";
        }

        var met = GameFlags.GetGameFlagValue<("?p3_met_wife");
        var msg = GameFlags.GetGameFlagValue<("?p3_met_wife_msg");


        // you've met wife and it is not summer
        M3Tools.Out("season: " + season);
        if( met && (season != 3) ) {
            if ( msg == false) {  // haven't shown msg
                ret += "You continue to court Blue Feather. ";
                scriptMgr.setPropertyValue("?p3_met_wife_msg", true); 
            }
        }

        if( ret.length == 0 ) {
            ret += "Nothing unusual happened to you this season.";
        }*/

    }


    public static void CalcPopulationFB()
    {
        string ret = "";

        M3.Out("calc population up/down " + popUp + "," + popDown);

        var gotWhite = GameFlags.GetGameFlagValue<bool>("P4WhiteBuf");
        M3.Out("... gotWhite buffalo " + gotWhite);

        if (gotWhite)
        {
            ret += "5 warriors and their wives join your band because you found a lucky white buffalo! ";
            warriorCount += 5;
            femaleCount += 5;
        }

        if (popUp)
        {
            if (gotWhite)
            {
                ret += "Additionally, because of your hunting success your band grows in size (+" + totalNew + "). ";
            }
            else
            {
                ret += "Because of your hunting success your band grows in size (+" + totalNew + "). ";
            }
            totalNew = 0;
            popUp = false;
        }
        else if (popDown)
        {
            if (gotWhite)
            {
                if (totalShrink == 1)
                {
                    ret += "However one person leaves your band to seek food at the Red Cloud Agency. ";
                }
                else
                {
                    ret += "However, your band shrinks in size as some people die and others seek food at the Red Cloud Agency (-" + totalShrink + "). ";
                }
            }
            else
            {
                var atAgency = (GameFlags.GetGameFlagValue<string>("P4CurNode") == "agency");
                string whereSeek = "seek food at the Red Cloud Agency ";
                if (atAgency) whereSeek = "leave seeking food from other bands ";

                if (totalShrink == 1)
                {
                    ret += "Your band shrinks slightly as one person leaves, seeking to join another band. ";
                }
                else
                {
                    ret += "Your band shrinks in size as some people die and others " + whereSeek + " (-" + totalShrink + "). ";
                }
            }
            totalShrink = 0;
            popDown = false;
        }
        else
        {
            if (gotWhite)
            {
                // nothing
            }
            else
            {
                ret += "Your band stays the same size.";
            }
        }

        // reset no matter what
        GameFlags.SetGameFlagValue("P4WhiteBuf", "false");


        M3.Out(">>" + ret);

        GameFlags.SetGameFlagValue("P4PopulationFb", ret);
    }


    private static void CalcGoalFB()
    {
        string ret = "";

        M3.Out("calc goal fb");

        var population = GameFlags.GetGameFlagValue<int>("P4Population");

        var food = GameFlags.GetGameFlagValue<int>("P4Food");
        food -= population;
        if (food < 0) food = 0;
        //Log.info(food);

        if (food > 0)
        {
            var goal = population - food;
            if (goal < 0) goal = 0;
            ret = "Next season you will only need to hunt and gather " + goal + " food, because you have " + food + " extra from this season.";
        }
        else
        {
            ret = "Next season you will need to hunt and gather " + population + " food.";
        }
        GameFlags.SetGameFlagValue("P4GoalFb", ret);
    }


    public static void CalcSuccessFB()
    {
        string ret = "";

        success = 0; // 1,2,3,4
                     // worst, bad, good, best

        string seasonString = GameFlags.GetGameFlagValue<string>("P4SeasonStr");

        // foodRatio = GlobalScripts.CalculateFoodRatio();
        if (foodRatio >= 1.33)
        {
            success = 4;
            M3.Out("best season");
            ret += "It was the best " + seasonString + " the elders can remember. Your band got enough food and much extra. ";

        }
        else if (foodRatio >= 1)
        {
            success = 3;
            M3.Out("good");
            ret += "It was a good " + seasonString + ". Your band got enough food and some extra. ";
        }
        else if (foodRatio >= .51)
        {
            success = 2;
            M3.Out("bad");
            ret += "It was a hard " + seasonString + ". Your band did not get enough food. ";

        }
        else
        {
            success = 1;
            M3.Out("worst");
            ret += "It was the worst " + seasonString + " the elders can remember. Your band got very little food. ";

        }

        if (healthUp)
        {
            ret += "The health of your people improves ('" + condition + "'). ";
        }
        else if (healthDown)
        {
            ret += "The health of your people goes down ('" + condition + "'). ";
        }
        else
        {

            if (starveCount > 1)
            {
                ret += "Your people are still starving! Soon you will be forced to seek rations at the Red Cloud Agency.";
            }
            else
            {
                ret += "Your people are " + condition + ". ";
            }
        }
        M3.Out(ret);

        GameFlags.SetGameFlagValue("P4SuccessFb", ret);
    }

    private static int CheckHungryStarving()
    {
        //M3.Out("checking for hungry starving");
        //var bad = true;

        // if HUNGRY 10%chance, if STARVING 30%
        var chance = (M3.GetInt("P4TribeHealth") == -1) ? 10 : 30;

        //trace("tribe health", GameFlags.P4TribeHealth);
        //trace("ill effect chance", chance);

        var roll = Random(100);
        if (roll > chance)
        {
            return 0;
        }

        popDown = true;
        int rnd = Random(4);
        switch (rnd)
        {
            case 1: // child dies
                childCount--;
                totalShrink++;
                break;
            case 2: // elder dies
                elderCount--;
                totalShrink++;
                //bad = true;
                break;
            case 3: // warrior leaves
                warriorCount--;
                totalShrink++;
                //trace("warrior leaves");
                break;
            case 4: // woman leaves
                femaleCount--;
                totalShrink++;
                //trace("female leaves");
                break;
        }

        return 1;
    }


#endregion



    public static void CalcDetailFB()
    {
        M3.Out("CalcDetailFB()");
        string ret = "";

        var detailCount = 0;

        var gotWhite = GameFlags.GetGameFlagValue<bool>("P4WhiteBuf");
        M3.Out("detail gotWhite " + gotWhite);
        M3.Out("...success: " + gotWhite);

        // 1 - 2 details
        if (gotWhite)
        {
            switch (success)
            {
                case 3:
                case 4:
                    ret += "You found a rare and lucky white buffalo. "; break;
                case 1:
                case 2:
                    ret += "A bright spot was finding a rare and lucky white buffalo. "; break;
            }
            detailCount++;
        }

        string berries = GameFlags.GetGameFlagValue<string>("P4Berries");

        if (berries != "")
        {
            switch (success)
            {
                case 3:
                case 4:
                    ret += "The women contributed to the bounty with " + berries + ". "; break;
                case 1:
                case 2:
                    ret += "The women, at least, were able to gather " + berries + ". "; break;
            }
            GameFlags.SetGameFlagValue("$p3_berries", ""); // clear it
            detailCount++;
        }

        if (detailCount < 2)
        {  // up to 2 details			
            if (GameFlags.GetGameFlagValue<bool>("P4ShareFood"))
            {
                ret += "Another band of Cheyenne shared some food, remembering your earlier generosity. ";
                GameFlags.SetGameFlagValue("P4ShareFood", "false"); // reset it	
                detailCount++;
            }
        }

        if (detailCount < 2)
        {
            M3.Out("herdsize string " + herdSizeString);

            // only comment if didn't find white buffalo
            if (gotWhite == false)
            {
                if (herdSizeString != "X")
                {   // if attempted a hunt...
                    switch (herdSizeString)
                    {
                        case "":
                            ret += "You tried, but found no buffalo. ";
                            break;
                        case "L":
                        case "XL":
                            ret += "You found plentiful buffalo. ";
                            break;
                        default:
                            ret += "You found some buffalo.";
                            break;
                    }
                    herdSizeString = "X"; // reset
                    detailCount++;
                }
            }
        }

        if (detailCount < 2)
        {
            if (GameFlags.GetGameFlagValue<bool>("P4DullKnifeMsg") == false)
            {
                if (GameFlags.GetGameFlagValue<bool>("P4DullKnife"))
                {
                    ret += "You camped with Chief Dull Knife and his band. ";  //he gave your band a gift of gun/horse You camped with Crazy Horse and his band.    //and he gave your band a gift of gun/horse
                    GameFlags.SetGameFlagValue("P4DullKnifeMsg", "true");
                    detailCount++;
                }
            }
        }

        if (detailCount < 2)
        {
            if (GameFlags.GetGameFlagValue<bool>("P4CrazyHorseMsg") == false)
            {
                if (GameFlags.GetGameFlagValue<bool>("P4CrazyHorse"))
                {
                    ret += "You camped with Crazy Horse and his band. ";  //he gave your band a gift of gun/horse You camped with Crazy Horse and his band.    //and he gave your band a gift of gun/horse
                    GameFlags.SetGameFlagValue("P4CrazyHorseMsg", "true");
                    detailCount++;
                }
            }
        }

        if (detailCount < 2)
        {
            if (GameFlags.GetGameFlagValue<bool>("P4LittleWolfMsg") == false)
            {
                if (GameFlags.GetGameFlagValue<bool>("P4LittleWolf"))
                {
                    ret += "You camped with Little Wolf and his band. ";  //he gave your band a gift of gun/horse You camped with Crazy Horse and his band.    //and he gave your band a gift of gun/horse
                    GameFlags.SetGameFlagValue("P4LittleWolfMsg", "true");
                    detailCount++;
                }
            }
        }

        if (detailCount < 2)
        {
            if (GameFlags.GetGameFlagValue<bool>("P4SittingBullMsg") == false)
            {
                if (GameFlags.GetGameFlagValue<bool>("P4SittingBull"))
                {
                    ret += "You camped with Sitting Bull and his band. ";  //he gave your band a gift of gun/horse You camped with Crazy Horse and his band.    //and he gave your band a gift of gun/horse
                    GameFlags.SetGameFlagValue("P4SittingBullMsg", "true");
                    detailCount++;
                }
            }
        }

        if (detailCount < 2)
        {
            if (GameFlags.GetGameFlagValue<bool>("P4Attended"))
            {
                ret += "You attended a Sun Dance.";
                GameFlags.SetGameFlagValue("P4Attended", "false");
                detailCount++;
            }
            else if (GameFlags.GetGameFlagValue<bool>("P4Hosted"))
            {
                ret += "You hosted a Sun Dance.";
                GameFlags.SetGameFlagValue("P4Hosted", "false");
                detailCount++;
            }
        }
        //if( detailCount > 1 ) break endDetail;




        GameFlags.SetGameFlagValue("P4DetailFb", ret);
    }
}
#endif