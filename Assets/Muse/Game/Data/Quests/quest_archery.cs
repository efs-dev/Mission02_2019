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
//CLASS Quest_archery : Quest
public class Quest_archery : Quest {
    ///METHOD Quest_archery
    public Quest_archery (  ) {
        ///METHOD_BODY_START Quest_archery
        ///Id archery
        Id = "archery";
        ///MaxRank 3
        MaxRank = 3;
        ///Tags 
        Tags = new List<string>() {};
        ///GameFlagTriggers tArchery
        GameFlagTriggers = new List<string>() {"tArchery"};
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
        ///METHOD_BODY_END Quest_archery
    }

    ///METHOD GetTitle
    public string GetTitle ( Quest quest ) {
        ///METHOD_BODY_START GetTitle
        return "Archery";
        ///METHOD_BODY_END GetTitle
    }

    ///METHOD GetActiveDescription
    public string GetActiveDescription ( Quest quest ) {
        ///METHOD_BODY_START GetActiveDescription
        if (GameFlags.tArchery == 0)
        return "You have used a bow since you were a young boy. You can hit a few things, but it is usually as much luck as skill.";
        else if (GameFlags.tArchery == 1)
        return "You can shoot a bow from the back of a horse, although only at close range.";
        else if (GameFlags.tArchery == 2)
        return "You are as good a shot as most warriors. You can also make your own bow and arrows.";
        else
        return "You are among the best warriors when using a bow. You can usually kill a full-grown buffalo with a single arrow.";
        ///METHOD_BODY_END GetActiveDescription
    }

    ///METHOD GetCompleteDescription
    public string GetCompleteDescription ( Quest quest ) {
        ///METHOD_BODY_START GetCompleteDescription
        return "Archery";
        ///METHOD_BODY_END GetCompleteDescription
    }

    ///METHOD GetFailDescription
    public string GetFailDescription ( Quest quest ) {
        ///METHOD_BODY_START GetFailDescription
        return "Archery";
        ///METHOD_BODY_END GetFailDescription
    }

    ///METHOD OnTriggeredCallback
    public void OnTriggeredCallback ( Quest quest ) {
        ///METHOD_BODY_START OnTriggeredCallback
        if (GameFlags.tArchery == 1)
        IncrementBadgeRank (1, "Your skill with the bow is average.", "archery_rank1");
        else if (GameFlags.tArchery == 2)
        IncrementBadgeRank (1, "Your skill with the bow is good.", "archery_rank2");
        else if (GameFlags.tArchery == 3)
        IncrementBadgeRank (1, "Your skill with the bow is excellent", "archery_rank3");
        ///METHOD_BODY_END OnTriggeredCallback
    }
}
//CLASS_END Quest_archery : Quest
