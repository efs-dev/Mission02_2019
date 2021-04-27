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
//CLASS Dialog_p4_sar_001
public class Dialog_p4_sar_001 {
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
        ///DIALOG_ID p4_sar_001
        var dialog = new Dialog();
        dialog.Id = "p4_sar_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 If it isn't my dear friend Lucy. Have you missed me?\n
        prompt.Text = "If it isn't my dear friend Lucy. Have you missed me?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Play dumb] Who are you?\n
        response.Text = "[Play dumb] Who are you?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 What do you want, Miss Sarah?\n
        response.Text = "What do you want, Miss Sarah?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n04
        response.NextNodeId = "n04";
        response.SetCondition(n01_r1_condition);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 What do you want, Miss Sarah?\n
        response.Text = "What do you want, Miss Sarah?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n03
        response.NextNodeId = "n03";
        response.SetCondition(n01_r2_condition);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 What do you want, Sarah?\n
        response.Text = "What do you want, Sarah?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Why, I want to sell you. \n
        prompt.Text = "Why, I want to sell you. \n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [Stay silent.]\n
        response.Text = "[Stay silent.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Why do you want to sell me?\n
        response.Text = "Why do you want to sell me?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n09
        response.NextNodeId = "n09";
        
        ///RESPONSE n02 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 2 If you must sell me, you must. But please spare Jonah. He is just a boy.\n
        response.Text = "If you must sell me, you must. But please spare Jonah. He is just a boy.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 2 n14
        response.NextNodeId = "n14";
        response.SetCondition(n02_r2_condition);
        
        ///RESPONSE n02 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 3 Please, I just want to live my life free. Like you. Is that too much to ask?\n
        response.Text = "Please, I just want to live my life free. Like you. Is that too much to ask?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 3 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 I'm glad you've finally learned some manners. Oh, I need to thank you for something.\n
        prompt.Text = "I'm glad you've finally learned some manners. Oh, I need to thank you for something.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What is that?\n
        response.Text = "What is that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 I'm glad you've finally learned some manners. Well, doesn't matter, I'm going to sell you.\n
        prompt.Text = "I'm glad you've finally learned some manners. Well, doesn't matter, I'm going to sell you.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Why do you need to sell me?\n
        response.Text = "Why do you need to sell me?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n09
        response.NextNodeId = "n09";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 If you must sell me, you must. But please spare Jonah. He is just a boy.\n
        response.Text = "If you must sell me, you must. But please spare Jonah. He is just a boy.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n14
        response.NextNodeId = "n14";
        response.SetCondition(n04_r1_condition);
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 Miss Sarah, please, I just want to live my life free. Like you. Is that too much to ask?\n
        response.Text = "Miss Sarah, please, I just want to live my life free. Like you. Is that too much to ask?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 Don't try to be clever with me. You can pretend all you want. But it's my word that matters. And I say I own you.\n
        prompt.Text = "Don't try to be clever with me. You can pretend all you want. But it's my word that matters. And I say I own you.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 I'm sorry, Miss Sarah. Please, I just want to live my life free. Like you. Is that too much to ask?\n
        response.Text = "I'm sorry, Miss Sarah. Please, I just want to live my life free. Like you. Is that too much to ask?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 I don't know what you're talking about.\n
        response.Text = "I don't know what you're talking about.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Very well. Mr. Bercham, please take them both to the Maysville auction. You know where to send the money. [She turns to leave.]\n
        prompt.Text = "Very well. Mr. Bercham, please take them both to the Maysville auction. You know where to send the money. [She turns to leave.]\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n06 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 1 Very well. Mr. Bercham, please take her to the Maysville auction. You know where to send the money. [She turns to leave.]\n
        prompt.Text = "Very well. Mr. Bercham, please take her to the Maysville auction. You know where to send the money. [She turns to leave.]\n";
        ///PROMPT_IGNORE_VO n06 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n06_p1_condition);
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Miss Sarah, wait! Please don't sell Jonah. He's just a boy.\n
        response.Text = "Miss Sarah, wait! Please don't sell Jonah. He's just a boy.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n14
        response.NextNodeId = "n14";
        response.SetCondition(n06_r0_condition);
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 [Sarah walks out the door.]\n
        prompt.Text = "[Sarah walks out the door.]\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n07_p0_show);
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 And to live my life, I need the money I'll get for selling you.\n
        prompt.Text = "And to live my life, I need the money I'll get for selling you.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 Then let's not waste any more time talking. Get it over with.\n
        response.Text = "Then let's not waste any more time talking. Get it over with.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 But you're rich, Miss Sarah. You have a plantation and lots of nice things.\n
        response.Text = "But you're rich, Miss Sarah. You have a plantation and lots of nice things.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 Father died, Lucy. He left a lot of debt. I must pay it off or I'll never be free of the banks.\n
        prompt.Text = "Father died, Lucy. He left a lot of debt. I must pay it off or I'll never be free of the banks.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 Miss Sarah, I don't expect anything good will ever come of you as long as you hold people enslaved!\n
        response.Text = "Miss Sarah, I don't expect anything good will ever come of you as long as you hold people enslaved!\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 I'm sorry to hear that, Miss Sarah.\n
        response.Text = "I'm sorry to hear that, Miss Sarah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 Remember that dress you fixed for me? Well, I met my fiancee at the wedding. He thought I looked beautiful in it.\n
        prompt.Text = "Remember that dress you fixed for me? Well, I met my fiancee at the wedding. He thought I looked beautiful in it.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 But you're ruining my life. Doesn't that matter to you at all?\n
        response.Text = "But you're ruining my life. Doesn't that matter to you at all?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 I'm very happy for you!\n
        response.Text = "I'm very happy for you!\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n10 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 2 Is he a Yankee gentleman?\n
        response.Text = "Is he a Yankee gentleman?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 2 n11
        response.NextNodeId = "n11";
        response.SetCondition(n10_r2_condition);
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 We'll be living in his home in Illinois. He's a Yankee!\n
        prompt.Text = "We'll be living in his home in Illinois. He's a Yankee!\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n11 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 1 You remember I said that. Why, yes, he is. We're moving to Illinois.\n
        prompt.Text = "You remember I said that. Why, yes, he is. We're moving to Illinois.\n";
        ///PROMPT_IGNORE_VO n11 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n11_p1_condition);
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 So while you're in Illinois, I'll be down south picking cotton to make your fancy dresses.\n
        response.Text = "So while you're in Illinois, I'll be down south picking cotton to make your fancy dresses.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 But you can't have slaves in Illinois.\n
        response.Text = "But you can't have slaves in Illinois.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n13
        response.NextNodeId = "n13";
        response.SetCondition(n11_r1_condition);
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 Same old Lucy. Always thinking about herself. Well, I must be going. Mr. Bercham will take you to the auction. [She turns to leave.]\n
        prompt.Text = "Same old Lucy. Always thinking about herself. Well, I must be going. Mr. Bercham will take you to the auction. [She turns to leave.]\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 Miss Sarah, wait! Please don't sell Jonah. He's just a boy.\n
        response.Text = "Miss Sarah, wait! Please don't sell Jonah. He's just a boy.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n14
        response.NextNodeId = "n14";
        response.SetCondition(n12_r0_condition);
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 No, we cannot. That's one reason I'm selling you. I'll have to hire servants, I suppose.\n
        prompt.Text = "No, we cannot. That's one reason I'm selling you. I'll have to hire servants, I suppose.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 Jonah could be your servant. He could earn his freedom in a few years.\n
        response.Text = "Jonah could be your servant. He could earn his freedom in a few years.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n20
        response.NextNodeId = "n20";
        response.SetCondition(n13_r0_condition);
        response.OnSelect(n13_r0_select);
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 You would just have me let him go?\n
        prompt.Text = "You would just have me let him go?\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 He could be your servant. He could earn his freedom in a few years.\n
        response.Text = "He could be your servant. He could earn his freedom in a few years.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n14 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 1 Yes, please let him live his life free.\n
        response.Text = "Yes, please let him live his life free.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 1 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 You would just have me let him go?\n
        prompt.Text = "You would just have me let him go?\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 He could be your servant. He could earn his freedom in a few years.\n
        response.Text = "He could be your servant. He could earn his freedom in a few years.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 n20
        response.NextNodeId = "n20";
        response.OnSelect(n15_r0_select);
        
        ///RESPONSE n15 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 1 Yes, please let him live his life free.\n
        response.Text = "Yes, please let him live his life free.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 1 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 Thank you, Lucy. Father never liked you, but you have a good heart.\n
        prompt.Text = "Thank you, Lucy. Father never liked you, but you have a good heart.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 It's not doing me much good right now.\n
        response.Text = "It's not doing me much good right now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n19
        response.NextNodeId = "n19";
        
        ///RESPONSE n16 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 1 Miss Sarah, you have a good heart too... I'm hoping you'd consider not selling Jonah.\n
        response.Text = "Miss Sarah, you have a good heart too... I'm hoping you'd consider not selling Jonah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 1 n15
        response.NextNodeId = "n15";
        response.SetCondition(n16_r1_condition);
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 What a ridiculous idea! I'm sure I can get at least $800 for him. Mr. Bercham, please take them to Maysville for auction. [She turns to leave.]\n
        prompt.Text = "What a ridiculous idea! I'm sure I can get at least $800 for him. Mr. Bercham, please take them to Maysville for auction. [She turns to leave.]\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 Why, thank you, Lucy. I wish you could meet him. He's so handsome.\n
        prompt.Text = "Why, thank you, Lucy. I wish you could meet him. He's so handsome.\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 I won't meet him because I'll be down south picking cotton.\n
        response.Text = "I won't meet him because I'll be down south picking cotton.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n18 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 1 Where will you be living, Miss Sarah?\n
        response.Text = "Where will you be living, Miss Sarah?\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 1 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 I'm sorry, Lucy. This is just the way it has to be. Mr. Bercham, please take care of things. [She turns to leave.]\n
        prompt.Text = "I'm sorry, Lucy. This is just the way it has to be. Mr. Bercham, please take care of things. [She turns to leave.]\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n19
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 That's not a good idea, Miss King. Get your money now. You can hire a servant if you need one.\n
        prompt.Text = "That's not a good idea, Miss King. Get your money now. You can hire a servant if you need one.\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n25
        response.NextNodeId = "n25";
        response.SetCondition(n20_r0_condition);
        
        ///RESPONSE n20 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 1 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 1 n21
        response.NextNodeId = "n21";
        response.SetCondition(n20_r1_condition);
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 [She pauses to think. It looks like she is calculating something.]\n
        prompt.Text = "[She pauses to think. It looks like she is calculating something.]\n";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n22
        response.NextNodeId = "n22";
        
        ///NODE_END n21
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Full
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n22~|||~
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 Very well, I'll take Jonah on as a servant for 10 years. That should be enough time to earn his freedom.\n
        prompt.Text = "Very well, I'll take Jonah on as a servant for 10 years. That should be enough time to earn his freedom.\n";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 I think eight years would be more fair, Miss Sarah.\n
        response.Text = "I think eight years would be more fair, Miss Sarah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n25
        response.NextNodeId = "n25";
        
        ///RESPONSE n22 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 1 Thank you, Miss Sarah.\n
        response.Text = "Thank you, Miss Sarah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 1 n23
        response.NextNodeId = "n23";
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 But ma'am...\n
        prompt.Text = "But ma'am...\n";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n24
        response.NextNodeId = "n24";
        
        ///NODE_END n23
        ///NODE_START n24
        node = dialog.CreateNode("n24");
        ///NODE_NPC n24 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n24 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24 Full
        ///NODE_VISUAL_USESCRIPT n24 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n24~|||~
        ///PROMPT n24 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24 0 Don't worry, Mr. Bercham, you'll get paid the same. Take her to the auction. I'll collect the boy. [She turns to leave.]\n
        prompt.Text = "Don't worry, Mr. Bercham, you'll get paid the same. Take her to the auction. I'll collect the boy. [She turns to leave.]\n";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 END
        response.NextNodeId = "END";
        response.OnSelect(n24_r0_select);
        
        ///NODE_END n24
        ///NODE_START n25
        node = dialog.CreateNode("n25");
        ///NODE_NPC n25 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n25 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n25 Full
        ///NODE_VISUAL_USESCRIPT n25 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n25~|||~
        ///PROMPT n25 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n25 0 You're right, Mr. Bercham. These Negroes are more trouble than they're worth. Take them both to the auction. [She turns to leave.]\n
        prompt.Text = "You're right, Mr. Bercham. These Negroes are more trouble than they're worth. Take them both to the auction. [She turns to leave.]\n";
        ///PROMPT_IGNORE_VO n25 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n25 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n25
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n06_p1_condition
    public bool n06_p1_condition (  ) {
        ///METHOD_BODY_START n06_p1_condition
        /*//if (#p4_lucy_canada > 0)*/
        return true;
        ///METHOD_BODY_END n06_p1_condition
    }

    ///METHOD n11_p1_condition
    public bool n11_p1_condition (  ) {
        ///METHOD_BODY_START n11_p1_condition
        /*//if (?p1_yankee_gentlemen = true)*/
        return true;
        ///METHOD_BODY_END n11_p1_condition
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//setLayer("fg", "gfx/swfs/dlg_bg/dbg_jail_interior_fore.swf")*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n07_p0_show
    public void n07_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n07_p0_show
        /*//showNpc( false, 2 )*/
        ///METHOD_BODY_END n07_p0_show
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if (#dress_quality < 3)*/
        return true;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD n01_r2_condition
    public bool n01_r2_condition (  ) {
        ///METHOD_BODY_START n01_r2_condition
        /*//if (#dress_quality = 3)*/
        return true;
        ///METHOD_BODY_END n01_r2_condition
    }

    ///METHOD n02_r2_condition
    public bool n02_r2_condition (  ) {
        ///METHOD_BODY_START n02_r2_condition
        /*//if (#p4_lucy_canada = 0)*/
        return true;
        ///METHOD_BODY_END n02_r2_condition
    }

    ///METHOD n04_r1_condition
    public bool n04_r1_condition (  ) {
        ///METHOD_BODY_START n04_r1_condition
        /*//if (#p4_lucy_canada = 0)*/
        return true;
        ///METHOD_BODY_END n04_r1_condition
    }

    ///METHOD n06_r0_condition
    public bool n06_r0_condition (  ) {
        ///METHOD_BODY_START n06_r0_condition
        /*//if (#p4_lucy_canada = 0)*/
        return true;
        ///METHOD_BODY_END n06_r0_condition
    }

    ///METHOD n10_r2_condition
    public bool n10_r2_condition (  ) {
        ///METHOD_BODY_START n10_r2_condition
        /*//if (?p1_yankee_gentlemen = true)*/
        return true;
        ///METHOD_BODY_END n10_r2_condition
    }

    ///METHOD n11_r1_condition
    public bool n11_r1_condition (  ) {
        ///METHOD_BODY_START n11_r1_condition
        /*//if (#p4_lucy_canada = 0)*/
        return true;
        ///METHOD_BODY_END n11_r1_condition
    }

    ///METHOD n12_r0_condition
    public bool n12_r0_condition (  ) {
        ///METHOD_BODY_START n12_r0_condition
        /*//if (#p4_lucy_canada = 0)*/
        return true;
        ///METHOD_BODY_END n12_r0_condition
    }

    ///METHOD n13_r0_condition
    public bool n13_r0_condition (  ) {
        ///METHOD_BODY_START n13_r0_condition
        /*//if (#p4_lucy_canada = 0)*/
        return true;
        ///METHOD_BODY_END n13_r0_condition
    }

    ///METHOD n16_r1_condition
    public bool n16_r1_condition (  ) {
        ///METHOD_BODY_START n16_r1_condition
        /*//if (#p4_lucy_canada = 0)*/
        return true;
        ///METHOD_BODY_END n16_r1_condition
    }

    ///METHOD n20_r0_condition
    public bool n20_r0_condition (  ) {
        ///METHOD_BODY_START n20_r0_condition
        /*//if (?p4_plea_works = false)*/
        return true;
        ///METHOD_BODY_END n20_r0_condition
    }

    ///METHOD n20_r1_condition
    public bool n20_r1_condition (  ) {
        ///METHOD_BODY_START n20_r1_condition
        /*//if (?p4_plea_works = true)*/
        return true;
        ///METHOD_BODY_END n20_r1_condition
    }

    ///METHOD n13_r0_select
    public void n13_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n13_r0_select
        /*//set ?p4_plea_works = true*/
        ///METHOD_BODY_END n13_r0_select
    }

    ///METHOD n15_r0_select
    public void n15_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15_r0_select
        /*//set ?p4_plea_works = true*/
        ///METHOD_BODY_END n15_r0_select
    }

    ///METHOD n24_r0_select
    public void n24_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n24_r0_select
        /*//set ?p4_jonah_servant = true*/
        ///METHOD_BODY_END n24_r0_select
    }
}
//CLASS_END Dialog_p4_sar_001
