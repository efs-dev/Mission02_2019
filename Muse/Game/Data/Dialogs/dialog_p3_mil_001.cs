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
//CLASS Dialog_p3_mil_001
public class Dialog_p3_mil_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _p3_ask_millie_help
        private bool _p3_ask_millie_help = false;

        //PROPERTY p3_ask_millie_help
        public bool p3_ask_millie_help {
                get {
                        ///PROPERTY_GETTER_START p3_ask_millie_help
                        return _p3_ask_millie_help;
                        ///PROPERTY_GETTER_END p3_ask_millie_help
                }
                set {
                        ///PROPERTY_SETTER_START p3_ask_millie_help
                        _p3_ask_millie_help = value;
                        ///PROPERTY_SETTER_END p3_ask_millie_help
                }
        }

        //PROPERTY _p3_kerchief_done
        private bool _p3_kerchief_done = false;

        //PROPERTY p3_kerchief_done
        public bool p3_kerchief_done {
                get {
                        ///PROPERTY_GETTER_START p3_kerchief_done
                        return _p3_kerchief_done;
                        ///PROPERTY_GETTER_END p3_kerchief_done
                }
                set {
                        ///PROPERTY_SETTER_START p3_kerchief_done
                        _p3_kerchief_done = value;
                        ///PROPERTY_SETTER_END p3_kerchief_done
                }
        }

        //PROPERTY _p3_millie_laundry
        private bool _p3_millie_laundry = false;

        //PROPERTY p3_millie_laundry
        public bool p3_millie_laundry {
                get {
                        ///PROPERTY_GETTER_START p3_millie_laundry
                        return _p3_millie_laundry;
                        ///PROPERTY_GETTER_END p3_millie_laundry
                }
                set {
                        ///PROPERTY_SETTER_START p3_millie_laundry
                        _p3_millie_laundry = value;
                        ///PROPERTY_SETTER_END p3_millie_laundry
                }
        }

        //PROPERTY _p3_millie_lesson_offer
        private bool _p3_millie_lesson_offer = false;

        //PROPERTY p3_millie_lesson_offer
        public bool p3_millie_lesson_offer {
                get {
                        ///PROPERTY_GETTER_START p3_millie_lesson_offer
                        return _p3_millie_lesson_offer;
                        ///PROPERTY_GETTER_END p3_millie_lesson_offer
                }
                set {
                        ///PROPERTY_SETTER_START p3_millie_lesson_offer
                        _p3_millie_lesson_offer = value;
                        ///PROPERTY_SETTER_END p3_millie_lesson_offer
                }
        }

        //PROPERTY _p3_seen_stowe_letter
        private bool _p3_seen_stowe_letter = false;

        //PROPERTY p3_seen_stowe_letter
        public bool p3_seen_stowe_letter {
                get {
                        ///PROPERTY_GETTER_START p3_seen_stowe_letter
                        return _p3_seen_stowe_letter;
                        ///PROPERTY_GETTER_END p3_seen_stowe_letter
                }
                set {
                        ///PROPERTY_SETTER_START p3_seen_stowe_letter
                        _p3_seen_stowe_letter = value;
                        ///PROPERTY_SETTER_END p3_seen_stowe_letter
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
        ///DIALOG_ID p3_mil_001
        var dialog = new Dialog();
        dialog.Id = "p3_mil_001";
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
        ///PROMPT_TEXT n01 0 You must be Lucy. Your aunt told me that I might meet you soon.\n
        prompt.Text = "You must be Lucy. Your aunt told me that I might meet you soon.\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Give her the boxes.] My aunt asked me to give you these handkerchiefs for the fundraiser.\n
        response.Text = "[Give her the boxes.] My aunt asked me to give you these handkerchiefs for the fundraiser.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n40
        response.NextNodeId = "n40";
        response.OnSelect(n01_r0_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Yes ma'am. My aunt told me about you too. She says you raise money to help runaway slaves. I need help for my family.\n
        response.Text = "Yes ma'am. My aunt told me about you too. She says you raise money to help runaway slaves. I need help for my family.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n03
        response.NextNodeId = "n03";
        response.SetCondition(n01_r1_condition);
        response.OnSelect(n01_r1_select);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Yes, ma'am. My uncle is away. I'm here to pick up your laundry.\n
        response.Text = "Yes, ma'am. My uncle is away. I'm here to pick up your laundry.\n";
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
        ///PROMPT_TEXT n02 0 Yes, of course. It's in the back room.\n
        prompt.Text = "Yes, of course. It's in the back room.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n02_p0_show);
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 [Go to the back room.]\n
        response.Text = "[Go to the back room.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n05
        response.NextNodeId = "n05";
        response.OnSelect(n02_r1_select);
        
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
        ///PROMPT_TEXT n03 0 You get right to the point. I like that. Where is your family?\n
        prompt.Text = "You get right to the point. I like that. Where is your family?\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n03_p0_show);
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 On the King Plantation near Lexington. Reverend Rankin heard they're to be sold. I don't know what to do.\n
        response.Text = "On the King Plantation near Lexington. Reverend Rankin heard they're to be sold. I don't know what to do.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n04
        response.NextNodeId = "n04";
        
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
        ///PROMPT_TEXT n04 0 Oh, I see. So they have not yet made it to Ripley.\n
        prompt.Text = "Oh, I see. So they have not yet made it to Ripley.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 No. I was hoping we could buy their freedom.\n
        response.Text = "No. I was hoping we could buy their freedom.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n14
        response.NextNodeId = "n14";
        
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
        ///PROMPT_TEXT n05 0 [You go to the back room. There is a basket full of laundry and a desk with many books.]\n
        prompt.Text = "[You go to the back room. There is a basket full of laundry and a desk with many books.]\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 [Look around.]\n
        response.Text = "[Look around.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 [Pick up laundry and go back out.]\n
        response.Text = "[Pick up laundry and go back out.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n11
        response.NextNodeId = "n11";
        response.OnSelect(n05_r1_select);
        
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
        ///PROMPT_TEXT n06 0 Do you need me to show you the way? Follow me.\n
        prompt.Text = "Do you need me to show you the way? Follow me.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [Follow her.]\n
        response.Text = "[Follow her.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n10
        response.NextNodeId = "n10";
        response.OnSelect(n06_r0_select);
        
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
        ///PROMPT_TEXT n07 0 [The room is furnished simply. There is a half-written letter on the desk.]\n
        prompt.Text = "[The room is furnished simply. There is a half-written letter on the desk.]\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 [Look at the letter.]\n
        response.Text = "[Look at the letter.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        response.OnSelect(n07_r0_select);
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 [Pick up laundry and go back out.]\n
        response.Text = "[Pick up laundry and go back out.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n11
        response.NextNodeId = "n11";
        response.OnSelect(n07_r1_select);
        
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
        ///PROMPT_TEXT n08 0 [You hear Miss Hatcher walking in.]
        prompt.Text = "[You hear Miss Hatcher walking in.]";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 [Keep holding the letter.]
        response.Text = "[Keep holding the letter.]";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n09
        response.NextNodeId = "n09";
        response.OnSelect(n08_r0_select);
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 [Try and put the letter back.]\n
        response.Text = "[Try and put the letter back.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n09
        response.NextNodeId = "n09";
        response.OnSelect(n08_r1_select);
        
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
        ///PROMPT_TEXT n09 0 Did you find it Lucy? Oh, I see...\n
        prompt.Text = "Did you find it Lucy? Oh, I see...\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n09_p0_show);
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 I'm sorry Miss Hatcher. Mama used to tell me I got to mind my own business. I'll get your laundry and go.\n
        response.Text = "I'm sorry Miss Hatcher. Mama used to tell me I got to mind my own business. I'll get your laundry and go.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n13
        response.NextNodeId = "n13";
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 I'm sorry Miss Hatcher. Please don't be mad. I've never seen so many books. I wish I could write like you.\n
        response.Text = "I'm sorry Miss Hatcher. Please don't be mad. I've never seen so many books. I wish I could write like you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n12
        response.NextNodeId = "n12";
        
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
        ///PROMPT_TEXT n10 0 [You go to the back room. There is a neatly stacked pile of laundry. There is also a writing desk with many books.]\n
        prompt.Text = "[You go to the back room. There is a neatly stacked pile of laundry. There is also a writing desk with many books.]\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I've never seen so many books, Miss Hatcher.\n
        response.Text = "I've never seen so many books, Miss Hatcher.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 [Pick up laundry and go back out.]\n
        response.Text = "[Pick up laundry and go back out.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n11
        response.NextNodeId = "n11";
        response.OnSelect(n10_r1_select);
        
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
        ///PROMPT_TEXT n11 0 I hope to see you soon.\n
        prompt.Text = "I hope to see you soon.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n11 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 1 I hope to see you soon. Perhaps you'd like to visit me at the Red Oak School. I can help you with your letters.\n
        prompt.Text = "I hope to see you soon. Perhaps you'd like to visit me at the Red Oak School. I can help you with your letters.\n";
        ///PROMPT_IGNORE_VO n11 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n11_p1_condition);
        prompt.OnShow(n11_p1_show);
        
        ///PROMPT n11 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 2 Did your aunt have anything for you to give to me?\n
        prompt.Text = "Did your aunt have anything for you to give to me?\n";
        ///PROMPT_IGNORE_VO n11 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n11_p2_condition);
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 I do as well. Good day.\n
        response.Text = "I do as well. Good day.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 END
        response.NextNodeId = "END";
        response.SetCondition(n11_r0_condition);
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 Yes, I have these handkerchiefs for the fundraiser [give her the boxes].\n
        response.Text = "Yes, I have these handkerchiefs for the fundraiser [give her the boxes].\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n40
        response.NextNodeId = "n40";
        response.SetCondition(n11_r1_condition);
        response.OnSelect(n11_r1_select);
        
        ///RESPONSE n11 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 2 Thank you, but I'm learning well enough on my own.\n
        response.Text = "Thank you, but I'm learning well enough on my own.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 2 n34
        response.NextNodeId = "n34";
        response.SetCondition(n11_r2_condition);
        
        ///RESPONSE n11 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 3 Thank you. I'll ask Aunt Abigail if that's okay with her.\n
        response.Text = "Thank you. I'll ask Aunt Abigail if that's okay with her.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 3 n33
        response.NextNodeId = "n33";
        response.SetCondition(n11_r3_condition);
        response.OnSelect(n11_r3_select);
        
        ///RESPONSE n11 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 4 Thank you, I'd like that. I need to learn to read better.\n
        response.Text = "Thank you, I'd like that. I need to learn to read better.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 4 n32
        response.NextNodeId = "n32";
        response.SetCondition(n11_r4_condition);
        response.OnSelect(n11_r4_select);
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 The best way I've found to fight slavery is through the power of words.\n
        prompt.Text = "The best way I've found to fight slavery is through the power of words.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 I see. I had better be getting back to work. [Pick up laundry and go outside.]\n
        response.Text = "I see. I had better be getting back to work. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n12_r0_select);
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 I don't mean any disrespect, but it would take more than words to make Master King free us.\n
        response.Text = "I don't mean any disrespect, but it would take more than words to make Master King free us.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n12 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 2 How do you mean?\n
        response.Text = "How do you mean?\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 2 n19
        response.NextNodeId = "n19";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 It's all right, Lucy. It's good that you are interested in reading and writing. Can you read that?\n
        prompt.Text = "It's all right, Lucy. It's good that you are interested in reading and writing. Can you read that?\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 Yes. Your handwriting is pretty.\n
        response.Text = "Yes. Your handwriting is pretty.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n31
        response.NextNodeId = "n31";
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 A little bit. A few words here and there.\n
        response.Text = "A little bit. A few words here and there.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n21a
        response.NextNodeId = "n21a";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 Even if I had that much money, buying their freedom would be supporting the system of slavery. We mustn't give money to our enemies. \n
        prompt.Text = "Even if I had that much money, buying their freedom would be supporting the system of slavery. We mustn't give money to our enemies. \n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 I understand. I better get your laundry now.\n
        response.Text = "I understand. I better get your laundry now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n14_r0_condition);
        
        ///RESPONSE n14 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 1 Is there anyone else who can help me?\n
        response.Text = "Is there anyone else who can help me?\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 1 n17
        response.NextNodeId = "n17";
        
        ///RESPONSE n14 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 2 But it may be too late to do anything else! My mama and brother will be sold south. I'll never see them again!\n
        response.Text = "But it may be too late to do anything else! My mama and brother will be sold south. I'll never see them again!\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 2 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n14
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 Oh Lucy, my heart breaks for them and you. This is why slavery must be ended for everyone. We can't buy what they should already have.\n
        prompt.Text = "Oh Lucy, my heart breaks for them and you. This is why slavery must be ended for everyone. We can't buy what they should already have.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 Is there anyone else who can help me?\n
        response.Text = "Is there anyone else who can help me?\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n17
        response.NextNodeId = "n17";
        
        ///RESPONSE n16 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 1 I'm sorry, Miss Hatcher, but I can only think of my family. I had better get going.\n
        response.Text = "I'm sorry, Miss Hatcher, but I can only think of my family. I had better get going.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 1 n11
        response.NextNodeId = "n11";
        response.SetCondition(n16_r1_condition);
        
        ///RESPONSE n16 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 2 I understand. I had better get going.\n
        response.Text = "I understand. I had better get going.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 2 n11
        response.NextNodeId = "n11";
        response.SetCondition(n16_r2_condition);
        
        ///RESPONSE n16 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 3 I'm sorry, Miss Hatcher, but I can only think of my family. I had better get your laundry now.\n
        response.Text = "I'm sorry, Miss Hatcher, but I can only think of my family. I had better get your laundry now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 3 n02
        response.NextNodeId = "n02";
        response.SetCondition(n16_r3_condition);
        
        ///RESPONSE n16 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 4 I understand. I had better get your laundry now.\n
        response.Text = "I understand. I had better get your laundry now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 4 n02
        response.NextNodeId = "n02";
        response.SetCondition(n16_r4_condition);
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 Have you met John Parker? His methods are, shall we say, more direct. He may have good advice.\n
        prompt.Text = "Have you met John Parker? His methods are, shall we say, more direct. He may have good advice.\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 No, but I am to pick up his laundry too. I will speak with him.\n
        response.Text = "No, but I am to pick up his laundry too. I will speak with him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n18
        response.NextNodeId = "n18";
        response.SetCondition(n17_r0_condition);
        response.OnSelect(n17_r0_select);
        
        ///RESPONSE n17 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 1 Yes, Reverend Rankin told me the same thing. I will speak with him.\n
        response.Text = "Yes, Reverend Rankin told me the same thing. I will speak with him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 1 n18
        response.NextNodeId = "n18";
        response.SetCondition(n17_r1_condition);
        response.OnSelect(n17_r1_select);
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 I wish you good fortune, Lucy.  \n
        prompt.Text = "I wish you good fortune, Lucy.  \n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 Thank you. I had better get going.\n
        response.Text = "Thank you. I had better get going.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n11
        response.NextNodeId = "n11";
        response.SetCondition(n18_r0_condition);
        
        ///RESPONSE n18 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 1 Thank you. I better get your laundry now.\n
        response.Text = "Thank you. I better get your laundry now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 1 n02
        response.NextNodeId = "n02";
        response.SetCondition(n18_r1_condition);
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 I write stories for newspapers about the evils of slavery. When people read them, they may support the abolitionist cause.\n
        prompt.Text = "I write stories for newspapers about the evils of slavery. When people read them, they may support the abolitionist cause.\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 I wish I could do that.\n
        response.Text = "I wish I could do that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 n23
        response.NextNodeId = "n23";
        response.SetCondition(n19_r0_condition);
        
        ///RESPONSE n19 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 1 Can you write about my family? Maybe that will help them.\n
        response.Text = "Can you write about my family? Maybe that will help them.\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 1 n22
        response.NextNodeId = "n22";
        response.SetCondition(n19_r1_condition);
        
        ///RESPONSE n19 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 2 Is that what you're writing now?\n
        response.Text = "Is that what you're writing now?\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 2 n21
        response.NextNodeId = "n21";
        response.SetCondition(n19_r2_condition);
        
        ///NODE_END n19
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 Endling slavery will not be easy.  It will take powerful words to convince people to take action. We must all fight the best way we can.\n
        prompt.Text = "Endling slavery will not be easy.  It will take powerful words to convince people to take action. We must all fight the best way we can.\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 I don't know if I can fight. I am just a girl.\n
        response.Text = "I don't know if I can fight. I am just a girl.\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n52
        response.NextNodeId = "n52";
        
        ///RESPONSE n20 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 1 I will fight it any way I can.\n
        response.Text = "I will fight it any way I can.\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 1 n51
        response.NextNodeId = "n51";
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 No, it is a letter to my friend Harriet Beecher Stowe. She was my teacher back east. Shall I read you what I've written so far?\n
        prompt.Text = "No, it is a letter to my friend Harriet Beecher Stowe. She was my teacher back east. Shall I read you what I've written so far?\n";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 No thank you. I had better be getting back to work. [Pick up laundry and go outside.]\n
        response.Text = "No thank you. I had better be getting back to work. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n21_r0_select);
        
        ///RESPONSE n21 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 1 Yes, I'd like that.\n
        response.Text = "Yes, I'd like that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 1 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n21
        ///NODE_START n21a
        node = dialog.CreateNode("n21a");
        ///NODE_NPC n21a MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n21a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21a Full
        ///NODE_VISUAL_USESCRIPT n21a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21a~|||~
        ///PROMPT n21a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21a 0 It is a letter to my friend Harriet Beecher Stowe. She was my teacher back east. Shall I read you what I've written so far?
        prompt.Text = "It is a letter to my friend Harriet Beecher Stowe. She was my teacher back east. Shall I read you what I've written so far?";
        ///PROMPT_IGNORE_VO n21a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21a 0 No thank you. I had better be getting back to work. [Pick up laundry and go outside.]\n
        response.Text = "No thank you. I had better be getting back to work. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n21a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21a 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n21a_r0_select);
        
        ///RESPONSE n21a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n21a 1 Yes, I'd like that.\n
        response.Text = "Yes, I'd like that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n21a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21a 1 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n21a
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Full
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n22~|||~
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 Perhaps, but it could also put you or even them in danger. I will see what our friends think of the matter.\n
        prompt.Text = "Perhaps, but it could also put you or even them in danger. I will see what our friends think of the matter.\n";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 Thank you. I had better be getting back to work. [Pick up laundry and go outside.]\n
        response.Text = "Thank you. I had better be getting back to work. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n22_r0_select);
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 Perhaps I can teach you to write like that. Will you come by the Red Oak school this week?\n
        prompt.Text = "Perhaps I can teach you to write like that. Will you come by the Red Oak school this week?\n";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n23_p0_show);
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 Thank you, but I'm learning well enough on my own.\n
        response.Text = "Thank you, but I'm learning well enough on my own.\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n34
        response.NextNodeId = "n34";
        
        ///RESPONSE n23 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 1 Thank you. I'll ask Aunt Abigail if that's okay with her.\n
        response.Text = "Thank you. I'll ask Aunt Abigail if that's okay with her.\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 1 n33
        response.NextNodeId = "n33";
        
        ///RESPONSE n23 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 2 Thank you, I'd like that. I need to learn to read and write better.\n
        response.Text = "Thank you, I'd like that. I need to learn to read and write better.\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 2 n32
        response.NextNodeId = "n32";
        response.OnSelect(n23_r2_select);
        
        ///NODE_END n23
        ///NODE_START n30
        node = dialog.CreateNode("n30");
        ///NODE_NPC n30 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n30 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n30 Full
        ///NODE_VISUAL_USESCRIPT n30 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n30~|||~
        ///PROMPT n30 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n30 0 Miss Hatcher starts reading it...\n
        prompt.Text = "Miss Hatcher starts reading it...\n";
        ///PROMPT_IGNORE_VO n30 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n30_p0_show);
        
        ///RESPONSE n30 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 0 You moved here just to help fight slavery?\n
        response.Text = "You moved here just to help fight slavery?\n";
        ///RESPONSE_NEXT_NODE_TYPE n30 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 0 n50
        response.NextNodeId = "n50";
        
        ///RESPONSE n30 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 1 You write very well. All I can do is write my name.\n
        response.Text = "You write very well. All I can do is write my name.\n";
        ///RESPONSE_NEXT_NODE_TYPE n30 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 1 n31
        response.NextNodeId = "n31";
        response.SetCondition(n30_r1_condition);
        response.OnSelect(n30_r1_select);
        
        ///NODE_END n30
        ///NODE_START n31
        node = dialog.CreateNode("n31");
        ///NODE_NPC n31 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n31 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n31 Full
        ///NODE_VISUAL_USESCRIPT n31 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n31~|||~
        ///PROMPT n31 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n31 0 Thank you. Perhaps I can teach you to write like that. Will you come by the Red Oak school this week?\n
        prompt.Text = "Thank you. Perhaps I can teach you to write like that. Will you come by the Red Oak school this week?\n";
        ///PROMPT_IGNORE_VO n31 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n31_p0_show);
        
        ///RESPONSE n31 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 0 Thank you, but I'm learning well enough on my own.\n
        response.Text = "Thank you, but I'm learning well enough on my own.\n";
        ///RESPONSE_NEXT_NODE_TYPE n31 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 0 n34
        response.NextNodeId = "n34";
        
        ///RESPONSE n31 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 1 Thank you. I'll ask Aunt Abigail if that's OK with her.\n
        response.Text = "Thank you. I'll ask Aunt Abigail if that's OK with her.\n";
        ///RESPONSE_NEXT_NODE_TYPE n31 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 1 n33
        response.NextNodeId = "n33";
        
        ///RESPONSE n31 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 2 Thank you, I'd like that. I need to learn to read and write better.\n
        response.Text = "Thank you, I'd like that. I need to learn to read and write better.\n";
        ///RESPONSE_NEXT_NODE_TYPE n31 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 2 n32
        response.NextNodeId = "n32";
        response.OnSelect(n31_r2_select);
        
        ///NODE_END n31
        ///NODE_START n32
        node = dialog.CreateNode("n32");
        ///NODE_NPC n32 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n32 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n32 Full
        ///NODE_VISUAL_USESCRIPT n32 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n32~|||~
        ///PROMPT n32 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n32 0 I look forward to it then.\n
        prompt.Text = "I look forward to it then.\n";
        ///PROMPT_IGNORE_VO n32 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n32_p0_show);
        
        ///RESPONSE n32 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n32 0 Me too. [Pick up laundry and go outside.]\n
        response.Text = "Me too. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n32 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n32 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n32_r0_select);
        
        ///NODE_END n32
        ///NODE_START n33
        node = dialog.CreateNode("n33");
        ///NODE_NPC n33 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n33 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n33 Full
        ///NODE_VISUAL_USESCRIPT n33 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n33~|||~
        ///PROMPT n33 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n33 0 I understand. Please let me know what she says.\n
        prompt.Text = "I understand. Please let me know what she says.\n";
        ///PROMPT_IGNORE_VO n33 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n33 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n33 0 I will. [Pick up laundry and go outside.]\n
        response.Text = "I will. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n33 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n33 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n33_r0_select);
        
        ///NODE_END n33
        ///NODE_START n34
        node = dialog.CreateNode("n34");
        ///NODE_NPC n34 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n34 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n34 Full
        ///NODE_VISUAL_USESCRIPT n34 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n34~|||~
        ///PROMPT n34 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n34 0 Of course. \n
        prompt.Text = "Of course. \n";
        ///PROMPT_IGNORE_VO n34 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n34 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n34 0 Goodbye Miss Hatcher. [Pick up laundry and go outside.]\n
        response.Text = "Goodbye Miss Hatcher. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n34 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n34 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n34_r0_select);
        
        ///NODE_END n34
        ///NODE_START n40
        node = dialog.CreateNode("n40");
        ///NODE_NPC n40 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n40 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n40 Full
        ///NODE_VISUAL_USESCRIPT n40 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n40~|||~
        ///PROMPT n40 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n40 0 Thank you, Lucy. These are beautiful. Did you make them? Your aunt says you are quite talented with a needle.\n
        prompt.Text = "Thank you, Lucy. These are beautiful. Did you make them? Your aunt says you are quite talented with a needle.\n";
        ///PROMPT_IGNORE_VO n40 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n40 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n40 0 Yes, thank you. I had better go now.\n
        response.Text = "Yes, thank you. I had better go now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n40 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n40 0 END
        response.NextNodeId = "END";
        response.SetCondition(n40_r0_condition);
        
        ///RESPONSE n40 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n40 1 Thank you, Miss Hatcher. The money that is raised... I was hoping some could be used to help my family.\n
        response.Text = "Thank you, Miss Hatcher. The money that is raised... I was hoping some could be used to help my family.\n";
        ///RESPONSE_NEXT_NODE_TYPE n40 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n40 1 n03
        response.NextNodeId = "n03";
        response.SetCondition(n40_r1_condition);
        response.OnSelect(n40_r1_select);
        
        ///RESPONSE n40 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n40 2 Yes, thank you. I am also here to pick up your laundry.\n
        response.Text = "Yes, thank you. I am also here to pick up your laundry.\n";
        ///RESPONSE_NEXT_NODE_TYPE n40 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n40 2 n02
        response.NextNodeId = "n02";
        response.SetCondition(n40_r2_condition);
        
        ///RESPONSE n40 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n40 3 Yes, thank you, I did make some of them. What do you do with the money you raise?\n
        response.Text = "Yes, thank you, I did make some of them. What do you do with the money you raise?\n";
        ///RESPONSE_NEXT_NODE_TYPE n40 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n40 3 n41
        response.NextNodeId = "n41";
        response.OnSelect(n40_r3_select);
        
        ///NODE_END n40
        ///NODE_START n41
        node = dialog.CreateNode("n41");
        ///NODE_NPC n41 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n41 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n41 Full
        ///NODE_VISUAL_USESCRIPT n41 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n41~|||~
        ///PROMPT n41 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n41 0 Most of it will help escaped slaves move to Canada. But some will be used to expand our school here in Red Oak.\n
        prompt.Text = "Most of it will help escaped slaves move to Canada. But some will be used to expand our school here in Red Oak.\n";
        ///PROMPT_IGNORE_VO n41 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n41 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n41 0 I see. I had better get your laundry now.\n
        response.Text = "I see. I had better get your laundry now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n41 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n41 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n41_r0_condition);
        
        ///RESPONSE n41 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n41 1 I'm glad that I could help. I had better go now.\n
        response.Text = "I'm glad that I could help. I had better go now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n41 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n41 1 END
        response.NextNodeId = "END";
        response.SetCondition(n41_r1_condition);
        
        ///RESPONSE n41 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n41 2 Why do they go to Canada?\n
        response.Text = "Why do they go to Canada?\n";
        ///RESPONSE_NEXT_NODE_TYPE n41 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n41 2 n43
        response.NextNodeId = "n43";
        response.SetCondition(n41_r2_condition);
        response.OnSelect(n41_r2_select);
        
        ///RESPONSE n41 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n41 3 My aunt said you teach at the school. Could you teach me?\n
        response.Text = "My aunt said you teach at the school. Could you teach me?\n";
        ///RESPONSE_NEXT_NODE_TYPE n41 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n41 3 n42
        response.NextNodeId = "n42";
        response.SetCondition(n41_r3_condition);
        response.OnSelect(n41_r3_select);
        
        ///RESPONSE n41 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n41 4 Excuse me for asking, but could some of it be used to help my family? They are in trouble.\n
        response.Text = "Excuse me for asking, but could some of it be used to help my family? They are in trouble.\n";
        ///RESPONSE_NEXT_NODE_TYPE n41 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n41 4 n03
        response.NextNodeId = "n03";
        response.SetCondition(n41_r4_condition);
        response.OnSelect(n41_r4_select);
        
        ///NODE_END n41
        ///NODE_START n42
        node = dialog.CreateNode("n42");
        ///NODE_NPC n42 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n42 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n42 Full
        ///NODE_VISUAL_USESCRIPT n42 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n42~|||~
        ///PROMPT n42 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n42 0 I would like that very much. You can come by anytime this week for a lesson.\n
        prompt.Text = "I would like that very much. You can come by anytime this week for a lesson.\n";
        ///PROMPT_IGNORE_VO n42 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n42_p0_show);
        
        ///RESPONSE n42 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n42 0 Thank you. I had better go now.\n
        response.Text = "Thank you. I had better go now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n42 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n42 0 END
        response.NextNodeId = "END";
        response.SetCondition(n42_r0_condition);
        
        ///RESPONSE n42 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n42 1 Thank you. I had better get your laundry now.\n
        response.Text = "Thank you. I had better get your laundry now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n42 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n42 1 n02
        response.NextNodeId = "n02";
        response.SetCondition(n42_r1_condition);
        
        ///NODE_END n42
        ///NODE_START n43
        node = dialog.CreateNode("n43");
        ///NODE_NPC n43 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n43 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n43 Full
        ///NODE_VISUAL_USESCRIPT n43 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n43~|||~
        ///PROMPT n43 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n43 0 While there is no slavery here in the north, the law still says escaped slaves belong to their masters. In Canada, runaways are out of the reach of that law.\n
        prompt.Text = "While there is no slavery here in the north, the law still says escaped slaves belong to their masters. In Canada, runaways are out of the reach of that law.\n";
        ///PROMPT_IGNORE_VO n43 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n43 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n43 0 I see. I had better get your laundry now.\n
        response.Text = "I see. I had better get your laundry now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n43 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n43 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n43_r0_condition);
        
        ///RESPONSE n43 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n43 1 I'm glad that I could help. I had better go now.\n
        response.Text = "I'm glad that I could help. I had better go now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n43 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n43 1 END
        response.NextNodeId = "END";
        response.SetCondition(n43_r1_condition);
        
        ///NODE_END n43
        ///NODE_START n50
        node = dialog.CreateNode("n50");
        ///NODE_NPC n50 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n50 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n50 Full
        ///NODE_VISUAL_USESCRIPT n50 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n50~|||~
        ///PROMPT n50 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n50 0 Yes, Mrs. Stowe -- Harriet -- opened my eyes to the evils of slavery. I knew then that fighting slavery was my calling.\n
        prompt.Text = "Yes, Mrs. Stowe -- Harriet -- opened my eyes to the evils of slavery. I knew then that fighting slavery was my calling.\n";
        ///PROMPT_IGNORE_VO n50 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n50_p0_show);
        
        ///RESPONSE n50 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n50 0 I don't know if I can fight. I am just a girl.\n
        response.Text = "I don't know if I can fight. I am just a girl.\n";
        ///RESPONSE_NEXT_NODE_TYPE n50 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n50 0 n52
        response.NextNodeId = "n52";
        
        ///RESPONSE n50 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n50 1 I've been a slave. It is evil. I'd like to fight it too.\n
        response.Text = "I've been a slave. It is evil. I'd like to fight it too.\n";
        ///RESPONSE_NEXT_NODE_TYPE n50 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n50 1 n51
        response.NextNodeId = "n51";
        
        ///NODE_END n50
        ///NODE_START n51
        node = dialog.CreateNode("n51");
        ///NODE_NPC n51 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n51 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n51 Full
        ///NODE_VISUAL_USESCRIPT n51 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n51~|||~
        ///PROMPT n51 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n51 0 The abolitionists welcome all who would fight slavery. You must come to our meeting tonight.\n
        prompt.Text = "The abolitionists welcome all who would fight slavery. You must come to our meeting tonight.\n";
        ///PROMPT_IGNORE_VO n51 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n51_p0_show);
        
        ///PROMPT n51 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n51 1 Making those handkerchiefs was a first step in your fight. You should also come to our abolitionist meeting tonight to learn more.\n
        prompt.Text = "Making those handkerchiefs was a first step in your fight. You should also come to our abolitionist meeting tonight to learn more.\n";
        ///PROMPT_IGNORE_VO n51 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n51_p1_condition);
        prompt.OnShow(n51_p1_show);
        
        ///RESPONSE n51 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n51 0 Thank you. My aunt already invited me! I will be there. I should get back to work now. [Pick up laundry and go outside.]\n
        response.Text = "Thank you. My aunt already invited me! I will be there. I should get back to work now. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n51 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n51 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n51_r0_select);
        
        ///NODE_END n51
        ///NODE_START n52
        node = dialog.CreateNode("n52");
        ///NODE_NPC n52 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n52 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n52 Full
        ///NODE_VISUAL_USESCRIPT n52 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n52~|||~
        ///PROMPT n52 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n52 0 I know you are not really Mrs. Wright's niece. Running away is a way of fighting. You have already struck a blow against slavery.\n
        prompt.Text = "I know you are not really Mrs. Wright's niece. Running away is a way of fighting. You have already struck a blow against slavery.\n";
        ///PROMPT_IGNORE_VO n52 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n52 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n52 0 I got lucky and now I'm going to lose my family and there is nothing I can do.\n
        response.Text = "I got lucky and now I'm going to lose my family and there is nothing I can do.\n";
        ///RESPONSE_NEXT_NODE_TYPE n52 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n52 0 n54
        response.NextNodeId = "n54";
        response.SetCondition(n52_r0_condition);
        response.OnSelect(n52_r0_select);
        
        ///RESPONSE n52 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n52 1 I never thought of it like that. Maybe I can help my family and my people.\n
        response.Text = "I never thought of it like that. Maybe I can help my family and my people.\n";
        ///RESPONSE_NEXT_NODE_TYPE n52 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n52 1 n53
        response.NextNodeId = "n53";
        response.OnSelect(n52_r1_select);
        
        ///NODE_END n52
        ///NODE_START n53
        node = dialog.CreateNode("n53");
        ///NODE_NPC n53 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n53 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n53 Full
        ///NODE_VISUAL_USESCRIPT n53 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n53~|||~
        ///PROMPT n53 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n53 0 The abolitionists will welcome you. You must come to our meeting tonight.\n
        prompt.Text = "The abolitionists will welcome you. You must come to our meeting tonight.\n";
        ///PROMPT_IGNORE_VO n53 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n53 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n53 0 Thank you. My aunt already invited me! I will be there. I should get back to work now. [Pick up laundry and go outside.]\n
        response.Text = "Thank you. My aunt already invited me! I will be there. I should get back to work now. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n53 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n53 0 n11
        response.NextNodeId = "n11";
        response.OnSelect(n53_r0_select);
        
        ///NODE_END n53
        ///NODE_START n54
        node = dialog.CreateNode("n54");
        ///NODE_NPC n54 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n54 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n54 Full
        ///NODE_VISUAL_USESCRIPT n54 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n54~|||~
        ///PROMPT n54 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n54 0 What do you mean? What is happening to your family?\n
        prompt.Text = "What do you mean? What is happening to your family?\n";
        ///PROMPT_IGNORE_VO n54 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n54 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n54 0 Never mind. I had better get back to work. [Pick up laundry and go outside.]\n
        response.Text = "Never mind. I had better get back to work. [Pick up laundry and go outside.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n54 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n54 0 n55
        response.NextNodeId = "n55";
        response.OnSelect(n54_r0_select);
        
        ///RESPONSE n54 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n54 1 They live on the King Plantation near Lexington. Reverend Rankin heard they're to be sold. I don't know what to do.\n
        response.Text = "They live on the King Plantation near Lexington. Reverend Rankin heard they're to be sold. I don't know what to do.\n";
        ///RESPONSE_NEXT_NODE_TYPE n54 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n54 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n54
        ///NODE_START n55
        node = dialog.CreateNode("n55");
        ///NODE_NPC n55 MIL
        node.Npc = "MIL";
        ///NODE_RANDOM_RESPONSES n55 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n55 Full
        ///NODE_VISUAL_USESCRIPT n55 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n55~|||~
        ///PROMPT n55 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n55 0 I am always here if you want to talk. I hope to see you soon.\n
        prompt.Text = "I am always here if you want to talk. I hope to see you soon.\n";
        ///PROMPT_IGNORE_VO n55 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n55 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n55 1 I am always here if you want to talk... Perhaps you'd like to visit me at the school. I can help you with your letters.\n
        prompt.Text = "I am always here if you want to talk... Perhaps you'd like to visit me at the school. I can help you with your letters.\n";
        ///PROMPT_IGNORE_VO n55 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n55_p1_condition);
        prompt.OnShow(n55_p1_show);
        
        ///PROMPT n55 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n55 2 I am always here if you want to talk... Oh, did your aunt have anything for you to give to me?\n
        prompt.Text = "I am always here if you want to talk... Oh, did your aunt have anything for you to give to me?\n";
        ///PROMPT_IGNORE_VO n55 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n55_p2_condition);
        
        ///RESPONSE n55 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n55 0 I do as well. Good day.\n
        response.Text = "I do as well. Good day.\n";
        ///RESPONSE_NEXT_NODE_TYPE n55 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n55 0 END
        response.NextNodeId = "END";
        response.SetCondition(n55_r0_condition);
        
        ///RESPONSE n55 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n55 1 Yes, I have these handkerchiefs for the fundraiser. [Give her the boxes.]\n
        response.Text = "Yes, I have these handkerchiefs for the fundraiser. [Give her the boxes.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n55 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n55 1 n40
        response.NextNodeId = "n40";
        response.SetCondition(n55_r1_condition);
        response.OnSelect(n55_r1_select);
        
        ///RESPONSE n55 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n55 2 Thank you, but I'm learning well enough on my own.\n
        response.Text = "Thank you, but I'm learning well enough on my own.\n";
        ///RESPONSE_NEXT_NODE_TYPE n55 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n55 2 n34
        response.NextNodeId = "n34";
        response.SetCondition(n55_r2_condition);
        
        ///RESPONSE n55 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n55 3 Thank you. I'll ask Aunt Abigail if that's okay with her.\n
        response.Text = "Thank you. I'll ask Aunt Abigail if that's okay with her.\n";
        ///RESPONSE_NEXT_NODE_TYPE n55 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n55 3 n33
        response.NextNodeId = "n33";
        response.SetCondition(n55_r3_condition);
        response.OnSelect(n55_r3_select);
        
        ///RESPONSE n55 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n55 4 Thank you, I'd like that. I need to learn to read better.\n
        response.Text = "Thank you, I'd like that. I need to learn to read better.\n";
        ///RESPONSE_NEXT_NODE_TYPE n55 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n55 4 n32
        response.NextNodeId = "n32";
        response.SetCondition(n55_r4_condition);
        response.OnSelect(n55_r4_select);
        
        ///NODE_END n55
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n11_p1_condition
    public bool n11_p1_condition (  ) {
        ///METHOD_BODY_START n11_p1_condition
        /*//if ((?p3_millie_lesson_offer = false) AND (?p3_millie_lesson_promise = false))*/
        return !DialogGameFlags.p3_millie_lesson_offer && !GameFlags.P3MillieLessonPromise;
        ///METHOD_BODY_END n11_p1_condition
    }

    ///METHOD n11_p2_condition
    public bool n11_p2_condition (  ) {
        ///METHOD_BODY_START n11_p2_condition
        /*//if (?p3_kerchief_done = false)*/
        return DialogGameFlags.p3_kerchief_done;
        ///METHOD_BODY_END n11_p2_condition
    }

    ///METHOD n51_p1_condition
    public bool n51_p1_condition (  ) {
        ///METHOD_BODY_START n51_p1_condition
        /*//if (?p3_kerchief_done = true)*/
        return DialogGameFlags.p3_kerchief_done;
        ///METHOD_BODY_END n51_p1_condition
    }

    ///METHOD n55_p1_condition
    public bool n55_p1_condition (  ) {
        ///METHOD_BODY_START n55_p1_condition
        /*//if ((?p3_millie_lesson_offer = false) AND (?p3_millie_lesson_promise = false))*/
        return !DialogGameFlags.p3_millie_lesson_offer && !GameFlags.P3MillieLessonPromise;
        ///METHOD_BODY_END n55_p1_condition
    }

    ///METHOD n55_p2_condition
    public bool n55_p2_condition (  ) {
        ///METHOD_BODY_START n55_p2_condition
        /*//if (?p3_kerchief_done = false)*/
        return !DialogGameFlags.p3_kerchief_done;
        ///METHOD_BODY_END n55_p2_condition
    }

    ///METHOD n02_p0_show
    public void n02_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n02_p0_show
        /*//set ?p3_millie_laundry = true*/
        DialogGameFlags.p3_millie_laundry = true;
        ///METHOD_BODY_END n02_p0_show
    }

    ///METHOD n03_p0_show
    public void n03_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n03_p0_show
        /*//#mil_points = #mil_points + 1
        //updateMessage ("Millie's opinion of you improves.")*/
        GameFlags.P3MilPoints++;
        ///METHOD_BODY_END n03_p0_show
    }

    ///METHOD n09_p0_show
    public void n09_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n09_p0_show
        /*//showNpc( true, 1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_room2.swf")*/
        ///METHOD_BODY_END n09_p0_show
    }

    ///METHOD n11_p1_show
    public void n11_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n11_p1_show
        /*//set ?p3_millie_lesson_offer = true*/
        DialogGameFlags.p3_millie_lesson_offer = true;
        ///METHOD_BODY_END n11_p1_show
    }

    ///METHOD n23_p0_show
    public void n23_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n23_p0_show
        /*//set ?p3_millie_lesson_offer = true*/
        DialogGameFlags.p3_millie_lesson_offer = true;
        ///METHOD_BODY_END n23_p0_show
    }

    ///METHOD n30_p0_show
    public void n30_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n30_p0_show
        /*//setLayer("fg", "gfx/stills/letter/letter1.png")
        //setFGXY("0|0")
        //showNpc( false, 1)*/
        ///METHOD_BODY_END n30_p0_show
    }

    ///METHOD n31_p0_show
    public void n31_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n31_p0_show
        /*//set ?p3_millie_lesson_offer = true
        //showNpc( true, 1)
        //setLayer("fg", "")*/
        DialogGameFlags.p3_millie_lesson_offer = true;
        ///METHOD_BODY_END n31_p0_show
    }

    ///METHOD n32_p0_show
    public void n32_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n32_p0_show
        /*//updateMessage ("This helps improve your reading.")
        //updateMessage ("Millie's opinion of you improves.")*/
        ///METHOD_BODY_END n32_p0_show
    }

    ///METHOD n42_p0_show
    public void n42_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n42_p0_show
        /*//updateMessage ("This helps improve your reading.")
        //updateMessage ("Millie's opinion of you improves.")*/
        ///METHOD_BODY_END n42_p0_show
    }

    ///METHOD n50_p0_show
    public void n50_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n50_p0_show
        /*//showNpc( true, 1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n50_p0_show
    }

    ///METHOD n51_p0_show
    public void n51_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n51_p0_show
        /*//showNpc( true, 1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n51_p0_show
    }

    ///METHOD n51_p1_show
    public void n51_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n51_p1_show
        /*//showNpc( true, 1)
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n51_p1_show
    }

    ///METHOD n55_p1_show
    public void n55_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n55_p1_show
        /*//set ?p3_millie_lesson_offer = true*/
        DialogGameFlags.p3_millie_lesson_offer = true;
        ///METHOD_BODY_END n55_p1_show
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if (?p3_ask_millie = true)*/
        return GameFlags.P3AskMilllie;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD n11_r0_condition
    public bool n11_r0_condition (  ) {
        ///METHOD_BODY_START n11_r0_condition
        /*//if ((?p3_kerchief_done = true) AND (?p3_millie_lesson_offer = true))*/
        return DialogGameFlags.p3_kerchief_done && DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n11_r0_condition
    }

    ///METHOD n11_r1_condition
    public bool n11_r1_condition (  ) {
        ///METHOD_BODY_START n11_r1_condition
        /*//if (?p3_kerchief_done = false)*/
        return !DialogGameFlags.p3_kerchief_done;
        ///METHOD_BODY_END n11_r1_condition
    }

    ///METHOD n11_r2_condition
    public bool n11_r2_condition (  ) {
        ///METHOD_BODY_START n11_r2_condition
        /*//if ((?p3_kerchief_done = true) AND (?p3_millie_lesson_offer = false))*/
        return DialogGameFlags.p3_kerchief_done && !DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n11_r2_condition
    }

    ///METHOD n11_r3_condition
    public bool n11_r3_condition (  ) {
        ///METHOD_BODY_START n11_r3_condition
        /*//if ((?p3_kerchief_done = true) AND (?p3_millie_lesson_offer = false))*/
        return DialogGameFlags.p3_kerchief_done && !DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n11_r3_condition
    }

    ///METHOD n11_r4_condition
    public bool n11_r4_condition (  ) {
        ///METHOD_BODY_START n11_r4_condition
        /*//if ((?p3_kerchief_done = true) AND (?p3_millie_lesson_offer = false))*/
        return DialogGameFlags.p3_kerchief_done && !DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n11_r4_condition
    }

    ///METHOD n14_r0_condition
    public bool n14_r0_condition (  ) {
        ///METHOD_BODY_START n14_r0_condition
        /*//if (?p3_millie_laundry = false)*/
        return !DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n14_r0_condition
    }

    ///METHOD n16_r1_condition
    public bool n16_r1_condition (  ) {
        ///METHOD_BODY_START n16_r1_condition
        /*//if (?p3_millie_laundry = true)*/
        return DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n16_r1_condition
    }

    ///METHOD n16_r2_condition
    public bool n16_r2_condition (  ) {
        ///METHOD_BODY_START n16_r2_condition
        /*//if (?p3_millie_laundry = true)*/
        return DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n16_r2_condition
    }

    ///METHOD n16_r3_condition
    public bool n16_r3_condition (  ) {
        ///METHOD_BODY_START n16_r3_condition
        /*//if (?p3_millie_laundry = false)*/
        return !DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n16_r3_condition
    }

    ///METHOD n16_r4_condition
    public bool n16_r4_condition (  ) {
        ///METHOD_BODY_START n16_r4_condition
        /*//if (?p3_millie_laundry = false)*/
        return !DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n16_r4_condition
    }

    ///METHOD n17_r0_condition
    public bool n17_r0_condition (  ) {
        ///METHOD_BODY_START n17_r0_condition
        /*//if (?p3_know_parker_resourceful = false)*/
        return !GameFlags.P3KnowParkerResourceful;
        ///METHOD_BODY_END n17_r0_condition
    }

    ///METHOD n17_r1_condition
    public bool n17_r1_condition (  ) {
        ///METHOD_BODY_START n17_r1_condition
        /*//if (?p3_know_parker_resourceful = true)*/
        return GameFlags.P3KnowParkerResourceful;
        ///METHOD_BODY_END n17_r1_condition
    }

    ///METHOD n18_r0_condition
    public bool n18_r0_condition (  ) {
        ///METHOD_BODY_START n18_r0_condition
        /*//if (?p3_millie_laundry = true)*/
        return DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n18_r0_condition
    }

    ///METHOD n18_r1_condition
    public bool n18_r1_condition (  ) {
        ///METHOD_BODY_START n18_r1_condition
        /*//if (?p3_millie_laundry = false)*/
        return !DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n18_r1_condition
    }

    ///METHOD n19_r0_condition
    public bool n19_r0_condition (  ) {
        ///METHOD_BODY_START n19_r0_condition
        /*//if (?p3_millie_lesson_promise = false)*/
        return !GameFlags.P3MillieLessonPromise;
        ///METHOD_BODY_END n19_r0_condition
    }

    ///METHOD n19_r1_condition
    public bool n19_r1_condition (  ) {
        ///METHOD_BODY_START n19_r1_condition
        /*//if (?p3_ask_millie_help = true)*/
        return DialogGameFlags.p3_ask_millie_help;
        ///METHOD_BODY_END n19_r1_condition
    }

    ///METHOD n19_r2_condition
    public bool n19_r2_condition (  ) {
        ///METHOD_BODY_START n19_r2_condition
        /*//if (?p3_seen_stowe_letter = true)*/
        return DialogGameFlags.p3_seen_stowe_letter;
        ///METHOD_BODY_END n19_r2_condition
    }

    ///METHOD n30_r1_condition
    public bool n30_r1_condition (  ) {
        ///METHOD_BODY_START n30_r1_condition
        /*//if (?p3_millie_lesson_offer = false)*/
        return !DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n30_r1_condition
    }

    ///METHOD n40_r0_condition
    public bool n40_r0_condition (  ) {
        ///METHOD_BODY_START n40_r0_condition
        /*//if (?p3_millie_laundry = true)*/
        return DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n40_r0_condition
    }

    ///METHOD n40_r1_condition
    public bool n40_r1_condition (  ) {
        ///METHOD_BODY_START n40_r1_condition
        /*//if (?p3_ask_millie_help = false)*/
        return !DialogGameFlags.p3_ask_millie_help;
        ///METHOD_BODY_END n40_r1_condition
    }

    ///METHOD n40_r2_condition
    public bool n40_r2_condition (  ) {
        ///METHOD_BODY_START n40_r2_condition
        /*//if (?p3_millie_laundry = false)*/
        return !DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n40_r2_condition
    }

    ///METHOD n41_r0_condition
    public bool n41_r0_condition (  ) {
        ///METHOD_BODY_START n41_r0_condition
        /*//if (?p3_millie_laundry = false)*/
        return !DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n41_r0_condition
    }

    ///METHOD n41_r1_condition
    public bool n41_r1_condition (  ) {
        ///METHOD_BODY_START n41_r1_condition
        /*//if (?p3_millie_laundry = true)*/
        return DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n41_r1_condition
    }

    ///METHOD n41_r2_condition
    public bool n41_r2_condition (  ) {
        ///METHOD_BODY_START n41_r2_condition
        /*//if (?p3_asked_canada = false)*/
        return !GameFlags.P3AskedCanada;
        ///METHOD_BODY_END n41_r2_condition
    }

    ///METHOD n41_r3_condition
    public bool n41_r3_condition (  ) {
        ///METHOD_BODY_START n41_r3_condition
        /*// if (?p3_millie_lesson_offer = false)*/
        return !DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n41_r3_condition
    }

    ///METHOD n41_r4_condition
    public bool n41_r4_condition (  ) {
        ///METHOD_BODY_START n41_r4_condition
        /*//if (?p3_ask_millie_help = false)*/
        return !DialogGameFlags.p3_ask_millie_help;
        ///METHOD_BODY_END n41_r4_condition
    }

    ///METHOD n42_r0_condition
    public bool n42_r0_condition (  ) {
        ///METHOD_BODY_START n42_r0_condition
        /*//if (?p3_millie_laundry = true)*/
        return DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n42_r0_condition
    }

    ///METHOD n42_r1_condition
    public bool n42_r1_condition (  ) {
        ///METHOD_BODY_START n42_r1_condition
        /*//if (?p3_millie_laundry = false)*/
        return !DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n42_r1_condition
    }

    ///METHOD n43_r0_condition
    public bool n43_r0_condition (  ) {
        ///METHOD_BODY_START n43_r0_condition
        /*//if (?p3_millie_laundry = false)*/
        return !DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n43_r0_condition
    }

    ///METHOD n43_r1_condition
    public bool n43_r1_condition (  ) {
        ///METHOD_BODY_START n43_r1_condition
        /*//if (?p3_millie_laundry = true)*/
        return DialogGameFlags.p3_millie_laundry;
        ///METHOD_BODY_END n43_r1_condition
    }

    ///METHOD n52_r0_condition
    public bool n52_r0_condition (  ) {
        ///METHOD_BODY_START n52_r0_condition
        /*//if (?p3_ask_millie_help = false)*/
        return !DialogGameFlags.p3_ask_millie_help;
        ///METHOD_BODY_END n52_r0_condition
    }

    ///METHOD n55_r0_condition
    public bool n55_r0_condition (  ) {
        ///METHOD_BODY_START n55_r0_condition
        /*//if ((?p3_kerchief_done = true) AND (?p3_millie_lesson_offer = true))*/
        return DialogGameFlags.p3_kerchief_done && DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n55_r0_condition
    }

    ///METHOD n55_r1_condition
    public bool n55_r1_condition (  ) {
        ///METHOD_BODY_START n55_r1_condition
        /*//if (?p3_kerchief_done = false)*/
        return !DialogGameFlags.p3_kerchief_done;
        ///METHOD_BODY_END n55_r1_condition
    }

    ///METHOD n55_r2_condition
    public bool n55_r2_condition (  ) {
        ///METHOD_BODY_START n55_r2_condition
        /*//if ((?p3_kerchief_done = true) AND (?p3_millie_lesson_offer = false))*/
        return DialogGameFlags.p3_kerchief_done && !DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n55_r2_condition
    }

    ///METHOD n55_r3_condition
    public bool n55_r3_condition (  ) {
        ///METHOD_BODY_START n55_r3_condition
        /*//if ((?p3_kerchief_done = true) AND (?p3_millie_lesson_offer = false))*/
        return DialogGameFlags.p3_kerchief_done && !DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n55_r3_condition
    }

    ///METHOD n55_r4_condition
    public bool n55_r4_condition (  ) {
        ///METHOD_BODY_START n55_r4_condition
        /*//if ((?p3_kerchief_done = true) AND (?p3_millie_lesson_offer = false))*/
        return DialogGameFlags.p3_kerchief_done && !DialogGameFlags.p3_millie_lesson_offer;
        ///METHOD_BODY_END n55_r4_condition
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//set ?p3_kerchief_done = true*/
        DialogGameFlags.p3_kerchief_done = true;
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//set ?p3_ask_millie_help = true*/
        DialogGameFlags.p3_ask_millie_help = true;
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n02_r1_select
    public void n02_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r1_select
        /*//showNpc(false,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_room.swf")*/
        ///METHOD_BODY_END n02_r1_select
    }

    ///METHOD n05_r1_select
    public void n05_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r1_select
        /*//showNpc(true,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n05_r1_select
    }

    ///METHOD n06_r0_select
    public void n06_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_room2.swf")*/
        ///METHOD_BODY_END n06_r0_select
    }

    ///METHOD n07_r0_select
    public void n07_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r0_select
        /*//showNpc(false,1)
        //setLayer("fg", "gfx/stills/letter/letter2.swf")
        //?p3_mil_curious = true*/
        GameFlags.P3MilCurious = true;
        ///METHOD_BODY_END n07_r0_select
    }

    ///METHOD n07_r1_select
    public void n07_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r1_select
        /*//showNpc(true,1)
        //setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n07_r1_select
    }

    ///METHOD n08_r0_select
    public void n08_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r0_select
        /*//set ?p3_seen_stowe_letter = true
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n08_r0_select
    }

    ///METHOD n08_r1_select
    public void n08_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r1_select
        /*//set ?p3_seen_stowe_letter = true
        //setLayer("fg", "")*/
        ///METHOD_BODY_END n08_r1_select
    }

    ///METHOD n10_r1_select
    public void n10_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r1_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")
        //showNpc(true,1)*/
        ///METHOD_BODY_END n10_r1_select
    }

    ///METHOD n11_r1_select
    public void n11_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r1_select
        /*//set ?p3_kerchief_done = true*/
        DialogGameFlags.p3_kerchief_done = true;
        ///METHOD_BODY_END n11_r1_select
    }

    ///METHOD n11_r3_select
    public void n11_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r3_select
        /*//#mil_points = #mil_points + 1
        //updateMessage ("Millie's opinion of you improves.")*/
        GameFlags.P3MilPoints++;
        ///METHOD_BODY_END n11_r3_select
    }

    ///METHOD n11_r4_select
    public void n11_r4_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r4_select
        /*//set ?p3_millie_lesson_promise = true
        //#mil_points = #mil_points + 2*/
        GameFlags.P3MillieLessonPromise = true;
        GameFlags.P3MilPoints+=2;
        ///METHOD_BODY_END n11_r4_select
    }

    ///METHOD n12_r0_select
    public void n12_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n12_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n12_r0_select
    }

    ///METHOD n17_r0_select
    public void n17_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n17_r0_select
        /*//set ?p3_know_parker_resourceful_mil = true*/
        GameFlags.P3KnowParkerResourcefulMil = true;
        ///METHOD_BODY_END n17_r0_select
    }

    ///METHOD n17_r1_select
    public void n17_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n17_r1_select
        /*//set ?p3_know_parker_resourceful_mil = true*/
        GameFlags.P3KnowParkerResourcefulMil = true;
        ///METHOD_BODY_END n17_r1_select
    }

    ///METHOD n21_r0_select
    public void n21_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n21_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n21_r0_select
    }

    ///METHOD n21a_r0_select
    public void n21a_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n21a_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n21a_r0_select
    }

    ///METHOD n22_r0_select
    public void n22_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n22_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n22_r0_select
    }

    ///METHOD n23_r2_select
    public void n23_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r2_select
        /*//set ?p3_millie_lesson_promise = true*/
        GameFlags.P3MillieLessonPromise = true;
        ///METHOD_BODY_END n23_r2_select
    }

    ///METHOD n30_r1_select
    public void n30_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n30_r1_select
        /*//?p3_millie_lesson_offer = true*/
        DialogGameFlags.p3_millie_lesson_offer = true;
        ///METHOD_BODY_END n30_r1_select
    }

    ///METHOD n31_r2_select
    public void n31_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n31_r2_select
        /*//set ?p3_millie_lesson_promise = true*/
        GameFlags.P3MillieLessonPromise = true;
        ///METHOD_BODY_END n31_r2_select
    }

    ///METHOD n32_r0_select
    public void n32_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n32_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n32_r0_select
    }

    ///METHOD n33_r0_select
    public void n33_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n33_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n33_r0_select
    }

    ///METHOD n34_r0_select
    public void n34_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n34_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n34_r0_select
    }

    ///METHOD n40_r1_select
    public void n40_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n40_r1_select
        /*//set ?p3_ask_millie_help = true*/
        DialogGameFlags.p3_ask_millie_help = true;
        ///METHOD_BODY_END n40_r1_select
    }

    ///METHOD n40_r3_select
    public void n40_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n40_r3_select
        /*//set ?p3_ask_funds = true*/
        GameFlags.P3AskFunds = true;
        ///METHOD_BODY_END n40_r3_select
    }

    ///METHOD n41_r2_select
    public void n41_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n41_r2_select
        /*//set ?p3_asked_canada = true*/
        GameFlags.P3AskedCanada = true;
        ///METHOD_BODY_END n41_r2_select
    }

    ///METHOD n41_r3_select
    public void n41_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n41_r3_select
        /*//set ?p3_millie_lesson_promise = true
        //?p3_millie_lesson_offer = true
        //#mil_points = #mil_points + 1*/
        DialogGameFlags.p3_millie_lesson_offer = true;
        GameFlags.P3MillieLessonPromise = true;
        GameFlags.P3MilPoints++;
        ///METHOD_BODY_END n41_r3_select
    }

    ///METHOD n41_r4_select
    public void n41_r4_select ( DialogResponse response ) {
        ///METHOD_BODY_START n41_r4_select
        /*//set ?p3_ask_millie_help = true*/
        DialogGameFlags.p3_ask_millie_help = true;
        ///METHOD_BODY_END n41_r4_select
    }

    ///METHOD n51_r0_select
    public void n51_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n51_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n51_r0_select
    }

    ///METHOD n52_r0_select
    public void n52_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n52_r0_select
        /*//set ?p3_ask_millie_help = true*/
        DialogGameFlags.p3_ask_millie_help = true;
        ///METHOD_BODY_END n52_r0_select
    }

    ///METHOD n52_r1_select
    public void n52_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n52_r1_select
        /*//updateMessage ("Millie's opinion of you improves.")*/
        ///METHOD_BODY_END n52_r1_select
    }

    ///METHOD n53_r0_select
    public void n53_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n53_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")
        //#mil_points = #mil_points + 1*/
        GameFlags.P3MilPoints++;
        ///METHOD_BODY_END n53_r0_select
    }

    ///METHOD n54_r0_select
    public void n54_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n54_r0_select
        /*//setLayer("bg", "gfx/swfs/dlg_bg/dbg_millie_house.swf")*/
        ///METHOD_BODY_END n54_r0_select
    }

    ///METHOD n55_r1_select
    public void n55_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n55_r1_select
        /*//set ?p3_kerchief_done = true*/
        DialogGameFlags.p3_kerchief_done = true;
        ///METHOD_BODY_END n55_r1_select
    }

    ///METHOD n55_r3_select
    public void n55_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n55_r3_select
        /*//#mil_points = #mil_points + 1
        //updateMessage ("Millie's opinion of you improves.")*/
        GameFlags.P3MilPoints+=1;
        ///METHOD_BODY_END n55_r3_select
    }

    ///METHOD n55_r4_select
    public void n55_r4_select ( DialogResponse response ) {
        ///METHOD_BODY_START n55_r4_select
        /*//set ?p3_millie_lesson_promise = true
        //#mil_points = #mil_points + 2*/
        GameFlags.P3MillieLessonPromise = true;
        GameFlags.P3MilPoints+=2;
        ///METHOD_BODY_END n55_r4_select
    }
}
//CLASS_END Dialog_p3_mil_001
