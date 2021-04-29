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
//CLASS Dialog_p1_sar_001
public class Dialog_p1_sar_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _p1_yankee_gentlemen
        private bool _p1_yankee_gentlemen = false;

        //PROPERTY p1_yankee_gentlemen
        public bool p1_yankee_gentlemen {
                get {
                        ///PROPERTY_GETTER_START p1_yankee_gentlemen
                        return _p1_yankee_gentlemen;
                        ///PROPERTY_GETTER_END p1_yankee_gentlemen
                }
                set {
                        ///PROPERTY_SETTER_START p1_yankee_gentlemen
                        _p1_yankee_gentlemen = value;
                        ///PROPERTY_SETTER_END p1_yankee_gentlemen
                }
        }
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
        ///DIALOG_ID p1_sar_001
        var dialog = new Dialog();
        dialog.Id = "p1_sar_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n0
        node = dialog.CreateNode("n0");
        ///NODE_NPC n0 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n0 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n0 Full
        ///NODE_VISUAL_USESCRIPT n0 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n0~|||~
        ///PROMPT n0 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n0 0 Oh, thank goodness, Lucy, I need something from you.
        prompt.Text = "Oh, thank goodness, Lucy, I need something from you.";
        ///PROMPT_IGNORE_VO n0 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n0 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n0 0 What is it, Sarah?
        response.Text = "What is it, Sarah?";
        ///RESPONSE_NEXT_NODE_TYPE n0 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n0 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n0
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
        ///PROMPT_TEXT n01 0 Well, there you are at last, Lucy! I sent for you hours ago.
        prompt.Text = "Well, there you are at last, Lucy! I sent for you hours ago.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 I'm sorry Sarah, it couldn't have been that long.
        response.Text = "I'm sorry Sarah, it couldn't have been that long.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n04
        response.NextNodeId = "n04";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 I came when I could! I've got many things to attend to, Sarah.
        response.Text = "I came when I could! I've got many things to attend to, Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 I'm sorry Sarah. It won't happen again.
        response.Text = "I'm sorry Sarah. It won't happen again.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
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
        ///PROMPT_TEXT n02 0 <sigh>'MISS' Sarah, Lucy. 'MISS' Sarah. We're not children anymore. If mother hears you'll get what-for.
        prompt.Text = "<sigh>'MISS' Sarah, Lucy. 'MISS' Sarah. We're not children anymore. If mother hears you'll get what-for.";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 But Sarah, no one can hear us. We're alone.
        response.Text = "But Sarah, no one can hear us. We're alone.";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n05
        response.NextNodeId = "n05";
        response.OnSelect(n02_r0_select);
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Yes, Miss Sarah.
        response.Text = "Yes, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n06
        response.NextNodeId = "n06";
        
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
        ///PROMPT_TEXT n03 0 MISS Sarah, Lucy. Miss Sarah. And I don't want to hear excuses. I want you to come when I call for you.
        prompt.Text = "MISS Sarah, Lucy. Miss Sarah. And I don't want to hear excuses. I want you to come when I call for you.";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 [Mumble] The dog don't even  come when you call.
        response.Text = "[Mumble] The dog don't even  come when you call.";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 Yes, Miss Sarah.
        response.Text = "Yes, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n06
        response.NextNodeId = "n06";
        
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
        ///PROMPT_TEXT n04 0 MISS Sarah, Lucy. Miss Sarah. And are you correcting me?
        prompt.Text = "MISS Sarah, Lucy. Miss Sarah. And are you correcting me?";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 But it really wasn't that long.
        response.Text = "But it really wasn't that long.";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 No, Miss Sarah. I'm sorry.
        response.Text = "No, Miss Sarah. I'm sorry.";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n06
        response.NextNodeId = "n06";
        
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
        ///PROMPT_TEXT n05 0 Enough Lucy. Lucky for you, I'm in a hurry, otherwise we'd have a lesson in manners.
        prompt.Text = "Enough Lucy. Lucky for you, I'm in a hurry, otherwise we'd have a lesson in manners.";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Yes, Miss Sarah.
        response.Text = "Yes, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n06
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
        ///PROMPT_TEXT n06 0 Now pay attention. I need you to fix up my new dress before I leave this afternoon.
        prompt.Text = "Now pay attention. I need you to fix up my new dress before I leave this afternoon.";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Why so soon, Miss Sarah?
        response.Text = "Why so soon, Miss Sarah?";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n07a
        response.NextNodeId = "n07a";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 Yes, Miss Sarah. What do you want me to do?
        response.Text = "Yes, Miss Sarah. What do you want me to do?";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n15a
        response.NextNodeId = "n15a";
        
        ///RESPONSE n06 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 2 [After examining dress] What's wrong? It looks just fine to me.
        response.Text = "[After examining dress] What's wrong? It looks just fine to me.";
        ///RESPONSE_NEXT_NODE_TYPE n06 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 2 n07
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
        ///PROMPT_TEXT n07 0 Not for my cousin's wedding. I'm leaving for Cincinnati right after lunch. She's marrying a Notherner. Can you believe it?
        prompt.Text = "Not for my cousin's wedding. I'm leaving for Cincinnati right after lunch. She's marrying a Notherner. Can you believe it?";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 The family must not like that.
        response.Text = "The family must not like that.";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 So that's why you have to change your dress.
        response.Text = "So that's why you have to change your dress.";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n15b
        response.NextNodeId = "n15b";
        
        ///NODE_END n07
        ///NODE_START n07a
        node = dialog.CreateNode("n07a");
        ///NODE_NPC n07a SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n07a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07a Full
        ///NODE_VISUAL_USESCRIPT n07a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07a~|||~
        ///PROMPT n07a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07a 0 I'm leaving for my cousin's wedding in Cincinnati right after lunch. She's marrying a Northerner. Can you believe it?
        prompt.Text = "I'm leaving for my cousin's wedding in Cincinnati right after lunch. She's marrying a Northerner. Can you believe it?";
        ///PROMPT_IGNORE_VO n07a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07a 0 The family must not like that.
        response.Text = "The family must not like that.";
        ///RESPONSE_NEXT_NODE_TYPE n07a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07a 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n07a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07a 1 So that's why you have to change your dress.
        response.Text = "So that's why you have to change your dress.";
        ///RESPONSE_NEXT_NODE_TYPE n07a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07a 1 n15b
        response.NextNodeId = "n15b";
        
        ///NODE_END n07a
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
        ///PROMPT_TEXT n08 0 In Ohio, north of the river. Tomorrow we're going to take the ferry from Maysville! Isn't that exciting?
        prompt.Text = "In Ohio, north of the river. Tomorrow we're going to take the ferry from Maysville! Isn't that exciting?";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 That does sound exciting Miss Sarah.
        response.Text = "That does sound exciting Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 Why yes Miss Sarah! I wish I could go with you.
        response.Text = "Why yes Miss Sarah! I wish I could go with you.";
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
        ///PROMPT_TEXT n09 0 What a funny idea! Father would never take a slave up north. Besides we give you everything you need right here.
        prompt.Text = "What a funny idea! Father would never take a slave up north. Besides we give you everything you need right here.";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 [Mumble] Not even by half.
        response.Text = "[Mumble] Not even by half.";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n09_r0_select);
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 Yes, Miss Sarah. I guess I was being silly.
        response.Text = "Yes, Miss Sarah. I guess I was being silly.";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n12
        response.NextNodeId = "n12";
        
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
        ///PROMPT_TEXT n10 0 And Father says we can stop at Paris to see my cousins. Oh listen to me go on, we better get to work.\n
        prompt.Text = "And Father says we can stop at Paris to see my cousins. Oh listen to me go on, we better get to work.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 Yes, Miss Sarah. What do you need me to do?
        response.Text = "Yes, Miss Sarah. What do you need me to do?";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n15b
        response.NextNodeId = "n15b";
        
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
        ///PROMPT_TEXT n11 0 What was that? Oh, never mind, we better get to work.
        prompt.Text = "What was that? Oh, never mind, we better get to work.";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 Yes, Miss Sarah. What do you need me to do?
        response.Text = "Yes, Miss Sarah. What do you need me to do?";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n15b
        response.NextNodeId = "n15b";
        
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
        ///PROMPT_TEXT n12 0 Yes, you always were a silly little thing. Well, enough chatter, let's get to work.\n
        prompt.Text = "Yes, you always were a silly little thing. Well, enough chatter, let's get to work.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 Yes, Miss Sarah. What do I have to do?\n
        response.Text = "Yes, Miss Sarah. What do I have to do?\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n15b
        response.NextNodeId = "n15b";
        
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
        ///PROMPT_TEXT n13 0 Enough of your questions! You don't have much time.\n
        prompt.Text = "Enough of your questions! You don't have much time.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 I'm sorry Miss Sarah. What do you want me to do to the dress?
        response.Text = "I'm sorry Miss Sarah. What do you want me to do to the dress?";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n15b
        response.NextNodeId = "n15b";
        
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
        ///PROMPT_TEXT n14 0 My father says he's better than most Yankees who want to meddle with our southern affairs.\n
        prompt.Text = "My father says he's better than most Yankees who want to meddle with our southern affairs.\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 I see Miss Sarah. Where is Cincinnati?
        response.Text = "I see Miss Sarah. Where is Cincinnati?";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n08
        response.NextNodeId = "n08";
        response.SetCondition(n14_r0_condition);
        
        ///RESPONSE n14 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 1 I see Miss Sarah. Where is Cincinnati?
        response.Text = "I see Miss Sarah. Where is Cincinnati?";
        ///RESPONSE_NEXT_NODE_TYPE n14 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 1 n13
        response.NextNodeId = "n13";
        response.SetCondition(n14_r1_condition);
        
        ///RESPONSE n14 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 2 I see Miss Sarah. What do you need me to do to the dress?
        response.Text = "I see Miss Sarah. What do you need me to do to the dress?";
        ///RESPONSE_NEXT_NODE_TYPE n14 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 2 n15b
        response.NextNodeId = "n15b";
        
        ///NODE_END n14
        ///NODE_START n15a
        node = dialog.CreateNode("n15a");
        ///NODE_NPC n15a SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n15a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15a Full
        ///NODE_VISUAL_USESCRIPT n15a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15a~|||~
        ///PROMPT n15a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15a 0 I'm attending a wedding in Ohio. I must look beautiful. Here's a page from Godey's with the latest fashion...
        prompt.Text = "I'm attending a wedding in Ohio. I must look beautiful. Here's a page from Godey's with the latest fashion...";
        ///PROMPT_IGNORE_VO n15a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15a 0 [Look at picture]
        response.Text = "[Look at picture]";
        ///RESPONSE_NEXT_NODE_TYPE n15a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15a 0 n16a
        response.NextNodeId = "n16a";
        response.OnSelect(n15a_r0_select);
        
        ///NODE_END n15a
        ///NODE_START n15b
        node = dialog.CreateNode("n15b");
        ///NODE_NPC n15b SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n15b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15b Full
        ///NODE_VISUAL_USESCRIPT n15b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15b~|||~
        ///PROMPT n15b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15b 0 If I'm to be in the company of ###smartword|Yankee|YANKEE### gentlemen, I must look beautiful. Here's a magazine with the latest fashion...
        prompt.Text = "If I'm to be in the company of ###smartword|Yankee|YANKEE### gentlemen, I must look beautiful. Here's a magazine with the latest fashion...";
        ///PROMPT_IGNORE_VO n15b 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n15b_p0_show);
        
        ///RESPONSE n15b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15b 0 [Look at picture]
        response.Text = "[Look at picture]";
        ///RESPONSE_NEXT_NODE_TYPE n15b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15b 0 n16a
        response.NextNodeId = "n16a";
        response.OnSelect(n15b_r0_select);
        
        ///NODE_END n15b
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
        ///PROMPT_TEXT n16 0 Can you make my dress look like that?
        prompt.Text = "Can you make my dress look like that?";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 I can try, but Mr. Otis already gave me lots to do this afternoon.
        response.Text = "I can try, but Mr. Otis already gave me lots to do this afternoon.";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n21
        response.NextNodeId = "n21";
        
        ///RESPONSE n16 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 1 You're already pretty, Miss Sarah. Why fuss about the dress?
        response.Text = "You're already pretty, Miss Sarah. Why fuss about the dress?";
        ///RESPONSE_NEXT_NODE_TYPE n16 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 1 n20
        response.NextNodeId = "n20";
        response.OnSelect(n16_r1_select);
        
        ///RESPONSE n16 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 2 Won't your mama be upset if we make these changes, Miss Sarah?
        response.Text = "Won't your mama be upset if we make these changes, Miss Sarah?";
        ///RESPONSE_NEXT_NODE_TYPE n16 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 2 n19
        response.NextNodeId = "n19";
        
        ///RESPONSE n16 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 3 I'll do my best Miss Sarah.
        response.Text = "I'll do my best Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n16 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 3 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n16
        ///NODE_START n16a
        node = dialog.CreateNode("n16a");
        ///NODE_NPC n16a SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n16a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16a Full
        ///NODE_VISUAL_USESCRIPT n16a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16a~|||~
        ///RESPONSE n16a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16a 0 [Done]
        response.Text = "[Done]";
        ///RESPONSE_NEXT_NODE_TYPE n16a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16a 0 n16
        response.NextNodeId = "n16";
        response.OnSelect(n16a_r0_select);
        
        ///NODE_END n16a
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
        ///PROMPT_TEXT n17 0 Yes, Lucy, you can do a good job when you pay attention. Like when you learned your letters from me.
        prompt.Text = "Yes, Lucy, you can do a good job when you pay attention. Like when you learned your letters from me.";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 You were a good teacher, Miss Sarah. I wish I could still practice my letters.
        response.Text = "You were a good teacher, Miss Sarah. I wish I could still practice my letters.";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n18
        response.NextNodeId = "n18";
        
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
        ///PROMPT_TEXT n18 0 Teaching slaves only causes trouble. I certainly don't see any use in it.  Why, it doesn't help you do the wash better, does it?\n
        prompt.Text = "Teaching slaves only causes trouble. I certainly don't see any use in it.  Why, it doesn't help you do the wash better, does it?\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 No, Miss Sarah, but I did like doing it.
        response.Text = "No, Miss Sarah, but I did like doing it.";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n25
        response.NextNodeId = "n25";
        
        ///RESPONSE n18 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 1 No, Miss Sarah, I suppose not.
        response.Text = "No, Miss Sarah, I suppose not.";
        ///RESPONSE_NEXT_NODE_TYPE n18 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 1 n30
        response.NextNodeId = "n30";
        
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
        ///PROMPT_TEXT n19 0 That's why we'll keep this our little secret, right?
        prompt.Text = "That's why we'll keep this our little secret, right?";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 Yes, Miss Sarah. But this will take some time and Mr. Otis already gave me extra work this afternoon.
        response.Text = "Yes, Miss Sarah. But this will take some time and Mr. Otis already gave me extra work this afternoon.";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 n22
        response.NextNodeId = "n22";
        
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
        ///PROMPT_TEXT n20 0 Well aren't you sweet for saying? Know what? I'm going to give you this here old shawl of mine. It used be very fashionable.
        prompt.Text = "Well aren't you sweet for saying? Know what? I'm going to give you this here old shawl of mine. It used be very fashionable.";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n20_p0_show);
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 Thank you, Miss Sarah. I'll get started. But it would be easier if I didn't have to do Mr. Otis' extra work today.
        response.Text = "Thank you, Miss Sarah. I'll get started. But it would be easier if I didn't have to do Mr. Otis' extra work today.";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n23
        response.NextNodeId = "n23";
        
        ///RESPONSE n20 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 1 Thank you, Miss Sarah.
        response.Text = "Thank you, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n20 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 1 n30
        response.NextNodeId = "n30";
        
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
        ///PROMPT_TEXT n21 0 I guess you'll just have to do that other work later.\n
        prompt.Text = "I guess you'll just have to do that other work later.\n";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 Yes, and if I get in trouble I'll just say that I was fixing up your dress.
        response.Text = "Yes, and if I get in trouble I'll just say that I was fixing up your dress.";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n22
        response.NextNodeId = "n22";
        response.OnSelect(n21_r0_select);
        
        ///RESPONSE n21 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 1 Yes, Miss Sarah.
        response.Text = "Yes, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n21 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 1 n30
        response.NextNodeId = "n30";
        
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
        ///PROMPT_TEXT n22 0 Yes, well I guess I'd rather not see you get in trouble. I'll talk to Mr. Otis.
        prompt.Text = "Yes, well I guess I'd rather not see you get in trouble. I'll talk to Mr. Otis.";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n22_p0_show);
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 Thank you, Miss Sarah.
        response.Text = "Thank you, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n30
        response.NextNodeId = "n30";
        
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
        ///PROMPT_TEXT n23 0 What extra work?
        prompt.Text = "What extra work?";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 I have too much work to do now. Can you speak to Mr. Otis for me?
        response.Text = "I have too much work to do now. Can you speak to Mr. Otis for me?";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n29
        response.NextNodeId = "n29";
        
        ///RESPONSE n23 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 1 Mr. Otis assigned me extra chores this afternoon but I need time to do the very best job on your dress.
        response.Text = "Mr. Otis assigned me extra chores this afternoon but I need time to do the very best job on your dress.";
        ///RESPONSE_NEXT_NODE_TYPE n23 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 1 n24
        response.NextNodeId = "n24";
        response.OnSelect(n23_r1_select);
        
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
        ///PROMPT_TEXT n24 0 Why I'm sure someone else can do those chores. I need you fixing up my dress. I'll speak to him.
        prompt.Text = "Why I'm sure someone else can do those chores. I need you fixing up my dress. I'll speak to him.";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n24_p0_show);
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 Thank you, Miss Sarah.
        response.Text = "Thank you, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 n30
        response.NextNodeId = "n30";
        
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
        ///PROMPT_TEXT n25 0 I'll tell you what. You do a good job on my dress and don't say a word to Mother and I'll let you have that old book while we're away.\n
        prompt.Text = "I'll tell you what. You do a good job on my dress and don't say a word to Mother and I'll let you have that old book while we're away.\n";
        ///PROMPT_IGNORE_VO n25 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n25_p0_show);
        
        ///RESPONSE n25 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 0 I was meaning to return that to you [Hand her the book]
        response.Text = "I was meaning to return that to you [Hand her the book]";
        ///RESPONSE_NEXT_NODE_TYPE n25 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 0 n26
        response.NextNodeId = "n26";
        response.SetCondition(n25_r0_condition);
        response.OnSelect(n25_r0_select);
        
        ///RESPONSE n25 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 1 Thank you, Miss Sarah.
        response.Text = "Thank you, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n25 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 1 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n25
        ///NODE_START n26
        node = dialog.CreateNode("n26");
        ///NODE_NPC n26 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n26 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26 Full
        ///NODE_VISUAL_USESCRIPT n26 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n26~|||~
        ///PROMPT n26 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26 0 You little thief! What are you doing with my book?!
        prompt.Text = "You little thief! What are you doing with my book?!";
        ///PROMPT_IGNORE_VO n26 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n26_p0_show);
        
        ///RESPONSE n26 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 0 I'm sorry, Miss Sarah. I found it out in the yard and I was just bringing it back.
        response.Text = "I'm sorry, Miss Sarah. I found it out in the yard and I was just bringing it back.";
        ///RESPONSE_NEXT_NODE_TYPE n26 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 0 n28
        response.NextNodeId = "n28";
        
        ///RESPONSE n26 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 1 I'm sorry, Miss Sarah. Jonah found it and I'm just bringing it back.
        response.Text = "I'm sorry, Miss Sarah. Jonah found it and I'm just bringing it back.";
        ///RESPONSE_NEXT_NODE_TYPE n26 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 1 n27
        response.NextNodeId = "n27";
        
        ///NODE_END n26
        ///NODE_START n27
        node = dialog.CreateNode("n27");
        ///NODE_NPC n27 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n27 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n27 Full
        ///NODE_VISUAL_USESCRIPT n27 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n27~|||~
        ///PROMPT n27 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n27 0 Yes, I'm sure he just <i>found</i> it. Very well, though, you brought it back. We'll keep our little bargain. And not a word to Mother.\n
        prompt.Text = "Yes, I'm sure he just <i>found</i> it. Very well, though, you brought it back. We'll keep our little bargain. And not a word to Mother.\n";
        ///PROMPT_IGNORE_VO n27 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n27 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n27 0 Yes, Miss Sarah.
        response.Text = "Yes, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n27 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n27 0 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n27
        ///NODE_START n28
        node = dialog.CreateNode("n28");
        ///NODE_NPC n28 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n28 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n28 Full
        ///NODE_VISUAL_USESCRIPT n28 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n28~|||~
        ///PROMPT n28 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n28 0 I know it didn't grow legs and walk away! Very well, though, you brought it back. We'll keep our little bargain. And not a word to Mother.\n
        prompt.Text = "I know it didn't grow legs and walk away! Very well, though, you brought it back. We'll keep our little bargain. And not a word to Mother.\n";
        ///PROMPT_IGNORE_VO n28 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n28 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n28 0 Yes, Miss Sarah.
        response.Text = "Yes, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n28 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n28 0 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n28
        ///NODE_START n29
        node = dialog.CreateNode("n29");
        ///NODE_NPC n29 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n29 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n29 Full
        ///NODE_VISUAL_USESCRIPT n29 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n29~|||~
        ///PROMPT n29 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n29 0 Lucy you do what you're told. I don't have time for your complaining.
        prompt.Text = "Lucy you do what you're told. I don't have time for your complaining.";
        ///PROMPT_IGNORE_VO n29 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n29 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n29 0 Yes, Miss Sarah.
        response.Text = "Yes, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n29 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n29 0 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n29
        ///NODE_START n30
        node = dialog.CreateNode("n30");
        ///NODE_NPC n30 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n30 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n30 Full
        ///NODE_VISUAL_USESCRIPT n30 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n30~|||~
        ///PROMPT n30 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n30 0 Very well. Mother, Father and I will be dining on the porch. I expect the dress to be finished by the time we are done.
        prompt.Text = "Very well. Mother, Father and I will be dining on the porch. I expect the dress to be finished by the time we are done.";
        ///PROMPT_IGNORE_VO n30 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n30 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n30 1 Now hear me. Mother, Father and I will be dining on the porch. I expect the dress to be finished by the time we are done dining. \n
        prompt.Text = "Now hear me. Mother, Father and I will be dining on the porch. I expect the dress to be finished by the time we are done dining. \n";
        ///PROMPT_IGNORE_VO n30 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n30_p1_condition);
        
        ///RESPONSE n30 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 0 I'll try, Miss Sarah.
        response.Text = "I'll try, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n30 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n30 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 1 I'll start now, Miss Sarah.
        response.Text = "I'll start now, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n30 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 1 END
        response.NextNodeId = "END";
        
        ///RESPONSE n30 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 2 You have my word, Miss Sarah.
        response.Text = "You have my word, Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n30 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 2 END
        response.NextNodeId = "END";
        
        ///NODE_END n30
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n30_p1_condition
    public bool n30_p1_condition (  ) {
        ///METHOD_BODY_START n30_p1_condition
        /*//if (#sar_mood >0)*/
        return GameFlags.P1SarMood > 0;
        ///METHOD_BODY_END n30_p1_condition
    }

    ///METHOD n15b_p0_show
    public void n15b_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n15b_p0_show
        /*//			?p1_yankee_gentlemen = true*/
        DialogGameFlags.p1_yankee_gentlemen = true;
        ///METHOD_BODY_END n15b_p0_show
    }

    ///METHOD n20_p0_show
    public void n20_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n20_p0_show
        /*//addItem ("shawl")*/
        GameFlags.P1HasShawl = true;
        ///METHOD_BODY_END n20_p0_show
    }

    ///METHOD n22_p0_show
    public void n22_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n22_p0_show
        /*//set ?negotiate_sar = true*/
        GameFlags.P1NegotiateSar = true;
        ///METHOD_BODY_END n22_p0_show
    }

    ///METHOD n24_p0_show
    public void n24_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n24_p0_show
        /*//set ?negotiate_sar = true*/
        GameFlags.P1NegotiateSar = true;
        ///METHOD_BODY_END n24_p0_show
    }

    ///METHOD n25_p0_show
    public void n25_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n25_p0_show
        /*//set ?primer_promise = true*/
        GameFlags.P1PrimerPromise = true;
        ///METHOD_BODY_END n25_p0_show
    }

    ///METHOD n26_p0_show
    public void n26_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n26_p0_show
        /*//set #sar_mood = 1*/
        GameFlags.P1SarMood = 1;
        ///METHOD_BODY_END n26_p0_show
    }

    ///METHOD n14_r0_condition
    public bool n14_r0_condition (  ) {
        ///METHOD_BODY_START n14_r0_condition
        /*//if (#sar_mood = 0)*/
        return GameFlags.P1SarMood == 0;
        ///METHOD_BODY_END n14_r0_condition
    }

    ///METHOD n14_r1_condition
    public bool n14_r1_condition (  ) {
        ///METHOD_BODY_START n14_r1_condition
        /*//if (#sar_mood > 0)*/
        return GameFlags.P1SarMood > 0;
        ///METHOD_BODY_END n14_r1_condition
    }

    ///METHOD n25_r0_condition
    public bool n25_r0_condition (  ) {
        ///METHOD_BODY_START n25_r0_condition
        /*//if (hasItem ("primer"))*/
        return GameFlags.P1HasPrimer;
        ///METHOD_BODY_END n25_r0_condition
    }

    ///METHOD n02_r0_select
    public void n02_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r0_select
        /*//set #sar_mood  =1*/
        GameFlags.P1SarMood = 1;
        ///METHOD_BODY_END n02_r0_select
    }

    ///METHOD n09_r0_select
    public void n09_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n09_r0_select
        /*//set #sar_mood  =1*/
        GameFlags.P1SarMood = 1;
        ///METHOD_BODY_END n09_r0_select
    }

    ///METHOD n15a_r0_select
    public void n15a_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15a_r0_select
        /*//?has_godeys = true*/
        ///METHOD_BODY_END n15a_r0_select
    }

    ///METHOD n15b_r0_select
    public void n15b_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15b_r0_select
        /*//?has_godeys = true*/
        ///METHOD_BODY_END n15b_r0_select
    }

    ///METHOD n16_r1_select
    public void n16_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r1_select
        /*//if (#sar_mood > 0)
        //set #sar_mood -=1
        ///if*/
        if (GameFlags.P1SarMood > 0){
        	GameFlags.P1SarMood--;
        }
        ///METHOD_BODY_END n16_r1_select
    }

    ///METHOD n16a_r0_select
    public void n16a_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16a_r0_select
        /*//showNpc(true,1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n16a_r0_select
    }

    ///METHOD n21_r0_select
    public void n21_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n21_r0_select
        /*//?p1_persuade = true*/
        GameFlags.P1Persuade = true;
        ///METHOD_BODY_END n21_r0_select
    }

    ///METHOD n23_r1_select
    public void n23_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r1_select
        /*//?p1_persuade = true*/
        GameFlags.P1Persuade = true;
        ///METHOD_BODY_END n23_r1_select
    }

    ///METHOD n25_r0_select
    public void n25_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n25_r0_select
        /*//removeItem ("primer")
        //set ?primer_return = true*/
        GameFlags.P1HasPrimer = false;
        GameFlags.P1PrimerReturn = true;
        ///METHOD_BODY_END n25_r0_select
    }
}
//CLASS_END Dialog_p1_sar_001
