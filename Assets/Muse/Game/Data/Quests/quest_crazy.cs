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
//CLASS Quest_crazy : Quest
public class Quest_crazy : Quest {
    ///METHOD Quest_crazy
    public Quest_crazy (  ) {
        ///METHOD_BODY_START Quest_crazy
        ///Id crazy
        Id = "crazy";
        ///MaxRank 3
        MaxRank = 3;
        ///Tags 
        Tags = new List<string>() {};
        ///GameFlagTriggers tCrazy
        GameFlagTriggers = new List<string>() {"tCrazy"};
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
        ///METHOD_BODY_END Quest_crazy
    }

    ///METHOD GetTitle
    public string GetTitle ( Quest quest ) {
        ///METHOD_BODY_START GetTitle
        return "Crazy";
        ///METHOD_BODY_END GetTitle
    }

    ///METHOD GetActiveDescription
    public string GetActiveDescription ( Quest quest ) {
        ///METHOD_BODY_START GetActiveDescription
        return "Impulsive, crazy actions show our animal natures. Crazy may help warriors' energy, but, like the powerful lightning bolt, can also be destructive. Crazy actions over time will increase your reputation.";
        ///METHOD_BODY_END GetActiveDescription
    }

    ///METHOD OnTriggeredCallback
    public void OnTriggeredCallback ( Quest quest ) {
        ///METHOD_BODY_START OnTriggeredCallback
        if (GameFlags.tCrazy == 1)
        IncrementBadgeRank (1, "Your craziness is known among your band.", "crazy_rank1");
        else if (GameFlags.tCrazy == 2)
        IncrementBadgeRank (1, "Your craziness is known among the Northern Cheyene.", "crazy_rank2");
        else if (GameFlags.tCrazy == 3)
        IncrementBadgeRank (1, "Your craziness is known among all the People.", "crazy_rank3");
        ///METHOD_BODY_END OnTriggeredCallback
    }
}
//CLASS_END Quest_crazy : Quest
