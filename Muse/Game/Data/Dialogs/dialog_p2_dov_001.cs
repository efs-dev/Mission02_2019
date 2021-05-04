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
//CLASS Dialog_p2_dov_001
public class Dialog_p2_dov_001 {
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
        ///DIALOG_ID p2_dov_001
        var dialog = new Dialog();
        dialog.Id = "p2_dov_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 DOV
        node.Npc = "DOV";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You reach the edge of the small town of Dover.
        prompt.Text = "You reach the edge of the small town of Dover.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Wait until night to try to steal a boat.
        response.Text = "Wait until night to try to steal a boat.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 0 
        response.NextNodeId = "";
        response.OnSelect(n01_r0_select);
        response.OnSelectNextNodeId(n01_r0_nextnodeid);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Try to steal a boat.
        response.Text = "Try to steal a boat.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 STEAL_DAY
        response.NextNodeId = "STEAL_DAY";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Go somewhere else.
        response.Text = "Go somewhere else.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 END
        response.NextNodeId = "END";
        
        ///NODE_END n01
        ///NODE_START AXE_BOAT
        node = dialog.CreateNode("AXE_BOAT");
        ///NODE_NPC AXE_BOAT DOV
        node.Npc = "DOV";
        ///NODE_RANDOM_RESPONSES AXE_BOAT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE AXE_BOAT Full
        ///NODE_VISUAL_USESCRIPT AXE_BOAT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~AXE_BOAT~|||~
        ///PROMPT AXE_BOAT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT AXE_BOAT 0 Most boats are locked up, but using your axe you quickly free one. You are not familiar with boating but manage to make your way across the river with some difficulty.
        prompt.Text = "Most boats are locked up, but using your axe you quickly free one. You are not familiar with boating but manage to make your way across the river with some difficulty.";
        ///PROMPT_IGNORE_VO AXE_BOAT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE AXE_BOAT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT AXE_BOAT 0 Go across.
        response.Text = "Go across.";
        ///RESPONSE_NEXT_NODE_TYPE AXE_BOAT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID AXE_BOAT 0 END
        response.NextNodeId = "END";
        response.OnSelect(AXE_BOAT_r0_select);
        
        ///NODE_END AXE_BOAT
        ///NODE_START AXE_NO_BOAT
        node = dialog.CreateNode("AXE_NO_BOAT");
        ///NODE_NPC AXE_NO_BOAT DOV
        node.Npc = "DOV";
        ///NODE_RANDOM_RESPONSES AXE_NO_BOAT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE AXE_NO_BOAT Full
        ///NODE_VISUAL_USESCRIPT AXE_NO_BOAT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~AXE_NO_BOAT~|||~
        ///PROMPT AXE_NO_BOAT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT AXE_NO_BOAT 0 Most boats are locked up. Your axe could help you free one, but all the boats you find are watched too closely.
        prompt.Text = "Most boats are locked up. Your axe could help you free one, but all the boats you find are watched too closely.";
        ///PROMPT_IGNORE_VO AXE_NO_BOAT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE AXE_NO_BOAT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT AXE_NO_BOAT 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE AXE_NO_BOAT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID AXE_NO_BOAT 0 END
        response.NextNodeId = "END";
        
        ///NODE_END AXE_NO_BOAT
        ///NODE_START STEAL_DAY
        node = dialog.CreateNode("STEAL_DAY");
        ///NODE_NPC STEAL_DAY DOV
        node.Npc = "DOV";
        ///NODE_RANDOM_RESPONSES STEAL_DAY False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE STEAL_DAY Full
        ///NODE_VISUAL_USESCRIPT STEAL_DAY false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~STEAL_DAY~|||~
        ///PROMPT STEAL_DAY 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT STEAL_DAY 0 On this side of the river the boats are locked up and closely watched. You draw attention to yourself and are captured and turned in for a reward.
        prompt.Text = "On this side of the river the boats are locked up and closely watched. You draw attention to yourself and are captured and turned in for a reward.";
        ///PROMPT_IGNORE_VO STEAL_DAY 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE STEAL_DAY 0
        response = node.AddResponse();
        ///RESPONSE_TEXT STEAL_DAY 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE STEAL_DAY 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID STEAL_DAY 0 END
        response.NextNodeId = "END";
        response.OnSelect(STEAL_DAY_r0_select);
        
        ///NODE_END STEAL_DAY
        ///NODE_START NO_BOAT
        node = dialog.CreateNode("NO_BOAT");
        ///NODE_NPC NO_BOAT DOV
        node.Npc = "DOV";
        ///NODE_RANDOM_RESPONSES NO_BOAT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NO_BOAT Full
        ///NODE_VISUAL_USESCRIPT NO_BOAT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NO_BOAT~|||~
        ///PROMPT NO_BOAT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NO_BOAT 0 You search for a long time, but it's no good. The boats on this side of the river are kept locked up tight.
        prompt.Text = "You search for a long time, but it's no good. The boats on this side of the river are kept locked up tight.";
        ///PROMPT_IGNORE_VO NO_BOAT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NO_BOAT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NO_BOAT 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE NO_BOAT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NO_BOAT 0 END
        response.NextNodeId = "END";
        
        ///NODE_END NO_BOAT
        ///NODE_START GOT_BOAT
        node = dialog.CreateNode("GOT_BOAT");
        ///NODE_NPC GOT_BOAT DOV
        node.Npc = "DOV";
        ///NODE_RANDOM_RESPONSES GOT_BOAT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE GOT_BOAT Full
        ///NODE_VISUAL_USESCRIPT GOT_BOAT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~GOT_BOAT~|||~
        ///PROMPT GOT_BOAT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT GOT_BOAT 0 Most boats on this side of the river are kept locked up, but you manage to find one unlocked and, with difficulty, make your way to the far side.
        prompt.Text = "Most boats on this side of the river are kept locked up, but you manage to find one unlocked and, with difficulty, make your way to the far side.";
        ///PROMPT_IGNORE_VO GOT_BOAT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE GOT_BOAT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT GOT_BOAT 0 Go across.
        response.Text = "Go across.";
        ///RESPONSE_NEXT_NODE_TYPE GOT_BOAT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID GOT_BOAT 0 END
        response.NextNodeId = "END";
        response.OnSelect(GOT_BOAT_r0_select);
        
        ///NODE_END GOT_BOAT
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//				#rand = random(100)
        //				#rand = #rand + (#escape_attempt * 20)
        //				if( #rand > 100 )
        //					$next_node = "GOT_BOAT"
        //				else
        //					$next_node = "NO_BOAT"
        //				/if
        //				if( hasItem("AXE") AND (#rand > 70 ) )
        //					$next_node = "AXE_BOAT"
        //				elseif( hasItem("AXE") )
        //					$next_node = "AXE_NO_BOAT"
        //				/if*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        rand += GameFlags.P2EscapeAttempts * 20;
        if (rand > 100){
        	DialogGameFlags.next_node = "GOT_BOAT";
        }
        else{
        	DialogGameFlags.next_node = "NO_BOAT";
        }
        if(GameFlags.P2HasAxe){
        	if (rand > 70){
        		DialogGameFlags.next_node = "AXE_BOAT";
        	}
        	else{
        		DialogGameFlags.next_node = "AXE_NO_BOAT";
        	}
        }
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD AXE_BOAT_r0_select
    public void AXE_BOAT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START AXE_BOAT_r0_select
        /*//			$pick_result = "boat"
        //			post("doTrip", "LANDING")  */
        ///METHOD_BODY_END AXE_BOAT_r0_select
    }

    ///METHOD STEAL_DAY_r0_select
    public void STEAL_DAY_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START STEAL_DAY_r0_select
        /*// endState("escape_end", "") */
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END STEAL_DAY_r0_select
    }

    ///METHOD GOT_BOAT_r0_select
    public void GOT_BOAT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START GOT_BOAT_r0_select
        /*//			$pick_result = "boat"
        //			post("doTrip", "LANDING")  */
        ///METHOD_BODY_END GOT_BOAT_r0_select
    }

    ///METHOD n01_r0_nextnodeid
    public string n01_r0_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01_r0_nextnodeid
    }
}
//CLASS_END Dialog_p2_dov_001
