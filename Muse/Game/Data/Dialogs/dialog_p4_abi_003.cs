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
//CLASS Dialog_p4_abi_003
public class Dialog_p4_abi_003 {
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
        ///DIALOG_ID p4_abi_003
        var dialog = new Dialog();
        dialog.Id = "p4_abi_003";
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
        ///PROMPT_TEXT n01 0 I can't believe my Morgan is gone. I might never see him again. \n
        prompt.Text = "I can't believe my Morgan is gone. I might never see him again. \n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 What are you going to do now?\n
        response.Text = "What are you going to do now?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n04
        response.NextNodeId = "n04";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 I am so sorry, Aunt Abigail. I should have done more. It's my fault!\n
        response.Text = "I am so sorry, Aunt Abigail. I should have done more. It's my fault!\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 I am so sorry, Aunt Abigail. I don't know what to say...\n
        response.Text = "I am so sorry, Aunt Abigail. I don't know what to say...\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
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
        ///PROMPT_TEXT n02 0 There's nothing that can be said that will bring him back.\n
        prompt.Text = "There's nothing that can be said that will bring him back.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 What are you going to do now?\n
        response.Text = "What are you going to do now?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n04
        response.NextNodeId = "n04";
        
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
        ///PROMPT_TEXT n03 0 You tried your best, Lucy. Everyone did. Sometimes that's just not enough. The blame lies with those who defend slavery, not with us.\n
        prompt.Text = "You tried your best, Lucy. Everyone did. Sometimes that's just not enough. The blame lies with those who defend slavery, not with us.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What are you going to do now?\n
        response.Text = "What are you going to do now?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n04
        response.NextNodeId = "n04";
        
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
        ///PROMPT_TEXT n04 0 Ain't nothing here for me anymore. We were thinking about moving to Canada. And that's what I'm still going to do.\n
        prompt.Text = "Ain't nothing here for me anymore. We were thinking about moving to Canada. And that's what I'm still going to do.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 But that's so far away and you don't know anyone!\n
        response.Text = "But that's so far away and you don't know anyone!\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 But you still have your business here. If you stay, Jonah and I could help you run it.\n
        response.Text = "But you still have your business here. If you stay, Jonah and I could help you run it.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n05
        response.NextNodeId = "n05";
        
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
        ///PROMPT_TEXT n05 0 That's kind of you. I know you'd be a great help. But I can't stay in Red Oak. Morgan would have wanted me to go on and be safe.\n
        prompt.Text = "That's kind of you. I know you'd be a great help. But I can't stay in Red Oak. Morgan would have wanted me to go on and be safe.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 I understand.\n
        response.Text = "I understand.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 I understand. But I don't want you to go alone. Jonah and I will come with you.\n
        response.Text = "I understand. But I don't want you to go alone. Jonah and I will come with you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n08
        response.NextNodeId = "n08";
        
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
        ///PROMPT_TEXT n06 0 That's true, but I know there are many communities there settled by escaped slaves. I'll find a place.\n
        prompt.Text = "That's true, but I know there are many communities there settled by escaped slaves. I'll find a place.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Any community would be lucky to have you.\n
        response.Text = "Any community would be lucky to have you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 But you shouldn't go alone. Jonah and I will come with you. We'll all be safe together.\n
        response.Text = "But you shouldn't go alone. Jonah and I will come with you. We'll all be safe together.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n08
        response.NextNodeId = "n08";
        
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
        ///PROMPT_TEXT n07 0 Thank you. I'll be leaving within a week. I'm sure Mr. Rankin and Miss Hatcher can help you find a place to live. You might even be able to stay here.\n
        prompt.Text = "Thank you. I'll be leaving within a week. I'm sure Mr. Rankin and Miss Hatcher can help you find a place to live. You might even be able to stay here.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 Don't worry about us. We'll be fine. I wish you safe travels.\n
        response.Text = "Don't worry about us. We'll be fine. I wish you safe travels.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 END
        response.NextNodeId = "END";
        response.OnSelect(n07_r0_select);
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 Thank you for everything, Aunt Abigail. I don't know what I would have done without you.\n
        response.Text = "Thank you for everything, Aunt Abigail. I don't know what I would have done without you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 END
        response.NextNodeId = "END";
        response.OnSelect(n07_r1_select);
        
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
        ///PROMPT_TEXT n08 0 I don't know why I didn't think about that. I guess I can't think about anything right now. But, yes, I'd like that. Thank you.\n
        prompt.Text = "I don't know why I didn't think about that. I guess I can't think about anything right now. But, yes, I'd like that. Thank you.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 I'd better go and tell Jonah.\n
        response.Text = "I'd better go and tell Jonah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 END
        response.NextNodeId = "END";
        response.OnSelect(n08_r0_select);
        
        ///NODE_END n08
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//showNpc( true, 1)*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n07_r0_select
    public void n07_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r0_select
        /*//#p4_lucy_canada = 0*/
        GameFlags.P4LucyCanada = 0;
        ///METHOD_BODY_END n07_r0_select
    }

    ///METHOD n07_r1_select
    public void n07_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r1_select
        /*//#p4_lucy_canada = 0*/
        GameFlags.P4LucyCanada = 0;
        ///METHOD_BODY_END n07_r1_select
    }

    ///METHOD n08_r0_select
    public void n08_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r0_select
        /*//#p4_lucy_canada = 2*/
        GameFlags.P4LucyCanada = 2;
        ///METHOD_BODY_END n08_r0_select
    }
}
//CLASS_END Dialog_p4_abi_003
