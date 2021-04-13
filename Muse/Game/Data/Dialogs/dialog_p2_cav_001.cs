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
//CLASS Dialog_p2_cav_001
public class Dialog_p2_cav_001 {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
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
        ///DIALOG_ID p2_cav_001
        var dialog = new Dialog();
        dialog.Id = "p2_cav_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You get to the chilly cave and find signs that an animal was living here at some point.
        prompt.Text = "You get to the chilly cave and find signs that an animal was living here at some point.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Stay the night and risk lighting a fire.
        response.Text = "Stay the night and risk lighting a fire.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 FIRE
        response.NextNodeId = "FIRE";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Stay the night inside.
        response.Text = "Stay the night inside.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 
        response.NextNodeId = "";
        response.OnSelect(n01_r1_select);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Force yourself to move on.
        response.Text = "Force yourself to move on.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 FORCE
        response.NextNodeId = "FORCE";
        
        ///NODE_END n01
        ///NODE_START FORCE
        node = dialog.CreateNode("FORCE");
        ///NODE_NPC FORCE CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES FORCE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FORCE Full
        ///NODE_VISUAL_USESCRIPT FORCE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FORCE~|||~
        ///PROMPT FORCE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FORCE 0 No telling what might be nearby. You push on even though it's very tiring. [Health goes down.]
        prompt.Text = "No telling what might be nearby. You push on even though it's very tiring. [Health goes down.]";
        ///PROMPT_IGNORE_VO FORCE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FORCE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FORCE 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE FORCE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FORCE 0 END
        response.NextNodeId = "END";
        response.OnSelect(FORCE_r0_select);
        
        ///NODE_END FORCE
        ///NODE_START FIRE
        node = dialog.CreateNode("FIRE");
        ///NODE_NPC FIRE CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES FIRE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FIRE Full
        ///NODE_VISUAL_USESCRIPT FIRE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FIRE~|||~
        ///PROMPT FIRE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FIRE 0 You light a fire at the mouth of the cave and settle down to rest.
        prompt.Text = "You light a fire at the mouth of the cave and settle down to rest.";
        ///PROMPT_IGNORE_VO FIRE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FIRE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FIRE 0 Go to sleep.
        response.Text = "Go to sleep.";
        ///RESPONSE_NEXT_NODE_TYPE FIRE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FIRE 0 END
        response.NextNodeId = "END";
        response.OnSelect(FIRE_r0_select);
        
        ///NODE_END FIRE
        ///NODE_START CAUGHT
        node = dialog.CreateNode("CAUGHT");
        ///NODE_NPC CAUGHT CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES CAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CAUGHT Full
        ///NODE_VISUAL_USESCRIPT CAUGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CAUGHT~|||~
        ///PROMPT CAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CAUGHT 0 You are surprised in the middle of the night by an armed patrol that saw the fire. They don't believe your story and take you to the sheriff. You are returned to the plantation and soon sold south.
        prompt.Text = "You are surprised in the middle of the night by an armed patrol that saw the fire. They don't believe your story and take you to the sheriff. You are returned to the plantation and soon sold south.";
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
        ///NODE_START ANIMAL
        node = dialog.CreateNode("ANIMAL");
        ///NODE_NPC ANIMAL CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES ANIMAL False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE ANIMAL Full
        ///NODE_VISUAL_USESCRIPT ANIMAL false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~ANIMAL~|||~
        ///PROMPT ANIMAL 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT ANIMAL 0 You are woken in the middle of the night by the sound of a large animal nearby. Luckily, it fears the fire and keeps its distance.
        prompt.Text = "You are woken in the middle of the night by the sound of a large animal nearby. Luckily, it fears the fire and keeps its distance.";
        ///PROMPT_IGNORE_VO ANIMAL 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE ANIMAL 0
        response = node.AddResponse();
        ///RESPONSE_TEXT ANIMAL 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE ANIMAL 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID ANIMAL 0 END
        response.NextNodeId = "END";
        
        ///NODE_END ANIMAL
        ///NODE_START WARM
        node = dialog.CreateNode("WARM");
        ///NODE_NPC WARM CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES WARM False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE WARM Full
        ///NODE_VISUAL_USESCRIPT WARM false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~WARM~|||~
        ///PROMPT WARM 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT WARM 0 The fire keeps you warm in the chilly cave. You wake refreshed. [Health improves.]
        prompt.Text = "The fire keeps you warm in the chilly cave. You wake refreshed. [Health improves.]";
        ///PROMPT_IGNORE_VO WARM 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE WARM 0
        response = node.AddResponse();
        ///RESPONSE_TEXT WARM 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE WARM 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WARM 0 END
        response.NextNodeId = "END";
        response.OnSelect(WARM_r0_select);
        
        ///NODE_END WARM
        ///NODE_START COLD
        node = dialog.CreateNode("COLD");
        ///NODE_NPC COLD CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES COLD False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE COLD Full
        ///NODE_VISUAL_USESCRIPT COLD false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~COLD~|||~
        ///PROMPT COLD 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT COLD 0 The cave is a very cold place at night. You have nothing to keep you warm. You catch a chill during the night. [Health goes down.]
        prompt.Text = "The cave is a very cold place at night. You have nothing to keep you warm. You catch a chill during the night. [Health goes down.]";
        ///PROMPT_IGNORE_VO COLD 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT COLD 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT COLD 1 The cave is a very cold place at night. Luckily you have a shawl to stay warm. You rest well. [Health improves.]
        prompt.Text = "The cave is a very cold place at night. Luckily you have a shawl to stay warm. You rest well. [Health improves.]";
        ///PROMPT_IGNORE_VO COLD 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(COLD_p1_condition);
        
        ///PROMPT COLD 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT COLD 2 The cave is a very cold place at night. Luckily you have a blanket to stay warm. You rest well. [Health improves.]
        prompt.Text = "The cave is a very cold place at night. Luckily you have a blanket to stay warm. You rest well. [Health improves.]";
        ///PROMPT_IGNORE_VO COLD 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(COLD_p2_condition);
        
        ///RESPONSE COLD 0
        response = node.AddResponse();
        ///RESPONSE_TEXT COLD 0 [Move on.]
        response.Text = "[Move on.]";
        ///RESPONSE_NEXT_NODE_TYPE COLD 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID COLD 0 END
        response.NextNodeId = "END";
        response.SetCondition(COLD_r1_condition);
        response.OnSelect(COLD_r1_select);
        
        ///RESPONSE COLD 1
        response = node.AddResponse();
        ///RESPONSE_TEXT COLD 1 [Move on.]
        response.Text = "[Move on.]";
        ///RESPONSE_NEXT_NODE_TYPE COLD 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID COLD 1 END
        response.NextNodeId = "END";
        response.SetCondition(COLD_r0_condition);
        response.OnSelect(COLD_r0_select);
        
        ///NODE_END COLD
        ///NODE_START BEAR
        node = dialog.CreateNode("BEAR");
        ///NODE_NPC BEAR CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES BEAR False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE BEAR Full
        ///NODE_VISUAL_USESCRIPT BEAR false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~BEAR~|||~
        ///PROMPT BEAR 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT BEAR 0 As it grows dark and you try to fall asleep in this uncomfortable place, you hear an animal stirring deeper in the cave. You see a bear!
        prompt.Text = "As it grows dark and you try to fall asleep in this uncomfortable place, you hear an animal stirring deeper in the cave. You see a bear!";
        ///PROMPT_IGNORE_VO BEAR 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE BEAR 0
        response = node.AddResponse();
        ///RESPONSE_TEXT BEAR 0 [Slowly back out of the cave.]
        response.Text = "[Slowly back out of the cave.]";
        ///RESPONSE_NEXT_NODE_TYPE BEAR 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BEAR 0 SLOW
        response.NextNodeId = "SLOW";
        
        ///RESPONSE BEAR 1
        response = node.AddResponse();
        ///RESPONSE_TEXT BEAR 1 [Run!]
        response.Text = "[Run!]";
        ///RESPONSE_NEXT_NODE_TYPE BEAR 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BEAR 1 RUN
        response.NextNodeId = "RUN";
        
        ///NODE_END BEAR
        ///NODE_START RUN
        node = dialog.CreateNode("RUN");
        ///NODE_NPC RUN CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES RUN False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE RUN Full
        ///NODE_VISUAL_USESCRIPT RUN false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~RUN~|||~
        ///PROMPT RUN 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT RUN 0 The bear is faster than you and angry at your disturbance. It chases you down.
        prompt.Text = "The bear is faster than you and angry at your disturbance. It chases you down.";
        ///PROMPT_IGNORE_VO RUN 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE RUN 0
        response = node.AddResponse();
        ///RESPONSE_TEXT RUN 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE RUN 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID RUN 0 END
        response.NextNodeId = "END";
        response.OnSelect(RUN_r0_select);
        
        ///NODE_END RUN
        ///NODE_START SLOW
        node = dialog.CreateNode("SLOW");
        ///NODE_NPC SLOW CAV
        node.Npc = "CAV";
        ///NODE_RANDOM_RESPONSES SLOW False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SLOW Full
        ///NODE_VISUAL_USESCRIPT SLOW false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SLOW~|||~
        ///PROMPT SLOW 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SLOW 0 You take slow steps backwards out of the cave and keep moving until the cave is no longer in sight. You got away! Unfortunately you had to leave some food behind. [Food goes down.]
        prompt.Text = "You take slow steps backwards out of the cave and keep moving until the cave is no longer in sight. You got away! Unfortunately you had to leave some food behind. [Food goes down.]";
        ///PROMPT_IGNORE_VO SLOW 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SLOW 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SLOW 0 [Move on.]
        response.Text = "[Move on.]";
        ///RESPONSE_NEXT_NODE_TYPE SLOW 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SLOW 0 END
        response.NextNodeId = "END";
        response.OnSelect(SLOW_r0_select);
        
        ///NODE_END SLOW
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD COLD_p1_condition
    public bool COLD_p1_condition (  ) {
        ///METHOD_BODY_START COLD_p1_condition
        /*//if( hasItem("SHAWL") ) */
        return true;
        ///METHOD_BODY_END COLD_p1_condition
    }

    ///METHOD COLD_p2_condition
    public bool COLD_p2_condition (  ) {
        ///METHOD_BODY_START COLD_p2_condition
        /*//if( hasItem("BLANKET") ) */
        return true;
        ///METHOD_BODY_END COLD_p2_condition
    }

    ///METHOD COLD_r1_condition
    public bool COLD_r1_condition (  ) {
        ///METHOD_BODY_START COLD_r1_condition
        /*//if( (hasItem("BLANKET") = false) AND (hasItem("SHAWL")  = false) ) */
        return true;
        ///METHOD_BODY_END COLD_r1_condition
    }

    ///METHOD COLD_r0_condition
    public bool COLD_r0_condition (  ) {
        ///METHOD_BODY_START COLD_r0_condition
        /*//if( hasItem("BLANKET")  OR hasItem("SHAWL")  ) */
        return true;
        ///METHOD_BODY_END COLD_r0_condition
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//				#rand = random(100)
        //				if( #rand < 25 )
        //					$next_node = "BEAR"
        //				else
        //					$next_node = "COLD"
        //				/if*/
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD FORCE_r0_select
    public void FORCE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FORCE_r0_select
        /*//				#lucy_health = #lucy_health - 1
        //				#henry_health = #henry_health - 1
        //				updateMessage("Your health goes down")
        //				post("reportHealth", "")*/
        ///METHOD_BODY_END FORCE_r0_select
    }

    ///METHOD FIRE_r0_select
    public void FIRE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FIRE_r0_select
        /*//				#rand = random(100)
        //				if( #rand < 20 )
        //					$next_node = "CAUGHT"
        //				elseif( #rand < 50 )
        //					$next_node = "ANIMAL"
        //				else
        //					$next_node = "WARM"
        //				/if*/
        ///METHOD_BODY_END FIRE_r0_select
    }

    ///METHOD CAUGHT_r0_select
    public void CAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START CAUGHT_r0_select
        /*//				endState("escape_end", "")*/
        ///METHOD_BODY_END CAUGHT_r0_select
    }

    ///METHOD WARM_r0_select
    public void WARM_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START WARM_r0_select
        /*//				#lucy_health = #lucy_health + 1
        //				#henry_health = #henry_health + 1
        //				updateMessage("Your health improves.")
        //				post("reportHealth()", "")*/
        ///METHOD_BODY_END WARM_r0_select
    }

    ///METHOD COLD_r1_select
    public void COLD_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START COLD_r1_select
        /*//				#lucy_health = #lucy_health - 1
        //				#henry_health = #henry_health - 1
        //				updateMessage("Your health goes down.")
        //				post("reportHealth", "")*/
        ///METHOD_BODY_END COLD_r1_select
    }

    ///METHOD COLD_r0_select
    public void COLD_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START COLD_r0_select
        /*//				#lucy_health = #lucy_health + 1
        //				#henry_health = #henry_health + 1
        //				updateMessage("Your health improves.")
        //				post("reportHealth", "")*/
        ///METHOD_BODY_END COLD_r0_select
    }

    ///METHOD RUN_r0_select
    public void RUN_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUN_r0_select
        /*//				endState("escape_end", "")*/
        ///METHOD_BODY_END RUN_r0_select
    }

    ///METHOD SLOW_r0_select
    public void SLOW_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START SLOW_r0_select
        /*//				loseFood( 2 )*/
        ///METHOD_BODY_END SLOW_r0_select
    }
}
//CLASS_END Dialog_p2_cav_001
