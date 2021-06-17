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
//CLASS Dialog_p2_cro_001
public class Dialog_p2_cro_001 {
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
        ///DIALOG_ID p2_cro_001
        var dialog = new Dialog();
        dialog.Id = "p2_cro_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 CRO
        node.Npc = "CRO";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Popup
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n01~|||~Header~||~~|~ImagePath~||~crossing_s_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "crossing_s_700");
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 The river here is fairly fast and it might get deep.
        prompt.Text = "The river here is fairly fast and it might get deep.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Go somewhere else.
        response.Text = "Go somewhere else.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Try to float across on a log.
        response.Text = "Try to float across on a log.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 1 
        response.NextNodeId = "";
        response.OnSelect(n01_r1_select);
        response.OnSelectNextNodeId(n01_r1_nextnodeid);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Try to wade across.
        response.Text = "Try to wade across.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 2 
        response.NextNodeId = "";
        response.OnSelect(n01_r2_select);
        response.OnSelectNextNodeId(n01_r2_nextnodeid);
        
        ///NODE_END n01
        ///NODE_START misstep
        node = dialog.CreateNode("misstep");
        ///NODE_NPC misstep CRO
        node.Npc = "CRO";
        ///NODE_RANDOM_RESPONSES misstep False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE misstep Popup
        ///NODE_VISUAL_USESCRIPT misstep false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~misstep~|||~Header~||~~|~ImagePath~||~henryswept_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "henryswept_700");
        ///PROMPT misstep 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT misstep 0 Henry takes a bad step into a deep spot. He struggles but is too weak to fight the river current. It sweeps him away. \"I'll be okay,\" he shouts back at you, \"You keep going north!\"
        prompt.Text = "Henry takes a bad step into a deep spot. He struggles but is too weak to fight the river current. It sweeps him away. \"I'll be okay,\" he shouts back at you, \"You keep going north!\"";
        ///PROMPT_IGNORE_VO misstep 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE misstep 0
        response = node.AddResponse();
        ///RESPONSE_TEXT misstep 0 Shout goodbye and carefully finish crossing.
        response.Text = "Shout goodbye and carefully finish crossing.";
        ///RESPONSE_NEXT_NODE_TYPE misstep 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID misstep 0 END
        response.NextNodeId = "END";
        response.OnSelect(misstep_r0_select);
        
        ///NODE_END misstep
        ///NODE_START madeit
        node = dialog.CreateNode("madeit");
        ///NODE_NPC madeit CRO
        node.Npc = "CRO";
        ///NODE_RANDOM_RESPONSES madeit False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE madeit Popup
        ///NODE_VISUAL_USESCRIPT madeit false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~madeit~|||~Header~||~~|~ImagePath~||~crossing_s_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "crossing_s_700");
        ///PROMPT madeit 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT madeit 0 You move across very slowly and carefully, feeling ahead with a stick. The water comes right up to your nose. It's scary, but finally you make it to the far side.
        prompt.Text = "You move across very slowly and carefully, feeling ahead with a stick. The water comes right up to your nose. It's scary, but finally you make it to the far side.";
        ///PROMPT_IGNORE_VO madeit 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE madeit 0
        response = node.AddResponse();
        ///RESPONSE_TEXT madeit 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE madeit 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID madeit 0 END
        response.NextNodeId = "END";
        response.OnSelect(madeit_r0_select);
        
        ///NODE_END madeit
        ///NODE_START washedaway
        node = dialog.CreateNode("washedaway");
        ///NODE_NPC washedaway CRO
        node.Npc = "CRO";
        ///NODE_RANDOM_RESPONSES washedaway False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE washedaway Popup
        ///NODE_VISUAL_USESCRIPT washedaway false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~washedaway~|||~Header~||~~|~ImagePath~||~crossing_s_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "crossing_s_700");
        ///PROMPT washedaway 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT washedaway 0 The spot you are crossing is too deep and you were wading too quickly. The currents take you up and carry you far down stream before leaving you in a shallow part. You lose some of your food. [Health and food go down.]
        prompt.Text = "The spot you are crossing is too deep and you were wading too quickly. The currents take you up and carry you far down stream before leaving you in a shallow part. You lose some of your food. [Health and food go down.]";
        ///PROMPT_IGNORE_VO washedaway 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE washedaway 0
        response = node.AddResponse();
        ///RESPONSE_TEXT washedaway 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE washedaway 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID washedaway 0 END
        response.NextNodeId = "END";
        response.OnSelect(washedaway_r0_select);
        
        ///NODE_END washedaway
        ///NODE_START LOG_H
        node = dialog.CreateNode("LOG_H");
        ///NODE_NPC LOG_H CRO
        node.Npc = "CRO";
        ///NODE_RANDOM_RESPONSES LOG_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE LOG_H Popup
        ///NODE_VISUAL_USESCRIPT LOG_H false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~LOG_H~|||~Header~||~~|~ImagePath~||~crossing_s_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "crossing_s_700");
        ///PROMPT LOG_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT LOG_H 0 You find part of a fallen tree and enter the water. With you and Henry kicking and paddling you manage to make it across!
        prompt.Text = "You find part of a fallen tree and enter the water. With you and Henry kicking and paddling you manage to make it across!";
        ///PROMPT_IGNORE_VO LOG_H 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE LOG_H 0
        response = node.AddResponse();
        ///RESPONSE_TEXT LOG_H 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE LOG_H 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID LOG_H 0 END
        response.NextNodeId = "END";
        response.OnSelect(LOG_H_r0_select);
        
        ///NODE_END LOG_H
        ///NODE_START LOG
        node = dialog.CreateNode("LOG");
        ///NODE_NPC LOG CRO
        node.Npc = "CRO";
        ///NODE_RANDOM_RESPONSES LOG False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE LOG Popup
        ///NODE_VISUAL_USESCRIPT LOG false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~LOG~|||~Header~||~~|~ImagePath~||~crossing_s_700
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "crossing_s_700");
        ///PROMPT LOG 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT LOG 0 The log is hard to control. The river current carries you far downriver before depositing you in a shallow part.
        prompt.Text = "The log is hard to control. The river current carries you far downriver before depositing you in a shallow part.";
        ///PROMPT_IGNORE_VO LOG 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE LOG 0
        response = node.AddResponse();
        ///RESPONSE_TEXT LOG 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE LOG 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID LOG 0 END
        response.NextNodeId = "END";
        response.OnSelect(LOG_r0_select);
        
        ///NODE_END LOG
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//				if( $escape_type = "henry" )
        //					$next_node = "LOG_H"
        //				else
        //					$next_node = "LOG"
        //				/if*/
        if (GameFlags.P2EscapeType == "henry"){
        DialogGameFlags.next_node = "LOG_H";
        }
        else{
        DialogGameFlags.next_node = "LOG";
        }
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n01_r2_select
    public void n01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_select
        /*//				#rand = random(100)
        //				if( $escape_type = "henry" )
        //					$next_node = "misstep"
        //				else
        //					if( #rand > 35 )
        //						$next_node = "madeit"
        //					else
        //						$next_node = "washedaway"
        //					/if
        //				/if
        //			$pick_result = "okay" */
        int rand = UnityEngine.Random.RandomRange(1,100);
        if (GameFlags.P2EscapeType == "henry"){
        DialogGameFlags.next_node = "misstep";
        }
        else if (rand > 35){
        DialogGameFlags.next_node = "madeit";
        }
        else{
        DialogGameFlags.next_node = "washedaway";
        }
        ///METHOD_BODY_END n01_r2_select
    }

    ///METHOD misstep_r0_select
    public void misstep_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START misstep_r0_select
        /*//				killHenry()
        //				#p2_henry_code = 40
        //				post("doTrip", "CROSSING_N")*/
        GlobalScripts.KillHenry();
        GameFlags.P2HenryCode = 40;
        ///METHOD_BODY_END misstep_r0_select
    }

    ///METHOD madeit_r0_select
    public void madeit_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START madeit_r0_select
        /*// post("doTrip", "CROSSING_N")*/
        ///METHOD_BODY_END madeit_r0_select
    }

    ///METHOD washedaway_r0_select
    public void washedaway_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START washedaway_r0_select
        /*//				#lucy_health = #lucy_health - 1
        //				loseFood( 1 )
        //				post("reportHealth", "")
        //				post("doTrip", "FORD_N")*/
        GameFlags.P2LucyFood--;
        GameFlags.P2LucyHealth--;
        ///METHOD_BODY_END washedaway_r0_select
    }

    ///METHOD LOG_H_r0_select
    public void LOG_H_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START LOG_H_r0_select
        /*//				post("doTrip", "CROSSING_N")*/
        ///METHOD_BODY_END LOG_H_r0_select
    }

    ///METHOD LOG_r0_select
    public void LOG_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START LOG_r0_select
        /*//				post("doTrip", "FORD_N")*/
        ///METHOD_BODY_END LOG_r0_select
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
}
//CLASS_END Dialog_p2_cro_001
