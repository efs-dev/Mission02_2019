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
//CLASS Dialog_p3_ran_002
public class Dialog_p3_ran_002 {
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
        ///DIALOG_ID p3_ran_002
        var dialog = new Dialog();
        dialog.Id = "p3_ran_002";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 Ladies and gentlemen, let me call this meeting to order.\n
        prompt.Text = "Ladies and gentlemen, let me call this meeting to order.\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 We have many urgent matters to review, but first I want to welcome someone new... Miss Lucy Wright.\n
        prompt.Text = "We have many urgent matters to review, but first I want to welcome someone new... Miss Lucy Wright.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n02_p0_show);
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 Thank you, Reverend.\n
        response.Text = "Thank you, Reverend.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 Miss Wright crossed my door a year ago and has joined her aunt and her uncle here in Red Oak. We are happy you are here, Lucy.\n
        prompt.Text = "Miss Wright crossed my door a year ago and has joined her aunt and her uncle here in Red Oak. We are happy you are here, Lucy.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n03_p0_show);
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 Will we be able to talk about rescuing my family?\n
        response.Text = "Will we be able to talk about rescuing my family?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 I am happy to be here. Thank you for inviting me.\n
        response.Text = "I am happy to be here. Thank you for inviting me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 We'll start tonight with the issue of slave catchers. John Parker will say a few words.\n
        prompt.Text = "We'll start tonight with the issue of slave catchers. John Parker will say a few words.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n04_p0_show);
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 It's getting more dangerous to move our ###smartword|cargo|CARGO### every day. Men like TC Bercham are prowling the streets. We can't trust anyone.\n
        prompt.Text = "It's getting more dangerous to move our ###smartword|cargo|CARGO### every day. Men like TC Bercham are prowling the streets. We can't trust anyone.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n05_p0_show);
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 Yes, Mr. Bercham was spying on me and Mr. Parker today when I picked up his laundry. \n
        response.Text = "Yes, Mr. Bercham was spying on me and Mr. Parker today when I picked up his laundry. \n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n06
        response.NextNodeId = "n06";
        response.SetCondition(n05_r1_condition);
        
        ///RESPONSE n05 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 2 Excuse me, Mr. Parker, but I ran into Mr. Bercham today. He questioned me about you.\n
        response.Text = "Excuse me, Mr. Parker, but I ran into Mr. Bercham today. He questioned me about you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 2 n06
        response.NextNodeId = "n06";
        response.SetCondition(n05_r2_condition);
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Exactly what I mean. Thank you Lucy. We're going to have to start taking new precautions. Here's what I think...\n
        prompt.Text = "Exactly what I mean. Thank you Lucy. We're going to have to start taking new precautions. Here's what I think...\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n06_p0_show);
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [He speaks for a while.]\n
        response.Text = "[He speaks for a while.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 Just today I caught TC Bercham spying on Lucy and me. We're going to have to start taking new precautions. Here's what I think...\n
        prompt.Text = "Just today I caught TC Bercham spying on Lucy and me. We're going to have to start taking new precautions. Here's what I think...\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n07_p0_show);
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 [He speaks for a while.]\n
        response.Text = "[He speaks for a while.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Miss Hatcher here will now tell us about our fundraiser.\n
        prompt.Text = "Miss Hatcher here will now tell us about our fundraiser.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n08_p0_show);
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 We have everything ready for next week. Just today, Lucy gave me all the handkerchiefs the Wrights made for us.\n
        prompt.Text = "We have everything ready for next week. Just today, Lucy gave me all the handkerchiefs the Wrights made for us.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n09_p0_show);
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n19
        response.NextNodeId = "n19";
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 What will you do with the money?\n
        response.Text = "What will you do with the money?\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n09_r1_condition);
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 Good question. Most of it will help those in need move to Canada. But some will be used to expand our school here in Red Oak.\n
        prompt.Text = "Good question. Most of it will help those in need move to Canada. But some will be used to expand our school here in Red Oak.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n10_p0_show);
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n19
        response.NextNodeId = "n19";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 Why do they move to Canada? Why can't we build them homes here?\n
        response.Text = "Why do they move to Canada? Why can't we build them homes here?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 Canada is the only place that is truly safe. \n
        prompt.Text = "Canada is the only place that is truly safe. \n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n19
        response.NextNodeId = "n19";
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 I wish it could be safe here.\n
        response.Text = "I wish it could be safe here.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n12
        response.NextNodeId = "n12";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 That's what we're fighting for... That's all I have to say, Reverend.\n
        prompt.Text = "That's what we're fighting for... That's all I have to say, Reverend.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n12_p0_show);
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Finally, we have a special guest: Mr. Benjamin Harrison. He is running for office and has a few words for us.\n
        prompt.Text = "Finally, we have a special guest: Mr. Benjamin Harrison. He is running for office and has a few words for us.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n13_p0_show);
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 Someday slavery will be ended. We all want that. But what then? How do whites and Negroes live together?\n
        prompt.Text = "Someday slavery will be ended. We all want that. But what then? How do whites and Negroes live together?\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n14_p0_show);
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n15
        response.NextNodeId = "n15";
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 The honest answer is that they should not. The home of the Negro people is Africa. We brought them here and we need to help them go home.\n
        prompt.Text = "The honest answer is that they should not. The home of the Negro people is Africa. We brought them here and we need to help them go home.\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n15_p0_show);
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 [Look around.]\n
        response.Text = "[Look around.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 n17
        response.NextNodeId = "n17";
        
        ///RESPONSE n15 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 1 But my home is here. I've never even seen Africa.\n
        response.Text = "But my home is here. I've never even seen Africa.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 1 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 It's natural to think that. But you will never be accepted here. You will never be a full citizen. In Africa you can be.\n
        prompt.Text = "It's natural to think that. But you will never be accepted here. You will never be a full citizen. In Africa you can be.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n16_p0_show);
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n18
        response.NextNodeId = "n18";
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 [Abigail looks uncomfortable as do many other abolitionists.]\n
        prompt.Text = "[Abigail looks uncomfortable as do many other abolitionists.]\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n17 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 1 But my home is here. I've never even seen Africa.\n
        response.Text = "But my home is here. I've never even seen Africa.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 1 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 This idea is called ###smartword|Colonization|COLONIZATION###. And it actually began in the time of President Washington. Since then thousands have gone back...\n
        prompt.Text = "This idea is called ###smartword|Colonization|COLONIZATION###. And it actually began in the time of President Washington. Since then thousands have gone back...\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n18_p0_show);
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 [He speaks for a while.]
        response.Text = "[He speaks for a while.]";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n24
        response.NextNodeId = "n24";
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 Finally, the school is doing well, although we could use more supplies. That's all I have to say, Reverend.\n
        prompt.Text = "Finally, the school is doing well, although we could use more supplies. That's all I have to say, Reverend.\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n19_p0_show);
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n19
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 [Abigail elbows you gently on the word \"rescuing\".]\n
        prompt.Text = "[Abigail elbows you gently on the word \"rescuing\".]\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 Um, will we be able to talk about rescuing the, um, town from slave catchers?\n
        response.Text = "Um, will we be able to talk about rescuing the, um, town from slave catchers?\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n23
        response.NextNodeId = "n23";
        
        ///RESPONSE n20 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 1 [Finish your question.]\n
        response.Text = "[Finish your question.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 1 n21
        response.NextNodeId = "n21";
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 ABIGAIL: Whatever do you mean, Lucy? We're fine. We're safe. No one needs to rescue us.\n
        prompt.Text = "ABIGAIL: Whatever do you mean, Lucy? We're fine. We're safe. No one needs to rescue us.\n";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n21_p0_show);
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 I mean my real family. Mama and my brother Jonah back in Kentucky.\n
        response.Text = "I mean my real family. Mama and my brother Jonah back in Kentucky.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 END
        response.NextNodeId = "END";
        response.OnSelect(n21_r0_select);
        
        ///RESPONSE n21 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 1 Yes, of course. I'm sorry.\n
        response.Text = "Yes, of course. I'm sorry.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n21
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 You read my mind Lucy. That is the very first issue we are to discuss. John Parker here will now say a few words.\n
        prompt.Text = "You read my mind Lucy. That is the very first issue we are to discuss. John Parker here will now say a few words.\n";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n23_p0_show);
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n23
        ///NODE_START n24
        node = dialog.CreateNode("n24");
        ///NODE_NPC n24 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n24 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24 Full
        ///NODE_VISUAL_USESCRIPT n24 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n24~|||~
        ///PROMPT n24 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24 0 [The meeting is soon over. Reverend Rankin asks you to stay for a few minutes after.]\n
        prompt.Text = "[The meeting is soon over. Reverend Rankin asks you to stay for a few minutes after.]\n";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n24
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//showNpc( true, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n02_p0_show
    public void n02_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n02_p0_show
        /*//showNpc( true, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n02_p0_show
    }

    ///METHOD n03_p0_show
    public void n03_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n03_p0_show
        /*//showNpc( true, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n03_p0_show
    }

    ///METHOD n04_p0_show
    public void n04_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n04_p0_show
        /*//showNpc( true, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n04_p0_show
    }

    ///METHOD n05_p0_show
    public void n05_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n05_p0_show
        /*//showNpc( false, 1 )
        //showNpc( true, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n05_p0_show
    }

    ///METHOD n06_p0_show
    public void n06_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n06_p0_show
        /*//showNpc( false, 1 )
        //showNpc( true, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n06_p0_show
    }

    ///METHOD n07_p0_show
    public void n07_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n07_p0_show
        /*//showNpc( false, 1 )
        //showNpc( true, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n07_p0_show
    }

    ///METHOD n08_p0_show
    public void n08_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n08_p0_show
        /*//showNpc( true, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n08_p0_show
    }

    ///METHOD n09_p0_show
    public void n09_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n09_p0_show
        /*//showNpc( false, 1 )
        //showNpc( false, 2 )
        //showNpc( true, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n09_p0_show
    }

    ///METHOD n10_p0_show
    public void n10_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n10_p0_show
        /*//showNpc( false, 1 )
        //showNpc( false, 2 )
        //showNpc( true, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n10_p0_show
    }

    ///METHOD n12_p0_show
    public void n12_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n12_p0_show
        /*//showNpc( false, 1 )
        //showNpc( false, 2 )
        //showNpc( true, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n12_p0_show
    }

    ///METHOD n13_p0_show
    public void n13_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n13_p0_show
        /*//showNpc( true, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n13_p0_show
    }

    ///METHOD n14_p0_show
    public void n14_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n14_p0_show
        /*//showNpc( false, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( true, 4 )*/
        ///METHOD_BODY_END n14_p0_show
    }

    ///METHOD n15_p0_show
    public void n15_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n15_p0_show
        /*//showNpc( false, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( true, 4 )*/
        ///METHOD_BODY_END n15_p0_show
    }

    ///METHOD n16_p0_show
    public void n16_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n16_p0_show
        /*//showNpc( false, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( true, 4 )*/
        ///METHOD_BODY_END n16_p0_show
    }

    ///METHOD n18_p0_show
    public void n18_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n18_p0_show
        /*//showNpc( false, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( true, 4 )*/
        ///METHOD_BODY_END n18_p0_show
    }

    ///METHOD n19_p0_show
    public void n19_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n19_p0_show
        /*//showNpc( false, 1 )
        //showNpc( false, 2 )
        //showNpc( true, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n19_p0_show
    }

    ///METHOD n21_p0_show
    public void n21_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n21_p0_show
        /*//play_sfx("audio/dlgs/p3/p3_ran_002/p3_ran_002_n21_p0.mp3")*/
        ///METHOD_BODY_END n21_p0_show
    }

    ///METHOD n23_p0_show
    public void n23_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n23_p0_show
        /*//showNpc( true, 1 )
        //showNpc( false, 2 )
        //showNpc( false, 3 )
        //showNpc( false, 4 )*/
        ///METHOD_BODY_END n23_p0_show
    }

    ///METHOD n05_r1_condition
    public bool n05_r1_condition (  ) {
        ///METHOD_BODY_START n05_r1_condition
        /*//if ((?p3_tc_spied = true) AND (?p3_ask_tc = true))*/
        return GameFlags.P3TcSpied && GameFlags.P3AskTc;
        ///METHOD_BODY_END n05_r1_condition
    }

    ///METHOD n05_r2_condition
    public bool n05_r2_condition (  ) {
        ///METHOD_BODY_START n05_r2_condition
        /*//if ((?p3_tc_ask_parker = true) AND (?p3_ask_tc = true))*/
        return GameFlags.P3TcAskParker && GameFlags.P3AskTc;
        ///METHOD_BODY_END n05_r2_condition
    }

    ///METHOD n09_r1_condition
    public bool n09_r1_condition (  ) {
        ///METHOD_BODY_START n09_r1_condition
        /*//if (?p3_ask_funds = false)*/
        return !GameFlags.P3AskFunds;
        ///METHOD_BODY_END n09_r1_condition
    }

    ///METHOD n21_r0_select
    public void n21_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n21_r0_select
        /*//$next_state = "LOSE_RAN_002"*/
        GameFlags.P3LoseRan002 = true;
        ///METHOD_BODY_END n21_r0_select
    }
}
//CLASS_END Dialog_p3_ran_002
