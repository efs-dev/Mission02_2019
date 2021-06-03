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
//CLASS Dialog_p4_abi_002
public class Dialog_p4_abi_002 {
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
        ///DIALOG_ID p4_abi_002
        var dialog = new Dialog();
        dialog.Id = "p4_abi_002";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 I want to thank you for your help. I don't know if Mr. Wright would be free without everything you did.\n
        prompt.Text = "I want to thank you for your help. I don't know if Mr. Wright would be free without everything you did.\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 You're welcome, Aunt Abigail. Family comes first and I'll always be ready to help you.\n
        response.Text = "You're welcome, Aunt Abigail. Family comes first and I'll always be ready to help you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 It was Mr. Parker who figured out what needed doing. But I'm glad I was able to help.\n
        response.Text = "It was Mr. Parker who figured out what needed doing. But I'm glad I was able to help.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n04
        response.NextNodeId = "n04";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 It was Miss Hatcher who figured out what needed doing. But I'm glad I was able to help.\n
        response.Text = "It was Miss Hatcher who figured out what needed doing. But I'm glad I was able to help.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 I owe you and Uncle Morgan so much for what you've done for Jonah and me.\n
        response.Text = "I owe you and Uncle Morgan so much for what you've done for Jonah and me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 It's good that we can count on each other. But I have to tell you something, Lucy.\n
        prompt.Text = "It's good that we can count on each other. But I have to tell you something, Lucy.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 What is it?\n
        response.Text = "What is it?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 She's a smart woman. But you did real good, too. Thank you.\n
        prompt.Text = "She's a smart woman. But you did real good, too. Thank you.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 You're welcome, Aunt Abigail. \n
        response.Text = "You're welcome, Aunt Abigail. \n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 He's a wily one. But you did real good too. Thank you.\n
        prompt.Text = "He's a wily one. But you did real good too. Thank you.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 You're welcome, Aunt Abigail. \n
        response.Text = "You're welcome, Aunt Abigail. \n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 Mr. Wright and I have decided that it is too dangerous to stay here any longer. \n
        prompt.Text = "Mr. Wright and I have decided that it is too dangerous to stay here any longer. \n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 But now everyone knows you and Uncle Morgan are free. You're safe.\n
        response.Text = "But now everyone knows you and Uncle Morgan are free. You're safe.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 What do you mean? Where will you go?\n
        response.Text = "What do you mean? Where will you go?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 We're going to Canada, leaving a week from tomorrow. We'd like for you and Jonah to come with us.\n
        prompt.Text = "We're going to Canada, leaving a week from tomorrow. We'd like for you and Jonah to come with us.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Thank you for your kindness. But there are more things I'd like to to do here and I want to keep Jonah close to me.\n
        response.Text = "Thank you for your kindness. But there are more things I'd like to to do here and I want to keep Jonah close to me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 There are more things I'd like to do here, but it'd be a relief knowing Jonah is safe. Can he join you and I'll follow later?\n
        response.Text = "There are more things I'd like to do here, but it'd be a relief knowing Jonah is safe. Can he join you and I'll follow later?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n11
        response.NextNodeId = "n11";
        
        ///RESPONSE n06 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 2 Yes, it has become too dangerous. Jonah and I can't be truly free here. We will come with you.
        response.Text = "Yes, it has become too dangerous. Jonah and I can't be truly free here. We will come with you.";
        ///RESPONSE_NEXT_NODE_TYPE n06 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 2 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 Maybe for today. But we fear things will only get worse. The ###smartword|Fugitive Slave Act|FUGITIVE_SLAVE_ACT### is only the start of more trouble to come.\n
        prompt.Text = "Maybe for today. But we fear things will only get worse. The ###smartword|Fugitive Slave Act|FUGITIVE_SLAVE_ACT### is only the start of more trouble to come.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 I think you should stay and fight it. The Anti-Slavery Society needs you.\n
        response.Text = "I think you should stay and fight it. The Anti-Slavery Society needs you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 Where will you go, then?\n
        response.Text = "Where will you go, then?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Leaving doesn't mean we are giving up. When we get to Canada, we'll continue to help the cause. We'd like for you and Jonah to come with us.\n
        prompt.Text = "Leaving doesn't mean we are giving up. When we get to Canada, we'll continue to help the cause. We'd like for you and Jonah to come with us.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 There are more things I'd like to do here, but it'd be a relief knowing Jonah is safe. Can he join you and I'll follow later?\n
        response.Text = "There are more things I'd like to do here, but it'd be a relief knowing Jonah is safe. Can he join you and I'll follow later?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n11
        response.NextNodeId = "n11";
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 Yes, it has become too dangerous. Jonah and I can't be truly free here. We will come with you.\n
        response.Text = "Yes, it has become too dangerous. Jonah and I can't be truly free here. We will come with you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n08 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 2 I will pray for your safe travels, but I must stay here and fight. And I won't leave Jonah again.\n
        response.Text = "I will pray for your safe travels, but I must stay here and fight. And I won't leave Jonah again.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 2 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n08 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 3 I think that is cowardly. I will stay here and fight.\n
        response.Text = "I think that is cowardly. I will stay here and fight.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 3 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n08
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 I'm very relieved to hear that. It'll also make the work of the abolitionists easier. They won't have to worry about protecting you.\n
        prompt.Text = "I'm very relieved to hear that. It'll also make the work of the abolitionists easier. They won't have to worry about protecting you.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I think it's best for Jonah and I don't want to leave him again.\n
        response.Text = "I think it's best for Jonah and I don't want to leave him again.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 END
        response.NextNodeId = "END";
        response.OnSelect(n10_r0_select);
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 I hadn't thought of that. I was putting my friends in danger.\n
        response.Text = "I hadn't thought of that. I was putting my friends in danger.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 END
        response.NextNodeId = "END";
        response.OnSelect(n10_r1_select);
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 Yes, of course. We'll care for Jonah like he was our own. But I hope you don't wait too long. Ripley is a dangerous place.\n
        prompt.Text = "Yes, of course. We'll care for Jonah like he was our own. But I hope you don't wait too long. Ripley is a dangerous place.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 I do not know how long I will be yet. But I am happy that Jonah will be safe with you.\n
        response.Text = "I do not know how long I will be yet. But I am happy that Jonah will be safe with you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 END
        response.NextNodeId = "END";
        response.OnSelect(n11_r0_select);
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 Staying here not only keeps you in danger, but it endangers the abolitionists who must protect you. Please come with us.\n
        prompt.Text = "Staying here not only keeps you in danger, but it endangers the abolitionists who must protect you. Please come with us.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 I must stay here and fight. But maybe it is selfish of me to keep Jonah here. He should go with you.\n
        response.Text = "I must stay here and fight. But maybe it is selfish of me to keep Jonah here. He should go with you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 You're right, it is dangerous. But can we still fight slavery in Canada?\n
        response.Text = "You're right, it is dangerous. But can we still fight slavery in Canada?\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n15
        response.NextNodeId = "n15";
        
        ///RESPONSE n12 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 2 No, I must stay and fight. I promise I'll be careful.\n
        response.Text = "No, I must stay and fight. I promise I'll be careful.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 2 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n12
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 I wish you would come too, but I am glad that you trust us with protecting Jonah.\n
        prompt.Text = "I wish you would come too, but I am glad that you trust us with protecting Jonah.\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 I do. Thank you for everything.\n
        response.Text = "I do. Thank you for everything.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 END
        response.NextNodeId = "END";
        response.OnSelect(n14_r0_select);
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 Yes, we can safely raise money for the cause and tell our story to all who will listen. \n
        prompt.Text = "Yes, we can safely raise money for the cause and tell our story to all who will listen. \n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 I want to take more direct action, like Mr. Parker. But you're right about the danger. Will you take Jonah?\n
        response.Text = "I want to take more direct action, like Mr. Parker. But you're right about the danger. Will you take Jonah?\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n15 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 1 I want to take more direct action, like Mr. Parker. I'm staying here. And I can't let Jonah out of my sight again.\n
        response.Text = "I want to take more direct action, like Mr. Parker. I'm staying here. And I can't let Jonah out of my sight again.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 1 n16
        response.NextNodeId = "n16";
        
        ///RESPONSE n15 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 2 If I can help our cause and keep Jonah safe, then I will come with you.\n
        response.Text = "If I can help our cause and keep Jonah safe, then I will come with you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 2 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 I understand. Just be ###smartword|vigilant|VIGILANT###. You're brave. Please don't be foolish.\n
        prompt.Text = "I understand. Just be ###smartword|vigilant|VIGILANT###. You're brave. Please don't be foolish.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 Thank you for everything.\n
        response.Text = "Thank you for everything.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 END
        response.NextNodeId = "END";
        response.OnSelect(n16_r0_select);
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 Don't you dare call me and Morgan cowards! After what we've done for you? Keeping you safe put us in danger.\n
        prompt.Text = "Don't you dare call me and Morgan cowards! After what we've done for you? Keeping you safe put us in danger.\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n18
        response.NextNodeId = "n18";
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 And in Canada we can safely raise money for the cause and tell our story to all who will listen.\n
        prompt.Text = "And in Canada we can safely raise money for the cause and tell our story to all who will listen.\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 I am sorry, you are no cowards. I must stay. But you're right about the danger. Will you take Jonah?\n
        response.Text = "I am sorry, you are no cowards. I must stay. But you're right about the danger. Will you take Jonah?\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n18 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 1 I must take more direct action, like Mr. Parker. I'm staying here with Jonah.\n
        response.Text = "I must take more direct action, like Mr. Parker. I'm staying here with Jonah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 1 END
        response.NextNodeId = "END";
        response.OnSelect(n18_r1_select);
        
        ///RESPONSE n18 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 2 I am sorry, you are no cowards. But I must take more direct action, like Mr. Parker. I'm staying here with Jonah.\n
        response.Text = "I am sorry, you are no cowards. But I must take more direct action, like Mr. Parker. I'm staying here with Jonah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 2 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n18
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//showNpc( true, 1)*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n10_r0_select
    public void n10_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r0_select
        /*//#p4_lucy_canada = 2*/
        GameFlags.P4LucyCanada = 2;
        ///METHOD_BODY_END n10_r0_select
    }

    ///METHOD n10_r1_select
    public void n10_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r1_select
        /*//#p4_lucy_canada = 2*/
        GameFlags.P4LucyCanada = 2;
        ///METHOD_BODY_END n10_r1_select
    }

    ///METHOD n11_r0_select
    public void n11_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r0_select
        /*//#p4_lucy_canada = 1*/
        GameFlags.P4LucyCanada = 1;
        ///METHOD_BODY_END n11_r0_select
    }

    ///METHOD n14_r0_select
    public void n14_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n14_r0_select
        /*//#p4_lucy_canada = 1*/
        GameFlags.P4LucyCanada = 1;
        ///METHOD_BODY_END n14_r0_select
    }

    ///METHOD n16_r0_select
    public void n16_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r0_select
        /*//#p4_lucy_canada = 0*/
        GameFlags.P4LucyCanada = 0;
        ///METHOD_BODY_END n16_r0_select
    }

    ///METHOD n18_r1_select
    public void n18_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n18_r1_select
        /*//#p4_lucy_canada = 0*/
        GameFlags.P4LucyCanada = 0;
        ///METHOD_BODY_END n18_r1_select
    }
}
//CLASS_END Dialog_p4_abi_002
