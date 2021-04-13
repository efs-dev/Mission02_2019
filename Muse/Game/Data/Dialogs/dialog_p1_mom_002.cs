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
//CLASS Dialog_p1_mom_002
public class Dialog_p1_mom_002 {
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
        ///DIALOG_ID p1_mom_002
        var dialog = new Dialog();
        dialog.Id = "p1_mom_002";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 Lucy, you're shaking. What did Mr. Otis say?\n
        prompt.Text = "Lucy, you're shaking. What did Mr. Otis say?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Oh Mama, he's blaming me and Henry for the fire!\n
        response.Text = "Oh Mama, he's blaming me and Henry for the fire!\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Mercy, child...
        prompt.Text = "Mercy, child...";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 And he said he'd get Master King to sell us down south.\n
        response.Text = "And he said he'd get Master King to sell us down south.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 I can't lie, it gives me the shivers to hear that. It's trouble if Mr. Otis is set against you.\n
        prompt.Text = "I can't lie, it gives me the shivers to hear that. It's trouble if Mr. Otis is set against you.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 But I didn't do it Mama. Why is Mr. Otis blaming me?\n
        response.Text = "But I didn't do it Mama. Why is Mr. Otis blaming me?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 Mama, I think I got to run.\n
        response.Text = "Mama, I think I got to run.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n06
        response.NextNodeId = "n06";
        response.SetCondition(n03_r2_condition);
        
        ///RESPONSE n03 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 2 Mama, me and Henry are going to run tonight.\n
        response.Text = "Mama, me and Henry are going to run tonight.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 2 n06
        response.NextNodeId = "n06";
        response.SetCondition(n03_r1_condition);
        
        ///RESPONSE n03 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 3 What should I do Mama?\n
        response.Text = "What should I do Mama?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 3 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 Lucy dear, it breaks my heart, but you got to run. It would be the end of me if I knew you was down south and no one caring about you.\n
        prompt.Text = "Lucy dear, it breaks my heart, but you got to run. It would be the end of me if I knew you was down south and no one caring about you.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Yes Mama. But don't cry, I'll make it.\n
        response.Text = "Yes Mama. But don't cry, I'll make it.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n07
        response.NextNodeId = "n07";
        response.SetCondition(n04_r3_condition);
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 Oh Mama, don't cry. Henry is going to run too and we'll go together.\n
        response.Text = "Oh Mama, don't cry. Henry is going to run too and we'll go together.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n07
        response.NextNodeId = "n07";
        response.SetCondition(n04_r2_condition);
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 I don't want to leave you! You and Jonah can come with me.\n
        response.Text = "I don't want to leave you! You and Jonah can come with me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n11
        response.NextNodeId = "n11";
        
        ///RESPONSE n04 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 3 But you just told Henry this morning it was too dangerous.\n
        response.Text = "But you just told Henry this morning it was too dangerous.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 3 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 Things are different now. There was no talk of being sold this morning. I can't see that happen. I can't.\n
        prompt.Text = "Things are different now. There was no talk of being sold this morning. I can't see that happen. I can't.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Oh Mama, don't cry. I'll make it somehow.\n
        response.Text = "Oh Mama, don't cry. I'll make it somehow.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        response.SetCondition(n05_r2_condition);
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 Oh Mama, don't cry. Henry is going to run too and we'll go together.\n
        response.Text = "Oh Mama, don't cry. Henry is going to run too and we'll go together.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n07
        response.NextNodeId = "n07";
        response.SetCondition(n05_r1_condition);
        
        ///RESPONSE n05 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 2 I don't want to leave you! You and Jonah can come with me.\n
        response.Text = "I don't want to leave you! You and Jonah can come with me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 2 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Lucy dear, it breaks my heart, but, yes, you got to run. It would be the end of me if I knew you was down south picking cotton and no one caring about you.\n
        prompt.Text = "Lucy dear, it breaks my heart, but, yes, you got to run. It would be the end of me if I knew you was down south picking cotton and no one caring about you.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 I better get started. I'm going to miss you and Jonah.\n
        response.Text = "I better get started. I'm going to miss you and Jonah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 Mama, I'm scared.\n
        response.Text = "Mama, I'm scared.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n06 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 2 I don't want to leave you! You and Jonah can come with me.\n
        response.Text = "I don't want to leave you! You and Jonah can come with me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 2 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 I'm not going to let you go without trying to help you.\n
        prompt.Text = "I'm not going to let you go without trying to help you.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 What do you mean? \n
        response.Text = "What do you mean? \n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 I've got something to give you. Here is my blanket. Your grandmother made it. Help keep you warm.\n
        prompt.Text = "I've got something to give you. Here is my blanket. Your grandmother made it. Help keep you warm.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n08_p0_show);
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 Thank you, Mama.
        response.Text = "Thank you, Mama.";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n10b
        response.NextNodeId = "n10b";
        response.SetCondition(n08_r2_condition);
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 Thank you, Mama.
        response.Text = "Thank you, Mama.";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n08_r1_condition);
        
        ///RESPONSE n08 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 2 But what about you? I don't want you to be cold.\n
        response.Text = "But what about you? I don't want you to be cold.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 2 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 You always so thoughtful Lucy. But I'll be safe here, at least I got a roof over my head. Please take it.
        prompt.Text = "You always so thoughtful Lucy. But I'll be safe here, at least I got a roof over my head. Please take it.";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 It's a leaky roof, Mama. But thank you.
        response.Text = "It's a leaky roof, Mama. But thank you.";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n10b
        response.NextNodeId = "n10b";
        response.SetCondition(n09_r1_condition);
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 It's a leaky roof, Mama. But thank you.\n
        response.Text = "It's a leaky roof, Mama. But thank you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n09_r0_condition);
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 This is my pass to go visit your Papa. As long as you're not too far from the Preston ###smartword|plantation|PLANTATION###, folks shouldn't get too suspicious.\n
        prompt.Text = "This is my pass to go visit your Papa. As long as you're not too far from the Preston ###smartword|plantation|PLANTATION###, folks shouldn't get too suspicious.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n10_p0_show);
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 Esther told me there was a church in Lexington that'd help me. What do you think?\n
        response.Text = "Esther told me there was a church in Lexington that'd help me. What do you think?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n16
        response.NextNodeId = "n16";
        response.SetCondition(n10_r3_condition);
        response.OnSelect(n10_r3_select);
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 Thank you, Mama. I better get started.
        response.Text = "Thank you, Mama. I better get started.";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n14
        response.NextNodeId = "n14";
        response.OnSelect(n10_r2_select);
        
        ///RESPONSE n10 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 2 But how are you going to see Papa?
        response.Text = "But how are you going to see Papa?";
        ///RESPONSE_NEXT_NODE_TYPE n10 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 2 n13
        response.NextNodeId = "n13";
        response.OnSelect(n10_r1_select);
        
        ///RESPONSE n10 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 3 But what about Henry?\n
        response.Text = "But what about Henry?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 3 n12
        response.NextNodeId = "n12";
        response.OnSelect(n10_r0_select);
        
        ///NODE_END n10
        ///NODE_START n10b
        node = dialog.CreateNode("n10b");
        ///NODE_NPC n10b MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n10b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10b Full
        ///NODE_VISUAL_USESCRIPT n10b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10b~|||~
        ///PROMPT n10b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10b 0 I'd have given you my pass to see your Papa, but Mr. Otis took it from me. He didn't say why.\n
        prompt.Text = "I'd have given you my pass to see your Papa, but Mr. Otis took it from me. He didn't say why.\n";
        ///PROMPT_IGNORE_VO n10b 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10b 0 It's my fault. Mr. Otis got mad at me and said none of us would see Papa.\n
        response.Text = "It's my fault. Mr. Otis got mad at me and said none of us would see Papa.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10b 0 n19
        response.NextNodeId = "n19";
        
        ///NODE_END n10b
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 That'd be too dangerous. I'd slow you down and them patrols would be suspicious of so many Negroes together.\n
        prompt.Text = "That'd be too dangerous. I'd slow you down and them patrols would be suspicious of so many Negroes together.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 Okay Mama, I understand.
        response.Text = "Okay Mama, I understand.";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 You won't slow us down! And we can avoid the roads and patrols like Henry says.\n
        response.Text = "You won't slow us down! And we can avoid the roads and patrols like Henry says.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n15
        response.NextNodeId = "n15";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 I can't read it, but I don't think it says anything about no man. But a lot of them patrols can't read neither.\n
        prompt.Text = "I can't read it, but I don't think it says anything about no man. But a lot of them patrols can't read neither.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 Esther told me there was a church in Lexington that'd help me. What do you think?\n
        response.Text = "Esther told me there was a church in Lexington that'd help me. What do you think?\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n16
        response.NextNodeId = "n16";
        response.SetCondition(n12_r1_condition);
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 I'll be careful. Thank you Mama. I better get started.\n
        response.Text = "I'll be careful. Thank you Mama. I better get started.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 When they find you and Henry gone, no one going to be leaving here for a spell. I'll get another pass after a while.\n
        prompt.Text = "When they find you and Henry gone, no one going to be leaving here for a spell. I'll get another pass after a while.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 Esther told me there was a church in Lexington that'd help me. What do you think?\n
        response.Text = "Esther told me there was a church in Lexington that'd help me. What do you think?\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n16
        response.NextNodeId = "n16";
        response.SetCondition(n13_r1_condition);
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 I'm sorry Mama. I don't want this to hurt you.\n
        response.Text = "I'm sorry Mama. I don't want this to hurt you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 Child, nothing is more important to me than you right now. You just find your way across that river.\n
        prompt.Text = "Child, nothing is more important to me than you right now. You just find your way across that river.\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 I will Mama. Goodbye.\n
        response.Text = "I will Mama. Goodbye.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n20
        response.NextNodeId = "n20";
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 Even if that was true, I don't want to leave your Papa behind. Family got to stick together when it can.\n
        prompt.Text = "Even if that was true, I don't want to leave your Papa behind. Family got to stick together when it can.\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 Okay Mama, I understand.\n
        response.Text = "Okay Mama, I understand.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 Lexington's the wrong way from the river, but Esther knows lots of things. I know your Papa will help you, but maybe they'll look for you there.\n
        prompt.Text = "Lexington's the wrong way from the river, but Esther knows lots of things. I know your Papa will help you, but maybe they'll look for you there.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 So what should I do Mama?\n
        response.Text = "So what should I do Mama?\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 I can't tell you that. But you make a plan and the Lord will guide you safely.\n
        prompt.Text = "I can't tell you that. But you make a plan and the Lord will guide you safely.\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 I'm scared Mama but I better get started.\n
        response.Text = "I'm scared Mama but I better get started.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 Mr. Otis blaming you so Master King can't blame him. He'll punish you so he don't lose his job.\n
        prompt.Text = "Mr. Otis blaming you so Master King can't blame him. He'll punish you so he don't lose his job.\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 Mama, I think I got to run before he punishes me.\n
        response.Text = "Mama, I think I got to run before he punishes me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n06
        response.NextNodeId = "n06";
        response.SetCondition(n18_r2_condition);
        
        ///RESPONSE n18 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 1 Mama, me and Henry are going to run tonight before he can punish us.\n
        response.Text = "Mama, me and Henry are going to run tonight before he can punish us.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 1 n06
        response.NextNodeId = "n06";
        response.SetCondition(n18_r1_condition);
        
        ///RESPONSE n18 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 2 What should I do Mama?
        response.Text = "What should I do Mama?";
        ///RESPONSE_NEXT_NODE_TYPE n18 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 2 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 That's alright. A pass might have helped you fool patrols. But you just be extra careful now.\n
        prompt.Text = "That's alright. A pass might have helped you fool patrols. But you just be extra careful now.\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 I will Mama. I better get started.\n
        response.Text = "I will Mama. I better get started.\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n19
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 Goodbye, Lucy.
        prompt.Text = "Goodbye, Lucy.";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 [Leave]
        response.Text = "[Leave]";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n20
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n08_p0_show
    public void n08_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n08_p0_show
        /*//addItem("blanket")*/
        ///METHOD_BODY_END n08_p0_show
    }

    ///METHOD n10_p0_show
    public void n10_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n10_p0_show
        /*//showNpc(false,1)
        //?has_pass = true
        //setLayer("fg", "gfx/stills/slave_pass/slave_pass.swf")
        //setFGXY("5|10")
        //addItem("preston_pass")*/
        ///METHOD_BODY_END n10_p0_show
    }

    ///METHOD n03_r2_condition
    public bool n03_r2_condition (  ) {
        ///METHOD_BODY_START n03_r2_condition
        /*//if ($escape_type = "alone")*/
        return true;
        ///METHOD_BODY_END n03_r2_condition
    }

    ///METHOD n03_r1_condition
    public bool n03_r1_condition (  ) {
        ///METHOD_BODY_START n03_r1_condition
        /*//if ($escape_type = "henry")*/
        return true;
        ///METHOD_BODY_END n03_r1_condition
    }

    ///METHOD n04_r3_condition
    public bool n04_r3_condition (  ) {
        ///METHOD_BODY_START n04_r3_condition
        /*//if ($escape_type = "alone")*/
        return true;
        ///METHOD_BODY_END n04_r3_condition
    }

    ///METHOD n04_r2_condition
    public bool n04_r2_condition (  ) {
        ///METHOD_BODY_START n04_r2_condition
        /*//if ($escape_type = "henry")*/
        return true;
        ///METHOD_BODY_END n04_r2_condition
    }

    ///METHOD n05_r2_condition
    public bool n05_r2_condition (  ) {
        ///METHOD_BODY_START n05_r2_condition
        /*//if ($escape_type = "alone")*/
        return true;
        ///METHOD_BODY_END n05_r2_condition
    }

    ///METHOD n05_r1_condition
    public bool n05_r1_condition (  ) {
        ///METHOD_BODY_START n05_r1_condition
        /*//if ($escape_type = "henry")*/
        return true;
        ///METHOD_BODY_END n05_r1_condition
    }

    ///METHOD n08_r2_condition
    public bool n08_r2_condition (  ) {
        ///METHOD_BODY_START n08_r2_condition
        /*//if(?pass_taken)*/
        return true;
        ///METHOD_BODY_END n08_r2_condition
    }

    ///METHOD n08_r1_condition
    public bool n08_r1_condition (  ) {
        ///METHOD_BODY_START n08_r1_condition
        /*//if(?pass_taken=false)*/
        return true;
        ///METHOD_BODY_END n08_r1_condition
    }

    ///METHOD n09_r1_condition
    public bool n09_r1_condition (  ) {
        ///METHOD_BODY_START n09_r1_condition
        /*//if(?pass_taken)*/
        return true;
        ///METHOD_BODY_END n09_r1_condition
    }

    ///METHOD n09_r0_condition
    public bool n09_r0_condition (  ) {
        ///METHOD_BODY_START n09_r0_condition
        /*//if(?pass_taken=false)*/
        return true;
        ///METHOD_BODY_END n09_r0_condition
    }

    ///METHOD n10_r3_condition
    public bool n10_r3_condition (  ) {
        ///METHOD_BODY_START n10_r3_condition
        /*//if (?know_lexington)*/
        return true;
        ///METHOD_BODY_END n10_r3_condition
    }

    ///METHOD n12_r1_condition
    public bool n12_r1_condition (  ) {
        ///METHOD_BODY_START n12_r1_condition
        /*//if (?know_lexington)*/
        return true;
        ///METHOD_BODY_END n12_r1_condition
    }

    ///METHOD n13_r1_condition
    public bool n13_r1_condition (  ) {
        ///METHOD_BODY_START n13_r1_condition
        /*//if (?know_lexington)*/
        return true;
        ///METHOD_BODY_END n13_r1_condition
    }

    ///METHOD n18_r2_condition
    public bool n18_r2_condition (  ) {
        ///METHOD_BODY_START n18_r2_condition
        /*//if ($escape_type = "alone")*/
        return true;
        ///METHOD_BODY_END n18_r2_condition
    }

    ///METHOD n18_r1_condition
    public bool n18_r1_condition (  ) {
        ///METHOD_BODY_START n18_r1_condition
        /*//if ($escape_type = "henry")*/
        return true;
        ///METHOD_BODY_END n18_r1_condition
    }

    ///METHOD n10_r3_select
    public void n10_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r3_select
        /*//showNpc(true,1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n10_r3_select
    }

    ///METHOD n10_r2_select
    public void n10_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r2_select
        /*//showNpc(true,1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n10_r2_select
    }

    ///METHOD n10_r1_select
    public void n10_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r1_select
        /*//showNpc(true,1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n10_r1_select
    }

    ///METHOD n10_r0_select
    public void n10_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r0_select
        /*//showNpc(true,1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n10_r0_select
    }
}
//CLASS_END Dialog_p1_mom_002
