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
//CLASS Dialog_p4_jon_002
public class Dialog_p4_jon_002 {
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
        ///DIALOG_ID p4_jon_002
        var dialog = new Dialog();
        dialog.Id = "p4_jon_002";
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
        ///PROMPT_TEXT n01 0 How did they take Uncle Morgan? He is free... What is Aunt Abigail going to do now?\n
        prompt.Text = "How did they take Uncle Morgan? He is free... What is Aunt Abigail going to do now?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 She's going to Canada. It's safer there.\n
        response.Text = "She's going to Canada. It's safer there.\n";
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
        ///PROMPT_TEXT n02 0 What are we going to do? Who will look after us now?\n
        prompt.Text = "What are we going to do? Who will look after us now?\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 We'll stay here, at least for a while. I can look after you. You're almost a man now, anyway.\n
        response.Text = "We'll stay here, at least for a while. I can look after you. You're almost a man now, anyway.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n05
        response.NextNodeId = "n05";
        response.SetCondition(n02_r0_condition);
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 We're going to go with her. I want you to grow up safe and I want to be with you.\n
        response.Text = "We're going to go with her. I want you to grow up safe and I want to be with you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n03
        response.NextNodeId = "n03";
        response.SetCondition(n02_r1_condition);
        
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
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n02_r0_condition
    public bool n02_r0_condition (  ) {
        ///METHOD_BODY_START n02_r0_condition
        /*//if (#p4_lucy_canada = 0)*/
        return GameFlags.P4LucyCanada == 0;
        ///METHOD_BODY_END n02_r0_condition
    }

    ///METHOD n02_r1_condition
    public bool n02_r1_condition (  ) {
        ///METHOD_BODY_START n02_r1_condition
        /*//if (#p4_lucy_canada = 2)*/
        return GameFlags.P4LucyCanada == 2;
        ///METHOD_BODY_END n02_r1_condition
    }

    ///METHOD n03_r0_select
    public void n03_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r0_select
        /*//#p4_lucy_canada = 2*/
        GameFlags.P4LucyCanada = 2;
        ///METHOD_BODY_END n03_r0_select
    }

    ///METHOD n05_r0_select
    public void n05_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r0_select
        /*//#p4_lucy_canada = 0*/
        GameFlags.P4LucyCanada = 0;
        ///METHOD_BODY_END n05_r0_select
    }
}
//CLASS_END Dialog_p4_jon_002
