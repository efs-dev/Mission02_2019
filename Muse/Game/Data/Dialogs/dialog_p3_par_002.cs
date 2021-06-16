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
//CLASS Dialog_p3_par_002
public class Dialog_p3_par_002 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _p3_ask_cart
        private bool _p3_ask_cart = false;

        //PROPERTY p3_ask_cart
        public bool p3_ask_cart {
                get {
                        ///PROPERTY_GETTER_START p3_ask_cart
                        return _p3_ask_cart;
                        ///PROPERTY_GETTER_END p3_ask_cart
                }
                set {
                        ///PROPERTY_SETTER_START p3_ask_cart
                        _p3_ask_cart = value;
                        ///PROPERTY_SETTER_END p3_ask_cart
                }
        }

        //PROPERTY _p3_ask_paper
        private bool _p3_ask_paper = false;

        //PROPERTY p3_ask_paper
        public bool p3_ask_paper {
                get {
                        ///PROPERTY_GETTER_START p3_ask_paper
                        return _p3_ask_paper;
                        ///PROPERTY_GETTER_END p3_ask_paper
                }
                set {
                        ///PROPERTY_SETTER_START p3_ask_paper
                        _p3_ask_paper = value;
                        ///PROPERTY_SETTER_END p3_ask_paper
                }
        }
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
        ///DIALOG_ID p3_par_002
        var dialog = new Dialog();
        dialog.Id = "p3_par_002";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n00
        node = dialog.CreateNode("n00");
        ///NODE_NPC n00 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n00 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n00 Full
        ///NODE_VISUAL_USESCRIPT n00 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n00~|||~
        ///PROMPT n00 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n00 0 Right now we need to make a plan for moving Henry. Mr. Parker?\n
        prompt.Text = "Right now we need to make a plan for moving Henry. Mr. Parker?\n";
        ///PROMPT_IGNORE_VO n00 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n00_p0_show);
        
        ///RESPONSE n00 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n00 0 Can we talk about my family after?\n
        response.Text = "Can we talk about my family after?\n";
        ///RESPONSE_NEXT_NODE_TYPE n00 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n00 0 n23
        response.NextNodeId = "n23";
        
        ///RESPONSE n00 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n00 1 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n00 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n00 1 n01
        response.NextNodeId = "n01";
        
        ///NODE_END n00
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
        ///PROMPT_TEXT n01 0 Here's how I see it...\n
        prompt.Text = "Here's how I see it...\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Excuse me, Mr. Parker, but I found this paper with Henry's name on it... \n
        response.Text = "Excuse me, Mr. Parker, but I found this paper with Henry's name on it... \n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n20
        response.NextNodeId = "n20";
        response.SetCondition(n01_r0_condition);
        response.OnSelect(n01_r0_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
        response.NextNodeId = "n02";
        response.SetCondition(n01_r1_condition);
        
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
        ///PROMPT_TEXT n02 0 With this paper Lucy found, we have what we need to get Henry moved and give Bercham a lesson.\n
        prompt.Text = "With this paper Lucy found, we have what we need to get Henry moved and give Bercham a lesson.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 How can we move Henry with his injuries?\n
        response.Text = "How can we move Henry with his injuries?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n04
        response.NextNodeId = "n04";
        response.OnSelect(n02_r0_select);
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 You mean he can't take Henry without that paper?\n
        response.Text = "You mean he can't take Henry without that paper?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n03
        response.NextNodeId = "n03";
        response.OnSelect(n02_r1_select);
        
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
        ///PROMPT_TEXT n03 0 He probably could. But the sheriff is friendly to our cause and can demand Bercham's proof before he takes Henry. And now we have his proof.\n
        prompt.Text = "He probably could. But the sheriff is friendly to our cause and can demand Bercham's proof before he takes Henry. And now we have his proof.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 [Wait]
        response.Text = "[Wait]";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n09
        response.NextNodeId = "n09";
        response.SetCondition(n03_r0_condition);
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 How can we move Henry with his bad leg?\n
        response.Text = "How can we move Henry with his bad leg?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n04
        response.NextNodeId = "n04";
        response.SetCondition(n03_r1_condition);
        response.OnSelect(n03_r1_select);
        
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
        ///PROMPT_TEXT n04 0 Did you know that cart of yours has a hollow bottom? Wouldn't be the first time it moved more than laundry.\n
        prompt.Text = "Did you know that cart of yours has a hollow bottom? Wouldn't be the first time it moved more than laundry.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 [Wait]
        response.Text = "[Wait]";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n09
        response.NextNodeId = "n09";
        response.SetCondition(n04_r0_condition);
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 And Bercham can't stop us without that paper?\n
        response.Text = "And Bercham can't stop us without that paper?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n03
        response.NextNodeId = "n03";
        response.SetCondition(n04_r1_condition);
        response.OnSelect(n04_r1_select);
        
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
        ///PROMPT_TEXT n05 0 Exactly.\n
        prompt.Text = "Exactly.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 It seems dangerous to anger Mr. Bercham on purpose.\n
        response.Text = "It seems dangerous to anger Mr. Bercham on purpose.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        response.OnSelect(n05_r0_select);
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 I like that plan.\n
        response.Text = "I like that plan.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n06
        response.NextNodeId = "n06";
        
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
        ///PROMPT_TEXT n06 0 If I may, Mr. Parker. It sounds dangerous. Would it not be safer to only use the affidavit if Bercham discovers us?\n
        prompt.Text = "If I may, Mr. Parker. It sounds dangerous. Would it not be safer to only use the affidavit if Bercham discovers us?\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n08
        response.NextNodeId = "n08";
        
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
        ///PROMPT_TEXT n07 0 [He and Miss Hatcher both nod.] Yes, perhaps we should try and move Henry quietly and use the affidavit as a backup.\n
        prompt.Text = "[He and Miss Hatcher both nod.] Yes, perhaps we should try and move Henry quietly and use the affidavit as a backup.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n10
        response.NextNodeId = "n10";
        
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
        ///PROMPT_TEXT n08 0 You are right, Miss Hatcher. I was letting my dislike of Bercham get the better of my judgement.\n
        prompt.Text = "You are right, Miss Hatcher. I was letting my dislike of Bercham get the better of my judgement.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 Don't you see? We set Bercham up. Make him think he's caught us red-handed but then he won't be able to do a darn thing.
        prompt.Text = "Don't you see? We set Bercham up. Make him think he's caught us red-handed but then he won't be able to do a darn thing.";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 So we let Mr. Bercham catch us moving Henry?
        response.Text = "So we let Mr. Bercham catch us moving Henry?";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n09
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
        ///PROMPT_TEXT n10 0 [Parker looks at you a moment.] You are both right. I was letting my dislike of Bercham get the better of my judgement.\n
        prompt.Text = "[Parker looks at you a moment.] You are both right. I was letting my dislike of Bercham get the better of my judgement.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 [More...]\n
        response.Text = "[More...]\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n11
        response.NextNodeId = "n11";
        
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
        ///PROMPT_TEXT n11 0 Not only was my idea riskier, but it might have revealed the secret of the cart, which has proven most useful. Let us choose ###smartword|prudence|PRUDENCE###.\n
        prompt.Text = "Not only was my idea riskier, but it might have revealed the secret of the cart, which has proven most useful. Let us choose ###smartword|prudence|PRUDENCE###.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n25
        response.NextNodeId = "n25";
        
        ///NODE_END n11
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 
        prompt.Text = "";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 What does it mean?\n
        response.Text = "What does it mean?\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n21
        response.NextNodeId = "n21";
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 It means you may have solved our problem.\n
        prompt.Text = "It means you may have solved our problem.\n";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n21_p0_show);
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 I have?\n
        response.Text = "I have?\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n22
        response.NextNodeId = "n22";
        
        ///NODE_END n21
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Full
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n22~|||~
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 Yes. It's exactly what we need to get Henry moved and give Bercham a lesson.\n
        prompt.Text = "Yes. It's exactly what we need to get Henry moved and give Bercham a lesson.\n";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 You mean he can't take Henry without that paper?\n
        response.Text = "You mean he can't take Henry without that paper?\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n03
        response.NextNodeId = "n03";
        response.OnSelect(n22_r0_select);
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 Yes, Lucy, that is certainly still on all of our minds. \n
        prompt.Text = "Yes, Lucy, that is certainly still on all of our minds. \n";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 Thank you.\n
        response.Text = "Thank you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n24
        response.NextNodeId = "n24";
        
        ///NODE_END n23
        ///NODE_START n24
        node = dialog.CreateNode("n24");
        ///NODE_NPC n24 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n24 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24 Full
        ///NODE_VISUAL_USESCRIPT n24 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n24~|||~
        ///PROMPT n24 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24 0 What are your thoughts on Henry, Mr. Parker?\n
        prompt.Text = "What are your thoughts on Henry, Mr. Parker?\n";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 n01
        response.NextNodeId = "n01";
        
        ///NODE_END n24
        ///NODE_START n25
        node = dialog.CreateNode("n25");
        ///NODE_NPC n25 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n25 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n25 Full
        ///NODE_VISUAL_USESCRIPT n25 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n25~|||~
        ///PROMPT n25 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n25 0 [The group talks for a few more minutes about the details.] Now let us turn our thoughts to Lucy's family.\n
        prompt.Text = "[The group talks for a few more minutes about the details.] Now let us turn our thoughts to Lucy's family.\n";
        ///PROMPT_IGNORE_VO n25 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n25 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 0 What do you think we can do, Aunt Abigail?\n
        response.Text = "What do you think we can do, Aunt Abigail?\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 0 n29
        response.NextNodeId = "n29";
        
        ///RESPONSE n25 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 1 What do you think we can do, Miss Hatcher?\n
        response.Text = "What do you think we can do, Miss Hatcher?\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 1 n26
        response.NextNodeId = "n26";
        response.OnSelect(n25_r1_select);
        
        ///RESPONSE n25 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 2 What do you think we can do, Reverend Rankin?\n
        response.Text = "What do you think we can do, Reverend Rankin?\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 2 n28
        response.NextNodeId = "n28";
        
        ///RESPONSE n25 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 3 What do you think we can do, Mr. Parker?\n
        response.Text = "What do you think we can do, Mr. Parker?\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 3 n27
        response.NextNodeId = "n27";
        response.OnSelect(n25_r3_select);
        
        ///RESPONSE n25 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 4 I am ready to go back and rescue them myself.\n
        response.Text = "I am ready to go back and rescue them myself.\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 4 n30
        response.NextNodeId = "n30";
        response.OnSelect(n25_r4_select);
        
        ///NODE_END n25
        ///NODE_START n26
        node = dialog.CreateNode("n26");
        ///NODE_NPC n26 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n26 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26 Full
        ///NODE_VISUAL_USESCRIPT n26 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n26~|||~
        ///PROMPT n26 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26 0 Buying their freedom would be supporting the system of slavery. Other action must be taken.\n
        prompt.Text = "Buying their freedom would be supporting the system of slavery. Other action must be taken.\n";
        ///PROMPT_IGNORE_VO n26 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n26 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 0 What do you think we can do, Aunt Abigail?\n
        response.Text = "What do you think we can do, Aunt Abigail?\n";
        ///RESPONSE_NEXT_NODE_TYPE n26 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 0 n29
        response.NextNodeId = "n29";
        
        ///RESPONSE n26 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 1 What do you think we can do, Reverend Rankin?\n
        response.Text = "What do you think we can do, Reverend Rankin?\n";
        ///RESPONSE_NEXT_NODE_TYPE n26 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 1 n28
        response.NextNodeId = "n28";
        
        ///RESPONSE n26 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 2 What do you think we can do, Mr. Parker?\n
        response.Text = "What do you think we can do, Mr. Parker?\n";
        ///RESPONSE_NEXT_NODE_TYPE n26 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 2 n27
        response.NextNodeId = "n27";
        
        ///RESPONSE n26 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 3 Then I am ready to go back and rescue them myself.\n
        response.Text = "Then I am ready to go back and rescue them myself.\n";
        ///RESPONSE_NEXT_NODE_TYPE n26 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 3 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n26
        ///NODE_START n27
        node = dialog.CreateNode("n27");
        ///NODE_NPC n27 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n27 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n27 Full
        ///NODE_VISUAL_USESCRIPT n27 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n27~|||~
        ///PROMPT n27 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n27 0 It's too dangerous for us to travel that far south. We must get the word to your family and be ready here to help them across the river.\n
        prompt.Text = "It's too dangerous for us to travel that far south. We must get the word to your family and be ready here to help them across the river.\n";
        ///PROMPT_IGNORE_VO n27 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n27 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n27 0 How will we get word to them?\n
        response.Text = "How will we get word to them?\n";
        ///RESPONSE_NEXT_NODE_TYPE n27 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n27 0 n29
        response.NextNodeId = "n29";
        
        ///NODE_END n27
        ///NODE_START n28
        node = dialog.CreateNode("n28");
        ///NODE_NPC n28 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n28 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n28 Full
        ///NODE_VISUAL_USESCRIPT n28 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n28~|||~
        ///PROMPT n28 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n28 0 Well, I ###smartword|defer|DEFER### to Mr. Parker on this. But I will help in any way that I can.\n
        prompt.Text = "Well, I ###smartword|defer|DEFER### to Mr. Parker on this. But I will help in any way that I can.\n";
        ///PROMPT_IGNORE_VO n28 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n28 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n28 0 What do you think we can do, Mr. Parker?\n
        response.Text = "What do you think we can do, Mr. Parker?\n";
        ///RESPONSE_NEXT_NODE_TYPE n28 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n28 0 n27
        response.NextNodeId = "n27";
        
        ///NODE_END n28
        ///NODE_START n29
        node = dialog.CreateNode("n29");
        ///NODE_NPC n29 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n29 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n29 Full
        ///NODE_VISUAL_USESCRIPT n29 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n29~|||~
        ///PROMPT n29 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n29 0 I know how we can get word to them. Our neighbor works on the river boats. He could get word to a cartman traveling from Maysville to Lexington.\n
        prompt.Text = "I know how we can get word to them. Our neighbor works on the river boats. He could get word to a cartman traveling from Maysville to Lexington.\n";
        ///PROMPT_IGNORE_VO n29 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n29 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n29 0 I'm sorry to ask, but how do you know we can trust him?\n
        response.Text = "I'm sorry to ask, but how do you know we can trust him?\n";
        ///RESPONSE_NEXT_NODE_TYPE n29 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n29 0 n32
        response.NextNodeId = "n32";
        
        ///RESPONSE n29 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n29 1 What will the message be?\n
        response.Text = "What will the message be?\n";
        ///RESPONSE_NEXT_NODE_TYPE n29 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n29 1 n31
        response.NextNodeId = "n31";
        
        ///NODE_END n29
        ///NODE_START n30
        node = dialog.CreateNode("n30");
        ///NODE_NPC n30 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n30 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n30 Full
        ///NODE_VISUAL_USESCRIPT n30 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n30~|||~
        ///PROMPT n30 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n30 0 I'm so sorry, Lucy, but we can't let that happen. It was a miracle that you made it this far. It would be too dangerous for even a man of Mr. Parker's abilities.\n
        prompt.Text = "I'm so sorry, Lucy, but we can't let that happen. It was a miracle that you made it this far. It would be too dangerous for even a man of Mr. Parker's abilities.\n";
        ///PROMPT_IGNORE_VO n30 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n30 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 0 No, I must go back myself. My family needs me. My mama can't do this without me. [Leave.]\n
        response.Text = "No, I must go back myself. My family needs me. My mama can't do this without me. [Leave.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n30 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 0 END
        response.NextNodeId = "END";
        response.OnSelect(n30_r0_select);
        
        ///RESPONSE n30 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 1 Then what do you suggest sir?\n
        response.Text = "Then what do you suggest sir?\n";
        ///RESPONSE_NEXT_NODE_TYPE n30 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 1 n28
        response.NextNodeId = "n28";
        
        ///NODE_END n30
        ///NODE_START n31
        node = dialog.CreateNode("n31");
        ///NODE_NPC n31 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n31 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n31 Full
        ///NODE_VISUAL_USESCRIPT n31 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n31~|||~
        ///PROMPT n31 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n31 0 They need to find their way to the Negro church in Lexington. Someone there can disguise Jonah and start him along the ###smartword|Underground Railroad|UNDERGROUNDRAILROAD###.\n
        prompt.Text = "They need to find their way to the Negro church in Lexington. Someone there can disguise Jonah and start him along the ###smartword|Underground Railroad|UNDERGROUNDRAILROAD###.\n";
        ///PROMPT_IGNORE_VO n31 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n31 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 0 And that will even get them across the river?\n
        response.Text = "And that will even get them across the river?\n";
        ///RESPONSE_NEXT_NODE_TYPE n31 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 0 n34
        response.NextNodeId = "n34";
        
        ///RESPONSE n31 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 1 I didn't see anything like that when I ran away.\n
        response.Text = "I didn't see anything like that when I ran away.\n";
        ///RESPONSE_NEXT_NODE_TYPE n31 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 1 n33
        response.NextNodeId = "n33";
        
        ///RESPONSE n31 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 2 There's a train for escaped slaves?\n
        response.Text = "There's a train for escaped slaves?\n";
        ///RESPONSE_NEXT_NODE_TYPE n31 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 2 n33
        response.NextNodeId = "n33";
        
        ///NODE_END n31
        ///NODE_START n32
        node = dialog.CreateNode("n32");
        ///NODE_NPC n32 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n32 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n32 Full
        ///NODE_VISUAL_USESCRIPT n32 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n32~|||~
        ///PROMPT n32 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n32 0 He has taken messages before for me. None have been this important or had to go so far, but I truly trust him.\n
        prompt.Text = "He has taken messages before for me. None have been this important or had to go so far, but I truly trust him.\n";
        ///PROMPT_IGNORE_VO n32 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n32 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n32 0 I'm sorry. I trust you, but I need to go myself. My mama can't do this without me. [Leave]\n
        response.Text = "I'm sorry. I trust you, but I need to go myself. My mama can't do this without me. [Leave]\n";
        ///RESPONSE_NEXT_NODE_TYPE n32 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n32 0 END
        response.NextNodeId = "END";
        response.OnSelect(n32_r0_select);
        
        ///RESPONSE n32 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n32 1 Very well. What will the message be then?\n
        response.Text = "Very well. What will the message be then?\n";
        ///RESPONSE_NEXT_NODE_TYPE n32 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n32 1 n31
        response.NextNodeId = "n31";
        
        ///NODE_END n32
        ///NODE_START n33
        node = dialog.CreateNode("n33");
        ///NODE_NPC n33 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n33 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n33 Full
        ///NODE_VISUAL_USESCRIPT n33 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n33~|||~
        ///PROMPT n33 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n33 0 The Railroad has no rails or trains. It is the name for all the brave people who help slaves escape. Each member passes a slave a little further north.\n
        prompt.Text = "The Railroad has no rails or trains. It is the name for all the brave people who help slaves escape. Each member passes a slave a little further north.\n";
        ///PROMPT_IGNORE_VO n33 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n33 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n33 0 And how will they get across the Ohio River?
        response.Text = "And how will they get across the Ohio River?";
        ///RESPONSE_NEXT_NODE_TYPE n33 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n33 0 n34
        response.NextNodeId = "n34";
        
        ///RESPONSE n33 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n33 1 A slave at my plantation, Esther, told me to go to Lexington. I didn't. But I wonder if that was on the Railroad.\n
        response.Text = "A slave at my plantation, Esther, told me to go to Lexington. I didn't. But I wonder if that was on the Railroad.\n";
        ///RESPONSE_NEXT_NODE_TYPE n33 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n33 1 n40
        response.NextNodeId = "n40";
        response.SetCondition(n33_r1_condition);
        
        ///RESPONSE n33 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n33 2 I think I was on it. Esther, at my plantation, told me to go to Lexington and I was put on a wagon.\n
        response.Text = "I think I was on it. Esther, at my plantation, told me to go to Lexington and I was put on a wagon.\n";
        ///RESPONSE_NEXT_NODE_TYPE n33 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n33 2 n40
        response.NextNodeId = "n40";
        response.SetCondition(n33_r2_condition);
        
        ///NODE_END n33
        ///NODE_START n34
        node = dialog.CreateNode("n34");
        ///NODE_NPC n34 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n34 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n34 Full
        ///NODE_VISUAL_USESCRIPT n34 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n34~|||~
        ///PROMPT n34 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n34 0 I will be waiting to row them across.\n
        prompt.Text = "I will be waiting to row them across.\n";
        ///PROMPT_IGNORE_VO n34 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n34 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n34 0 I hope this works. \n
        response.Text = "I hope this works. \n";
        ///RESPONSE_NEXT_NODE_TYPE n34 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n34 0 n37
        response.NextNodeId = "n37";
        
        ///RESPONSE n34 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n34 1 Can I come with you?\n
        response.Text = "Can I come with you?\n";
        ///RESPONSE_NEXT_NODE_TYPE n34 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n34 1 n36
        response.NextNodeId = "n36";
        
        ///RESPONSE n34 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n34 2 So you are part of the Underground Railroad too?\n
        response.Text = "So you are part of the Underground Railroad too?\n";
        ///RESPONSE_NEXT_NODE_TYPE n34 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n34 2 n35
        response.NextNodeId = "n35";
        
        ///NODE_END n34
        ///NODE_START n35
        node = dialog.CreateNode("n35");
        ///NODE_NPC n35 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n35 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n35 Full
        ///NODE_VISUAL_USESCRIPT n35 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n35~|||~
        ///PROMPT n35 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n35 0 Yes. We all help in different ways.\n
        prompt.Text = "Yes. We all help in different ways.\n";
        ///PROMPT_IGNORE_VO n35 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n35 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n35 0 I hope this works. \n
        response.Text = "I hope this works. \n";
        ///RESPONSE_NEXT_NODE_TYPE n35 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n35 0 n37
        response.NextNodeId = "n37";
        
        ///RESPONSE n35 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n35 1 Can I help?\n
        response.Text = "Can I help?\n";
        ///RESPONSE_NEXT_NODE_TYPE n35 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n35 1 n36
        response.NextNodeId = "n36";
        
        ///NODE_END n35
        ///NODE_START n36
        node = dialog.CreateNode("n36");
        ///NODE_NPC n36 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n36 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n36 Full
        ///NODE_VISUAL_USESCRIPT n36 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n36~|||~
        ///PROMPT n36 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n36 0 I have a feeling you'll be a ###smartword|conductor|CONDUCTOR### on the Railroad soon enough. But not this time. First I'll need to teach you how to handle a gun and row a boat against the current.\n
        prompt.Text = "I have a feeling you'll be a ###smartword|conductor|CONDUCTOR### on the Railroad soon enough. But not this time. First I'll need to teach you how to handle a gun and row a boat against the current.\n";
        ///PROMPT_IGNORE_VO n36 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n36 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n36 0 I don't want to shoot anybody and I can't swim. Perhaps I should finish my reading and writing studies first. \n
        response.Text = "I don't want to shoot anybody and I can't swim. Perhaps I should finish my reading and writing studies first. \n";
        ///RESPONSE_NEXT_NODE_TYPE n36 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n36 0 n38
        response.NextNodeId = "n38";
        response.OnSelect(n36_r0_select);
        
        ///RESPONSE n36 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n36 1 I will be a willing student. I hope this plan works.\n
        response.Text = "I will be a willing student. I hope this plan works.\n";
        ///RESPONSE_NEXT_NODE_TYPE n36 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n36 1 n37
        response.NextNodeId = "n37";
        response.OnSelect(n36_r1_select);
        
        ///NODE_END n36
        ///NODE_START n37
        node = dialog.CreateNode("n37");
        ///NODE_NPC n37 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n37 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n37 Full
        ///NODE_VISUAL_USESCRIPT n37 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n37~|||~
        ///PROMPT n37 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n37 0 Hope is one of the most powerful weapons we can have... although I'll still carry my gun just in case. We'll get them back, Lucy.\n
        prompt.Text = "Hope is one of the most powerful weapons we can have... although I'll still carry my gun just in case. We'll get them back, Lucy.\n";
        ///PROMPT_IGNORE_VO n37 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n37 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n37 0 Thank you, Mr. Parker.\n
        response.Text = "Thank you, Mr. Parker.\n";
        ///RESPONSE_NEXT_NODE_TYPE n37 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n37 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n37
        ///NODE_START n38
        node = dialog.CreateNode("n38");
        ///NODE_NPC n38 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n38 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n38 Full
        ///NODE_VISUAL_USESCRIPT n38 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n38~|||~
        ///PROMPT n38 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n38 0 Your words will be powerful weapons Lucy. I will be glad to have them in the fight ahead.\n
        prompt.Text = "Your words will be powerful weapons Lucy. I will be glad to have them in the fight ahead.\n";
        ///PROMPT_IGNORE_VO n38 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n38 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n38 0 Thank you, Miss Hatcher.\n
        response.Text = "Thank you, Miss Hatcher.\n";
        ///RESPONSE_NEXT_NODE_TYPE n38 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n38 0 n39
        response.NextNodeId = "n39";
        
        ///NODE_END n38
        ///NODE_START n39
        node = dialog.CreateNode("n39");
        ///NODE_NPC n39 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n39 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n39 Full
        ///NODE_VISUAL_USESCRIPT n39 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n39~|||~
        ///PROMPT n39 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n39 0 Miss Hatcher is right. But I'll still carry my gun just in case. We'll get them back Lucy.\n
        prompt.Text = "Miss Hatcher is right. But I'll still carry my gun just in case. We'll get them back Lucy.\n";
        ///PROMPT_IGNORE_VO n39 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n39 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n39 0 Thank you, Mr. Parker.\n
        response.Text = "Thank you, Mr. Parker.\n";
        ///RESPONSE_NEXT_NODE_TYPE n39 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n39 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n39
        ///NODE_START n40
        node = dialog.CreateNode("n40");
        ///NODE_NPC n40 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n40 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n40 Full
        ///NODE_VISUAL_USESCRIPT n40 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n40~|||~
        ///PROMPT n40 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n40 0 It sounds like it.\n
        prompt.Text = "It sounds like it.\n";
        ///PROMPT_IGNORE_VO n40 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n40 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n40 0 How will they get across the river?\n
        response.Text = "How will they get across the river?\n";
        ///RESPONSE_NEXT_NODE_TYPE n40 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n40 0 n34
        response.NextNodeId = "n34";
        
        ///NODE_END n40
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n00_p0_show
    public void n00_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n00_p0_show
        /*//showNpc( true, 1 )
        //showNpc( true, 2 )
        //showNpc( true, 3 )
        //showNpc( true, 4 )*/
        ///METHOD_BODY_END n00_p0_show
    }

    ///METHOD n21_p0_show
    public void n21_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n21_p0_show
        /*//setLayer("fg", "")*/
        ///METHOD_BODY_END n21_p0_show
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if (?p3_aff_read = false)*/
        return !GameFlags.P3AffRead;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if (?p3_aff_read = true)*/
        return GameFlags.P3AffRead;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD n03_r0_condition
    public bool n03_r0_condition (  ) {
        ///METHOD_BODY_START n03_r0_condition
        /*//if (?p3_ask_cart = true)*/
        return DialogGameFlags.p3_ask_cart;
        ///METHOD_BODY_END n03_r0_condition
    }

    ///METHOD n03_r1_condition
    public bool n03_r1_condition (  ) {
        ///METHOD_BODY_START n03_r1_condition
        /*//if (?p3_ask_cart = false)*/
        return !DialogGameFlags.p3_ask_cart;
        ///METHOD_BODY_END n03_r1_condition
    }

    ///METHOD n04_r0_condition
    public bool n04_r0_condition (  ) {
        ///METHOD_BODY_START n04_r0_condition
        /*//if (?p3_ask_paper = true)*/
        return DialogGameFlags.p3_ask_paper;
        ///METHOD_BODY_END n04_r0_condition
    }

    ///METHOD n04_r1_condition
    public bool n04_r1_condition (  ) {
        ///METHOD_BODY_START n04_r1_condition
        /*//if (?p3_ask_paper = false)*/
        return !DialogGameFlags.p3_ask_paper;
        ///METHOD_BODY_END n04_r1_condition
    }

    ///METHOD n33_r1_condition
    public bool n33_r1_condition (  ) {
        ///METHOD_BODY_START n33_r1_condition
        /*//if ((?know_lexington = true) AND (?p2_lucy_escape_lex = false))*/
        return GameFlags.P1KnowLexington && !GameFlags.P2LucyEscapeLex;
        ///METHOD_BODY_END n33_r1_condition
    }

    ///METHOD n33_r2_condition
    public bool n33_r2_condition (  ) {
        ///METHOD_BODY_START n33_r2_condition
        /*//if (?p2_lucy_escape_lex = true)*/
        return GameFlags.P2LucyEscapeLex;
        ///METHOD_BODY_END n33_r2_condition
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//#par_points = #par_points + 1
        //updateMessage ("This helps earn the Parker's Ally Badge.")*/
        GameFlags.P3ParPoints++;
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n02_r0_select
    public void n02_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r0_select
        /*//set ?p3_ask_cart = true*/
        DialogGameFlags.p3_ask_cart = true;
        ///METHOD_BODY_END n02_r0_select
    }

    ///METHOD n02_r1_select
    public void n02_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r1_select
        /*//set ?p3_ask_paper = true*/
        DialogGameFlags.p3_ask_paper = true;
        ///METHOD_BODY_END n02_r1_select
    }

    ///METHOD n03_r1_select
    public void n03_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r1_select
        /*//set ?p3_ask_cart = true*/
        DialogGameFlags.p3_ask_cart = true;
        ///METHOD_BODY_END n03_r1_select
    }

    ///METHOD n04_r1_select
    public void n04_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n04_r1_select
        /*//set ?p3_ask_paper = true*/
        DialogGameFlags.p3_ask_paper = true;
        ///METHOD_BODY_END n04_r1_select
    }

    ///METHOD n05_r0_select
    public void n05_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r0_select
        /*//set ?p3_lucy_cautious=true
        //#par_points = #par_points + 1
        //#mil_points = #mil_points + 1
        //updateMessage ("Parker's opinion of you improves.")
        //updateMessage ("Millie's opinion of you improves.")*/
        GameFlags.P3LucyCautious = true;
        GameFlags.P3ParPoints++;
        GameFlags.P3MilPoints++;
        ///METHOD_BODY_END n05_r0_select
    }

    ///METHOD n22_r0_select
    public void n22_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n22_r0_select
        /*//set ?p3_ask_paper = true*/
        DialogGameFlags.p3_ask_paper = true;
        ///METHOD_BODY_END n22_r0_select
    }

    ///METHOD n25_r1_select
    public void n25_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n25_r1_select
        /*//#mil_points = #mil_points + 1
        //updateMessage ("Millie's opinion of you improves.")*/
        GameFlags.P3MilPoints++;
        ///METHOD_BODY_END n25_r1_select
    }

    ///METHOD n25_r3_select
    public void n25_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n25_r3_select
        /*//#par_points = #par_points + 1
        //updateMessage ("Parker's opinion of you improves.")*/
        GameFlags.P3ParPoints++;
        ///METHOD_BODY_END n25_r3_select
    }

    ///METHOD n25_r4_select
    public void n25_r4_select ( DialogResponse response ) {
        ///METHOD_BODY_START n25_r4_select
        /*//?p3_lucy_self_reliant = true*/
        GameFlags.P3LucySelfReliant = true;
        ///METHOD_BODY_END n25_r4_select
    }

    ///METHOD n30_r0_select
    public void n30_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n30_r0_select
        /*//$next_state = "LOSE_PAR_002"*/
        GameFlags.P3LosePar002 = true;
        ///METHOD_BODY_END n30_r0_select
    }

    ///METHOD n32_r0_select
    public void n32_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n32_r0_select
        /*//$next_state = "LOSE_PAR_002"*/
        GameFlags.P3LosePar002 = true;
        ///METHOD_BODY_END n32_r0_select
    }

    ///METHOD n36_r0_select
    public void n36_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n36_r0_select
        /*//#mil_points = #mil_points + 1
        //?p3_choose_reading = true
        //updateMessage ("Millie's opinion of you improves.")
        //updateMessage ("This helps improve your reading.")*/
        GameFlags.P3ChooseReading = true;
        GameFlags.P3MilPoints++;
        ///METHOD_BODY_END n36_r0_select
    }

    ///METHOD n36_r1_select
    public void n36_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n36_r1_select
        /*//?p3_parkers_promise = true
        //#par_points = #par_points + 1
        //updateMessage ("Parker's opinion of you improves.")*/
        GameFlags.P3ParkersPromise = true;
        GameFlags.P3ParPoints++;
        ///METHOD_BODY_END n36_r1_select
    }
}
//CLASS_END Dialog_p3_par_002
