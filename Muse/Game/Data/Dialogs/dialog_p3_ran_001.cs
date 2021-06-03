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
//CLASS Dialog_p3_ran_001
public class Dialog_p3_ran_001 {
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
        ///DIALOG_ID p3_ran_001
        var dialog = new Dialog();
        dialog.Id = "p3_ran_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 It is good to see you Lucy. What brings you to our church this day?\n
        prompt.Text = "It is good to see you Lucy. What brings you to our church this day?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Aunt Abigail asked me to drop off our contribution to the fundraiser.\n
        response.Text = "Aunt Abigail asked me to drop off our contribution to the fundraiser.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Mrs. Wright is a ###smartword|stalwart|STALWART### in our movement... Do you have a moment to talk? \n
        prompt.Text = "Mrs. Wright is a ###smartword|stalwart|STALWART### in our movement... Do you have a moment to talk? \n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 I should get started with my laundry route. It is my first day and I don't want to be late.\n
        response.Text = "I should get started with my laundry route. It is my first day and I don't want to be late.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Yes, Reverend. What is it?\n
        response.Text = "Yes, Reverend. What is it?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 I admire your diligence, child, but this will only take a few minutes and it is of some urgency.\n
        prompt.Text = "I admire your diligence, child, but this will only take a few minutes and it is of some urgency.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What is it, sir?\n
        response.Text = "What is it, sir?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 You came to us from the King Plantation near Lexington, yes?\n
        prompt.Text = "You came to us from the King Plantation near Lexington, yes?\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Yes, I did.\n
        response.Text = "Yes, I did.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 I'm very sorry to have to tell you this. I have word that Master King is auctioning his slaves within weeks. \n
        prompt.Text = "I'm very sorry to have to tell you this. I have word that Master King is auctioning his slaves within weeks. \n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Jonah? My mama? What will happen to them?\n
        response.Text = "Jonah? My mama? What will happen to them?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 Why would he do that?\n
        response.Text = "Why would he do that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 The rumor is that he is near ###smartword|bankruptcy|BANKRUPTCY### and must raise money.\n
        prompt.Text = "The rumor is that he is near ###smartword|bankruptcy|BANKRUPTCY### and must raise money.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 I heard Mr. Parker bought his freedom. I've been saving my money. I could buy theirs! \n
        response.Text = "I heard Mr. Parker bought his freedom. I've been saving my money. I could buy theirs! \n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n08
        response.NextNodeId = "n08";
        response.SetCondition(n06_r0_condition);
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 I've been saving my money. I could buy their freedom!\n
        response.Text = "I've been saving my money. I could buy their freedom!\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n08
        response.NextNodeId = "n08";
        response.SetCondition(n06_r1_condition);
        
        ///RESPONSE n06 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 2 But my family. Where will they end up?\n
        response.Text = "But my family. Where will they end up?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 2 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 I'm afraid most slaves are sold to cotton plantations in the South, totally out of our reach. \n
        prompt.Text = "I'm afraid most slaves are sold to cotton plantations in the South, totally out of our reach. \n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n07_p0_show);
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 I heard Mr. Parker bought his freedom. I've been saving my money. I could buy theirs! \n
        response.Text = "I heard Mr. Parker bought his freedom. I've been saving my money. I could buy theirs! \n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        response.SetCondition(n07_r0_condition);
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 I've been saving my money. I could buy their freedom!\n
        response.Text = "I've been saving my money. I could buy their freedom!\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n08
        response.NextNodeId = "n08";
        response.SetCondition(n07_r1_condition);
        
        ///RESPONSE n07 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 2 Can't I still help them somehow?\n
        response.Text = "Can't I still help them somehow?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 2 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 It is a noble idea, but it could take $2,000 or more. \n
        prompt.Text = "It is a noble idea, but it could take $2,000 or more. \n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 What can we do to help then?\n
        response.Text = "What can we do to help then?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n08
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 It is too far to send someone to attempt a rescue. But I have some ideas. You should come to our abolitionist meeting tonight and we will discuss our options.\n
        prompt.Text = "It is too far to send someone to attempt a rescue. But I have some ideas. You should come to our abolitionist meeting tonight and we will discuss our options.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 What about Mr. Parker? Aunt Abigail said he helps slaves escape.  \n
        response.Text = "What about Mr. Parker? Aunt Abigail said he helps slaves escape.  \n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n11
        response.NextNodeId = "n11";
        response.SetCondition(n10_r0_condition);
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 I made it here myself. I am not afraid to go back and get my family.\n
        response.Text = "I made it here myself. I am not afraid to go back and get my family.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n10 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 2 Aunt Abigail has already invited me.\n
        response.Text = "Aunt Abigail has already invited me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 2 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 Yes, John Parker has many talents.\n
        prompt.Text = "Yes, John Parker has many talents.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 I am to pick up his laundry today. Perhaps I can ask him for advice.\n
        response.Text = "I am to pick up his laundry today. Perhaps I can ask him for advice.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n12
        response.NextNodeId = "n12";
        response.OnSelect(n11_r0_select);
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 Yes, Mr. Parker is quite resourceful. You should talk with him. He will also be at our abolitionist meeting tonight. You should come.\n
        prompt.Text = "Yes, Mr. Parker is quite resourceful. You should talk with him. He will also be at our abolitionist meeting tonight. You should come.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 Aunt Abigail has already invited me.\n
        response.Text = "Aunt Abigail has already invited me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Mrs. Wright is usually one step ahead of me. We will see you tonight and decide what is to be done.\n
        prompt.Text = "Mrs. Wright is usually one step ahead of me. We will see you tonight and decide what is to be done.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 Thank you, sir.\n
        response.Text = "Thank you, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 END
        response.NextNodeId = "END";
        response.OnSelect(n13_r0_select);
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 RAN
        node.Npc = "RAN";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 I would not see you embark on a ###smartword|foolhardy|FOOLHARDY### journey, however noble in intent. Please, Lucy, come to the meeting before you make any decisions.\n
        prompt.Text = "I would not see you embark on a ###smartword|foolhardy|FOOLHARDY### journey, however noble in intent. Please, Lucy, come to the meeting before you make any decisions.\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 Yes, sir, I will.\n
        response.Text = "Yes, sir, I will.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 END
        response.NextNodeId = "END";
        response.OnSelect(n14_r0_select);
        
        ///NODE_END n14
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n07_p0_show
    public void n07_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n07_p0_show
        /*//set ?p3_know_rankin_no_money = true*/
        ///METHOD_BODY_END n07_p0_show
    }

    ///METHOD n06_r0_condition
    public bool n06_r0_condition (  ) {
        ///METHOD_BODY_START n06_r0_condition
        /*//if (?p3_know_parker_free = true)*/
        return GameFlags.P3KnowParkerFree;
        ///METHOD_BODY_END n06_r0_condition
    }

    ///METHOD n06_r1_condition
    public bool n06_r1_condition (  ) {
        ///METHOD_BODY_START n06_r1_condition
        /*//if (?p3_know_parker_free = false)*/
        return !GameFlags.P3KnowParkerFree;
        ///METHOD_BODY_END n06_r1_condition
    }

    ///METHOD n07_r0_condition
    public bool n07_r0_condition (  ) {
        ///METHOD_BODY_START n07_r0_condition
        /*//if (?p3_know_parker_free = true)*/
        return GameFlags.P3KnowParkerFree;
        ///METHOD_BODY_END n07_r0_condition
    }

    ///METHOD n07_r1_condition
    public bool n07_r1_condition (  ) {
        ///METHOD_BODY_START n07_r1_condition
        /*//if (?p3_know_parker_free = false)*/
        return !GameFlags.P3KnowParkerFree;
        ///METHOD_BODY_END n07_r1_condition
    }

    ///METHOD n10_r0_condition
    public bool n10_r0_condition (  ) {
        ///METHOD_BODY_START n10_r0_condition
        /*//if (?p3_know_parker_free = true)*/
        return GameFlags.P3KnowParkerFree;
        ///METHOD_BODY_END n10_r0_condition
    }

    ///METHOD n11_r0_select
    public void n11_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r0_select
        /*//set ?p3_know_parker_resourceful = true*/
        GameFlags.P3KnowParkerResourceful = true;
        ///METHOD_BODY_END n11_r0_select
    }

    ///METHOD n13_r0_select
    public void n13_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n13_r0_select
        /*//showPopup("P3_TO_MILLY")*/
        ///METHOD_BODY_END n13_r0_select
    }

    ///METHOD n14_r0_select
    public void n14_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n14_r0_select
        /*//showPopup("P3_TO_MILLY")*/
        ///METHOD_BODY_END n14_r0_select
    }
}
//CLASS_END Dialog_p3_ran_001
