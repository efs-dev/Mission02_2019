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
//CLASS Dialog_p2_won_001
public class Dialog_p2_won_001 {
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
        ///DIALOG_ID p2_won_001
        var dialog = new Dialog();
        dialog.Id = "p2_won_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START LOST_01
        node = dialog.CreateNode("LOST_01");
        ///NODE_NPC LOST_01 WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES LOST_01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE LOST_01 Full
        ///NODE_VISUAL_USESCRIPT LOST_01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~LOST_01~|||~
        ///PROMPT LOST_01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT LOST_01 0 It's getting dark and you feel like you are lost.
        prompt.Text = "It's getting dark and you feel like you are lost.";
        ///PROMPT_IGNORE_VO LOST_01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE LOST_01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT LOST_01 0 Keep moving.
        response.Text = "Keep moving.";
        ///RESPONSE_NEXT_NODE_TYPE LOST_01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID LOST_01 0 KEEP_MOVING
        response.NextNodeId = "KEEP_MOVING";
        response.SetCondition(LOST_01_r0_condition);
        
        ///RESPONSE LOST_01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT LOST_01 1 Keep moving.
        response.Text = "Keep moving.";
        ///RESPONSE_NEXT_NODE_TYPE LOST_01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID LOST_01 1 KEEP_MOVING_H
        response.NextNodeId = "KEEP_MOVING_H";
        response.SetCondition(LOST_01_r1_condition);
        
        ///RESPONSE LOST_01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT LOST_01 2 Spend the night where you are.
        response.Text = "Spend the night where you are.";
        ///RESPONSE_NEXT_NODE_TYPE LOST_01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID LOST_01 2 SPEND_NIGHT
        response.NextNodeId = "SPEND_NIGHT";
        
        ///NODE_END LOST_01
        ///NODE_START SPEND_NIGHT
        node = dialog.CreateNode("SPEND_NIGHT");
        ///NODE_NPC SPEND_NIGHT WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES SPEND_NIGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SPEND_NIGHT Full
        ///NODE_VISUAL_USESCRIPT SPEND_NIGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SPEND_NIGHT~|||~
        ///PROMPT SPEND_NIGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SPEND_NIGHT 0 Wolves and bears can roam the woods at night. You spend the night in between a group of large rocks. In the morning the sun helps you decide which way to go. [Extra time passes and food goes down.]
        prompt.Text = "Wolves and bears can roam the woods at night. You spend the night in between a group of large rocks. In the morning the sun helps you decide which way to go. [Extra time passes and food goes down.]";
        ///PROMPT_IGNORE_VO SPEND_NIGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SPEND_NIGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SPEND_NIGHT 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE SPEND_NIGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SPEND_NIGHT 0 END
        response.NextNodeId = "END";
        response.OnSelect(SPEND_NIGHT_r0_select);
        
        ///NODE_END SPEND_NIGHT
        ///NODE_START KEEP_MOVING
        node = dialog.CreateNode("KEEP_MOVING");
        ///NODE_NPC KEEP_MOVING WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES KEEP_MOVING False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE KEEP_MOVING Full
        ///NODE_VISUAL_USESCRIPT KEEP_MOVING false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~KEEP_MOVING~|||~
        ///PROMPT KEEP_MOVING 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT KEEP_MOVING 0 You can't see where you are going in the dark. You stumble into a patch of plants that make you incredibly itchy. You get little sleep, but you find your way by morning. [Health goes down.]
        prompt.Text = "You can't see where you are going in the dark. You stumble into a patch of plants that make you incredibly itchy. You get little sleep, but you find your way by morning. [Health goes down.]";
        ///PROMPT_IGNORE_VO KEEP_MOVING 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE KEEP_MOVING 0
        response = node.AddResponse();
        ///RESPONSE_TEXT KEEP_MOVING 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE KEEP_MOVING 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID KEEP_MOVING 0 END
        response.NextNodeId = "END";
        response.OnSelect(KEEP_MOVING_r0_select);
        
        ///NODE_END KEEP_MOVING
        ///NODE_START KEEP_MOVING_H
        node = dialog.CreateNode("KEEP_MOVING_H");
        ///NODE_NPC KEEP_MOVING_H WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES KEEP_MOVING_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE KEEP_MOVING_H Full
        ///NODE_VISUAL_USESCRIPT KEEP_MOVING_H false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~KEEP_MOVING_H~|||~
        ///PROMPT KEEP_MOVING_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT KEEP_MOVING_H 0 In a clearing in the woods Henry spots the North Star, which helps you get your bearings. By morning you are heading north again, but you are exhausted. [Health goes down.]
        prompt.Text = "In a clearing in the woods Henry spots the North Star, which helps you get your bearings. By morning you are heading north again, but you are exhausted. [Health goes down.]";
        ///PROMPT_IGNORE_VO KEEP_MOVING_H 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE KEEP_MOVING_H 0
        response = node.AddResponse();
        ///RESPONSE_TEXT KEEP_MOVING_H 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE KEEP_MOVING_H 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID KEEP_MOVING_H 0 END
        response.NextNodeId = "END";
        response.OnSelect(KEEP_MOVING_H_r0_select);
        
        ///NODE_END KEEP_MOVING_H
        ///NODE_START SLAVE_01
        node = dialog.CreateNode("SLAVE_01");
        ///NODE_NPC SLAVE_01 WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES SLAVE_01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SLAVE_01 Full
        ///NODE_VISUAL_USESCRIPT SLAVE_01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SLAVE_01~|||~
        ///PROMPT SLAVE_01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SLAVE_01 0 Suddenly you hear angry shouts and people crashing through the undergrowth.
        prompt.Text = "Suddenly you hear angry shouts and people crashing through the undergrowth.";
        ///PROMPT_IGNORE_VO SLAVE_01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(SLAVE_01_p0_show);
        
        ///RESPONSE SLAVE_01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SLAVE_01 0 Wait and see.
        response.Text = "Wait and see.";
        ///RESPONSE_NEXT_NODE_TYPE SLAVE_01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SLAVE_01 0 SLAVE_01A
        response.NextNodeId = "SLAVE_01A";
        
        ///RESPONSE SLAVE_01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT SLAVE_01 1 Hide.
        response.Text = "Hide.";
        ///RESPONSE_NEXT_NODE_TYPE SLAVE_01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SLAVE_01 1 HIDE
        response.NextNodeId = "HIDE";
        
        ///NODE_END SLAVE_01
        ///NODE_START SLAVE_01A
        node = dialog.CreateNode("SLAVE_01A");
        ///NODE_NPC SLAVE_01A WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES SLAVE_01A False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SLAVE_01A Full
        ///NODE_VISUAL_USESCRIPT SLAVE_01A false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SLAVE_01A~|||~
        ///PROMPT SLAVE_01A 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SLAVE_01A 0 You see an escaped slave running away from an armed patrol. Unfortunately they capture you both and take you to the sheriff.
        prompt.Text = "You see an escaped slave running away from an armed patrol. Unfortunately they capture you both and take you to the sheriff.";
        ///PROMPT_IGNORE_VO SLAVE_01A 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SLAVE_01A 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SLAVE_01A 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE SLAVE_01A 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SLAVE_01A 0 END
        response.NextNodeId = "END";
        response.OnSelect(SLAVE_01A_r0_select);
        
        ///NODE_END SLAVE_01A
        ///NODE_START HIDE
        node = dialog.CreateNode("HIDE");
        ///NODE_NPC HIDE WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES HIDE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HIDE Full
        ///NODE_VISUAL_USESCRIPT HIDE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HIDE~|||~
        ///PROMPT HIDE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HIDE 0 You hide in thick brush. Soon you see another escaped slave run past. In the the distance you see a patrol chasing him.
        prompt.Text = "You hide in thick brush. Soon you see another escaped slave run past. In the the distance you see a patrol chasing him.";
        ///PROMPT_IGNORE_VO HIDE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HIDE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HIDE 0 Call him over.
        response.Text = "Call him over.";
        ///RESPONSE_NEXT_NODE_TYPE HIDE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HIDE 0 CALL
        response.NextNodeId = "CALL";
        
        ///RESPONSE HIDE 1
        response = node.AddResponse();
        ///RESPONSE_TEXT HIDE 1 Watch him go.
        response.Text = "Watch him go.";
        ///RESPONSE_NEXT_NODE_TYPE HIDE 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HIDE 1 WATCH
        response.NextNodeId = "WATCH";
        
        ///NODE_END HIDE
        ///NODE_START WATCH
        node = dialog.CreateNode("WATCH");
        ///NODE_NPC WATCH WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES WATCH False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE WATCH Full
        ///NODE_VISUAL_USESCRIPT WATCH false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~WATCH~|||~
        ///PROMPT WATCH 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT WATCH 0 Your heart is beating fast as you watch him disappear into the distance. You hope the patrol won't find you in your spot. In a few moments the patrolmen dash by. They don't find you.
        prompt.Text = "Your heart is beating fast as you watch him disappear into the distance. You hope the patrol won't find you in your spot. In a few moments the patrolmen dash by. They don't find you.";
        ///PROMPT_IGNORE_VO WATCH 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE WATCH 0
        response = node.AddResponse();
        ///RESPONSE_TEXT WATCH 0 Wait awhile then move on.
        response.Text = "Wait awhile then move on.";
        ///RESPONSE_NEXT_NODE_TYPE WATCH 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WATCH 0 END
        response.NextNodeId = "END";
        
        ///NODE_END WATCH
        ///NODE_START CALL
        node = dialog.CreateNode("CALL");
        ///NODE_NPC CALL WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES CALL False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CALL Full
        ///NODE_VISUAL_USESCRIPT CALL false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CALL~|||~
        ///PROMPT CALL 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CALL 0 You quietly call out to the slave. He pauses. You motion for him to hide with you, but he glances behind him and runs off. In a few moments, patrolmen dash by. Luckily, they don't spot you.
        prompt.Text = "You quietly call out to the slave. He pauses. You motion for him to hide with you, but he glances behind him and runs off. In a few moments, patrolmen dash by. Luckily, they don't spot you.";
        ///PROMPT_IGNORE_VO CALL 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE CALL 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CALL 0 Wait awhile then move on.
        response.Text = "Wait awhile then move on.";
        ///RESPONSE_NEXT_NODE_TYPE CALL 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CALL 0 END
        response.NextNodeId = "END";
        
        ///NODE_END CALL
        ///NODE_START DOGS_01
        node = dialog.CreateNode("DOGS_01");
        ///NODE_NPC DOGS_01 WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES DOGS_01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE DOGS_01 Full
        ///NODE_VISUAL_USESCRIPT DOGS_01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~DOGS_01~|||~
        ///PROMPT DOGS_01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT DOGS_01 0 Faintly at first, then growing louder, you hear dogs in the distance. It could be a patrol.
        prompt.Text = "Faintly at first, then growing louder, you hear dogs in the distance. It could be a patrol.";
        ///PROMPT_IGNORE_VO DOGS_01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(DOGS_01_p0_show);
        
        ///RESPONSE DOGS_01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT DOGS_01 0 Ignore the sound.
        response.Text = "Ignore the sound.";
        ///RESPONSE_NEXT_NODE_TYPE DOGS_01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID DOGS_01 0 END
        response.NextNodeId = "END";
        response.OnSelect(DOGS_01_r0_select);
        
        ///RESPONSE DOGS_01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT DOGS_01 1 Run!
        response.Text = "Run!";
        ///RESPONSE_NEXT_NODE_TYPE DOGS_01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID DOGS_01 1 RUNDOGS
        response.NextNodeId = "RUNDOGS";
        
        ///NODE_END DOGS_01
        ///NODE_START NODOGS
        node = dialog.CreateNode("NODOGS");
        ///NODE_NPC NODOGS WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES NODOGS False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NODOGS Full
        ///NODE_VISUAL_USESCRIPT NODOGS false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NODOGS~|||~
        ///PROMPT NODOGS 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NODOGS 0 You keep walking. In a few moments the sound of the dogs fades.
        prompt.Text = "You keep walking. In a few moments the sound of the dogs fades.";
        ///PROMPT_IGNORE_VO NODOGS 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NODOGS 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NODOGS 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE NODOGS 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NODOGS 0 END
        response.NextNodeId = "END";
        
        ///NODE_END NODOGS
        ///NODE_START RUNDOGS
        node = dialog.CreateNode("RUNDOGS");
        ///NODE_NPC RUNDOGS WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES RUNDOGS False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE RUNDOGS Full
        ///NODE_VISUAL_USESCRIPT RUNDOGS false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~RUNDOGS~|||~
        ///PROMPT RUNDOGS 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT RUNDOGS 0 By now you've been reported missing. Slave catchers could be after you. You run hard until you can't run any more. [Health goes down.]
        prompt.Text = "By now you've been reported missing. Slave catchers could be after you. You run hard until you can't run any more. [Health goes down.]";
        ///PROMPT_IGNORE_VO RUNDOGS 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE RUNDOGS 0
        response = node.AddResponse();
        ///RESPONSE_TEXT RUNDOGS 0 Rest then move on.
        response.Text = "Rest then move on.";
        ///RESPONSE_NEXT_NODE_TYPE RUNDOGS 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID RUNDOGS 0 END
        response.NextNodeId = "END";
        response.OnSelect(RUNDOGS_r0_select);
        
        ///NODE_END RUNDOGS
        ///NODE_START PATROL_01
        node = dialog.CreateNode("PATROL_01");
        ///NODE_NPC PATROL_01 WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES PATROL_01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE PATROL_01 Full
        ///NODE_VISUAL_USESCRIPT PATROL_01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~PATROL_01~|||~
        ///PROMPT PATROL_01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT PATROL_01 0 You are spotted by a group of men patrolling the woods.
        prompt.Text = "You are spotted by a group of men patrolling the woods.";
        ///PROMPT_IGNORE_VO PATROL_01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE PATROL_01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT PATROL_01 0 Show the men your pass.
        response.Text = "Show the men your pass.";
        ///RESPONSE_NEXT_NODE_TYPE PATROL_01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID PATROL_01 0 PATROLPASS
        response.NextNodeId = "PATROLPASS";
        response.SetCondition(PATROL_01_r0_condition);
        
        ///RESPONSE PATROL_01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT PATROL_01 1 Make up a story.
        response.Text = "Make up a story.";
        ///RESPONSE_NEXT_NODE_TYPE PATROL_01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID PATROL_01 1 PATROLBLUFF
        response.NextNodeId = "PATROLBLUFF";
        
        ///RESPONSE PATROL_01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT PATROL_01 2 Run!
        response.Text = "Run!";
        ///RESPONSE_NEXT_NODE_TYPE PATROL_01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID PATROL_01 2 PATROLRUN
        response.NextNodeId = "PATROLRUN";
        response.OnSelect(PATROL_01_r2_select);
        
        ///NODE_END PATROL_01
        ///NODE_START PATROLPASS
        node = dialog.CreateNode("PATROLPASS");
        ///NODE_NPC PATROLPASS WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES PATROLPASS False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE PATROLPASS Full
        ///NODE_VISUAL_USESCRIPT PATROLPASS false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~PATROLPASS~|||~
        ///PROMPT PATROLPASS 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT PATROLPASS 0 You show the men your pass. This deep in the woods the patrol captain doesn't believe it for a moment. The men haul you off to the local sheriff.
        prompt.Text = "You show the men your pass. This deep in the woods the patrol captain doesn't believe it for a moment. The men haul you off to the local sheriff.";
        ///PROMPT_IGNORE_VO PATROLPASS 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE PATROLPASS 0
        response = node.AddResponse();
        ///RESPONSE_TEXT PATROLPASS 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE PATROLPASS 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID PATROLPASS 0 END
        response.NextNodeId = "END";
        response.OnSelect(PATROLPASS_r0_select);
        
        ///NODE_END PATROLPASS
        ///NODE_START PATROLBLUFF
        node = dialog.CreateNode("PATROLBLUFF");
        ///NODE_NPC PATROLBLUFF WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES PATROLBLUFF False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE PATROLBLUFF Full
        ///NODE_VISUAL_USESCRIPT PATROLBLUFF false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~PATROLBLUFF~|||~
        ///PROMPT PATROLBLUFF 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT PATROLBLUFF 0 Out here in the woods the men don't believe a word you say. The men haul you off to the local sheriff.
        prompt.Text = "Out here in the woods the men don't believe a word you say. The men haul you off to the local sheriff.";
        ///PROMPT_IGNORE_VO PATROLBLUFF 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE PATROLBLUFF 0
        response = node.AddResponse();
        ///RESPONSE_TEXT PATROLBLUFF 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE PATROLBLUFF 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID PATROLBLUFF 0 END
        response.NextNodeId = "END";
        response.OnSelect(PATROLBLUFF_r0_select);
        
        ///NODE_END PATROLBLUFF
        ///NODE_START HENRYCAUGHT
        node = dialog.CreateNode("HENRYCAUGHT");
        ///NODE_NPC HENRYCAUGHT WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES HENRYCAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HENRYCAUGHT Full
        ///NODE_VISUAL_USESCRIPT HENRYCAUGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HENRYCAUGHT~|||~
        ///PROMPT HENRYCAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HENRYCAUGHT 0 You and Henry run for all you're worth. Unfortunately Henry stumbles on a log and twists his leg. He can't keep up. \"Go Lucy,\" he says, \"I ain't beat. You keep running. I'll get by.\"
        prompt.Text = "You and Henry run for all you're worth. Unfortunately Henry stumbles on a log and twists his leg. He can't keep up. \"Go Lucy,\" he says, \"I ain't beat. You keep running. I'll get by.\"";
        ///PROMPT_IGNORE_VO HENRYCAUGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HENRYCAUGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HENRYCAUGHT 0 \"Goodbye, Henry. You'll be in my thoughts always.\"
        response.Text = "\"Goodbye, Henry. You'll be in my thoughts always.\"";
        ///RESPONSE_NEXT_NODE_TYPE HENRYCAUGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HENRYCAUGHT 0 END
        response.NextNodeId = "END";
        response.OnSelect(HENRYCAUGHT_r0_select);
        
        ///RESPONSE HENRYCAUGHT 1
        response = node.AddResponse();
        ///RESPONSE_TEXT HENRYCAUGHT 1 \"I'll pray for you Henry. Goodbye.\"
        response.Text = "\"I'll pray for you Henry. Goodbye.\"";
        ///RESPONSE_NEXT_NODE_TYPE HENRYCAUGHT 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HENRYCAUGHT 1 END
        response.NextNodeId = "END";
        response.OnSelect(HENRYCAUGHT_r1_select);
        
        ///NODE_END HENRYCAUGHT
        ///NODE_START RUNESCAPE
        node = dialog.CreateNode("RUNESCAPE");
        ///NODE_NPC RUNESCAPE WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES RUNESCAPE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE RUNESCAPE Full
        ///NODE_VISUAL_USESCRIPT RUNESCAPE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~RUNESCAPE~|||~
        ///PROMPT RUNESCAPE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT RUNESCAPE 0 You dash away as fast as you can go. Amazingly you are able to get away from the patrol, but you are left gasping and exhausted. [Health goes down.]
        prompt.Text = "You dash away as fast as you can go. Amazingly you are able to get away from the patrol, but you are left gasping and exhausted. [Health goes down.]";
        ///PROMPT_IGNORE_VO RUNESCAPE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE RUNESCAPE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT RUNESCAPE 0 Catch your breath and move on.
        response.Text = "Catch your breath and move on.";
        ///RESPONSE_NEXT_NODE_TYPE RUNESCAPE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID RUNESCAPE 0 END
        response.NextNodeId = "END";
        response.OnSelect(RUNESCAPE_r0_select);
        
        ///NODE_END RUNESCAPE
        ///NODE_START RUNCAUGHT
        node = dialog.CreateNode("RUNCAUGHT");
        ///NODE_NPC RUNCAUGHT WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES RUNCAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE RUNCAUGHT Full
        ///NODE_VISUAL_USESCRIPT RUNCAUGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~RUNCAUGHT~|||~
        ///PROMPT RUNCAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT RUNCAUGHT 0 The men were ready for you. You don't get far. They catch you and take you to the local sheriff.
        prompt.Text = "The men were ready for you. You don't get far. They catch you and take you to the local sheriff.";
        ///PROMPT_IGNORE_VO RUNCAUGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE RUNCAUGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT RUNCAUGHT 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE RUNCAUGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID RUNCAUGHT 0 END
        response.NextNodeId = "END";
        response.OnSelect(RUNCAUGHT_r0_select);
        
        ///NODE_END RUNCAUGHT
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD SLAVE_01_p0_show
    public void SLAVE_01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START SLAVE_01_p0_show
        /*// play_sfx("audio/sfx/running_underbrush.mp3") */
        ///METHOD_BODY_END SLAVE_01_p0_show
    }

    ///METHOD DOGS_01_p0_show
    public void DOGS_01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START DOGS_01_p0_show
        /*// play_sfx("audio/sfx/mus_sfx_dogs_baying.mp3") */
        ///METHOD_BODY_END DOGS_01_p0_show
    }

    ///METHOD LOST_01_r0_condition
    public bool LOST_01_r0_condition (  ) {
        ///METHOD_BODY_START LOST_01_r0_condition
        /*// if($escape_type = "alone")*/
        return true;
        ///METHOD_BODY_END LOST_01_r0_condition
    }

    ///METHOD LOST_01_r1_condition
    public bool LOST_01_r1_condition (  ) {
        ///METHOD_BODY_START LOST_01_r1_condition
        /*// if($escape_type = "henry" AND  ?HENRY_ALIVE = true) */
        return true;
        ///METHOD_BODY_END LOST_01_r1_condition
    }

    ///METHOD PATROL_01_r0_condition
    public bool PATROL_01_r0_condition (  ) {
        ///METHOD_BODY_START PATROL_01_r0_condition
        /*// if( hasItem("PRESTON_PASS") OR hasItem("FORGED_PASS") ) */
        return true;
        ///METHOD_BODY_END PATROL_01_r0_condition
    }

    ///METHOD SPEND_NIGHT_r0_select
    public void SPEND_NIGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START SPEND_NIGHT_r0_select
        /*//			doDays()
        //			doFood()			*/
        ///METHOD_BODY_END SPEND_NIGHT_r0_select
    }

    ///METHOD KEEP_MOVING_r0_select
    public void KEEP_MOVING_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START KEEP_MOVING_r0_select
        /*//#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			doDays()
        //			post("reportHealth", "")*/
        ///METHOD_BODY_END KEEP_MOVING_r0_select
    }

    ///METHOD KEEP_MOVING_H_r0_select
    public void KEEP_MOVING_H_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START KEEP_MOVING_H_r0_select
        /*//			#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			#HENRY_HEALTH = #HENRY_HEALTH - 1
        //			doDays()
        //			doFood()
        //			post("reportHealth", "")*/
        ///METHOD_BODY_END KEEP_MOVING_H_r0_select
    }

    ///METHOD SLAVE_01A_r0_select
    public void SLAVE_01A_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START SLAVE_01A_r0_select
        /*// endState("escape_end", "") */
        ///METHOD_BODY_END SLAVE_01A_r0_select
    }

    ///METHOD DOGS_01_r0_select
    public void DOGS_01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START DOGS_01_r0_select
        /*//			if( #days_passed > 2 )
        //				#rand = random(100)
        //				#rand = #rand + (#escape_attempt * 10)
        //				if( #rand > 50 )
        //					$next_node = "NODOGS"
        //				else
        //					$next_node = "PATROL_01"
        //				/if
        //			else
        //				$next_node = "NODOGS"
        //			/if*/
        ///METHOD_BODY_END DOGS_01_r0_select
    }

    ///METHOD RUNDOGS_r0_select
    public void RUNDOGS_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUNDOGS_r0_select
        /*//			#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			#HENRY_HEALTH = #HENRY_HEALTH - 1
        //			post("reportHealth", "")*/
        ///METHOD_BODY_END RUNDOGS_r0_select
    }

    ///METHOD PATROL_01_r2_select
    public void PATROL_01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START PATROL_01_r2_select
        /*//			if($escape_type = "henry")
        //				$next_node = "HENRYCAUGHT"
        //			else
        //				#rand = random(100)
        //				#rand = #rand + (#escape_attempt * 10)
        //				if( #rand > 50 )
        //					$next_node = "RUNESCAPE"
        //				else
        //					$next_node = "RUNCAUGHT"
        //				/if
        //			/if*/
        ///METHOD_BODY_END PATROL_01_r2_select
    }

    ///METHOD PATROLPASS_r0_select
    public void PATROLPASS_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START PATROLPASS_r0_select
        /*// endState("escape_end", "") */
        ///METHOD_BODY_END PATROLPASS_r0_select
    }

    ///METHOD PATROLBLUFF_r0_select
    public void PATROLBLUFF_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START PATROLBLUFF_r0_select
        /*// endState("escape_end", "") */
        ///METHOD_BODY_END PATROLBLUFF_r0_select
    }

    ///METHOD HENRYCAUGHT_r0_select
    public void HENRYCAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START HENRYCAUGHT_r0_select
        /*//			#p2_henry_code = 20
        //			killHenry()*/
        ///METHOD_BODY_END HENRYCAUGHT_r0_select
    }

    ///METHOD HENRYCAUGHT_r1_select
    public void HENRYCAUGHT_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START HENRYCAUGHT_r1_select
        /*//			#p2_henry_code = 20
        //			killHenry()*/
        ///METHOD_BODY_END HENRYCAUGHT_r1_select
    }

    ///METHOD RUNESCAPE_r0_select
    public void RUNESCAPE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUNESCAPE_r0_select
        /*//			#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			post("reportHealth", "")*/
        ///METHOD_BODY_END RUNESCAPE_r0_select
    }

    ///METHOD RUNCAUGHT_r0_select
    public void RUNCAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUNCAUGHT_r0_select
        /*// endState("escape_end", "") */
        ///METHOD_BODY_END RUNCAUGHT_r0_select
    }
}
//CLASS_END Dialog_p2_won_001
