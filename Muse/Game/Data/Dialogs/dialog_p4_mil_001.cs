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
//CLASS Dialog_p4_mil_001
public class Dialog_p4_mil_001 {
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
        ///DIALOG_ID p4_mil_001
        var dialog = new Dialog();
        dialog.Id = "p4_mil_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 Lucy, I'm glad you're here. Mr. Wright will need all our help and support in this dark time.\n
        prompt.Text = "Lucy, I'm glad you're here. Mr. Wright will need all our help and support in this dark time.\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Mr. Parker asked me to look for pieces of Uncle Morgan's free papers that got torn up.\n
        response.Text = "Mr. Parker asked me to look for pieces of Uncle Morgan's free papers that got torn up.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n04
        response.NextNodeId = "n04";
        response.SetCondition(n01_r0_condition);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Where's Uncle Morgan? Did they hurt him?\n
        response.Text = "Where's Uncle Morgan? Did they hurt him?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n03
        response.NextNodeId = "n03";
        response.SetCondition(n01_r1_condition);
        response.OnSelect(n01_r1_select);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 What can I do to help?\n
        response.Text = "What can I do to help?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Our best course of action is to find witnesses who will testify that they know Mr. Wright is a free man.\n
        prompt.Text = "Our best course of action is to find witnesses who will testify that they know Mr. Wright is a free man.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 But everyone knows that. That shouldn't be hard.\n
        response.Text = "But everyone knows that. That shouldn't be hard.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 I saw him brought to the jail and he looked unharmed. I think Mr. Parker talked with him for a minute.\n
        prompt.Text = "I saw him brought to the jail and he looked unharmed. I think Mr. Parker talked with him for a minute.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What can I do to help?
        response.Text = "What can I do to help?";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n02
        response.NextNodeId = "n02";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 Yes, Uncle Morgan told him they'd ripped up his free papers. Mr. Parker asked me to look for the pieces.\n
        response.Text = "Yes, Uncle Morgan told him they'd ripped up his free papers. Mr. Parker asked me to look for the pieces.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n04
        response.NextNodeId = "n04";
        response.SetCondition(n03_r1_condition);
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 That may be effective... if you can find the evidence. But I think there is something that has a better chance of success.\n
        prompt.Text = "That may be effective... if you can find the evidence. But I think there is something that has a better chance of success.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 What is it?\n
        response.Text = "What is it?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 Unfortunately, the ###smartword|commissioner|COMMISSIONER### will likely consider the testimony of abolitionists biased. And he won't even listen to Negroes.\n
        prompt.Text = "Unfortunately, the ###smartword|commissioner|COMMISSIONER### will likely consider the testimony of abolitionists biased. And he won't even listen to Negroes.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Then who can we ask to be witnesses?\n
        response.Text = "Then who can we ask to be witnesses?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 What does that mean?\n
        response.Text = "What does that mean?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 He will think that we might lie to protect Mr. Wright.\n
        prompt.Text = "He will think that we might lie to protect Mr. Wright.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Then who can we ask to be witnesses?\n
        response.Text = "Then who can we ask to be witnesses?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n07
        response.NextNodeId = "n07";
        response.OnSelect(n06_r0_select);
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 Mr. Parker said he'll listen to the men who captured Uncle Morgan. Aren't they biased, too?\n
        response.Text = "Mr. Parker said he'll listen to the men who captured Uncle Morgan. Aren't they biased, too?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n09
        response.NextNodeId = "n09";
        response.SetCondition(n06_r1_condition);
        response.OnSelect(n06_r1_select);
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 We can still have men like Reverend Rankin testify, but the best witnesses will be whites who don't appear to have a stake in the outcome.\n
        prompt.Text = "We can still have men like Reverend Rankin testify, but the best witnesses will be whites who don't appear to have a stake in the outcome.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 Then I will go find as many good witnesses as I can.\n
        response.Text = "Then I will go find as many good witnesses as I can.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 And you want me to find people like that?\n
        response.Text = "And you want me to find people like that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Yes. Perhaps some of the Wrights' customers or other people you've met in town.\n
        prompt.Text = "Yes. Perhaps some of the Wrights' customers or other people you've met in town.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 Will you be looking for witnesses, too?\n
        response.Text = "Will you be looking for witnesses, too?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n11
        response.NextNodeId = "n11";
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 I can do that.\n
        response.Text = "I can do that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 Yes, they are. The whole law is written to favor slave owners. We will just have to do all we can.\n
        prompt.Text = "Yes, they are. The whole law is written to favor slave owners. We will just have to do all we can.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 Then I will go find as many witnesses as I can.\n
        response.Text = "Then I will go find as many witnesses as I can.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 Then who should we ask to be witnesses?\n
        response.Text = "Then who should we ask to be witnesses?\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 Good. We don't have much time before the commissioner arrives. So please do hurry...\n
        prompt.Text = "Good. We don't have much time before the commissioner arrives. So please do hurry...\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n10_p0_show);
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 [Leave.]\n
        response.Text = "[Leave.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 Yes. But I am also trying to find an abolitionist attorney who can help present our case.\n
        prompt.Text = "Yes. But I am also trying to find an abolitionist attorney who can help present our case.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 Then I will go find as many good witnesses as I can.\n
        response.Text = "Then I will go find as many good witnesses as I can.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n11
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//set ?p4_talk_millie = true*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n10_p0_show
    public void n10_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n10_p0_show
        /*//?p4_confirm_mil = true
        //#mil_points = #mil_points +1*/
        ///METHOD_BODY_END n10_p0_show
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if (?p4_talk_parker = true)*/
        return true;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if (?p4_ask_morgan_ok = false)*/
        return true;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD n03_r1_condition
    public bool n03_r1_condition (  ) {
        ///METHOD_BODY_START n03_r1_condition
        /*//if (?p4_talk_parker = true)*/
        return true;
        ///METHOD_BODY_END n03_r1_condition
    }

    ///METHOD n06_r1_condition
    public bool n06_r1_condition (  ) {
        ///METHOD_BODY_START n06_r1_condition
        /*//if (?p4_comm_thugs = true)*/
        return true;
        ///METHOD_BODY_END n06_r1_condition
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//set ?p4_ask_morgan_ok = true*/
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n06_r0_select
    public void n06_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r0_select
        /*//n07*/
        ///METHOD_BODY_END n06_r0_select
    }

    ///METHOD n06_r1_select
    public void n06_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r1_select
        /*//n09*/
        ///METHOD_BODY_END n06_r1_select
    }
}
//CLASS_END Dialog_p4_mil_001
