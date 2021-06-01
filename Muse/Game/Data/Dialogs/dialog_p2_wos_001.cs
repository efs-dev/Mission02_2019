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
//CLASS Dialog_p2_wos_001
public class Dialog_p2_wos_001 {
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
        ///DIALOG_ID p2_wos_001
        var dialog = new Dialog();
        dialog.Id = "p2_wos_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START LOST_01
        node = dialog.CreateNode("LOST_01");
        ///NODE_NPC LOST_01 WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES LOST_01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE LOST_01 Full
        ///NODE_VISUAL_USESCRIPT LOST_01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~LOST_01~|||~
        ///PROMPT LOST_01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT LOST_01 0 After wandering around in the woods for hours, you realize you are lost and it's getting dark.
        prompt.Text = "After wandering around in the woods for hours, you realize you are lost and it's getting dark.";
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
        ///NODE_NPC SPEND_NIGHT WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES SPEND_NIGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SPEND_NIGHT Full
        ///NODE_VISUAL_USESCRIPT SPEND_NIGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SPEND_NIGHT~|||~
        ///PROMPT SPEND_NIGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SPEND_NIGHT 0 It's too dangerous to go through the woods at night. You spend the night near the roots of a large tree. In the morning the sun helps you figure out which direction to head. [Extra time passes and food goes down.]
        prompt.Text = "It's too dangerous to go through the woods at night. You spend the night near the roots of a large tree. In the morning the sun helps you figure out which direction to head. [Extra time passes and food goes down.]";
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
        ///NODE_NPC KEEP_MOVING WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES KEEP_MOVING False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE KEEP_MOVING Full
        ///NODE_VISUAL_USESCRIPT KEEP_MOVING false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~KEEP_MOVING~|||~
        ///PROMPT KEEP_MOVING 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT KEEP_MOVING 0 You're not familiar with traveling these woods after dark. You stumble into a stream, get soaked, and lose some food. You get little sleep, but you find your way by morning. [Health and food go down]
        prompt.Text = "You're not familiar with traveling these woods after dark. You stumble into a stream, get soaked, and lose some food. You get little sleep, but you find your way by morning. [Health and food go down]";
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
        ///NODE_NPC KEEP_MOVING_H WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES KEEP_MOVING_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE KEEP_MOVING_H Full
        ///NODE_VISUAL_USESCRIPT KEEP_MOVING_H false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~KEEP_MOVING_H~|||~
        ///PROMPT KEEP_MOVING_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT KEEP_MOVING_H 0 Henry finds the North Star in the night sky. It helps you get your bearings. By morning you are heading north again, but you are exhausted. [Health goes down.]
        prompt.Text = "Henry finds the North Star in the night sky. It helps you get your bearings. By morning you are heading north again, but you are exhausted. [Health goes down.]";
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
        ///NODE_START DOGS_01
        node = dialog.CreateNode("DOGS_01");
        ///NODE_NPC DOGS_01 WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES DOGS_01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE DOGS_01 Full
        ///NODE_VISUAL_USESCRIPT DOGS_01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~DOGS_01~|||~
        ///PROMPT DOGS_01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT DOGS_01 0 As you move along you suddenly hear dogs in the distance. It could be a patrol.
        prompt.Text = "As you move along you suddenly hear dogs in the distance. It could be a patrol.";
        ///PROMPT_IGNORE_VO DOGS_01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(DOGS_01_p0_show);
        
        ///RESPONSE DOGS_01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT DOGS_01 0 Ignore the sound.
        response.Text = "Ignore the sound.";
        ///RESPONSE_NEXT_NODE_TYPE DOGS_01 0 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID DOGS_01 0 
        response.NextNodeId = "";
        response.OnSelect(DOGS_01_r0_select);
        response.OnSelectNextNodeId(DOGS_01_r0_nextnodeid);
        
        ///RESPONSE DOGS_01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT DOGS_01 1 Run for it!
        response.Text = "Run for it!";
        ///RESPONSE_NEXT_NODE_TYPE DOGS_01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID DOGS_01 1 RUNDOGS
        response.NextNodeId = "RUNDOGS";
        
        ///NODE_END DOGS_01
        ///NODE_START NODOGS
        node = dialog.CreateNode("NODOGS");
        ///NODE_NPC NODOGS WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES NODOGS False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NODOGS Full
        ///NODE_VISUAL_USESCRIPT NODOGS false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NODOGS~|||~
        ///PROMPT NODOGS 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NODOGS 0 You keep traveling at your same pace. In a few moments the sound of the dogs dies away.
        prompt.Text = "You keep traveling at your same pace. In a few moments the sound of the dogs dies away.";
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
        ///NODE_NPC RUNDOGS WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES RUNDOGS False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE RUNDOGS Full
        ///NODE_VISUAL_USESCRIPT RUNDOGS false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~RUNDOGS~|||~
        ///PROMPT RUNDOGS 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT RUNDOGS 0 Best not to take any chances. You run as hard as you can until you can't run any more. [Health goes down.]
        prompt.Text = "Best not to take any chances. You run as hard as you can until you can't run any more. [Health goes down.]";
        ///PROMPT_IGNORE_VO RUNDOGS 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE RUNDOGS 0
        response = node.AddResponse();
        ///RESPONSE_TEXT RUNDOGS 0 Catch your breath and move on.
        response.Text = "Catch your breath and move on.";
        ///RESPONSE_NEXT_NODE_TYPE RUNDOGS 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID RUNDOGS 0 END
        response.NextNodeId = "END";
        response.OnSelect(RUNDOGS_r0_select);
        
        ///NODE_END RUNDOGS
        ///NODE_START SIGNS_01
        node = dialog.CreateNode("SIGNS_01");
        ///NODE_NPC SIGNS_01 WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES SIGNS_01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SIGNS_01 Full
        ///NODE_VISUAL_USESCRIPT SIGNS_01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SIGNS_01~|||~
        ///PROMPT SIGNS_01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SIGNS_01 0 You come across the remains of a recent campfire. The people might still be close by.
        prompt.Text = "You come across the remains of a recent campfire. The people might still be close by.";
        ///PROMPT_IGNORE_VO SIGNS_01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SIGNS_01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SIGNS_01 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE SIGNS_01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SIGNS_01 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE SIGNS_01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT SIGNS_01 1 Run for it!
        response.Text = "Run for it!";
        ///RESPONSE_NEXT_NODE_TYPE SIGNS_01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SIGNS_01 1 RUNFIRE
        response.NextNodeId = "RUNFIRE";
        
        ///NODE_END SIGNS_01
        ///NODE_START RUNFIRE
        node = dialog.CreateNode("RUNFIRE");
        ///NODE_NPC RUNFIRE WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES RUNFIRE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE RUNFIRE Full
        ///NODE_VISUAL_USESCRIPT RUNFIRE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~RUNFIRE~|||~
        ///PROMPT RUNFIRE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT RUNFIRE 0 You don't wait to find out who might be nearby. You dash away through the woods. It's exhausting. [Health goes down.]
        prompt.Text = "You don't wait to find out who might be nearby. You dash away through the woods. It's exhausting. [Health goes down.]";
        ///PROMPT_IGNORE_VO RUNFIRE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE RUNFIRE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT RUNFIRE 0 When you're rested, move on.
        response.Text = "When you're rested, move on.";
        ///RESPONSE_NEXT_NODE_TYPE RUNFIRE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID RUNFIRE 0 END
        response.NextNodeId = "END";
        response.OnSelect(RUNFIRE_r0_select);
        
        ///NODE_END RUNFIRE
        ///NODE_START FOOD_01
        node = dialog.CreateNode("FOOD_01");
        ///NODE_NPC FOOD_01 WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES FOOD_01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FOOD_01 Full
        ///NODE_VISUAL_USESCRIPT FOOD_01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FOOD_01~|||~
        ///PROMPT FOOD_01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FOOD_01 0 As you make your way through the trees you see that you've surprised a wild rabbit.
        prompt.Text = "As you make your way through the trees you see that you've surprised a wild rabbit.";
        ///PROMPT_IGNORE_VO FOOD_01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FOOD_01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FOOD_01 0 Leave it alone.
        response.Text = "Leave it alone.";
        ///RESPONSE_NEXT_NODE_TYPE FOOD_01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FOOD_01 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE FOOD_01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT FOOD_01 1 Try to catch it!
        response.Text = "Try to catch it!";
        ///RESPONSE_NEXT_NODE_TYPE FOOD_01 1 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID FOOD_01 1 
        response.NextNodeId = "";
        response.OnSelect(FOOD_01_r1_select);
        response.OnSelectNextNodeId(FOOD_01_r1_nextnodeid);
        
        ///NODE_END FOOD_01
        ///NODE_START CAUGHT1
        node = dialog.CreateNode("CAUGHT1");
        ///NODE_NPC CAUGHT1 WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES CAUGHT1 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CAUGHT1 Full
        ///NODE_VISUAL_USESCRIPT CAUGHT1 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CAUGHT1~|||~
        ///PROMPT CAUGHT1 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CAUGHT1 0 You chase the rabbit around and just barely manage to catch it. But now you need a fire to cook it.
        prompt.Text = "You chase the rabbit around and just barely manage to catch it. But now you need a fire to cook it.";
        ///PROMPT_IGNORE_VO CAUGHT1 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT CAUGHT1 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CAUGHT1 1 With Henry's help you catch the rabbit without too much trouble. But now you need a fire to cook it.
        prompt.Text = "With Henry's help you catch the rabbit without too much trouble. But now you need a fire to cook it.";
        ///PROMPT_IGNORE_VO CAUGHT1 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(CAUGHT1_p1_condition);
        
        ///RESPONSE CAUGHT1 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CAUGHT1 0 Don't risk it.
        response.Text = "Don't risk it.";
        ///RESPONSE_NEXT_NODE_TYPE CAUGHT1 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CAUGHT1 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE CAUGHT1 1
        response = node.AddResponse();
        ///RESPONSE_TEXT CAUGHT1 1 Build a fire.
        response.Text = "Build a fire.";
        ///RESPONSE_NEXT_NODE_TYPE CAUGHT1 1 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID CAUGHT1 1 
        response.NextNodeId = "";
        response.OnSelect(CAUGHT1_r1_select);
        response.OnSelectNextNodeId(CAUGHT1_r1_nextnodeid);
        
        ///NODE_END CAUGHT1
        ///NODE_START FULL
        node = dialog.CreateNode("FULL");
        ///NODE_NPC FULL WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES FULL False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FULL Full
        ///NODE_VISUAL_USESCRIPT FULL false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FULL~|||~
        ///PROMPT FULL 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FULL 0 The rabbit is very filling and you also get a little rest while you eat. [Health goes up.]
        prompt.Text = "The rabbit is very filling and you also get a little rest while you eat. [Health goes up.]";
        ///PROMPT_IGNORE_VO FULL 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FULL 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FULL 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE FULL 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FULL 0 END
        response.NextNodeId = "END";
        response.OnSelect(FULL_r0_select);
        
        ///NODE_END FULL
        ///NODE_START NOTCAUGHT1
        node = dialog.CreateNode("NOTCAUGHT1");
        ///NODE_NPC NOTCAUGHT1 WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES NOTCAUGHT1 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NOTCAUGHT1 Full
        ///NODE_VISUAL_USESCRIPT NOTCAUGHT1 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NOTCAUGHT1~|||~
        ///PROMPT NOTCAUGHT1 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NOTCAUGHT1 0 You chase the rabbit around and around. Unfortunately it gets away and now you are exhausted. [Health goes down.]
        prompt.Text = "You chase the rabbit around and around. Unfortunately it gets away and now you are exhausted. [Health goes down.]";
        ///PROMPT_IGNORE_VO NOTCAUGHT1 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NOTCAUGHT1 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NOTCAUGHT1 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE NOTCAUGHT1 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NOTCAUGHT1 0 END
        response.NextNodeId = "END";
        response.OnSelect(NOTCAUGHT1_r0_select);
        
        ///NODE_END NOTCAUGHT1
        ///NODE_START PATROL_01
        node = dialog.CreateNode("PATROL_01");
        ///NODE_NPC PATROL_01 WOS
        node.Npc = "WOS";
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
        ///RESPONSE_TEXT PATROL_01 2 Run for it!
        response.Text = "Run for it!";
        ///RESPONSE_NEXT_NODE_TYPE PATROL_01 2 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID PATROL_01 2 
        response.NextNodeId = "";
        response.OnSelect(PATROL_01_r2_select);
        response.OnSelectNextNodeId(PATROL_01_r2_nextnodeid);
        
        ///NODE_END PATROL_01
        ///NODE_START PATROLPASS
        node = dialog.CreateNode("PATROLPASS");
        ///NODE_NPC PATROLPASS WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES PATROLPASS False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE PATROLPASS Full
        ///NODE_VISUAL_USESCRIPT PATROLPASS false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~PATROLPASS~|||~
        ///PROMPT PATROLPASS 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT PATROLPASS 0 You show the men your pass. The patrol captain rips it up and chuckles. He doesn't believe it for a moment. The men haul you off to the local sheriff.
        prompt.Text = "You show the men your pass. The patrol captain rips it up and chuckles. He doesn't believe it for a moment. The men haul you off to the local sheriff.";
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
        ///NODE_NPC PATROLBLUFF WOS
        node.Npc = "WOS";
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
        ///NODE_NPC HENRYCAUGHT WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES HENRYCAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HENRYCAUGHT Full
        ///NODE_VISUAL_USESCRIPT HENRYCAUGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HENRYCAUGHT~|||~
        ///PROMPT HENRYCAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HENRYCAUGHT 0 You and Henry run like the wind. Unfortunately Henry slips on a moss covered rock and twists his ankle. He can't keep up. \"Lucy,\" he says, \"You gotta keep running. I'll get by. Now go!\"
        prompt.Text = "You and Henry run like the wind. Unfortunately Henry slips on a moss covered rock and twists his ankle. He can't keep up. \"Lucy,\" he says, \"You gotta keep running. I'll get by. Now go!\"";
        ///PROMPT_IGNORE_VO HENRYCAUGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HENRYCAUGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HENRYCAUGHT 0 \"Goodbye, Henry. I won't forget you!\"
        response.Text = "\"Goodbye, Henry. I won't forget you!\"";
        ///RESPONSE_NEXT_NODE_TYPE HENRYCAUGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HENRYCAUGHT 0 END
        response.NextNodeId = "END";
        response.OnSelect(HENRYCAUGHT_r0_select);
        
        ///RESPONSE HENRYCAUGHT 1
        response = node.AddResponse();
        ///RESPONSE_TEXT HENRYCAUGHT 1 \"I'm so sorry Henry. Goodbye.\"
        response.Text = "\"I'm so sorry Henry. Goodbye.\"";
        ///RESPONSE_NEXT_NODE_TYPE HENRYCAUGHT 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HENRYCAUGHT 1 END
        response.NextNodeId = "END";
        response.OnSelect(HENRYCAUGHT_r1_select);
        
        ///NODE_END HENRYCAUGHT
        ///NODE_START RUNESCAPE
        node = dialog.CreateNode("RUNESCAPE");
        ///NODE_NPC RUNESCAPE WOS
        node.Npc = "WOS";
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
        ///NODE_NPC RUNCAUGHT WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES RUNCAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE RUNCAUGHT Full
        ///NODE_VISUAL_USESCRIPT RUNCAUGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~RUNCAUGHT~|||~
        ///PROMPT RUNCAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT RUNCAUGHT 0 The men expected you to run and were ready. They quickly catch you and take you to the local sheriff.
        prompt.Text = "The men expected you to run and were ready. They quickly catch you and take you to the local sheriff.";
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

    ///METHOD CAUGHT1_p1_condition
    public bool CAUGHT1_p1_condition (  ) {
        ///METHOD_BODY_START CAUGHT1_p1_condition
        /*//if( $escape_type = "henry" )*/
        return GameFlags.P2EscapeType == "henry";
        ///METHOD_BODY_END CAUGHT1_p1_condition
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
        return GameFlags.P2EscapeType == "alone";
        ///METHOD_BODY_END LOST_01_r0_condition
    }

    ///METHOD LOST_01_r1_condition
    public bool LOST_01_r1_condition (  ) {
        ///METHOD_BODY_START LOST_01_r1_condition
        /*// if($escape_type = "henry" AND  ?HENRY_ALIVE = true) */
        return GameFlags.P2EscapeType == "henry";
        ///METHOD_BODY_END LOST_01_r1_condition
    }

    ///METHOD PATROL_01_r0_condition
    public bool PATROL_01_r0_condition (  ) {
        ///METHOD_BODY_START PATROL_01_r0_condition
        /*// if( hasItem("PRESTON_PASS") OR hasItem("FORGED_PASS") ) */
        return GameFlags.P1HasPass || GameFlags.P2HasForgedPass;
        ///METHOD_BODY_END PATROL_01_r0_condition
    }

    ///METHOD SPEND_NIGHT_r0_select
    public void SPEND_NIGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START SPEND_NIGHT_r0_select
        /*//			doDays()
        //			doFood()*/
        GlobalScripts.DoDays();
        GlobalScripts.DoFood();
        ///METHOD_BODY_END SPEND_NIGHT_r0_select
    }

    ///METHOD KEEP_MOVING_r0_select
    public void KEEP_MOVING_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START KEEP_MOVING_r0_select
        /*//			doDays()
        //			// lucy is alone
        //			#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			loseFood( 1 )
        //			//#FOOD = #FOOD - 1
        //			//updateMessage("You lost 1 food")
        //			post("reportHealth", "")*/
        GlobalScripts.DoDays();
        GameFlags.P2LucyHealth--;
        GameFlags.P2LucyFood--;
        ///METHOD_BODY_END KEEP_MOVING_r0_select
    }

    ///METHOD KEEP_MOVING_H_r0_select
    public void KEEP_MOVING_H_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START KEEP_MOVING_H_r0_select
        /*//			doDays()
        //			doFood()
        //			#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			#HENRY_HEALTH = #HENRY_HEALTH - 1
        //			post("reportHealth", "")*/
        GlobalScripts.DoDays();
        GlobalScripts.DoFood();
        GameFlags.P2LucyHealth--;
        GameFlags.P2HenryHealth--;
        ///METHOD_BODY_END KEEP_MOVING_H_r0_select
    }

    ///METHOD DOGS_01_r0_select
    public void DOGS_01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START DOGS_01_r0_select
        /*//			if( #days_passed > 2 )
        //				#rand = random(100)
        //				#rand = #rand + (#escape_attempt * 10)
        //				if( #rand > 60 )
        //					$next_node = "NODOGS"
        //				else
        //					$next_node = "PATROL_01"
        //				/if
        //			else
        //				$next_node = "NODOGS"
        //			/if*/
        if (GameFlags.P2DaysPassed > 2){
        	int rand = UnityEngine.Random.RandomRange(1,100);
        rand += GameFlags.P2EscapeAttempts * 10;
        if (rand < 60){
        DialogGameFlags.next_node = "NODOGS";
        }
        else{
        DialogGameFlags.next_node = "PATROL_01";
        }
        }
        else{
        	DialogGameFlags.next_node = "NODOGS";
        }
        ///METHOD_BODY_END DOGS_01_r0_select
    }

    ///METHOD RUNDOGS_r0_select
    public void RUNDOGS_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUNDOGS_r0_select
        /*//			#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			#HENRY_HEALTH = #HENRY_HEALTH - 1
        //			post("reportHealth", "")*/
        GameFlags.P2LucyHealth--;
        GameFlags.P2HenryHealth--;
        ///METHOD_BODY_END RUNDOGS_r0_select
    }

    ///METHOD RUNFIRE_r0_select
    public void RUNFIRE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUNFIRE_r0_select
        /*//			#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			#HENRY_HEALTH = #HENRY_HEALTH - 1
        //			post("reportHealth", "")	*/
        GameFlags.P2LucyHealth--;
        GameFlags.P2HenryHealth--;
        ///METHOD_BODY_END RUNFIRE_r0_select
    }

    ///METHOD FOOD_01_r1_select
    public void FOOD_01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START FOOD_01_r1_select
        /*//			#rand = random(100)
        //			if($escape_type="henry")
        //			     #rand = #rand + 50
        //			/if
        //			if(#rand < 74)
        //			     $next_node = "CAUGHT1"
        //		    else
        //                 $next_node = "NOTCAUGHT1"
        //            /if*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        if (GameFlags.P2EscapeType == "henry"){
        	rand+= 50;
        }
        if (rand < 74){
        DialogGameFlags.next_node = "CAUGHT1";
        }
        else{
        DialogGameFlags.next_node = "NOTCAUGHT1";
        }
        ///METHOD_BODY_END FOOD_01_r1_select
    }

    ///METHOD CAUGHT1_r1_select
    public void CAUGHT1_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START CAUGHT1_r1_select
        /*//			#rand = random(100)
        //			#rand = #rand + (#escape_attempt * 15)
        //		    if(#rand < 40)
        //				$next_node = "PATROL_01"
        //			else
        //				$next_node = "FULL"
        //			/if		*/
        int rand = UnityEngine.Random.RandomRange(1,100);
        rand += GameFlags.P2EscapeAttempts * 15;
        if (rand < 40){
        DialogGameFlags.next_node = "PATROL_01";
        }
        else{
        DialogGameFlags.next_node = "FULL";
        }
        ///METHOD_BODY_END CAUGHT1_r1_select
    }

    ///METHOD FULL_r0_select
    public void FULL_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FULL_r0_select
        /*//			#food = #food + 2
        //			#lucy_health = #lucy_health + 1
        //			#henry_health = #henry_health + 1
        //			post("reportHealth","")*/
        GameFlags.P2LucyFood+=2;
        GameFlags.P2LucyHealth++;
        GameFlags.P2HenryHealth++;
        ///METHOD_BODY_END FULL_r0_select
    }

    ///METHOD NOTCAUGHT1_r0_select
    public void NOTCAUGHT1_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START NOTCAUGHT1_r0_select
        /*//			#lucy_health = #lucy_health - 1
        //			#henry_health = #henry_health - 1
        //			post("reportHealth","")*/
        GameFlags.P2LucyHealth--;
        GameFlags.P2HenryHealth--;
        ///METHOD_BODY_END NOTCAUGHT1_r0_select
    }

    ///METHOD PATROL_01_r2_select
    public void PATROL_01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START PATROL_01_r2_select
        /*//			if($escape_type = "henry")
        //				$next_node = "HENRYCAUGHT"
        //			else
        //				#rand = random(100)
        //				if( #rand > 50 )
        //					$next_node = "RUNESCAPE"
        //				else
        //					$next_node = "RUNCAUGHT"
        //				/if
        //			/if*/
        if (GameFlags.P2EscapeType == "henry"){
        	DialogGameFlags.next_node = "HENRYCAUGHT";
        }
        else{
        	int rand = UnityEngine.Random.RandomRange(1,100);
        	if (rand > 50){
        		DialogGameFlags.next_node = "RUNESCAPE";
        	}
        	else{
        		DialogGameFlags.next_node = "RUNCAUGHT";
        	}
        }
        ///METHOD_BODY_END PATROL_01_r2_select
    }

    ///METHOD PATROLPASS_r0_select
    public void PATROLPASS_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START PATROLPASS_r0_select
        /*// endState("escape_end", "") */
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END PATROLPASS_r0_select
    }

    ///METHOD PATROLBLUFF_r0_select
    public void PATROLBLUFF_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START PATROLBLUFF_r0_select
        /*// endState("escape_end", "") */
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END PATROLBLUFF_r0_select
    }

    ///METHOD HENRYCAUGHT_r0_select
    public void HENRYCAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START HENRYCAUGHT_r0_select
        /*//			#p2_henry_code = 20
        //			killHenry()		*/
        GameFlags.P2HenryCode = 20;
        GlobalScripts.KillHenry();
        ///METHOD_BODY_END HENRYCAUGHT_r0_select
    }

    ///METHOD HENRYCAUGHT_r1_select
    public void HENRYCAUGHT_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START HENRYCAUGHT_r1_select
        /*//			#p2_henry_code = 20
        //			killHenry()	*/
        GameFlags.P2HenryCode = 20;
        GlobalScripts.KillHenry();
        ///METHOD_BODY_END HENRYCAUGHT_r1_select
    }

    ///METHOD RUNESCAPE_r0_select
    public void RUNESCAPE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUNESCAPE_r0_select
        /*//			#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			post("reportHealth", "")	*/
        GameFlags.P2LucyHealth--;
        ///METHOD_BODY_END RUNESCAPE_r0_select
    }

    ///METHOD RUNCAUGHT_r0_select
    public void RUNCAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUNCAUGHT_r0_select
        /*// endState("escape_end", "") */
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END RUNCAUGHT_r0_select
    }

    ///METHOD DOGS_01_r0_nextnodeid
    public string DOGS_01_r0_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START DOGS_01_r0_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END DOGS_01_r0_nextnodeid
    }

    ///METHOD FOOD_01_r1_nextnodeid
    public string FOOD_01_r1_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START FOOD_01_r1_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END FOOD_01_r1_nextnodeid
    }

    ///METHOD CAUGHT1_r1_nextnodeid
    public string CAUGHT1_r1_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START CAUGHT1_r1_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END CAUGHT1_r1_nextnodeid
    }

    ///METHOD PATROL_01_r2_nextnodeid
    public string PATROL_01_r2_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START PATROL_01_r2_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END PATROL_01_r2_nextnodeid
    }
}
//CLASS_END Dialog_p2_wos_001
