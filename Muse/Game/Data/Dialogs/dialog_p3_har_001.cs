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
//CLASS Dialog_p3_har_001
public class Dialog_p3_har_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _p3_ask_har_abo
        private bool _p3_ask_har_abo = false;

        //PROPERTY p3_ask_har_abo
        public bool p3_ask_har_abo {
                get {
                        ///PROPERTY_GETTER_START p3_ask_har_abo
                        return _p3_ask_har_abo;
                        ///PROPERTY_GETTER_END p3_ask_har_abo
                }
                set {
                        ///PROPERTY_SETTER_START p3_ask_har_abo
                        _p3_ask_har_abo = value;
                        ///PROPERTY_SETTER_END p3_ask_har_abo
                }
        }

        //PROPERTY _p3_ask_ken
        private bool _p3_ask_ken = false;

        //PROPERTY p3_ask_ken
        public bool p3_ask_ken {
                get {
                        ///PROPERTY_GETTER_START p3_ask_ken
                        return _p3_ask_ken;
                        ///PROPERTY_GETTER_END p3_ask_ken
                }
                set {
                        ///PROPERTY_SETTER_START p3_ask_ken
                        _p3_ask_ken = value;
                        ///PROPERTY_SETTER_END p3_ask_ken
                }
        }

        //PROPERTY _p3_har_08a_seen
        private bool _p3_har_08a_seen = false;

        //PROPERTY p3_har_08a_seen
        public bool p3_har_08a_seen {
                get {
                        ///PROPERTY_GETTER_START p3_har_08a_seen
                        return _p3_har_08a_seen;
                        ///PROPERTY_GETTER_END p3_har_08a_seen
                }
                set {
                        ///PROPERTY_SETTER_START p3_har_08a_seen
                        _p3_har_08a_seen = value;
                        ///PROPERTY_SETTER_END p3_har_08a_seen
                }
        }

        //PROPERTY _p3_intro_har
        private bool _p3_intro_har = false;

        //PROPERTY p3_intro_har
        public bool p3_intro_har {
                get {
                        ///PROPERTY_GETTER_START p3_intro_har
                        return _p3_intro_har;
                        ///PROPERTY_GETTER_END p3_intro_har
                }
                set {
                        ///PROPERTY_SETTER_START p3_intro_har
                        _p3_intro_har = value;
                        ///PROPERTY_SETTER_END p3_intro_har
                }
        }

        //PROPERTY _p3_know_harrison
        private bool _p3_know_harrison = false;

        //PROPERTY p3_know_harrison
        public bool p3_know_harrison {
                get {
                        ///PROPERTY_GETTER_START p3_know_harrison
                        return _p3_know_harrison;
                        ///PROPERTY_GETTER_END p3_know_harrison
                }
                set {
                        ///PROPERTY_SETTER_START p3_know_harrison
                        _p3_know_harrison = value;
                        ///PROPERTY_SETTER_END p3_know_harrison
                }
        }

        //PROPERTY _p3_new_lands
        private bool _p3_new_lands = false;

        //PROPERTY p3_new_lands
        public bool p3_new_lands {
                get {
                        ///PROPERTY_GETTER_START p3_new_lands
                        return _p3_new_lands;
                        ///PROPERTY_GETTER_END p3_new_lands
                }
                set {
                        ///PROPERTY_SETTER_START p3_new_lands
                        _p3_new_lands = value;
                        ///PROPERTY_SETTER_END p3_new_lands
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
        ///DIALOG_ID p3_har_001
        var dialog = new Dialog();
        dialog.Id = "p3_har_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 Are you OK miss?\n
        prompt.Text = "Are you OK miss?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Who was that man?\n
        response.Text = "Who was that man?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n03
        response.NextNodeId = "n03";
        response.OnSelect(n01_r0_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 I think so. Who are you?\n
        response.Text = "I think so. Who are you?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
        response.NextNodeId = "n02";
        response.OnSelect(n01_r1_select);
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 I'm Benjamin Harrison. I'm running as a ###smartword|Free Soil|FREESOIL### candidate in the upcoming elections.\n
        prompt.Text = "I'm Benjamin Harrison. I'm running as a ###smartword|Free Soil|FREESOIL### candidate in the upcoming elections.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 I'm Lucy Wright.\n
        response.Text = "I'm Lucy Wright.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n09
        response.NextNodeId = "n09";
        response.SetCondition(n02_r0_condition);
        response.OnSelect(n02_r0_select);
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Who was that man?\n
        response.Text = "Who was that man?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n03
        response.NextNodeId = "n03";
        response.SetCondition(n02_r1_condition);
        response.OnSelect(n02_r1_select);
        
        ///RESPONSE n02 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 2 What do you mean by Free Soil?\n
        response.Text = "What do you mean by Free Soil?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 2 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 TC Bercham? He's a ###smartword|ruthless|RUTHLESS### one. Slave catcher by trade. You're a lucky girl.\n
        prompt.Text = "TC Bercham? He's a ###smartword|ruthless|RUTHLESS### one. Slave catcher by trade. You're a lucky girl.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 And you're not a slave catcher?\n
        response.Text = "And you're not a slave catcher?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n03_r0_condition);
        response.OnSelect(n03_r0_select);
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 Lucky? Why? I'm free here in Ohio.\n
        response.Text = "Lucky? Why? I'm free here in Ohio.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 That may be so. But that hasn't always stopped Bercham from dragging Negroes to jail.\n
        prompt.Text = "That may be so. But that hasn't always stopped Bercham from dragging Negroes to jail.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 And you're not a slave catcher?\n
        response.Text = "And you're not a slave catcher?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n04_r0_condition);
        response.OnSelect(n04_r0_select);
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 He could take me to jail?\n
        response.Text = "He could take me to jail?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 He certainly could. Now the sheriff here, he's sympathetic to your kind, so he'd make sure Bercham had proof you were a runaway.\n
        prompt.Text = "He certainly could. Now the sheriff here, he's sympathetic to your kind, so he'd make sure Bercham had proof you were a runaway.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 And are you sympathetic?\n
        response.Text = "And are you sympathetic?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n13
        response.NextNodeId = "n13";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 How would he prove something like that?\n
        response.Text = "How would he prove something like that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 I believe it's vital that the new lands to the West get admitted to the Union as free states. Slavery must not be expanded.\n
        prompt.Text = "I believe it's vital that the new lands to the West get admitted to the Union as free states. Slavery must not be expanded.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 What about Kentucky? What about the slaves there?\n
        response.Text = "What about Kentucky? What about the slaves there?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n16
        response.NextNodeId = "n16";
        response.OnSelect(n06_r0_select);
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 So you're an abolitionist?\n
        response.Text = "So you're an abolitionist?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n07
        response.NextNodeId = "n07";
        response.SetCondition(n06_r1_condition);
        response.OnSelect(n06_r1_select);
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 I wouldn't use that term exactly. Some abolitionists can be rather extreme in their views.\n
        prompt.Text = "I wouldn't use that term exactly. Some abolitionists can be rather extreme in their views.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 I see. I had better get back to my work. Good day sir.
        response.Text = "I see. I had better get back to my work. Good day sir.";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 END
        response.NextNodeId = "END";
        response.SetCondition(n07_r0_condition);
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 What about Kentucky? What about the slaves there?\n
        response.Text = "What about Kentucky? What about the slaves there?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n16
        response.NextNodeId = "n16";
        response.SetCondition(n07_r1_condition);
        response.OnSelect(n07_r1_select);
        
        ///RESPONSE n07 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 2 How are they extreme?\n
        response.Text = "How are they extreme?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 2 n08
        response.NextNodeId = "n08";
        response.SetCondition(n07_r2_condition);
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 They want slavery to end now. It will end someday, but first we must stop its growth. The new lands to the west must not become slave states.\n
        prompt.Text = "They want slavery to end now. It will end someday, but first we must stop its growth. The new lands to the west must not become slave states.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n08 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 1 They want slavery to end now. But slavery can't just be ended lickety split. It will end someday, but first we must stop its growth. \n
        prompt.Text = "They want slavery to end now. But slavery can't just be ended lickety split. It will end someday, but first we must stop its growth. \n";
        ///PROMPT_IGNORE_VO n08 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n08_p1_condition);
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 I see. Who was that man I ran into?\n
        response.Text = "I see. Who was that man I ran into?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n03
        response.NextNodeId = "n03";
        response.SetCondition(n08_r0_condition);
        response.OnSelect(n08_r0_select);
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 I see. I had better get back to my work. Good day sir.\n
        response.Text = "I see. I had better get back to my work. Good day sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 END
        response.NextNodeId = "END";
        response.OnSelect(n08_r1_select);
        
        ///RESPONSE n08 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 2 What about Kentucky? What about the slaves there?\n
        response.Text = "What about Kentucky? What about the slaves there?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 2 n16
        response.NextNodeId = "n16";
        response.SetCondition(n08_r2_condition);
        response.OnSelect(n08_r2_select);
        
        ///RESPONSE n08 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 3 What does someday mean? My mother and brother are still slaves. They might be sold further south in a few weeks.\n
        response.Text = "What does someday mean? My mother and brother are still slaves. They might be sold further south in a few weeks.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 3 n19
        response.NextNodeId = "n19";
        
        ///NODE_END n08
        ///NODE_START n08a
        node = dialog.CreateNode("n08a");
        ///NODE_NPC n08a HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n08a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08a Full
        ///NODE_VISUAL_USESCRIPT n08a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08a~|||~
        ///PROMPT n08a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08a 0 Slavery can't just be ended lickety split. It will end someday, but first we must stop its growth. The new lands to the west must not become slave states.\n
        prompt.Text = "Slavery can't just be ended lickety split. It will end someday, but first we must stop its growth. The new lands to the west must not become slave states.\n";
        ///PROMPT_IGNORE_VO n08a 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n08a_p0_show);
        
        ///PROMPT n08a 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08a 1 Right now the law is the law. Slavery can't just be ended lickety split. It will end someday, but first we must stop its growth. \n
        prompt.Text = "Right now the law is the law. Slavery can't just be ended lickety split. It will end someday, but first we must stop its growth. \n";
        ///PROMPT_IGNORE_VO n08a 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n08a_p1_condition);
        prompt.OnShow(n08a_p1_show);
        
        ///RESPONSE n08a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08a 0 I see. Who was that man I ran into?\n
        response.Text = "I see. Who was that man I ran into?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08a 0 n03
        response.NextNodeId = "n03";
        response.SetCondition(n08a_r0_condition);
        response.OnSelect(n08a_r0_select);
        
        ///RESPONSE n08a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08a 1 I see. I had better get back to my work. Good day sir.\n
        response.Text = "I see. I had better get back to my work. Good day sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08a 1 END
        response.NextNodeId = "END";
        response.OnSelect(n08a_r1_select);
        
        ///RESPONSE n08a 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n08a 2 What about Kentucky? What about the slaves there?\n
        response.Text = "What about Kentucky? What about the slaves there?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08a 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08a 2 n16
        response.NextNodeId = "n16";
        response.SetCondition(n08a_r2_condition);
        response.OnSelect(n08a_r2_select);
        
        ///RESPONSE n08a 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n08a 3 What does someday mean? My mother and brother are still slaves. They might be sold south in a few weeks.\n
        response.Text = "What does someday mean? My mother and brother are still slaves. They might be sold south in a few weeks.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08a 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08a 3 n19
        response.NextNodeId = "n19";
        
        ///NODE_END n08a
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 Wright? I just heard that name... yes, are you related to Abigail and Morgan Wright? \n
        prompt.Text = "Wright? I just heard that name... yes, are you related to Abigail and Morgan Wright? \n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 Yes, I'm their niece.\n
        response.Text = "Yes, I'm their niece.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 What a coincidence. Reverend Rankin introduced me to your aunt yesterday. I'll be speaking at their abolitionist meeting tonight.\n
        prompt.Text = "What a coincidence. Reverend Rankin introduced me to your aunt yesterday. I'll be speaking at their abolitionist meeting tonight.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I will be there to hear you, Mr. Harrison.\n
        response.Text = "I will be there to hear you, Mr. Harrison.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n15
        response.NextNodeId = "n15";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 Are you an abolitionist?\n
        response.Text = "Are you an abolitionist?\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n07
        response.NextNodeId = "n07";
        response.SetCondition(n10_r1_condition);
        response.OnSelect(n10_r1_select);
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 He'd get a sworn ###smartword|affidavit|AFFIDAVIT### from a plantation owner that states you're really an escaped slave.\n
        prompt.Text = "He'd get a sworn ###smartword|affidavit|AFFIDAVIT### from a plantation owner that states you're really an escaped slave.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 I see. I had better get back to my work. Good day sir.\n
        response.Text = "I see. I had better get back to my work. Good day sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 END
        response.NextNodeId = "END";
        response.OnSelect(n11_r0_select);
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 Even if I'm not?\n
        response.Text = "Even if I'm not?\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n12
        response.NextNodeId = "n12";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 The law is the law. You'd need your ###smartword|free papers|FREE_PAPERS### and some reliable witnesses who can swear to your story.\n
        prompt.Text = "The law is the law. You'd need your ###smartword|free papers|FREE_PAPERS### and some reliable witnesses who can swear to your story.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 As a Free Soil candidate, what do you think about these laws?\n
        response.Text = "As a Free Soil candidate, what do you think about these laws?\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n08a
        response.NextNodeId = "n08a";
        response.SetCondition(n12_r0_condition);
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 I see. I had better get back to my work. Good day sir.\n
        response.Text = "I see. I had better get back to my work. Good day sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 END
        response.NextNodeId = "END";
        response.OnSelect(n12_r1_select);
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Certainly, certainly. This country suffers from slavery. Negroes, whites, all of us.\n
        prompt.Text = "Certainly, certainly. This country suffers from slavery. Negroes, whites, all of us.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 Are you an abolitionist?\n
        response.Text = "Are you an abolitionist?\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n07
        response.NextNodeId = "n07";
        response.SetCondition(n13_r0_condition);
        response.OnSelect(n13_r0_select);
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 How do white people suffer?\n
        response.Text = "How do white people suffer?\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 I'm sorry but I must be going. Good day.
        prompt.Text = "I'm sorry but I must be going. Good day.";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n14 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 1 You ask a lot of questions! May I ask your name before we continue?\n
        prompt.Text = "You ask a lot of questions! May I ask your name before we continue?\n";
        ///PROMPT_IGNORE_VO n14 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n14_p1_condition);
        prompt.OnShow(n14_p1_show);
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 Good day.
        response.Text = "Good day.";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 END
        response.NextNodeId = "END";
        response.SetCondition(n14_r0_condition);
        response.OnSelect(n14_r0_select);
        
        ///RESPONSE n14 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 1 No, I had better get back to my work. Good day sir.\n
        response.Text = "No, I had better get back to my work. Good day sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 1 END
        response.NextNodeId = "END";
        response.SetCondition(n14_r1_condition);
        response.OnSelect(n14_r1_select);
        
        ///RESPONSE n14 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 2 Lucy Wright.\n
        response.Text = "Lucy Wright.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 2 n09
        response.NextNodeId = "n09";
        response.SetCondition(n14_r2_condition);
        response.OnSelect(n14_r2_select);
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 Then I will see you tonight Miss Wright. Good day.\n
        prompt.Text = "Then I will see you tonight Miss Wright. Good day.\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 Good day.\n
        response.Text = "Good day.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 END
        response.NextNodeId = "END";
        response.OnSelect(n15_r0_select);
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 If we surround the existing slave states with free states, slavery will slowly wither and die. \n
        prompt.Text = "If we surround the existing slave states with free states, slavery will slowly wither and die. \n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 Not everyone has time to wait.\n
        response.Text = "Not everyone has time to wait.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n16 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 1 I see. I had better get back to my work. Good day sir.\n
        response.Text = "I see. I had better get back to my work. Good day sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 1 END
        response.NextNodeId = "END";
        response.OnSelect(n16_r1_select);
        
        ///RESPONSE n16 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 2 So are you an abolitionist?\n
        response.Text = "So are you an abolitionist?\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 2 n07
        response.NextNodeId = "n07";
        response.SetCondition(n16_r2_condition);
        response.OnSelect(n16_r2_select);
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 Keep your voice down. Slave catchers hear you say that, you'll be jailed.\n
        prompt.Text = "Keep your voice down. Slave catchers hear you say that, you'll be jailed.\n";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT n17 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 1 Keep your voice down. If a slave catcher like Bercham hears you say that, you'll be jailed.\n
        prompt.Text = "Keep your voice down. If a slave catcher like Bercham hears you say that, you'll be jailed.\n";
        ///PROMPT_IGNORE_VO n17 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n17_p1_condition);
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 And you're not a slave catcher?\n
        response.Text = "And you're not a slave catcher?\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n17_r0_condition);
        response.OnSelect(n17_r0_select);
        
        ///RESPONSE n17 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 1 I'm sorry. I had better get back to my work. Good day sir.\n
        response.Text = "I'm sorry. I had better get back to my work. Good day sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 1 END
        response.NextNodeId = "END";
        response.OnSelect(n17_r1_select);
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 I'm sorry but I must be going. Good day.\n
        prompt.Text = "I'm sorry but I must be going. Good day.\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 Good day.\n
        response.Text = "Good day.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 END
        response.NextNodeId = "END";
        response.OnSelect(n18_r0_select);
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 HAR
        node.Npc = "HAR";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 I am sorry to hear that. But slavery has endured for centuries and won't be ended in a matter of weeks. You must be realistic.\n
        prompt.Text = "I am sorry to hear that. But slavery has endured for centuries and won't be ended in a matter of weeks. You must be realistic.\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 I'll try. I had better get back to my work. Good day sir.\n
        response.Text = "I'll try. I had better get back to my work. Good day sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 END
        response.NextNodeId = "END";
        response.OnSelect(n19_r0_select);
        
        ///RESPONSE n19 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 1 I had better get back to my work. Good day sir.\n
        response.Text = "I had better get back to my work. Good day sir.\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 1 END
        response.NextNodeId = "END";
        response.OnSelect(n19_r1_select);
        
        ///RESPONSE n19 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 2 I couldn't endure slavery one more day! I ran away! And I want my family to be free too.\n
        response.Text = "I couldn't endure slavery one more day! I ran away! And I want my family to be free too.\n";
        ///RESPONSE_NEXT_NODE_TYPE n19 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 2 n17
        response.NextNodeId = "n17";
        
        ///NODE_END n19
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n08_p1_condition
    public bool n08_p1_condition (  ) {
        ///METHOD_BODY_START n08_p1_condition
        /*//if (?p3_new_lands = true)*/
        return DialogGameFlags.p3_new_lands;
        ///METHOD_BODY_END n08_p1_condition
    }

    ///METHOD n08a_p1_condition
    public bool n08a_p1_condition (  ) {
        ///METHOD_BODY_START n08a_p1_condition
        /*//if (?p3_new_lands = true)*/
        return DialogGameFlags.p3_new_lands;
        ///METHOD_BODY_END n08a_p1_condition
    }

    ///METHOD n14_p1_condition
    public bool n14_p1_condition (  ) {
        ///METHOD_BODY_START n14_p1_condition
        /*//if (?p3_intro_har = false)*/
        return !DialogGameFlags.p3_intro_har;
        ///METHOD_BODY_END n14_p1_condition
    }

    ///METHOD n17_p1_condition
    public bool n17_p1_condition (  ) {
        ///METHOD_BODY_START n17_p1_condition
        /*//if (?p3_ask_tc = true)*/
        return GameFlags.P3AskTc;
        ///METHOD_BODY_END n17_p1_condition
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//showNpc(true,1)*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n08a_p0_show
    public void n08a_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n08a_p0_show
        /*//?p3_har_08a_seen = true*/
        DialogGameFlags.p3_har_08a_seen = true;
        ///METHOD_BODY_END n08a_p0_show
    }

    ///METHOD n08a_p1_show
    public void n08a_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n08a_p1_show
        /*//?p3_har_08a_seen = true*/
        DialogGameFlags.p3_har_08a_seen = true;
        ///METHOD_BODY_END n08a_p1_show
    }

    ///METHOD n14_p1_show
    public void n14_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n14_p1_show
        /*//?p3_har_curious = true*/
        // Variable is never used?
        GameFlags.P3HarCurious = true;
        ///METHOD_BODY_END n14_p1_show
    }

    ///METHOD n02_r0_condition
    public bool n02_r0_condition (  ) {
        ///METHOD_BODY_START n02_r0_condition
        /*//if (?p3_intro_har = false)*/
        return !DialogGameFlags.p3_intro_har;
        ///METHOD_BODY_END n02_r0_condition
    }

    ///METHOD n02_r1_condition
    public bool n02_r1_condition (  ) {
        ///METHOD_BODY_START n02_r1_condition
        /*//if (?p3_ask_tc = false)*/
        return !GameFlags.P3AskTc;
        ///METHOD_BODY_END n02_r1_condition
    }

    ///METHOD n03_r0_condition
    public bool n03_r0_condition (  ) {
        ///METHOD_BODY_START n03_r0_condition
        /*//if (?p3_know_harrison = false)*/
        return !DialogGameFlags.p3_know_harrison;
        ///METHOD_BODY_END n03_r0_condition
    }

    ///METHOD n04_r0_condition
    public bool n04_r0_condition (  ) {
        ///METHOD_BODY_START n04_r0_condition
        /*//if (?p3_know_harrison = false)*/
        return !DialogGameFlags.p3_know_harrison;
        ///METHOD_BODY_END n04_r0_condition
    }

    ///METHOD n06_r1_condition
    public bool n06_r1_condition (  ) {
        ///METHOD_BODY_START n06_r1_condition
        /*//if (?p3_ask_har_abo = false)*/
        return !DialogGameFlags.p3_ask_har_abo;
        ///METHOD_BODY_END n06_r1_condition
    }

    ///METHOD n07_r0_condition
    public bool n07_r0_condition (  ) {
        ///METHOD_BODY_START n07_r0_condition
        /*//if (?p3_har_08a_seen)*/
        return DialogGameFlags.p3_har_08a_seen;
        ///METHOD_BODY_END n07_r0_condition
    }

    ///METHOD n07_r1_condition
    public bool n07_r1_condition (  ) {
        ///METHOD_BODY_START n07_r1_condition
        /*//if ((?p3_new_lands = true) AND (?p3_ask_ken = false))*/
        return DialogGameFlags.p3_new_lands && DialogGameFlags.p3_ask_ken;
        ///METHOD_BODY_END n07_r1_condition
    }

    ///METHOD n07_r2_condition
    public bool n07_r2_condition (  ) {
        ///METHOD_BODY_START n07_r2_condition
        /*//if (?p3_har_08a_seen = false)*/
        return !DialogGameFlags.p3_har_08a_seen;
        ///METHOD_BODY_END n07_r2_condition
    }

    ///METHOD n08_r0_condition
    public bool n08_r0_condition (  ) {
        ///METHOD_BODY_START n08_r0_condition
        /*//if (?p3_ask_tc = false)*/
        return !GameFlags.P3AskTc;
        ///METHOD_BODY_END n08_r0_condition
    }

    ///METHOD n08_r2_condition
    public bool n08_r2_condition (  ) {
        ///METHOD_BODY_START n08_r2_condition
        /*//if ((?p3_new_lands = false) AND (?p3_ask_ken = false))*/
        return !DialogGameFlags.p3_new_lands && !DialogGameFlags.p3_ask_ken;
        ///METHOD_BODY_END n08_r2_condition
    }

    ///METHOD n08a_r0_condition
    public bool n08a_r0_condition (  ) {
        ///METHOD_BODY_START n08a_r0_condition
        /*//if (?p3_ask_tc=false)*/
        return !GameFlags.P3AskTc;
        ///METHOD_BODY_END n08a_r0_condition
    }

    ///METHOD n08a_r2_condition
    public bool n08a_r2_condition (  ) {
        ///METHOD_BODY_START n08a_r2_condition
        /*//if ((?p3_new_lands = false) AND (?p3_ask_ken = false))*/
        return !DialogGameFlags.p3_new_lands && !DialogGameFlags.p3_ask_ken;
        ///METHOD_BODY_END n08a_r2_condition
    }

    ///METHOD n10_r1_condition
    public bool n10_r1_condition (  ) {
        ///METHOD_BODY_START n10_r1_condition
        /*//if (?p3_ask_har_abo = false)*/
        return !DialogGameFlags.p3_ask_har_abo;
        ///METHOD_BODY_END n10_r1_condition
    }

    ///METHOD n12_r0_condition
    public bool n12_r0_condition (  ) {
        ///METHOD_BODY_START n12_r0_condition
        /*//if (?p3_know_harrison = true)*/
        return DialogGameFlags.p3_know_harrison;
        ///METHOD_BODY_END n12_r0_condition
    }

    ///METHOD n13_r0_condition
    public bool n13_r0_condition (  ) {
        ///METHOD_BODY_START n13_r0_condition
        /*//if (?p3_ask_har_abo = false)*/
        return !DialogGameFlags.p3_ask_har_abo;
        ///METHOD_BODY_END n13_r0_condition
    }

    ///METHOD n14_r0_condition
    public bool n14_r0_condition (  ) {
        ///METHOD_BODY_START n14_r0_condition
        /*//if (?p3_intro_har = true)*/
        return DialogGameFlags.p3_intro_har;
        ///METHOD_BODY_END n14_r0_condition
    }

    ///METHOD n14_r1_condition
    public bool n14_r1_condition (  ) {
        ///METHOD_BODY_START n14_r1_condition
        /*//if (?p3_intro_har = false)*/
        return !DialogGameFlags.p3_intro_har;
        ///METHOD_BODY_END n14_r1_condition
    }

    ///METHOD n14_r2_condition
    public bool n14_r2_condition (  ) {
        ///METHOD_BODY_START n14_r2_condition
        /*//if (?p3_intro_har = false)*/
        return !DialogGameFlags.p3_intro_har;
        ///METHOD_BODY_END n14_r2_condition
    }

    ///METHOD n16_r2_condition
    public bool n16_r2_condition (  ) {
        ///METHOD_BODY_START n16_r2_condition
        /*//if (?p3_ask_har_abo = false)*/
        return !DialogGameFlags.p3_ask_har_abo;
        ///METHOD_BODY_END n16_r2_condition
    }

    ///METHOD n17_r0_condition
    public bool n17_r0_condition (  ) {
        ///METHOD_BODY_START n17_r0_condition
        /*//if (?p3_know_harrison = false)*/
        return !DialogGameFlags.p3_know_harrison;
        ///METHOD_BODY_END n17_r0_condition
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//set ?p3_ask_tc = true*/
        GameFlags.P3AskTc = true;
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//set ?p3_know_harrison = true*/
        DialogGameFlags.p3_know_harrison = true;
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n02_r0_select
    public void n02_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r0_select
        /*//set ?p3_intro_har = true*/
        DialogGameFlags.p3_intro_har = true;
        ///METHOD_BODY_END n02_r0_select
    }

    ///METHOD n02_r1_select
    public void n02_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r1_select
        /*//set ?p3_ask_tc = true*/
        GameFlags.P3AskTc = true;
        ///METHOD_BODY_END n02_r1_select
    }

    ///METHOD n03_r0_select
    public void n03_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r0_select
        /*//set ?p3_know_harrison = true*/
        DialogGameFlags.p3_know_harrison = true;
        ///METHOD_BODY_END n03_r0_select
    }

    ///METHOD n04_r0_select
    public void n04_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n04_r0_select
        /*//set ?p3_know_harrison = true*/
        DialogGameFlags.p3_know_harrison = true;
        ///METHOD_BODY_END n04_r0_select
    }

    ///METHOD n06_r0_select
    public void n06_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r0_select
        /*//set ?p3_ask_ken = true*/
        DialogGameFlags.p3_ask_ken = true;
        ///METHOD_BODY_END n06_r0_select
    }

    ///METHOD n06_r1_select
    public void n06_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n06_r1_select
        /*//set ?p3_ask_har_abo = true
        //set ?p3_new_lands = true*/
        DialogGameFlags.p3_ask_har_abo= true;
        DialogGameFlags.p3_new_lands = true;
        ///METHOD_BODY_END n06_r1_select
    }

    ///METHOD n07_r1_select
    public void n07_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r1_select
        /*//set ?p3_ask_ken = true*/
        DialogGameFlags.p3_ask_ken = true;
        ///METHOD_BODY_END n07_r1_select
    }

    ///METHOD n08_r0_select
    public void n08_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r0_select
        /*//set ?p3_ask_tc = true*/
        GameFlags.P3AskTc = true;
        ///METHOD_BODY_END n08_r0_select
    }

    ///METHOD n08_r1_select
    public void n08_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r1_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n08_r1_select
    }

    ///METHOD n08_r2_select
    public void n08_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r2_select
        /*//set ?p3_ask_ken = true*/
        DialogGameFlags.p3_ask_ken = true;
        ///METHOD_BODY_END n08_r2_select
    }

    ///METHOD n08a_r0_select
    public void n08a_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08a_r0_select
        /*//?p3_ask_tc=true*/
        GameFlags.P3AskTc = true;
        ///METHOD_BODY_END n08a_r0_select
    }

    ///METHOD n08a_r1_select
    public void n08a_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08a_r1_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n08a_r1_select
    }

    ///METHOD n08a_r2_select
    public void n08a_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08a_r2_select
        /*//?p3_ask_ken = true*/
        DialogGameFlags.p3_ask_ken = true;
        ///METHOD_BODY_END n08a_r2_select
    }

    ///METHOD n10_r1_select
    public void n10_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r1_select
        /*//set ?p3_ask_har_abo = true*/
        DialogGameFlags.p3_ask_har_abo = true;
        ///METHOD_BODY_END n10_r1_select
    }

    ///METHOD n11_r0_select
    public void n11_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r0_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n11_r0_select
    }

    ///METHOD n12_r1_select
    public void n12_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n12_r1_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n12_r1_select
    }

    ///METHOD n13_r0_select
    public void n13_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n13_r0_select
        /*//set ?p3_ask_har_abo = true*/
        DialogGameFlags.p3_ask_har_abo = true;
        ///METHOD_BODY_END n13_r0_select
    }

    ///METHOD n14_r0_select
    public void n14_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n14_r0_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n14_r0_select
    }

    ///METHOD n14_r1_select
    public void n14_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n14_r1_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n14_r1_select
    }

    ///METHOD n14_r2_select
    public void n14_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n14_r2_select
        /*//set ?p3_intro_har = true*/
        DialogGameFlags.p3_intro_har = true;
        ///METHOD_BODY_END n14_r2_select
    }

    ///METHOD n15_r0_select
    public void n15_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n15_r0_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n15_r0_select
    }

    ///METHOD n16_r1_select
    public void n16_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r1_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n16_r1_select
    }

    ///METHOD n16_r2_select
    public void n16_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r2_select
        /*//?p3_ask_har_abo = true*/
        DialogGameFlags.p3_ask_har_abo = true;
        ///METHOD_BODY_END n16_r2_select
    }

    ///METHOD n17_r0_select
    public void n17_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n17_r0_select
        /*//?p3_know_harrison = true*/
        DialogGameFlags.p3_know_harrison = true;
        ///METHOD_BODY_END n17_r0_select
    }

    ///METHOD n17_r1_select
    public void n17_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n17_r1_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n17_r1_select
    }

    ///METHOD n18_r0_select
    public void n18_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n18_r0_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n18_r0_select
    }

    ///METHOD n19_r0_select
    public void n19_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n19_r0_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n19_r0_select
    }

    ///METHOD n19_r1_select
    public void n19_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n19_r1_select
        /*//showPopup("P3_LEAVE_HOTEL")*/
        ///METHOD_BODY_END n19_r1_select
    }
}
//CLASS_END Dialog_p3_har_001
