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
//CLASS Dialog_p2_tol_001
public class Dialog_p2_tol_001 {
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
        ///DIALOG_ID p2_tol_001
        var dialog = new Dialog();
        dialog.Id = "p2_tol_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 TOL
        node.Npc = "TOL";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Popup
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n01~|||~Header~||~~|~ImagePath~||~toll_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "toll_700");
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 A short bridge extends across the river here. A rope stretches across the mouth of the bridge preventing horses and wagons from crossing unless they pay the toll. The toll man studies you from his small wooden shack nearby.
        prompt.Text = "A short bridge extends across the river here. A rope stretches across the mouth of the bridge preventing horses and wagons from crossing unless they pay the toll. The toll man studies you from his small wooden shack nearby.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Tell him that Heath says \"Hello.\"
        response.Text = "Tell him that Heath says \"Hello.\"";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 HINT
        response.NextNodeId = "HINT";
        response.SetCondition(n01_r0_condition);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Go somewhere else.
        response.Text = "Go somewhere else.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 END
        response.NextNodeId = "END";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Wait until night and sneak across.
        response.Text = "Wait until night and sneak across.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 SNEAK
        response.NextNodeId = "SNEAK";
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 Dash across the bridge.
        response.Text = "Dash across the bridge.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 3 
        response.NextNodeId = "";
        response.OnSelect(n01_r3_select);
        response.OnSelectNextNodeId(n01_r3_nextnodeid);
        
        ///NODE_END n01
        ///NODE_START DASH1
        node = dialog.CreateNode("DASH1");
        ///NODE_NPC DASH1 TOL
        node.Npc = "TOL";
        ///NODE_RANDOM_RESPONSES DASH1 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE DASH1 Popup
        ///NODE_VISUAL_USESCRIPT DASH1 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~DASH1~|||~Header~||~~|~ImagePath~||~toll_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "toll_700");
        ///PROMPT DASH1 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT DASH1 0 You run across and don't look back. The toll man shouts but doesn't follow you. Hopefully he won't alert a patrol until you are long gone.
        prompt.Text = "You run across and don't look back. The toll man shouts but doesn't follow you. Hopefully he won't alert a patrol until you are long gone.";
        ///PROMPT_IGNORE_VO DASH1 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE DASH1 0
        response = node.AddResponse();
        ///RESPONSE_TEXT DASH1 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE DASH1 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID DASH1 0 END
        response.NextNodeId = "END";
        response.OnSelect(DASH1_r0_select);
        
        ///NODE_END DASH1
        ///NODE_START DASH2
        node = dialog.CreateNode("DASH2");
        ///NODE_NPC DASH2 TOL
        node.Npc = "TOL";
        ///NODE_RANDOM_RESPONSES DASH2 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE DASH2 Popup
        ///NODE_VISUAL_USESCRIPT DASH2 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~DASH2~|||~Header~||~~|~ImagePath~||~toll_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "toll_700");
        ///PROMPT DASH2 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT DASH2 0 You sprint across the bridge only to run into a mounted patrol on the other side. There is nowhere to run. You are swiftly returned to the King Plantation.
        prompt.Text = "You sprint across the bridge only to run into a mounted patrol on the other side. There is nowhere to run. You are swiftly returned to the King Plantation.";
        ///PROMPT_IGNORE_VO DASH2 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE DASH2 0
        response = node.AddResponse();
        ///RESPONSE_TEXT DASH2 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE DASH2 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID DASH2 0 END
        response.NextNodeId = "END";
        response.OnSelect(DASH2_r0_select);
        
        ///NODE_END DASH2
        ///NODE_START SNEAK
        node = dialog.CreateNode("SNEAK");
        ///NODE_NPC SNEAK TOL
        node.Npc = "TOL";
        ///NODE_RANDOM_RESPONSES SNEAK False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SNEAK Popup
        ///NODE_VISUAL_USESCRIPT SNEAK false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~SNEAK~|||~Header~||~~|~ImagePath~||~toll2_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "toll2_700");
        ///PROMPT SNEAK 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SNEAK 0 You hide until it is the dead of night and the toll man has fallen asleep after drinking. Then, as quickly and quietly as you can, you make your way across the bridge.
        prompt.Text = "You hide until it is the dead of night and the toll man has fallen asleep after drinking. Then, as quickly and quietly as you can, you make your way across the bridge.";
        ///PROMPT_IGNORE_VO SNEAK 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(SNEAK_p0_show);
        
        ///RESPONSE SNEAK 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SNEAK 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE SNEAK 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SNEAK 0 END
        response.NextNodeId = "END";
        
        ///NODE_END SNEAK
        ///NODE_START HINT
        node = dialog.CreateNode("HINT");
        ///NODE_NPC HINT TOL
        node.Npc = "TOL";
        ///NODE_RANDOM_RESPONSES HINT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HINT Popup
        ///NODE_VISUAL_USESCRIPT HINT false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~HINT~|||~Header~||~~|~ImagePath~||~toll_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "toll_700");
        ///PROMPT HINT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HINT 0 The man mops some sweat from his forehead and nods. He waves you across.
        prompt.Text = "The man mops some sweat from his forehead and nods. He waves you across.";
        ///PROMPT_IGNORE_VO HINT 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(HINT_p0_show);
        
        ///RESPONSE HINT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HINT 0 Cross the bridge.
        response.Text = "Cross the bridge.";
        ///RESPONSE_NEXT_NODE_TYPE HINT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HINT 0 END
        response.NextNodeId = "END";
        
        ///NODE_END HINT
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD SNEAK_p0_show
    public void SNEAK_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START SNEAK_p0_show
        /*// $pick_result = "cross" */
        ///METHOD_BODY_END SNEAK_p0_show
    }

    ///METHOD HINT_p0_show
    public void HINT_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START HINT_p0_show
        /*// $pick_result = "cross" */
        ///METHOD_BODY_END HINT_p0_show
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*// if(?p2_toll_hint = true)*/
        return GameFlags.P2TollHint;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n01_r3_select
    public void n01_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r3_select
        /*//				if( random(100) < 70 )
        //					$next_node = "DASH1"
        //				else
        //					$next_node = "DASH2"
        //				/if						*/
        
        int rand = UnityEngine.Random.RandomRange(1,100);
        if (rand < 70){
        DialogGameFlags.next_node = "DASH1";
        }
        else{
        DialogGameFlags.next_node = "DASH2";
        }
        ///METHOD_BODY_END n01_r3_select
    }

    ///METHOD DASH1_r0_select
    public void DASH1_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START DASH1_r0_select
        /*// $pick_result = "cross" */
        ///METHOD_BODY_END DASH1_r0_select
    }

    ///METHOD DASH2_r0_select
    public void DASH2_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START DASH2_r0_select
        /*// endState("escape_end", "") */
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END DASH2_r0_select
    }

    ///METHOD n01_r3_nextnodeid
    public string n01_r3_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r3_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01_r3_nextnodeid
    }
}
//CLASS_END Dialog_p2_tol_001
