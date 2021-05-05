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
//CLASS Dialog_p1_wash_creek
public class Dialog_p1_wash_creek {
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
        ///DIALOG_ID p1_wash_creek
        var dialog = new Dialog();
        dialog.Id = "p1_wash_creek";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 WASH
        node.Npc = "WASH";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 [You fill up the bucket from the cold, rushing water of the creek and make several trips back to the Yard to fill the wash basin.]
        prompt.Text = "[You fill up the bucket from the cold, rushing water of the creek and make several trips back to the Yard to fill the wash basin.]";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Take some extra time to collect comfrey root]
        response.Text = "[Take some extra time to collect comfrey root]";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n01_r0_condition);
        response.OnSelect(n01_r0_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 [Take the last bucketful to back to the Yard]
        response.Text = "[Take the last bucketful to back to the Yard]";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 END
        response.NextNodeId = "END";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 WASH
        node.Npc = "WASH";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 [You collect enough comfrey to make a poultice for Henry's back.]
        prompt.Text = "[You collect enough comfrey to make a poultice for Henry's back.]";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [Return to the Yard]
        response.Text = "[Return to the Yard]";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 END
        response.NextNodeId = "END";
        response.OnSelect(n02_r0_select);
        
        ///NODE_END n02
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if( ?comfrey_complete = false )*/
        return !GameFlags.P1ComfreyComplete;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//?comfrey_complete = true
        //addItem("comfrey")*/
        GameFlags.P1ComfreyComplete = true;
        GameFlags.P1HasComfrey = true;
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n02_r0_select
    public void n02_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r0_select
        /*//#p1_total_tasks     += 1*/
        ///METHOD_BODY_END n02_r0_select
    }
}
//CLASS_END Dialog_p1_wash_creek
