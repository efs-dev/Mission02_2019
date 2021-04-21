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
//CLASS Dialog_p0_rob_sal_001
public class Dialog_p0_rob_sal_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _asksally
        private bool _asksally = false;

        //PROPERTY asksally
        public bool asksally {
                get {
                        ///PROPERTY_GETTER_START asksally
                        return _asksally;
                        ///PROPERTY_GETTER_END asksally
                }
                set {
                        ///PROPERTY_SETTER_START asksally
                        _asksally = value;
                        ///PROPERTY_SETTER_END asksally
                }
        }

        //PROPERTY _change
        private bool _change = false;

        //PROPERTY change
        public bool change {
                get {
                        ///PROPERTY_GETTER_START change
                        return _change;
                        ///PROPERTY_GETTER_END change
                }
                set {
                        ///PROPERTY_SETTER_START change
                        _change = value;
                        ///PROPERTY_SETTER_END change
                }
        }

        //PROPERTY _cold
        private bool _cold = false;

        //PROPERTY cold
        public bool cold {
                get {
                        ///PROPERTY_GETTER_START cold
                        return _cold;
                        ///PROPERTY_GETTER_END cold
                }
                set {
                        ///PROPERTY_SETTER_START cold
                        _cold = value;
                        ///PROPERTY_SETTER_END cold
                }
        }

        //PROPERTY _granddaddy
        private bool _granddaddy = false;

        //PROPERTY granddaddy
        public bool granddaddy {
                get {
                        ///PROPERTY_GETTER_START granddaddy
                        return _granddaddy;
                        ///PROPERTY_GETTER_END granddaddy
                }
                set {
                        ///PROPERTY_SETTER_START granddaddy
                        _granddaddy = value;
                        ///PROPERTY_SETTER_END granddaddy
                }
        }

        //PROPERTY _heat
        private bool _heat = false;

        //PROPERTY heat
        public bool heat {
                get {
                        ///PROPERTY_GETTER_START heat
                        return _heat;
                        ///PROPERTY_GETTER_END heat
                }
                set {
                        ///PROPERTY_SETTER_START heat
                        _heat = value;
                        ///PROPERTY_SETTER_END heat
                }
        }

        //PROPERTY _job
        private bool _job = false;

        //PROPERTY job
        public bool job {
                get {
                        ///PROPERTY_GETTER_START job
                        return _job;
                        ///PROPERTY_GETTER_END job
                }
                set {
                        ///PROPERTY_SETTER_START job
                        _job = value;
                        ///PROPERTY_SETTER_END job
                }
        }

        //PROPERTY _n25
        private bool _n25 = false;

        //PROPERTY n25
        public bool n25 {
                get {
                        ///PROPERTY_GETTER_START n25
                        return _n25;
                        ///PROPERTY_GETTER_END n25
                }
                set {
                        ///PROPERTY_SETTER_START n25
                        _n25 = value;
                        ///PROPERTY_SETTER_END n25
                }
        }

        //PROPERTY _n26b
        private bool _n26b = false;

        //PROPERTY n26b
        public bool n26b {
                get {
                        ///PROPERTY_GETTER_START n26b
                        return _n26b;
                        ///PROPERTY_GETTER_END n26b
                }
                set {
                        ///PROPERTY_SETTER_START n26b
                        _n26b = value;
                        ///PROPERTY_SETTER_END n26b
                }
        }

        //PROPERTY _sallyalt
        private bool _sallyalt = false;

        //PROPERTY sallyalt
        public bool sallyalt {
                get {
                        ///PROPERTY_GETTER_START sallyalt
                        return _sallyalt;
                        ///PROPERTY_GETTER_END sallyalt
                }
                set {
                        ///PROPERTY_SETTER_START sallyalt
                        _sallyalt = value;
                        ///PROPERTY_SETTER_END sallyalt
                }
        }

        //PROPERTY _UNIA
        private bool _UNIA = false;

        //PROPERTY UNIA
        public bool UNIA {
                get {
                        ///PROPERTY_GETTER_START UNIA
                        return _UNIA;
                        ///PROPERTY_GETTER_END UNIA
                }
                set {
                        ///PROPERTY_SETTER_START UNIA
                        _UNIA = value;
                        ///PROPERTY_SETTER_END UNIA
                }
        }

        //PROPERTY _whitefolks
        private bool _whitefolks = false;

        //PROPERTY whitefolks
        public bool whitefolks {
                get {
                        ///PROPERTY_GETTER_START whitefolks
                        return _whitefolks;
                        ///PROPERTY_GETTER_END whitefolks
                }
                set {
                        ///PROPERTY_SETTER_START whitefolks
                        _whitefolks = value;
                        ///PROPERTY_SETTER_END whitefolks
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
        ///DIALOG_ID p0_rob_sal_001
        var dialog = new Dialog();
        dialog.Id = "p0_rob_sal_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You spot a gangly teenager dressed to the nines (triple pleated pants, collar shirt, maybe suspenders)...could that be...?
        prompt.Text = "You spot a gangly teenager dressed to the nines (triple pleated pants, collar shirt, maybe suspenders)...could that be...?";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Wave] Robert!
        response.Text = "[Wave] Robert!";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n01b
        response.NextNodeId = "n01b";
        
        ///NODE_END n01
        ///NODE_START n01b
        node = dialog.CreateNode("n01b");
        ///NODE_NPC n01b ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n01b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01b Full
        ///NODE_VISUAL_USESCRIPT n01b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01b~|||~
        node.OnShow(n01b_show);
        ///PROMPT n01b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01b 0 Verna? Hey there little cuz!
        prompt.Text = "Verna? Hey there little cuz!";
        ///PROMPT_IGNORE_VO n01b 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01b 0 Wow, you look different! Those pants!
        response.Text = "Wow, you look different! Those pants!";
        ///RESPONSE_NEXT_NODE_TYPE n01b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01b 0 n02
        response.NextNodeId = "n02";
        
        ///RESPONSE n01b 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01b 1 We missed you! Five years is too long.
        response.Text = "We missed you! Five years is too long.";
        ///RESPONSE_NEXT_NODE_TYPE n01b 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01b 1 n03
        response.NextNodeId = "n03";
        
        ///NODE_END n01b
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Three pleats, see? It looks good when I walk. Got the sweater too, but I'm sweating as it is.
        prompt.Text = "Three pleats, see? It looks good when I walk. Got the sweater too, but I'm sweating as it is.";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 No offense, but I'm used to seeing a man in denim overalls … like Grandaddy.
        response.Text = "No offense, but I'm used to seeing a man in denim overalls … like Grandaddy.";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Only five years and you can't take the heat here?
        response.Text = "Only five years and you can't take the heat here?";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n03
        response.NextNodeId = "n03";
        response.OnSelect(n02_r1_select);
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 I wish I'd gotten to see Granddaddy. But Mama wouldn't let me within a hundred miles of this place after what happened.
        prompt.Text = "I wish I'd gotten to see Granddaddy. But Mama wouldn't let me within a hundred miles of this place after what happened.";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n03 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 1 Not my fault it's been five years! You know Mama wouldn't let me within a hundred miles of this place after what happend.
        prompt.Text = "Not my fault it's been five years! You know Mama wouldn't let me within a hundred miles of this place after what happend.";
        ///PROMPT_IGNORE_VO n03 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n03_p1_condition);
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 That could have been you instead of Emmett Till. You came here every summer.
        response.Text = "That could have been you instead of Emmett Till. You came here every summer.";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n04
        response.NextNodeId = "n04";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 My mama wouldn't let Junior whistle any more … ever.
        response.Text = "My mama wouldn't let Junior whistle any more … ever.";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 Yeah. Chicago isn't exactly safe. But at least I can whistle without risking my life. You should come visit us!
        prompt.Text = "Yeah. Chicago isn't exactly safe. But at least I can whistle without risking my life. You should come visit us!";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 You can make more money there, right?
        response.Text = "You can make more money there, right?";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n11
        response.NextNodeId = "n11";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 What's your school like?
        response.Text = "What's your school like?";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n09
        response.NextNodeId = "n09";
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 I would love to! Maybe after I'm back from Greenwood.
        response.Text = "I would love to! Maybe after I'm back from Greenwood.";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n04 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 3 Nah, it's too cold up there.
        response.Text = "Nah, it's too cold up there.";
        ///RESPONSE_NEXT_NODE_TYPE n04 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 3 n05
        response.NextNodeId = "n05";
        response.OnSelect(n04_r3_select);
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 Grandma says you're moving there for high school. You think its going to be any better?
        prompt.Text = "Grandma says you're moving there for high school. You think its going to be any better?";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n05 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 1 That's what coats are for! Anyway, I hear you're moving to Greenwood for high school. You think its going to be any better?
        prompt.Text = "That's what coats are for! Anyway, I hear you're moving to Greenwood for high school. You think its going to be any better?";
        ///PROMPT_IGNORE_VO n05 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n05_p1_condition);
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 I really hope so. What's your school like?
        response.Text = "I really hope so. What's your school like?";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n09
        response.NextNodeId = "n09";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 I'm not sure, but I need a change.
        response.Text = "I'm not sure, but I need a change.";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Then you should definitely come up North.
        prompt.Text = "Then you should definitely come up North.";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 How's it different?
        response.Text = "How's it different?";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 What's your school like?
        response.Text = "What's your school like?";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 For starters, I don't have to worry about what I say … and I can pretty much go where I like.
        prompt.Text = "For starters, I don't have to worry about what I say … and I can pretty much go where I like.";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 Pretty much?
        response.Text = "Pretty much?";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 What about the schools?
        response.Text = "What about the schools?";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n09
        response.NextNodeId = "n09";
        
        ///RESPONSE n07 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 2 Do you mix with white folks there?
        response.Text = "Do you mix with white folks there?";
        ///RESPONSE_NEXT_NODE_TYPE n07 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 2 n08
        response.NextNodeId = "n08";
        response.OnSelect(n07_r2_select);
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 I can sit on a bus same as anyone, but there's still an invisible line between the black and white neighborhoods. They don't cross into our world, and we don't spend time in theirs.
        prompt.Text = "I can sit on a bus same as anyone, but there's still an invisible line between the black and white neighborhoods. They don't cross into our world, and we don't spend time in theirs.";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n08 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 1 Dad works with some whites at the stockyard, but that's about it. There's still an invisible line between the black and white neighborhoods. They don't cross into our world, and we don't spend time in theirs.
        prompt.Text = "Dad works with some whites at the stockyard, but that's about it. There's still an invisible line between the black and white neighborhoods. They don't cross into our world, and we don't spend time in theirs.";
        ///PROMPT_IGNORE_VO n08 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n08_p1_condition);
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 [Someone walks up to join you …]
        response.Text = "[Someone walks up to join you …]";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n21
        response.NextNodeId = "n21";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 The teachers aren't bad … but our building's gotten so crowded that they have us taking classes in shifts. I hear the white schools are half empty.
        prompt.Text = "The teachers aren't bad … but our building's gotten so crowded that they have us taking classes in shifts. I hear the white schools are half empty.";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 [Someone walks up to join you …]
        response.Text = "[Someone walks up to join you …]";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n21
        response.NextNodeId = "n21";
        
        ///NODE_END n09
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 That's what they say. At the stockyards, my dad says he makes almost as much in a few days as he used to make in the Delta in a month.
        prompt.Text = "That's what they say. At the stockyards, my dad says he makes almost as much in a few days as he used to make in the Delta in a month.";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 That's so much!
        response.Text = "That's so much!";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 So are you going to get a job there?
        response.Text = "So are you going to get a job there?";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n13
        response.NextNodeId = "n13";
        response.OnSelect(n11_r1_select);
        
        ///RESPONSE n11 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 2 Well that explains why half of the Delta has moved up there.
        response.Text = "Well that explains why half of the Delta has moved up there.";
        ///RESPONSE_NEXT_NODE_TYPE n11 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 2 n12
        response.NextNodeId = "n12";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 But forget the stockyards, Chicago is really about the music. You know the best musicians come out of the South Side … Earl Hooker, Bo Diddley, Elmore James, Sam Cooke!
        prompt.Text = "But forget the stockyards, Chicago is really about the music. You know the best musicians come out of the South Side … Earl Hooker, Bo Diddley, Elmore James, Sam Cooke!";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 You know they're all from Mississippi, right?
        response.Text = "You know they're all from Mississippi, right?";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 When did you start listening to the Blues?
        response.Text = "When did you start listening to the Blues?";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n13
        response.NextNodeId = "n13";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 For a while, actually. I'm learning the guitar. Maybe when I get to college I'll join a band.
        prompt.Text = "For a while, actually. I'm learning the guitar. Maybe when I get to college I'll join a band.";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n13 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 1 Nah, not if I can help it. I'm learning guitar. Maybe when I get to college I'll join a band.
        prompt.Text = "Nah, not if I can help it. I'm learning guitar. Maybe when I get to college I'll join a band.";
        ///PROMPT_IGNORE_VO n13 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n13_p1_condition);
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 [Someone walks up to join you …]
        response.Text = "[Someone walks up to join you …]";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n21
        response.NextNodeId = "n21";
        
        ///NODE_END n13
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 SAL
        node.Npc = "SAL";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Full
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n21~|||~
        node.OnShow(n21_show);
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 Verna! There you are!
        prompt.Text = "Verna! There you are!";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 Sally! You came! And look who else made it.
        response.Text = "Sally! You came! And look who else made it.";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n22
        response.NextNodeId = "n22";
        
        ///NODE_END n21
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 SAL
        node.Npc = "SAL";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Full
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n22~|||~
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 Chicago Robert! I almost didn't recognize you.
        prompt.Text = "Chicago Robert! I almost didn't recognize you.";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n23
        response.NextNodeId = "n23";
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Full
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n23~|||~
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 How could I forget the Mischief Queen of Sunflower County. You got me in trouble with Grandma at least once a week.
        prompt.Text = "How could I forget the Mischief Queen of Sunflower County. You got me in trouble with Grandma at least once a week.";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 C'mon Robert, you enjoyed those pie heists as much as we did.
        response.Text = "C'mon Robert, you enjoyed those pie heists as much as we did.";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n24
        response.NextNodeId = "n24";
        response.OnSelect(n23_r0_select);
        
        ///RESPONSE n23 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 1 Oh please, Grandma could never stay mad at her Chicago grandson.
        response.Text = "Oh please, Grandma could never stay mad at her Chicago grandson.";
        ///RESPONSE_NEXT_NODE_TYPE n23 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 1 n24
        response.NextNodeId = "n24";
        
        ///NODE_END n23
        ///NODE_START n24
        node = dialog.CreateNode("n24");
        ///NODE_NPC n24 SAL
        node.Npc = "SAL";
        ///NODE_RANDOM_RESPONSES n24 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24 Full
        ///NODE_VISUAL_USESCRIPT n24 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n24~|||~
        ///PROMPT n24 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24 0 Verna, I'm sorry I'm so late. All the white ladies decided to shop at Mrs. Dixon's this morning. I must have been waiting two hours just to get butter and sugar.
        prompt.Text = "Verna, I'm sorry I'm so late. All the white ladies decided to shop at Mrs. Dixon's this morning. I must have been waiting two hours just to get butter and sugar.";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 Don't worry, that happens to me all the time.
        response.Text = "Don't worry, that happens to me all the time.";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 n25
        response.NextNodeId = "n25";
        
        ///RESPONSE n24 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 1 I wish there was another store we could go to.
        response.Text = "I wish there was another store we could go to.";
        ///RESPONSE_NEXT_NODE_TYPE n24 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 1 n24b
        response.NextNodeId = "n24b";
        
        ///RESPONSE n24 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 2 My grandaddy said, if there were more black-owned businesses, we wouldn't have to deal with this nonsense.
        response.Text = "My grandaddy said, if there were more black-owned businesses, we wouldn't have to deal with this nonsense.";
        ///RESPONSE_NEXT_NODE_TYPE n24 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 2 n25
        response.NextNodeId = "n25";
        response.SetCondition(n24_r2_condition);
        response.OnSelect(n24_r2_select);
        
        ///NODE_END n24
        ///NODE_START n24b
        node = dialog.CreateNode("n24b");
        ///NODE_NPC n24b SAL
        node.Npc = "SAL";
        ///NODE_RANDOM_RESPONSES n24b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24b Full
        ///NODE_VISUAL_USESCRIPT n24b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n24b~|||~
        ///PROMPT n24b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24b 0 What do you think, maybe we should start churning our own butter?
        prompt.Text = "What do you think, maybe we should start churning our own butter?";
        ///PROMPT_IGNORE_VO n24b 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24b 0 Just as soon as you figure out how to get milk from an old mule!
        response.Text = "Just as soon as you figure out how to get milk from an old mule!";
        ///RESPONSE_NEXT_NODE_TYPE n24b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24b 0 n25
        response.NextNodeId = "n25";
        
        ///RESPONSE n24b 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n24b 1 If we're going to churn anything, it better be ice cream.
        response.Text = "If we're going to churn anything, it better be ice cream.";
        ///RESPONSE_NEXT_NODE_TYPE n24b 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24b 1 n25
        response.NextNodeId = "n25";
        
        ///NODE_END n24b
        ///NODE_START n25
        node = dialog.CreateNode("n25");
        ///NODE_NPC n25 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n25 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n25 Full
        ///NODE_VISUAL_USESCRIPT n25 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n25~|||~
        ///PROMPT n25 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n25 0 I almost forgot about that part of living in Mississippi. You still let every white person go first?
        prompt.Text = "I almost forgot about that part of living in Mississippi. You still let every white person go first?";
        ///PROMPT_IGNORE_VO n25 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n25 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n25 1 He's right, though even in Chicago we can't do all our shopping at black-owned stores … yet. Do you still let every white person go first here?
        prompt.Text = "He's right, though even in Chicago we can't do all our shopping at black-owned stores … yet. Do you still let every white person go first here?";
        ///PROMPT_IGNORE_VO n25 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n25_p1_condition);
        
        ///RESPONSE n25 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 0 It's not really a choice.
        response.Text = "It's not really a choice.";
        ///RESPONSE_NEXT_NODE_TYPE n25 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 0 n27
        response.NextNodeId = "n27";
        response.OnSelect(n25_r0_select);
        
        ///RESPONSE n25 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 1 What else do you expect us to do?
        response.Text = "What else do you expect us to do?";
        ///RESPONSE_NEXT_NODE_TYPE n25 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 1 n26
        response.NextNodeId = "n26";
        
        ///RESPONSE n25 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 2 Yep. You could be waiting for hours.
        response.Text = "Yep. You could be waiting for hours.";
        ///RESPONSE_NEXT_NODE_TYPE n25 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 2 n27
        response.NextNodeId = "n27";
        
        ///NODE_END n25
        ///NODE_START n26
        node = dialog.CreateNode("n26");
        ///NODE_NPC n26 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n26 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26 Full
        ///NODE_VISUAL_USESCRIPT n26 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n26~|||~
        ///PROMPT n26 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26 0 A petition? A boycott? Maybe one day one of those sit-ins will reach Sunflower County.
        prompt.Text = "A petition? A boycott? Maybe one day one of those sit-ins will reach Sunflower County.";
        ///PROMPT_IGNORE_VO n26 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n26 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 0 What sit-ins?
        response.Text = "What sit-ins?";
        ///RESPONSE_NEXT_NODE_TYPE n26 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 0 n26c
        response.NextNodeId = "n26c";
        
        ///RESPONSE n26 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 1 What do you think, Sally?
        response.Text = "What do you think, Sally?";
        ///RESPONSE_NEXT_NODE_TYPE n26 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 1 n26b
        response.NextNodeId = "n26b";
        
        ///NODE_END n26
        ///NODE_START n26b
        node = dialog.CreateNode("n26b");
        ///NODE_NPC n26b SAL
        node.Npc = "SAL";
        ///NODE_RANDOM_RESPONSES n26b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26b Full
        ///NODE_VISUAL_USESCRIPT n26b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n26b~|||~
        ///PROMPT n26b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26b 0 Maybe in North Carolina or Tennessee. But come on, this is Mississippi.
        prompt.Text = "Maybe in North Carolina or Tennessee. But come on, this is Mississippi.";
        ///PROMPT_IGNORE_VO n26b 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n26b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26b 0 True. If we tried that kind of thing, Dad could lose work … or worse.
        response.Text = "True. If we tried that kind of thing, Dad could lose work … or worse.";
        ///RESPONSE_NEXT_NODE_TYPE n26b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26b 0 n27
        response.NextNodeId = "n27";
        
        ///RESPONSE n26b 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n26b 1 But how are things going to change otherwise?
        response.Text = "But how are things going to change otherwise?";
        ///RESPONSE_NEXT_NODE_TYPE n26b 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26b 1 n27
        response.NextNodeId = "n27";
        response.OnSelect(n26b_r1_select);
        
        ///RESPONSE n26b 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n26b 2 What sit-ins?
        response.Text = "What sit-ins?";
        ///RESPONSE_NEXT_NODE_TYPE n26b 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26b 2 n26c
        response.NextNodeId = "n26c";
        
        ///NODE_END n26b
        ///NODE_START n26c
        node = dialog.CreateNode("n26c");
        ///NODE_NPC n26c ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n26c False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26c Full
        ///NODE_VISUAL_USESCRIPT n26c false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n26c~|||~
        ///PROMPT n26c 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26c 0 Haven't you been reading Jet?
        prompt.Text = "Haven't you been reading Jet?";
        ///PROMPT_IGNORE_VO n26c 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n26c 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26c 0 I read it when I can, but hard to find down here.
        response.Text = "I read it when I can, but hard to find down here.";
        ///RESPONSE_NEXT_NODE_TYPE n26c 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26c 0 n26d
        response.NextNodeId = "n26d";
        
        ///RESPONSE n26c 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n26c 1 I've been busy! Can you just tell me about the sit-ins, please.
        response.Text = "I've been busy! Can you just tell me about the sit-ins, please.";
        ///RESPONSE_NEXT_NODE_TYPE n26c 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26c 1 n26d
        response.NextNodeId = "n26d";
        
        ///NODE_END n26c
        ///NODE_START n26d
        node = dialog.CreateNode("n26d");
        ///NODE_NPC n26d ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n26d False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26d Full
        ///NODE_VISUAL_USESCRIPT n26d false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n26d~|||~
        ///PROMPT n26d 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26d 0 I saved a clipping to show you -- look at this.
        prompt.Text = "I saved a clipping to show you -- look at this.";
        ///PROMPT_IGNORE_VO n26d 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n26d 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26d 0 [Take the magazine]
        response.Text = "[Take the magazine]";
        ///RESPONSE_NEXT_NODE_TYPE n26d 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26d 0 SCRIPT
        response.NextNodeId = "SCRIPT";
        response.OnSelect(n26d_r0_select);
        
        ///RESPONSE n26d 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n26d 1 No thanks.
        response.Text = "No thanks.";
        ///RESPONSE_NEXT_NODE_TYPE n26d 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26d 1 n27
        response.NextNodeId = "n27";
        response.OnSelect(n26d_r1_select);
        
        ///NODE_END n26d
        ///NODE_START n27
        node = dialog.CreateNode("n27");
        ///NODE_NPC n27 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n27 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n27 Full
        ///NODE_VISUAL_USESCRIPT n27 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n27~|||~
        ///PROMPT n27 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n27 0 This is just why my Dad left! He said it was just too dangerous to try to change things in Mississippi.
        prompt.Text = "This is just why my Dad left! He said it was just too dangerous to try to change things in Mississippi.";
        ///PROMPT_IGNORE_VO n27 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n27_p0_condition);
        
        ///PROMPT n27 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n27 1 Maybe someday something like that could happen here.
        prompt.Text = "Maybe someday something like that could happen here.";
        ///PROMPT_IGNORE_VO n27 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n27_p1_condition);
        
        ///PROMPT n27 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n27 2 You have to hope that, someday, something like that could happen here.
        prompt.Text = "You have to hope that, someday, something like that could happen here.";
        ///PROMPT_IGNORE_VO n27 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n27_p2_condition);
        
        ///RESPONSE n27 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n27 0 I don't know. Sally could say a thing or two about that.
        response.Text = "I don't know. Sally could say a thing or two about that.";
        ///RESPONSE_NEXT_NODE_TYPE n27 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n27 0 n29
        response.NextNodeId = "n29";
        response.SetCondition(n27_r0_condition);
        response.OnSelect(n27_r0_select);
        
        ///RESPONSE n27 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n27 1 I don't know. Sally could say a thing or two about that.
        response.Text = "I don't know. Sally could say a thing or two about that.";
        ///RESPONSE_NEXT_NODE_TYPE n27 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n27 1 n29
        response.NextNodeId = "n29";
        response.SetCondition(n27_r1_condition);
        
        ///RESPONSE n27 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n27 2 Well he's not wrong.
        response.Text = "Well he's not wrong.";
        ///RESPONSE_NEXT_NODE_TYPE n27 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n27 2 n29
        response.NextNodeId = "n29";
        response.SetCondition(n27_r2_condition);
        
        ///NODE_END n27
        ///NODE_START n29
        node = dialog.CreateNode("n29");
        ///NODE_NPC n29 SAL
        node.Npc = "SAL";
        ///NODE_RANDOM_RESPONSES n29 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n29 Full
        ///NODE_VISUAL_USESCRIPT n29 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n29~|||~
        ///PROMPT n29 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n29 0 Mmhmm. Last year my dad went to hear an NAACP man named Medgar Evers speak. Within a week, men from the bank were calling in our loans and my brothers got suspended from school.
        prompt.Text = "Mmhmm. Last year my dad went to hear an NAACP man named Medgar Evers speak. Within a week, men from the bank were calling in our loans and my brothers got suspended from school.";
        ///PROMPT_IGNORE_VO n29 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n29 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n29 1 Yeah, I'll tell you why. Last year my dad went to hear an NAACP leader named Medgar Evers speak. Within a week, men from the bank were calling in our loans and my brothers got suspended from school.
        prompt.Text = "Yeah, I'll tell you why. Last year my dad went to hear an NAACP leader named Medgar Evers speak. Within a week, men from the bank were calling in our loans and my brothers got suspended from school.";
        ///PROMPT_IGNORE_VO n29 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n29_p1_condition);
        
        ///RESPONSE n29 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n29 0 What do you mean, NAACP?
        response.Text = "What do you mean, NAACP?";
        ///RESPONSE_NEXT_NODE_TYPE n29 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n29 0 n29b
        response.NextNodeId = "n29b";
        
        ///RESPONSE n29 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n29 1 The same thing happened to another family.
        response.Text = "The same thing happened to another family.";
        ///RESPONSE_NEXT_NODE_TYPE n29 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n29 1 n30
        response.NextNodeId = "n30";
        
        ///RESPONSE n29 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n29 2 [Stay silent]
        response.Text = "[Stay silent]";
        ///RESPONSE_NEXT_NODE_TYPE n29 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n29 2 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n29
        ///NODE_START n29b
        node = dialog.CreateNode("n29b");
        ///NODE_NPC n29b SAL
        node.Npc = "SAL";
        ///NODE_RANDOM_RESPONSES n29b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n29b Full
        ///NODE_VISUAL_USESCRIPT n29b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n29b~|||~
        ///PROMPT n29b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n29b 0 They're the group that has been fighting against all of the segregated schools.
        prompt.Text = "They're the group that has been fighting against all of the segregated schools.";
        ///PROMPT_IGNORE_VO n29b 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n29b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n29b 0 Oh, I knew I'd heard of them.
        response.Text = "Oh, I knew I'd heard of them.";
        ///RESPONSE_NEXT_NODE_TYPE n29b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n29b 0 n30
        response.NextNodeId = "n30";
        
        ///NODE_END n29b
        ///NODE_START n30
        node = dialog.CreateNode("n30");
        ///NODE_NPC n30 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n30 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n30 Full
        ///NODE_VISUAL_USESCRIPT n30 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n30~|||~
        ///PROMPT n30 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n30 0 That's crazy! Just for going to a meeting?
        prompt.Text = "That's crazy! Just for going to a meeting?";
        ///PROMPT_IGNORE_VO n30 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n30 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n30 1 And your family had all that happen to them just for going to one of the NAACP's meetings?
        prompt.Text = "And your family had all that happen to them just for going to one of the NAACP's meetings?";
        ///PROMPT_IGNORE_VO n30 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n30_p1_condition);
        
        ///RESPONSE n30 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 0 It happens.
        response.Text = "It happens.";
        ///RESPONSE_NEXT_NODE_TYPE n30 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 0 n31
        response.NextNodeId = "n31";
        
        ///RESPONSE n30 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 1 I still don't understand what some white folks are so scared about.
        response.Text = "I still don't understand what some white folks are so scared about.";
        ///RESPONSE_NEXT_NODE_TYPE n30 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 1 n31
        response.NextNodeId = "n31";
        
        ///RESPONSE n30 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 2 I know it doesn't make sense.
        response.Text = "I know it doesn't make sense.";
        ///RESPONSE_NEXT_NODE_TYPE n30 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 2 n31
        response.NextNodeId = "n31";
        
        ///NODE_END n30
        ///NODE_START n31
        node = dialog.CreateNode("n31");
        ///NODE_NPC n31 SAL
        node.Npc = "SAL";
        ///NODE_RANDOM_RESPONSES n31 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n31 Full
        ///NODE_VISUAL_USESCRIPT n31 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n31~|||~
        ///PROMPT n31 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n31 0 All I know is, ever since Brown v. Board Education, a lot of white folks around here have been organizing to make sure nothing changes in Mississippi.
        prompt.Text = "All I know is, ever since Brown v. Board Education, a lot of white folks around here have been organizing to make sure nothing changes in Mississippi.";
        ///PROMPT_IGNORE_VO n31 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n31 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 0 Guess our organizing is going to have to get more creative.
        response.Text = "Guess our organizing is going to have to get more creative.";
        ///RESPONSE_NEXT_NODE_TYPE n31 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 0 END
        response.NextNodeId = "END";
        response.SetCondition(n31_r0_condition);
        
        ///RESPONSE n31 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 1 I wish things were different.
        response.Text = "I wish things were different.";
        ///RESPONSE_NEXT_NODE_TYPE n31 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 1 END
        response.NextNodeId = "END";
        
        ///RESPONSE n31 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 2 Change is always happening, whether they like it or not.
        response.Text = "Change is always happening, whether they like it or not.";
        ///RESPONSE_NEXT_NODE_TYPE n31 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 2 END
        response.NextNodeId = "END";
        response.OnSelect(n31_r2_select);
        
        ///NODE_END n31
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 ROB
        node.Npc = "ROB";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 Born in the Delta but raised in Chicago ... just like someone you know ...
        prompt.Text = "Born in the Delta but raised in Chicago ... just like someone you know ...";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 [Someone walks up to join you ...]
        response.Text = "[Someone walks up to join you ...]";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n21
        response.NextNodeId = "n21";
        
        ///NODE_END n14
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01b_show
    public void n01b_show ( DialogNode node ) {
        ///METHOD_BODY_START n01b_show
        Actions.SetHotspotVisible("CrkRbt", true);
        ///METHOD_BODY_END n01b_show
    }

    ///METHOD n21_show
    public void n21_show ( DialogNode node ) {
        ///METHOD_BODY_START n21_show
        Actions.SetHotspotVisible("sis", true);
        ///METHOD_BODY_END n21_show
    }

    ///METHOD n03_p1_condition
    public bool n03_p1_condition (  ) {
        ///METHOD_BODY_START n03_p1_condition
        /*//heat*/
        return DialogGameFlags.heat;
        ///METHOD_BODY_END n03_p1_condition
    }

    ///METHOD n05_p1_condition
    public bool n05_p1_condition (  ) {
        ///METHOD_BODY_START n05_p1_condition
        /*//cold*/
        return DialogGameFlags.cold;
        ///METHOD_BODY_END n05_p1_condition
    }

    ///METHOD n08_p1_condition
    public bool n08_p1_condition (  ) {
        ///METHOD_BODY_START n08_p1_condition
        /*//white folks*/
        return DialogGameFlags.whitefolks;
        ///METHOD_BODY_END n08_p1_condition
    }

    ///METHOD n13_p1_condition
    public bool n13_p1_condition (  ) {
        ///METHOD_BODY_START n13_p1_condition
        /*//job*/
        return DialogGameFlags.job;
        ///METHOD_BODY_END n13_p1_condition
    }

    ///METHOD n25_p1_condition
    public bool n25_p1_condition (  ) {
        ///METHOD_BODY_START n25_p1_condition
        /*//granddaddy*/
        return DialogGameFlags.granddaddy;
        ///METHOD_BODY_END n25_p1_condition
    }

    ///METHOD n27_p0_condition
    public bool n27_p0_condition (  ) {
        ///METHOD_BODY_START n27_p0_condition
        /*//from n25 or //n26b*/
        return DialogGameFlags.n26b || DialogGameFlags.n25;
        ///METHOD_BODY_END n27_p0_condition
    }

    ///METHOD n27_p1_condition
    public bool n27_p1_condition (  ) {
        ///METHOD_BODY_START n27_p1_condition
        /*//from JET article*/
        return true;
        ///METHOD_BODY_END n27_p1_condition
    }

    ///METHOD n27_p2_condition
    public bool n27_p2_condition (  ) {
        ///METHOD_BODY_START n27_p2_condition
        /*//change*/
        return DialogGameFlags.change;
        ///METHOD_BODY_END n27_p2_condition
    }

    ///METHOD n29_p1_condition
    public bool n29_p1_condition (  ) {
        ///METHOD_BODY_START n29_p1_condition
        /*//ask Sally*/
        return DialogGameFlags.asksally;
        ///METHOD_BODY_END n29_p1_condition
    }

    ///METHOD n30_p1_condition
    public bool n30_p1_condition (  ) {
        ///METHOD_BODY_START n30_p1_condition
        /*//from n29b*/
        return Actions.FromNode("n29b");
        ///METHOD_BODY_END n30_p1_condition
    }

    ///METHOD n24_r2_condition
    public bool n24_r2_condition (  ) {
        ///METHOD_BODY_START n24_r2_condition
        /*//If UNIA (?)*/
        return DialogGameFlags.UNIA;
        ///METHOD_BODY_END n24_r2_condition
    }

    ///METHOD n27_r0_condition
    public bool n27_r0_condition (  ) {
        ///METHOD_BODY_START n27_r0_condition
        /*//from JET article*/
        return true;
        ///METHOD_BODY_END n27_r0_condition
    }

    ///METHOD n27_r1_condition
    public bool n27_r1_condition (  ) {
        ///METHOD_BODY_START n27_r1_condition
        /*//change*/
        return DialogGameFlags.change;
        ///METHOD_BODY_END n27_r1_condition
    }

    ///METHOD n27_r2_condition
    public bool n27_r2_condition (  ) {
        ///METHOD_BODY_START n27_r2_condition
        /*//from n25 or //n26b*/
        return DialogGameFlags.n26b || DialogGameFlags.n25;
        ///METHOD_BODY_END n27_r2_condition
    }

    ///METHOD n31_r0_condition
    public bool n31_r0_condition (  ) {
        ///METHOD_BODY_START n31_r0_condition
        /*//If chose bus route artifact from grandfather*/
        return true;
        //TODO
        ///METHOD_BODY_END n31_r0_condition
    }

    ///METHOD n02_r1_select
    public void n02_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r1_select
        /*//heat*/
        DialogGameFlags.heat = true;
        ///METHOD_BODY_END n02_r1_select
    }

    ///METHOD n04_r3_select
    public void n04_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n04_r3_select
        /*//cold*/
        DialogGameFlags.cold = true;
        ///METHOD_BODY_END n04_r3_select
    }

    ///METHOD n07_r2_select
    public void n07_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r2_select
        /*//white folks*/
        DialogGameFlags.whitefolks = true;
        ///METHOD_BODY_END n07_r2_select
    }

    ///METHOD n11_r1_select
    public void n11_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r1_select
        /*//job*/
        DialogGameFlags.job = true;
        ///METHOD_BODY_END n11_r1_select
    }

    ///METHOD n23_r0_select
    public void n23_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n23_r0_select
        /*//Sally alt*/
        DialogGameFlags.sallyalt = true;
        ///METHOD_BODY_END n23_r0_select
    }

    ///METHOD n24_r2_select
    public void n24_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n24_r2_select
        /*//granddaddy*/
        DialogGameFlags.granddaddy = true;
        ///METHOD_BODY_END n24_r2_select
    }

    ///METHOD n25_r0_select
    public void n25_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n25_r0_select
        DialogGameFlags.n25 = true;
        ///METHOD_BODY_END n25_r0_select
    }

    ///METHOD n26b_r1_select
    public void n26b_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n26b_r1_select
        /*//change*/
        DialogGameFlags.change = true;
        ///METHOD_BODY_END n26b_r1_select
    }

    ///METHOD n26d_r0_select
    public void n26d_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n26d_r0_select
        /*>>> see JET article excerpt*/
        //TODO
        ///METHOD_BODY_END n26d_r0_select
    }

    ///METHOD n26d_r1_select
    public void n26d_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n26d_r1_select
        /*//n26b*/
        DialogGameFlags.n26b = true;
        ///METHOD_BODY_END n26d_r1_select
    }

    ///METHOD n27_r0_select
    public void n27_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n27_r0_select
        /*//ask Sally*/
        DialogGameFlags.asksally = true;
        ///METHOD_BODY_END n27_r0_select
    }

    ///METHOD n31_r2_select
    public void n31_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n31_r2_select
        /*//change*/
        DialogGameFlags.change = true;
        ///METHOD_BODY_END n31_r2_select
    }
}
//CLASS_END Dialog_p0_rob_sal_001
