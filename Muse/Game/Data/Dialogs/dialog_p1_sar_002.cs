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
//CLASS Dialog_p1_sar_002
public class Dialog_p1_sar_002 {
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
        ///DIALOG_ID p1_sar_002
        var dialog = new Dialog();
        dialog.Id = "p1_sar_002";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 So, is my dress ready?
        prompt.Text = "So, is my dress ready?";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 No, Miss Sarah. I didn't finish it.
        response.Text = "No, Miss Sarah. I didn't finish it.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n05
        response.NextNodeId = "n05";
        response.SetCondition(n01_r0_condition);
        response.OnSelect(n01_r0_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 [Lie] Yes, Miss Sarah. And I packed it in your bag to save you time.
        response.Text = "[Lie] Yes, Miss Sarah. And I packed it in your bag to save you time.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n04
        response.NextNodeId = "n04";
        response.SetCondition(n01_r1_condition);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Yes, Miss Sarah. And I packed it in your bag to save you time.
        response.Text = "Yes, Miss Sarah. And I packed it in your bag to save you time.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n04
        response.NextNodeId = "n04";
        response.SetCondition(n01_r2_condition);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 Yes, Miss Sarah. I think you'll be pleased.
        response.Text = "Yes, Miss Sarah. I think you'll be pleased.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n03
        response.NextNodeId = "n03";
        response.SetCondition(n01_r3_condition);
        
        ///RESPONSE n01 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 4 Yes, Miss Sarah. Do you want to try it on?
        response.Text = "Yes, Miss Sarah. Do you want to try it on?";
        ///RESPONSE_NEXT_NODE_TYPE n01 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 4 n02
        response.NextNodeId = "n02";
        response.SetCondition(n01_r4_condition);
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Oh I want to Lucy. But we are leaving immediately. I'll tell you about it when I return.
        prompt.Text = "Oh I want to Lucy. But we are leaving immediately. I'll tell you about it when I return.";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 Have a good trip Miss Sarah. \n
        response.Text = "Have a good trip Miss Sarah. \n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 END
        response.NextNodeId = "END";
        response.SetCondition(n02_r0_condition);
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Have a good trip Miss Sarah.
        response.Text = "Have a good trip Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n07
        response.NextNodeId = "n07";
        response.SetCondition(n02_r1_condition);
        
        ///RESPONSE n02 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 2 Have a good trip Miss Sarah.\n
        response.Text = "Have a good trip Miss Sarah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 2 n07
        response.NextNodeId = "n07";
        response.SetCondition(n02_r2_condition);
        
        ///RESPONSE n02 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 3 When are you coming back Miss Sarah?
        response.Text = "When are you coming back Miss Sarah?";
        ///RESPONSE_NEXT_NODE_TYPE n02 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 3 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 I'm sure I will. We'll be gone a few days so you have plenty of time to fix my other new dress the same way. You can go back to the yard now.
        prompt.Text = "I'm sure I will. We'll be gone a few days so you have plenty of time to fix my other new dress the same way. You can go back to the yard now.";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n03_p0_show);
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 Have a good trip Miss Sarah. \n
        response.Text = "Have a good trip Miss Sarah. \n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 END
        response.NextNodeId = "END";
        response.SetCondition(n03_r0_condition);
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 Have a good trip Miss Sarah. \n
        response.Text = "Have a good trip Miss Sarah. \n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n07
        response.NextNodeId = "n07";
        response.SetCondition(n03_r1_condition);
        
        ///RESPONSE n03 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 2 Have a good trip Miss Sarah.
        response.Text = "Have a good trip Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n03 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 2 n07
        response.NextNodeId = "n07";
        response.SetCondition(n03_r2_condition);
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 Oh, I would have liked to see it first. But we are leaving immediately, so it will have to wait. Back to the yard with you.
        prompt.Text = "Oh, I would have liked to see it first. But we are leaving immediately, so it will have to wait. Back to the yard with you.";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Have a good trip Miss Sarah. \n
        response.Text = "Have a good trip Miss Sarah. \n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 END
        response.NextNodeId = "END";
        response.SetCondition(n04_r0_condition);
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 Have a good trip Miss Sarah. \n
        response.Text = "Have a good trip Miss Sarah. \n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n07
        response.NextNodeId = "n07";
        response.SetCondition(n04_r1_condition);
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 Have a good trip Miss Sarah.
        response.Text = "Have a good trip Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n07
        response.NextNodeId = "n07";
        response.SetCondition(n04_r2_condition);
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 You foolish girl! When I get back you'll learn how hard I can make things for you! Now get out!!\n
        prompt.Text = "You foolish girl! When I get back you'll learn how hard I can make things for you! Now get out!!\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n05 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 1 You foolish girl! When I get back you'll learn how hard I can make things for you! Now get out!! [She throws the book at your head]\n
        prompt.Text = "You foolish girl! When I get back you'll learn how hard I can make things for you! Now get out!! [She throws the book at your head]\n";
        ///PROMPT_IGNORE_VO n05 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n05_p1_condition);
        prompt.OnShow(n05_p1_show);
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 [Leave]
        response.Text = "[Leave]";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 [Take book and leave]
        response.Text = "[Take book and leave]";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 END
        response.NextNodeId = "END";
        response.SetCondition(n05_r1_condition);
        
        ///RESPONSE n05 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 2 I won't be here when you're back! I'll run away with Henry!
        response.Text = "I won't be here when you're back! I'll run away with Henry!";
        ///RESPONSE_NEXT_NODE_TYPE n05 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 2 END
        response.NextNodeId = "END";
        response.OnSelect(n05_r2_select);
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Father wants to be back in four days, but I'm hoping we can stay an extra day in Cincinnati for some shopping.
        prompt.Text = "Father wants to be back in four days, but I'm hoping we can stay an extra day in Cincinnati for some shopping.";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n06_p0_show);
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Have a good trip Miss Sarah.
        response.Text = "Have a good trip Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 END
        response.NextNodeId = "END";
        response.SetCondition(n06_r0_condition);
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 Have a good trip Miss Sarah.
        response.Text = "Have a good trip Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n07
        response.NextNodeId = "n07";
        response.SetCondition(n06_r1_condition);
        
        ///RESPONSE n06 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 2 Have a good trip Miss Sarah.\n
        response.Text = "Have a good trip Miss Sarah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 2 n07
        response.NextNodeId = "n07";
        response.SetCondition(n06_r2_condition);
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 SAR
        node.Npc = "SAR";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 Oh, wait Lucy. Here's that book we used to practice our letters with. Use it while I'm gone and it will be our little secret...like this dress.
        prompt.Text = "Oh, wait Lucy. Here's that book we used to practice our letters with. Use it while I'm gone and it will be our little secret...like this dress.";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n07_p0_condition);
        prompt.OnShow(n07_p0_show);
        
        ///PROMPT n07 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 1 Oh, wait Lucy. Here's that book. I want it back when we return. We can't have Father finding out, now can we?
        prompt.Text = "Oh, wait Lucy. Here's that book. I want it back when we return. We can't have Father finding out, now can we?";
        ///PROMPT_IGNORE_VO n07 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n07_p1_condition);
        prompt.OnShow(n07_p1_show);
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 Thank you Miss Sarah.
        response.Text = "Thank you Miss Sarah.";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n07
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n05_p1_condition
    public bool n05_p1_condition (  ) {
        ///METHOD_BODY_START n05_p1_condition
        /*//if (?primer_return)*/
        return GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n05_p1_condition
    }

    ///METHOD n07_p0_condition
    public bool n07_p0_condition (  ) {
        ///METHOD_BODY_START n07_p0_condition
        /*//if (?primer_return AND (?primer_promise = false))*/
        return !GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n07_p0_condition
    }

    ///METHOD n07_p1_condition
    public bool n07_p1_condition (  ) {
        ///METHOD_BODY_START n07_p1_condition
        /*//if (?primer_return AND ?primer_promise)*/
        return GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n07_p1_condition
    }

    ///METHOD n03_p0_show
    public void n03_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n03_p0_show
        /*//set ?know_king_time = true*/
        GameFlags.P1KnowKingTime = true;
        ///METHOD_BODY_END n03_p0_show
    }

    ///METHOD n05_p1_show
    public void n05_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n05_p1_show
        /*//addItem("primer")*/
        GameFlags.P1HasPrimer = true;
        ///METHOD_BODY_END n05_p1_show
    }

    ///METHOD n06_p0_show
    public void n06_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n06_p0_show
        /*//set ?know_king_time = true*/
        ///METHOD_BODY_END n06_p0_show
    }

    ///METHOD n07_p0_show
    public void n07_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n07_p0_show
        /*//addItem ("primer")*/
        GameFlags.P1HasPrimer = true;
        ///METHOD_BODY_END n07_p0_show
    }

    ///METHOD n07_p1_show
    public void n07_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n07_p1_show
        /*//addItem ("primer")*/
        GameFlags.P1HasPrimer = true;
        ///METHOD_BODY_END n07_p1_show
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if (?dress_finished = false)*/
        return !GameFlags.P1DressFinished;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if (?dress_finished = false AND (?dress_packed))*/
        return !GameFlags.P1DressFinished && GameFlags.P1DressPacked;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD n01_r2_condition
    public bool n01_r2_condition (  ) {
        ///METHOD_BODY_START n01_r2_condition
        /*//if (?dress_finished AND (?dress_packed))*/
        return GameFlags.P1DressFinished && GameFlags.P1DressPacked;
        ///METHOD_BODY_END n01_r2_condition
    }

    ///METHOD n01_r3_condition
    public bool n01_r3_condition (  ) {
        ///METHOD_BODY_START n01_r3_condition
        /*//if (?dress_finished AND (?dress_packed = false))*/
        return GameFlags.P1DressFinished && !GameFlags.P1DressPacked;
        ///METHOD_BODY_END n01_r3_condition
    }

    ///METHOD n01_r4_condition
    public bool n01_r4_condition (  ) {
        ///METHOD_BODY_START n01_r4_condition
        /*//if (?dress_finished AND (?dress_packed = false))*/
        return GameFlags.P1DressFinished && !GameFlags.P1DressPacked;
        ///METHOD_BODY_END n01_r4_condition
    }

    ///METHOD n02_r0_condition
    public bool n02_r0_condition (  ) {
        ///METHOD_BODY_START n02_r0_condition
        /*//if (((?primer_promise = false) AND (?primer_return = false)) OR (?primer_promise AND (?primer_return = false)))*/
        return (!GameFlags.P1PrimerPromise && !GameFlags.P1PrimerReturn) || (GameFlags.P1PrimerPromise && !GameFlags.P1PrimerReturn);
        ///METHOD_BODY_END n02_r0_condition
    }

    ///METHOD n02_r1_condition
    public bool n02_r1_condition (  ) {
        ///METHOD_BODY_START n02_r1_condition
        /*//if (?primer_promise = false AND (?primer_return))*/
        return !GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n02_r1_condition
    }

    ///METHOD n02_r2_condition
    public bool n02_r2_condition (  ) {
        ///METHOD_BODY_START n02_r2_condition
        /*//if (?primer_promise AND (?primer_return))*/
        return GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n02_r2_condition
    }

    ///METHOD n03_r0_condition
    public bool n03_r0_condition (  ) {
        ///METHOD_BODY_START n03_r0_condition
        /*//if (((?primer_promise = false) AND (?primer_return = false)) OR (?primer_promise AND (?primer_return = false)))*/
        return (!GameFlags.P1PrimerPromise && !GameFlags.P1PrimerReturn) || (GameFlags.P1PrimerPromise && !GameFlags.P1PrimerReturn);
        ///METHOD_BODY_END n03_r0_condition
    }

    ///METHOD n03_r1_condition
    public bool n03_r1_condition (  ) {
        ///METHOD_BODY_START n03_r1_condition
        /*//if (?primer_promise = false AND (?primer_return))*/
        return !GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n03_r1_condition
    }

    ///METHOD n03_r2_condition
    public bool n03_r2_condition (  ) {
        ///METHOD_BODY_START n03_r2_condition
        /*//if (?primer_promise AND (?primer_return))*/
        return GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n03_r2_condition
    }

    ///METHOD n04_r0_condition
    public bool n04_r0_condition (  ) {
        ///METHOD_BODY_START n04_r0_condition
        /*//if (((?primer_promise = false) AND (?primer_return = false)) OR (?primer_promise AND (?primer_return = false)))*/
        return (!GameFlags.P1PrimerPromise && !GameFlags.P1PrimerReturn) || (GameFlags.P1PrimerPromise && !GameFlags.P1PrimerReturn);
        ///METHOD_BODY_END n04_r0_condition
    }

    ///METHOD n04_r1_condition
    public bool n04_r1_condition (  ) {
        ///METHOD_BODY_START n04_r1_condition
        /*//if (?primer_promise = false AND (?primer_return))*/
        return !GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n04_r1_condition
    }

    ///METHOD n04_r2_condition
    public bool n04_r2_condition (  ) {
        ///METHOD_BODY_START n04_r2_condition
        /*//if (?primer_promise AND (?primer_return))*/
        return GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n04_r2_condition
    }

    ///METHOD n05_r1_condition
    public bool n05_r1_condition (  ) {
        ///METHOD_BODY_START n05_r1_condition
        /*//if (?primer_return)*/
        return GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n05_r1_condition
    }

    ///METHOD n06_r0_condition
    public bool n06_r0_condition (  ) {
        ///METHOD_BODY_START n06_r0_condition
        /*//if (((?primer_promise = false) AND (?primer_return = false)) OR (?primer_promise AND (?primer_return = false)))*/
        return (!GameFlags.P1PrimerPromise && !GameFlags.P1PrimerReturn) || (GameFlags.P1PrimerPromise && !GameFlags.P1PrimerReturn);
        ///METHOD_BODY_END n06_r0_condition
    }

    ///METHOD n06_r1_condition
    public bool n06_r1_condition (  ) {
        ///METHOD_BODY_START n06_r1_condition
        /*//if (?primer_promise = false AND (?primer_return))*/
        return !GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n06_r1_condition
    }

    ///METHOD n06_r2_condition
    public bool n06_r2_condition (  ) {
        ///METHOD_BODY_START n06_r2_condition
        /*//if (?primer_promise AND (?primer_return))*/
        return GameFlags.P1PrimerPromise && GameFlags.P1PrimerReturn;
        ///METHOD_BODY_END n06_r2_condition
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//set ?sar_mad = true*/
        GameFlags.P1SarMad = true;
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n05_r2_select
    public void n05_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r2_select
        /*//$next_state = "lose_sar"*/
        ///METHOD_BODY_END n05_r2_select
    }
}
//CLASS_END Dialog_p1_sar_002
