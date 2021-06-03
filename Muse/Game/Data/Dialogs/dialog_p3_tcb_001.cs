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
//CLASS Dialog_p3_tcb_001
public class Dialog_p3_tcb_001 {
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
        ///DIALOG_ID p3_tcb_001
        var dialog = new Dialog();
        dialog.Id = "p3_tcb_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 Excuse me I... [He looks at you] ...watch where you're going. You new here?\n
        prompt.Text = "Excuse me I... [He looks at you] ...watch where you're going. You new here?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Usually my uncle gets the sheets and I do the washing.\n
        response.Text = "Usually my uncle gets the sheets and I do the washing.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Yes, sir.\n
        response.Text = "Yes, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
        response.NextNodeId = "n02";
        response.SetCondition(n01_r1_condition);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Yes, sir.\n
        response.Text = "Yes, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n10
        response.NextNodeId = "n10";
        response.SetCondition(n01_r2_condition);
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Then I'll forgive this little mishap you caused. Perhaps you can do me a favor in return.\n
        prompt.Text = "Then I'll forgive this little mishap you caused. Perhaps you can do me a favor in return.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 I had better get back to work. [Pick up sheets.]\n
        response.Text = "I had better get back to work. [Pick up sheets.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 What is it, sir?\n
        response.Text = "What is it, sir?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n05a
        response.NextNodeId = "n05a";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 Where's your uncle today? Why is he making you do all this work?\n
        prompt.Text = "Where's your uncle today? Why is he making you do all this work?\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 He's in Cincinnati attending a meeting.\n
        response.Text = "He's in Cincinnati attending a meeting.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n13
        response.NextNodeId = "n13";
        response.SetCondition(n03_r0_condition);
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 [Lie] He's sick.\n
        response.Text = "[Lie] He's sick.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 That's too bad. You're a good...niece.\n
        prompt.Text = "That's too bad. You're a good...niece.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Thank you. I'd better pick this up. [Pick up sheets.]\n
        response.Text = "Thank you. I'd better pick this up. [Pick up sheets.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n05
        response.NextNodeId = "n05";
        response.SetCondition(n04_r0_condition);
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 Thank you. I'd better pick this up. [Pick up sheets.]\n
        response.Text = "Thank you. I'd better pick this up. [Pick up sheets.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n11
        response.NextNodeId = "n11";
        response.SetCondition(n04_r1_condition);
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 [He steps on the sheets.] Now tell me, have you ever heard of the King Plantation?\n
        prompt.Text = "[He steps on the sheets.] Now tell me, have you ever heard of the King Plantation?\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 I might have heard that name before. Is that in Kentucky?\n
        response.Text = "I might have heard that name before. Is that in Kentucky?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 [Lie] No, sir.\n
        response.Text = "[Lie] No, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05
        ///NODE_START n05a
        node = dialog.CreateNode("n05a");
        ///NODE_NPC n05a TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n05a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05a Full
        ///NODE_VISUAL_USESCRIPT n05a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05a~|||~
        ///PROMPT n05a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05a 0 Now tell me, have you ever heard of the King Plantation?\n
        prompt.Text = "Now tell me, have you ever heard of the King Plantation?\n";
        ///PROMPT_IGNORE_VO n05a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05a 0 I might have heard that name before. Is that in Kentucky?\n
        response.Text = "I might have heard that name before. Is that in Kentucky?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05a 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n05a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05a 1 [Lie] No, sir.\n
        response.Text = "[Lie] No, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05a 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05a
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 That's too bad. Might have been worth your while to know of it.\n
        prompt.Text = "That's too bad. Might have been worth your while to know of it.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 I'd better pick this up. [Pick up sheets.]\n
        response.Text = "I'd better pick this up. [Pick up sheets.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 What do you mean?\n
        response.Text = "What do you mean?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 I'm looking for someone who ran away from there.\n
        prompt.Text = "I'm looking for someone who ran away from there.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 [Lie] I'm sorry, sir. I don't know anyone.\n
        response.Text = "[Lie] I'm sorry, sir. I don't know anyone.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n16
        response.NextNodeId = "n16";
        response.SetCondition(n07_r0_condition);
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 [Lie] I'm sorry, sir. I don't know anyone.\n
        response.Text = "[Lie] I'm sorry, sir. I don't know anyone.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n17
        response.NextNodeId = "n17";
        response.SetCondition(n07_r1_condition);
        
        ///RESPONSE n07 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 2 [Run.]\n
        response.Text = "[Run.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 2 END
        response.NextNodeId = "END";
        response.OnSelect(n07_r2_select);
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 [He gathers his papers.] If you hear anything about a new young fella in town -- goes by the name of Henry -- you'll come tell me, right?\n
        prompt.Text = "[He gathers his papers.] If you hear anything about a new young fella in town -- goes by the name of Henry -- you'll come tell me, right?\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 No, sir. I won't help you.\n
        response.Text = "No, sir. I won't help you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n17a
        response.NextNodeId = "n17a";
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 Yes, sir. [Wait for him to leave and then pick up sheets.]\n
        response.Text = "Yes, sir. [Wait for him to leave and then pick up sheets.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n20
        response.NextNodeId = "n20";
        response.OnSelect(n08_r1_select);
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 If you'd known something, might have been a dollar in it for you.\n
        prompt.Text = "If you'd known something, might have been a dollar in it for you.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 I don't need your money.\n
        response.Text = "I don't need your money.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n23
        response.NextNodeId = "n23";
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 I'll remember that.\n
        response.Text = "I'll remember that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 And are you new at visiting John Parker, too?\n
        prompt.Text = "And are you new at visiting John Parker, too?\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n10_p0_show);
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 Yes, we do his wash, too.\n
        response.Text = "Yes, we do his wash, too.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 [Lie] I don't know what you're talking about, sir.\n
        response.Text = "[Lie] I don't know what you're talking about, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 [He steps on the sheets] Tell me, what were you doing talking to John Parker?\n
        prompt.Text = "[He steps on the sheets] Tell me, what were you doing talking to John Parker?\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 I wanted to see if he could help my family.\n
        response.Text = "I wanted to see if he could help my family.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 END
        response.NextNodeId = "END";
        response.OnSelect(n11_r0_select);
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 I was picking up his wash.\n
        response.Text = "I was picking up his wash.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n12
        response.NextNodeId = "n12";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 So tell me, why did you have to go inside and close the door.\n
        prompt.Text = "So tell me, why did you have to go inside and close the door.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 [Lie] Mr. Parker asked me in while he got his wash.\n
        response.Text = "[Lie] Mr. Parker asked me in while he got his wash.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 I saw you watching me and I got scared.\n
        response.Text = "I saw you watching me and I got scared.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n15
        response.NextNodeId = "n15";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 That's a mighty fine town. What kind of meeting would a laundry man be attending?\n
        prompt.Text = "That's a mighty fine town. What kind of meeting would a laundry man be attending?\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 I think it's an anti-slavery meeting.\n
        response.Text = "I think it's an anti-slavery meeting.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n24
        response.NextNodeId = "n24";
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 [Lie] I don't know, sir.\n
        response.Text = "[Lie] I don't know, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 I've watched your uncle get the wash and Mr. Parker never asked him in. Mr. Parker is a very private man.\n
        prompt.Text = "I've watched your uncle get the wash and Mr. Parker never asked him in. Mr. Parker is a very private man.\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 I went in because I saw you watching me and I got scared.\n
        response.Text = "I went in because I saw you watching me and I got scared.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n15
        response.NextNodeId = "n15";
        
        ///RESPONSE n14 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 1 [Lie] I'm sorry, sir. I don't know why he asked me.\n
        response.Text = "[Lie] I'm sorry, sir. I don't know why he asked me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 1 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 See the truth ain't so hard. I know I can seem scary. What were you scared of? What could you have to hide?\n
        prompt.Text = "See the truth ain't so hard. I know I can seem scary. What were you scared of? What could you have to hide?\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 [Run]\n
        response.Text = "[Run]\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 END
        response.NextNodeId = "END";
        response.OnSelect(n15_r0_select);
        
        ///RESPONSE n15 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 1 [Lie] I don't know, sir.\n
        response.Text = "[Lie] I don't know, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 1 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 Don't know or won't say...hmmm. Well, we'll continue this another time. [He quickly gathers his papers and walks away.]\n
        prompt.Text = "Don't know or won't say...hmmm. Well, we'll continue this another time. [He quickly gathers his papers and walks away.]\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 [Pick up sheets.]\n
        response.Text = "[Pick up sheets.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n20
        response.NextNodeId = "n20";
        response.OnSelect(n16_r0_select);
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 Don't know or won't say? You should step into my room and we can discuss this further.\n
        prompt.Text = "Don't know or won't say? You should step into my room and we can discuss this further.\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 No, sir. I can't do that.\n
        response.Text = "No, sir. I can't do that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n17 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 1 Yes, sir.\n
        response.Text = "Yes, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 1 n18
        response.NextNodeId = "n18";
        
        ///NODE_END n17
        ///NODE_START n17a
        node = dialog.CreateNode("n17a");
        ///NODE_NPC n17a TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n17a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17a Full
        ///NODE_VISUAL_USESCRIPT n17a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17a~|||~
        ///PROMPT n17a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17a 0 No? That won't do. Step into my room and we'll discuss this further.\n
        prompt.Text = "No? That won't do. Step into my room and we'll discuss this further.\n";
        ///PROMPT_IGNORE_VO n17a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17a 0 No, sir. I can't do that.\n
        response.Text = "No, sir. I can't do that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17a 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n17a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17a 1 Yes, sir.\n
        response.Text = "Yes, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17a 1 n18
        response.NextNodeId = "n18";
        
        ///NODE_END n17a
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 [From downstairs] Mr. Bercham, someone here to talk to you...\n
        prompt.Text = "[From downstairs] Mr. Bercham, someone here to talk to you...\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n18_p0_show);
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 [Wait]\n
        response.Text = "[Wait]\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n19
        response.NextNodeId = "n19";
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 We ain't done here. [He walks away.]\n
        prompt.Text = "We ain't done here. [He walks away.]\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 [Pick up sheets]\n
        response.Text = "[Pick up sheets]\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 n20
        response.NextNodeId = "n20";
        response.OnSelect(n19_r0_select);
        
        ///NODE_END n19
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 [Mixed in with the sheets you find a piece of paper.]\n
        prompt.Text = "[Mixed in with the sheets you find a piece of paper.]\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 [Look at the paper.]\n
        response.Text = "[Look at the paper.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n21
        response.NextNodeId = "n21";
        response.OnSelect(n20_r0_select);
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 [Put the paper away.]\n
        response.Text = "[Put the paper away.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n22
        response.NextNodeId = "n22";
        response.OnSelect(n21_r0_select);
        
        ///NODE_END n21
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Full
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n22~|||~
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 [You hear another door open behind you.]\n
        prompt.Text = "[You hear another door open behind you.]\n";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n22_p0_show);
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 [Stand up.]\n
        response.Text = "[Stand up.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 You have some lip on you girl. I'll be watching you. You can count on that. [He gathers his papers and leaves.]\n
        prompt.Text = "You have some lip on you girl. I'll be watching you. You can count on that. [He gathers his papers and leaves.]\n";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 [Pick up sheets]\n
        response.Text = "[Pick up sheets]\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n20
        response.NextNodeId = "n20";
        response.OnSelect(n23_r0_select);
        
        ///NODE_END n23
        ///NODE_START n24
        node = dialog.CreateNode("n24");
        ///NODE_NPC n24 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n24 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24 Full
        ///NODE_VISUAL_USESCRIPT n24 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n24~|||~
        ///PROMPT n24 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24 0 Now there's a laugh. A Negro thinks he's going to end slavery. You people should stick to washing the clothes of your betters.\n
        prompt.Text = "Now there's a laugh. A Negro thinks he's going to end slavery. You people should stick to washing the clothes of your betters.\n";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 Yes, sir.\n
        response.Text = "Yes, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 n25
        response.NextNodeId = "n25";
        
        ///RESPONSE n24 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 1 My uncle is right. Slavery is evil.\n
        response.Text = "My uncle is right. Slavery is evil.\n";
        ///RESPONSE_NEXT_NODE_TYPE n24 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 1 n23
        response.NextNodeId = "n23";
        
        ///NODE_END n24
        ///NODE_START n25
        node = dialog.CreateNode("n25");
        ///NODE_NPC n25 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n25 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n25 Full
        ///NODE_VISUAL_USESCRIPT n25 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n25~|||~
        ///PROMPT n25 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n25 0 That's more like it. Now get those sheets clean. I like them fresh. [He gathers his papers and leaves.]\n
        prompt.Text = "That's more like it. Now get those sheets clean. I like them fresh. [He gathers his papers and leaves.]\n";
        ///PROMPT_IGNORE_VO n25 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n25 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 0 [Pick up sheets]\n
        response.Text = "[Pick up sheets]\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 0 n20
        response.NextNodeId = "n20";
        response.OnSelect(n25_r0_select);
        
        ///NODE_END n25
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n10_p0_show
    public void n10_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n10_p0_show
        /*//set ?p3_tc_ask_parker = true*/
        ///METHOD_BODY_END n10_p0_show
    }

    ///METHOD n18_p0_show
    public void n18_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n18_p0_show
        /*//play_sfx("audio/dlgs/p3/p3_tcb_001/shout.mp3")*/
        ///METHOD_BODY_END n18_p0_show
    }

    ///METHOD n22_p0_show
    public void n22_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n22_p0_show
        /*//play_sfx("audio/sfx/mus_sfx_door_open.mp3")*/
        ///METHOD_BODY_END n22_p0_show
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if (?p3_tc_spied = false)*/
        return !GameFlags.P3TcSpied;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD n01_r2_condition
    public bool n01_r2_condition (  ) {
        ///METHOD_BODY_START n01_r2_condition
        /*//if (?p3_tc_spied = true)*/
        return GameFlags.P3TcSpied;
        ///METHOD_BODY_END n01_r2_condition
    }

    ///METHOD n03_r0_condition
    public bool n03_r0_condition (  ) {
        ///METHOD_BODY_START n03_r0_condition
        /*//if (?p3_know_morgan_cin = true)*/
        return GameFlags.P3KnowMorganCin;
        ///METHOD_BODY_END n03_r0_condition
    }

    ///METHOD n04_r0_condition
    public bool n04_r0_condition (  ) {
        ///METHOD_BODY_START n04_r0_condition
        /*//if (?p3_tc_spied = false)*/
        return !GameFlags.P3TcSpied;
        ///METHOD_BODY_END n04_r0_condition
    }

    ///METHOD n04_r1_condition
    public bool n04_r1_condition (  ) {
        ///METHOD_BODY_START n04_r1_condition
        /*//if (?p3_tc_spied = true)*/
        return GameFlags.P3TcSpied;
        ///METHOD_BODY_END n04_r1_condition
    }

    ///METHOD n07_r0_condition
    public bool n07_r0_condition (  ) {
        ///METHOD_BODY_START n07_r0_condition
        /*//if (?p3_tc_spied = false)*/
        return !GameFlags.P3TcSpied;
        ///METHOD_BODY_END n07_r0_condition
    }

    ///METHOD n07_r1_condition
    public bool n07_r1_condition (  ) {
        ///METHOD_BODY_START n07_r1_condition
        /*//if (?p3_tc_spied = true)*/
        return GameFlags.P3TcSpied;
        ///METHOD_BODY_END n07_r1_condition
    }

    ///METHOD n07_r2_select
    public void n07_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r2_select
        /*//$next_state = "tcb_lose"*/
        GameFlags.P3TCBLose = true;
        ///METHOD_BODY_END n07_r2_select
    }

    ///METHOD n08_r1_select
    public void n08_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r1_select
        /*//showNpc(false,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_hotel_hall1.swf")*/
        ///METHOD_BODY_END n08_r1_select
    }

    ///METHOD n11_r0_select
    public void n11_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r0_select
        /*//$next_state = "tcb_lose"*/
        GameFlags.P3TCBLose = true;
        ///METHOD_BODY_END n11_r0_select
    }

    ///METHOD n15_r0_select
    public void n15_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15_r0_select
        /*//$next_state = "tcb_lose"*/
        GameFlags.P3TCBLose = true;
        ///METHOD_BODY_END n15_r0_select
    }

    ///METHOD n16_r0_select
    public void n16_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r0_select
        /*//showNpc(false,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_hotel_hall1.swf")*/
        ///METHOD_BODY_END n16_r0_select
    }

    ///METHOD n19_r0_select
    public void n19_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n19_r0_select
        /*//showNpc(false,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_hotel_hall1.swf")*/
        ///METHOD_BODY_END n19_r0_select
    }

    ///METHOD n20_r0_select
    public void n20_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n20_r0_select
        /*//addItem("ITEM_AFFIDAVIT")
        //set ?p3_have_aff = true
        //setLayer("fg", "gfx/stills/affidavit/affidavit.swf")*/
        GameFlags.P3HaveAff = true;
        ///METHOD_BODY_END n20_r0_select
    }

    ///METHOD n21_r0_select
    public void n21_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n21_r0_select
        /*//setLayer("fg", "")*/
        ///METHOD_BODY_END n21_r0_select
    }

    ///METHOD n23_r0_select
    public void n23_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r0_select
        /*//showNpc(false,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_hotel_hall1.swf")*/
        ///METHOD_BODY_END n23_r0_select
    }

    ///METHOD n25_r0_select
    public void n25_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n25_r0_select
        /*//showNpc(false,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_hotel_hall1.swf")*/
        ///METHOD_BODY_END n25_r0_select
    }
}
//CLASS_END Dialog_p3_tcb_001
