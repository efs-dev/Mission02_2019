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
//CLASS Dialog_p4_choice1
public class Dialog_p4_choice1 {
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
        ///DIALOG_ID p4_choice1
        var dialog = new Dialog();
        dialog.Id = "p4_choice1";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 CHOICE1
        node.Npc = "CHOICE1";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You have time to do THREE things before the Commissioner arrives and decides Morgan's fate.
        prompt.Text = "You have time to do THREE things before the Commissioner arrives and decides Morgan's fate.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Send a telegraph message to Morgan's family in Philadelphia.
        response.Text = "Send a telegraph message to Morgan's family in Philadelphia.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 END
        response.NextNodeId = "END";
        response.SetCondition(n01_r0_condition);
        response.OnSelect(n01_r0_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Go to the place where Morgan was grabbed and look for evidence.
        response.Text = "Go to the place where Morgan was grabbed and look for evidence.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 END
        response.NextNodeId = "END";
        response.OnSelect(n01_r1_select);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Talk to people in Ripley and try to find witnesses.
        response.Text = "Talk to people in Ripley and try to find witnesses.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 END
        response.NextNodeId = "END";
        response.OnSelect(n01_r2_select);
        
        ///NODE_END n01
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//					if( ?P3_TELEGRAPH  )*/
        return GameFlags.P3Telegraph;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//				endState("telegraph", "CROSSFADE")	*/
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//				endState("ambush", "CROSSFADE")*/
        GameFlags.P4VisitedAmbush1 = true;
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n01_r2_select
    public void n01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_select
        /*//					endState("witness", "CROSSFADE")*/
        GameFlags.P4VisitedWitness1 = true;
        ///METHOD_BODY_END n01_r2_select
    }
}
//CLASS_END Dialog_p4_choice1
