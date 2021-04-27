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
//CLASS Dialog_p3_jon_001
public class Dialog_p3_jon_001 {
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
        ///DIALOG_ID p3_jon_001
        var dialog = new Dialog();
        dialog.Id = "p3_jon_001";
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
        ///PROMPT_TEXT n01 0 Lucy!\n
        prompt.Text = "Lucy!\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Little brother. I knew I'd see you again.\n
        response.Text = "Little brother. I knew I'd see you again.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n04
        response.NextNodeId = "n04";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Jonah! Are you hurt? Are you all right?\n
        response.Text = "Jonah! Are you hurt? Are you all right?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Jonah! Thank the Lord! You made it!\n
        response.Text = "Jonah! Thank the Lord! You made it!\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
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
        ///PROMPT_TEXT n02 0 I just did what the preacher told me. I was scared, but I knew if you made it, then I could, too.\n
        prompt.Text = "I just did what the preacher told me. I was scared, but I knew if you made it, then I could, too.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 I'm proud of you. I only wish that Mama could be here, too.\n
        response.Text = "I'm proud of you. I only wish that Mama could be here, too.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n05
        response.NextNodeId = "n05";
        
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
        ///PROMPT_TEXT n03 0 I'm okay. Just hungry and tired... But I miss Mama. What are we going to do, Lucy?\n
        prompt.Text = "I'm okay. Just hungry and tired... But I miss Mama. What are we going to do, Lucy?\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 I don't know yet. I have to talk to Aunt Abigail.\n
        response.Text = "I don't know yet. I have to talk to Aunt Abigail.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n11
        response.NextNodeId = "n11";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 I'm going to take care of you. \n
        response.Text = "I'm going to take care of you. \n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n10
        response.NextNodeId = "n10";
        
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
        ///PROMPT_TEXT n04 0 Me, too. And I had a dream last night that Mama came back. When do you think we'll see her again?\n
        prompt.Text = "Me, too. And I had a dream last night that Mama came back. When do you think we'll see her again?\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 I don't know. All we can do is hope and pray now.\n
        response.Text = "I don't know. All we can do is hope and pray now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n23
        response.NextNodeId = "n23";
        response.OnSelect(n04_r0_select);
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 I don't think we'll ever see her again. I'm sorry.\n
        response.Text = "I don't think we'll ever see her again. I'm sorry.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n22
        response.NextNodeId = "n22";
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 [Lie] Soon, Jonah. Let me take you home and we'll get some food.\n
        response.Text = "[Lie] Soon, Jonah. Let me take you home and we'll get some food.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n21
        response.NextNodeId = "n21";
        
        ///RESPONSE n04 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 3 Maybe when slavery is ended. People here are trying to do that.\n
        response.Text = "Maybe when slavery is ended. People here are trying to do that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 3 n20
        response.NextNodeId = "n20";
        
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
        ///PROMPT_TEXT n05 0 Me, too. I had a dream last night that she came back. When do you think we'll see her again?\n
        prompt.Text = "Me, too. I had a dream last night that she came back. When do you think we'll see her again?\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 I don't know. All we can do is hope and pray now.\n
        response.Text = "I don't know. All we can do is hope and pray now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n23
        response.NextNodeId = "n23";
        response.OnSelect(n05_r0_select);
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 I don't think we'll ever see her again. I'm sorry.\n
        response.Text = "I don't think we'll ever see her again. I'm sorry.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n22
        response.NextNodeId = "n22";
        
        ///RESPONSE n05 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 2 [Lie] Soon Jonah. Let me take you home and we'll get some food.\n
        response.Text = "[Lie] Soon Jonah. Let me take you home and we'll get some food.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 2 n21
        response.NextNodeId = "n21";
        
        ///RESPONSE n05 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 3 If slavery ever ends, maybe we'll find her.\n
        response.Text = "If slavery ever ends, maybe we'll find her.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 3 n20
        response.NextNodeId = "n20";
        
        ///NODE_END n05
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
        ///PROMPT_TEXT n10 0 I know you will. But when do you think we'll see Mama again?\n
        prompt.Text = "I know you will. But when do you think we'll see Mama again?\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I don't know. All we can do is hope and pray now.\n
        response.Text = "I don't know. All we can do is hope and pray now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n23
        response.NextNodeId = "n23";
        response.OnSelect(n10_r0_select);
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 I don't think we'll ever see her again. I'm sorry.\n
        response.Text = "I don't think we'll ever see her again. I'm sorry.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n22
        response.NextNodeId = "n22";
        
        ///RESPONSE n10 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 2 [Lie] Soon, Jonah. Let me take you home and we'll get some food.\n
        response.Text = "[Lie] Soon, Jonah. Let me take you home and we'll get some food.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 2 n21
        response.NextNodeId = "n21";
        
        ///RESPONSE n10 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 3 If slavery ever ends maybe we'll find her.\n
        response.Text = "If slavery ever ends maybe we'll find her.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 3 n20
        response.NextNodeId = "n20";
        
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
        ///PROMPT_TEXT n11 0 Who is Aunt Abigail?\n
        prompt.Text = "Who is Aunt Abigail?\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 She and Mr. Wright took me in after I escaped. We just pretend we are real family so people don't know where I came from.\n
        response.Text = "She and Mr. Wright took me in after I escaped. We just pretend we are real family so people don't know where I came from.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n12
        response.NextNodeId = "n12";
        
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
        ///PROMPT_TEXT n12 0 Will I live there with you now?\n
        prompt.Text = "Will I live there with you now?\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 For now, at least. But we both won't be able to stay there forever. It'll be too dangerous.\n
        response.Text = "For now, at least. But we both won't be able to stay there forever. It'll be too dangerous.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n13
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
        ///PROMPT_TEXT n13 0 But what about Mama? When will we see her again?\n
        prompt.Text = "But what about Mama? When will we see her again?\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 I don't know. All we can do is hope and pray now.\n
        response.Text = "I don't know. All we can do is hope and pray now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n23
        response.NextNodeId = "n23";
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 I don't think we'll ever see her again. I'm sorry.\n
        response.Text = "I don't think we'll ever see her again. I'm sorry.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n22
        response.NextNodeId = "n22";
        
        ///RESPONSE n13 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 2 [Lie] Soon Jonah. Let me take you home and we'll get some food.\n
        response.Text = "[Lie] Soon Jonah. Let me take you home and we'll get some food.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 2 n21
        response.NextNodeId = "n21";
        
        ///RESPONSE n13 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 3 If slavery ever ends maybe we'll find her.\n
        response.Text = "If slavery ever ends maybe we'll find her.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 3 n20
        response.NextNodeId = "n20";
        
        ///NODE_END n13
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 Is that possible... ending slavery? If it is then I think we should help Mr. Parker and the others.\n
        prompt.Text = "Is that possible... ending slavery? If it is then I think we should help Mr. Parker and the others.\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 Mama would want us to be safe. That's what we'll have to think about first. We'll talk more in the morning.\n
        response.Text = "Mama would want us to be safe. That's what we'll have to think about first. We'll talk more in the morning.\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n20 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 1 Yes, we should do that. But let's go home now and get you some food.\n
        response.Text = "Yes, we should do that. But let's go home now and get you some food.\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 1 END
        response.NextNodeId = "END";
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 That ain't the truth. I'm big enough to know that.\n
        prompt.Text = "That ain't the truth. I'm big enough to know that.\n";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 You're right. I don't think we'll ever see her again.\n
        response.Text = "You're right. I don't think we'll ever see her again.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n22
        response.NextNodeId = "n22";
        
        ///RESPONSE n21 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 1 You're right. I don't know if we'll see her again. We can just hope and pray.\n
        response.Text = "You're right. I don't know if we'll see her again. We can just hope and pray.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 1 n23
        response.NextNodeId = "n23";
        
        ///RESPONSE n21 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 2 I'm sorry. I guess I can't protect you from everything. I wish I could.\n
        response.Text = "I'm sorry. I guess I can't protect you from everything. I wish I could.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 2 n24
        response.NextNodeId = "n24";
        
        ///NODE_END n21
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Full
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n22~|||~
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 Have you given up? Mama never gave up on you! She prayed for you every day.\n
        prompt.Text = "Have you given up? Mama never gave up on you! She prayed for you every day.\n";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 Of course, we'll pray. It's a miracle that we both made it. We'll ask for just one more.\n
        response.Text = "Of course, we'll pray. It's a miracle that we both made it. We'll ask for just one more.\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n26
        response.NextNodeId = "n26";
        response.OnSelect(n22_r0_select);
        
        ///RESPONSE n22 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 1 We can pray, but she's far away now. Folks way down south don't come back.\n
        response.Text = "We can pray, but she's far away now. Folks way down south don't come back.\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 1 n25
        response.NextNodeId = "n25";
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 I been doing that every day. I just wish I could do more.\n
        prompt.Text = "I been doing that every day. I just wish I could do more.\n";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 You make yourself smarter and stronger every day. That's your job now. That's what Mama would want. Let's go home now.\n
        response.Text = "You make yourself smarter and stronger every day. That's your job now. That's what Mama would want. Let's go home now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n23 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 1 You did a lot by escaping. Mama would be so proud of you. Let's go home now and get you some food.\n
        response.Text = "You did a lot by escaping. Mama would be so proud of you. Let's go home now and get you some food.\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 1 END
        response.NextNodeId = "END";
        
        ///NODE_END n23
        ///NODE_START n24
        node = dialog.CreateNode("n24");
        ///NODE_NPC n24 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n24 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24 Full
        ///NODE_VISUAL_USESCRIPT n24 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n24~|||~
        ///PROMPT n24 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24 0 That's okay. You don't have to do that anymore. Just tell me the truth.\n
        prompt.Text = "That's okay. You don't have to do that anymore. Just tell me the truth.\n";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 I don't know when we'll see Mama again. Right now we can just pray.\n
        response.Text = "I don't know when we'll see Mama again. Right now we can just pray.\n";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 n23
        response.NextNodeId = "n23";
        
        ///RESPONSE n24 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 1 I don't know when we'll see Mama again. Probably never. \n
        response.Text = "I don't know when we'll see Mama again. Probably never. \n";
        ///RESPONSE_NEXT_NODE_TYPE n24 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 1 n22
        response.NextNodeId = "n22";
        
        ///NODE_END n24
        ///NODE_START n25
        node = dialog.CreateNode("n25");
        ///NODE_NPC n25 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n25 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n25 Full
        ///NODE_VISUAL_USESCRIPT n25 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n25~|||~
        ///PROMPT n25 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n25 0 Well, we have to try, right?\n
        prompt.Text = "Well, we have to try, right?\n";
        ///PROMPT_IGNORE_VO n25 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n25 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 0 Mama is too far south. Slavery will have to end before we see her again.\n
        response.Text = "Mama is too far south. Slavery will have to end before we see her again.\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 0 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n25 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 1 I don't know what we can do. But right now, let's go home and get you some food.\n
        response.Text = "I don't know what we can do. But right now, let's go home and get you some food.\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 1 END
        response.NextNodeId = "END";
        
        ///RESPONSE n25 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 2 Mama would want us to be safe. That's what we'll have to think about first. We'll talk more in the morning.\n
        response.Text = "Mama would want us to be safe. That's what we'll have to think about first. We'll talk more in the morning.\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 2 END
        response.NextNodeId = "END";
        
        ///NODE_END n25
        ///NODE_START n26
        node = dialog.CreateNode("n26");
        ///NODE_NPC n26 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n26 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26 Full
        ///NODE_VISUAL_USESCRIPT n26 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n26~|||~
        ///PROMPT n26 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26 0 Okay, let's do that. Can we go home now?\n
        prompt.Text = "Okay, let's do that. Can we go home now?\n";
        ///PROMPT_IGNORE_VO n26 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n26 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 0 Yes, let's get you some food and some sleep. We'll talk more later.\n
        response.Text = "Yes, let's get you some food and some sleep. We'll talk more later.\n";
        ///RESPONSE_NEXT_NODE_TYPE n26 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n26
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//?p3_family = true*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n04_r0_select
    public void n04_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n04_r0_select
        /*//?p3_faith = true*/
        ///METHOD_BODY_END n04_r0_select
    }

    ///METHOD n05_r0_select
    public void n05_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r0_select
        /*//?p3_faith = true*/
        ///METHOD_BODY_END n05_r0_select
    }

    ///METHOD n10_r0_select
    public void n10_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r0_select
        /*//?p3_faith = true*/
        ///METHOD_BODY_END n10_r0_select
    }

    ///METHOD n22_r0_select
    public void n22_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n22_r0_select
        /*//?p3_faith = true*/
        ///METHOD_BODY_END n22_r0_select
    }
}
//CLASS_END Dialog_p3_jon_001
