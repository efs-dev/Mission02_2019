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
//CLASS Dialog_p3_pro_001
public class Dialog_p3_pro_001 {
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
        ///DIALOG_ID p3_pro_001
        var dialog = new Dialog();
        dialog.Id = "p3_pro_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 PRO
        node.Npc = "PRO";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You. You here for the laundry?\n
        prompt.Text = "You. You here for the laundry?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Yes ma'am.\n
        response.Text = "Yes ma'am.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 PRO
        node.Npc = "PRO";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Well it's about time. Where's Morgan?\n
        prompt.Text = "Well it's about time. Where's Morgan?\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 Mr. Wright? Oh, he had to go to an anti-slavery meeting in Cincinnati.\n
        response.Text = "Mr. Wright? Oh, he had to go to an anti-slavery meeting in Cincinnati.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n04
        response.NextNodeId = "n04";
        response.SetCondition(n02_r1_condition);
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Mr. Wright? Oh, he's sick. I'm his niece.\n
        response.Text = "Mr. Wright? Oh, he's sick. I'm his niece.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n03
        response.NextNodeId = "n03";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 PRO
        node.Npc = "PRO";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 Niece, huh? I thought he told me he didn't have no kin like that.\n
        prompt.Text = "Niece, huh? I thought he told me he didn't have no kin like that.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 I'm from Aunt Abigail's side of the family.\n
        response.Text = "I'm from Aunt Abigail's side of the family.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 I reckon he must, because I'm the daughter of his brother... Jeffrey.\n
        response.Text = "I reckon he must, because I'm the daughter of his brother... Jeffrey.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n03 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 2 I'm sorry, ma'am. I'm his niece. Should I get the laundry now?\n
        response.Text = "I'm sorry, ma'am. I'm his niece. Should I get the laundry now?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 2 n05
        response.NextNodeId = "n05";
        response.OnSelect(n03_r0_select);
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 PRO
        node.Npc = "PRO";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 Morgan is working with them abolitionists? They're tearing our states apart!
        prompt.Text = "Morgan is working with them abolitionists? They're tearing our states apart!";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n04_p0_show);
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Did I say something wrong, ma'am?\n
        response.Text = "Did I say something wrong, ma'am?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 PRO
        node.Npc = "PRO";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 Yes, yes, get started. Make sure you get all the sheets from every room. I'll have my eye on you.\n
        prompt.Text = "Yes, yes, get started. Make sure you get all the sheets from every room. I'll have my eye on you.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Yes, ma'am.\n
        response.Text = "Yes, ma'am.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 PRO
        node.Npc = "PRO";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 I'll have to ask Morgan about that! I don't care for liars.\n
        prompt.Text = "I'll have to ask Morgan about that! I don't care for liars.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 I'm sorry, ma'am. Should I get started.\n
        response.Text = "I'm sorry, ma'am. Should I get started.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n06
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 PRO
        node.Npc = "PRO";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 No, I'm glad to know who I was really doing business with.\n
        prompt.Text = "No, I'm glad to know who I was really doing business with.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 Yes ma'am.\n
        response.Text = "Yes ma'am.\n";
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
        /*//?p3_did_hotel = true*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n04_p0_show
    public void n04_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n04_p0_show
        /*//?witness_u1 = true*/
        ///METHOD_BODY_END n04_p0_show
    }

    ///METHOD n02_r1_condition
    public bool n02_r1_condition (  ) {
        ///METHOD_BODY_START n02_r1_condition
        /*//if (?p3_know_morgan_cin = true)*/
        return true;
        ///METHOD_BODY_END n02_r1_condition
    }

    ///METHOD n03_r0_select
    public void n03_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r0_select
        /*//?p3_persuader = true*/
        ///METHOD_BODY_END n03_r0_select
    }

    ///METHOD n08_r0_select
    public void n08_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r0_select
        /*//set ?p3_lose_hotel = true*/
        ///METHOD_BODY_END n08_r0_select
    }
}
//CLASS_END Dialog_p3_pro_001
