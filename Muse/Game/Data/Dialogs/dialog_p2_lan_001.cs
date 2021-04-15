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
//CLASS Dialog_p2_lan_001
public class Dialog_p2_lan_001 {
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
        ///DIALOG_ID p2_lan_001
        var dialog = new Dialog();
        dialog.Id = "p2_lan_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START BOAT_H
        node = dialog.CreateNode("BOAT_H");
        ///NODE_NPC BOAT_H LAN
        node.Npc = "LAN";
        ///NODE_RANDOM_RESPONSES BOAT_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE BOAT_H Full
        ///NODE_VISUAL_USESCRIPT BOAT_H false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~BOAT_H~|||~
        ///PROMPT BOAT_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT BOAT_H 0 You make it across to Ohio! But... some slave catchers spot you. You and Henry run in different directions. The men chase Henry. A young white man sees you running and points to a house on top of a hill. \"Go see my father, Reverend Rankin!\" he says.
        prompt.Text = "You make it across to Ohio! But... some slave catchers spot you. You and Henry run in different directions. The men chase Henry. A young white man sees you running and points to a house on top of a hill. \"Go see my father, Reverend Rankin!\" he says.";
        ///PROMPT_IGNORE_VO BOAT_H 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE BOAT_H 0
        response = node.AddResponse();
        ///RESPONSE_TEXT BOAT_H 0 Go to the house
        response.Text = "Go to the house";
        ///RESPONSE_NEXT_NODE_TYPE BOAT_H 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BOAT_H 0 END
        response.NextNodeId = "END";
        response.OnSelect(BOAT_H_r0_select);
        
        ///NODE_END BOAT_H
        ///NODE_START BOAT
        node = dialog.CreateNode("BOAT");
        ///NODE_NPC BOAT LAN
        node.Npc = "LAN";
        ///NODE_RANDOM_RESPONSES BOAT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE BOAT Full
        ///NODE_VISUAL_USESCRIPT BOAT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~BOAT~|||~
        ///PROMPT BOAT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT BOAT 0 You make it across to Ohio! You freeze when you see you have been spotted by a young white man. He points to a house on the top of a hill. \"There are slave catchers along this river. You better go see my father, Reverend Rankin.\" he says.
        prompt.Text = "You make it across to Ohio! You freeze when you see you have been spotted by a young white man. He points to a house on the top of a hill. \"There are slave catchers along this river. You better go see my father, Reverend Rankin.\" he says.";
        ///PROMPT_IGNORE_VO BOAT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE BOAT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT BOAT 0 Go to the house
        response.Text = "Go to the house";
        ///RESPONSE_NEXT_NODE_TYPE BOAT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BOAT 0 END
        response.NextNodeId = "END";
        response.OnSelect(BOAT_r0_select);
        
        ///NODE_END BOAT
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 LAN
        node.Npc = "LAN";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You made it to the free state of Ohio! The steward sneaks you off at the Ripley ferry landing.
        prompt.Text = "You made it to the free state of Ohio! The steward sneaks you off at the Ripley ferry landing.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Thank him and leave
        response.Text = "Thank him and leave";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 END
        response.NextNodeId = "END";
        response.OnSelect(n01_r0_select);
        
        ///NODE_END n01
        ///NODE_START CAUGHT
        node = dialog.CreateNode("CAUGHT");
        ///NODE_NPC CAUGHT LAN
        node.Npc = "LAN";
        ///NODE_RANDOM_RESPONSES CAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CAUGHT Full
        ///NODE_VISUAL_USESCRIPT CAUGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CAUGHT~|||~
        ///PROMPT CAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CAUGHT 0 You made it to the free state of Ohio! The steward sneaks you off at the Ripley ferry landing. But before he can get Henry, Henry is discovered. He is bound and turned over to the captain who will take him back to the Maysville sheriff.
        prompt.Text = "You made it to the free state of Ohio! The steward sneaks you off at the Ripley ferry landing. But before he can get Henry, Henry is discovered. He is bound and turned over to the captain who will take him back to the Maysville sheriff.";
        ///PROMPT_IGNORE_VO CAUGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE CAUGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CAUGHT 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE CAUGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CAUGHT 0 END
        response.NextNodeId = "END";
        response.OnSelect(CAUGHT_r0_select);
        
        ///NODE_END CAUGHT
        ///NODE_START FARSIDE
        node = dialog.CreateNode("FARSIDE");
        ///NODE_NPC FARSIDE LAN
        node.Npc = "LAN";
        ///NODE_RANDOM_RESPONSES FARSIDE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FARSIDE Full
        ///NODE_VISUAL_USESCRIPT FARSIDE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FARSIDE~|||~
        ///PROMPT FARSIDE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FARSIDE 0 You learn about a Reverend in Ripley who might be able to help you more. You arrive on the far side and are directed to a house on a hill overlooking the river.
        prompt.Text = "You learn about a Reverend in Ripley who might be able to help you more. You arrive on the far side and are directed to a house on a hill overlooking the river.";
        ///PROMPT_IGNORE_VO FARSIDE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FARSIDE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FARSIDE 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE FARSIDE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FARSIDE 0 END
        response.NextNodeId = "END";
        response.OnSelect(FARSIDE_r0_select);
        
        ///NODE_END FARSIDE
        ///NODE_START FARSIDE_H
        node = dialog.CreateNode("FARSIDE_H");
        ///NODE_NPC FARSIDE_H LAN
        node.Npc = "LAN";
        ///NODE_RANDOM_RESPONSES FARSIDE_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FARSIDE_H Full
        ///NODE_VISUAL_USESCRIPT FARSIDE_H false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FARSIDE_H~|||~
        ///PROMPT FARSIDE_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FARSIDE_H 0 You learn about a Reverend in Ripley who might be able to help you more. Unfortunately, on  the far side your group is surprised by a band of slavecatchers. People flee in all directions. You manage to hide, but poor Henry is recaptured!
        prompt.Text = "You learn about a Reverend in Ripley who might be able to help you more. Unfortunately, on  the far side your group is surprised by a band of slavecatchers. People flee in all directions. You manage to hide, but poor Henry is recaptured!";
        ///PROMPT_IGNORE_VO FARSIDE_H 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FARSIDE_H 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FARSIDE_H 0 Sadly go on
        response.Text = "Sadly go on";
        ///RESPONSE_NEXT_NODE_TYPE FARSIDE_H 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FARSIDE_H 0 END
        response.NextNodeId = "END";
        response.OnSelect(FARSIDE_H_r0_select);
        
        ///NODE_END FARSIDE_H
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD BOAT_H_r0_select
    public void BOAT_H_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START BOAT_H_r0_select
        /*//				#p2_henry_code = 20
        //				killHenry()*/
        ///METHOD_BODY_END BOAT_H_r0_select
    }

    ///METHOD BOAT_r0_select
    public void BOAT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START BOAT_r0_select
        /*//				killHenry()*/
        ///METHOD_BODY_END BOAT_r0_select
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//				post("doTrip", "RIPLEY")*/
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD CAUGHT_r0_select
    public void CAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START CAUGHT_r0_select
        /*//				#p2_henry_code = 50
        //				killHenry()
        //				post("doTrip", "RIPLEY")*/
        ///METHOD_BODY_END CAUGHT_r0_select
    }

    ///METHOD FARSIDE_r0_select
    public void FARSIDE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FARSIDE_r0_select
        /*// post("doTrip", "RIPLEY")  */
        ///METHOD_BODY_END FARSIDE_r0_select
    }

    ///METHOD FARSIDE_H_r0_select
    public void FARSIDE_H_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FARSIDE_H_r0_select
        /*//				#p2_henry_code = 20
        //				killHenry()
        //				post("doTrip", "RIPLEY")*/
        ///METHOD_BODY_END FARSIDE_H_r0_select
    }
}
//CLASS_END Dialog_p2_lan_001
