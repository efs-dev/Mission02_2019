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
//CLASS Dialog_p4_tcb_001
public class Dialog_p4_tcb_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _p4_why_tc_cares
        private bool _p4_why_tc_cares = false;

        //PROPERTY p4_why_tc_cares
        public bool p4_why_tc_cares {
                get {
                        ///PROPERTY_GETTER_START p4_why_tc_cares
                        return _p4_why_tc_cares;
                        ///PROPERTY_GETTER_END p4_why_tc_cares
                }
                set {
                        ///PROPERTY_SETTER_START p4_why_tc_cares
                        _p4_why_tc_cares = value;
                        ///PROPERTY_SETTER_END p4_why_tc_cares
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
        ///DIALOG_ID p4_tcb_001
        var dialog = new Dialog();
        dialog.Id = "p4_tcb_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 What might you be looking for? Another ###smartword|affidavit|AFFIDAVIT###?\n
        prompt.Text = "What might you be looking for? Another ###smartword|affidavit|AFFIDAVIT###?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Leave us alone!\n
        response.Text = "Leave us alone!\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n11
        response.NextNodeId = "n11";
        response.SetCondition(n01_r0_condition);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Leave me alone!\n
        response.Text = "Leave me alone!\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n04
        response.NextNodeId = "n04";
        response.SetCondition(n01_r1_condition);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 [Lie] Some laundry fell off the cart near here. I'm trying to find it.\n
        response.Text = "[Lie] Some laundry fell off the cart near here. I'm trying to find it.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 My uncle is in trouble. I'm trying to help him.\n
        response.Text = "My uncle is in trouble. I'm trying to help him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n02
        response.NextNodeId = "n02";
        
        ///RESPONSE n01 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 4 The men who grabbed my uncle tore up his free papers. I'm trying to find the pieces.\n
        response.Text = "The men who grabbed my uncle tore up his free papers. I'm trying to find the pieces.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 4 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 So I have heard. A free man being kidnapped by a band of ###smartword|opportunists|OPPORTUNISTS###.\n
        prompt.Text = "So I have heard. A free man being kidnapped by a band of ###smartword|opportunists|OPPORTUNISTS###.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n11
        response.NextNodeId = "n11";
        response.SetCondition(n02_r0_condition);
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n02_r1_condition);
        
        ///RESPONSE n02 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 2 What do you care?\n
        response.Text = "What do you care?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 2 n07
        response.NextNodeId = "n07";
        response.OnSelect(n02_r2_select);
        
        ///RESPONSE n02 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 3 You believe that he is free?\n
        response.Text = "You believe that he is free?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 3 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 You think I don't know a lying Negro when I see one? This has to do with the trouble your uncle is in. I'd bet my last dollar on it.\n
        prompt.Text = "You think I don't know a lying Negro when I see one? This has to do with the trouble your uncle is in. I'd bet my last dollar on it.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n11
        response.NextNodeId = "n11";
        response.SetCondition(n03_r0_condition);
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n03_r1_condition);
        
        ///RESPONSE n03 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 2 Yes, my uncle is in trouble. I'm trying to help him.\n
        response.Text = "Yes, my uncle is in trouble. I'm trying to help him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 2 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 Why so afraid? Or is there something you're hiding? Perhaps I'll find out. [He leaves.]\n
        prompt.Text = "Why so afraid? Or is there something you're hiding? Perhaps I'll find out. [He leaves.]\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n04
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Yes. A year ago I stopped Morgan thinking he was a runaway. But he showed me his free papers, so I let him go.\n
        prompt.Text = "Yes. A year ago I stopped Morgan thinking he was a runaway. But he showed me his free papers, so I let him go.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n11
        response.NextNodeId = "n11";
        response.SetCondition(n06_r0_condition);
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n06_r1_condition);
        
        ///RESPONSE n06 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 2 Would you tell that to the commissioner, Mr. Bercham?\n
        response.Text = "Would you tell that to the commissioner, Mr. Bercham?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 2 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 I don't much. But these men running around grabbing any Negro they see, competition like that is no good for my business.\n
        prompt.Text = "I don't much. But these men running around grabbing any Negro they see, competition like that is no good for my business.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n11
        response.NextNodeId = "n11";
        response.SetCondition(n07_r0_condition);
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n07_r1_condition);
        
        ///RESPONSE n07 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 2 Do you believe Uncle Morgan is free?\n
        response.Text = "Do you believe Uncle Morgan is free?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 2 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Now why would I want to do that? Sounds like a lot of time and trouble to help a Negro.\n
        prompt.Text = "Now why would I want to do that? Sounds like a lot of time and trouble to help a Negro.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 I could pay you for your trouble, Mr. Bercham.\n
        response.Text = "I could pay you for your trouble, Mr. Bercham.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 You could teach those opportunists a lesson.\n
        response.Text = "You could teach those opportunists a lesson.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n13
        response.NextNodeId = "n13";
        response.SetCondition(n08_r1_condition);
        
        ///RESPONSE n08 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 2 I'm begging you, sir. He's a free man and his family is here.\n
        response.Text = "I'm begging you, sir. He's a free man and his family is here.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 2 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 Don't mistake me for your abolitionist friends. I don't help Negroes... at least not for free.\n
        prompt.Text = "Don't mistake me for your abolitionist friends. I don't help Negroes... at least not for free.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n11
        response.NextNodeId = "n11";
        response.SetCondition(n09_r0_condition);
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n09_r1_condition);
        
        ///RESPONSE n09 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 2 I could pay you for your trouble, Mr. Bercham.\n
        response.Text = "I could pay you for your trouble, Mr. Bercham.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 2 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 Playing dumb? Well, I prefer a quiet Negro. I'll be seeing you again... I'm sure. [He leaves.]
        prompt.Text = "Playing dumb? Well, I prefer a quiet Negro. I'll be seeing you again... I'm sure. [He leaves.]";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 Say, who's your little friend? Do the Wrights have a nephew now, too?\n
        prompt.Text = "Say, who's your little friend? Do the Wrights have a nephew now, too?\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 Keep away from Jonah!\n
        response.Text = "Keep away from Jonah!\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 [Lie] No, he's the son of the Masons. I'm watching him today.\n
        response.Text = "[Lie] No, he's the son of the Masons. I'm watching him today.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n11 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 2 [Say nothing.]\n
        response.Text = "[Say nothing.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 2 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 The Masons? Hmmm, don't know them. I'll have to introduce myself.\n
        prompt.Text = "The Masons? Hmmm, don't know them. I'll have to introduce myself.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 Keep away from Jonah!\n
        response.Text = "Keep away from Jonah!\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 [Say nothing.]
        response.Text = "[Say nothing.]";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 True. But I need more than that if I'm to use my good name as a witness.\n
        prompt.Text = "True. But I need more than that if I'm to use my good name as a witness.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 I could pay you for your trouble, Mr. Bercham.\n
        response.Text = "I could pay you for your trouble, Mr. Bercham.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 I'm begging you, sir. He's a free man and his family is here.\n
        response.Text = "I'm begging you, sir. He's a free man and his family is here.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 You think you can afford my price girl? This will cost you $40. Do you have that kind of money?\n
        prompt.Text = "You think you can afford my price girl? This will cost you $40. Do you have that kind of money?\n";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 No, I don't.\n
        response.Text = "No, I don't.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n16
        response.NextNodeId = "n16";
        
        ///RESPONSE n14 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 1 I have $31, sir.
        response.Text = "I have $31, sir.";
        ///RESPONSE_NEXT_NODE_TYPE n14 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 1 n15a
        response.NextNodeId = "n15a";
        response.SetCondition(n14_r1_condition);
        
        ///RESPONSE n14 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 2 I have $33, sir.
        response.Text = "I have $33, sir.";
        ///RESPONSE_NEXT_NODE_TYPE n14 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 2 n15a
        response.NextNodeId = "n15a";
        response.SetCondition(n14_r2_condition);
        
        ///RESPONSE n14 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 3 I have $35, sir.
        response.Text = "I have $35, sir.";
        ///RESPONSE_NEXT_NODE_TYPE n14 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 3 n15
        response.NextNodeId = "n15";
        response.SetCondition(n14_r3_condition);
        
        ///RESPONSE n14 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 4 I have $37, sir.\n
        response.Text = "I have $37, sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 4 n15
        response.NextNodeId = "n15";
        response.SetCondition(n14_r4_condition);
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 A thrifty Negro. I thought I'd seen it all. Well, that's pretty close. I'll take that and you'll owe me $10.
        prompt.Text = "A thrifty Negro. I thought I'd seen it all. Well, that's pretty close. I'll take that and you'll owe me $10.";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n15 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 1 A thrifty Negro. I thought I'd seen it all. Well, that's pretty close. I'll take that and you'll just owe me $8.\n
        prompt.Text = "A thrifty Negro. I thought I'd seen it all. Well, that's pretty close. I'll take that and you'll just owe me $8.\n";
        ///PROMPT_IGNORE_VO n15 1 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 Very well. I accept.\n
        response.Text = "Very well. I accept.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 n19
        response.NextNodeId = "n19";
        response.OnSelect(n15_r0_select);
        
        ///RESPONSE n15 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 1 But that's more than $40.\n
        response.Text = "But that's more than $40.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 1 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n15
        ///NODE_START n15a
        node = dialog.CreateNode("n15a");
        ///NODE_NPC n15a TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n15a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15a Full
        ///NODE_VISUAL_USESCRIPT n15a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15a~|||~
        ///PROMPT n15a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15a 0 A thrifty Negro. I thought I'd seen it all. But that's not enough because I don't work for less. [He leaves.]
        prompt.Text = "A thrifty Negro. I thought I'd seen it all. But that's not enough because I don't work for less. [He leaves.]";
        ///PROMPT_IGNORE_VO n15a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15a 0 [Wait.]
        response.Text = "[Wait.]";
        ///RESPONSE_NEXT_NODE_TYPE n15a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15a 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n15a
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 I didn't think you did. [He leaves.]\n
        prompt.Text = "I didn't think you did. [He leaves.]\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 That's what we call interest. You owe me $5 and you pay me an extra $5. Do we have a deal?
        prompt.Text = "That's what we call interest. You owe me $5 and you pay me an extra $5. Do we have a deal?";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n17 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 1 That's what we call interest. You owe me $3 and you pay me an extra $5. Do we have a deal?\n
        prompt.Text = "That's what we call interest. You owe me $3 and you pay me an extra $5. Do we have a deal?\n";
        ///PROMPT_IGNORE_VO n17 1 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 No, I'll get Uncle Morgan free without your interest.\n
        response.Text = "No, I'll get Uncle Morgan free without your interest.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n17 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 1 Very well. I accept.\n
        response.Text = "Very well. I accept.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 1 n19
        response.NextNodeId = "n19";
        response.OnSelect(n17_r1_select);
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 Suit yourself. [He leaves.]\n
        prompt.Text = "Suit yourself. [He leaves.]\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 I'll see you in town when the commissioner arrives. Bring the money then. [He leaves.]\n
        prompt.Text = "I'll see you in town when the commissioner arrives. Bring the money then. [He leaves.]\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n19_p0_show);
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n19
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 TCB
        node.Npc = "TCB";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 That's what I thought. I'm sure you'll be seeing me again real soon. [He leaves.]\n
        prompt.Text = "That's what I thought. I'm sure you'll be seeing me again real soon. [He leaves.]\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 [Wait.]\n
        response.Text = "[Wait.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n20
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n19_p0_show
    public void n19_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n19_p0_show
        /*//#p4_witness_pts += 50
        //?p4_got_tcb = true*/
        GameFlags.P4WitnessPoints += 50;
        GameFlags.P4GotTCB = true;
        ///METHOD_BODY_END n19_p0_show
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if (?p4_bring_jonah  = true)*/
        return GameFlags.P4BringJonah;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if (?p4_bring_jonah = false)*/
        return !GameFlags.P4BringJonah;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD n02_r0_condition
    public bool n02_r0_condition (  ) {
        ///METHOD_BODY_START n02_r0_condition
        /*//if (?p4_bring_jonah = true)*/
        return GameFlags.P4BringJonah;
        ///METHOD_BODY_END n02_r0_condition
    }

    ///METHOD n02_r1_condition
    public bool n02_r1_condition (  ) {
        ///METHOD_BODY_START n02_r1_condition
        /*//if (?p4_bring_jonah = false)*/
        return !GameFlags.P4BringJonah;
        ///METHOD_BODY_END n02_r1_condition
    }

    ///METHOD n03_r0_condition
    public bool n03_r0_condition (  ) {
        ///METHOD_BODY_START n03_r0_condition
        /*//if (?p4_bring_jonah = true)*/
        return GameFlags.P4BringJonah;
        ///METHOD_BODY_END n03_r0_condition
    }

    ///METHOD n03_r1_condition
    public bool n03_r1_condition (  ) {
        ///METHOD_BODY_START n03_r1_condition
        /*//if (?p4_bring_jonah = false)*/
        return !GameFlags.P4BringJonah;
        ///METHOD_BODY_END n03_r1_condition
    }

    ///METHOD n06_r0_condition
    public bool n06_r0_condition (  ) {
        ///METHOD_BODY_START n06_r0_condition
        /*//if (?p4_bring_jonah = true)*/
        return GameFlags.P4BringJonah;
        ///METHOD_BODY_END n06_r0_condition
    }

    ///METHOD n06_r1_condition
    public bool n06_r1_condition (  ) {
        ///METHOD_BODY_START n06_r1_condition
        /*//if (?p4_bring_jonah = false)*/
        return !GameFlags.P4BringJonah;
        ///METHOD_BODY_END n06_r1_condition
    }

    ///METHOD n07_r0_condition
    public bool n07_r0_condition (  ) {
        ///METHOD_BODY_START n07_r0_condition
        /*//if (?p4_bring_jonah = true)*/
        return GameFlags.P4BringJonah;
        ///METHOD_BODY_END n07_r0_condition
    }

    ///METHOD n07_r1_condition
    public bool n07_r1_condition (  ) {
        ///METHOD_BODY_START n07_r1_condition
        /*//if (?p4_bring_jonah = false)*/
        return !GameFlags.P4BringJonah;
        ///METHOD_BODY_END n07_r1_condition
    }

    ///METHOD n08_r1_condition
    public bool n08_r1_condition (  ) {
        ///METHOD_BODY_START n08_r1_condition
        /*//if (?p4_why_tc_cares = true)*/
        return DialogGameFlags.p4_why_tc_cares;
        ///METHOD_BODY_END n08_r1_condition
    }

    ///METHOD n09_r0_condition
    public bool n09_r0_condition (  ) {
        ///METHOD_BODY_START n09_r0_condition
        /*//if (?p4_bring_jonah = true)*/
        return GameFlags.P4BringJonah;
        ///METHOD_BODY_END n09_r0_condition
    }

    ///METHOD n09_r1_condition
    public bool n09_r1_condition (  ) {
        ///METHOD_BODY_START n09_r1_condition
        /*//if (?p4_bring_jonah = false)*/
        return !GameFlags.P4BringJonah;
        ///METHOD_BODY_END n09_r1_condition
    }

    ///METHOD n14_r1_condition
    public bool n14_r1_condition (  ) {
        ///METHOD_BODY_START n14_r1_condition
        /*//if (#lucy_money = 31)*/
        return GameFlags.LucyMoney == 31;
        ///METHOD_BODY_END n14_r1_condition
    }

    ///METHOD n14_r2_condition
    public bool n14_r2_condition (  ) {
        ///METHOD_BODY_START n14_r2_condition
        /*//if (#lucy_money = 33)*/
        return GameFlags.LucyMoney == 33;
        ///METHOD_BODY_END n14_r2_condition
    }

    ///METHOD n14_r3_condition
    public bool n14_r3_condition (  ) {
        ///METHOD_BODY_START n14_r3_condition
        /*//if (#lucy_money = 35)*/
        return GameFlags.LucyMoney == 35;
        ///METHOD_BODY_END n14_r3_condition
    }

    ///METHOD n14_r4_condition
    public bool n14_r4_condition (  ) {
        ///METHOD_BODY_START n14_r4_condition
        /*//if (#lucy_money = 37)*/
        return GameFlags.LucyMoney == 37;
        ///METHOD_BODY_END n14_r4_condition
    }

    ///METHOD n02_r2_select
    public void n02_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r2_select
        /*//set ?p4_why_tc_cares = true*/
        DialogGameFlags.p4_why_tc_cares = true;
        ///METHOD_BODY_END n02_r2_select
    }

    ///METHOD n15_r0_select
    public void n15_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15_r0_select
        /*//?p4_hard_bargain=true*/
        GameFlags.P4HardBargain = true;
        ///METHOD_BODY_END n15_r0_select
    }

    ///METHOD n17_r1_select
    public void n17_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n17_r1_select
        /*//?p4_hard_bargain = true*/
        GameFlags.P4HardBargain = true;
        ///METHOD_BODY_END n17_r1_select
    }
}
//CLASS_END Dialog_p4_tcb_001
