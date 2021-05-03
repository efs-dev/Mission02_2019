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
//CLASS Dialog_p2_brk_001
public class Dialog_p2_brk_001 {
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
        ///DIALOG_ID p2_brk_001
        var dialog = new Dialog();
        dialog.Id = "p2_brk_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 BRK
        node.Npc = "BRK";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You arrive at the outskirts of Brooksville, Kentucky and see a poster nailed to a tree.
        prompt.Text = "You arrive at the outskirts of Brooksville, Kentucky and see a poster nailed to a tree.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Go far out of your way around town.
        response.Text = "Go far out of your way around town.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 DETOUR
        response.NextNodeId = "DETOUR";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Wait until nightfall.
        response.Text = "Wait until nightfall.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 1 
        response.NextNodeId = "";
        response.OnSelect(n01_r1_select);
        response.OnSelectNextNodeId(n01_r1_nextnodeid);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Hurry through town.
        response.Text = "Hurry through town.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 2 
        response.NextNodeId = "";
        response.OnSelect(n01_r2_select);
        response.OnSelectNextNodeId(n01_r2_nextnodeid);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 Look at the poster.
        response.Text = "Look at the poster.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n01a
        response.NextNodeId = "n01a";
        response.OnSelect(n01_r3_select);
        
        ///NODE_END n01
        ///NODE_START n01a
        node = dialog.CreateNode("n01a");
        ///NODE_NPC n01a BRK
        node.Npc = "BRK";
        ///NODE_RANDOM_RESPONSES n01a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01a Full
        ///NODE_VISUAL_USESCRIPT n01a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01a~|||~
        ///PROMPT n01a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01a 0 You are just outside of Brooksville, Kentucky.
        prompt.Text = "You are just outside of Brooksville, Kentucky.";
        ///PROMPT_IGNORE_VO n01a 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01a 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01a 0 Go far out of your way around town.
        response.Text = "Go far out of your way around town.";
        ///RESPONSE_NEXT_NODE_TYPE n01a 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01a 0 DETOUR
        response.NextNodeId = "DETOUR";
        
        ///RESPONSE n01a 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01a 1 Change clothes and stroll through town.
        response.Text = "Change clothes and stroll through town.";
        ///RESPONSE_NEXT_NODE_TYPE n01a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01a 1 HURRY1
        response.NextNodeId = "HURRY1";
        response.SetCondition(n01a_r1_condition);
        response.OnSelect(n01a_r1_select);
        
        ///RESPONSE n01a 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01a 2 Wait until nightfall.
        response.Text = "Wait until nightfall.";
        ///RESPONSE_NEXT_NODE_TYPE n01a 2 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01a 2 
        response.NextNodeId = "";
        response.OnSelect(n01a_r2_select);
        response.OnSelectNextNodeId(n01a_r2_nextnodeid);
        
        ///RESPONSE n01a 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01a 3 Hurry through town.
        response.Text = "Hurry through town.";
        ///RESPONSE_NEXT_NODE_TYPE n01a 3 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01a 3 
        response.NextNodeId = "";
        response.OnSelect(n01a_r3_select);
        response.OnSelectNextNodeId(n01a_r3_nextnodeid);
        
        ///NODE_END n01a
        ///NODE_START DETOUR
        node = dialog.CreateNode("DETOUR");
        ///NODE_NPC DETOUR BRK
        node.Npc = "BRK";
        ///NODE_RANDOM_RESPONSES DETOUR False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE DETOUR Full
        ///NODE_VISUAL_USESCRIPT DETOUR false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~DETOUR~|||~
        ///PROMPT DETOUR 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT DETOUR 0 You make a wide path around Brooksville. The way is difficult and you need to eat some extra food. [Food goes down.]
        prompt.Text = "You make a wide path around Brooksville. The way is difficult and you need to eat some extra food. [Food goes down.]";
        ///PROMPT_IGNORE_VO DETOUR 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE DETOUR 0
        response = node.AddResponse();
        ///RESPONSE_TEXT DETOUR 0 [Keep going.]
        response.Text = "[Keep going.]";
        ///RESPONSE_NEXT_NODE_TYPE DETOUR 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID DETOUR 0 END
        response.NextNodeId = "END";
        response.OnSelect(DETOUR_r0_select);
        
        ///NODE_END DETOUR
        ///NODE_START HURRY1
        node = dialog.CreateNode("HURRY1");
        ///NODE_NPC HURRY1 BRK
        node.Npc = "BRK";
        ///NODE_RANDOM_RESPONSES HURRY1 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HURRY1 Full
        ///NODE_VISUAL_USESCRIPT HURRY1 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HURRY1~|||~
        ///PROMPT HURRY1 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HURRY1 0 [Lucky] You get some suspicious glances but you keep your head down and quickly move through town.
        prompt.Text = "[Lucky] You get some suspicious glances but you keep your head down and quickly move through town.";
        ///PROMPT_IGNORE_VO HURRY1 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HURRY1 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HURRY1 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE HURRY1 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HURRY1 0 END
        response.NextNodeId = "END";
        
        ///NODE_END HURRY1
        ///NODE_START HURRY2
        node = dialog.CreateNode("HURRY2");
        ///NODE_NPC HURRY2 BRK
        node.Npc = "BRK";
        ///NODE_RANDOM_RESPONSES HURRY2 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HURRY2 Full
        ///NODE_VISUAL_USESCRIPT HURRY2 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HURRY2~|||~
        ///PROMPT HURRY2 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HURRY2 0 Several people recognize you from the description in the wanted poster. The sheriff questions you and takes you into custody.
        prompt.Text = "Several people recognize you from the description in the wanted poster. The sheriff questions you and takes you into custody.";
        ///PROMPT_IGNORE_VO HURRY2 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HURRY2 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HURRY2 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE HURRY2 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HURRY2 0 END
        response.NextNodeId = "END";
        response.OnSelect(HURRY2_r0_select);
        
        ///NODE_END HURRY2
        ///NODE_START NIGHTFALL
        node = dialog.CreateNode("NIGHTFALL");
        ///NODE_NPC NIGHTFALL BRK
        node.Npc = "BRK";
        ///NODE_RANDOM_RESPONSES NIGHTFALL False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NIGHTFALL Full
        ///NODE_VISUAL_USESCRIPT NIGHTFALL false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NIGHTFALL~|||~
        ///PROMPT NIGHTFALL 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NIGHTFALL 0 It's very suspicious for a Negro to be out after dark, especially in a small town. You are quickly reported and taken into custody.
        prompt.Text = "It's very suspicious for a Negro to be out after dark, especially in a small town. You are quickly reported and taken into custody.";
        ///PROMPT_IGNORE_VO NIGHTFALL 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NIGHTFALL 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NIGHTFALL 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE NIGHTFALL 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NIGHTFALL 0 END
        response.NextNodeId = "END";
        response.OnSelect(NIGHTFALL_r0_select);
        
        ///NODE_END NIGHTFALL
        ///NODE_START NIGHTFALL_H
        node = dialog.CreateNode("NIGHTFALL_H");
        ///NODE_NPC NIGHTFALL_H BRK
        node.Npc = "BRK";
        ///NODE_RANDOM_RESPONSES NIGHTFALL_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NIGHTFALL_H Full
        ///NODE_VISUAL_USESCRIPT NIGHTFALL_H false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NIGHTFALL_H~|||~
        ///PROMPT NIGHTFALL_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NIGHTFALL_H 0 It's suspicious for slaves to be out at night. You're surprised by a patrol. \"Split up!\" Henry shouts. You run until you're exhausted. You don't know what happens to Henry. [Health goes down.]
        prompt.Text = "It's suspicious for slaves to be out at night. You're surprised by a patrol. \"Split up!\" Henry shouts. You run until you're exhausted. You don't know what happens to Henry. [Health goes down.]";
        ///PROMPT_IGNORE_VO NIGHTFALL_H 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NIGHTFALL_H 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NIGHTFALL_H 0 Go on
        response.Text = "Go on";
        ///RESPONSE_NEXT_NODE_TYPE NIGHTFALL_H 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NIGHTFALL_H 0 END
        response.NextNodeId = "END";
        response.OnSelect(NIGHTFALL_H_r0_select);
        
        ///NODE_END NIGHTFALL_H
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01a_r1_condition
    public bool n01a_r1_condition (  ) {
        ///METHOD_BODY_START n01a_r1_condition
        /*//				if( hasItem("CLOTHES") AND (?p2_disguised = false) ) */
        return GameFlags.P1HasClothes && !GameFlags.P2Disguised;
        ///METHOD_BODY_END n01a_r1_condition
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//				if( $escape_type = "henry" )
        //					$next_node = "NIGHTFALL_H"
        //				else
        //					$next_node = "NIGHTFALL"
        //				/if*/
        if (GameFlags.P2EscapeType == "henry"){
        	DialogGameFlags.next_node = "NIGHTFALL_H";
        }
        else{
        	DialogGameFlags.next_node = "NIGHTFALL";
        }
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n01_r2_select
    public void n01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_select
        /*//				#rand = random(100)
        //				// decrease chance
        //				if( $escape_type = "henry" )
        //					#rand = #rand - 15
        //				/if
        //				#rand = #rand + (15 * #escape_attempt)
        //				if( #rand > 40 )
        //					$next_node = "HURRY1"
        //				else
        //					$next_node = "HURRY2"
        //				/if*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        if (GameFlags.P2EscapeType == "henry"){
        	rand -= 15;
        }
        rand += GameFlags.P2EscapeAttempts * 15;
        
        if (rand > 40){
        	DialogGameFlags.next_node = "HURRY1";
        }
        else{
        	DialogGameFlags.next_node = "HURRY2";
        }
        ///METHOD_BODY_END n01_r2_select
    }

    ///METHOD n01_r3_select
    public void n01_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r3_select
        /*//					overlayPopup("brooksville_poster")
        //					?has_wanted2 = true*/
        ///METHOD_BODY_END n01_r3_select
    }

    ///METHOD n01a_r1_select
    public void n01a_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01a_r1_select
        /*//				?p2_disguised = true*/
        GameFlags.P2Disguised = true;
        ///METHOD_BODY_END n01a_r1_select
    }

    ///METHOD n01a_r2_select
    public void n01a_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01a_r2_select
        /*//				if( $escape_type = "henry" )
        //					$next_node = "NIGHTFALL_H"
        //				else
        //					$next_node = "NIGHTFALL"
        //				/if*/
        if (GameFlags.P2EscapeType == "henry"){
        	DialogGameFlags.next_node = "NIGHTFALL_H";
        }
        else{
        	DialogGameFlags.next_node = "NIGHTFALL";
        }
        ///METHOD_BODY_END n01a_r2_select
    }

    ///METHOD n01a_r3_select
    public void n01a_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01a_r3_select
        /*//				#rand = random(100)
        //				// decrease chance
        //				if( $escape_type = "henry" )
        //					#rand = #rand - 15
        //				/if
        //				#rand = #rand + (15 * #escape_attempt)
        //				if( #rand > 40 )
        //					$next_node = "HURRY1"
        //				else
        //					$next_node = "HURRY2"
        //				/if*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        if (GameFlags.P2EscapeType == "henry"){
        	rand -= 15;
        }
        rand += GameFlags.P2EscapeAttempts * 15;
        
        if (rand > 40){
        	DialogGameFlags.next_node = "HURRY1";
        }
        else{
        	DialogGameFlags.next_node = "HURRY2";
        }
        ///METHOD_BODY_END n01a_r3_select
    }

    ///METHOD DETOUR_r0_select
    public void DETOUR_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START DETOUR_r0_select
        /*//				doFood()*/
        GameFlags.P2LucyFood--;
        ///METHOD_BODY_END DETOUR_r0_select
    }

    ///METHOD HURRY2_r0_select
    public void HURRY2_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START HURRY2_r0_select
        /*//				endState("escape_end","")			*/
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END HURRY2_r0_select
    }

    ///METHOD NIGHTFALL_r0_select
    public void NIGHTFALL_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START NIGHTFALL_r0_select
        /*//				endState("escape_end", "")*/
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END NIGHTFALL_r0_select
    }

    ///METHOD NIGHTFALL_H_r0_select
    public void NIGHTFALL_H_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START NIGHTFALL_H_r0_select
        /*//				killHenry()
        //				#p2_henry_code = 20
        //				#lucy_health = #lucy_health - 1
        //				post("reportHealth", "")*/
        GlobalScripts.KillHenry();
        GameFlags.P2LucyHealth--;
        GameFlags.P2HenryCode = 20;
        ///METHOD_BODY_END NIGHTFALL_H_r0_select
    }

    ///METHOD n01_r1_nextnodeid
    public string n01_r1_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01_r1_nextnodeid
    }

    ///METHOD n01_r2_nextnodeid
    public string n01_r2_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01_r2_nextnodeid
    }

    ///METHOD n01a_r2_nextnodeid
    public string n01a_r2_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01a_r2_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01a_r2_nextnodeid
    }

    ///METHOD n01a_r3_nextnodeid
    public string n01a_r3_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01a_r3_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01a_r3_nextnodeid
    }
}
//CLASS_END Dialog_p2_brk_001
