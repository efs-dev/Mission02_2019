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
//CLASS Dialog_p2_pre_001
public class Dialog_p2_pre_001 {
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
        ///DIALOG_ID p2_pre_001
        var dialog = new Dialog();
        dialog.Id = "p2_pre_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START HOME
        node = dialog.CreateNode("HOME");
        ///NODE_NPC HOME PRE
        node.Npc = "PRE";
        ///NODE_RANDOM_RESPONSES HOME False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HOME Full
        ///NODE_VISUAL_USESCRIPT HOME false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HOME~|||~
        ///PROMPT HOME 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HOME 0 Your father is overjoyed to see you. When you explain your situation his manner turns grim. He gives you some food and tells you to find his brother up north at the Skinner farm. He hugs you goodbye and wipes away a tear.
        prompt.Text = "Your father is overjoyed to see you. When you explain your situation his manner turns grim. He gives you some food and tells you to find his brother up north at the Skinner farm. He hugs you goodbye and wipes away a tear.";
        ///PROMPT_IGNORE_VO HOME 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HOME 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HOME 0 Say goodbye and leave.
        response.Text = "Say goodbye and leave.";
        ///RESPONSE_NEXT_NODE_TYPE HOME 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HOME 0 END
        response.NextNodeId = "END";
        response.OnSelect(HOME_r0_select);
        
        ///NODE_END HOME
        ///NODE_START NOT_HOME
        node = dialog.CreateNode("NOT_HOME");
        ///NODE_NPC NOT_HOME PRE
        node.Npc = "PRE";
        ///NODE_RANDOM_RESPONSES NOT_HOME False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NOT_HOME Full
        ///NODE_VISUAL_USESCRIPT NOT_HOME false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NOT_HOME~|||~
        ///PROMPT NOT_HOME 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NOT_HOME 0 You get to the Preston plantation and find out that unfortunately your father has been sent on an errand down to Lexington. It's not safe to stay here.
        prompt.Text = "You get to the Preston plantation and find out that unfortunately your father has been sent on an errand down to Lexington. It's not safe to stay here.";
        ///PROMPT_IGNORE_VO NOT_HOME 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NOT_HOME 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NOT_HOME 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE NOT_HOME 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NOT_HOME 0 END
        response.NextNodeId = "END";
        
        ///NODE_END NOT_HOME
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD HOME_r0_select
    public void HOME_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START HOME_r0_select
        /*//				#food = #food + 2
        //				updateMessage("Your father gives you 2 food.")*/
        GameFlags.P2LucyFood+=2;
        ///METHOD_BODY_END HOME_r0_select
    }
}
//CLASS_END Dialog_p2_pre_001
