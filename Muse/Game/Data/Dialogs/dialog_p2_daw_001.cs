//USING
using UnityEngine;
//USING
using System;
//USING
using System.Collections;
//USING
using System.Collections.Generic;
//USING
using System.Linq;
//USING
using Efs.Dialogs;
//CLASS Dialog_p2_daw_001
public class Dialog_p2_daw_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
    }
    //CLASS_END DialogGameFlagsClass
    //CLASS DialogScriptsClass
    public class DialogScriptsClass {
    }
    //CLASS_END DialogScriptsClass

    //PROPERTY DialogGameFlags
    private DialogGameFlagsClass DialogGameFlags = new DialogGameFlagsClass();

    //PROPERTY Scripts
    private DialogScriptsClass Scripts = new DialogScriptsClass();

    //PROPERTY DefaultNpc
    public string DefaultNpc = "";

    ///METHOD CreateDialog
    public Dialog CreateDialog (  ) {
        ///METHOD_BODY_START CreateDialog
        ///DIALOG_ID p2_daw_001
        var dialog = new Dialog();
        dialog.Id = "p2_daw_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START HOME
        node = dialog.CreateNode("HOME");
        ///NODE_NPC HOME DAW
        node.Npc = "DAW";
        ///NODE_RANDOM_RESPONSES HOME False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HOME Full
        ///NODE_VISUAL_USESCRIPT HOME false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HOME~|||~
        ///PROMPT HOME 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HOME 0 You arrive at the small Dawson farm and find Esther in the kitchen. She hugs you and gives you some food. She offers to hide you away for the night and let you rest.
        prompt.Text = "You arrive at the small Dawson farm and find Esther in the kitchen. She hugs you and gives you some food. She offers to hide you away for the night and let you rest.";
        ///PROMPT_IGNORE_VO HOME 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(HOME_p0_show);
        
        ///RESPONSE HOME 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HOME 0 Thank her, and stay the night.
        response.Text = "Thank her, and stay the night.";
        ///RESPONSE_NEXT_NODE_TYPE HOME 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HOME 0 STAY
        response.NextNodeId = "STAY";
        
        ///RESPONSE HOME 1
        response = node.AddResponse();
        ///RESPONSE_TEXT HOME 1 Thank her, but continue on your way.
        response.Text = "Thank her, but continue on your way.";
        ///RESPONSE_NEXT_NODE_TYPE HOME 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HOME 1 HINT
        response.NextNodeId = "HINT";
        
        ///NODE_END HOME
        ///NODE_START HOME_H
        node = dialog.CreateNode("HOME_H");
        ///NODE_NPC HOME_H DAW
        node.Npc = "DAW";
        ///NODE_RANDOM_RESPONSES HOME_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HOME_H Full
        ///NODE_VISUAL_USESCRIPT HOME_H false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HOME_H~|||~
        ///PROMPT HOME_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HOME_H 0 You arrive at the small Dawson farm and find Esther in the kitchen. She hugs you and gives you some food. She thinks it's risky for you and Henry to stay.
        prompt.Text = "You arrive at the small Dawson farm and find Esther in the kitchen. She hugs you and gives you some food. She thinks it's risky for you and Henry to stay.";
        ///PROMPT_IGNORE_VO HOME_H 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HOME_H 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HOME_H 0 Thank her, and continue on your way.
        response.Text = "Thank her, and continue on your way.";
        ///RESPONSE_NEXT_NODE_TYPE HOME_H 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HOME_H 0 HINT
        response.NextNodeId = "HINT";
        
        ///NODE_END HOME_H
        ///NODE_START HINT
        node = dialog.CreateNode("HINT");
        ///NODE_NPC HINT DAW
        node.Npc = "DAW";
        ///NODE_RANDOM_RESPONSES HINT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HINT Full
        ///NODE_VISUAL_USESCRIPT HINT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HINT~|||~
        ///PROMPT HINT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HINT 0 Just as you're leaving Esther says, \"I heard from the wagon driver there's a steward on the morning ferry from Maysville who helps runaways get across. Jackson's his name.\"
        prompt.Text = "Just as you're leaving Esther says, \"I heard from the wagon driver there's a steward on the morning ferry from Maysville who helps runaways get across. Jackson's his name.\"";
        ///PROMPT_IGNORE_VO HINT 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(HINT_p1_show);
        
        ///PROMPT HINT 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HINT 1 Just as you're leaving Esther says, \"I heard from the wagon driver you might get help in Maysville if you go to the back of the tavern.\"
        prompt.Text = "Just as you're leaving Esther says, \"I heard from the wagon driver you might get help in Maysville if you go to the back of the tavern.\"";
        ///PROMPT_IGNORE_VO HINT 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(HINT_p1_condition);
        prompt.OnShow(HINT_p0_show);
        
        ///RESPONSE HINT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HINT 0 Set off again.
        response.Text = "Set off again.";
        ///RESPONSE_NEXT_NODE_TYPE HINT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HINT 0 END
        response.NextNodeId = "END";
        response.OnSelect(HINT_r0_select);
        
        ///NODE_END HINT
        ///NODE_START STAY
        node = dialog.CreateNode("STAY");
        ///NODE_NPC STAY DAW
        node.Npc = "DAW";
        ///NODE_RANDOM_RESPONSES STAY False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE STAY Full
        ///NODE_VISUAL_USESCRIPT STAY false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~STAY~|||~
        ///PROMPT STAY 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT STAY 0 Esther hides you in the hayloft of the barn. You sleep well and feel refreshed. [Health improves]
        prompt.Text = "Esther hides you in the hayloft of the barn. You sleep well and feel refreshed. [Health improves]";
        ///PROMPT_IGNORE_VO STAY 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(STAY_p0_show);
        
        ///RESPONSE STAY 0
        response = node.AddResponse();
        ///RESPONSE_TEXT STAY 0 Thank Esther and leave.
        response.Text = "Thank Esther and leave.";
        ///RESPONSE_NEXT_NODE_TYPE STAY 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID STAY 0 HINT
        response.NextNodeId = "HINT";
        
        ///NODE_END STAY
        ///NODE_START NOT_HOME
        node = dialog.CreateNode("NOT_HOME");
        ///NODE_NPC NOT_HOME DAW
        node.Npc = "DAW";
        ///NODE_RANDOM_RESPONSES NOT_HOME False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NOT_HOME Full
        ///NODE_VISUAL_USESCRIPT NOT_HOME false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NOT_HOME~|||~
        ///PROMPT NOT_HOME 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NOT_HOME 0 You get to the Dawson farm and find the kitchen door locked. Through the window it looks as if no one is inside. Farmer Dawson is riding around keeping an eye on the other slaves. It's not safe to stay.
        prompt.Text = "You get to the Dawson farm and find the kitchen door locked. Through the window it looks as if no one is inside. Farmer Dawson is riding around keeping an eye on the other slaves. It's not safe to stay.";
        ///PROMPT_IGNORE_VO NOT_HOME 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NOT_HOME 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NOT_HOME 0 Continue on.
        response.Text = "Continue on.";
        ///RESPONSE_NEXT_NODE_TYPE NOT_HOME 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NOT_HOME 0 END
        response.NextNodeId = "END";
        
        ///NODE_END NOT_HOME
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD HINT_p1_condition
    public bool HINT_p1_condition (  ) {
        ///METHOD_BODY_START HINT_p1_condition
        /*// if( random(100) > 50 )*/
        return true;
        ///METHOD_BODY_END HINT_p1_condition
    }

    ///METHOD HOME_p0_show
    public void HOME_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START HOME_p0_show
        /*//				log("single log esther")*/
        ///METHOD_BODY_END HOME_p0_show
    }

    ///METHOD HINT_p1_show
    public void HINT_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START HINT_p1_show
        /*// ?p2_know_steward = true*/
        ///METHOD_BODY_END HINT_p1_show
    }

    ///METHOD HINT_p0_show
    public void HINT_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START HINT_p0_show
        /*// ?know_tavern = true*/
        ///METHOD_BODY_END HINT_p0_show
    }

    ///METHOD STAY_p0_show
    public void STAY_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START STAY_p0_show
        /*//				#days_passed = #days_passed + 1
        //				#lucy_health = #lucy_health + 1
        //				post("reportHealth", "")*/
        ///METHOD_BODY_END STAY_p0_show
    }

    ///METHOD HINT_r0_select
    public void HINT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START HINT_r0_select
        /*//				#food = #food + 2
        //				updateMessage("Esther gives you 2 food.")*/
        ///METHOD_BODY_END HINT_r0_select
    }
}
//CLASS_END Dialog_p2_daw_001
