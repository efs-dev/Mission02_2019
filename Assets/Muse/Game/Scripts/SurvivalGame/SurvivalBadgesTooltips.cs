using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalBadgesTooltips : MonoBehaviour
{
    public ToolTipTrigger FindingBuffalo;
    public ToolTipTrigger HuntingBuffalo;
    public ToolTipTrigger PreparingMeat;
    /*
    public ToolTipTrigger WisdomBadge;
    public ToolTipTrigger BraveryBadge;
    public ToolTipTrigger RifleryBadge;
    public ToolTipTrigger ArcheryBadge;
    public ToolTipTrigger HorseBadge;
    public ToolTipTrigger GenerosityBadge;
    */
    public ToolTipTrigger Guns;
    public ToolTipTrigger Horses;
    public ToolTipTrigger Supplies;

    private void Start()
    {
        var elders = GameFlags.GetGameFlagValue<int>("P4ElderCount");
        var warriors = GameFlags.GetGameFlagValue<int>("P4WarriorCount");
        var women = GameFlags.GetGameFlagValue<int>("P4FemaleCount");
        /*
        var wisdom = Quest.GetQuest("wisdom").Rank;
        var bravery = Quest.GetQuest("bravery").Rank;
        var riflery = Quest.GetQuest("riflery").Rank;
        var archery = Quest.GetQuest("archery").Rank;
        var horse = Quest.GetQuest("horse_sense").Rank;
        var generosity = Quest.GetQuest("generosity").Rank;
        */

        var horses = GameFlags.GetGameFlagValue<int>("P4HorseCount");
        var guns = GameFlags.GetGameFlagValue<int>("P4GunCount");
        var supplies = GameFlags.GetGameFlagValue<int>("P4Supplies");

        FindingBuffalo.GetText = () =>
        {
            if (elders > 1)
                return "There are " + elders + " elders in your band.";
            else if (elders == 1)
                return "There is " + elders + " elder in your band.";
            else
                return "There are no elders in your band.";
        };

        HuntingBuffalo.GetText = () =>
        {
            if (elders > 1)
                return "There are " + warriors + " warriors in your band.";
            else if (elders == 1)
                return "There is " + warriors + " warrior in your band.";
            else
                return "There are no warriors in your band.";
        };

        PreparingMeat.GetText = () =>
        {
            if (women > 1)
                return "There are " + women + " women in your band.";
            else if (women == 1)
                return "There is " + women + " woman in your band.";
            else
                return "There are no women in your band.";
        };

        /*
        WisdomBadge.GetText = () =>
        {
            if (wisdom == 0)
                return "You do not have any wisdom badges.";
            else if (wisdom == 1)
                return "You have " + wisdom + " wisdom badge.";
            else
                return "You have " + wisdom + " wisdom badges.";
        };

        BraveryBadge.GetText = () =>
        {
            if (bravery == 0)
                return "You do not have any bravery badges.";
            else if (bravery == 1)
                return "You have " + bravery + " bravery badge.";
            else
                return "You have " + bravery + " bravery badges.";
        };

        RifleryBadge.GetText = () =>
        {
            if (riflery == 0)
                return "You do not have any riflery badges.";
            else if (riflery == 1)
                return "You have " + riflery + " riflery badge.";
            else
                return "You have " + riflery + " riflery badges.";
        };

        ArcheryBadge.GetText = () =>
        {
            if (archery == 0)
                return "You do not have any archery badges.";
            else if (archery == 1)
                return "You have " + archery + " archery badge.";
            else
                return "You have " + archery + " archery badges.";
        };

        HorseBadge.GetText = () =>
        {
            if (horse == 0)
                return "You do not have any horse sense badges.";
            else if (horse == 1)
                return "You have " + horse + " horse sense badge.";
            else
                return "You have " + horse + " horse sense badges.";
        };

        GenerosityBadge.GetText = () =>
        {
            if (generosity == 0)
                return "You do not have any generosity badges.";
            else if (generosity == 1)
                return "You have " + generosity + " generosity badge.";
            else
                return "You have " + generosity + " generosity badges.";
        };
        */

        Horses.GetText = () =>
        {
            if (horses == 1)
                return "You have " + horses + " fast horse.";
            else
                return "You have " + horses + " fast horses.";
        };

        Guns.GetText = () =>
        {
            if (guns == 1)
                return "You have " + guns + " gun.";
            else
                return "You have " + guns + " guns.";
        };

        Supplies.GetText = () =>
        {
            if (supplies == 1)
                return "You have " + supplies + " supplies";
            else
                return "You have " + supplies + " supplies.";
        };
    }

}
