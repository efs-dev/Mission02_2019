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
//CLASS Dialog_p4_par_001
public class Dialog_p4_par_001 {
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
        ///DIALOG_ID p4_par_001
        var dialog = new Dialog();
        dialog.Id = "p4_par_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 Lucy, just in time. Glad you'll be helping us solve this ###smartword|quandary|QUANDARY###.\n
        prompt.Text = "Lucy, just in time. Glad you'll be helping us solve this ###smartword|quandary|QUANDARY###.\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Miss Hatcher says we need to get witnesses to testify that Morgan is a free man. What do you think?\n
        response.Text = "Miss Hatcher says we need to get witnesses to testify that Morgan is a free man. What do you think?\n";
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
        ///RESPONSE_TEXT n01 2 You know me, Mr. Parker. I'm ready for anything.\n
        response.Text = "You know me, Mr. Parker. I'm ready for anything.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 That does seem so. We have to act fast because the ###smartword|commissioner|COMMISSIONER### will be here tomorrow.\n
        prompt.Text = "That does seem so. We have to act fast because the ###smartword|commissioner|COMMISSIONER### will be here tomorrow.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 What will the commissioner do?\n
        response.Text = "What will the commissioner do?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Do you have a plan?\n
        response.Text = "Do you have a plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 He's in the jail but he's unharmed. But we have to act fast because the commissioner will be here tomorrow.\n
        prompt.Text = "He's in the jail but he's unharmed. But we have to act fast because the commissioner will be here tomorrow.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What will the commissioner do?\n
        response.Text = "What will the commissioner do?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 Do you have a plan?\n
        response.Text = "Do you have a plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 It's a fine idea. But I think we need a backup plan as well. No telling what will or won't persuade the commissioner... if he'll even listen to us.\n
        prompt.Text = "It's a fine idea. But I think we need a backup plan as well. No telling what will or won't persuade the commissioner... if he'll even listen to us.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 The commissioner doesn't have to listen to us?\n
        response.Text = "The commissioner doesn't have to listen to us?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 Do you have a plan?\n
        response.Text = "Do you have a plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 I do. I got a minute to talk with Morgan and found out those men ripped up his free papers.\n
        prompt.Text = "I do. I got a minute to talk with Morgan and found out those men ripped up his free papers.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Do you think we can prove that they did that?\n
        response.Text = "Do you think we can prove that they did that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 The commissioner will listen to the men who captured Morgan. And, if he's a fair man, he will listen to the facts.\n
        prompt.Text = "The commissioner will listen to the men who captured Morgan. And, if he's a fair man, he will listen to the facts.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n06_p0_show);
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Can't Uncle Morgan just tell the commissioner that he's a free man?\n
        response.Text = "Can't Uncle Morgan just tell the commissioner that he's a free man?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 The commissioner doesn't have to listen to us?\n
        response.Text = "The commissioner doesn't have to listen to us?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 No, the law, in all its wisdom, says he only has to consider the evidence provided by the men who captured Morgan.\n
        prompt.Text = "No, the law, in all its wisdom, says he only has to consider the evidence provided by the men who captured Morgan.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 That's not fair. But not much is, I guess. Do you have a plan?\n
        response.Text = "That's not fair. But not much is, I guess. Do you have a plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 I'm hoping that's what you can do.\n
        prompt.Text = "I'm hoping that's what you can do.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 Me? What are you doing?\n
        response.Text = "Me? What are you doing?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n08_r0_select);
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 Me? What can I do?\n
        response.Text = "Me? What can I do?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n08
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 Morgan also told me where he was ambushed. I want you to go there and see if you can find any pieces of those papers.\n
        prompt.Text = "Morgan also told me where he was ambushed. I want you to go there and see if you can find any pieces of those papers.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I can do that. Can I bring Jonah? He has good eyes.\n
        response.Text = "I can do that. Can I bring Jonah? He has good eyes.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n13
        response.NextNodeId = "n13";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 I can do that.\n
        response.Text = "I can do that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n10 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 2 Why can't we go together?\n
        response.Text = "Why can't we go together?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 2 n11
        response.NextNodeId = "n11";
        response.SetCondition(n10_r2_condition);
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 A good backup plan needs another backup. If the commissioner won't listen to us, we may have to rescue him ourselves. I need to gather some men.\n
        prompt.Text = "A good backup plan needs another backup. If the commissioner won't listen to us, we may have to rescue him ourselves. I need to gather some men.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 What do you need me to do?
        response.Text = "What do you need me to do?";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n10
        response.NextNodeId = "n10";
        response.SetCondition(n11_r0_condition);
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 I hope it doesn't come to that. I'll see what I can find. Can I bring Jonah? He has good eyes.\n
        response.Text = "I hope it doesn't come to that. I'll see what I can find. Can I bring Jonah? He has good eyes.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n13
        response.NextNodeId = "n13";
        response.SetCondition(n11_r1_condition);
        
        ///RESPONSE n11 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 2 I hope it doesn't come to that. I'll see what I can find.\n
        response.Text = "I hope it doesn't come to that. I'll see what I can find.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 2 n12
        response.NextNodeId = "n12";
        response.SetCondition(n11_r2_condition);
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 Good. Be careful.\n
        prompt.Text = "Good. Be careful.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n12_p0_show);
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 I will, Mr. Parker.\n
        response.Text = "I will, Mr. Parker.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Yes, bring him. But be ###smartword|vigilant|VIGILANT###. Hide if you see strangers approaching.\n
        prompt.Text = "Yes, bring him. But be ###smartword|vigilant|VIGILANT###. Hide if you see strangers approaching.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n13_p0_show);
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 We will, Mr. Parker.\n
        response.Text = "We will, Mr. Parker.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 No, the law, in all its wisdom, says that the captured Negro may not testify on his own behalf. \n
        prompt.Text = "No, the law, in all its wisdom, says that the captured Negro may not testify on his own behalf. \n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 That's not fair. But not much is, I guess. Do you have a plan?\n
        response.Text = "That's not fair. But not much is, I guess. Do you have a plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n14
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//set ?p4_talk_parker = true*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n06_p0_show
    public void n06_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n06_p0_show
        /*//set ?p4_comm_thugs = true*/
        ///METHOD_BODY_END n06_p0_show
    }

    ///METHOD n12_p0_show
    public void n12_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n12_p0_show
        /*//?p4_confirm_par = true
        //#par_points = #par_points +1*/
        ///METHOD_BODY_END n12_p0_show
    }

    ///METHOD n13_p0_show
    public void n13_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n13_p0_show
        /*//set ?p4_bring_jonah = true
        //?p4_confirm_par = true
        //#par_points = #par_points +1*/
        ///METHOD_BODY_END n13_p0_show
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if (?p4_talk_millie = true)*/
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

    ///METHOD n10_r2_condition
    public bool n10_r2_condition (  ) {
        ///METHOD_BODY_START n10_r2_condition
        /*//if (?p4_parker_doing = false)*/
        return true;
        ///METHOD_BODY_END n10_r2_condition
    }

    ///METHOD n11_r0_condition
    public bool n11_r0_condition (  ) {
        ///METHOD_BODY_START n11_r0_condition
        /*//if (?p4_parker_doing = true)*/
        return true;
        ///METHOD_BODY_END n11_r0_condition
    }

    ///METHOD n11_r1_condition
    public bool n11_r1_condition (  ) {
        ///METHOD_BODY_START n11_r1_condition
        /*//if (?p4_parker_doing = false)*/
        return true;
        ///METHOD_BODY_END n11_r1_condition
    }

    ///METHOD n11_r2_condition
    public bool n11_r2_condition (  ) {
        ///METHOD_BODY_START n11_r2_condition
        /*//if (?p4_parker_doing = false)*/
        return true;
        ///METHOD_BODY_END n11_r2_condition
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//set ?p4_ask_morgan_ok = true*/
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n08_r0_select
    public void n08_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r0_select
        /*//?p4_parker_doing = true*/
        ///METHOD_BODY_END n08_r0_select
    }
}
//CLASS_END Dialog_p4_par_001
