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
//CLASS Quest_wisdom : Quest
public class Quest_wisdom : Quest {
    ///METHOD Quest_wisdom
    public Quest_wisdom (  ) {
        ///METHOD_BODY_START Quest_wisdom
        ///Id wisdom
        Id = "wisdom";
        ///MaxRank 3
        MaxRank = 3;
        ///Tags 
        Tags = new List<string>() {};
        ///GameFlagTriggers tWisdom
        GameFlagTriggers = new List<string>() {"tWisdom"};
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
        ///METHOD_BODY_END Quest_wisdom
    }

    ///METHOD GetTitle
    public string GetTitle ( Quest quest ) {
        ///METHOD_BODY_START GetTitle
        return "Wisdom";
        ///METHOD_BODY_END GetTitle
    }

    ///METHOD GetActiveDescription
    public string GetActiveDescription ( Quest quest ) {
        ///METHOD_BODY_START GetActiveDescription
        return "Purposeful action is better than foolish decisions. The bear represents wisdom -- dreaming of one signals an important idea. Wise actions over time will increase your reputation.";
        ///METHOD_BODY_END GetActiveDescription
    }

    ///METHOD OnTriggeredCallback
    public void OnTriggeredCallback ( Quest quest ) {
        ///METHOD_BODY_START OnTriggeredCallback
        if (GameFlags.tWisdom == 1)
        Actions.AlertFromId("wisdom_point_tut");
        else if (GameFlags.tWisdom == 2)
        IncrementBadgeRank (1, "Your wisdom is known among your band.", "wisdom_rank1");
        else if (GameFlags.tWisdom < 4)
        Actions.AlertFromId("wisdom_point");
        else if (GameFlags.tWisdom == 4)
        IncrementBadgeRank (1, "Your wisdom is known among the Northern Cheyenne.", "wisdom_rank2");
        else if (GameFlags.tWisdom < 6)
        Actions.AlertFromId("wisdom_point");
        else if (GameFlags.tWisdom == 6)
        IncrementBadgeRank (1, "Your wisdom is known among all the People.", "wisdom_rank3");
        ///METHOD_BODY_END OnTriggeredCallback
    }
}
//CLASS_END Quest_wisdom : Quest
