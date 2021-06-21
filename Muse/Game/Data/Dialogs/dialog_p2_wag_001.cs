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
//CLASS Dialog_p2_wag_001
public class Dialog_p2_wag_001 {
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
        ///DIALOG_ID p2_wag_001
        var dialog = new Dialog();
        dialog.Id = "p2_wag_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Popup
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n01~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 There is a wagon outside the wagon station. Through the window you can smell something delicious cooking.
        prompt.Text = "There is a wagon outside the wagon station. Through the window you can smell something delicious cooking.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Hide in one of the wagons.
        response.Text = "Hide in one of the wagons.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 0 
        response.NextNodeId = "";
        response.OnSelect(n01_r0_select);
        response.OnSelectNextNodeId(n01_r0_nextnodeid);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Wait to see who comes out.
        response.Text = "Wait to see who comes out.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 1 
        response.NextNodeId = "";
        response.OnSelect(n01_r1_select);
        response.OnSelectNextNodeId(n01_r1_nextnodeid);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Go inside and ask for food.
        response.Text = "Go inside and ask for food.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 HELP
        response.NextNodeId = "HELP";
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 Force yourself to go on.
        response.Text = "Force yourself to go on.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 FORCE
        response.NextNodeId = "FORCE";
        
        ///NODE_END n01
        ///NODE_START CAUGHT
        node = dialog.CreateNode("CAUGHT");
        ///NODE_NPC CAUGHT WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES CAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CAUGHT Popup
        ///NODE_VISUAL_USESCRIPT CAUGHT false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~CAUGHT~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT CAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CAUGHT 0 You are discovered in the wagon and turned over to the local sheriff.
        prompt.Text = "You are discovered in the wagon and turned over to the local sheriff.";
        ///PROMPT_IGNORE_VO CAUGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE CAUGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CAUGHT 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE CAUGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CAUGHT 0 END
        response.NextNodeId = "END";
        response.OnSelect(CAUGHT_r0_select);
        
        ///NODE_END CAUGHT
        ///NODE_START HIDWELL
        node = dialog.CreateNode("HIDWELL");
        ///NODE_NPC HIDWELL WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES HIDWELL False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HIDWELL Popup
        ///NODE_VISUAL_USESCRIPT HIDWELL false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~HIDWELL~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT HIDWELL 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HIDWELL 0 You are discovered by the driver, but surprisingly he's not angry. He says you can stay hidden and he will take you across the Maysville ferry to Ohio!
        prompt.Text = "You are discovered by the driver, but surprisingly he's not angry. He says you can stay hidden and he will take you across the Maysville ferry to Ohio!";
        ///PROMPT_IGNORE_VO HIDWELL 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HIDWELL 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HIDWELL 0 More...
        response.Text = "More...";
        ///RESPONSE_NEXT_NODE_TYPE HIDWELL 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HIDWELL 0 END
        response.NextNodeId = "END";
        response.OnSelect(HIDWELL_r0_select);
        
        ///NODE_END HIDWELL
        ///NODE_START OFFERRIDE
        node = dialog.CreateNode("OFFERRIDE");
        ///NODE_NPC OFFERRIDE WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES OFFERRIDE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE OFFERRIDE Popup
        ///NODE_VISUAL_USESCRIPT OFFERRIDE false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~OFFERRIDE~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT OFFERRIDE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT OFFERRIDE 0 After awhile a Negro wagon driver comes out and gets ready to move on.
        prompt.Text = "After awhile a Negro wagon driver comes out and gets ready to move on.";
        ///PROMPT_IGNORE_VO OFFERRIDE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE OFFERRIDE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT OFFERRIDE 0 Leave when he's gone.
        response.Text = "Leave when he's gone.";
        ///RESPONSE_NEXT_NODE_TYPE OFFERRIDE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID OFFERRIDE 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE OFFERRIDE 1
        response = node.AddResponse();
        ///RESPONSE_TEXT OFFERRIDE 1 Ask for help.
        response.Text = "Ask for help.";
        ///RESPONSE_NEXT_NODE_TYPE OFFERRIDE 1 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID OFFERRIDE 1 
        response.NextNodeId = "";
        response.OnSelect(OFFERRIDE_r1_select);
        response.OnSelectNextNodeId(OFFERRIDE_r1_nextnodeid);
        
        ///NODE_END OFFERRIDE
        ///NODE_START OFFERHINT
        node = dialog.CreateNode("OFFERHINT");
        ///NODE_NPC OFFERHINT WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES OFFERHINT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE OFFERHINT Popup
        ///NODE_VISUAL_USESCRIPT OFFERHINT false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~OFFERHINT~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT OFFERHINT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT OFFERHINT 0 After awhile a black wagon driver comes out and gets ready to move on.
        prompt.Text = "After awhile a black wagon driver comes out and gets ready to move on.";
        ///PROMPT_IGNORE_VO OFFERHINT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE OFFERHINT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT OFFERHINT 0 Leave when he's gone.
        response.Text = "Leave when he's gone.";
        ///RESPONSE_NEXT_NODE_TYPE OFFERHINT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID OFFERHINT 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE OFFERHINT 1
        response = node.AddResponse();
        ///RESPONSE_TEXT OFFERHINT 1 Ask for help.
        response.Text = "Ask for help.";
        ///RESPONSE_NEXT_NODE_TYPE OFFERHINT 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID OFFERHINT 1 GIVEHINT
        response.NextNodeId = "GIVEHINT";
        
        ///NODE_END OFFERHINT
        ///NODE_START GIVEHINT
        node = dialog.CreateNode("GIVEHINT");
        ///NODE_NPC GIVEHINT WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES GIVEHINT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE GIVEHINT Popup
        ///NODE_VISUAL_USESCRIPT GIVEHINT false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~GIVEHINT~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT GIVEHINT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT GIVEHINT 0 The driver tells you to find help at the back door of the Maysville tavern.
        prompt.Text = "The driver tells you to find help at the back door of the Maysville tavern.";
        ///PROMPT_IGNORE_VO GIVEHINT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE GIVEHINT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT GIVEHINT 0 Thank him and leave.
        response.Text = "Thank him and leave.";
        ///RESPONSE_NEXT_NODE_TYPE GIVEHINT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID GIVEHINT 0 END
        response.NextNodeId = "END";
        response.OnSelect(GIVEHINT_r0_select);
        
        ///NODE_END GIVEHINT
        ///NODE_START WAGON_H
        node = dialog.CreateNode("WAGON_H");
        ///NODE_NPC WAGON_H WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES WAGON_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE WAGON_H Popup
        ///NODE_VISUAL_USESCRIPT WAGON_H false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~WAGON_H~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT WAGON_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT WAGON_H 0 The driver says he can hide one of you all the way across the Maysville ferry! \"You go,\" Henry insists, \"I'll find another way. Don't argue with me.\"
        prompt.Text = "The driver says he can hide one of you all the way across the Maysville ferry! \"You go,\" Henry insists, \"I'll find another way. Don't argue with me.\"";
        ///PROMPT_IGNORE_VO WAGON_H 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE WAGON_H 0
        response = node.AddResponse();
        ///RESPONSE_TEXT WAGON_H 0 Thank the driver, but continue with Henry.
        response.Text = "Thank the driver, but continue with Henry.";
        ///RESPONSE_NEXT_NODE_TYPE WAGON_H 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WAGON_H 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE WAGON_H 1
        response = node.AddResponse();
        ///RESPONSE_TEXT WAGON_H 1 Say goodbye to Henry and hide in the wagon.
        response.Text = "Say goodbye to Henry and hide in the wagon.";
        ///RESPONSE_NEXT_NODE_TYPE WAGON_H 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WAGON_H 1 WAGON
        response.NextNodeId = "WAGON";
        response.OnSelect(WAGON_H_r1_select);
        
        ///NODE_END WAGON_H
        ///NODE_START WAGON
        node = dialog.CreateNode("WAGON");
        ///NODE_NPC WAGON WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES WAGON False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE WAGON Popup
        ///NODE_VISUAL_USESCRIPT WAGON false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~WAGON~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT WAGON 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT WAGON 0 The driver says he can hide you all the way across the Maysville ferry! He hides you among his goods and tells you to be as quiet as you can.
        prompt.Text = "The driver says he can hide you all the way across the Maysville ferry! He hides you among his goods and tells you to be as quiet as you can.";
        ///PROMPT_IGNORE_VO WAGON 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE WAGON 0
        response = node.AddResponse();
        ///RESPONSE_TEXT WAGON 0 Set off.
        response.Text = "Set off.";
        ///RESPONSE_NEXT_NODE_TYPE WAGON 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WAGON 0 END
        response.NextNodeId = "END";
        response.OnSelect(WAGON_r0_select);
        
        ///NODE_END WAGON
        ///NODE_START FORCE
        node = dialog.CreateNode("FORCE");
        ///NODE_NPC FORCE WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES FORCE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FORCE Popup
        ///NODE_VISUAL_USESCRIPT FORCE false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~FORCE~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT FORCE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FORCE 0 You stagger on even though you are tired. You wind up exhausted. [Health goes down.]
        prompt.Text = "You stagger on even though you are tired. You wind up exhausted. [Health goes down.]";
        ///PROMPT_IGNORE_VO FORCE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FORCE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FORCE 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE FORCE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FORCE 0 END
        response.NextNodeId = "END";
        response.OnSelect(FORCE_r0_select);
        
        ///NODE_END FORCE
        ///NODE_START HELP
        node = dialog.CreateNode("HELP");
        ///NODE_NPC HELP WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES HELP False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HELP Popup
        ///NODE_VISUAL_USESCRIPT HELP false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~HELP~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT HELP 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HELP 0 The manager of the wagon station scowls when you walk in. \"Get out!\" he shouts, \"I'm calling a patrol!\"
        prompt.Text = "The manager of the wagon station scowls when you walk in. \"Get out!\" he shouts, \"I'm calling a patrol!\"";
        ///PROMPT_IGNORE_VO HELP 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HELP 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HELP 0 Run away!
        response.Text = "Run away!";
        ///RESPONSE_NEXT_NODE_TYPE HELP 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HELP 0 RUN
        response.NextNodeId = "RUN";
        
        ///NODE_END HELP
        ///NODE_START RUN
        node = dialog.CreateNode("RUN");
        ///NODE_NPC RUN WAG
        node.Npc = "WAG";
        ///NODE_RANDOM_RESPONSES RUN False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE RUN Popup
        ///NODE_VISUAL_USESCRIPT RUN false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~RUN~|||~Header~||~~|~ImagePath~||~wagon_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "wagon_700");
        ///PROMPT RUN 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT RUN 0 You run as fast as you can and wind up exhausted. [Health goes down.]
        prompt.Text = "You run as fast as you can and wind up exhausted. [Health goes down.]";
        ///PROMPT_IGNORE_VO RUN 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE RUN 0
        response = node.AddResponse();
        ///RESPONSE_TEXT RUN 0 When you can, move on.
        response.Text = "When you can, move on.";
        ///RESPONSE_NEXT_NODE_TYPE RUN 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID RUN 0 END
        response.NextNodeId = "END";
        response.OnSelect(RUN_r0_select);
        
        ///NODE_END RUN
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//				#rand = random(100)
        //				if( #rand > 85 )
        //					$next_node = "HIDWELL"
        //				else
        //					$next_node = "CAUGHT"
        //				/if*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        if (rand < 85){
        DialogGameFlags.next_node = "HIDWELL";
        }
        else{
        DialogGameFlags.next_node = "CAUGHT";
        }
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//				#rand = random(100)
        //				if( #rand > 50 )
        //					$next_node = "OFFERRIDE"
        //				else
        //					$next_node = "OFFERHINT"
        //				/if*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        if (rand < 50){
        DialogGameFlags.next_node = "OFFERRIDE";
        }
        else{
        DialogGameFlags.next_node = "OFFERHINT";
        }
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD CAUGHT_r0_select
    public void CAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START CAUGHT_r0_select
        /*//				endState("escape_end", "")*/
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END CAUGHT_r0_select
    }

    ///METHOD HIDWELL_r0_select
    public void HIDWELL_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START HIDWELL_r0_select
        /*//				$pick_result = "wagon"
        //				post("doTrip", "maysville_wagonstop-shore2")*/
        ///METHOD_BODY_END HIDWELL_r0_select
    }

    ///METHOD OFFERRIDE_r1_select
    public void OFFERRIDE_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START OFFERRIDE_r1_select
        /*//				if( $escape_type = "henry" )
        //					$next_node = "WAGON_H"
        //				else
        //					$next_node = "WAGON"
        //				/if*/
        if (GameFlags.P2EscapeType == "henry"){
        	DialogGameFlags.next_node = "WAGON_H";
        }
        else{
        	DialogGameFlags.next_node = "WAGON";
        }
        ///METHOD_BODY_END OFFERRIDE_r1_select
    }

    ///METHOD GIVEHINT_r0_select
    public void GIVEHINT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START GIVEHINT_r0_select
        /*//				?know_tavern = true*/
        GameFlags.P2KnowTavern = true;
        ///METHOD_BODY_END GIVEHINT_r0_select
    }

    ///METHOD WAGON_H_r1_select
    public void WAGON_H_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START WAGON_H_r1_select
        /*//				#p2_henry_code = 30
        //				killHenry()*/
        GameFlags.P2HenryCode = 30;
        GlobalScripts.KillHenry();
        ///METHOD_BODY_END WAGON_H_r1_select
    }

    ///METHOD WAGON_r0_select
    public void WAGON_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START WAGON_r0_select
        /*//				$pick_result = "wagon"
        //				post("doTrip", "maysville_wagonstop-shore2")*/
        ///METHOD_BODY_END WAGON_r0_select
    }

    ///METHOD FORCE_r0_select
    public void FORCE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FORCE_r0_select
        /*//				#lucy_health = #lucy_health - 1
        //				#henry_health = #henry_health - 1
        //				post("reportHealth", "")	*/
        GameFlags.P2LucyHealth--;
        GameFlags.P2HenryHealth--;
        ///METHOD_BODY_END FORCE_r0_select
    }

    ///METHOD RUN_r0_select
    public void RUN_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUN_r0_select
        /*//				#lucy_health = #lucy_health - 1
        //				#henry_health = #henry_health - 1
        //				post("reportHealth", "")*/
        GameFlags.P2LucyHealth--;
        GameFlags.P2HenryHealth--;
        ///METHOD_BODY_END RUN_r0_select
    }

    ///METHOD n01_r0_nextnodeid
    public string n01_r0_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01_r0_nextnodeid
    }

    ///METHOD n01_r1_nextnodeid
    public string n01_r1_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01_r1_nextnodeid
    }

    ///METHOD OFFERRIDE_r1_nextnodeid
    public string OFFERRIDE_r1_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START OFFERRIDE_r1_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END OFFERRIDE_r1_nextnodeid
    }
}
//CLASS_END Dialog_p2_wag_001
