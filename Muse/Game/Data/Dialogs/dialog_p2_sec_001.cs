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
//CLASS Dialog_p2_sec_001
public class Dialog_p2_sec_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _next_node
        private string _next_node = "false";

        //PROPERTY next_node
        public string next_node {
                get {
                        ///PROPERTY_GETTER_START next_node
                        return _next_node;
                        ///PROPERTY_GETTER_END next_node
                }
                set {
                        ///PROPERTY_SETTER_START next_node
                        _next_node = value;
                        ///PROPERTY_SETTER_END next_node
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
        ///DIALOG_ID p2_sec_001
        var dialog = new Dialog();
        dialog.Id = "p2_sec_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START NOFISH
        node = dialog.CreateNode("NOFISH");
        ///NODE_NPC NOFISH SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES NOFISH False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NOFISH Full
        ///NODE_VISUAL_USESCRIPT NOFISH false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NOFISH~|||~
        ///PROMPT NOFISH 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NOFISH 0 This is a remote, well-wooded spot on the bank of the Ohio River. The river is wide and the current swift.
        prompt.Text = "This is a remote, well-wooded spot on the bank of the Ohio River. The river is wide and the current swift.";
        ///PROMPT_IGNORE_VO NOFISH 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NOFISH 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NOFISH 0 Try to float across on a log.
        response.Text = "Try to float across on a log.";
        ///RESPONSE_NEXT_NODE_TYPE NOFISH 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NOFISH 0 FLOAT
        response.NextNodeId = "FLOAT";
        
        ///RESPONSE NOFISH 1
        response = node.AddResponse();
        ///RESPONSE_TEXT NOFISH 1 Go somewhere else.
        response.Text = "Go somewhere else.";
        ///RESPONSE_NEXT_NODE_TYPE NOFISH 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NOFISH 1 END
        response.NextNodeId = "END";
        
        ///NODE_END NOFISH
        ///NODE_START FISH
        node = dialog.CreateNode("FISH");
        ///NODE_NPC FISH SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES FISH False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FISH Full
        ///NODE_VISUAL_USESCRIPT FISH false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FISH~|||~
        ///PROMPT FISH 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FISH 0 You spot a Negro fisherman in his boat passing close by.
        prompt.Text = "You spot a Negro fisherman in his boat passing close by.";
        ///PROMPT_IGNORE_VO FISH 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FISH 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FISH 0 Wait until he is out of sight.
        response.Text = "Wait until he is out of sight.";
        ///RESPONSE_NEXT_NODE_TYPE FISH 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FISH 0 NOFISH
        response.NextNodeId = "NOFISH";
        
        ///RESPONSE FISH 1
        response = node.AddResponse();
        ///RESPONSE_TEXT FISH 1 Ask for his help.
        response.Text = "Ask for his help.";
        ///RESPONSE_NEXT_NODE_TYPE FISH 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FISH 1 HELP
        response.NextNodeId = "HELP";
        
        ///NODE_END FISH
        ///NODE_START FLOAT
        node = dialog.CreateNode("FLOAT");
        ///NODE_NPC FLOAT SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES FLOAT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FLOAT Full
        ///NODE_VISUAL_USESCRIPT FLOAT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FLOAT~|||~
        ///PROMPT FLOAT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FLOAT 0 [This seems like a very dangerous thing to do. Are you sure?]
        prompt.Text = "[This seems like a very dangerous thing to do. Are you sure?]";
        ///PROMPT_IGNORE_VO FLOAT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FLOAT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FLOAT 0 No
        response.Text = "No";
        ///RESPONSE_NEXT_NODE_TYPE FLOAT 0 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID FLOAT 0 
        response.NextNodeId = "";
        response.OnSelect(FLOAT_r0_select);
        response.OnSelectNextNodeId(FLOAT_r0_nextnodeid);
        
        ///RESPONSE FLOAT 1
        response = node.AddResponse();
        ///RESPONSE_TEXT FLOAT 1 Yes
        response.Text = "Yes";
        ///RESPONSE_NEXT_NODE_TYPE FLOAT 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FLOAT 1 FLOAT_ACROSS
        response.NextNodeId = "FLOAT_ACROSS";
        
        ///NODE_END FLOAT
        ///NODE_START H_CHOICE
        node = dialog.CreateNode("H_CHOICE");
        ///NODE_NPC H_CHOICE SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES H_CHOICE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE H_CHOICE Full
        ///NODE_VISUAL_USESCRIPT H_CHOICE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~H_CHOICE~|||~
        ///PROMPT H_CHOICE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT H_CHOICE 0 \"Well I'm gonna do it,\" says Henry. \"Last chance. You coming with me?\"
        prompt.Text = "\"Well I'm gonna do it,\" says Henry. \"Last chance. You coming with me?\"";
        ///PROMPT_IGNORE_VO H_CHOICE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE H_CHOICE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT H_CHOICE 0 Say goodbye.
        response.Text = "Say goodbye.";
        ///RESPONSE_NEXT_NODE_TYPE H_CHOICE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID H_CHOICE 0 GOODBYE
        response.NextNodeId = "GOODBYE";
        
        ///RESPONSE H_CHOICE 1
        response = node.AddResponse();
        ///RESPONSE_TEXT H_CHOICE 1 Float across with Henry.
        response.Text = "Float across with Henry.";
        ///RESPONSE_NEXT_NODE_TYPE H_CHOICE 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID H_CHOICE 1 FLOAT_ACROSS
        response.NextNodeId = "FLOAT_ACROSS";
        
        ///NODE_END H_CHOICE
        ///NODE_START GOODBYE
        node = dialog.CreateNode("GOODBYE");
        ///NODE_NPC GOODBYE SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES GOODBYE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE GOODBYE Full
        ///NODE_VISUAL_USESCRIPT GOODBYE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~GOODBYE~|||~
        ///PROMPT GOODBYE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT GOODBYE 0 Sadly, you say goodbye to Henry. He wades into the river with a log and starts paddling. About halfway across the current is too strong for him. He clings to the log as the water quickly sweeps him downriver and out of sight.
        prompt.Text = "Sadly, you say goodbye to Henry. He wades into the river with a log and starts paddling. About halfway across the current is too strong for him. He clings to the log as the water quickly sweeps him downriver and out of sight.";
        ///PROMPT_IGNORE_VO GOODBYE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE GOODBYE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT GOODBYE 0 Say a prayer for Henry and keep going.
        response.Text = "Say a prayer for Henry and keep going.";
        ///RESPONSE_NEXT_NODE_TYPE GOODBYE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID GOODBYE 0 END
        response.NextNodeId = "END";
        response.OnSelect(GOODBYE_r0_select);
        
        ///NODE_END GOODBYE
        ///NODE_START FLOAT_ACROSS
        node = dialog.CreateNode("FLOAT_ACROSS");
        ///NODE_NPC FLOAT_ACROSS SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES FLOAT_ACROSS False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FLOAT_ACROSS Full
        ///NODE_VISUAL_USESCRIPT FLOAT_ACROSS false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FLOAT_ACROSS~|||~
        ///PROMPT FLOAT_ACROSS 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FLOAT_ACROSS 0 You and Henry drag a log into the water and start paddling. It is very difficult and tiring to fight the river current. About halfway across you give up. It's all you can do to hold on. The river sweeps you away.
        prompt.Text = "You and Henry drag a log into the water and start paddling. It is very difficult and tiring to fight the river current. About halfway across you give up. It's all you can do to hold on. The river sweeps you away.";
        ///PROMPT_IGNORE_VO FLOAT_ACROSS 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT FLOAT_ACROSS 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FLOAT_ACROSS 1 You drag a log into the water and start paddling. It is very difficult and tiring to fight the river current. About halfway across you give up paddling. It's all you can do to hold on. The river sweeps you away.
        prompt.Text = "You drag a log into the water and start paddling. It is very difficult and tiring to fight the river current. About halfway across you give up paddling. It's all you can do to hold on. The river sweeps you away.";
        ///PROMPT_IGNORE_VO FLOAT_ACROSS 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(FLOAT_ACROSS_p1_condition);
        
        ///RESPONSE FLOAT_ACROSS 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FLOAT_ACROSS 0 Pray
        response.Text = "Pray";
        ///RESPONSE_NEXT_NODE_TYPE FLOAT_ACROSS 0 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID FLOAT_ACROSS 0 
        response.NextNodeId = "";
        response.OnSelect(FLOAT_ACROSS_r0_select);
        response.OnSelectNextNodeId(FLOAT_ACROSS_r0_nextnodeid);
        
        ///NODE_END FLOAT_ACROSS
        ///NODE_START S_SIDE
        node = dialog.CreateNode("S_SIDE");
        ///NODE_NPC S_SIDE SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES S_SIDE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE S_SIDE Full
        ///NODE_VISUAL_USESCRIPT S_SIDE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~S_SIDE~|||~
        ///PROMPT S_SIDE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT S_SIDE 0 Amazingly you don't drown. You are plucked out of the water by the crew of a flatboat. They tie you up and turn you over to the sheriff in Dover.
        prompt.Text = "Amazingly you don't drown. You are plucked out of the water by the crew of a flatboat. They tie you up and turn you over to the sheriff in Dover.";
        ///PROMPT_IGNORE_VO S_SIDE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE S_SIDE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT S_SIDE 0 More...
        response.Text = "More...";
        ///RESPONSE_NEXT_NODE_TYPE S_SIDE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID S_SIDE 0 END
        response.NextNodeId = "END";
        response.OnSelect(S_SIDE_r0_select);
        
        ///NODE_END S_SIDE
        ///NODE_START N_SIDE
        node = dialog.CreateNode("N_SIDE");
        ///NODE_NPC N_SIDE SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES N_SIDE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE N_SIDE Full
        ///NODE_VISUAL_USESCRIPT N_SIDE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~N_SIDE~|||~
        ///PROMPT N_SIDE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT N_SIDE 0 You hit a stretch of rough water and lose your grip. Gasping, you frantically try to dog-paddle. At some point you pass out because you wake up bruised on the riverbank. You made it across the Ohio River!
        prompt.Text = "You hit a stretch of rough water and lose your grip. Gasping, you frantically try to dog-paddle. At some point you pass out because you wake up bruised on the riverbank. You made it across the Ohio River!";
        ///PROMPT_IGNORE_VO N_SIDE 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT N_SIDE 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT N_SIDE 1 You hit rough water and lose your grip. Gasping, you frantically try to dog-paddle. At some point you pass out. You wake up bruised on the riverbank. You made it across the Ohio River! But, sadly, Henry is nowhere to be seen.
        prompt.Text = "You hit rough water and lose your grip. Gasping, you frantically try to dog-paddle. At some point you pass out. You wake up bruised on the riverbank. You made it across the Ohio River! But, sadly, Henry is nowhere to be seen.";
        ///PROMPT_IGNORE_VO N_SIDE 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(N_SIDE_p1_condition);
        prompt.OnShow(N_SIDE_p1_show);
        
        ///RESPONSE N_SIDE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT N_SIDE 0 More...
        response.Text = "More...";
        ///RESPONSE_NEXT_NODE_TYPE N_SIDE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID N_SIDE 0 DIRECTIONS
        response.NextNodeId = "DIRECTIONS";
        response.OnSelect(N_SIDE_r0_select);
        
        ///NODE_END N_SIDE
        ///NODE_START DIRECTIONS
        node = dialog.CreateNode("DIRECTIONS");
        ///NODE_NPC DIRECTIONS SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES DIRECTIONS False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE DIRECTIONS Full
        ///NODE_VISUAL_USESCRIPT DIRECTIONS false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~DIRECTIONS~|||~
        ///PROMPT DIRECTIONS 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT DIRECTIONS 0 You stumble along and finally encounter a free Negro woman on her way to Ripley. She points to a house on a hill and tells you to go there.
        prompt.Text = "You stumble along and finally encounter a free Negro woman on her way to Ripley. She points to a house on a hill and tells you to go there.";
        ///PROMPT_IGNORE_VO DIRECTIONS 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE DIRECTIONS 0
        response = node.AddResponse();
        ///RESPONSE_TEXT DIRECTIONS 0 More...
        response.Text = "More...";
        ///RESPONSE_NEXT_NODE_TYPE DIRECTIONS 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID DIRECTIONS 0 END
        response.NextNodeId = "END";
        response.OnSelect(DIRECTIONS_r0_select);
        
        ///NODE_END DIRECTIONS
        ///NODE_START HELP
        node = dialog.CreateNode("HELP");
        ///NODE_NPC HELP SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES HELP False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HELP Full
        ///NODE_VISUAL_USESCRIPT HELP false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HELP~|||~
        ///PROMPT HELP 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HELP 0 The man hesitates. He looks at the river. There is not much traffic at the moment. \"I could get in big trouble,\" he says, \"but, okay, hurry up.\"
        prompt.Text = "The man hesitates. He looks at the river. There is not much traffic at the moment. \"I could get in big trouble,\" he says, \"but, okay, hurry up.\"";
        ///PROMPT_IGNORE_VO HELP 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(HELP_p0_show);
        
        ///RESPONSE HELP 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HELP 0 Hide in the boat.
        response.Text = "Hide in the boat.";
        ///RESPONSE_NEXT_NODE_TYPE HELP 0 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID HELP 0 
        response.NextNodeId = "";
        response.OnSelect(HELP_r0_select);
        response.OnSelectNextNodeId(HELP_r0_nextnodeid);
        
        ///NODE_END HELP
        ///NODE_START ACROSS
        node = dialog.CreateNode("ACROSS");
        ///NODE_NPC ACROSS SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES ACROSS False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE ACROSS Full
        ///NODE_VISUAL_USESCRIPT ACROSS false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~ACROSS~|||~
        ///PROMPT ACROSS 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT ACROSS 0 The fisherman rows you across the river and lets you off in a quiet spot. He tells you to find Reverend Rankin's house on the hill in Ripley. He also says to be careful, there are slave catchers on this side of the river too.
        prompt.Text = "The fisherman rows you across the river and lets you off in a quiet spot. He tells you to find Reverend Rankin's house on the hill in Ripley. He also says to be careful, there are slave catchers on this side of the river too.";
        ///PROMPT_IGNORE_VO ACROSS 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE ACROSS 0
        response = node.AddResponse();
        ///RESPONSE_TEXT ACROSS 0 Thank him and leave.
        response.Text = "Thank him and leave.";
        ///RESPONSE_NEXT_NODE_TYPE ACROSS 0 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID ACROSS 0 
        response.NextNodeId = "";
        response.OnSelect(ACROSS_r0_select);
        response.OnSelectNextNodeId(ACROSS_r0_nextnodeid);
        
        ///NODE_END ACROSS
        ///NODE_START CAUGHT
        node = dialog.CreateNode("CAUGHT");
        ///NODE_NPC CAUGHT SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES CAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CAUGHT Full
        ///NODE_VISUAL_USESCRIPT CAUGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CAUGHT~|||~
        ///PROMPT CAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CAUGHT 0 The fisherman rows you across. You are just thanking him when a group of white men shout and start running toward the boat. There are slave catchers on this side, too!
        prompt.Text = "The fisherman rows you across. You are just thanking him when a group of white men shout and start running toward the boat. There are slave catchers on this side, too!";
        ///PROMPT_IGNORE_VO CAUGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE CAUGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CAUGHT 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE CAUGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CAUGHT 0 CAUGHT2
        response.NextNodeId = "CAUGHT2";
        response.OnSelect(CAUGHT_r0_select);
        
        ///NODE_END CAUGHT
        ///NODE_START CAUGHT2
        node = dialog.CreateNode("CAUGHT2");
        ///NODE_NPC CAUGHT2 SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES CAUGHT2 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CAUGHT2 Full
        ///NODE_VISUAL_USESCRIPT CAUGHT2 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CAUGHT2~|||~
        ///PROMPT CAUGHT2 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CAUGHT2 0 Henry starts fighting with the slave catchers, while the fisherman rows away. \"Run!\" Henry shouts to you.
        prompt.Text = "Henry starts fighting with the slave catchers, while the fisherman rows away. \"Run!\" Henry shouts to you.";
        ///PROMPT_IGNORE_VO CAUGHT2 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(CAUGHT2_p0_show);
        
        ///RESPONSE CAUGHT2 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CAUGHT2 0 [Run!]
        response.Text = "[Run!]";
        ///RESPONSE_NEXT_NODE_TYPE CAUGHT2 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CAUGHT2 0 RUN
        response.NextNodeId = "RUN";
        response.OnSelect(CAUGHT2_r0_select);
        
        ///NODE_END CAUGHT2
        ///NODE_START RUN
        node = dialog.CreateNode("RUN");
        ///NODE_NPC RUN SEC
        node.Npc = "SEC";
        ///NODE_RANDOM_RESPONSES RUN False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE RUN Full
        ///NODE_VISUAL_USESCRIPT RUN false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~RUN~|||~
        ///PROMPT RUN 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT RUN 0 You start running. The fisherman told you to find Reverend Rankin's house on the hill in Ripley.
        prompt.Text = "You start running. The fisherman told you to find Reverend Rankin's house on the hill in Ripley.";
        ///PROMPT_IGNORE_VO RUN 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE RUN 0
        response = node.AddResponse();
        ///RESPONSE_TEXT RUN 0 [Keep going.]
        response.Text = "[Keep going.]";
        ///RESPONSE_NEXT_NODE_TYPE RUN 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID RUN 0 END
        response.NextNodeId = "END";
        
        ///NODE_END RUN
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD FLOAT_ACROSS_p1_condition
    public bool FLOAT_ACROSS_p1_condition (  ) {
        ///METHOD_BODY_START FLOAT_ACROSS_p1_condition
        /*//				if( $escape_type = "alone" )			*/
        return GameFlags.P2EscapeType == "alone";
        ///METHOD_BODY_END FLOAT_ACROSS_p1_condition
    }

    ///METHOD N_SIDE_p1_condition
    public bool N_SIDE_p1_condition (  ) {
        ///METHOD_BODY_START N_SIDE_p1_condition
        /*//					if( $escape_type = "henry" )			*/
        return GameFlags.P2EscapeType == "henry";
        ///METHOD_BODY_END N_SIDE_p1_condition
    }

    ///METHOD N_SIDE_p1_show
    public void N_SIDE_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START N_SIDE_p1_show
        /*//					#p2_henry_code = 40*/
        GameFlags.P2HenryCode = 40;
        ///METHOD_BODY_END N_SIDE_p1_show
    }

    ///METHOD HELP_p0_show
    public void HELP_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START HELP_p0_show
        /*//				post("setNodeState", "SHORE|VISIBLE")
        //				post("setNodeState", "SECLUDED|GHOSTED")
        //				post("setNodeState", "DOVER|DEAD")*/
        ///METHOD_BODY_END HELP_p0_show
    }

    ///METHOD CAUGHT2_p0_show
    public void CAUGHT2_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START CAUGHT2_p0_show
        /*//				#p2_henry_code = 20*/
        GameFlags.P2HenryCode = 20;
        ///METHOD_BODY_END CAUGHT2_p0_show
    }

    ///METHOD FLOAT_r0_select
    public void FLOAT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FLOAT_r0_select
        /*//				if( $escape_type = "henry" )
        //					$next_node = "H_CHOICE"
        //				/if			*/
        if (GameFlags.P2EscapeType == "henry"){
        DialogGameFlags.next_node ="H_CHOICE";
        }
        else{
        DialogGameFlags.next_node ="END";
        }
        ///METHOD_BODY_END FLOAT_r0_select
    }

    ///METHOD GOODBYE_r0_select
    public void GOODBYE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START GOODBYE_r0_select
        /*//				#p2_henry_code = 40
        //				killHenry()*/
        GameFlags.P2HenryCode = 40;
        GlobalScripts.KillHenry();
        ///METHOD_BODY_END GOODBYE_r0_select
    }

    ///METHOD FLOAT_ACROSS_r0_select
    public void FLOAT_ACROSS_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FLOAT_ACROSS_r0_select
        /*//				#rand = random(100)
        //				#rand = #rand + (15 * #escape_attempt)
        //				if( #rand > 60 )
        //					$next_node = "N_SIDE"
        //				else
        //					$next_node = "S_SIDE"
        //				/if*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        rand+=15*GameFlags.P2EscapeAttempts;
        if (rand > 60){
        DialogGameFlags.next_node = "N_SIDE";
        }
        else{
        DialogGameFlags.next_node = "S_SIDE";
        }
        ///METHOD_BODY_END FLOAT_ACROSS_r0_select
    }

    ///METHOD S_SIDE_r0_select
    public void S_SIDE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START S_SIDE_r0_select
        /*//				endState("escape_end", "")			*/
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END S_SIDE_r0_select
    }

    ///METHOD N_SIDE_r0_select
    public void N_SIDE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START N_SIDE_r0_select
        /*//				#lucy_health = 1
        //				killHenry()
        //				post("reportHealth", "")*/
        GameFlags.P2LucyHealth = 1;
        GlobalScripts.KillHenry();
        ///METHOD_BODY_END N_SIDE_r0_select
    }

    ///METHOD DIRECTIONS_r0_select
    public void DIRECTIONS_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START DIRECTIONS_r0_select
        /*//				post("setNodeState", "SHORE|VISIBLE")
        //				$pick_result = "across1"*/
        ///METHOD_BODY_END DIRECTIONS_r0_select
    }

    ///METHOD HELP_r0_select
    public void HELP_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START HELP_r0_select
        /*//				if( $escape_type = "henry" )
        //					$next_node = "CAUGHT"
        //				/if*/
        if (GameFlags.P2EscapeType == "henry"){
        DialogGameFlags.next_node ="CAUGHT";
        }
        else{
        DialogGameFlags.next_node ="ACROSS";
        }
        ///METHOD_BODY_END HELP_r0_select
    }

    ///METHOD ACROSS_r0_select
    public void ACROSS_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START ACROSS_r0_select
        /*//				#rand = random(100)
        //				#rand = #rand + (15 * #escape_attempt)
        //				if( #rand > 60 )
        //					$next_node = "N_SIDE"
        //				else
        //					$next_node = "S_SIDE"
        //				/if*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        rand+=15*GameFlags.P2EscapeAttempts;
        if (rand > 60){
        DialogGameFlags.next_node = "N_SIDE";
        }
        else{
        DialogGameFlags.next_node = "S_SIDE";
        }
        ///METHOD_BODY_END ACROSS_r0_select
    }

    ///METHOD CAUGHT_r0_select
    public void CAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START CAUGHT_r0_select
        /*// $pick_result = "across2" */
        ///METHOD_BODY_END CAUGHT_r0_select
    }

    ///METHOD CAUGHT2_r0_select
    public void CAUGHT2_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START CAUGHT2_r0_select
        /*//				killHenry()*/
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END CAUGHT2_r0_select
    }

    ///METHOD FLOAT_r0_nextnodeid
    public string FLOAT_r0_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START FLOAT_r0_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END FLOAT_r0_nextnodeid
    }

    ///METHOD FLOAT_ACROSS_r0_nextnodeid
    public string FLOAT_ACROSS_r0_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START FLOAT_ACROSS_r0_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END FLOAT_ACROSS_r0_nextnodeid
    }

    ///METHOD HELP_r0_nextnodeid
    public string HELP_r0_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START HELP_r0_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END HELP_r0_nextnodeid
    }

    ///METHOD ACROSS_r0_nextnodeid
    public string ACROSS_r0_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START ACROSS_r0_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END ACROSS_r0_nextnodeid
    }
}
//CLASS_END Dialog_p2_sec_001
