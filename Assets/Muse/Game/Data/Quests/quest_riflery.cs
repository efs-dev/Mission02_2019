//USING
using UnityEngine;
//USING
using System;
//USING
using System.Collections;
//USING
using System.Collections.Generic;
//USING

//USING
[Quest]
//CLASS Quest_riflery : Quest
public class Quest_riflery : Quest {
    ///METHOD Quest_riflery
    public Quest_riflery (  ) {
        ///METHOD_BODY_START Quest_riflery
        ///Id riflery
        Id = "riflery";
        ///MaxRank 3
        MaxRank = 3;
        ///Tags 
        Tags = new List<string>() {};
        ///GameFlagTriggers tRiflery
        GameFlagTriggers = new List<string>() {"tRiflery"};
        ///QuestType 1
        QuestType = 1;
        ///ColorTag 0
        ///TitleType CSharp
        DynamicTitle = GetTitle;
        ///ActiveType CSharp
        DynamicActiveDescription = GetActiveDescription;
        ///CompleteType CSharp
        DynamicCompleteDescription = GetCompleteDescription;
        ///FailType CSharp
        DynamicFailDescription = GetFailDescription;
        ///RankDescriptionText 
        OnTriggered = OnTriggeredCallback;
        ///METHOD_BODY_END Quest_riflery
    }

    ///METHOD GetTitle
    public string GetTitle ( Quest quest ) {
        ///METHOD_BODY_START GetTitle
        return "Riflery";
        ///METHOD_BODY_END GetTitle
    }

    ///METHOD GetActiveDescription
    public string GetActiveDescription ( Quest quest ) {
        ///METHOD_BODY_START GetActiveDescription
        if (GameFlags.tRiflery == 0)
        return "Your skill in shooting a musket or rifle. You do not yet have any experience and probably could not even load a gun, much less hit anything with it.";
        else if (GameFlags.tRiflery == 1)
        return "You know the basics of using a musket or rifle. You can hit big things that are not too far.";
        else if (GameFlags.tRiflery == 2)
        return "You have shown some skill. You can usually bring down a buffalo in one or two shots.";
        else
        return "You are a crack shot with a gun. Your people admire that you can hit a running rabbit from a far distance.";
        ///METHOD_BODY_END GetActiveDescription
    }

    ///METHOD GetCompleteDescription
    public string GetCompleteDescription ( Quest quest ) {
        ///METHOD_BODY_START GetCompleteDescription
        return "Riflery";
        ///METHOD_BODY_END GetCompleteDescription
    }

    ///METHOD GetFailDescription
    public string GetFailDescription ( Quest quest ) {
        ///METHOD_BODY_START GetFailDescription
        return "Riflery";
        ///METHOD_BODY_END GetFailDescription
    }

    ///METHOD OnTriggeredCallback
    public void OnTriggeredCallback ( Quest quest ) {
        ///METHOD_BODY_START OnTriggeredCallback
        if (GameFlags.tRiflery == 1)
        IncrementBadgeRank (1, "Your skill with rifles is average.", "riflery_rank1");
        else if (GameFlags.tRiflery == 2)
        IncrementBadgeRank (1, "Your skill with rifles is good.", "riflery_rank2");
        else if (GameFlags.tRiflery == 3)
        IncrementBadgeRank (1, "Your skill with rifles is excellent", "riflery_rank3");
        ///METHOD_BODY_END OnTriggeredCallback
    }
}
//CLASS_END Quest_riflery : Quest
