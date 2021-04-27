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
//CLASS Dialog_p3_hen_001
public class Dialog_p3_hen_001 {
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
        ///DIALOG_ID p3_hen_001
        var dialog = new Dialog();
        dialog.Id = "p3_hen_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 Lucy. You are a sight to see. I helped save you and now you helped save me.\n
        prompt.Text = "Lucy. You are a sight to see. I helped save you and now you helped save me.\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///PROMPT n01 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 1 Lucy. You are a sight to see. You made it. Your mama was right.\n
        prompt.Text = "Lucy. You are a sight to see. You made it. Your mama was right.\n";
        ///PROMPT_IGNORE_VO n01 1 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p1_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 How is Mama? Jonah?\n
        response.Text = "How is Mama? Jonah?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Henry, I thought I'd never see you again. What happened?\n
        response.Text = "Henry, I thought I'd never see you again. What happened?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 I didn't get far that night. Got myself caught. Master King punished me fierce, but I knew I'd try again.\n
        prompt.Text = "I didn't get far that night. Got myself caught. Master King punished me fierce, but I knew I'd try again.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n02 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 1 I can't remember what happened after we got separated. A patrol must have found me and returned me to Master King. He punished me fierce, but I knew I'd try again.\n
        prompt.Text = "I can't remember what happened after we got separated. A patrol must have found me and returned me to Master King. He punished me fierce, but I knew I'd try again.\n";
        ///PROMPT_IGNORE_VO n02 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n02_p1_condition);
        
        ///PROMPT n02 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 2 I was found by a patrol and dragged back to Master King. But I was determined to escape and Mr. Otis couldn't beat that out of me.\n
        prompt.Text = "I was found by a patrol and dragged back to Master King. But I was determined to escape and Mr. Otis couldn't beat that out of me.\n";
        ///PROMPT_IGNORE_VO n02 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n02_p2_condition);
        
        ///PROMPT n02 3
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 3 I was dragged back to Master King. That patrol got a nice reward for me. But I was determined to escape and Mr. Otis couldn't beat that out of me.\n
        prompt.Text = "I was dragged back to Master King. That patrol got a nice reward for me. But I was determined to escape and Mr. Otis couldn't beat that out of me.\n";
        ///PROMPT_IGNORE_VO n02 3 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n02_p3_condition);
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 How did you escape?\n
        response.Text = "How did you escape?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 A couple of weeks ago, Mr. Otis's horse got spooked and threw him off. While he was laid up, I took my chance.\n
        prompt.Text = "A couple of weeks ago, Mr. Otis's horse got spooked and threw him off. While he was laid up, I took my chance.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 Spooked? Did you have anything to do with that?\n
        response.Text = "Spooked? Did you have anything to do with that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 How did you break your leg?\n
        response.Text = "How did you break your leg?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 About a week in I fell out of a tree trying to see the way ahead. Got found by a wood cutter. A white man. Thought I was done for sure.\n
        prompt.Text = "About a week in I fell out of a tree trying to see the way ahead. Got found by a wood cutter. A white man. Thought I was done for sure.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 What happened?\n
        response.Text = "What happened?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 The strangest thing. He braced my leg and gave me a change of clothes.\n
        prompt.Text = "The strangest thing. He braced my leg and gave me a change of clothes.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 [More]\n
        response.Text = "[More]\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n05a
        response.NextNodeId = "n05a";
        
        ///NODE_END n05
        ///NODE_START n05a
        node = dialog.CreateNode("n05a");
        ///NODE_NPC n05a HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n05a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05a Full
        ///NODE_VISUAL_USESCRIPT n05a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05a~|||~
        ///PROMPT n05a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05a 0 I hid out around Dover for a week. A free Negro family brought me food. They told their preacher about me, and he found someone from Ohio to help me across.\n
        prompt.Text = "I hid out around Dover for a week. A free Negro family brought me food. They told their preacher about me, and he found someone from Ohio to help me across.\n";
        ///PROMPT_IGNORE_VO n05a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05a 0 So what happened?\n
        response.Text = "So what happened?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05a 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05a
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Your friend John Parker was waiting for me. Rowed me across in the darkest night. Then he got me hid away. And here I am.\n
        prompt.Text = "Your friend John Parker was waiting for me. Rowed me across in the darkest night. Then he got me hid away. And here I am.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 How is Mama? Jonah?\n
        response.Text = "How is Mama? Jonah?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 Sometimes that hemp break makes an awful loud sound. \n
        prompt.Text = "Sometimes that hemp break makes an awful loud sound. \n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 Especially if it isn't fixed proper. How did you break your leg?\n
        response.Text = "Especially if it isn't fixed proper. How did you break your leg?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Jonah, he's getting by. Esther's been keeping a good eye on him since... since...\n
        prompt.Text = "Jonah, he's getting by. Esther's been keeping a good eye on him since... since...\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 Since what, Henry? What happened?\n
        response.Text = "Since what, Henry? What happened?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 Your Mama... your Mama was sold. I'm sorry, Lucy. \n
        prompt.Text = "Your Mama... your Mama was sold. I'm sorry, Lucy. \n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 Where? Where is she now?\n
        response.Text = "Where? Where is she now?\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n22
        response.NextNodeId = "n22";
        response.OnSelect(n09_r0_select);
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 How can she be sold and not Jonah? They need to be together.\n
        response.Text = "How can she be sold and not Jonah? They need to be together.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n21
        response.NextNodeId = "n21";
        response.OnSelect(n09_r1_select);
        
        ///RESPONSE n09 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 2 How can that be? The auction isn't supposed to be for weeks.\n
        response.Text = "How can that be? The auction isn't supposed to be for weeks.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 2 n20
        response.NextNodeId = "n20";
        response.OnSelect(n09_r2_select);
        
        ///NODE_END n09
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Mr. Parker and the Reverend think it's too dangerous here for me. Slave catchers are crawling all over the place.\n
        prompt.Text = "Mr. Parker and the Reverend think it's too dangerous here for me. Slave catchers are crawling all over the place.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 You escaped Bercham. You can escape him or any slave catcher. You should stay here.\n
        response.Text = "You escaped Bercham. You can escape him or any slave catcher. You should stay here.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 Where will you go, then?\n
        response.Text = "Where will you go, then?\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 I have to go to Canada. Maybe I can build my own house and start a small farm. I was hoping... maybe you'd come with me.\n
        prompt.Text = "I have to go to Canada. Maybe I can build my own house and start a small farm. I was hoping... maybe you'd come with me.\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 Why Henry, I don't know what to say.\n
        response.Text = "Why Henry, I don't know what to say.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n15
        response.NextNodeId = "n15";
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 I'm sorry. That was too bold. I should go now.
        prompt.Text = "I'm sorry. That was too bold. I should go now.";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 Yes, you have a long trip. I am glad you made it, Henry. Good luck.\n
        response.Text = "Yes, you have a long trip. I am glad you made it, Henry. Good luck.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 END
        response.NextNodeId = "END";
        response.OnSelect(n15_r0_select);
        
        ///RESPONSE n15 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 1 No, Henry, it's not that. I just can't right now. I have to try and save Jonah.\n
        response.Text = "No, Henry, it's not that. I just can't right now. I have to try and save Jonah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 1 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 What do you mean? You can't go back. There are more patrols than ever.\n
        prompt.Text = "What do you mean? You can't go back. There are more patrols than ever.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 I'd try if I had to, but Mr. Parker and everyone else are going to help me find another way.\n
        response.Text = "I'd try if I had to, but Mr. Parker and everyone else are going to help me find another way.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n19
        response.NextNodeId = "n19";
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 I understand. But maybe when you get him back...\n
        prompt.Text = "I understand. But maybe when you get him back...\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 No, Henry, I think my place is here, helping our people.\n
        response.Text = "No, Henry, I think my place is here, helping our people.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 END
        response.NextNodeId = "END";
        response.OnSelect(n17_r0_select);
        
        ///RESPONSE n17 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 1 I'm not sure, Henry. I have a lot to think about.\n
        response.Text = "I'm not sure, Henry. I have a lot to think about.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 1 END
        response.NextNodeId = "END";
        
        ///RESPONSE n17 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 2 Yes, I'll think about it then. I really will. You're a good man, Henry.\n
        response.Text = "Yes, I'll think about it then. I really will. You're a good man, Henry.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 2 END
        response.NextNodeId = "END";
        response.OnSelect(n17_r2_select);
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 That's kind of you to think. But if Mr. Parker tells me I'm not safe, I have to believe him.\n
        prompt.Text = "That's kind of you to think. But if Mr. Parker tells me I'm not safe, I have to believe him.\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 Where will you go, then?\n
        response.Text = "Where will you go, then?\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 Yes, Mr. Parker is going to help me find a way, too.\n
        prompt.Text = "Yes, Mr. Parker is going to help me find a way, too.\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 What do you mean? Where are you going?\n
        response.Text = "What do you mean? Where are you going?\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n19
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 A slave trader came by the plantation looking for women slaves. He bought her right then.\n
        prompt.Text = "A slave trader came by the plantation looking for women slaves. He bought her right then.\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 If I can't help mama, I can still try to save Jonah.
        response.Text = "If I can't help mama, I can still try to save Jonah.";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n16
        response.NextNodeId = "n16";
        response.SetCondition(n20_r0_condition);
        
        ///RESPONSE n20 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 1 And he wouldn't buy Jonah, too?\n
        response.Text = "And he wouldn't buy Jonah, too?\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 1 n21
        response.NextNodeId = "n21";
        response.SetCondition(n20_r1_condition);
        response.OnSelect(n20_r1_select);
        
        ///RESPONSE n20 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 2 Where did he take her?\n
        response.Text = "Where did he take her?\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 2 n22
        response.NextNodeId = "n22";
        response.SetCondition(n20_r2_condition);
        response.OnSelect(n20_r2_select);
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 Your mama begged the trader to buy Jonah, too, but he didn't want no boy.\n
        prompt.Text = "Your mama begged the trader to buy Jonah, too, but he didn't want no boy.\n";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 I hate Master King. I have to save Jonah before he sells him too.\n
        response.Text = "I hate Master King. I have to save Jonah before he sells him too.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n16
        response.NextNodeId = "n16";
        response.OnSelect(n21_r0_select);
        
        ///RESPONSE n21 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 1 Where did he take her?\n
        response.Text = "Where did he take her?\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 1 n22
        response.NextNodeId = "n22";
        response.SetCondition(n21_r1_condition);
        response.OnSelect(n21_r1_select);
        
        ///NODE_END n21
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Full
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n22~|||~
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 I think New Orleans--at least that's what I heard Master King saying. That's where those traders sell lots of slaves.\n
        prompt.Text = "I think New Orleans--at least that's what I heard Master King saying. That's where those traders sell lots of slaves.\n";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 Where is New Orleans?\n
        response.Text = "Where is New Orleans?\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n23
        response.NextNodeId = "n23";
        
        ///RESPONSE n22 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 1 Who bought her?\n
        response.Text = "Who bought her?\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 1 n20
        response.NextNodeId = "n20";
        response.SetCondition(n22_r1_condition);
        response.OnSelect(n22_r1_select);
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 I don't know for sure. But I don't think you can get much further south.\n
        prompt.Text = "I don't know for sure. But I don't think you can get much further south.\n";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 Who bought her?\n
        response.Text = "Who bought her?\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n20
        response.NextNodeId = "n20";
        response.SetCondition(n23_r0_condition);
        response.OnSelect(n23_r0_select);
        
        ///RESPONSE n23 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 1 Oh, Mama. I can't help you no more. But I can still help Jonah.\n
        response.Text = "Oh, Mama. I can't help you no more. But I can still help Jonah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 1 n16
        response.NextNodeId = "n16";
        response.OnSelect(n23_r1_select);
        
        ///NODE_END n23
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n02_p1_condition
    public bool n02_p1_condition (  ) {
        ///METHOD_BODY_START n02_p1_condition
        /*//if (#p2_henry_code = 10)*/
        return true;
        ///METHOD_BODY_END n02_p1_condition
    }

    ///METHOD n02_p2_condition
    public bool n02_p2_condition (  ) {
        ///METHOD_BODY_START n02_p2_condition
        /*//if ((#p2_henry_code = 30) OR (#p2_henry_code = 40))*/
        return true;
        ///METHOD_BODY_END n02_p2_condition
    }

    ///METHOD n02_p3_condition
    public bool n02_p3_condition (  ) {
        ///METHOD_BODY_START n02_p3_condition
        /*//if ((#p2_henry_code = 20) OR (#p2_henry_code = 50))*/
        return true;
        ///METHOD_BODY_END n02_p3_condition
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//showNpc( true, 1)*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n01_p1_show
    public void n01_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p1_show
        /*//showNpc( true, 1)*/
        ///METHOD_BODY_END n01_p1_show
    }

    ///METHOD n20_r0_condition
    public bool n20_r0_condition (  ) {
        ///METHOD_BODY_START n20_r0_condition
        /*//if ((?p3_mama_where = true) AND (?p3_mama_jonah = true))*/
        return true;
        ///METHOD_BODY_END n20_r0_condition
    }

    ///METHOD n20_r1_condition
    public bool n20_r1_condition (  ) {
        ///METHOD_BODY_START n20_r1_condition
        /*//if (?p3_mama_jonah = false)*/
        return true;
        ///METHOD_BODY_END n20_r1_condition
    }

    ///METHOD n20_r2_condition
    public bool n20_r2_condition (  ) {
        ///METHOD_BODY_START n20_r2_condition
        /*//if (?p3_mama_where = false)*/
        return true;
        ///METHOD_BODY_END n20_r2_condition
    }

    ///METHOD n21_r1_condition
    public bool n21_r1_condition (  ) {
        ///METHOD_BODY_START n21_r1_condition
        /*//if (?p3_mama_where = false)*/
        return true;
        ///METHOD_BODY_END n21_r1_condition
    }

    ///METHOD n22_r1_condition
    public bool n22_r1_condition (  ) {
        ///METHOD_BODY_START n22_r1_condition
        /*//if (?p3_mama_time = false)*/
        return true;
        ///METHOD_BODY_END n22_r1_condition
    }

    ///METHOD n23_r0_condition
    public bool n23_r0_condition (  ) {
        ///METHOD_BODY_START n23_r0_condition
        /*//if (?p3_mama_time = false)*/
        return true;
        ///METHOD_BODY_END n23_r0_condition
    }

    ///METHOD n09_r0_select
    public void n09_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n09_r0_select
        /*//set ?p3_mama_where = true*/
        ///METHOD_BODY_END n09_r0_select
    }

    ///METHOD n09_r1_select
    public void n09_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n09_r1_select
        /*//set ?p3_mama_jonah = true*/
        ///METHOD_BODY_END n09_r1_select
    }

    ///METHOD n09_r2_select
    public void n09_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n09_r2_select
        /*//set ?p3_mama_time = true*/
        ///METHOD_BODY_END n09_r2_select
    }

    ///METHOD n15_r0_select
    public void n15_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15_r0_select
        /*//set ?p3_lucy_rejects_henry = true*/
        ///METHOD_BODY_END n15_r0_select
    }

    ///METHOD n17_r0_select
    public void n17_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n17_r0_select
        /*//set ?p3_lucy_rejects_henry = true*/
        ///METHOD_BODY_END n17_r0_select
    }

    ///METHOD n17_r2_select
    public void n17_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n17_r2_select
        /*//?p3_oh_henry = true
        //wait(2000)*/
        ///METHOD_BODY_END n17_r2_select
    }

    ///METHOD n20_r1_select
    public void n20_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n20_r1_select
        /*//set ?p3_mama_jonah=true*/
        ///METHOD_BODY_END n20_r1_select
    }

    ///METHOD n20_r2_select
    public void n20_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n20_r2_select
        /*//set ?p3_mama_where = true*/
        ///METHOD_BODY_END n20_r2_select
    }

    ///METHOD n21_r0_select
    public void n21_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n21_r0_select
        /*//set ?p3_lucy_save_jonah = true*/
        ///METHOD_BODY_END n21_r0_select
    }

    ///METHOD n21_r1_select
    public void n21_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n21_r1_select
        /*//set ?p3_mama_where = true*/
        ///METHOD_BODY_END n21_r1_select
    }

    ///METHOD n22_r1_select
    public void n22_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n22_r1_select
        /*//set ?p3_mama_time = true*/
        ///METHOD_BODY_END n22_r1_select
    }

    ///METHOD n23_r0_select
    public void n23_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r0_select
        /*//set ?p3_mama_time = true*/
        ///METHOD_BODY_END n23_r0_select
    }

    ///METHOD n23_r1_select
    public void n23_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r1_select
        /*//set ?p3_lucy_save_jonah = true*/
        ///METHOD_BODY_END n23_r1_select
    }
}
//CLASS_END Dialog_p3_hen_001
