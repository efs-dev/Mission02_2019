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
//CLASS Dialog_p4_abi_001
public class Dialog_p4_abi_001 {
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
        ///DIALOG_ID p4_abi_001
        var dialog = new Dialog();
        dialog.Id = "p4_abi_001";
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
        ///PROMPT_TEXT n01 0 Lucy, get the cart ready. Mr. Wright is in real trouble!\n
        prompt.Text = "Lucy, get the cart ready. Mr. Wright is in real trouble!\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 What happened?\n
        response.Text = "What happened?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n01a
        response.NextNodeId = "n01a";
        
        ///NODE_END n01
        ///NODE_START n01a
        node = dialog.CreateNode("n01a");
        ///NODE_NPC n01a ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n01a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01a Full
        ///NODE_VISUAL_USESCRIPT n01a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01a~|||~
        ///PROMPT n01a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01a 0 Some men grabbed him and took him to jail. They're lying and saying he's a runaway. They'll try and take him south!\n
        prompt.Text = "Some men grabbed him and took him to jail. They're lying and saying he's a runaway. They'll try and take him south!\n";
        ///PROMPT_IGNORE_VO n01a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01a 0 Yes, Aunt Abigail. I'll hitch Tess to the cart at once.\n
        response.Text = "Yes, Aunt Abigail. I'll hitch Tess to the cart at once.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01a 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n01a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01a 1 Uncle Morgan has free papers. They can't send him south.\n
        response.Text = "Uncle Morgan has free papers. They can't send him south.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01a 1 n03
        response.NextNodeId = "n03";
        response.OnSelect(n01a_r1_select);
        
        ///RESPONSE n01a 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01a 2 The sheriff is friendly to us. He'll protect Uncle Morgan, right?\n
        response.Text = "The sheriff is friendly to us. He'll protect Uncle Morgan, right?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01a 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01a 2 n02
        response.NextNodeId = "n02";
        response.OnSelect(n01a_r0_select);
        
        ///NODE_END n01a
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
        ///PROMPT_TEXT n02 0 Sheriff McKee got ###smartword|cholera|CHOLERA### and he's on death's door. He can't help us.\n
        prompt.Text = "Sheriff McKee got ###smartword|cholera|CHOLERA### and he's on death's door. He can't help us.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 Will he recover?\n
        response.Text = "Will he recover?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Is there a new sheriff?\n
        response.Text = "Is there a new sheriff?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n04
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
        ///PROMPT_TEXT n03 0 He always has his papers. I don't know what happened. But since the ###smartword|Fugitive Slave Act|FUGITIVE_SLAVE_ACT### passed, slave catchers are mighty aggressive. \n
        prompt.Text = "He always has his papers. I don't know what happened. But since the ###smartword|Fugitive Slave Act|FUGITIVE_SLAVE_ACT### passed, slave catchers are mighty aggressive. \n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n03_p0_show);
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 We better go at once then!\n
        response.Text = "We better go at once then!\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 What about Sheriff McKee? He'll help us.\n
        response.Text = "What about Sheriff McKee? He'll help us.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n02
        response.NextNodeId = "n02";
        response.SetCondition(n03_r1_condition);
        response.OnSelect(n03_r1_select);
        
        ///RESPONSE n03 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 2 Miss Hatcher told me about that law at school. Anyone who helps a runaway can be put in prison.\n
        response.Text = "Miss Hatcher told me about that law at school. Anyone who helps a runaway can be put in prison.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 2 n07
        response.NextNodeId = "n07";
        response.SetCondition(n03_r0_condition);
        
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
        ///PROMPT_TEXT n04 0 No, but it don't matter. Some government man comes and decides these things now. I heard he'll be in Ripley tomorrow.\n
        prompt.Text = "No, but it don't matter. Some government man comes and decides these things now. I heard he'll be in Ripley tomorrow.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 We better go at once then!\n
        response.Text = "We better go at once then!\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 But what about Uncle Morgan's free papers?\n
        response.Text = "But what about Uncle Morgan's free papers?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n03
        response.NextNodeId = "n03";
        response.SetCondition(n04_r0_condition);
        response.OnSelect(n04_r0_select);
        
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
        ///PROMPT_TEXT n05 0 It's a cruel sickness. No telling for a few more days. We'll just keep praying.\n
        prompt.Text = "It's a cruel sickness. No telling for a few more days. We'll just keep praying.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 But what about Uncle Morgan's free papers?\n
        response.Text = "But what about Uncle Morgan's free papers?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n03
        response.NextNodeId = "n03";
        response.SetCondition(n05_r1_condition);
        response.OnSelect(n05_r1_select);
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 Is there a new sheriff?\n
        response.Text = "Is there a new sheriff?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n05
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
        ///PROMPT_TEXT n07 0 Yes, and it's even worse than that. If you're arrested, everything depends on a federal ###smartword|commissioner|COMMISSIONER### who doesn't know any of the free Negroes.\n
        prompt.Text = "Yes, and it's even worse than that. If you're arrested, everything depends on a federal ###smartword|commissioner|COMMISSIONER### who doesn't know any of the free Negroes.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 What about Sheriff McKee? He'll help us.\n
        response.Text = "What about Sheriff McKee? He'll help us.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n07_r1_condition);
        response.OnSelect(n07_r1_select);
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 We'd better go at once then!\n
        response.Text = "We'd better go at once then!\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 END
        response.NextNodeId = "END";
        
        ///NODE_END n07
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n03_p0_show
    public void n03_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n03_p0_show
        /*//set ?p4_lucy_know_fsa = true*/
        ///METHOD_BODY_END n03_p0_show
    }

    ///METHOD n03_r1_condition
    public bool n03_r1_condition (  ) {
        ///METHOD_BODY_START n03_r1_condition
        /*//if (?p4_asked_mckee = false)*/
        return true;
        ///METHOD_BODY_END n03_r1_condition
    }

    ///METHOD n03_r0_condition
    public bool n03_r0_condition (  ) {
        ///METHOD_BODY_START n03_r0_condition
        /*//if (?p3_millie_lesson_promise = true)*/
        return true;
        ///METHOD_BODY_END n03_r0_condition
    }

    ///METHOD n04_r0_condition
    public bool n04_r0_condition (  ) {
        ///METHOD_BODY_START n04_r0_condition
        /*//if (?p4_asked_papers = false)*/
        return true;
        ///METHOD_BODY_END n04_r0_condition
    }

    ///METHOD n05_r1_condition
    public bool n05_r1_condition (  ) {
        ///METHOD_BODY_START n05_r1_condition
        /*//if (?p4_asked_papers = false)*/
        return true;
        ///METHOD_BODY_END n05_r1_condition
    }

    ///METHOD n07_r1_condition
    public bool n07_r1_condition (  ) {
        ///METHOD_BODY_START n07_r1_condition
        /*//if (?p4_asked_mckee = false)*/
        return true;
        ///METHOD_BODY_END n07_r1_condition
    }

    ///METHOD n01a_r1_select
    public void n01a_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01a_r1_select
        /*//set ?p4_asked_papers = true*/
        ///METHOD_BODY_END n01a_r1_select
    }

    ///METHOD n01a_r0_select
    public void n01a_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01a_r0_select
        /*//set ?p4_asked_mckee = true*/
        ///METHOD_BODY_END n01a_r0_select
    }

    ///METHOD n03_r1_select
    public void n03_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r1_select
        /*//set ?p4_asked_mckee = true*/
        ///METHOD_BODY_END n03_r1_select
    }

    ///METHOD n04_r0_select
    public void n04_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n04_r0_select
        /*//set ?p4_asked_papers = true*/
        ///METHOD_BODY_END n04_r0_select
    }

    ///METHOD n05_r1_select
    public void n05_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r1_select
        /*//set ?p4_asked_papers = true*/
        ///METHOD_BODY_END n05_r1_select
    }

    ///METHOD n07_r1_select
    public void n07_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r1_select
        /*//set ?p4_asked_mckee = true*/
        ///METHOD_BODY_END n07_r1_select
    }
}
//CLASS_END Dialog_p4_abi_001
