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
//CLASS Dialog_p1_ovr_002
public class Dialog_p1_ovr_002 {
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
        ///DIALOG_ID p1_ovr_002
        var dialog = new Dialog();
        dialog.Id = "p1_ovr_002";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You, girl! You finished your morning work?
        prompt.Text = "You, girl! You finished your morning work?";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 I slopped the hogs, Mr. Otis.
        response.Text = "I slopped the hogs, Mr. Otis.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n04
        response.NextNodeId = "n04";
        response.SetCondition(n01_r4_condition);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 I started the wash, Mr. Otis.
        response.Text = "I started the wash, Mr. Otis.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n04
        response.NextNodeId = "n04";
        response.SetCondition(n01_r3_condition);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 I collected the eggs, Mr. Otis.
        response.Text = "I collected the eggs, Mr. Otis.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n04
        response.NextNodeId = "n04";
        response.SetCondition(n01_r2_condition);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 I just have one more thing to do, Mr. Otis.
        response.Text = "I just have one more thing to do, Mr. Otis.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n03
        response.NextNodeId = "n03";
        response.SetCondition(n01_r1_condition);
        
        ///RESPONSE n01 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 4 Yes, Mr. Otis.
        response.Text = "Yes, Mr. Otis.";
        ///RESPONSE_NEXT_NODE_TYPE n01 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 4 n02
        response.NextNodeId = "n02";
        response.SetCondition(n01_r0_condition);
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Since Henry can't work, need you to take care of the smokehouse.
        prompt.Text = "Since Henry can't work, need you to take care of the smokehouse.";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 What do I need to do?
        response.Text = "What do I need to do?";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 You're about the laziest Negro this side of the river! You're going to take care of the smokehouse too today, since Henry can't do it.
        prompt.Text = "You're about the laziest Negro this side of the river! You're going to take care of the smokehouse too today, since Henry can't do it.";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What do I need to do?
        response.Text = "What do I need to do?";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 That's all you done?! I've had enough of your laziness.You and your family won't be seeing your father this Sunday!\n
        prompt.Text = "That's all you done?! I've had enough of your laziness.You and your family won't be seeing your father this Sunday!\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n04_p0_show);
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 [Stay silent]
        response.Text = "[Stay silent]";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 But we haven't seem him for weeks.
        response.Text = "But we haven't seem him for weeks.";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 I'm sorry, Mr. Otis. I'll do better.
        response.Text = "I'm sorry, Mr. Otis. I'll do better.";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 And you're going to take care of the smokehouse. I'll show you what it means to work.
        prompt.Text = "And you're going to take care of the smokehouse. I'll show you what it means to work.";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 What do I need to do?
        response.Text = "What do I need to do?";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 You're going to put some damp, green wood on the fire and then chop some more wood for tomorrow.
        prompt.Text = "You're going to put some damp, green wood on the fire and then chop some more wood for tomorrow.";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Yes, Mr. Otis.
        response.Text = "Yes, Mr. Otis.";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 And here's the key for the door. Make sure you lock it up when you done. Don't want no slaves stealing meat.
        prompt.Text = "And here's the key for the door. Make sure you lock it up when you done. Don't want no slaves stealing meat.";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 Yes, Mr. Otis.
        response.Text = "Yes, Mr. Otis.";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 END
        response.NextNodeId = "END";
        response.OnSelect(n07_r0_select);
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 What you say? You ain't seeing him until harvest's over because of your mouth!
        prompt.Text = "What you say? You ain't seeing him until harvest's over because of your mouth!";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n08_p0_show);
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n08
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n04_p0_show
    public void n04_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n04_p0_show
        /*//?pass_taken = true*/
        ///METHOD_BODY_END n04_p0_show
    }

    ///METHOD n08_p0_show
    public void n08_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n08_p0_show
        /*//?pass_taken = true*/
        ///METHOD_BODY_END n08_p0_show
    }

    ///METHOD n01_r4_condition
    public bool n01_r4_condition (  ) {
        ///METHOD_BODY_START n01_r4_condition
        /*//if (?hogs_complete AND (#ptasks_complete= 1))*/
        return true;
        ///METHOD_BODY_END n01_r4_condition
    }

    ///METHOD n01_r3_condition
    public bool n01_r3_condition (  ) {
        ///METHOD_BODY_START n01_r3_condition
        /*//if (?laundry_complete AND (#ptasks_complete = 1))*/
        return true;
        ///METHOD_BODY_END n01_r3_condition
    }

    ///METHOD n01_r2_condition
    public bool n01_r2_condition (  ) {
        ///METHOD_BODY_START n01_r2_condition
        /*//if (?eggs_complete AND (#ptasks_complete = 1))*/
        return true;
        ///METHOD_BODY_END n01_r2_condition
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if (#ptasks_complete = 2)*/
        return true;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if (#ptasks_complete = 3)*/
        return true;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n07_r0_select
    public void n07_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r0_select
        /*//addItem("smokehouse_key")*/
        ///METHOD_BODY_END n07_r0_select
    }
}
//CLASS_END Dialog_p1_ovr_002
