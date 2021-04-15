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
//CLASS Dialog_p4_auc_001
public class Dialog_p4_auc_001 {
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
        ///DIALOG_ID p4_auc_001
        var dialog = new Dialog();
        dialog.Id = "p4_auc_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 AUC
        node.Npc = "AUC";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 As you wait for your turn on the auction block, you...
        prompt.Text = "As you wait for your turn on the auction block, you...";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Pray.
        response.Text = "Pray.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n05
        response.NextNodeId = "n05";
        response.OnSelect(n01_r3_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Look for ways to escape.
        response.Text = "Look for ways to escape.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n04
        response.NextNodeId = "n04";
        response.OnSelect(n01_r2_select);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Talk to the woman sitting next to you.
        response.Text = "Talk to the woman sitting next to you.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n03
        response.NextNodeId = "n03";
        response.OnSelect(n01_r1_select);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 Think about your family.
        response.Text = "Think about your family.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n02
        response.NextNodeId = "n02";
        response.OnSelect(n01_r0_select);
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 AUC
        node.Npc = "AUC";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 As scary and horrible as this place is, you are thankful that your actions spared Jonah from being here too. You imagine him in a better place, growing up, learning to read, and finding his way as a free man. You think of your mama. Maybe you'll be closer to her now. Maybe you can try and find her.
        prompt.Text = "As scary and horrible as this place is, you are thankful that your actions spared Jonah from being here too. You imagine him in a better place, growing up, learning to read, and finding his way as a free man. You think of your mama. Maybe you'll be closer to her now. Maybe you can try and find her.";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n02 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 1 You look down at Jonah and put your arm around him. He is scared but trying to be brave. Maybe the same person will buy both of you. But you concentrate on remembering what he looks like because you may never see him again.
        prompt.Text = "You look down at Jonah and put your arm around him. He is scared but trying to be brave. Maybe the same person will buy both of you. But you concentrate on remembering what he looks like because you may never see him again.";
        ///PROMPT_IGNORE_VO n02 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n02_p1_condition);
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 AUC
        node.Npc = "AUC";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 Mary is being sold from a Kentucky farm. She's heard that there are many buyers from the western state of Missouri and the new territory of Kansas. She thinks life will be hard on the frontier. But maybe it'll also be easier to escape. She's also heard that many anti-slavery folks are headed there.
        prompt.Text = "Mary is being sold from a Kentucky farm. She's heard that there are many buyers from the western state of Missouri and the new territory of Kansas. She thinks life will be hard on the frontier. But maybe it'll also be easier to escape. She's also heard that many anti-slavery folks are headed there.";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 AUC
        node.Npc = "AUC";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 You look around for anything that might help you escape. Your hands and legs are in chains and it's hard to move, but you find a loose nail and are able to hide it in the sleeve of your dress.
        prompt.Text = "You look around for anything that might help you escape. Your hands and legs are in chains and it's hard to move, but you find a loose nail and are able to hide it in the sleeve of your dress.";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n06
        response.NextNodeId = "n06";
        response.OnSelect(n04_r0_select);
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 AUC
        node.Npc = "AUC";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 You close your eyes and try not to hear the sound of the auctioneer's voice as you quietly pray. For what seems like a long time you forget about the world you're in and imagine a better place.
        prompt.Text = "You close your eyes and try not to hear the sound of the auctioneer's voice as you quietly pray. For what seems like a long time you forget about the world you're in and imagine a better place.";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 AUC
        node.Npc = "AUC";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 A man approaches, grabs your arm, yanks you to your feet, and leads you outside and up onto the auction block.
        prompt.Text = "A man approaches, grabs your arm, yanks you to your feet, and leads you outside and up onto the auction block.";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [To the auction...]
        response.Text = "[To the auction...]";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 AUC
        node.Npc = "AUC";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 You are startled when a man grabs your arm and yanks you to your feet. He pulls you outside to the auction block.
        prompt.Text = "You are startled when a man grabs your arm and yanks you to your feet. He pulls you outside to the auction block.";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 [To the auction...]
        response.Text = "[To the auction...]";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n07
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n02_p1_condition
    public bool n02_p1_condition (  ) {
        ///METHOD_BODY_START n02_p1_condition
        /*//if ((#p4_lucy_canada = 0) AND (?p4_jonah_servant = false))*/
        return true;
        ///METHOD_BODY_END n02_p1_condition
    }

    ///METHOD n01_r3_select
    public void n01_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r3_select
        /*//?p4_auction_faith = true*/
        ///METHOD_BODY_END n01_r3_select
    }

    ///METHOD n01_r2_select
    public void n01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_select
        /*//?p4_auction_resistance = true*/
        ///METHOD_BODY_END n01_r2_select
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//?p4_auction_community = true*/
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//?p4_auction_family = true*/
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n04_r0_select
    public void n04_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n04_r0_select
        /*//?p4_has_nail = true*/
        ///METHOD_BODY_END n04_r0_select
    }
}
//CLASS_END Dialog_p4_auc_001
