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
//CLASS Dialog_p0_gma_001
public class Dialog_p0_gma_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _looked_book
        private bool _looked_book = false;

        //PROPERTY looked_book
        public bool looked_book {
                get {
                        ///PROPERTY_GETTER_START looked_book
                        return _looked_book;
                        ///PROPERTY_GETTER_END looked_book
                }
                set {
                        ///PROPERTY_SETTER_START looked_book
                        _looked_book = value;
                        ///PROPERTY_SETTER_END looked_book
                }
        }

        //PROPERTY _looked_photo
        private bool _looked_photo = false;

        //PROPERTY looked_photo
        public bool looked_photo {
                get {
                        ///PROPERTY_GETTER_START looked_photo
                        return _looked_photo;
                        ///PROPERTY_GETTER_END looked_photo
                }
                set {
                        ///PROPERTY_SETTER_START looked_photo
                        _looked_photo = value;
                        ///PROPERTY_SETTER_END looked_photo
                }
        }

        //PROPERTY _looked_pin
        private bool _looked_pin = false;

        //PROPERTY looked_pin
        public bool looked_pin {
                get {
                        ///PROPERTY_GETTER_START looked_pin
                        return _looked_pin;
                        ///PROPERTY_GETTER_END looked_pin
                }
                set {
                        ///PROPERTY_SETTER_START looked_pin
                        _looked_pin = value;
                        ///PROPERTY_SETTER_END looked_pin
                }
        }

        //PROPERTY _memory
        private bool _memory = false;

        //PROPERTY memory
        public bool memory {
                get {
                        ///PROPERTY_GETTER_START memory
                        return _memory;
                        ///PROPERTY_GETTER_END memory
                }
                set {
                        ///PROPERTY_SETTER_START memory
                        _memory = value;
                        ///PROPERTY_SETTER_END memory
                }
        }

        //PROPERTY _saw_n06
        private bool _saw_n06 = false;

        //PROPERTY saw_n06
        public bool saw_n06 {
                get {
                        ///PROPERTY_GETTER_START saw_n06
                        return _saw_n06;
                        ///PROPERTY_GETTER_END saw_n06
                }
                set {
                        ///PROPERTY_SETTER_START saw_n06
                        _saw_n06 = value;
                        ///PROPERTY_SETTER_END saw_n06
                }
        }

        //PROPERTY _think_more
        private bool _think_more = false;

        //PROPERTY think_more
        public bool think_more {
                get {
                        ///PROPERTY_GETTER_START think_more
                        return _think_more;
                        ///PROPERTY_GETTER_END think_more
                }
                set {
                        ///PROPERTY_SETTER_START think_more
                        _think_more = value;
                        ///PROPERTY_SETTER_END think_more
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
        ///DIALOG_ID p0_gma_001
        var dialog = new Dialog();
        dialog.Id = "p0_gma_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 Sit with me for a minute, Verna, and help me remember.
        prompt.Text = "Sit with me for a minute, Verna, and help me remember.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 I miss him so much.
        response.Text = "I miss him so much.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 I was thinking about his stories.
        response.Text = "I was thinking about his stories.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n04
        response.NextNodeId = "n04";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 What's that you are looking at?
        response.Text = "What's that you are looking at?";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n01
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 Me too. Your grandfather and I knew each other our whole lives. His family sharecropped on the same plantation as mine.
        prompt.Text = "Me too. Your grandfather and I knew each other our whole lives. His family sharecropped on the same plantation as mine.";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What's your favorite memory with him?
        response.Text = "What's your favorite memory with him?";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n05
        response.NextNodeId = "n05";
        response.OnSelect(n03_r0_select);
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 What's that you are looking at?
        response.Text = "What's that you are looking at?";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n06
        response.NextNodeId = "n06";
        response.OnSelect(n03_r1_select);
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 He couldn't resist telling stories, especially for you youngsters.
        prompt.Text = "He couldn't resist telling stories, especially for you youngsters.";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n04_p0_condition);
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 What is your favorite memory with him?
        response.Text = "What is your favorite memory with him?";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n05
        response.NextNodeId = "n05";
        response.OnSelect(n04_r0_select);
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 What's that you are looking at?
        response.Text = "What's that you are looking at?";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n06
        response.NextNodeId = "n06";
        response.OnSelect(n04_r1_select);
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 I've just been going through his things. My, these bring me back.
        prompt.Text = "I've just been going through his things. My, these bring me back.";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n05 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 1 I don't suppose I know how to answer that. I've been going through his things to remind me of our younger years.
        prompt.Text = "I don't suppose I know how to answer that. I've been going through his things to remind me of our younger years.";
        ///PROMPT_IGNORE_VO n05 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n05_p1_condition);
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 What did you find?
        response.Text = "What did you find?";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n06
        response.NextNodeId = "n06";
        response.OnSelect(n05_r0_select);
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 [Shows you] These are three of your grandfather's most treasured possessions.
        prompt.Text = "[Shows you] These are three of your grandfather's most treasured possessions.";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n06_p0_show);
        
        ///PROMPT n06 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 1 Would you like to look at one of the others?
        prompt.Text = "Would you like to look at one of the others?";
        ///PROMPT_IGNORE_VO n06 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n06_p1_condition);
        
        ///PROMPT n06 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 2 So that's what I've been thinking about up here.
        prompt.Text = "So that's what I've been thinking about up here.";
        ///PROMPT_IGNORE_VO n06 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n06_p2_condition);
        
        ///PROMPT n06 3
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 3 Sure, honey. Which one would you like to look at?
        prompt.Text = "Sure, honey. Which one would you like to look at?";
        ///PROMPT_IGNORE_VO n06 3 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n06_p3_condition);
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [Look at book again]
        response.Text = "[Look at book again]";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 z_book
        response.NextNodeId = "z_book";
        response.SetCondition(n06_r0_condition);
        response.OnSelect(n06_r0_select);
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 [Look at photo again]
        response.Text = "[Look at photo again]";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 z_photo
        response.NextNodeId = "z_photo";
        response.SetCondition(n06_r1_condition);
        response.OnSelect(n06_r1_select);
        
        ///RESPONSE n06 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 2 [Look at pin again]
        response.Text = "[Look at pin again]";
        ///RESPONSE_NEXT_NODE_TYPE n06 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 2 z_pin
        response.NextNodeId = "z_pin";
        response.SetCondition(n06_r2_condition);
        
        ///RESPONSE n06 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 3 [Look at book: James Weldon Johnson, God's Trombones]
        response.Text = "[Look at book: James Weldon Johnson, God's Trombones]";
        ///RESPONSE_NEXT_NODE_TYPE n06 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 3 n07a
        response.NextNodeId = "n07a";
        response.SetCondition(n06_r3_condition);
        response.OnSelect(n06_r3_select);
        
        ///RESPONSE n06 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 4 [Look at pin]
        response.Text = "[Look at pin]";
        ///RESPONSE_NEXT_NODE_TYPE n06 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 4 n08
        response.NextNodeId = "n08";
        response.SetCondition(n06_r4_condition);
        response.OnSelect(n06_r4_select);
        
        ///RESPONSE n06 5
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 5 [Look at photo]
        response.Text = "[Look at photo]";
        ///RESPONSE_NEXT_NODE_TYPE n06 5 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 5 n09
        response.NextNodeId = "n09";
        response.SetCondition(n06_r5_condition);
        response.OnSelect(n06_r5_select);
        
        ///RESPONSE n06 6
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 6 Thank you for letting me look at these.
        response.Text = "Thank you for letting me look at these.";
        ///RESPONSE_NEXT_NODE_TYPE n06 6 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 6 n11
        response.NextNodeId = "n11";
        response.SetCondition(n06_r6_condition);
        
        ///NODE_END n06
        ///NODE_START n07a
        node = dialog.CreateNode("n07a");
        ///NODE_NPC n07a 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n07a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07a Full
        ///NODE_VISUAL_USESCRIPT n07a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07a~|||~
        ///PROMPT n07a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07a 0 Reading from the page was difficult for him; he didn't have much chance to learn when he was younger. But he loved those poems, so he went over them so many times that he learned them by heart.
        prompt.Text = "Reading from the page was difficult for him; he didn't have much chance to learn when he was younger. But he loved those poems, so he went over them so many times that he learned them by heart.";
        ///PROMPT_IGNORE_VO n07a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07a 0 [See if you can find one of the poems you remember]
        response.Text = "[See if you can find one of the poems you remember]";
        ///RESPONSE_NEXT_NODE_TYPE n07a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07a 0 z_book
        response.NextNodeId = "z_book";
        
        ///RESPONSE n07a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07a 1 [Look at one of the other objects]
        response.Text = "[Look at one of the other objects]";
        ///RESPONSE_NEXT_NODE_TYPE n07a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07a 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n07a
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Oooh, this one takes me back! You are too young to remember the UNIA …
        prompt.Text = "Oooh, this one takes me back! You are too young to remember the UNIA …";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n08_p0_condition);
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 What's the UNIA?
        response.Text = "What's the UNIA?";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n08a
        response.NextNodeId = "n08a";
        
        ///NODE_END n08
        ///NODE_START n08a
        node = dialog.CreateNode("n08a");
        ///NODE_NPC n08a Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n08a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08a Full
        ///NODE_VISUAL_USESCRIPT n08a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08a~|||~
        ///PROMPT n08a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08a 0 [Memory] There was a man named Marcus Garvey, a Jamaican, who wanted all black people around the world to unite in pride of their African heritage. The Universal Negro Improvement Association was his vision of our becoming one united and independent community.
        prompt.Text = "[Memory] There was a man named Marcus Garvey, a Jamaican, who wanted all black people around the world to unite in pride of their African heritage. The Universal Negro Improvement Association was his vision of our becoming one united and independent community.";
        ///PROMPT_IGNORE_VO n08a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08a 0 Did it work?
        response.Text = "Did it work?";
        ///RESPONSE_NEXT_NODE_TYPE n08a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08a 0 n08b
        response.NextNodeId = "n08b";
        
        ///RESPONSE n08a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08a 1 Granddaddy said once that he wanted to visit Africa …
        response.Text = "Granddaddy said once that he wanted to visit Africa …";
        ///RESPONSE_NEXT_NODE_TYPE n08a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08a 1 n08b
        response.NextNodeId = "n08b";
        
        ///NODE_END n08a
        ///NODE_START n08b
        node = dialog.CreateNode("n08b");
        ///NODE_NPC n08b Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n08b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08b Full
        ///NODE_VISUAL_USESCRIPT n08b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08b~|||~
        ///PROMPT n08b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08b 0 [Memory, continued] I wish, but it didn't last. Garvey had some powerful ideas, but he he got in trouble over some bad business decisions. In the end, the white man found a way to put him in prison. But your Granddaddy never gave up on the vision of black unity.
        prompt.Text = "[Memory, continued] I wish, but it didn't last. Garvey had some powerful ideas, but he he got in trouble over some bad business decisions. In the end, the white man found a way to put him in prison. But your Granddaddy never gave up on the vision of black unity.";
        ///PROMPT_IGNORE_VO n08b 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08b 0 [Examine the pin]
        response.Text = "[Examine the pin]";
        ///RESPONSE_NEXT_NODE_TYPE n08b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08b 0 z_pin
        response.NextNodeId = "z_pin";
        response.OnSelect(n08b_r0_select);
        
        ///NODE_END n08b
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 [Warm laugh] That's me and your grandfather, can you believe it! This was the first trip on the school bus route we helped put together.
        prompt.Text = "[Warm laugh] That's me and your grandfather, can you believe it! This was the first trip on the school bus route we helped put together.";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n09_p0_condition);
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 You started a school bus route? Doesn't the school do that?
        response.Text = "You started a school bus route? Doesn't the school do that?";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n09a
        response.NextNodeId = "n09a";
        
        ///NODE_END n09
        ///NODE_START n09a
        node = dialog.CreateNode("n09a");
        ///NODE_NPC n09a Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n09a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09a Full
        ///NODE_VISUAL_USESCRIPT n09a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09a~|||~
        ///PROMPT n09a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09a 0 When your parents were young, only white schools offered bus service. Black kids were expected to walk to their schools.
        prompt.Text = "When your parents were young, only white schools offered bus service. Black kids were expected to walk to their schools.";
        ///PROMPT_IGNORE_VO n09a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09a 0 Walk! How far?
        response.Text = "Walk! How far?";
        ///RESPONSE_NEXT_NODE_TYPE n09a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09a 0 n09b
        response.NextNodeId = "n09b";
        
        ///RESPONSE n09a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09a 1 I know, Dad likes to remind me whenever I'm late getting up for school.
        response.Text = "I know, Dad likes to remind me whenever I'm late getting up for school.";
        ///RESPONSE_NEXT_NODE_TYPE n09a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09a 1 n09b
        response.NextNodeId = "n09b";
        
        ///NODE_END n09a
        ///NODE_START n09b
        node = dialog.CreateNode("n09b");
        ///NODE_NPC n09b Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n09b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09b Full
        ///NODE_VISUAL_USESCRIPT n09b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09b~|||~
        ///PROMPT n09b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09b 0 It was a five mile walk in all kinds of nasty weather. Since the school board refused to pay for a bus, one of the teachers put out a call to organize our own service. We put seats in the back of a truck, and all the parents chipped in for gas, even if it was just a nickel. Your granddaddy volunteered to drive it that first year!
        prompt.Text = "It was a five mile walk in all kinds of nasty weather. Since the school board refused to pay for a bus, one of the teachers put out a call to organize our own service. We put seats in the back of a truck, and all the parents chipped in for gas, even if it was just a nickel. Your granddaddy volunteered to drive it that first year!";
        ///PROMPT_IGNORE_VO n09b 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09b 0 [Look closer at the photo]
        response.Text = "[Look closer at the photo]";
        ///RESPONSE_NEXT_NODE_TYPE n09b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09b 0 z_photo
        response.NextNodeId = "z_photo";
        
        ///NODE_END n09b
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 Your grandfather wanted you to have a bright future. Why don't you take one of these things with you to Greenwood to keep him close?
        prompt.Text = "Your grandfather wanted you to have a bright future. Why don't you take one of these things with you to Greenwood to keep him close?";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n11 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 1 Have you thought about it a little more?
        prompt.Text = "Have you thought about it a little more?";
        ///PROMPT_IGNORE_VO n11 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n11_p1_condition);
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 [Choose the book of poems; you know the power of words.]
        response.Text = "[Choose the book of poems; you know the power of words.]";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 [Choose the pin; you have big dreams for change.]
        response.Text = "[Choose the pin; you have big dreams for change.]";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n11 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 2 [Choose the photo: you believe you need to work together to make a difference.]
        response.Text = "[Choose the photo: you believe you need to work together to make a difference.]";
        ///RESPONSE_NEXT_NODE_TYPE n11 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 2 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n11 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 3 I'm not sure. Can I look at them some more?
        response.Text = "I'm not sure. Can I look at them some more?";
        ///RESPONSE_NEXT_NODE_TYPE n11 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 3 n06
        response.NextNodeId = "n06";
        response.SetCondition(n11_r3_condition);
        response.OnSelect(n11_r3_select);
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 Gma
        node.Npc = "Gma";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 Your grandfather was so proud of you. Remember to always hold your head high in Greenwood.
        prompt.Text = "Your grandfather was so proud of you. Remember to always hold your head high in Greenwood.";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 Yes, ma'am.
        response.Text = "Yes, ma'am.";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n12
        ///NODE_START z_book
        node = dialog.CreateNode("z_book");
        ///NODE_NPC z_book 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES z_book False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE z_book Popup
        ///NODE_VISUAL_USESCRIPT z_book false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~z_book~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT z_book 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT z_book 0 This is something about the book.
        prompt.Text = "This is something about the book.";
        ///PROMPT_IGNORE_VO z_book 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE z_book 0
        response = node.AddResponse();
        ///RESPONSE_TEXT z_book 0 Continue.
        response.Text = "Continue.";
        ///RESPONSE_NEXT_NODE_TYPE z_book 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID z_book 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END z_book
        ///NODE_START z_pin
        node = dialog.CreateNode("z_pin");
        ///NODE_NPC z_pin 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES z_pin False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE z_pin Popup
        ///NODE_VISUAL_USESCRIPT z_pin false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~z_pin~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT z_pin 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT z_pin 0 This is something about the pin.
        prompt.Text = "This is something about the pin.";
        ///PROMPT_IGNORE_VO z_pin 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE z_pin 0
        response = node.AddResponse();
        ///RESPONSE_TEXT z_pin 0 Continue.
        response.Text = "Continue.";
        ///RESPONSE_NEXT_NODE_TYPE z_pin 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID z_pin 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END z_pin
        ///NODE_START z_photo
        node = dialog.CreateNode("z_photo");
        ///NODE_NPC z_photo 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES z_photo False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE z_photo Popup
        ///NODE_VISUAL_USESCRIPT z_photo false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~z_photo~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT z_photo 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT z_photo 0 This is something about the photo.
        prompt.Text = "This is something about the photo.";
        ///PROMPT_IGNORE_VO z_photo 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE z_photo 0
        response = node.AddResponse();
        ///RESPONSE_TEXT z_photo 0 Continue.
        response.Text = "Continue.";
        ///RESPONSE_NEXT_NODE_TYPE z_photo 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID z_photo 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END z_photo
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n04_p0_condition
    public bool n04_p0_condition (  ) {
        ///METHOD_BODY_START n04_p0_condition
        /*//n01b*/
        return true;
        ///METHOD_BODY_END n04_p0_condition
    }

    ///METHOD n05_p1_condition
    public bool n05_p1_condition (  ) {
        ///METHOD_BODY_START n05_p1_condition
        return DialogGameFlags.memory = true;
        ///METHOD_BODY_END n05_p1_condition
    }

    ///METHOD n06_p1_condition
    public bool n06_p1_condition (  ) {
        ///METHOD_BODY_START n06_p1_condition
        return DialogGameFlags.saw_n06;
        ///METHOD_BODY_END n06_p1_condition
    }

    ///METHOD n06_p2_condition
    public bool n06_p2_condition (  ) {
        ///METHOD_BODY_START n06_p2_condition
        return DialogGameFlags.looked_photo && DialogGameFlags.looked_pin && DialogGameFlags.looked_book;
        ///METHOD_BODY_END n06_p2_condition
    }

    ///METHOD n06_p3_condition
    public bool n06_p3_condition (  ) {
        ///METHOD_BODY_START n06_p3_condition
        return Actions.FromNode("n11");
        ///METHOD_BODY_END n06_p3_condition
    }

    ///METHOD n08_p0_condition
    public bool n08_p0_condition (  ) {
        ///METHOD_BODY_START n08_p0_condition
        /*//n06b*/
        return true;
        ///METHOD_BODY_END n08_p0_condition
    }

    ///METHOD n09_p0_condition
    public bool n09_p0_condition (  ) {
        ///METHOD_BODY_START n09_p0_condition
        /*//n06c*/
        return true;
        ///METHOD_BODY_END n09_p0_condition
    }

    ///METHOD n11_p1_condition
    public bool n11_p1_condition (  ) {
        ///METHOD_BODY_START n11_p1_condition
        return DialogGameFlags.think_more;
        ///METHOD_BODY_END n11_p1_condition
    }

    ///METHOD n06_p0_show
    public void n06_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n06_p0_show
        DialogGameFlags.saw_n06 = true;
        ///METHOD_BODY_END n06_p0_show
    }

    ///METHOD n06_r0_condition
    public bool n06_r0_condition (  ) {
        ///METHOD_BODY_START n06_r0_condition
        /*p0_looked_book*/
        return DialogGameFlags.looked_book;
        ///METHOD_BODY_END n06_r0_condition
    }

    ///METHOD n06_r1_condition
    public bool n06_r1_condition (  ) {
        ///METHOD_BODY_START n06_r1_condition
        /*p0_looked_photo*/
        return DialogGameFlags.looked_photo;
        ///METHOD_BODY_END n06_r1_condition
    }

    ///METHOD n06_r2_condition
    public bool n06_r2_condition (  ) {
        ///METHOD_BODY_START n06_r2_condition
        /*p0_looked_pin*/
        return DialogGameFlags.looked_pin;
        ///METHOD_BODY_END n06_r2_condition
    }

    ///METHOD n06_r3_condition
    public bool n06_r3_condition (  ) {
        ///METHOD_BODY_START n06_r3_condition
        /*!p0_looked_book*/
        return !DialogGameFlags.looked_book;
        ///METHOD_BODY_END n06_r3_condition
    }

    ///METHOD n06_r4_condition
    public bool n06_r4_condition (  ) {
        ///METHOD_BODY_START n06_r4_condition
        /*!p0_looked_pin*/
        return !DialogGameFlags.looked_pin;
        ///METHOD_BODY_END n06_r4_condition
    }

    ///METHOD n06_r5_condition
    public bool n06_r5_condition (  ) {
        ///METHOD_BODY_START n06_r5_condition
        /*!p0_looked_photo*/
        return !DialogGameFlags.looked_photo;
        ///METHOD_BODY_END n06_r5_condition
    }

    ///METHOD n06_r6_condition
    public bool n06_r6_condition (  ) {
        ///METHOD_BODY_START n06_r6_condition
        return DialogGameFlags.looked_photo && DialogGameFlags.looked_pin && DialogGameFlags.looked_book;
        ///METHOD_BODY_END n06_r6_condition
    }

    ///METHOD n11_r3_condition
    public bool n11_r3_condition (  ) {
        ///METHOD_BODY_START n11_r3_condition
        return !DialogGameFlags.think_more;
        ///METHOD_BODY_END n11_r3_condition
    }

    ///METHOD n03_r0_select
    public void n03_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r0_select
        DialogGameFlags.memory = true;
        ///METHOD_BODY_END n03_r0_select
    }

    ///METHOD n03_r1_select
    public void n03_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r1_select
        /*//n03b*/
        ///METHOD_BODY_END n03_r1_select
    }

    ///METHOD n04_r0_select
    public void n04_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n04_r0_select
        DialogGameFlags.memory = true;
        ///METHOD_BODY_END n04_r0_select
    }

    ///METHOD n04_r1_select
    public void n04_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n04_r1_select
        /*//n04b*/
        ///METHOD_BODY_END n04_r1_select
    }

    ///METHOD n05_r0_select
    public void n05_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r0_select
        /*//n05a*/
        ///METHOD_BODY_END n05_r0_select
    }

    ///METHOD n06_r0_select
    public void n06_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r0_select
        /*[Launch book]*/
        ///METHOD_BODY_END n06_r0_select
    }

    ///METHOD n06_r1_select
    public void n06_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r1_select
        /*[Launch photo]*/
        ///METHOD_BODY_END n06_r1_select
    }

    ///METHOD n06_r3_select
    public void n06_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r3_select
        DialogGameFlags.looked_book = true;
        ///METHOD_BODY_END n06_r3_select
    }

    ///METHOD n06_r4_select
    public void n06_r4_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r4_select
        DialogGameFlags.looked_pin = true;
        ///METHOD_BODY_END n06_r4_select
    }

    ///METHOD n06_r5_select
    public void n06_r5_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r5_select
        DialogGameFlags.looked_photo = true;
        ///METHOD_BODY_END n06_r5_select
    }

    ///METHOD n08b_r0_select
    public void n08b_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08b_r0_select
        /*[Launch pin colors] > n06*/
        ///METHOD_BODY_END n08b_r0_select
    }

    ///METHOD n11_r3_select
    public void n11_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r3_select
        DialogGameFlags.think_more = true;
        ///METHOD_BODY_END n11_r3_select
    }
}
//CLASS_END Dialog_p0_gma_001
