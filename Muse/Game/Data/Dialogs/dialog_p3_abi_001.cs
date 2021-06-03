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
//CLASS Dialog_p3_abi_001
public class Dialog_p3_abi_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _p3_asked_parker
        private bool _p3_asked_parker = false;

        //PROPERTY p3_asked_parker
        public bool p3_asked_parker {
                get {
                        ///PROPERTY_GETTER_START p3_asked_parker
                        return _p3_asked_parker;
                        ///PROPERTY_GETTER_END p3_asked_parker
                }
                set {
                        ///PROPERTY_SETTER_START p3_asked_parker
                        _p3_asked_parker = value;
                        ///PROPERTY_SETTER_END p3_asked_parker
                }
        }

        //PROPERTY _p3_lucy_knows_law
        private bool _p3_lucy_knows_law = false;

        //PROPERTY p3_lucy_knows_law
        public bool p3_lucy_knows_law {
                get {
                        ///PROPERTY_GETTER_START p3_lucy_knows_law
                        return _p3_lucy_knows_law;
                        ///PROPERTY_GETTER_END p3_lucy_knows_law
                }
                set {
                        ///PROPERTY_SETTER_START p3_lucy_knows_law
                        _p3_lucy_knows_law = value;
                        ///PROPERTY_SETTER_END p3_lucy_knows_law
                }
        }

        //PROPERTY _p3_want_meet_millie
        private bool _p3_want_meet_millie = false;

        //PROPERTY p3_want_meet_millie
        public bool p3_want_meet_millie {
                get {
                        ///PROPERTY_GETTER_START p3_want_meet_millie
                        return _p3_want_meet_millie;
                        ///PROPERTY_GETTER_END p3_want_meet_millie
                }
                set {
                        ///PROPERTY_SETTER_START p3_want_meet_millie
                        _p3_want_meet_millie = value;
                        ///PROPERTY_SETTER_END p3_want_meet_millie
                }
        }

        //PROPERTY _p3_want_meet_parker
        private bool _p3_want_meet_parker = false;

        //PROPERTY p3_want_meet_parker
        public bool p3_want_meet_parker {
                get {
                        ///PROPERTY_GETTER_START p3_want_meet_parker
                        return _p3_want_meet_parker;
                        ///PROPERTY_GETTER_END p3_want_meet_parker
                }
                set {
                        ///PROPERTY_SETTER_START p3_want_meet_parker
                        _p3_want_meet_parker = value;
                        ///PROPERTY_SETTER_END p3_want_meet_parker
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
        ///DIALOG_ID p3_abi_001
        var dialog = new Dialog();
        dialog.Id = "p3_abi_001";
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
        ///PROMPT_TEXT n01 0 Good morning Lucy. No washing for you today. I need you to take the wagon into town and pick up our customers' laundry.\n
        prompt.Text = "Good morning Lucy. No washing for you today. I need you to take the wagon into town and pick up our customers' laundry.\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 I've never driven a wagon before.\n
        response.Text = "I've never driven a wagon before.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n04
        response.NextNodeId = "n04";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Where do I have to go?\n
        response.Text = "Where do I have to go?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Where is Mr. Wright?\n
        response.Text = "Where is Mr. Wright?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
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
        ///PROMPT_TEXT n02 0 He left last night to go to Cincinnati for a convention of colored citizens. He's representing our community.
        prompt.Text = "He left last night to go to Cincinnati for a convention of colored citizens. He's representing our community.";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n02_p0_show);
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 Where do I have to go?\n
        response.Text = "Where do I have to go?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
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
        ///PROMPT_TEXT n03 0 A few households around Ripley and then the Ripley Hotel. They're our biggest customer. But you'll need to be careful there.\n
        prompt.Text = "A few households around Ripley and then the Ripley Hotel. They're our biggest customer. But you'll need to be careful there.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What is the danger?\n
        response.Text = "What is the danger?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 Do they not like colored folks?\n
        response.Text = "Do they not like colored folks?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n05
        response.NextNodeId = "n05";
        
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
        ///PROMPT_TEXT n04 0 Tess is a good horse. She knows the way and won't give you no trouble.\n
        prompt.Text = "Tess is a good horse. She knows the way and won't give you no trouble.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Where do I have to go?
        response.Text = "Where do I have to go?";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 Where is Mr. Wright?\n
        response.Text = "Where is Mr. Wright?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n02
        response.NextNodeId = "n02";
        response.SetCondition(n04_r1_condition);
        
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
        ///PROMPT_TEXT n05 0 They have many southern customers, including slave catchers.\n
        prompt.Text = "They have many southern customers, including slave catchers.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Slave catchers? Will they take me back?\n
        response.Text = "Slave catchers? Will they take me back?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 Why do you do business with them?\n
        response.Text = "Why do you do business with them?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n07
        response.NextNodeId = "n07";
        
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
        ///PROMPT_TEXT n07 0 We need their business to survive... and we use any extra money to help escaped slaves.\n
        prompt.Text = "We need their business to survive... and we use any extra money to help escaped slaves.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 I see. Do I have to worry about slave catchers?\n
        response.Text = "I see. Do I have to worry about slave catchers?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 You do? I know you helped me. But what else do you do?\n
        response.Text = "You do? I know you helped me. But what else do you do?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n22
        response.NextNodeId = "n22";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Not if you're careful. People think you're our niece. You should be safe as long as you don't give them a reason to question that.\n
        prompt.Text = "Not if you're careful. People think you're our niece. You should be safe as long as you don't give them a reason to question that.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 Are there other customers I should be careful with?\n
        response.Text = "Are there other customers I should be careful with?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 Until slavery is abolished, you'll need to watch yourself. There's no slavery here, but that doesn't make you free. The law says you still belong to Mr. King.\n
        prompt.Text = "Until slavery is abolished, you'll need to watch yourself. There's no slavery here, but that doesn't make you free. The law says you still belong to Mr. King.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n09 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 1 Until slavery is abolished, you'll need to watch yourself.\n
        prompt.Text = "Until slavery is abolished, you'll need to watch yourself.\n";
        ///PROMPT_IGNORE_VO n09 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n09_p1_condition);
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 I understand. I am ready to start.\n
        response.Text = "I understand. I am ready to start.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 Is there anyone we can trust?\n
        response.Text = "Is there anyone we can trust?\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 Some customers, like Miss Hatcher or Mr. Parker are ###smartword|abolitionists|ABOLITIONISTS###. You can trust them. But the fewer who know your past, the safer you will be.\n
        prompt.Text = "Some customers, like Miss Hatcher or Mr. Parker are ###smartword|abolitionists|ABOLITIONISTS###. You can trust them. But the fewer who know your past, the safer you will be.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I understand. I am ready to start.\n
        response.Text = "I understand. I am ready to start.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 Who is Mr. Parker?\n
        response.Text = "Who is Mr. Parker?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n13
        response.NextNodeId = "n13";
        response.OnSelect(n10_r1_select);
        
        ///RESPONSE n10 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 2 Who is Miss Hatcher?\n
        response.Text = "Who is Miss Hatcher?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 2 n12
        response.NextNodeId = "n12";
        response.OnSelect(n10_r2_select);
        
        ///NODE_END n10
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 She teaches at our church school and writes newspaper articles telling of the evils of slavery. She also raises money for our cause.\n
        prompt.Text = "She teaches at our church school and writes newspaper articles telling of the evils of slavery. She also raises money for our cause.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 I look forward to meeting her.\n
        response.Text = "I look forward to meeting her.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n17
        response.NextNodeId = "n17";
        response.OnSelect(n12_r0_select);
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 Who is Mr. Parker?\n
        response.Text = "Who is Mr. Parker?\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n13
        response.NextNodeId = "n13";
        response.SetCondition(n12_r1_condition);
        response.OnSelect(n12_r1_select);
        
        ///RESPONSE n12 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 2 I wish I could help the abolitionist cause like that.\n
        response.Text = "I wish I could help the abolitionist cause like that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 2 n14
        response.NextNodeId = "n14";
        response.OnSelect(n12_r2_select);
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 He's new to town. He bought his freedom and now works in a ###smartword|foundry|FOUNDRY###. I hear he sometimes goes across the river and rows escaped slaves to safety.\n
        prompt.Text = "He's new to town. He bought his freedom and now works in a ###smartword|foundry|FOUNDRY###. I hear he sometimes goes across the river and rows escaped slaves to safety.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n13_p0_show);
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 Who is Miss Hatcher?\n
        response.Text = "Who is Miss Hatcher?\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n12
        response.NextNodeId = "n12";
        response.SetCondition(n13_r0_condition);
        response.OnSelect(n13_r0_select);
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 I wish I could help escaped slaves like that.\n
        response.Text = "I wish I could help escaped slaves like that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n16
        response.NextNodeId = "n16";
        response.OnSelect(n13_r1_select);
        
        ///RESPONSE n13 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 2 That sounds dangerous.\n
        response.Text = "That sounds dangerous.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 2 n15
        response.NextNodeId = "n15";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 You were an abolitionist since the day you decided to run away. Maybe it's time you came to one of our abolitionist meetings.
        prompt.Text = "You were an abolitionist since the day you decided to run away. Maybe it's time you came to one of our abolitionist meetings.";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 I'd like that.\n
        response.Text = "I'd like that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n18
        response.NextNodeId = "n18";
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 No doubt it is. If he's ever caught he could be hanged. John Parker is a fearless man indeed.\n
        prompt.Text = "No doubt it is. If he's ever caught he could be hanged. John Parker is a fearless man indeed.\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 I wish I could help escaped slaves like that.\n
        response.Text = "I wish I could help escaped slaves like that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 n16
        response.NextNodeId = "n16";
        response.OnSelect(n15_r0_select);
        
        ///RESPONSE n15 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 1 Who is Miss Hatcher?\n
        response.Text = "Who is Miss Hatcher?\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 1 n12
        response.NextNodeId = "n12";
        response.SetCondition(n15_r1_condition);
        response.OnSelect(n15_r1_select);
        
        ///RESPONSE n15 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 2 I look forward to meeting him.\n
        response.Text = "I look forward to meeting him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 2 n17
        response.NextNodeId = "n17";
        response.OnSelect(n15_r2_select);
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 You escaped on your own, so I wouldn't put anything past you. Maybe it's time you came to one of our abolitionist meetings.\n
        prompt.Text = "You escaped on your own, so I wouldn't put anything past you. Maybe it's time you came to one of our abolitionist meetings.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 I'd like that.\n
        response.Text = "I'd like that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n18
        response.NextNodeId = "n18";
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 You'll meet her today -- she's one of our customers. But you should come to our abolitionist meeting tonight and you can talk more.\n
        prompt.Text = "You'll meet her today -- she's one of our customers. But you should come to our abolitionist meeting tonight and you can talk more.\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n17_p0_condition);
        
        ///PROMPT n17 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 1 You'll meet him today -- he's one of our customers. But you should come to our abolitionist meeting tonight and you can talk more.
        prompt.Text = "You'll meet him today -- he's one of our customers. But you should come to our abolitionist meeting tonight and you can talk more.";
        ///PROMPT_IGNORE_VO n17 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n17_p1_condition);
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 I'd like that.\n
        response.Text = "I'd like that.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n18
        response.NextNodeId = "n18";
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 Very good. When you come back with all the laundry, we'll go over together. Oh, and one more thing.\n
        prompt.Text = "Very good. When you come back with all the laundry, we'll go over together. Oh, and one more thing.\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 What is it?\n
        response.Text = "What is it?\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 n20
        response.NextNodeId = "n20";
        
        ///NODE_END n18
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Full
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n20~|||~
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 You know those handkerchiefs we've been embroidering? They're for the anti-slavery fundraiser in Red Oak. Drop them off with Miss Hatcher. [She shows you a flier.]\n
        prompt.Text = "You know those handkerchiefs we've been embroidering? They're for the anti-slavery fundraiser in Red Oak. Drop them off with Miss Hatcher. [She shows you a flier.]\n";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n20_p0_show);
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 [Look at the flier.]\n
        response.Text = "[Look at the flier.]\n";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n21
        response.NextNodeId = "n21";
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 I'm glad my work is going to help! I'll take the handkerchiefs to the church [Leave]\n
        response.Text = "I'm glad my work is going to help! I'll take the handkerchiefs to the church [Leave]\n";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n21
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Full
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n22~|||~
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 We help support the school, but mostly we help folks go further North, all the way up to Canada.\n
        prompt.Text = "We help support the school, but mostly we help folks go further North, all the way up to Canada.\n";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 Do you think I should go to Canada too?\n
        response.Text = "Do you think I should go to Canada too?\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n24
        response.NextNodeId = "n24";
        
        ///RESPONSE n22 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 1 Why do they go to Canada?\n
        response.Text = "Why do they go to Canada?\n";
        ///RESPONSE_NEXT_NODE_TYPE n22 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 1 n23
        response.NextNodeId = "n23";
        response.OnSelect(n22_r1_select);
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 While there is no slavery here in the North, the law still says you have to be returned to Mr. King. But in Canada they won't return you.\n
        prompt.Text = "While there is no slavery here in the North, the law still says you have to be returned to Mr. King. But in Canada they won't return you.\n";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 Do you think I should go to Canada too?\n
        response.Text = "Do you think I should go to Canada too?\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n24
        response.NextNodeId = "n24";
        response.OnSelect(n23_r0_select);
        
        ///RESPONSE n23 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 1 Why don't you go to Canada?\n
        response.Text = "Why don't you go to Canada?\n";
        ///RESPONSE_NEXT_NODE_TYPE n23 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 1 n25
        response.NextNodeId = "n25";
        response.OnSelect(n23_r1_select);
        
        ///NODE_END n23
        ///NODE_START n24
        node = dialog.CreateNode("n24");
        ///NODE_NPC n24 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n24 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24 Full
        ///NODE_VISUAL_USESCRIPT n24 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n24~|||~
        ///PROMPT n24 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24 0 Mr. Wright and I think we can keep you safe and we have a paying job for you. It might be tough for a young girl alone in Canada.\n
        prompt.Text = "Mr. Wright and I think we can keep you safe and we have a paying job for you. It might be tough for a young girl alone in Canada.\n";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 I appreciate that very much Aunt Abigail. But do I have to worry about slave catchers?\n
        response.Text = "I appreciate that very much Aunt Abigail. But do I have to worry about slave catchers?\n";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n24
        ///NODE_START n25
        node = dialog.CreateNode("n25");
        ///NODE_NPC n25 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n25 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n25 Full
        ///NODE_VISUAL_USESCRIPT n25 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n25~|||~
        ///PROMPT n25 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n25 0 We have our ###smartword|free papers|FREE_PAPERS### so we should be safe. And helping escaped slaves is important to us. We can do that best here.\n
        prompt.Text = "We have our ###smartword|free papers|FREE_PAPERS### so we should be safe. And helping escaped slaves is important to us. We can do that best here.\n";
        ///PROMPT_IGNORE_VO n25 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n25 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 0 Can I get free papers?\n
        response.Text = "Can I get free papers?\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 0 n26
        response.NextNodeId = "n26";
        
        ///RESPONSE n25 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 1 Why did I stay here and not go north?\n
        response.Text = "Why did I stay here and not go north?\n";
        ///RESPONSE_NEXT_NODE_TYPE n25 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 1 n24
        response.NextNodeId = "n24";
        
        ///NODE_END n25
        ///NODE_START n26
        node = dialog.CreateNode("n26");
        ///NODE_NPC n26 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n26 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26 Full
        ///NODE_VISUAL_USESCRIPT n26 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n26~|||~
        ///PROMPT n26 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26 0 I don't think so. We'd have to prove in court that you were born here or bought your freedom.\n
        prompt.Text = "I don't think so. We'd have to prove in court that you were born here or bought your freedom.\n";
        ///PROMPT_IGNORE_VO n26 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n26 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 0 If I can't get papers, shouldn't I go north?\n
        response.Text = "If I can't get papers, shouldn't I go north?\n";
        ///RESPONSE_NEXT_NODE_TYPE n26 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 0 n24
        response.NextNodeId = "n24";
        
        ///RESPONSE n26 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 1 How did you get your papers?\n
        response.Text = "How did you get your papers?\n";
        ///RESPONSE_NEXT_NODE_TYPE n26 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 1 n27
        response.NextNodeId = "n27";
        
        ///NODE_END n26
        ///NODE_START n27
        node = dialog.CreateNode("n27");
        ///NODE_NPC n27 ABI
        node.Npc = "ABI";
        ///NODE_RANDOM_RESPONSES n27 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n27 Full
        ///NODE_VISUAL_USESCRIPT n27 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n27~|||~
        ///PROMPT n27 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n27 0 Mr. Wright and I were born to free blacks in Pennslyvania. We have never been slaves.\n
        prompt.Text = "Mr. Wright and I were born to free blacks in Pennslyvania. We have never been slaves.\n";
        ///PROMPT_IGNORE_VO n27 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n27 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n27 0 If I can't get papers, shouldn't I go north?\n
        response.Text = "If I can't get papers, shouldn't I go north?\n";
        ///RESPONSE_NEXT_NODE_TYPE n27 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n27 0 n24
        response.NextNodeId = "n24";
        
        ///RESPONSE n27 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n27 1 If I am not truly free like you, do I have to worry about slave catchers?\n
        response.Text = "If I am not truly free like you, do I have to worry about slave catchers?\n";
        ///RESPONSE_NEXT_NODE_TYPE n27 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n27 1 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n27
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n09_p1_condition
    public bool n09_p1_condition (  ) {
        ///METHOD_BODY_START n09_p1_condition
        /*//if (?p3_lucy_knows_law = true)*/
        return DialogGameFlags.p3_lucy_knows_law;
        ///METHOD_BODY_END n09_p1_condition
    }

    ///METHOD n17_p0_condition
    public bool n17_p0_condition (  ) {
        ///METHOD_BODY_START n17_p0_condition
        /*//if (?p3_want_meet_millie)*/
        return DialogGameFlags.p3_want_meet_millie;
        ///METHOD_BODY_END n17_p0_condition
    }

    ///METHOD n17_p1_condition
    public bool n17_p1_condition (  ) {
        ///METHOD_BODY_START n17_p1_condition
        /*//if (?p3_want_meet_parker)*/
        return DialogGameFlags.p3_want_meet_parker;
        ///METHOD_BODY_END n17_p1_condition
    }

    ///METHOD n02_p0_show
    public void n02_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n02_p0_show
        /*//set ?p3_know_morgan_cin = true*/
        GameFlags.P3KnowMorganCin = true;
        ///METHOD_BODY_END n02_p0_show
    }

    ///METHOD n13_p0_show
    public void n13_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n13_p0_show
        /*//set ?p3_know_parker_free = true*/
        GameFlags.P3KnowParkerFree = true;
        ///METHOD_BODY_END n13_p0_show
    }

    ///METHOD n20_p0_show
    public void n20_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n20_p0_show
        /*//?has_fair = true*/
        GameFlags.P3HasFair = true;
        ///METHOD_BODY_END n20_p0_show
    }

    ///METHOD n04_r1_condition
    public bool n04_r1_condition (  ) {
        ///METHOD_BODY_START n04_r1_condition
        /*//if (?p3_know_morgan_cin = false)*/
        return !GameFlags.P3KnowMorganCin;
        ///METHOD_BODY_END n04_r1_condition
    }

    ///METHOD n12_r1_condition
    public bool n12_r1_condition (  ) {
        ///METHOD_BODY_START n12_r1_condition
        /*//if (?p3_asked_parker = false)*/
        return !DialogGameFlags.p3_asked_parker;
        ///METHOD_BODY_END n12_r1_condition
    }

    ///METHOD n13_r0_condition
    public bool n13_r0_condition (  ) {
        ///METHOD_BODY_START n13_r0_condition
        /*//if (?p3_ask_millie = false)*/
        return !GameFlags.P3AskMilllie;
        ///METHOD_BODY_END n13_r0_condition
    }

    ///METHOD n15_r1_condition
    public bool n15_r1_condition (  ) {
        ///METHOD_BODY_START n15_r1_condition
        /*//if (?p3_ask_millie = false)*/
        return !GameFlags.P3AskMilllie;
        ///METHOD_BODY_END n15_r1_condition
    }

    ///METHOD n10_r1_select
    public void n10_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r1_select
        /*//set ?p3_asked_parker = true*/
        DialogGameFlags.p3_asked_parker = true;
        ///METHOD_BODY_END n10_r1_select
    }

    ///METHOD n10_r2_select
    public void n10_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r2_select
        /*//set ?p3_ask_millie = true*/
        GameFlags.P3AskMilllie = true;
        ///METHOD_BODY_END n10_r2_select
    }

    ///METHOD n12_r0_select
    public void n12_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n12_r0_select
        /*//set ?p3_want_meet_millie = true*/
        DialogGameFlags.p3_want_meet_millie = true;
        ///METHOD_BODY_END n12_r0_select
    }

    ///METHOD n12_r1_select
    public void n12_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n12_r1_select
        /*//set ?p3_asked_parker = true*/
        DialogGameFlags.p3_asked_parker = true;
        ///METHOD_BODY_END n12_r1_select
    }

    ///METHOD n12_r2_select
    public void n12_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n12_r2_select
        /*//set ?p3_lucy_millie_interest = true*/
        GameFlags.P3LucyMillieInterest = true;
        ///METHOD_BODY_END n12_r2_select
    }

    ///METHOD n13_r0_select
    public void n13_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n13_r0_select
        /*//set ?p3_ask_millie = true*/
        GameFlags.P3AskMilllie = true;
        ///METHOD_BODY_END n13_r0_select
    }

    ///METHOD n13_r1_select
    public void n13_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n13_r1_select
        /*//set ?p3_lucy_parker_interest = true*/
        GameFlags.P3LucyParkerInterest = true;
        ///METHOD_BODY_END n13_r1_select
    }

    ///METHOD n15_r0_select
    public void n15_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15_r0_select
        /*//set ?p3_lucy_parker_interest = true*/
        GameFlags.P3LucyParkerInterest = true;
        ///METHOD_BODY_END n15_r0_select
    }

    ///METHOD n15_r1_select
    public void n15_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15_r1_select
        /*//set ?p3_ask_millie = true*/
        GameFlags.P3AskMilllie = true;
        ///METHOD_BODY_END n15_r1_select
    }

    ///METHOD n15_r2_select
    public void n15_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15_r2_select
        /*//set ?p3_want_meet_parker = true*/
        DialogGameFlags.p3_want_meet_parker = true;
        ///METHOD_BODY_END n15_r2_select
    }

    ///METHOD n22_r1_select
    public void n22_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n22_r1_select
        /*//set ?p3_asked_canada = true*/
        GameFlags.P3AskedCanada = true;
        ///METHOD_BODY_END n22_r1_select
    }

    ///METHOD n23_r0_select
    public void n23_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r0_select
        /*//set ?p3_lucy_knows_law = true*/
        DialogGameFlags.p3_lucy_knows_law = true;
        ///METHOD_BODY_END n23_r0_select
    }

    ///METHOD n23_r1_select
    public void n23_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r1_select
        /*//set ?p3_lucy_knows_law = true*/
        DialogGameFlags.p3_lucy_knows_law = true;
        ///METHOD_BODY_END n23_r1_select
    }
}
//CLASS_END Dialog_p3_abi_001
