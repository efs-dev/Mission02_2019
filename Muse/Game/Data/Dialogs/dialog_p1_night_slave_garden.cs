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
//CLASS Dialog_p1_night_slave_garden
public class Dialog_p1_night_slave_garden {
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
        ///DIALOG_ID p1_night_slave_garden
        var dialog = new Dialog();
        dialog.Id = "p1_night_slave_garden";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You can take some of the vegetables to have to eat during your escape.
        prompt.Text = "You can take some of the vegetables to have to eat during your escape.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Leave.
        response.Text = "Leave.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 End
        response.NextNodeType = DialogResponse.NextNodeTypes.End;
        ///RESPONSE_NEXT_NODE_ID n01 0 end
        response.NextNodeId = "end";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Take some food.
        response.Text = "Take some food.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 End
        response.NextNodeType = DialogResponse.NextNodeTypes.End;
        ///RESPONSE_NEXT_NODE_ID n01 1 end
        response.NextNodeId = "end";
        response.OnSelect(n01_r1_select);
        
        ///NODE_END n01
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        GameFlags.P2LucyFood+=2;
        ///METHOD_BODY_END n01_r1_select
    }
}
//CLASS_END Dialog_p1_night_slave_garden
