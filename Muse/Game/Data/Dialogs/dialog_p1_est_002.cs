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
//CLASS Dialog_p1_est_002
public class Dialog_p1_est_002 {
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
        ///DIALOG_ID p1_est_002
        var dialog = new Dialog();
        dialog.Id = "p1_est_002";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 How were things with Miss Sarah?\n
        prompt.Text = "How were things with Miss Sarah?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 She is very mad at me.
        response.Text = "She is very mad at me.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n01_r0_condition);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 I took care of everything.\n
        response.Text = "I took care of everything.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n03
        response.NextNodeId = "n03";
        response.SetCondition(n01_r1_condition);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 You were right. Miss Sarah is not my friend.\n
        response.Text = "You were right. Miss Sarah is not my friend.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
        response.NextNodeId = "n02";
        response.SetCondition(n01_r2_condition);
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 I'm sorry Lucy. There's something you have to see.\n
        prompt.Text = "I'm sorry Lucy. There's something you have to see.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 What is it?
        response.Text = "What is it?";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 Good. I have something to show you.\n
        prompt.Text = "Good. I have something to show you.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What is it?
        response.Text = "What is it?";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 I saw Master King and Mister Otis talking and looking at this poster.\n
        prompt.Text = "I saw Master King and Mister Otis talking and looking at this poster.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 [Look at the poster.]
        response.Text = "[Look at the poster.]";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 It's about a slave auction. I can't read it but I think they're planning to sell some of us.\n
        prompt.Text = "It's about a slave auction. I can't read it but I think they're planning to sell some of us.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n05_p0_show);
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Do you think Miss Sarah will have me sold?
        response.Text = "Do you think Miss Sarah will have me sold?";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n21
        response.NextNodeId = "n21";
        response.SetCondition(n05_r0_condition);
        response.OnSelect(n05_r0_select);
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 Who are they going to sell?\n
        response.Text = "Who are they going to sell?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n07
        response.NextNodeId = "n07";
        response.OnSelect(n05_r1_select);
        
        ///RESPONSE n05 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 2 Why would they do that?\n
        response.Text = "Why would they do that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 2 n06
        response.NextNodeId = "n06";
        response.OnSelect(n05_r2_select);
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 I heard Master King lost money and I don't think the ###smartword|hemp|HEMP### harvest is going too good.
        prompt.Text = "I heard Master King lost money and I don't think the ###smartword|hemp|HEMP### harvest is going too good.";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Do you think Miss Sarah will have me sold?
        response.Text = "Do you think Miss Sarah will have me sold?";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n21
        response.NextNodeId = "n21";
        response.SetCondition(n06_r0_condition);
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 Who are they going to sell?\n
        response.Text = "Who are they going to sell?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 I don't know. But I think Henry might be the first to go. Mister Otis don't like him.\n
        prompt.Text = "I don't know. But I think Henry might be the first to go. Mister Otis don't like him.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 Should we warn Henry?\n
        response.Text = "Should we warn Henry?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n09
        response.NextNodeId = "n09";
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 Henry said this morning he's thinking about running.\n
        response.Text = "Henry said this morning he's thinking about running.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Yes, that man's going to run. Good time with the Master away. I hope he makes it this time.\n
        prompt.Text = "Yes, that man's going to run. Good time with the Master away. I hope he makes it this time.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 My mama doesn't think it's a good idea.\n
        response.Text = "My mama doesn't think it's a good idea.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n17
        response.NextNodeId = "n17";
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 I hope so too.\n
        response.Text = "I hope so too.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 I think Henry already knows. That man's going to run. Good time with the Master away. I hope he makes it this time.\n
        prompt.Text = "I think Henry already knows. That man's going to run. Good time with the Master away. I hope he makes it this time.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 My mama doesn't think it's a good idea.\n
        response.Text = "My mama doesn't think it's a good idea.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n17
        response.NextNodeId = "n17";
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 I hope so too.\n
        response.Text = "I hope so too.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 I was hoping you could give Henry something for me.\n
        prompt.Text = "I was hoping you could give Henry something for me.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I don't want to get in trouble. I'd better not.\n
        response.Text = "I don't want to get in trouble. I'd better not.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 What is it?\n
        response.Text = "What is it?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 Well, first I gathered some comfrey root for him. Should help with the pain.\n
        prompt.Text = "Well, first I gathered some comfrey root for him. Should help with the pain.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 Thank you. My mama asked me to pick some comfrey root, but I haven't had time yet.\n
        response.Text = "Thank you. My mama asked me to pick some comfrey root, but I haven't had time yet.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n13
        response.NextNodeId = "n13";
        response.SetCondition(n11_r0_condition);
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 Thank you. My mama asked me to pick some comfrey root, but Mr. Otis stopped me.\n
        response.Text = "Thank you. My mama asked me to pick some comfrey root, but Mr. Otis stopped me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n13
        response.NextNodeId = "n13";
        response.SetCondition(n11_r1_condition);
        
        ///RESPONSE n11 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 2 I already helped my mama get some this morning.\n
        response.Text = "I already helped my mama get some this morning.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 2 n12
        response.NextNodeId = "n12";
        response.SetCondition(n11_r2_condition);
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 That's good, but I'm sure he could use some more in the days ahead.\n
        prompt.Text = "That's good, but I'm sure he could use some more in the days ahead.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 Yes, I see what you mean. I'll give it to him.\n
        response.Text = "Yes, I see what you mean. I'll give it to him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n15
        response.NextNodeId = "n15";
        response.OnSelect(n12_r0_select);
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Good, there is plenty here for now and for later. Enough even to help him while he's away.\n
        prompt.Text = "Good, there is plenty here for now and for later. Enough even to help him while he's away.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 Yes, I see what you mean. I'll give them to him.\n
        response.Text = "Yes, I see what you mean. I'll give them to him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n15
        response.NextNodeId = "n15";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 I see. Just remember that all we got is each other.\n
        prompt.Text = "I see. Just remember that all we got is each other.\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 I'm sorry Esther. [Leave]\n
        response.Text = "I'm sorry Esther. [Leave]\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 That's good. Even more important, I need you to tell him something.\n
        prompt.Text = "That's good. Even more important, I need you to tell him something.\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 What is it?\n
        response.Text = "What is it?\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 I've heard there's a Negro church in Lexington. It's in an old stable near the market. The church folks help people who run off.\n
        prompt.Text = "I've heard there's a Negro church in Lexington. It's in an old stable near the market. The church folks help people who run off.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n16_p0_show);
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 Okay, I'll tell him. \n
        response.Text = "Okay, I'll tell him. \n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n16 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 1 Why can't you tell Henry?\n
        response.Text = "Why can't you tell Henry?\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 1 n18
        response.NextNodeId = "n18";
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 Nell is just worried. She knows he's going to run. But if he gets caught again, well, I don't want to think about that. Henry's like another son to her.\n
        prompt.Text = "Nell is just worried. She knows he's going to run. But if he gets caught again, well, I don't want to think about that. Henry's like another son to her.\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 Mama does like to worry.\n
        response.Text = "Mama does like to worry.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 Master King hired me out to the Dawson farm while he's at the wedding. Someone is coming to take me over there real soon.\n
        prompt.Text = "Master King hired me out to the Dawson farm while he's at the wedding. Someone is coming to take me over there real soon.\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n18_p0_show);
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 I understand. I'll be sure to tell him.\n
        response.Text = "I understand. I'll be sure to tell him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n18 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 1 Why are they doing that?
        response.Text = "Why are they doing that?";
        ///RESPONSE_NEXT_NODE_TYPE n18 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 1 n19
        response.NextNodeId = "n19";
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 Master wants to make money off of us any way he can.\n
        prompt.Text = "Master wants to make money off of us any way he can.\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 Yes he does. I'll tell Henry what you said.\n
        response.Text = "Yes he does. I'll tell Henry what you said.\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 n20
        response.NextNodeId = "n20";
        
        ///NODE_END n19
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 You take care of yourself. You are something special.\n
        prompt.Text = "You take care of yourself. You are something special.\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 Thank you, Esther.\n
        response.Text = "Thank you, Esther.\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 END
        response.NextNodeId = "END";
        response.SetCondition(n20_r0_condition);
        
        ///RESPONSE n20 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 1 Thank you, Esther. See you when you get back from the Dawson's.
        response.Text = "Thank you, Esther. See you when you get back from the Dawson's.";
        ///RESPONSE_NEXT_NODE_TYPE n20 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 1 END
        response.NextNodeId = "END";
        response.SetCondition(n20_r1_condition);
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 EST
        node.Npc = "EST";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 She'll forget she's mad by the time she comes back. But Henry's got trouble.
        prompt.Text = "She'll forget she's mad by the time she comes back. But Henry's got trouble.";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 Should we warn Henry?\n
        response.Text = "Should we warn Henry?\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n09
        response.NextNodeId = "n09";
        
        ///RESPONSE n21 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 1 Henry said this morning he's thinking about running.\n
        response.Text = "Henry said this morning he's thinking about running.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 1 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n21
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n05_p0_show
    public void n05_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n05_p0_show
        /*//showNpc(false,1)
        //?has_auction_poster = true
        //setLayer("fg", "gfx/stills/auction_poster/auction_poster.swf")
        //setFGXY("100|0")
        ////hint("Words you can't yet read appear blurry.")
        //overlayPopup("literacy_message")
        //if( ?first_doc)
        //   ?first_doc = false
        ///if*/
        ///METHOD_BODY_END n05_p0_show
    }

    ///METHOD n16_p0_show
    public void n16_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n16_p0_show
        /*//set ?know_lexington = true*/
        ///METHOD_BODY_END n16_p0_show
    }

    ///METHOD n18_p0_show
    public void n18_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n18_p0_show
        /*//set ?know_est_dawsons = true*/
        ///METHOD_BODY_END n18_p0_show
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if (?sar_mad)*/
        return true;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if (?sar_mad = false)*/
        return true;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD n01_r2_condition
    public bool n01_r2_condition (  ) {
        ///METHOD_BODY_START n01_r2_condition
        /*//if (?cook_warning)*/
        return true;
        ///METHOD_BODY_END n01_r2_condition
    }

    ///METHOD n05_r0_condition
    public bool n05_r0_condition (  ) {
        ///METHOD_BODY_START n05_r0_condition
        /*//if (?sar_mad)*/
        return true;
        ///METHOD_BODY_END n05_r0_condition
    }

    ///METHOD n06_r0_condition
    public bool n06_r0_condition (  ) {
        ///METHOD_BODY_START n06_r0_condition
        /*//if (?sar_mad)*/
        return true;
        ///METHOD_BODY_END n06_r0_condition
    }

    ///METHOD n11_r0_condition
    public bool n11_r0_condition (  ) {
        ///METHOD_BODY_START n11_r0_condition
        /*//if (?comfrey_complete = false AND (?comfrey_tried = false))*/
        return true;
        ///METHOD_BODY_END n11_r0_condition
    }

    ///METHOD n11_r1_condition
    public bool n11_r1_condition (  ) {
        ///METHOD_BODY_START n11_r1_condition
        /*//if (?comfrey_complete = false AND (?comfrey_tried))*/
        return true;
        ///METHOD_BODY_END n11_r1_condition
    }

    ///METHOD n11_r2_condition
    public bool n11_r2_condition (  ) {
        ///METHOD_BODY_START n11_r2_condition
        /*//if (?comfrey_complete)*/
        return true;
        ///METHOD_BODY_END n11_r2_condition
    }

    ///METHOD n20_r0_condition
    public bool n20_r0_condition (  ) {
        ///METHOD_BODY_START n20_r0_condition
        /*//if (?know_est_dawsons = false)*/
        return true;
        ///METHOD_BODY_END n20_r0_condition
    }

    ///METHOD n20_r1_condition
    public bool n20_r1_condition (  ) {
        ///METHOD_BODY_START n20_r1_condition
        /*//if (?know_est_dawsons)*/
        return true;
        ///METHOD_BODY_END n20_r1_condition
    }

    ///METHOD n05_r0_select
    public void n05_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r0_select
        /*//showNpc(true,1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n05_r0_select
    }

    ///METHOD n05_r1_select
    public void n05_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r1_select
        /*//showNpc(true,1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n05_r1_select
    }

    ///METHOD n05_r2_select
    public void n05_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r2_select
        /*//showNpc(true,1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n05_r2_select
    }

    ///METHOD n12_r0_select
    public void n12_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n12_r0_select
        /*//?p1_est_comfrey = true
        //addItem("COMFREY2")*/
        ///METHOD_BODY_END n12_r0_select
    }
}
//CLASS_END Dialog_p1_est_002
