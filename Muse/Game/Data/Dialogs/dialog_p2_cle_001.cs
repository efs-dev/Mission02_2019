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
//CLASS Dialog_p2_cle_001
public class Dialog_p2_cle_001 {
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
        ///DIALOG_ID p2_cle_001
        var dialog = new Dialog();
        dialog.Id = "p2_cle_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START NO_BERRIES
        node = dialog.CreateNode("NO_BERRIES");
        ///NODE_NPC NO_BERRIES CLE
        node.Npc = "CLE";
        ///NODE_RANDOM_RESPONSES NO_BERRIES False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NO_BERRIES Full
        ///NODE_VISUAL_USESCRIPT NO_BERRIES false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NO_BERRIES~|||~
        ///PROMPT NO_BERRIES 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NO_BERRIES 0 You reach this quiet spot with no trouble. There are blackberry bushes here, but it looks like wild animals and birds have eaten almost all of them.
        prompt.Text = "You reach this quiet spot with no trouble. There are blackberry bushes here, but it looks like wild animals and birds have eaten almost all of them.";
        ///PROMPT_IGNORE_VO NO_BERRIES 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NO_BERRIES 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NO_BERRIES 0 Rest here overnight.
        response.Text = "Rest here overnight.";
        ///RESPONSE_NEXT_NODE_TYPE NO_BERRIES 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NO_BERRIES 0 REST
        response.NextNodeId = "REST";
        
        ///RESPONSE NO_BERRIES 1
        response = node.AddResponse();
        ///RESPONSE_TEXT NO_BERRIES 1 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE NO_BERRIES 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NO_BERRIES 1 END
        response.NextNodeId = "END";
        
        ///NODE_END NO_BERRIES
        ///NODE_START REST
        node = dialog.CreateNode("REST");
        ///NODE_NPC REST CLE
        node.Npc = "CLE";
        ///NODE_RANDOM_RESPONSES REST False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE REST Full
        ///NODE_VISUAL_USESCRIPT REST false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~REST~|||~
        ///PROMPT REST 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT REST 0 The grass here is soft and the trees sheltering. You sleep here and wake feeling refreshed. [Health increases]
        prompt.Text = "The grass here is soft and the trees sheltering. You sleep here and wake feeling refreshed. [Health increases]";
        ///PROMPT_IGNORE_VO REST 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(REST_p0_show);
        
        ///RESPONSE REST 0
        response = node.AddResponse();
        ///RESPONSE_TEXT REST 0 Continue on...
        response.Text = "Continue on...";
        ///RESPONSE_NEXT_NODE_TYPE REST 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID REST 0 END
        response.NextNodeId = "END";
        
        ///NODE_END REST
        ///NODE_START BERRIES
        node = dialog.CreateNode("BERRIES");
        ///NODE_NPC BERRIES CLE
        node.Npc = "CLE";
        ///NODE_RANDOM_RESPONSES BERRIES False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE BERRIES Full
        ///NODE_VISUAL_USESCRIPT BERRIES false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~BERRIES~|||~
        ///PROMPT BERRIES 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT BERRIES 0 You reach this quiet spot with no trouble. There are bushes here full of delicious ripe blackberries. You eat some and take some with you for the days ahead.
        prompt.Text = "You reach this quiet spot with no trouble. There are bushes here full of delicious ripe blackberries. You eat some and take some with you for the days ahead.";
        ///PROMPT_IGNORE_VO BERRIES 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE BERRIES 0
        response = node.AddResponse();
        ///RESPONSE_TEXT BERRIES 0 Rest here overnight.
        response.Text = "Rest here overnight.";
        ///RESPONSE_NEXT_NODE_TYPE BERRIES 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BERRIES 0 REST
        response.NextNodeId = "REST";
        
        ///RESPONSE BERRIES 1
        response = node.AddResponse();
        ///RESPONSE_TEXT BERRIES 1 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE BERRIES 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BERRIES 1 END
        response.NextNodeId = "END";
        
        ///NODE_END BERRIES
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD REST_p0_show
    public void REST_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START REST_p0_show
        /*//				#lucy_health = #lucy_health + 1
        //				#henry_health = #henry_health + 1
        //				doDays()
        //				post("reportHealth", "")*/
        ///METHOD_BODY_END REST_p0_show
    }
}
//CLASS_END Dialog_p2_cle_001
