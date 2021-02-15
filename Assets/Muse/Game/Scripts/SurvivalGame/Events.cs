using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using randomlist;

#if DEPRECATED
public partial class SurvivalGame
{

    public static void DoBigRaid()
    {
        M3.Out("doBigRaid()");

        var dead = 0;
        var newFood = 0;
        var newSupply = 0;
        var gotGun = false;
        var countedCoup = false;
        var bowUp = false;
        var gunUp = false;

        _bigRaidCount++;  // start at one

        int i;
        int r;

        // each warrior 5% chance of being killed
        for (i = 0; i < warriorCount; i++)
        {
            r = Random(100);
            if (r < (5 * _bigRaidCount))
            {
                M3.Out("warrior killed");
                warriorCount -= 1;
                dead++;
            }
        }

        // each survivor steals 1 - 3 food and  
        //50% 1 supply
        for (i = 0; i < warriorCount; i++)
        {
            r = Random(3) + 1;
            newFood += r;

            r = Random(100);
            if (r < 50)
            {
                newSupply++;
            }
        }
        M3.IncFlag("P4Food", newFood);
        M3.IncFlag("P4Supplies,", newSupply);

        // 20 % repeating rifle GameFlags.P4GunCount++
        r = Random(100);
        if (r < 20)
        {
            gotGun = true;
            M3.IncFlag("P4GunCount", 1);
        }

        //50% count coup
        r = Random(100);
        if (r < 50)
        {
            M3.Out("Counted coup");
            M3.IncFlag("tBravery", 1);
            M3.SimpleAlert("Title", "You acted bravely.");

            countedCoup = true;
        }

        // 50% inc skill
        r = Random(100);
        if (r < 50)
        {
            // TODO var bm:BadgeManager = BadgeManager.getInstance();

            r = Random(100);
            if (false /* todo bm.hasBadge("BADGE_ARCHERY3") && bm.hasBadge("BADGE_RIFLERY3") */)
            {
                // terrific
            }
            else if (r < 50)
            {
                bowUp = true;
                M3.IncFlag("tArchery", 1);
            }
            else
            {
                gunUp = true;
                M3.IncFlag("tRiflery", 1);
            }
            // 50% bow chance unless aT 3 / 50% RIFLE UNLESS AT 3 

        }

        /*
			 * You atk the supply train. while 2 warriors are killed, you take many oxen and cattle (58 food). You  
			 * 
			 */
        var ret = "";

        if (countedCoup)
        {
            if (gunUp)
            {
                ret = "You attack the supply train, and count coup on a soldier! Your skill with rifles goes up.";
            }
            else if (bowUp)
            {
                ret = "You attack the supply train, and count coup on a soldier! Your skill with a bow goes up.";
            }
            else
            {
                ret = "You attack the supply train, and count coup on a soldier!";
            }
        }
        else
        {
            if (gunUp)
            {
                ret = "You attack the supply train, and your skill with rifles goes up.";
            }
            else if (bowUp)
            {
                ret = "You attack the supply train, and your skill with the bow goes up.";
            }
            else
            {
                ret = "You attack the supply train.";
            }
        }

        if (dead == 1)
        {
            ret += " Your warriors take many oxen and cattle (" + newFood + " food), but 1 warrior is killed.";
        }
        else if (dead > 1)
        {
            ret += " Your warriors take many oxen and cattle (" + newFood + " food), but " + dead + " warriors are killed.";
        }
        else
        {
            ret += " Your warriors take many oxen and cattle (" + newFood + " food), and no warriors are hurt!";
        }

        if (newSupply > 1)
        {
            ret += " You also get some supplies (" + newSupply + ").";
        }

        if (gotGun)
        {
            ret += " Before riding away, you take a repeating rifle from a dead soldier.";
        }

        GameFlags.SetGameFlagValue("P4RaidResult", ret);

    }  // big raid

    public static void DoHorseRaid()
    {
        M3.Out("DoHorseRaid()");


        // init stats
        horsesStolen = 0; // normal horses
        newFastHorse = 0;
        hadFight = false;
        killCount = 0;
        countedCoup = false;

        // ??? why set this to zero ???
        //GameFlags.SetGameFlagValue("P4UpForTrade", ""+ 0);

        var r = 0;
        //  each warrior  to steal horse
        // each horse  fast
        for (var i = 0; i < warriorCount; i++)
        {
            r = SurvivalGame.Random(100);
            if (r < _stealChance)
            {
                M3.Out("stole a horse");
                r = Random(100);
                if (r < _fastChance)
                {
                    M3.Out("...it's FAST!");
                    newFastHorse++;
                    M3.IncFlag("P4HorseCount", 1);
                }
                else
                {
                    M3.Out("...it's normal speed");
                    horsesStolen++;
                }
            }
        }


        // 50% have fight
        r = Random(100);
        if (r < 50)
        {
            M3.Out("got into fight");
            hadFight = true;
            // 25% warrior killed
            r = Random(100);
            if (r < 25)
            {
                M3.Out("warrior killed");
                warriorCount -= 1;
            }

            // 50% counted coup
            r = Random(100);
            if (r < 50)
            {
                M3.Out("Counted coup");
                int b = GameFlags.GetGameFlagValue<int>("tBravery") + 1;
                GameFlags.SetGameFlagValue("tBravery", "" + b);
                M3.SimpleAlert("Improvement", "You acted bravely.");
                countedCoup = true;
            }
        }

        if (horsesStolen < 1) horsesStolen = 1;

        // calc how many horses up for trade
        upForTrade = (int)Mathf.Ceil(horsesStolen / 2);



        var ret = "Your raiding party steals ";
        var totalHorse = horsesStolen + newFastHorse;

        // # horses
        if (newFastHorse > 1)
        {
            ret += "" + totalHorse + " horses, including " + newFastHorse + " fast ones.";

        }
        else if (newFastHorse == 1)
        {
            ret += "" + totalHorse + " horses, including a fast one.";

        }
        else
        {
            if (horsesStolen == 1)
            {
                ret += "a single horse.";
            }
            else
            {
                ret += "" + horsesStolen + " horses.";
            }
        }

        // fight?
        if (hadFight)
        {

            string ri = GameFlags.GetGameFlagValue<string>("P4RaidInfo");

            if (killCount > 0)
            {
                ret += " You get into a fight with a small band of " + ri + ".";
                ret += " One of your warriors is killed.";
            }
            else
            {
                ret += " You get into a fight with a small band of " + ri + ", but luckily no one is hurt.";
            }

            if (countedCoup)
            {
                ret += " You count coup on an enemy - you acted bravely!";

            }
        }

        // 50% horsesense
        r = Random(100);
        if (r < 50)
        {
            M3.Out("horse sense increase");
            int hs = GameFlags.GetGameFlagValue<int>("tHorseSense") + 1;
            GameFlags.SetGameFlagValue("tHorseSense", "" + hs);

            ret += "\nYour skill with horses increases.";

        }

        GameFlags.SetGameFlagValue("P4RaidResult", ret);

    }

    // populate $p3_raid_result
    public static void DoRaid(string target)
    {
        M3.Out("doRaid()");

        switch (target)
        {
            case "miners2": // scare
                ScareMiners(); break;
            case "miners3":
                KillMiners(); break;
            case "surveyors2":
                KillSurveyors(); break;
            case "settlers2":
                KillSettlers(); break;
            default:
                M3.Out("Unrecognized raid type: " + target); break;
        }
    }



    public static void DoSmallRaid()
    {
        M3.Out("DoSmallRaid()");

        newFood = 0;
        newSupply = 0;
        gotHorse = false;

        int r = 0;
        // each warrior 0 - 2 food
        for (var i = 0; i < warriorCount; i++)
        {
            r = Random(3);
            newFood += r;

            // 25% supply
            r = Random(100);
            if (r < 25)
            {
                newSupply++;
            }
        }
        M3.IncFlag("P4Food", newFood);
        M3.IncFlag("P4Supplies", newSupply);

        // 25% fast horse
        r = Random(100);
        if (r < 25)
        {
            gotHorse = true;
            M3.IncFlag("P4HorseCount", 1);
        }

        string type = GameFlags.GetGameFlagValue<string>("P4RaidInfo");


        string ret = "Your raiding party ";

        switch (type)
        {
            case "settlers": ret += "sneaks onto the farm "; break;
            case "surveyors": ret += "sneaks into the camp "; break;
            case "miners": ret += "sneaks into the miners' camp "; break;
        }

        ret += "and escapes with some oxen and cattle (" + newFood + "). ";

        if ((newSupply > 0) && gotHorse)
        {
            ret += "You also get some supplies (" + newSupply + "), and take a fast-looking horse.";
            gotHorse = false;
        }
        else if (newSupply > 0)
        {
            ret += "You also get some supplies (" + newSupply + "). ";
        }

        if (gotHorse)
        {
            ret += "You also take a fast-looking horse.";
        }

        // your raiding party quietly sneaks in and escapes with some oxen and cattle (31 food ). You take a fast-looking horse. You also get 12 supplies.

        GameFlags.SetGameFlagValue("P4RaidResult", ret);
    }

    public static bool FindHerd()
    {
        M3.Out("FindHerd()");

        //public static attemptFindHerd(callback )

        //var turn = GameFlags.GetGameFlagValue <int>( "P4SupplyTurn");

        //Log.info("\nSupply turn: " + turn );

        //var value = 0;

        // roll random
        var rand = SurvivalGame.Random(100);

        M3.Out("...random roll: " + rand);
        M3.Out("...cur BuffaloChance: " + curBuffaloChance);



        // base chance can't drop below 30% 
        if (curBuffaloChance < 30) curBuffaloChance = 30;


        // mods
        float mods = 0;

        if (GameFlags.GetGameFlagValue<bool>("HasSpyglass"))
        {
            M3.Out("...adding spyglass mod +10");
            mods += 10;
        }

        float wisMod = (GameFlags.GetGameFlagValue<int>("tWisdom") * 2.5f);
        M3.Out("...adding wisdom * 2.5: " + wisMod);
        mods += wisMod;

        var elderMod = elderCount;
        //Log.info("...elder mod: " + elderMod);
        mods += elderMod;

        //trace("...find herd mods:",mods);

        // modified chance to find herd
        var modifiedChance = curBuffaloChance + (int)mods;

        // seasonal mods
        // ??

        if (GameFlags.GetGameFlagValue<bool>("P4DidBufDance"))
        {
            dance = true;
            GameFlags.SetGameFlagValue("P4DidBufDance", "false");
        }



        var curNode = GameFlags.GetGameFlagValue<string>("P4CurNode");
        //M3.Out("cur node: " + curNode);

        var seasonCount = GameFlags.GetGameFlagValue<int>("P4SeasonCount");

        // MODIFY CHANCE TO FIND HERD BASED ON LOCATION
        if (curNode == "hunting_grounds")
        {
            //Log.info("...hunting grounds mod");
            modifiedChance -= (10 * seasonCount);
        }
        else if (curNode == "sioux")
        {
            //Log.info("...great sioux mod");
            modifiedChance -= (5 * seasonCount);
        }



        var campBonus = GameFlags.GetGameFlagValue<bool>("P4CampBuffaloBonus");
        if (campBonus)
        {
            //Log.info("adding co-camping bonus to find");
            modifiedChance += 10;
        }


        // GUARANTEE FIRST HUNT Log.info("**** FIRST HUNT GUARANTEED FIND ****");
        if (firstHunt) rand = 2;


        // ADD IN BUFFALO DANCE MOD
        var danceBuf = GameFlags.GetGameFlagValue<int>("P4DanceBuff");

        if (dance)
        {
            modifiedChance += danceBuf;
            M3.Out("applied dance buff, chance now " + modifiedChance);
        }


        if (rand < modifiedChance)
        {
            //M3.Out("found a herd");
            // found a herd
            FoundHerd();
            return true;
        }
        else
        {
            M3.Out("did not find a herd");
            herdSizeString = "";  // none
            return false;  // found nothing
        }
    }





    private static void FoundHerd()
    {
        M3.Out("FoundHerd()");
        M3.Out("setting P4HuntedBufThisSeason true");


        GameFlags.SetGameFlagValue("P4HuntedBufThisSeason", "true");

        var herd = _herdList.Pick();
        //var item = _herdList.mostRecentItem;

        var herdMod = 1f;

        var wasted = false;

        ////////////////////// WHITE BUFF
        var chanceWhite = GameFlags.GetGameFlagValue<int>("P4WhiteBuffaloChance");
        // buf dance increases chance of white
        if (dance) chanceWhite += 10;

        var result = SurvivalGame.Random(100);

        bool foundWhite = result <= chanceWhite;
        if (foundWhite)
        {
            // found it!!
            GameFlags.SetGameFlagValue("P4WhiteBuf", "true");
            M3.Out("found a white! setting P4WhiteBuf to true");
            M3.IncFlag("P4WhiteBuffaloHides", 1);
        }

        /////////////////////////////////////////

        string hsize = "";

        Debug.Log("max herd size random number: " + curBuffaloSizeChance);
        var random = UnityEngine.Random.Range(0, curBuffaloSizeChance);

        var herdSizes = new string[] { "XS", "S", "M", "L", "XL" };
        for (var i = 0; i <= _herdWeights.Count; i++)
        {
            if (random < _herdWeights[i])
            {
                hsize = herdSizes[i];
                Debug.Log("herd size random: " + random + ", in category " + hsize + " -- " + _herdWeights[i]);
                break;
            }
        }

        herdSizeString = hsize;

        if (firstHunt)
        {
            M3.Out("**** FIRST HUNT GUARANTEED HERD SIZE ****");
            firstHunt = false;
            hsize = "L";
            herdSizeString = "L";
        }
        else
        {
            string curNode = GameFlags.GetGameFlagValue<string>("P4CurNode");
            // MODIFY  HERD BASED ON LOCATION
            if (curNode == "hunting_grounds")
            {
                M3.Out("...hunting grounds herd mod... always small"); // always small

                // no larger than SMALL
                if ((hsize == "XL") || (hsize == "L") || (hsize == "M"))
                {
                    hsize = "S";
                    herdSizeString = "S";
                }
            }
            else if (curNode == "sioux")
            {
                M3.Out("...great sioux herd mod - capped at med");

                // no larger than MED
                if ((hsize == "XL") || (hsize == "L"))
                {
                    hsize = "M";
                    herdSizeString = "M";
                }
            }
        }

        



        M3.Out("found herd size: " + hsize);

        string ret = "Your hunters find ";

        switch (hsize)
        {
            case "XS":
                _lastHerdSize = 0;
                herdMod = herdMods[0];
                GameFlags.SetGameFlagValue("P4HerdPrefix", "sml");
                ret += "a very small herd of buffalo.";
                break;
            case "S":
                _lastHerdSize = 1;
                herdMod = herdMods[1];
                GameFlags.SetGameFlagValue("P4HerdPrefix", "sml");
                ret += "a small herd of buffalo.";
                break;
            case "M":
                _lastHerdSize = 2;
                herdMod = herdMods[2];
                GameFlags.SetGameFlagValue("P4HerdPrefix", "med");
                ret += "a medium size herd of buffalo.";
                break;
            case "L":
                _lastHerdSize = 3;
                herdMod = herdMods[3];
                GameFlags.SetGameFlagValue("P4HerdPrefix", "lrg");
                ret += "a large herd of buffalo!";
                break;
            case "XL":
                _lastHerdSize = 4;
                herdMod = herdMods[4];
                GameFlags.SetGameFlagValue("P4HerdPrefix", "lrg");
                ret += "a huge herd of buffalo!";
                break;
            default:
                M3.Out("Unknown herd size!!");
                break;
        }
        //M3Tools.Out("roll and obj ");

        // add mods
        float fMod = 0;


        fMod += (M3.GetInt("tArchery") * archeryMod);   // %p3_archery_mod  
        fMod += (M3.GetInt("tRiflery") * rifleryMod);    // %p3_riflery_mod
        fMod += (M3.GetInt("P4HorseCount") * fastHorseMod);  // %p3_fasthorse_mod
        fMod += (M3.GetInt("P4GunCount") * gunMod);  // %p3_gun_mod
        fMod += (M3.GetInt("tBravery") * braveryMod);  // %p3_bravery_mod
        fMod += (M3.GetInt("tCrazy") * crazyMod);   // %p3_crazy_mod
        fMod += (M3.GetInt("tHorseSense") * horseSkillMod); // %p3_horse_skill_mod

        var specialsMod = (1 + (fMod / 100));

        M3.Out("warriors * herdMod: " + (warriorCount * herdMod));
        M3.Out("special food mods (horse, etc): " + specialsMod);

        float newFood = (warriorCount * herdMod) * specialsMod;
        M3.Out("total hunted: " + newFood);

        var campBonus = GameFlags.GetGameFlagValue<bool>("P4CampBuffaloBonus");
        if (campBonus)
        {
            M3.Out("adding co-camping bonus to raw meat yield");
            newFood *= 1.2f;
        }


        var baseP = GameFlags.GetGameFlagValue<float>("P4BaseProcessing");

        var supplyMod = (GameFlags.GetGameFlagValue<int>("P4Supplies") / 10) * .1f;
        M3.Out("supplymod " + supplyMod);

        int processLimit = (int)Mathf.Ceil(femaleCount * (baseP + supplyMod));
        M3.Out("      female processing limit (femcount * (baseProcessing + supplyMod)): " + processLimit);

        int wastedFood = 0;

        newFood = Mathf.Ceil(newFood);

        if (newFood > processLimit)
        {
            wastedFood = (int)(newFood - processLimit);
            GameFlags.SetGameFlagValue("P4Waste", "" + wastedFood);
            M3.Out("There is more meat than the women can process. Some is wasted.");
            //wastedFood = Math.ceil(wastedFood);
            if (wastedFood == 0) wastedFood = 1;
            wasted = true;
            newFood = processLimit;
        }
        else
        {
            GameFlags.SetGameFlagValue("P4Waste", "0");
            wasted = false;
        }

        M3.Out("     adjusted new food: " + newFood);
        GameFlags.SetGameFlagValue("P4NewFood", "" + newFood);

        var r = Random(100);
        string suitor = GameFlags.GetGameFlagValue<string>("P2SuitorChoice");

        string person;

        if (r < 25)
        {
            person = "Crooked Rabbit";
        }
        else if (r < 50)
        {
            person = "Your uncle";
        }
        else if (r < 75)
        {
            person = (suitor == "soc") ? "Black Moon" : "Many Horses";
        }
        else
        {
            person = "You";
        }

        string kill = (person == "You") ? "kill" : "kills";

        // create details
        if (foundWhite)
        {
            ret += " " + person;
            ret += " " + kill;
            ret += " a lucky white buffalo!";
        }
        else
        {
            r = Random(3);
            M3.Out("detail #" + r);
            switch (r)
            {
                case 0: ret += " You and the warriors kill many of them."; break;
                case 1: ret += " The hunt is a success, but one warrior is badly hurt."; break;
                case 2: ret += " " + person + " " + kill + " a buffalo with a single shot!"; break;
            }
        }

        // skill increase
        r = Random(100);
        if (r < 33)
        {
            // var bm:BadgeManager = BadgeManager.getInstance();

            r = Random(100);
            /*if (bm.hasBadge("BADGE_ARCHERY3") && bm.hasBadge("BADGE_RIFLERY3") && bm.hasBadge("BADGE_HORSESENSE3"))
            {
                // terrific
            }
            else 
            */

            if (r < 33)
            {
                M3.IncFlag("tArchery", 1);
                //GameFlags.tArchery++;
                ret += " You improve your bow skill.";
                bowUp = true;
            }
            else if (r < 66)
            {
                M3.IncFlag("tRiflery", 1);
                //GameFlags.tRiflery++;
                ret += " You get better at shooting a rifle.";
                rifleUp = true;
            }
            else
            {
                M3.IncFlag("tHorseSense", 1);
                //GameFlags.tHorseSense++;
                ret += " You gain more skill at riding a horse.";
                horseUp = true;
            }

        }

        //M3Tools.Out(">>> setting $p3_hunt_result to " + ret);
        GameFlags.SetGameFlagValue("P4HuntResult", ret);

        ret = "";
        if (wasted)
        {
            ret += " The women process as much of the meat and hides as they can (" + newFood + " food). However some food (" + wastedFood + ") will spoil before the women can get to it.";
        }
        else
        {
            ret += " The women process as much of the meat and hides as they can (" + newFood + " food).";
        }

        // M3Tools.Out(">>> setting $p3_process_result to " + ret);
        GameFlags.SetGameFlagValue("P4ProcessResult", ret);


    }


    private static void ScareMiners()
    {
        var ret = "Your warriors scream their war cries and gallop around the mining camp. Outnumbered, the miners flee. You take their oxen and cattle (";

        /* Your warriors scream their war cries and gallop around the mining camp. Outnumbered, the miners flee.
        You take their oxen and cattle (## food) and what tools and supplies you can (## supplies). FAST_HORSE SENTENCE IF APPLICABLE.
        You then make camp a ways upstream.
        */

        DoSmallRaid();

        ret += newFood;
        ret += " food) and what tools and supplies you can (";
        ret += newSupply + " supplies). ";

        if (gotHorse)
        {
            ret += "You also take a fast-looking horse. ";
        }

        ret += "You then make camp a bit upstream.";

        GameFlags.SetGameFlagValue("P4RaidResult", ret);
    }



    private static void KillMiners()
    {
        var ret = "The miners put up a brief fight before fleeing. ";

        DoSmallRaid();

        int dead = 0;

        //But chance for casualties. Use the 5% per warrior.
        for (var i = 0; i < warriorCount; i++)
        {
            var r = Random(100);
            if (r < 5)
            {
                dead++;
                warriorCount--;
            }
        }

        if (dead == 1)
        {
            ret += "But they kill 1 warrior.";
        }
        else if (dead > 1)
        {
            ret += "But they kill " + dead + " warriors.";
        }
        else
        {
            ret += "Luckily, no warriors are killed.";
        }

        ret += " You take their oxen and cattle (";

        ret += newFood;
        ret += " food) and what tools and supplies you can (";
        ret += newSupply + " supplies). ";

        if (gotHorse)
        {
            ret += "You also take a fast-looking horse. ";
        }

        ret += "You leave the mining camp to burn, and make your way further upstream.";

        GameFlags.SetGameFlagValue("P4RaidResult", ret);
    }


    private static void KillSurveyors()
    {

        var ret = "The surveyors and soldiers put up a brief fight before fleeing. ";

        DoSmallRaid();

        int dead = 0;

        //But chance for casualties. Use the 5% per warrior.
        for (var i = 0; i < warriorCount; i++)
        {
            var r = Random(100);
            if (r < 5)
            {
                dead++;
                warriorCount--;
            }
        }

        if (dead == 1)
        {
            ret += "But they kill 1 warrior.";
        }
        else if (dead > 1)
        {
            ret += "But they kill " + dead + " warriors.";
        }
        else
        {
            ret += "Luckily, no warriors are killed.";
        }

        ret += " You take their oxen and cattle (";

        ret += newFood;
        ret += " food) and what tools and supplies you can (";
        ret += newSupply + " supplies). ";

        if (gotHorse)
        {
            ret += "You also take a fast-looking horse. ";
        }

        ret += "You leave the camp to burn, and set up your tipis further upstream.";

        GameFlags.SetGameFlagValue("P4RaidResult", ret);
    }

    private static void KillSettlers()
    {

        var ret = "The homesteader and his family put up a brief fight before fleeing. ";

        DoSmallRaid();

        int dead = 0;

        //But chance for casualties. Use the 5% per warrior.
        for (var i = 0; i < warriorCount; i++)
        {
            var r = Random(100);
            if (r < 2)
            {
                dead++;
                warriorCount--;
            }
        }

        if (dead == 1)
        {
            ret += "But they kill 1 warrior.";
        }
        else if (dead > 1)
        {
            ret += "But they kill " + dead + " warriors.";
        }
        else
        {
            ret += "Luckily, no warriors are killed.";
        }

        ret += " You take their oxen and cattle (";

        ret += newFood;
        ret += " food) and what tools and supplies you can (";
        ret += newSupply + " supplies). ";

        if (gotHorse)
        {
            ret += "You also take a fast-looking horse. ";
        }

        ret += "You leave the farm to burn, and set up your tipis farther away.";

        GameFlags.SetGameFlagValue("P4RaidResult", ret);
    }

}
#endif