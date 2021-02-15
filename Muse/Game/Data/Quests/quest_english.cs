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
//CLASS Quest_english : Quest
public class Quest_english : Quest {
    ///METHOD Quest_english
    public Quest_english (  ) {
        ///METHOD_BODY_START Quest_english
        ///Id english
        Id = "english";
        ///MaxRank 3
        MaxRank = 3;
        ///Tags 
        Tags = new List<string>() {};
        ///GameFlagTriggers tEnglish
        GameFlagTriggers = new List<string>() {"tEnglish"};
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
        ///METHOD_BODY_END Quest_english
    }

    ///METHOD GetTitle
    public string GetTitle ( Quest quest ) {
        ///METHOD_BODY_START GetTitle
        return Rank > 0 ? "English" : "???";
        ///METHOD_BODY_END GetTitle
    }

    ///METHOD GetActiveDescription
    public string GetActiveDescription ( Quest quest ) {
        ///METHOD_BODY_START GetActiveDescription
        if (GameFlags.tEnglish == 0)
        return "This is a skill you have not yet encountered or been trained in.";
        else if (GameFlags.tEnglish == 1)
        return "You have learned a few English words and phrases.";
        else if (GameFlags.tEnglish == 2)
        return "You can hold a conversation in English about common topics. You are familiar with the alphabet and can read a little.";
        else
        return "You are almost a fluent speaker of English and can talk about most things. You can read and are starting to write as well.";
        ///METHOD_BODY_END GetActiveDescription
    }

    ///METHOD GetCompleteDescription
    public string GetCompleteDescription ( Quest quest ) {
        ///METHOD_BODY_START GetCompleteDescription
        return "English";
        ///METHOD_BODY_END GetCompleteDescription
    }

    ///METHOD GetFailDescription
    public string GetFailDescription ( Quest quest ) {
        ///METHOD_BODY_START GetFailDescription
        return "English";
        ///METHOD_BODY_END GetFailDescription
    }

    ///METHOD OnTriggeredCallback
    public void OnTriggeredCallback ( Quest quest ) {
        ///METHOD_BODY_START OnTriggeredCallback
        if (GameFlags.tEnglish == 1)
        IncrementBadgeRank (1, "Your skill with English is basic.", "english_rank1");
        else if (GameFlags.tEnglish == 2)
        IncrementBadgeRank (1, "Your skill with English is conversant.", "english_rank2");
        else if (GameFlags.tEnglish == 3)
        IncrementBadgeRank (1, "Your skill with English is fluent.", "english_rank3");
        ///METHOD_BODY_END OnTriggeredCallback
    }
}
//CLASS_END Quest_english : Quest
