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
//CLASS Dialog_p3_par_001
public class Dialog_p3_par_001 {
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
        ///DIALOG_ID p3_par_001
        var dialog = new Dialog();
        dialog.Id = "p3_par_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 Yes, may I help you?
        prompt.Text = "Yes, may I help you?";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Mr. Parker, I need your help.\n
        response.Text = "Mr. Parker, I need your help.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n03
        response.NextNodeId = "n03";
        response.SetCondition(n01_r0_condition);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 I'm here to pick up the laundry, Mr. Parker.\n
        response.Text = "I'm here to pick up the laundry, Mr. Parker.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Of course, Morgan is at that meeting. You must be Lucy. Wait right here, I'll get the laundry for you...\n
        prompt.Text = "Of course, Morgan is at that meeting. You must be Lucy. Wait right here, I'll get the laundry for you...\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [Wait]\n
        response.Text = "[Wait]\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n06
        response.NextNodeId = "n06";
        response.OnSelect(n02_r0_select);
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 When it rains, it pours. Come inside quickly. Are you being chased?\n
        prompt.Text = "When it rains, it pours. Come inside quickly. Are you being chased?\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 [Go inside] No, but I found this [show the paper you found in the hotel]. It looks important but I can't read it.\n
        response.Text = "[Go inside] No, but I found this [show the paper you found in the hotel]. It looks important but I can't read it.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n05
        response.NextNodeId = "n05";
        response.SetCondition(n03_r0_condition);
        response.OnSelect(n03_r0_select);
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 [Go inside] Oh, I am safe now. I am hoping you can help my family.\n
        response.Text = "[Go inside] Oh, I am safe now. I am hoping you can help my family.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n04
        response.NextNodeId = "n04";
        response.OnSelect(n03_r1_select);
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 Why do you think I can help?\n
        prompt.Text = "Why do you think I can help?\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Reverend Rankin and Miss Hatcher both said you know how to get things done.\n
        response.Text = "Reverend Rankin and Miss Hatcher both said you know how to get things done.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n07
        response.NextNodeId = "n07";
        response.SetCondition(n04_r0_condition);
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 Miss Hatcher says you know how to get things done.\n
        response.Text = "Miss Hatcher says you know how to get things done.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n07
        response.NextNodeId = "n07";
        response.SetCondition(n04_r1_condition);
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 Reverend Rankin says you know how to get things done.\n
        response.Text = "Reverend Rankin says you know how to get things done.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n07
        response.NextNodeId = "n07";
        response.SetCondition(n04_r2_condition);
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 \n
        prompt.Text = "\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n05_p0_show);
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 What does it mean?\n
        response.Text = "What does it mean?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n09
        response.NextNodeId = "n09";
        response.OnSelect(n05_r0_select);
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 I know a Henry. Could it be the same man?\n
        response.Text = "I know a Henry. Could it be the same man?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n08
        response.NextNodeId = "n08";
        response.SetCondition(n05_r1_condition);
        response.OnSelect(n05_r1_select);
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 [You see a white man watching you from down the street.]\n
        prompt.Text = "[You see a white man watching you from down the street.]\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n06_p0_condition);
        
        ///PROMPT n06 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 1 [You see the man you ran into at the hotel watching you from down the street.]\n
        prompt.Text = "[You see the man you ran into at the hotel watching you from down the street.]\n";
        ///PROMPT_IGNORE_VO n06 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n06_p1_condition);
        
        ///PROMPT n06 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 2 [You see TC Bercham watching you from down the street]\n
        prompt.Text = "[You see TC Bercham watching you from down the street]\n";
        ///PROMPT_IGNORE_VO n06 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n06_p2_condition);
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [Step inside and close the door behind you]\n
        response.Text = "[Step inside and close the door behind you]\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n22
        response.NextNodeId = "n22";
        response.OnSelect(n06_r0_select);
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 [Wait]\n
        response.Text = "[Wait]\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n20
        response.NextNodeId = "n20";
        response.OnSelect(n06_r1_select);
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 They said that, did they? Where is your family?\n
        prompt.Text = "They said that, did they? Where is your family?\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n07_p0_condition);
        
        ///PROMPT n07 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 1 She said that, did she? Where is your family?\n
        prompt.Text = "She said that, did she? Where is your family?\n";
        ///PROMPT_IGNORE_VO n07 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n07_p1_condition);
        
        ///PROMPT n07 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 2 He said that, did he? Where is your family?\n
        prompt.Text = "He said that, did he? Where is your family?\n";
        ///PROMPT_IGNORE_VO n07 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n07_p2_condition);
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 At the King Plantation, just north of Lexington. My family is to be auctioned and I don't know what to do.\n
        response.Text = "At the King Plantation, just north of Lexington. My family is to be auctioned and I don't know what to do.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 This Henry came from a plantation outside Lexington. The Kane, or maybe King plantation.\n
        prompt.Text = "This Henry came from a plantation outside Lexington. The Kane, or maybe King plantation.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 The King Plantation! Henry? I know him. He's escaped? Is he safe?\n
        response.Text = "The King Plantation! Henry? I know him. He's escaped? Is he safe?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n08_r0_select);
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 It means you may have solved my problem.\n
        prompt.Text = "It means you may have solved my problem.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 I have?\n
        response.Text = "I have?\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n12
        response.NextNodeId = "n12";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 The King Plantation? Do you know a slave there by the name of Henry?\n
        prompt.Text = "The King Plantation? Do you know a slave there by the name of Henry?\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 Yes, I do. We ran away at the same time. I don't know what happened to him.\n
        response.Text = "Yes, I do. We ran away at the same time. I don't know what happened to him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n11
        response.NextNodeId = "n11";
        response.SetCondition(n10_r0_condition);
        response.OnSelect(n10_r0_select);
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 Yes, I do. We tried to escape together. I made it, but he didn't.\n
        response.Text = "Yes, I do. We tried to escape together. I made it, but he didn't.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n11
        response.NextNodeId = "n11";
        response.SetCondition(n10_r1_condition);
        response.OnSelect(n10_r1_select);
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 He must have tried again and this time he did make it. He is badly hurt, but he will recover. But he is not safe yet. Slave catchers are tracking him.\n
        prompt.Text = "He must have tried again and this time he did make it. He is badly hurt, but he will recover. But he is not safe yet. Slave catchers are tracking him.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n11 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 1 He has escaped. He is badly hurt, but he will recover. But he is not safe yet. Slave catchers are tracking him.\n
        prompt.Text = "He has escaped. He is badly hurt, but he will recover. But he is not safe yet. Slave catchers are tracking him.\n";
        ///PROMPT_IGNORE_VO n11 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n11_p1_condition);
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 Is there anything I can do to help?\n
        response.Text = "Is there anything I can do to help?\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n17
        response.NextNodeId = "n17";
        response.SetCondition(n11_r0_condition);
        response.OnSelect(n11_r0_select);
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 Can I see Henry?\n
        response.Text = "Can I see Henry?\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n16
        response.NextNodeId = "n16";
        response.SetCondition(n11_r1_condition);
        response.OnSelect(n11_r1_select);
        
        ///RESPONSE n11 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 2 I found this paper with the name Henry on it. Do you think it is about him? [show the paper]\n
        response.Text = "I found this paper with the name Henry on it. Do you think it is about him? [show the paper]\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 2 n05
        response.NextNodeId = "n05";
        response.SetCondition(n11_r2_condition);
        response.OnSelect(n11_r2_select);
        
        ///RESPONSE n11 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 3 Slave catchers like TC Bercham.  That's where I got the paper.
        response.Text = "Slave catchers like TC Bercham.  That's where I got the paper.";
        ///RESPONSE_NEXT_NODE_TYPE n11 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 3 n14
        response.NextNodeId = "n14";
        response.SetCondition(n11_r3_condition);
        
        ///RESPONSE n11 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 4 I ran into one by the name of TC Bercham. That's where I got the paper.\n
        response.Text = "I ran into one by the name of TC Bercham. That's where I got the paper.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 4 n14
        response.NextNodeId = "n14";
        response.SetCondition(n11_r4_condition);
        
        ///RESPONSE n11 5
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 5 I ran into one by the name of TC Bercham.\n
        response.Text = "I ran into one by the name of TC Bercham.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 5 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 5 n13
        response.NextNodeId = "n13";
        response.SetCondition(n11_r5_condition);
        response.OnSelect(n11_r5_select);
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 We should speak no more right now. We are being watched. Continue with your work and we will talk more later.\n
        prompt.Text = "We should speak no more right now. We are being watched. Continue with your work and we will talk more later.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 Yes, Mr. Parker. [Leave]\n
        response.Text = "Yes, Mr. Parker. [Leave]\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 But what about my family?\n
        response.Text = "But what about my family?\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n15
        response.NextNodeId = "n15";
        response.SetCondition(n12_r1_condition);
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Bercham. I bear no affection for that man. But he is wily, I'll give him that.\n
        prompt.Text = "Bercham. I bear no affection for that man. But he is wily, I'll give him that.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 He dropped this paper. Can you read it?\n
        response.Text = "He dropped this paper. Can you read it?\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n05
        response.NextNodeId = "n05";
        response.SetCondition(n13_r0_condition);
        response.OnSelect(n13_r0_select);
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 He dropped this paper. It has Henry's name on it. Can you read it?\n
        response.Text = "He dropped this paper. It has Henry's name on it. Can you read it?\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n05
        response.NextNodeId = "n05";
        response.SetCondition(n13_r1_condition);
        response.OnSelect(n13_r1_select);
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 We should speak no more right now. Continue with your work and we will talk more later.\n
        prompt.Text = "We should speak no more right now. Continue with your work and we will talk more later.\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n14_p0_condition);
        
        ///PROMPT n14 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 1 Bercham. I bear no affection for that man... We should speak no more right now. Continue with your work and we will talk more later.\n
        prompt.Text = "Bercham. I bear no affection for that man... We should speak no more right now. Continue with your work and we will talk more later.\n";
        ///PROMPT_IGNORE_VO n14 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n14_p1_condition);
        prompt.OnShow(n14_p1_show);
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 Yes, Mr. Parker. [Leave]\n
        response.Text = "Yes, Mr. Parker. [Leave]\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n14 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 1 But what about my family?\n
        response.Text = "But what about my family?\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 1 n15
        response.NextNodeId = "n15";
        response.SetCondition(n14_r1_condition);
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 When we get Henry moved to safety, I will be able to give you my full attention.\n
        prompt.Text = "When we get Henry moved to safety, I will be able to give you my full attention.\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 Thank you Mr. Parker.\n
        response.Text = "Thank you Mr. Parker.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 I'm afraid not. It would be too dangerous to hide him in my home. \n
        prompt.Text = "I'm afraid not. It would be too dangerous to hide him in my home. \n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 I hope I can see him soon.\n
        response.Text = "I hope I can see him soon.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n16 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 1 Is there anything I can do to help?\n
        response.Text = "Is there anything I can do to help?\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 1 n17
        response.NextNodeId = "n17";
        response.SetCondition(n16_r1_condition);
        response.OnSelect(n16_r1_select);
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 Perhaps there will be. I thank you for your offer. It is brave of you.\n
        prompt.Text = "Perhaps there will be. I thank you for your offer. It is brave of you.\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n17_p0_show);
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 I hope I can see him soon.\n
        response.Text = "I hope I can see him soon.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n17 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 1 Can I see him?\n
        response.Text = "Can I see him?\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 1 n16
        response.NextNodeId = "n16";
        response.SetCondition(n17_r1_condition);
        response.OnSelect(n17_r1_select);
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 Let us hope so. We should speak no more right now. Continue with your work and we will talk more later.\n
        prompt.Text = "Let us hope so. We should speak no more right now. Continue with your work and we will talk more later.\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 Yes, Mr. Parker. [Leave]\n
        response.Text = "Yes, Mr. Parker. [Leave]\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n18 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 1 But what about my family?\n
        response.Text = "But what about my family?\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 1 n15
        response.NextNodeId = "n15";
        response.SetCondition(n18_r1_condition);
        
        ///NODE_END n18
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 Here you go Lucy. Thank you. Is something the matter?\n
        prompt.Text = "Here you go Lucy. Thank you. Is something the matter?\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 TC Bercham is watching us.
        response.Text = "TC Bercham is watching us.";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n37
        response.NextNodeId = "n37";
        response.SetCondition(n20_r0_condition);
        
        ///RESPONSE n20 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 1 There is a slave catcher watching me. I think his name is TC Bercham.\n
        response.Text = "There is a slave catcher watching me. I think his name is TC Bercham.\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 1 n37
        response.NextNodeId = "n37";
        response.SetCondition(n20_r1_condition);
        response.OnSelect(n20_r1_select);
        
        ///RESPONSE n20 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 2 There is a man watching us.\n
        response.Text = "There is a man watching us.\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 2 n23
        response.NextNodeId = "n23";
        response.SetCondition(n20_r2_condition);
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 Why did you shut the door?\n
        prompt.Text = "Why did you shut the door?\n";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 TC Bercham was watching me.
        response.Text = "TC Bercham was watching me.";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n13
        response.NextNodeId = "n13";
        response.SetCondition(n21_r0_condition);
        
        ///RESPONSE n21 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 1 There was a slave catcher watching me. I think his name is TC Bercham.\n
        response.Text = "There was a slave catcher watching me. I think his name is TC Bercham.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 1 n13
        response.NextNodeId = "n13";
        response.SetCondition(n21_r1_condition);
        response.OnSelect(n21_r1_select);
        
        ///RESPONSE n21 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 2 There was a man watching me.\n
        response.Text = "There was a man watching me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 2 n24
        response.NextNodeId = "n24";
        response.SetCondition(n21_r2_condition);
        
        ///NODE_END n21
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Full
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n22~|||~
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 [You see a rifle behind the door. You hear Parker returning.]\n
        prompt.Text = "[You see a rifle behind the door. You hear Parker returning.]\n";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 [Wait]\n
        response.Text = "[Wait]\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n21
        response.NextNodeId = "n21";
        response.OnSelect(n22_r0_select);
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 Step inside. Quickly.\n
        prompt.Text = "Step inside. Quickly.\n";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 I had better not. I should finish my work.\n
        response.Text = "I had better not. I should finish my work.\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n25
        response.NextNodeId = "n25";
        response.OnSelect(n23_r0_select);
        
        ///RESPONSE n23 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 1 [Enter Parker's house]\n
        response.Text = "[Enter Parker's house]\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 1 n26
        response.NextNodeId = "n26";
        response.OnSelect(n23_r1_select);
        
        ///NODE_END n23
        ///NODE_START n24
        node = dialog.CreateNode("n24");
        ///NODE_NPC n24 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n24 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24 Full
        ///NODE_VISUAL_USESCRIPT n24 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n24~|||~
        ///PROMPT n24 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24 0 Are you OK? Are you being chased?\n
        prompt.Text = "Are you OK? Are you being chased?\n";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 I am safe. I don't know why he was watching me.\n
        response.Text = "I am safe. I don't know why he was watching me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n24
        ///NODE_START n25
        node = dialog.CreateNode("n25");
        ///NODE_NPC n25 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n25 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n25 Full
        ///NODE_VISUAL_USESCRIPT n25 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n25~|||~
        ///PROMPT n25 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n25 0 [Parker firmly takes your arm and leads you inside]\n
        prompt.Text = "[Parker firmly takes your arm and leads you inside]\n";
        ///PROMPT_IGNORE_VO n25 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n25 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 0 [Scream]\n
        response.Text = "[Scream]\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 0 n27
        response.NextNodeId = "n27";
        response.OnSelect(n25_r0_select);
        
        ///RESPONSE n25 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 1 [Wait]\n
        response.Text = "[Wait]\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 1 n26
        response.NextNodeId = "n26";
        
        ///NODE_END n25
        ///NODE_START n26
        node = dialog.CreateNode("n26");
        ///NODE_NPC n26 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n26 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26 Full
        ///NODE_VISUAL_USESCRIPT n26 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n26~|||~
        ///PROMPT n26 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26 0 [When Parker shuts the door you see a rifle behind it.]\n
        prompt.Text = "[When Parker shuts the door you see a rifle behind it.]\n";
        ///PROMPT_IGNORE_VO n26 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n26 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 0 [Scream]\n
        response.Text = "[Scream]\n";
        ///RESPONSE_NEXT_NODE_TYPE n26 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 0 n27
        response.NextNodeId = "n27";
        response.OnSelect(n26_r0_select);
        
        ///RESPONSE n26 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 1 [Wait]\n
        response.Text = "[Wait]\n";
        ///RESPONSE_NEXT_NODE_TYPE n26 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 1 n28
        response.NextNodeId = "n28";
        
        ///NODE_END n26
        ///NODE_START n27
        node = dialog.CreateNode("n27");
        ///NODE_NPC n27 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n27 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n27 Full
        ///NODE_VISUAL_USESCRIPT n27 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n27~|||~
        ///PROMPT n27 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n27 0 [With lightning reflexes, Parker puts his hand over your mouth.]\n
        prompt.Text = "[With lightning reflexes, Parker puts his hand over your mouth.]\n";
        ///PROMPT_IGNORE_VO n27 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n27 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n27 0 [Stomp on his foot to try and make him let go]
        response.Text = "[Stomp on his foot to try and make him let go]";
        ///RESPONSE_NEXT_NODE_TYPE n27 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n27 0 n28
        response.NextNodeId = "n28";
        response.OnSelect(n27_r0_select);
        
        ///RESPONSE n27 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n27 1 [Wait]\n
        response.Text = "[Wait]\n";
        ///RESPONSE_NEXT_NODE_TYPE n27 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n27 1 n28
        response.NextNodeId = "n28";
        
        ///NODE_END n27
        ///NODE_START n28
        node = dialog.CreateNode("n28");
        ///NODE_NPC n28 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n28 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n28 Full
        ///NODE_VISUAL_USESCRIPT n28 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n28~|||~
        ///PROMPT n28 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n28 0 I'm sorry that I grabbed you, but that man may be dangerous. Can't be too careful.\n
        prompt.Text = "I'm sorry that I grabbed you, but that man may be dangerous. Can't be too careful.\n";
        ///PROMPT_IGNORE_VO n28 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n28 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n28 1 I'm sorry about that, but that man may be dangerous. Can't be too careful. [He releases you]\n
        prompt.Text = "I'm sorry about that, but that man may be dangerous. Can't be too careful. [He releases you]\n";
        ///PROMPT_IGNORE_VO n28 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n28_p1_condition);
        
        ///PROMPT n28 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n28 2 [He grimaces with the blow but holds on] I'm sorry about that, but that man may be dangerous. Can't be too careful. [He releases you cautiously]
        prompt.Text = "[He grimaces with the blow but holds on] I'm sorry about that, but that man may be dangerous. Can't be too careful. [He releases you cautiously]";
        ///PROMPT_IGNORE_VO n28 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n28_p2_condition);
        
        ///RESPONSE n28 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n28 0 You seem dangerous.\n
        response.Text = "You seem dangerous.\n";
        ///RESPONSE_NEXT_NODE_TYPE n28 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n28 0 n31
        response.NextNodeId = "n31";
        response.SetCondition(n28_r0_condition);
        
        ///RESPONSE n28 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n28 1 I don't know why he was watching me.\n
        response.Text = "I don't know why he was watching me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n28 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n28 1 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n28
        ///NODE_START n30
        node = dialog.CreateNode("n30");
        ///NODE_NPC n30 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n30 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n30 Full
        ///NODE_VISUAL_USESCRIPT n30 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n30~|||~
        ///PROMPT n30 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n30 0 I suspect he's watching me. He thinks I'm hiding an escaped slave and hopes to catch me in the act.\n
        prompt.Text = "I suspect he's watching me. He thinks I'm hiding an escaped slave and hopes to catch me in the act.\n";
        ///PROMPT_IGNORE_VO n30 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n30 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 0 I was hoping you could help me. Help my family, really. They're to be auctioned south soon.\n
        response.Text = "I was hoping you could help me. Help my family, really. They're to be auctioned south soon.\n";
        ///RESPONSE_NEXT_NODE_TYPE n30 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 0 n33
        response.NextNodeId = "n33";
        response.OnSelect(n30_r0_select);
        
        ///RESPONSE n30 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 1 Are you hiding someone?\n
        response.Text = "Are you hiding someone?\n";
        ///RESPONSE_NEXT_NODE_TYPE n30 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 1 n32
        response.NextNodeId = "n32";
        
        ///NODE_END n30
        ///NODE_START n31
        node = dialog.CreateNode("n31");
        ///NODE_NPC n31 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n31 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n31 Full
        ///NODE_VISUAL_USESCRIPT n31 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n31~|||~
        ///PROMPT n31 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n31 0 I suppose I am. But not to you, I promise.\n
        prompt.Text = "I suppose I am. But not to you, I promise.\n";
        ///PROMPT_IGNORE_VO n31 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n31_p0_show);
        
        ///RESPONSE n31 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 0 I don't know why that man was watching me.\n
        response.Text = "I don't know why that man was watching me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n31 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 0 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n31
        ///NODE_START n32
        node = dialog.CreateNode("n32");
        ///NODE_NPC n32 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n32 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n32 Full
        ///NODE_VISUAL_USESCRIPT n32 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n32~|||~
        ///PROMPT n32 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n32 0 That's a direct question. \n
        prompt.Text = "That's a direct question. \n";
        ///PROMPT_IGNORE_VO n32 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n32 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n32 0 I'm sorry. My mama always said I asked too many questions.\n
        response.Text = "I'm sorry. My mama always said I asked too many questions.\n";
        ///RESPONSE_NEXT_NODE_TYPE n32 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n32 0 n36
        response.NextNodeId = "n36";
        
        ///NODE_END n32
        ///NODE_START n33
        node = dialog.CreateNode("n33");
        ///NODE_NPC n33 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n33 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n33 Full
        ///NODE_VISUAL_USESCRIPT n33 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n33~|||~
        ///PROMPT n33 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n33 0 Where is your family?\n
        prompt.Text = "Where is your family?\n";
        ///PROMPT_IGNORE_VO n33 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n33 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n33 0 At the King Plantation, just north of Lexington.\n
        response.Text = "At the King Plantation, just north of Lexington.\n";
        ///RESPONSE_NEXT_NODE_TYPE n33 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n33 0 n34
        response.NextNodeId = "n34";
        
        ///NODE_END n33
        ///NODE_START n34
        node = dialog.CreateNode("n34");
        ///NODE_NPC n34 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n34 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n34 Full
        ///NODE_VISUAL_USESCRIPT n34 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n34~|||~
        ///PROMPT n34 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n34 0 The King Plantation? Do you know a slave there by the name of Henry?\n
        prompt.Text = "The King Plantation? Do you know a slave there by the name of Henry?\n";
        ///PROMPT_IGNORE_VO n34 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n34 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n34 0 Yes, I do. We ran away at the same time. I don't know what happened to him.\n
        response.Text = "Yes, I do. We ran away at the same time. I don't know what happened to him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n34 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n34 0 n35
        response.NextNodeId = "n35";
        response.SetCondition(n34_r0_condition);
        response.OnSelect(n34_r0_select);
        
        ///RESPONSE n34 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n34 1 Yes, I do. We tried to escape together. I made it, but he didn't.\n
        response.Text = "Yes, I do. We tried to escape together. I made it, but he didn't.\n";
        ///RESPONSE_NEXT_NODE_TYPE n34 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n34 1 n35
        response.NextNodeId = "n35";
        response.SetCondition(n34_r1_condition);
        response.OnSelect(n34_r1_select);
        
        ///NODE_END n34
        ///NODE_START n35
        node = dialog.CreateNode("n35");
        ///NODE_NPC n35 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n35 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n35 Full
        ///NODE_VISUAL_USESCRIPT n35 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n35~|||~
        ///PROMPT n35 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n35 0 Now that is a coincidence! I am hiding someone. Henry. He is badly hurt, but he will recover. That man watching us is a slave catcher.\n
        prompt.Text = "Now that is a coincidence! I am hiding someone. Henry. He is badly hurt, but he will recover. That man watching us is a slave catcher.\n";
        ///PROMPT_IGNORE_VO n35 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n35 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n35 0 Is there anything I can do to help?\n
        response.Text = "Is there anything I can do to help?\n";
        ///RESPONSE_NEXT_NODE_TYPE n35 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n35 0 n17
        response.NextNodeId = "n17";
        response.SetCondition(n35_r0_condition);
        response.OnSelect(n35_r0_select);
        
        ///RESPONSE n35 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n35 1 Can I see Henry?\n
        response.Text = "Can I see Henry?\n";
        ///RESPONSE_NEXT_NODE_TYPE n35 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n35 1 n16
        response.NextNodeId = "n16";
        response.SetCondition(n35_r1_condition);
        response.OnSelect(n35_r1_select);
        
        ///RESPONSE n35 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n35 2 I found this paper with the name Henry on it. Do you think it is about him? [show the paper]\n
        response.Text = "I found this paper with the name Henry on it. Do you think it is about him? [show the paper]\n";
        ///RESPONSE_NEXT_NODE_TYPE n35 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n35 2 n05
        response.NextNodeId = "n05";
        response.SetCondition(n35_r2_condition);
        response.OnSelect(n35_r2_select);
        
        ///NODE_END n35
        ///NODE_START n36
        node = dialog.CreateNode("n36");
        ///NODE_NPC n36 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n36 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n36 Full
        ///NODE_VISUAL_USESCRIPT n36 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n36~|||~
        ///PROMPT n36 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n36 0 It's quite alright. I like a curious mind. Where is your mama now?\n
        prompt.Text = "It's quite alright. I like a curious mind. Where is your mama now?\n";
        ///PROMPT_IGNORE_VO n36 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n36_p0_show);
        
        ///RESPONSE n36 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n36 0 At the King Plantation, just north of Lexington.\n
        response.Text = "At the King Plantation, just north of Lexington.\n";
        ///RESPONSE_NEXT_NODE_TYPE n36 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n36 0 n34
        response.NextNodeId = "n34";
        
        ///NODE_END n36
        ///NODE_START n37
        node = dialog.CreateNode("n37");
        ///NODE_NPC n37 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n37 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n37 Full
        ///NODE_VISUAL_USESCRIPT n37 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n37~|||~
        ///PROMPT n37 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n37 0 Step inside. Quickly.\n
        prompt.Text = "Step inside. Quickly.\n";
        ///PROMPT_IGNORE_VO n37 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n37 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n37 0 [Enter Parker's house]\n
        response.Text = "[Enter Parker's house]\n";
        ///RESPONSE_NEXT_NODE_TYPE n37 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n37 0 n38
        response.NextNodeId = "n38";
        response.OnSelect(n37_r0_select);
        
        ///NODE_END n37
        ///NODE_START n38
        node = dialog.CreateNode("n38");
        ///NODE_NPC n38 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n38 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n38 Full
        ///NODE_VISUAL_USESCRIPT n38 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n38~|||~
        ///PROMPT n38 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n38 0 [When Parker shuts the door you see a rifle behind it.]\n
        prompt.Text = "[When Parker shuts the door you see a rifle behind it.]\n";
        ///PROMPT_IGNORE_VO n38 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n38 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n38 0 [Wait]\n
        response.Text = "[Wait]\n";
        ///RESPONSE_NEXT_NODE_TYPE n38 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n38 0 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n38
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n06_p0_condition
    public bool n06_p0_condition (  ) {
        ///METHOD_BODY_START n06_p0_condition
        /*//if (?p3_did_hotel = false)*/
        return true;
        ///METHOD_BODY_END n06_p0_condition
    }

    ///METHOD n06_p1_condition
    public bool n06_p1_condition (  ) {
        ///METHOD_BODY_START n06_p1_condition
        /*//if ((?p3_did_hotel = true) AND (?p3_ask_tc = false))*/
        return true;
        ///METHOD_BODY_END n06_p1_condition
    }

    ///METHOD n06_p2_condition
    public bool n06_p2_condition (  ) {
        ///METHOD_BODY_START n06_p2_condition
        /*//if (?p3_ask_tc = true)*/
        return true;
        ///METHOD_BODY_END n06_p2_condition
    }

    ///METHOD n07_p0_condition
    public bool n07_p0_condition (  ) {
        ///METHOD_BODY_START n07_p0_condition
        /*//if ((?p3_know_parker_resourceful_mil = true) AND (?p3_know_parker_resourceful = true))*/
        return true;
        ///METHOD_BODY_END n07_p0_condition
    }

    ///METHOD n07_p1_condition
    public bool n07_p1_condition (  ) {
        ///METHOD_BODY_START n07_p1_condition
        /*//if ((?p3_know_parker_resourceful_mil = true) AND (?p3_know_parker_resourceful = false))*/
        return true;
        ///METHOD_BODY_END n07_p1_condition
    }

    ///METHOD n07_p2_condition
    public bool n07_p2_condition (  ) {
        ///METHOD_BODY_START n07_p2_condition
        /*//if ((?p3_know_parker_resourceful_mil = false) AND (?p3_know_parker_resourceful = true))*/
        return true;
        ///METHOD_BODY_END n07_p2_condition
    }

    ///METHOD n11_p1_condition
    public bool n11_p1_condition (  ) {
        ///METHOD_BODY_START n11_p1_condition
        /*//if (?p3_from_n10 = false)*/
        return true;
        ///METHOD_BODY_END n11_p1_condition
    }

    ///METHOD n14_p0_condition
    public bool n14_p0_condition (  ) {
        ///METHOD_BODY_START n14_p0_condition
        /*//if (?p3_disgust_tc = true)*/
        return true;
        ///METHOD_BODY_END n14_p0_condition
    }

    ///METHOD n14_p1_condition
    public bool n14_p1_condition (  ) {
        ///METHOD_BODY_START n14_p1_condition
        /*//if (?p3_disgust_tc = false)*/
        return true;
        ///METHOD_BODY_END n14_p1_condition
    }

    ///METHOD n28_p1_condition
    public bool n28_p1_condition (  ) {
        ///METHOD_BODY_START n28_p1_condition
        /*//if (?p3_lucy_screams = true)*/
        return true;
        ///METHOD_BODY_END n28_p1_condition
    }

    ///METHOD n28_p2_condition
    public bool n28_p2_condition (  ) {
        ///METHOD_BODY_START n28_p2_condition
        /*//if (?p3_fighting_spirit=true)*/
        return true;
        ///METHOD_BODY_END n28_p2_condition
    }

    ///METHOD n05_p0_show
    public void n05_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n05_p0_show
        /*//setLayer("fg", "gfx/stills/affidavit/affidavit2.swf")
        //#par_points = #par_points + 1
        //updateMessage ("Parker's opinion of you improves.")*/
        ///METHOD_BODY_END n05_p0_show
    }

    ///METHOD n14_p1_show
    public void n14_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n14_p1_show
        /*//set ?p3_disgust_tc = true*/
        ///METHOD_BODY_END n14_p1_show
    }

    ///METHOD n17_p0_show
    public void n17_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n17_p0_show
        /*//#par_points = #par_points + 1
        //updateMessage ("Parker's opinion of you improves.")*/
        ///METHOD_BODY_END n17_p0_show
    }

    ///METHOD n31_p0_show
    public void n31_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n31_p0_show
        /*//#par_points = #par_points + 1
        //updateMessage ("Parker's opinion of you improves.")*/
        ///METHOD_BODY_END n31_p0_show
    }

    ///METHOD n36_p0_show
    public void n36_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n36_p0_show
        /*//#par_points = #par_points + 1
        //updateMessage ("Parker's opinion of you improves.")*/
        ///METHOD_BODY_END n36_p0_show
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if ((?p3_know_parker_resourceful = true) OR (?p3_know_parker_resourceful_mil = true))*/
        return true;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n03_r0_condition
    public bool n03_r0_condition (  ) {
        ///METHOD_BODY_START n03_r0_condition
        /*//if (?p3_have_aff = true)*/
        return true;
        ///METHOD_BODY_END n03_r0_condition
    }

    ///METHOD n04_r0_condition
    public bool n04_r0_condition (  ) {
        ///METHOD_BODY_START n04_r0_condition
        /*//if ((?p3_know_parker_resourceful_mil = true) AND (?p3_know_parker_resourceful = true))*/
        return true;
        ///METHOD_BODY_END n04_r0_condition
    }

    ///METHOD n04_r1_condition
    public bool n04_r1_condition (  ) {
        ///METHOD_BODY_START n04_r1_condition
        /*//if ((?p3_know_parker_resourceful_mil = true) AND (?p3_know_parker_resourceful = false))*/
        return true;
        ///METHOD_BODY_END n04_r1_condition
    }

    ///METHOD n04_r2_condition
    public bool n04_r2_condition (  ) {
        ///METHOD_BODY_START n04_r2_condition
        /*//if ((?p3_know_parker_resourceful_mil = false) AND (?p3_know_parker_resourceful = true))*/
        return true;
        ///METHOD_BODY_END n04_r2_condition
    }

    ///METHOD n05_r1_condition
    public bool n05_r1_condition (  ) {
        ///METHOD_BODY_START n05_r1_condition
        /*//if ((?p3_know_henry_aff = false) AND (?p3_hen_discussed = false))*/
        return true;
        ///METHOD_BODY_END n05_r1_condition
    }

    ///METHOD n10_r0_condition
    public bool n10_r0_condition (  ) {
        ///METHOD_BODY_START n10_r0_condition
        /*//if ($escape_type = "alone")*/
        return true;
        ///METHOD_BODY_END n10_r0_condition
    }

    ///METHOD n10_r1_condition
    public bool n10_r1_condition (  ) {
        ///METHOD_BODY_START n10_r1_condition
        /*//if ($escape_type = "henry")*/
        return true;
        ///METHOD_BODY_END n10_r1_condition
    }

    ///METHOD n11_r0_condition
    public bool n11_r0_condition (  ) {
        ///METHOD_BODY_START n11_r0_condition
        /*//if ((?p3_did_hotel = false) OR (?p3_aff_read = true))*/
        return true;
        ///METHOD_BODY_END n11_r0_condition
    }

    ///METHOD n11_r1_condition
    public bool n11_r1_condition (  ) {
        ///METHOD_BODY_START n11_r1_condition
        /*//if ((?p3_did_hotel = false) OR (?p3_aff_read = true))*/
        return true;
        ///METHOD_BODY_END n11_r1_condition
    }

    ///METHOD n11_r2_condition
    public bool n11_r2_condition (  ) {
        ///METHOD_BODY_START n11_r2_condition
        /*//if ((?p3_ask_tc = false) AND (?p3_have_aff = true) AND (?p3_aff_read = false))*/
        return true;
        ///METHOD_BODY_END n11_r2_condition
    }

    ///METHOD n11_r3_condition
    public bool n11_r3_condition (  ) {
        ///METHOD_BODY_START n11_r3_condition
        /*//if ((?p3_ask_tc = true) AND (?p3_aff_read = true) AND (?p3_disgust_tc = true))*/
        return true;
        ///METHOD_BODY_END n11_r3_condition
    }

    ///METHOD n11_r4_condition
    public bool n11_r4_condition (  ) {
        ///METHOD_BODY_START n11_r4_condition
        /*//if ((?p3_ask_tc = true) AND (?p3_aff_read = true) AND (?p3_disgust_tc = false))*/
        return true;
        ///METHOD_BODY_END n11_r4_condition
    }

    ///METHOD n11_r5_condition
    public bool n11_r5_condition (  ) {
        ///METHOD_BODY_START n11_r5_condition
        /*//if ((?p3_ask_tc = true) AND (?p3_aff_read = false))*/
        return true;
        ///METHOD_BODY_END n11_r5_condition
    }

    ///METHOD n12_r1_condition
    public bool n12_r1_condition (  ) {
        ///METHOD_BODY_START n12_r1_condition
        /*//if (?p3_ask_par_family = true)*/
        return true;
        ///METHOD_BODY_END n12_r1_condition
    }

    ///METHOD n13_r0_condition
    public bool n13_r0_condition (  ) {
        ///METHOD_BODY_START n13_r0_condition
        /*//if ((?p3_aff_read = false) AND (?p3_have_aff = true) AND (?p3_hen_discussed = false))*/
        return true;
        ///METHOD_BODY_END n13_r0_condition
    }

    ///METHOD n13_r1_condition
    public bool n13_r1_condition (  ) {
        ///METHOD_BODY_START n13_r1_condition
        /*//if ((?p3_aff_read = false) AND (?p3_have_aff = true) AND (?p3_hen_discussed = true))*/
        return true;
        ///METHOD_BODY_END n13_r1_condition
    }

    ///METHOD n14_r1_condition
    public bool n14_r1_condition (  ) {
        ///METHOD_BODY_START n14_r1_condition
        /*//if (?p3_ask_par_family = true)*/
        return true;
        ///METHOD_BODY_END n14_r1_condition
    }

    ///METHOD n16_r1_condition
    public bool n16_r1_condition (  ) {
        ///METHOD_BODY_START n16_r1_condition
        /*//if (?p3_ask_help_hen = false)*/
        return true;
        ///METHOD_BODY_END n16_r1_condition
    }

    ///METHOD n17_r1_condition
    public bool n17_r1_condition (  ) {
        ///METHOD_BODY_START n17_r1_condition
        /*//if (?p3_ask_see_hen = false)*/
        return true;
        ///METHOD_BODY_END n17_r1_condition
    }

    ///METHOD n18_r1_condition
    public bool n18_r1_condition (  ) {
        ///METHOD_BODY_START n18_r1_condition
        /*//if (?p3_ask_par_family = true)*/
        return true;
        ///METHOD_BODY_END n18_r1_condition
    }

    ///METHOD n20_r0_condition
    public bool n20_r0_condition (  ) {
        ///METHOD_BODY_START n20_r0_condition
        /*//if ((?p3_ask_tc=true) AND (?p3_disgust_tc = true))*/
        return true;
        ///METHOD_BODY_END n20_r0_condition
    }

    ///METHOD n20_r1_condition
    public bool n20_r1_condition (  ) {
        ///METHOD_BODY_START n20_r1_condition
        /*//if ((?p3_ask_tc=true) AND (?p3_disgust_tc = false))*/
        return true;
        ///METHOD_BODY_END n20_r1_condition
    }

    ///METHOD n20_r2_condition
    public bool n20_r2_condition (  ) {
        ///METHOD_BODY_START n20_r2_condition
        /*//if (?p3_ask_tc=false)*/
        return true;
        ///METHOD_BODY_END n20_r2_condition
    }

    ///METHOD n21_r0_condition
    public bool n21_r0_condition (  ) {
        ///METHOD_BODY_START n21_r0_condition
        /*//if ((?p3_ask_tc=true) AND (?p3_disgust_tc = true))*/
        return true;
        ///METHOD_BODY_END n21_r0_condition
    }

    ///METHOD n21_r1_condition
    public bool n21_r1_condition (  ) {
        ///METHOD_BODY_START n21_r1_condition
        /*//if ((?p3_ask_tc=true) AND (?p3_disgust_tc = false))*/
        return true;
        ///METHOD_BODY_END n21_r1_condition
    }

    ///METHOD n21_r2_condition
    public bool n21_r2_condition (  ) {
        ///METHOD_BODY_START n21_r2_condition
        /*//if (?p3_ask_tc=false)*/
        return true;
        ///METHOD_BODY_END n21_r2_condition
    }

    ///METHOD n28_r0_condition
    public bool n28_r0_condition (  ) {
        ///METHOD_BODY_START n28_r0_condition
        /*//if (?p3_lucy_screams = true)*/
        return true;
        ///METHOD_BODY_END n28_r0_condition
    }

    ///METHOD n34_r0_condition
    public bool n34_r0_condition (  ) {
        ///METHOD_BODY_START n34_r0_condition
        /*//if ($escape_type = "alone")*/
        return true;
        ///METHOD_BODY_END n34_r0_condition
    }

    ///METHOD n34_r1_condition
    public bool n34_r1_condition (  ) {
        ///METHOD_BODY_START n34_r1_condition
        /*//if ($escape_type = "henry")*/
        return true;
        ///METHOD_BODY_END n34_r1_condition
    }

    ///METHOD n35_r0_condition
    public bool n35_r0_condition (  ) {
        ///METHOD_BODY_START n35_r0_condition
        /*//if ((?p3_did_hotel = false) OR (?p3_aff_read = true))*/
        return true;
        ///METHOD_BODY_END n35_r0_condition
    }

    ///METHOD n35_r1_condition
    public bool n35_r1_condition (  ) {
        ///METHOD_BODY_START n35_r1_condition
        /*//if ((?p3_did_hotel = false) OR (?p3_aff_read = true))*/
        return true;
        ///METHOD_BODY_END n35_r1_condition
    }

    ///METHOD n35_r2_condition
    public bool n35_r2_condition (  ) {
        ///METHOD_BODY_START n35_r2_condition
        /*//if ((?p3_ask_tc = false) AND (?p3_have_aff = true) AND (?p3_aff_read = false))*/
        return true;
        ///METHOD_BODY_END n35_r2_condition
    }

    ///METHOD n02_r0_select
    public void n02_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_parker_outside1.swf")
        //set ?p3_tc_spied = true
        //showNpc(false,1)*/
        ///METHOD_BODY_END n02_r0_select
    }

    ///METHOD n03_r0_select
    public void n03_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r0_select
        /*//set ?p3_aff_read = true
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_parker_inside2.swf")*/
        ///METHOD_BODY_END n03_r0_select
    }

    ///METHOD n03_r1_select
    public void n03_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r1_select
        /*//set ?p3_ask_par_family = true
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_parker_inside2.swf")*/
        ///METHOD_BODY_END n03_r1_select
    }

    ///METHOD n05_r0_select
    public void n05_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r0_select
        /*//setLayer("fg", "")*/
        ///METHOD_BODY_END n05_r0_select
    }

    ///METHOD n05_r1_select
    public void n05_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r1_select
        /*//set ?p3_know_henry_aff = true
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n05_r1_select
    }

    ///METHOD n06_r0_select
    public void n06_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_parker_inside1.swf")*/
        ///METHOD_BODY_END n06_r0_select
    }

    ///METHOD n06_r1_select
    public void n06_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r1_select
        /*//showNpc(true,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_parker_outside2.swf")*/
        ///METHOD_BODY_END n06_r1_select
    }

    ///METHOD n08_r0_select
    public void n08_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r0_select
        /*//set ?p3_hen_discussed = true*/
        ///METHOD_BODY_END n08_r0_select
    }

    ///METHOD n10_r0_select
    public void n10_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r0_select
        /*//set ?p3_hen_discussed = true
        //set ?p3_from_n10 = false*/
        ///METHOD_BODY_END n10_r0_select
    }

    ///METHOD n10_r1_select
    public void n10_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r1_select
        /*//set ?p3_hen_discussed = true
        //set ?p3_from_n10 = true*/
        ///METHOD_BODY_END n10_r1_select
    }

    ///METHOD n11_r0_select
    public void n11_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r0_select
        /*//set ?p3_ask_help_hen = true*/
        ///METHOD_BODY_END n11_r0_select
    }

    ///METHOD n11_r1_select
    public void n11_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r1_select
        /*//set ?p3_ask_see_hen = true*/
        ///METHOD_BODY_END n11_r1_select
    }

    ///METHOD n11_r2_select
    public void n11_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r2_select
        /*//set ?p3_aff_read = true*/
        ///METHOD_BODY_END n11_r2_select
    }

    ///METHOD n11_r5_select
    public void n11_r5_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r5_select
        /*//set ?p3_disgust_tc = true*/
        ///METHOD_BODY_END n11_r5_select
    }

    ///METHOD n13_r0_select
    public void n13_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n13_r0_select
        /*//set ?p3_aff_read = true*/
        ///METHOD_BODY_END n13_r0_select
    }

    ///METHOD n13_r1_select
    public void n13_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n13_r1_select
        /*//set ?p3_aff_read = true*/
        ///METHOD_BODY_END n13_r1_select
    }

    ///METHOD n16_r1_select
    public void n16_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r1_select
        /*//set ?p3_ask_help_hen = true*/
        ///METHOD_BODY_END n16_r1_select
    }

    ///METHOD n17_r1_select
    public void n17_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n17_r1_select
        /*//set ?p3_ask_see_hen = true*/
        ///METHOD_BODY_END n17_r1_select
    }

    ///METHOD n20_r1_select
    public void n20_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n20_r1_select
        /*//set ?p3_disgust_tc = true*/
        ///METHOD_BODY_END n20_r1_select
    }

    ///METHOD n21_r1_select
    public void n21_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n21_r1_select
        /*//set ?p3_disgust_tc = true*/
        ///METHOD_BODY_END n21_r1_select
    }

    ///METHOD n22_r0_select
    public void n22_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n22_r0_select
        /*//showNpc(true,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_parker_inside2.swf")*/
        ///METHOD_BODY_END n22_r0_select
    }

    ///METHOD n23_r0_select
    public void n23_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r0_select
        /*//set ?p3_lucy_resist_par = true
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_parker_inside2.swf")*/
        ///METHOD_BODY_END n23_r0_select
    }

    ///METHOD n23_r1_select
    public void n23_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r1_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_parker_inside2.swf")*/
        ///METHOD_BODY_END n23_r1_select
    }

    ///METHOD n25_r0_select
    public void n25_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n25_r0_select
        /*//set ?p3_lucy_screams = true*/
        ///METHOD_BODY_END n25_r0_select
    }

    ///METHOD n26_r0_select
    public void n26_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n26_r0_select
        /*//set ?p3_lucy_screams = true*/
        ///METHOD_BODY_END n26_r0_select
    }

    ///METHOD n27_r0_select
    public void n27_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n27_r0_select
        /*//?p3_fighting_spirit = true*/
        ///METHOD_BODY_END n27_r0_select
    }

    ///METHOD n30_r0_select
    public void n30_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n30_r0_select
        /*//set ?p3_ask_par_family = true*/
        ///METHOD_BODY_END n30_r0_select
    }

    ///METHOD n34_r0_select
    public void n34_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n34_r0_select
        /*//set ?p3_hen_discussed = true*/
        ///METHOD_BODY_END n34_r0_select
    }

    ///METHOD n34_r1_select
    public void n34_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n34_r1_select
        /*//set ?p3_hen_discussed = true*/
        ///METHOD_BODY_END n34_r1_select
    }

    ///METHOD n35_r0_select
    public void n35_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n35_r0_select
        /*//set ?p3_ask_help_hen = true*/
        ///METHOD_BODY_END n35_r0_select
    }

    ///METHOD n35_r1_select
    public void n35_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n35_r1_select
        /*//set ?p3_ask_see_hen = true*/
        ///METHOD_BODY_END n35_r1_select
    }

    ///METHOD n35_r2_select
    public void n35_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n35_r2_select
        /*//set ?p3_aff_read = true*/
        ///METHOD_BODY_END n35_r2_select
    }

    ///METHOD n37_r0_select
    public void n37_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n37_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_parker_inside2.swf")*/
        ///METHOD_BODY_END n37_r0_select
    }
}
//CLASS_END Dialog_p3_par_001
