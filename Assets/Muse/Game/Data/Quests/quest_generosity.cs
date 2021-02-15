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
//CLASS Quest_generosity : Quest
public class Quest_generosity : Quest {
    ///METHOD Quest_generosity
    public Quest_generosity (  ) {
        ///METHOD_BODY_START Quest_generosity
        ///Id generosity
        Id = "generosity";
        ///MaxRank 3
        MaxRank = 3;
        ///Tags 
        Tags = new List<string>() {};
        ///GameFlagTriggers tGenerosity
        GameFlagTriggers = new List<string>() {"tGenerosity"};
        ///QuestType 1
        QuestType = 1;
        ///ColorTag 0
        ///TitleType CSharp
        DynamicTitle = GetTitle;
        ///ActiveType CSharp
        DynamicActiveDescription = GetActiveDescription;
        ///CompleteType CSharp
        ///FailType CSharp
        ///RankDescriptionText 
        OnTriggered = OnTriggeredCallback;
        ///METHOD_BODY_END Quest_generosity
    }

    ///METHOD GetTitle
    public string GetTitle ( Quest quest ) {
        ///METHOD_BODY_START GetTitle
        return "Generosity";
        ///METHOD_BODY_END GetTitle
    }

    ///METHOD GetActiveDescription
    public string GetActiveDescription ( Quest quest ) {
        ///METHOD_BODY_START GetActiveDescription
        return "Your people rely on each other to survive. Generosity makes that possible. Hunters always leave meat for the badger spirit, showing their generosity. Generous actions over time will increase your reputation.";
        ///METHOD_BODY_END GetActiveDescription
    }

    ///METHOD OnTriggeredCallback
    public void OnTriggeredCallback ( Quest quest ) {
        ///METHOD_BODY_START OnTriggeredCallback
        if (GameFlags.tGenerosity == 1)
        Actions.AlertFromId("generosity_point_tut");
        else if (GameFlags.tGenerosity == 2)
        IncrementBadgeRank (1, "Your generosity is known among your band.", "generosity_rank1");
        else if (GameFlags.tGenerosity < 4)
        Actions.AlertFromId("generosity_point");
        else if (GameFlags.tGenerosity == 4)
        IncrementBadgeRank (1, "Your generosity is known among the Northern Cheyenne.", "generosity_rank2");
        else if (GameFlags.tGenerosity < 6)
        Actions.AlertFromId("generosity_point");
        else if (GameFlags.tGenerosity == 6)
        IncrementBadgeRank (1, "Your generosity is known among all the People.", "generosity_rank3");
        ///METHOD_BODY_END OnTriggeredCallback
    }
}
//CLASS_END Quest_generosity : Quest
