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
//CLASS Dialog_p2_for_001
public class Dialog_p2_for_001 {
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
        ///DIALOG_ID p2_for_001
        var dialog = new Dialog();
        dialog.Id = "p2_for_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 FOR
        node.Npc = "FOR";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 This is a crossing point at a shallow part of the river that is busy with foot traffic and wagons full of corn and other goods.
        prompt.Text = "This is a crossing point at a shallow part of the river that is busy with foot traffic and wagons full of corn and other goods.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Go elsewhere.]
        response.Text = "[Go elsewhere.]";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Sneak across the ford at night.
        response.Text = "Sneak across the ford at night.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 WATCHED
        response.NextNodeId = "WATCHED";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Sneak across the ford.
        response.Text = "Sneak across the ford.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 2 
        response.NextNodeId = "";
        response.OnSelect(n01_r2_select);
        response.OnSelectNextNodeId(n01_r2_nextnodeid);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 Try to blend in and cross the ford.
        response.Text = "Try to blend in and cross the ford.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 MADEIT
        response.NextNodeId = "MADEIT";
        
        ///NODE_END n01
        ///NODE_START MADEIT
        node = dialog.CreateNode("MADEIT");
        ///NODE_NPC MADEIT FOR
        node.Npc = "FOR";
        ///NODE_RANDOM_RESPONSES MADEIT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE MADEIT Full
        ///NODE_VISUAL_USESCRIPT MADEIT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~MADEIT~|||~
        ///PROMPT MADEIT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT MADEIT 0 You make it to the far side of the ford without trouble. That was nerve-wracking!
        prompt.Text = "You make it to the far side of the ford without trouble. That was nerve-wracking!";
        ///PROMPT_IGNORE_VO MADEIT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE MADEIT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT MADEIT 0 Go on
        response.Text = "Go on";
        ///RESPONSE_NEXT_NODE_TYPE MADEIT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID MADEIT 0 END
        response.NextNodeId = "END";
        response.OnSelect(MADEIT_r0_select);
        
        ///NODE_END MADEIT
        ///NODE_START WATCHED
        node = dialog.CreateNode("WATCHED");
        ///NODE_NPC WATCHED FOR
        node.Npc = "FOR";
        ///NODE_RANDOM_RESPONSES WATCHED False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE WATCHED Full
        ///NODE_VISUAL_USESCRIPT WATCHED false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~WATCHED~|||~
        ///PROMPT WATCHED 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT WATCHED 0 Unfortunately the ford is patrolled heavily at night because it is such an easy place to cross. You spend the whole night but don't see an opportunity to get by without being caught. [Time passes and food goes down.]
        prompt.Text = "Unfortunately the ford is patrolled heavily at night because it is such an easy place to cross. You spend the whole night but don't see an opportunity to get by without being caught. [Time passes and food goes down.]";
        ///PROMPT_IGNORE_VO WATCHED 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE WATCHED 0
        response = node.AddResponse();
        ///RESPONSE_TEXT WATCHED 0 [Move on.]
        response.Text = "[Move on.]";
        ///RESPONSE_NEXT_NODE_TYPE WATCHED 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WATCHED 0 END
        response.NextNodeId = "END";
        response.OnSelect(WATCHED_r0_select);
        
        ///NODE_END WATCHED
        ///NODE_START SNEAK
        node = dialog.CreateNode("SNEAK");
        ///NODE_NPC SNEAK FOR
        node.Npc = "FOR";
        ///NODE_RANDOM_RESPONSES SNEAK False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SNEAK Full
        ///NODE_VISUAL_USESCRIPT SNEAK false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SNEAK~|||~
        ///PROMPT SNEAK 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SNEAK 0 Your strange behavior draws the attention of a mounted patrol.
        prompt.Text = "Your strange behavior draws the attention of a mounted patrol.";
        ///PROMPT_IGNORE_VO SNEAK 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SNEAK 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SNEAK 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE SNEAK 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SNEAK 0 CAUGHT
        response.NextNodeId = "CAUGHT";
        response.SetCondition(SNEAK_r0_condition);
        
        ///RESPONSE SNEAK 1
        response = node.AddResponse();
        ///RESPONSE_TEXT SNEAK 1 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE SNEAK 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SNEAK 1 SPLITUP
        response.NextNodeId = "SPLITUP";
        response.SetCondition(SNEAK_r1_condition);
        
        ///NODE_END SNEAK
        ///NODE_START CAUGHT
        node = dialog.CreateNode("CAUGHT");
        ///NODE_NPC CAUGHT FOR
        node.Npc = "FOR";
        ///NODE_RANDOM_RESPONSES CAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CAUGHT Full
        ///NODE_VISUAL_USESCRIPT CAUGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CAUGHT~|||~
        ///PROMPT CAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CAUGHT 0 They quickly ride you down and turn you in for a reward.
        prompt.Text = "They quickly ride you down and turn you in for a reward.";
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
        ///NODE_START SPLITUP
        node = dialog.CreateNode("SPLITUP");
        ///NODE_NPC SPLITUP FOR
        node.Npc = "FOR";
        ///NODE_RANDOM_RESPONSES SPLITUP False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SPLITUP Full
        ///NODE_VISUAL_USESCRIPT SPLITUP false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SPLITUP~|||~
        ///PROMPT SPLITUP 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SPLITUP 0 Henry shouts for you to split up. \"Run, Lucy!\" Since he is worth more money the patrol chases him. You get away.
        prompt.Text = "Henry shouts for you to split up. \"Run, Lucy!\" Since he is worth more money the patrol chases him. You get away.";
        ///PROMPT_IGNORE_VO SPLITUP 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SPLITUP 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SPLITUP 0 Sadly, go on.
        response.Text = "Sadly, go on.";
        ///RESPONSE_NEXT_NODE_TYPE SPLITUP 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SPLITUP 0 END
        response.NextNodeId = "END";
        response.OnSelect(SPLITUP_r0_select);
        
        ///NODE_END SPLITUP
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD SNEAK_r0_condition
    public bool SNEAK_r0_condition (  ) {
        ///METHOD_BODY_START SNEAK_r0_condition
        /*// if($escape_type = "alone") */
        return GameFlags.P2EscapeType == "alone";
        ///METHOD_BODY_END SNEAK_r0_condition
    }

    ///METHOD SNEAK_r1_condition
    public bool SNEAK_r1_condition (  ) {
        ///METHOD_BODY_START SNEAK_r1_condition
        /*// if($escape_type = "henry") */
        return GameFlags.P2EscapeType == "henry";
        ///METHOD_BODY_END SNEAK_r1_condition
    }

    ///METHOD n01_r2_select
    public void n01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_select
        /*//				#rand = random(100)
        //				if( #rand < 30 )
        //					$next_node = "SNEAK"
        //				else
        //					$next_node = "MADEIT"
        //				/if*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        if (rand < 30){
        DialogGameFlags.next_node = "SNEAK";
        }
        else{
        DialogGameFlags.next_node = "MADEIT";
        }
        ///METHOD_BODY_END n01_r2_select
    }

    ///METHOD MADEIT_r0_select
    public void MADEIT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START MADEIT_r0_select
        /*// post("doTrip", "FORD_N") */
        ///METHOD_BODY_END MADEIT_r0_select
    }

    ///METHOD WATCHED_r0_select
    public void WATCHED_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START WATCHED_r0_select
        /*//				doDays()
        //				doFood()
        //				//changeTemplate("top|gfx/smartmap/escape/enc/ford.png")	*/
        GlobalScripts.DoFood();
        GlobalScripts.DoDays();
        ///METHOD_BODY_END WATCHED_r0_select
    }

    ///METHOD CAUGHT_r0_select
    public void CAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START CAUGHT_r0_select
        /*// endState("escape_end", "") */
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END CAUGHT_r0_select
    }

    ///METHOD SPLITUP_r0_select
    public void SPLITUP_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START SPLITUP_r0_select
        /*//			#p2_henry_code = 20
        //			killHenry()
        //			post("doTrip", "FORD_N") */
        GameFlags.P2HenryCode = 20;
        GlobalScripts.KillHenry();
        ///METHOD_BODY_END SPLITUP_r0_select
    }

    ///METHOD n01_r2_nextnodeid
    public string n01_r2_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01_r2_nextnodeid
    }
}
//CLASS_END Dialog_p2_for_001
