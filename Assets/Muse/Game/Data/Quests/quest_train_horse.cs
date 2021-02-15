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
//CLASS Quest_train_horse : Quest
public class Quest_train_horse : Quest {
    ///METHOD Quest_train_horse
    public Quest_train_horse (  ) {
        ///METHOD_BODY_START Quest_train_horse
        ///Id train_horse
        Id = "train_horse";
        ///MaxRank 0
        MaxRank = 0;
        ///Tags 
        Tags = new List<string>() {};
        ///GameFlagTriggers P1HorseSuccess;P1HorseFail
        GameFlagTriggers = new List<string>() {"P1HorseSuccess","P1HorseFail"};
        ///QuestType 2
        QuestType = 2;
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
        ///METHOD_BODY_END Quest_train_horse
    }

    ///METHOD GetTitle
    public string GetTitle ( Quest quest ) {
        ///METHOD_BODY_START GetTitle
        return "Train the new horse.";
        ///METHOD_BODY_END GetTitle
    }

    ///METHOD GetActiveDescription
    public string GetActiveDescription ( Quest quest ) {
        ///METHOD_BODY_START GetActiveDescription
        return "Active";
        ///METHOD_BODY_END GetActiveDescription
    }

    ///METHOD GetCompleteDescription
    public string GetCompleteDescription ( Quest quest ) {
        ///METHOD_BODY_START GetCompleteDescription
        return "Complete";
        ///METHOD_BODY_END GetCompleteDescription
    }

    ///METHOD GetFailDescription
    public string GetFailDescription ( Quest quest ) {
        ///METHOD_BODY_START GetFailDescription
        return "Failed";
        ///METHOD_BODY_END GetFailDescription
    }

    ///METHOD OnTriggeredCallback
    public void OnTriggeredCallback ( Quest quest ) {
        ///METHOD_BODY_START OnTriggeredCallback
        if (GameFlags.P1HorseSuccess)
        Complete();
        else if (GameFlags.P1HorseFail)
        Fail();
        ///METHOD_BODY_END OnTriggeredCallback
    }
}
//CLASS_END Quest_train_horse : Quest
