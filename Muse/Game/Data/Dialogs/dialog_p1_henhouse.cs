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
//CLASS Dialog_p1_henhouse
public class Dialog_p1_henhouse {
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
        ///DIALOG_ID p1_henhouse
        var dialog = new Dialog();
        dialog.Id = "p1_henhouse";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 HENHOUSE
        node.Npc = "HENHOUSE";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 [There is an empty basket just inside the door.]
        prompt.Text = "[There is an empty basket just inside the door.]";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Steal food] Collect all the eggs but hide most under the hen house until later.
        response.Text = "[Steal food] Collect all the eggs but hide most under the hen house until later.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        response.OnSelect(n01_r0_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Collect eggs quickly and carelessly, breaking some.
        response.Text = "Collect eggs quickly and carelessly, breaking some.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
        response.NextNodeId = "n02";
        response.OnSelect(n01_r1_select);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 [Waste time] Collect all the eggs, but take time to pet and play with your favorite hens.
        response.Text = "[Waste time] Collect all the eggs, but take time to pet and play with your favorite hens.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
        response.NextNodeId = "n02";
        response.OnSelect(n01_r2_select);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 [Obey Mr. Otis] Collect all the eggs quickly, but carefully.
        response.Text = "[Obey Mr. Otis] Collect all the eggs quickly, but carefully.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n02
        response.NextNodeId = "n02";
        response.OnSelect(n01_r3_select);
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 HENHOUSE
        node.Npc = "HENHOUSE";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 [You drop the eggs off with Esther in the kitchen. She's too busy to chat with you now.]
        prompt.Text = "[You drop the eggs off with Esther in the kitchen. She's too busy to chat with you now.]";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n02_p0_show);
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [Leave]
        response.Text = "[Leave]";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n02
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n02_p0_show
    public void n02_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n02_p0_show
        /*//log("")*/
        ///METHOD_BODY_END n02_p0_show
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//#egg_code = 4
        //#p1_total_tasks= #p1_total_tasks+2
        //#ptasks_complete= #ptasks_complete+1
        //if(  hasBadge("BADGE_RESISTANCE") = false )
        //	overlayPopup("resisted_popup")
        ///if
        //#res_points = #res_points + 2*/
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//#egg_code = 3
        //#p1_total_tasks= #p1_total_tasks+2
        //#ptasks_complete= #ptasks_complete+1
        //if(  hasBadge("BADGE_RESISTANCE") = false )
        //	overlayPopup("resisted_popup")
        ///if
        //#res_points = #res_points + 1*/
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n01_r2_select
    public void n01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_select
        /*//#egg_code = 2
        //#p1_total_tasks= #p1_total_tasks+3
        //#ptasks_complete= #ptasks_complete+1
        //if(  hasBadge("BADGE_RESISTANCE") = false )
        //	overlayPopup("resisted_popup")
        ///if
        //#res_points = #res_points + 1*/
        ///METHOD_BODY_END n01_r2_select
    }

    ///METHOD n01_r3_select
    public void n01_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r3_select
        /*//#egg_code = 1
        //#p1_total_tasks= #p1_total_tasks+2
        //#ptasks_complete= #ptasks_complete+1*/
        
        ///METHOD_BODY_END n01_r3_select
    }
}
//CLASS_END Dialog_p1_henhouse
