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
//CLASS Dialog_p4_jon_001
public class Dialog_p4_jon_001 {
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
        ///DIALOG_ID p4_jon_001
        var dialog = new Dialog();
        dialog.Id = "p4_jon_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 I'm glad that Uncle Morgan is okay. That was scary.\n
        prompt.Text = "I'm glad that Uncle Morgan is okay. That was scary.\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Yes, it was. And because of that they've decided to move to Canada.\n
        response.Text = "Yes, it was. And because of that they've decided to move to Canada.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 What are we going to do then? Who will look after us now?\n
        prompt.Text = "What are we going to do then? Who will look after us now?\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 I've decided that we'll stay here, at least for a while. I can look after you. You're almost a man now, anyway.\n
        response.Text = "I've decided that we'll stay here, at least for a while. I can look after you. You're almost a man now, anyway.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n05
        response.NextNodeId = "n05";
        response.SetCondition(n02_r0_condition);
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Jonah, I've decided I need to stay here for a while. But I want you to go with them. I need you to be safe.\n
        response.Text = "Jonah, I've decided I need to stay here for a while. But I want you to go with them. I need you to be safe.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n04
        response.NextNodeId = "n04";
        response.SetCondition(n02_r1_condition);
        
        ///RESPONSE n02 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 2 We're going to go with them. I want you to grow up safe and I want to be with you.\n
        response.Text = "We're going to go with them. I want you to grow up safe and I want to be with you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 2 n03
        response.NextNodeId = "n03";
        response.SetCondition(n02_r2_condition);
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 As long as we stay together, I'll go wherever we need to. Maybe we'll see Henry, too.\n
        prompt.Text = "As long as we stay together, I'll go wherever we need to. Maybe we'll see Henry, too.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 Yes, maybe we will. We'll be leaving a week from tomorrow.\n
        response.Text = "Yes, maybe we will. We'll be leaving a week from tomorrow.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 END
        response.NextNodeId = "END";
        response.OnSelect(n03_r0_select);
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 You can't leave me again! I go where you go.\n
        prompt.Text = "You can't leave me again! I go where you go.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 You're right, I'm sorry. Staying together is the most important thing. I'll go to Canada with you.\n
        response.Text = "You're right, I'm sorry. Staying together is the most important thing. I'll go to Canada with you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 If I let you stay with me you have to promise me something.\n
        response.Text = "If I let you stay with me you have to promise me something.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 Jonah, this is how it has to be. I promise I'll come find you soon.\n
        response.Text = "Jonah, this is how it has to be. I promise I'll come find you soon.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 As long as we stay together, I'm happy. I'll do whatever you tell me.\n
        prompt.Text = "As long as we stay together, I'm happy. I'll do whatever you tell me.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Thank you. We'll be just fine here. You can go to school, too.\n
        response.Text = "Thank you. We'll be just fine here. You can go to school, too.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 END
        response.NextNodeId = "END";
        response.OnSelect(n05_r0_select);
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 What's so important here that you can't come with me?\n
        prompt.Text = "What's so important here that you can't come with me?\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 I want to help the abolitionists. There is a lot of work to do and even more with the Wrights leaving.\n
        response.Text = "I want to help the abolitionists. There is a lot of work to do and even more with the Wrights leaving.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 I want to help Mr. Parker on the Underground Railroad.\n
        response.Text = "I want to help Mr. Parker on the Underground Railroad.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n11
        response.NextNodeId = "n11";
        
        ///RESPONSE n06 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 2 I want to finish my schooling with Miss Hatcher. \n
        response.Text = "I want to finish my schooling with Miss Hatcher. \n";
        ///RESPONSE_NEXT_NODE_TYPE n06 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 2 n10
        response.NextNodeId = "n10";
        response.OnSelect(n06_r2_select);
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 What is it?\n
        prompt.Text = "What is it?\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 If you ever see any strangers in town, you must avoid them.\n
        response.Text = "If you ever see any strangers in town, you must avoid them.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 You must always be with me or someone we trust, like Miss Hatcher.\n
        response.Text = "You must always be with me or someone we trust, like Miss Hatcher.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 I promise. Mama would be happy to know we're together.\n
        prompt.Text = "I promise. Mama would be happy to know we're together.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 Yes, she would. I'd better go help Aunt Abigail pack.\n
        response.Text = "Yes, she would. I'd better go help Aunt Abigail pack.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 END
        response.NextNodeId = "END";
        response.OnSelect(n08_r0_select);
        
        ///NODE_END n08
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 I can stay and go to school with you. That'll be safe.\n
        prompt.Text = "I can stay and go to school with you. That'll be safe.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 Maybe you're right. But if you stay, you have to promise me something.\n
        response.Text = "Maybe you're right. But if you stay, you have to promise me something.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 I'm sorry, I can't take any chances with your safety. You have to go with the Wrights.\n
        response.Text = "I'm sorry, I can't take any chances with your safety. You have to go with the Wrights.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 That's dangerous! What if you're caught? You promised you'd come find me.\n
        prompt.Text = "That's dangerous! What if you're caught? You promised you'd come find me.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 You're right. I did promise. And you're the most important thing. I'll go to Canada with you.\n
        response.Text = "You're right. I did promise. And you're the most important thing. I'll go to Canada with you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n15
        response.NextNodeId = "n15";
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 You're right. I can't make that promise. But I just have to help others escape slavery like we did.\n
        response.Text = "You're right. I can't make that promise. But I just have to help others escape slavery like we did.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n11 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 2 And I will. If things get too dangerous here, I'll leave.\n
        response.Text = "And I will. If things get too dangerous here, I'll leave.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 2 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 I can help too. I'll be very careful.\n
        prompt.Text = "I can help too. I'll be very careful.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 If you stay, you have to promise me something.\n
        response.Text = "If you stay, you have to promise me something.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 I'm sorry, I can't take any chances with your safety. You have to go with the Wrights.\n
        response.Text = "I'm sorry, I can't take any chances with your safety. You have to go with the Wrights.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 I'll go, but I don't think Mama would want us to be apart. [He walks away].\n
        prompt.Text = "I'll go, but I don't think Mama would want us to be apart. [He walks away].\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 [End]\n
        response.Text = "[End]\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 END
        response.NextNodeId = "END";
        response.OnSelect(n13_r0_select);
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 Will Mr. Parker give you a gun to protect yourself?\n
        prompt.Text = "Will Mr. Parker give you a gun to protect yourself?\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 I don't know.\n
        response.Text = "I don't know.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n17
        response.NextNodeId = "n17";
        response.SetCondition(n14_r0_condition);
        
        ///RESPONSE n14 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 1 He said he'd teach me how to shoot.\n
        response.Text = "He said he'd teach me how to shoot.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 1 n16
        response.NextNodeId = "n16";
        response.SetCondition(n14_r1_condition);
        
        ///RESPONSE n14 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 2 God will protect me. I don't need a gun.\n
        response.Text = "God will protect me. I don't need a gun.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 2 n17
        response.NextNodeId = "n17";
        
        ///RESPONSE n14 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 3 I don't want to do anything where I'd need a gun. \n
        response.Text = "I don't want to do anything where I'd need a gun. \n";
        ///RESPONSE_NEXT_NODE_TYPE n14 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 3 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 Thank you big sister. After losing Mama, I can't lose you too.\n
        prompt.Text = "Thank you big sister. After losing Mama, I can't lose you too.\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 Don't worry, you won't.\n
        response.Text = "Don't worry, you won't.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 END
        response.NextNodeId = "END";
        response.OnSelect(n15_r0_select);
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 That sounds safer. Okay, I'll go but you have to come find me soon.\n
        prompt.Text = "That sounds safer. Okay, I'll go but you have to come find me soon.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 I'll find you when my work is done.\n
        response.Text = "I'll find you when my work is done.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 END
        response.NextNodeId = "END";
        response.OnSelect(n16_r0_select);
        
        ///RESPONSE n16 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 1 I'll do my best.\n
        response.Text = "I'll do my best.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 1 END
        response.NextNodeId = "END";
        response.OnSelect(n16_r1_select);
        
        ///RESPONSE n16 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 2 I will.\n
        response.Text = "I will.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 2 END
        response.NextNodeId = "END";
        response.OnSelect(n16_r2_select);
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 Lucy, it's too dangerous. What can you do to help? Mr. Parker is a big man and he knows how to fight. \n
        prompt.Text = "Lucy, it's too dangerous. What can you do to help? Mr. Parker is a big man and he knows how to fight. \n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 You're right. Maybe I would make it even more dangerous for Mr. Parker. I should be with you in Canada.\n
        response.Text = "You're right. Maybe I would make it even more dangerous for Mr. Parker. I should be with you in Canada.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n15
        response.NextNodeId = "n15";
        
        ///RESPONSE n17 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 1 I made it here, that wasn't easy. Now I'm going to help others have that chance. I'm sorry, but that's what I need to do.\n
        response.Text = "I made it here, that wasn't easy. Now I'm going to help others have that chance. I'm sorry, but that's what I need to do.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 1 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n17
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n02_r0_condition
    public bool n02_r0_condition (  ) {
        ///METHOD_BODY_START n02_r0_condition
        /*//if (#p4_lucy_canada = 0)*/
        return true;
        ///METHOD_BODY_END n02_r0_condition
    }

    ///METHOD n02_r1_condition
    public bool n02_r1_condition (  ) {
        ///METHOD_BODY_START n02_r1_condition
        /*//if (#p4_lucy_canada = 1)*/
        return true;
        ///METHOD_BODY_END n02_r1_condition
    }

    ///METHOD n02_r2_condition
    public bool n02_r2_condition (  ) {
        ///METHOD_BODY_START n02_r2_condition
        /*//if (#p4_lucy_canada = 2)*/
        return true;
        ///METHOD_BODY_END n02_r2_condition
    }

    ///METHOD n14_r0_condition
    public bool n14_r0_condition (  ) {
        ///METHOD_BODY_START n14_r0_condition
        /*//if (?p3_parker_gun = false)*/
        return true;
        ///METHOD_BODY_END n14_r0_condition
    }

    ///METHOD n14_r1_condition
    public bool n14_r1_condition (  ) {
        ///METHOD_BODY_START n14_r1_condition
        /*//if (?p3_parker_gun = true)*/
        return true;
        ///METHOD_BODY_END n14_r1_condition
    }

    ///METHOD n03_r0_select
    public void n03_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r0_select
        /*//#p4_lucy_canada = 2*/
        ///METHOD_BODY_END n03_r0_select
    }

    ///METHOD n05_r0_select
    public void n05_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r0_select
        /*//#p4_lucy_canada = 0*/
        ///METHOD_BODY_END n05_r0_select
    }

    ///METHOD n06_r2_select
    public void n06_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r2_select
        /*//updateMessage ("This helps earn a Literacy Badge.")
        //?p4_finish_school = true*/
        ///METHOD_BODY_END n06_r2_select
    }

    ///METHOD n08_r0_select
    public void n08_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r0_select
        /*//#p4_lucy_canada = 0*/
        ///METHOD_BODY_END n08_r0_select
    }

    ///METHOD n13_r0_select
    public void n13_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n13_r0_select
        /*//#p4_lucy_canada = 1*/
        ///METHOD_BODY_END n13_r0_select
    }

    ///METHOD n15_r0_select
    public void n15_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15_r0_select
        /*//#p4_lucy_canada = 2*/
        ///METHOD_BODY_END n15_r0_select
    }

    ///METHOD n16_r0_select
    public void n16_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r0_select
        /*//#p4_lucy_canada = 1*/
        ///METHOD_BODY_END n16_r0_select
    }

    ///METHOD n16_r1_select
    public void n16_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r1_select
        /*//#p4_lucy_canada = 1*/
        ///METHOD_BODY_END n16_r1_select
    }

    ///METHOD n16_r2_select
    public void n16_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r2_select
        /*//#p4_lucy_canada = 1*/
        ///METHOD_BODY_END n16_r2_select
    }
}
//CLASS_END Dialog_p4_jon_001
