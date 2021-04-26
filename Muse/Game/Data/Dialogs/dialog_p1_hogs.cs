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
//CLASS Dialog_p1_hogs
public class Dialog_p1_hogs {
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
        ///DIALOG_ID p1_hogs
        var dialog = new Dialog();
        dialog.Id = "p1_hogs";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 HOGS
        node.Npc = "HOGS";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 [You go to the kitchen and get the slop bucket of food scraps.]
        prompt.Text = "[You go to the kitchen and get the slop bucket of food scraps.]";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Starve pigs] Dump the slop out of sight.
        response.Text = "[Starve pigs] Dump the slop out of sight.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n04
        response.NextNodeId = "n04";
        response.OnSelect(n01_r0_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 [Waste time] Take your time feeding the pigs and watch the little piglets play.
        response.Text = "[Waste time] Take your time feeding the pigs and watch the little piglets play.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n03
        response.NextNodeId = "n03";
        response.OnSelect(n01_r1_select);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 [Obey Mr. Otis] Feed the pigs quickly.
        response.Text = "[Obey Mr. Otis] Feed the pigs quickly.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
        response.NextNodeId = "n02";
        response.OnSelect(n01_r2_select);
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 HOGS
        node.Npc = "HOGS";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 [You do as you've been told. The pigs squeal as they jostle each other to get to the food. Afterward you bring the bucket back to the kitchen.]
        prompt.Text = "[You do as you've been told. The pigs squeal as they jostle each other to get to the food. Afterward you bring the bucket back to the kitchen.]";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 Go back to work.
        response.Text = "Go back to work.";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 HOGS
        node.Npc = "HOGS";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 [You feed the pigs a bit at a time. It's funny how they squeal and how dirty they get. You laugh softly so Mr. Otis doesn't hear. Afterward you bring the bucket back to the kitchen.]
        prompt.Text = "[You feed the pigs a bit at a time. It's funny how they squeal and how dirty they get. You laugh softly so Mr. Otis doesn't hear. Afterward you bring the bucket back to the kitchen.]";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 Go back to work.
        response.Text = "Go back to work.";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 HOGS
        node.Npc = "HOGS";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 [You dump the bucket out by the creek and then return it to the kitchen. Master's pigs are going to be a little skinnier.]
        prompt.Text = "[You dump the bucket out by the creek and then return it to the kitchen. Master's pigs are going to be a little skinnier.]";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Go back to work.
        response.Text = "Go back to work.";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n04
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//#hog_code = 3
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
        /*//#hog_code = 2
        //#p1_total_tasks= #p1_total_tasks+3
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
        /*//#hog_code = 1
        //#p1_total_tasks= #p1_total_tasks+2
        //#ptasks_complete= #ptasks_complete+1*/
        ///METHOD_BODY_END n01_r2_select
    }
}
//CLASS_END Dialog_p1_hogs
