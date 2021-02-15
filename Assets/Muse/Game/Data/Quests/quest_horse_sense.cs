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
//CLASS Quest_horse_sense : Quest
public class Quest_horse_sense : Quest {
    ///METHOD Quest_horse_sense
    public Quest_horse_sense (  ) {
        ///METHOD_BODY_START Quest_horse_sense
        ///Id horse_sense
        Id = "horse_sense";
        ///MaxRank 3
        MaxRank = 3;
        ///Tags 
        Tags = new List<string>() {};
        ///GameFlagTriggers tHorseSense
        GameFlagTriggers = new List<string>() {"tHorseSense"};
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
        ///METHOD_BODY_END Quest_horse_sense
    }

    ///METHOD GetTitle
    public string GetTitle ( Quest quest ) {
        ///METHOD_BODY_START GetTitle
        return "Horse Sense";
        ///METHOD_BODY_END GetTitle
    }

    ///METHOD GetActiveDescription
    public string GetActiveDescription ( Quest quest ) {
        ///METHOD_BODY_START GetActiveDescription
        if (GameFlags.tHorseSense == 0)
        return "You can easily ride a calm horse and are learning to tame wilder ones. But a warrior will need much more skill.";
        else if (GameFlags.tHorseSense == 1)
        return "You can tame most wild horses and start training them for buffalo hunting.";
        else if (GameFlags.tHorseSense == 2)
        return "You can ride a horse well for both hunting and battle.";
        else
        return "You have a strong bond with horses and can coax them to run more boldly and faster than most other warriors can.";
        ///METHOD_BODY_END GetActiveDescription
    }

    ///METHOD GetCompleteDescription
    public string GetCompleteDescription ( Quest quest ) {
        ///METHOD_BODY_START GetCompleteDescription
        return "Horse Sense";
        ///METHOD_BODY_END GetCompleteDescription
    }

    ///METHOD GetFailDescription
    public string GetFailDescription ( Quest quest ) {
        ///METHOD_BODY_START GetFailDescription
        return "Horse Sense";
        ///METHOD_BODY_END GetFailDescription
    }

    ///METHOD OnTriggeredCallback
    public void OnTriggeredCallback ( Quest quest ) {
        ///METHOD_BODY_START OnTriggeredCallback
        if (GameFlags.tHorseSense == 1)
        IncrementBadgeRank (1, "Your skill riding horses is average.", "horsesense_rank1");
        else if (GameFlags.tHorseSense == 2)
        IncrementBadgeRank (1, "Your skill riding horses is good.", "horsesense_rank2");
        else if (GameFlags.tHorseSense == 3)
        IncrementBadgeRank (1, "Your skill riding horses is excellent", "horsesense_rank3");
        ///METHOD_BODY_END OnTriggeredCallback
    }
}
//CLASS_END Quest_horse_sense : Quest
