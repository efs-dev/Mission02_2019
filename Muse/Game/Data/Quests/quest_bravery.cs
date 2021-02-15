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
//CLASS Quest_bravery : Quest
public class Quest_bravery : Quest {
    ///METHOD Quest_bravery
    public Quest_bravery (  ) {
        ///METHOD_BODY_START Quest_bravery
        ///Id bravery
        Id = "bravery";
        ///MaxRank 3
        MaxRank = 3;
        ///Tags 
        Tags = new List<string>() {};
        ///GameFlagTriggers tBravery
        GameFlagTriggers = new List<string>() {"tBravery"};
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
        ///METHOD_BODY_END Quest_bravery
    }

    ///METHOD GetTitle
    public string GetTitle ( Quest quest ) {
        ///METHOD_BODY_START GetTitle
        return "Bravery";
        ///METHOD_BODY_END GetTitle
    }

    ///METHOD GetActiveDescription
    public string GetActiveDescription ( Quest quest ) {
        ///METHOD_BODY_START GetActiveDescription
        return "The dragonfly represents bravery for its daring aerial acrobatics. Brave actions over time will increase your reputation.";
        ///METHOD_BODY_END GetActiveDescription
    }

    ///METHOD OnTriggeredCallback
    public void OnTriggeredCallback ( Quest quest ) {
        ///METHOD_BODY_START OnTriggeredCallback
        if (GameFlags.tBravery == 1)
        Actions.AlertFromId("bravery_point_tut");
        else if (GameFlags.tBravery < 3)
        Actions.AlertFromId("bravery_point");
        else if (GameFlags.tBravery == 3)
        IncrementBadgeRank (1, "Your bravery is known among your band.", "bravery_rank1");
        else if (GameFlags.tBravery < 6)
        Actions.AlertFromId("bravery_point");
        else if (GameFlags.tBravery == 6)
        IncrementBadgeRank (1, "Your bravery is known among the Northern Cheyenne.", "bravery_rank2");
        else if (GameFlags.tBravery < 9)
        Actions.AlertFromId("bravery_point");
        else if (GameFlags.tBravery == 9)
        IncrementBadgeRank (1, "Your bravery is known among all the People.", "bravery_rank3");
        ///METHOD_BODY_END OnTriggeredCallback
    }
}
//CLASS_END Quest_bravery : Quest
