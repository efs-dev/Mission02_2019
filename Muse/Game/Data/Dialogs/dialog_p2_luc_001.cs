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
//CLASS Dialog_p2_luc_001
public class Dialog_p2_luc_001 {
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
        ///DIALOG_ID p2_luc_001
        var dialog = new Dialog();
        dialog.Id = "p2_luc_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START N01
        node = dialog.CreateNode("N01");
        ///NODE_NPC N01 LUC
        node.Npc = "LUC";
        ///NODE_RANDOM_RESPONSES N01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE N01 Full
        ///NODE_VISUAL_USESCRIPT N01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~N01~|||~
        ///PROMPT N01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT N01 0 You collapse on the ground. You are just too tired, hungry and miserable to move another inch.  Eventually you are found by a patrol and returned to the King plantation.
        prompt.Text = "You collapse on the ground. You are just too tired, hungry and miserable to move another inch.  Eventually you are found by a patrol and returned to the King plantation.";
        ///PROMPT_IGNORE_VO N01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE N01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT N01 0 More
        response.Text = "More";
        ///RESPONSE_NEXT_NODE_TYPE N01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID N01 0 END
        response.NextNodeId = "END";
        response.OnSelect(N01_r0_select);
        
        ///NODE_END N01
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD N01_r0_select
    public void N01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START N01_r0_select
        /*//				endState("escape_end", "")*/
        ///METHOD_BODY_END N01_r0_select
    }
}
//CLASS_END Dialog_p2_luc_001
