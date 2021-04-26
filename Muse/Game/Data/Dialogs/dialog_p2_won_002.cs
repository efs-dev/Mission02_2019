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
//CLASS Dialog_p2_won_002
public class Dialog_p2_won_002 {
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
        ///DIALOG_ID p2_won_002
        var dialog = new Dialog();
        dialog.Id = "p2_won_002";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START FULLTRAP
        node = dialog.CreateNode("FULLTRAP");
        ///NODE_NPC FULLTRAP WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES FULLTRAP False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FULLTRAP Full
        ///NODE_VISUAL_USESCRIPT FULLTRAP false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FULLTRAP~|||~
        ///PROMPT FULLTRAP 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FULLTRAP 0 You come across a trap with a squirrel caught in it. But now you need a fire to cook it.
        prompt.Text = "You come across a trap with a squirrel caught in it. But now you need a fire to cook it.";
        ///PROMPT_IGNORE_VO FULLTRAP 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE FULLTRAP 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FULLTRAP 0 Don't risk it.
        response.Text = "Don't risk it.";
        ///RESPONSE_NEXT_NODE_TYPE FULLTRAP 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FULLTRAP 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE FULLTRAP 1
        response = node.AddResponse();
        ///RESPONSE_TEXT FULLTRAP 1 Build a fire.
        response.Text = "Build a fire.";
        ///RESPONSE_NEXT_NODE_TYPE FULLTRAP 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FULLTRAP 1 COOK1
        response.NextNodeId = "COOK1";
        response.OnSelect(FULLTRAP_r1_select);
        
        ///NODE_END FULLTRAP
        ///NODE_START EMPTYTRAP
        node = dialog.CreateNode("EMPTYTRAP");
        ///NODE_NPC EMPTYTRAP WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES EMPTYTRAP False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE EMPTYTRAP Full
        ///NODE_VISUAL_USESCRIPT EMPTYTRAP false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~EMPTYTRAP~|||~
        ///PROMPT EMPTYTRAP 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT EMPTYTRAP 0 You come across a squirrel trap, but unfortunately it's empty.
        prompt.Text = "You come across a squirrel trap, but unfortunately it's empty.";
        ///PROMPT_IGNORE_VO EMPTYTRAP 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE EMPTYTRAP 0
        response = node.AddResponse();
        ///RESPONSE_TEXT EMPTYTRAP 0 Go on.
        response.Text = "Go on.";
        ///RESPONSE_NEXT_NODE_TYPE EMPTYTRAP 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID EMPTYTRAP 0 END
        response.NextNodeId = "END";
        
        ///NODE_END EMPTYTRAP
        ///NODE_START FULL
        node = dialog.CreateNode("FULL");
        ///NODE_NPC FULL WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES FULL False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FULL Full
        ///NODE_VISUAL_USESCRIPT FULL false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FULL~|||~
        ///PROMPT FULL 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FULL 0 The squirrel is not much food, but every little bit helps. [Health goes up]
        prompt.Text = "The squirrel is not much food, but every little bit helps. [Health goes up]";
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
        ///NODE_START WARM
        node = dialog.CreateNode("WARM");
        ///NODE_NPC WARM WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES WARM False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE WARM Full
        ///NODE_VISUAL_USESCRIPT WARM false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~WARM~|||~
        ///PROMPT WARM 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT WARM 0 It starts to rain and you stop at a spot in the woods. Luckily your blanket keeps you warm.
        prompt.Text = "It starts to rain and you stop at a spot in the woods. Luckily your blanket keeps you warm.";
        ///PROMPT_IGNORE_VO WARM 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT WARM 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT WARM 1 It starts to rain and you stop at a spot in the woods. Luckily your shawl keeps you warm.
        prompt.Text = "It starts to rain and you stop at a spot in the woods. Luckily your shawl keeps you warm.";
        ///PROMPT_IGNORE_VO WARM 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(WARM_p1_condition);
        
        ///RESPONSE WARM 0
        response = node.AddResponse();
        ///RESPONSE_TEXT WARM 0 In the morning, move on.
        response.Text = "In the morning, move on.";
        ///RESPONSE_NEXT_NODE_TYPE WARM 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WARM 0 END
        response.NextNodeId = "END";
        
        ///NODE_END WARM
        ///NODE_START COLD
        node = dialog.CreateNode("COLD");
        ///NODE_NPC COLD WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES COLD False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE COLD Full
        ///NODE_VISUAL_USESCRIPT COLD false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~COLD~|||~
        ///PROMPT COLD 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT COLD 0 It starts to rain and you have to stop. You spend a cold, wet night in the woods and catch a chill. [Health goes down.]
        prompt.Text = "It starts to rain and you have to stop. You spend a cold, wet night in the woods and catch a chill. [Health goes down.]";
        ///PROMPT_IGNORE_VO COLD 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE COLD 0
        response = node.AddResponse();
        ///RESPONSE_TEXT COLD 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE COLD 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID COLD 0 END
        response.NextNodeId = "END";
        response.OnSelect(COLD_r0_select);
        
        ///NODE_END COLD
        ///NODE_START INDIAN_01
        node = dialog.CreateNode("INDIAN_01");
        ///NODE_NPC INDIAN_01 WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES INDIAN_01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE INDIAN_01 Full
        ///NODE_VISUAL_USESCRIPT INDIAN_01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~INDIAN_01~|||~
        ///PROMPT INDIAN_01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT INDIAN_01 0 You see a Indian man emptying an animal trap. He stands up quickly when he spots you and moves off into the woods.
        prompt.Text = "You see a Indian man emptying an animal trap. He stands up quickly when he spots you and moves off into the woods.";
        ///PROMPT_IGNORE_VO INDIAN_01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE INDIAN_01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT INDIAN_01 0 Call out and run towards him.
        response.Text = "Call out and run towards him.";
        ///RESPONSE_NEXT_NODE_TYPE INDIAN_01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID INDIAN_01 0 INDIAN_02
        response.NextNodeId = "INDIAN_02";
        
        ///RESPONSE INDIAN_01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT INDIAN_01 1 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE INDIAN_01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID INDIAN_01 1 END
        response.NextNodeId = "END";
        
        ///NODE_END INDIAN_01
        ///NODE_START INDIAN_02
        node = dialog.CreateNode("INDIAN_02");
        ///NODE_NPC INDIAN_02 WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES INDIAN_02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE INDIAN_02 Full
        ///NODE_VISUAL_USESCRIPT INDIAN_02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~INDIAN_02~|||~
        ///PROMPT INDIAN_02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT INDIAN_02 0 The man picks up his pace and you quickly lose track of him in the trees and undergrowth.
        prompt.Text = "The man picks up his pace and you quickly lose track of him in the trees and undergrowth.";
        ///PROMPT_IGNORE_VO INDIAN_02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE INDIAN_02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT INDIAN_02 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE INDIAN_02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID INDIAN_02 0 END
        response.NextNodeId = "END";
        
        ///NODE_END INDIAN_02
        ///NODE_START LAYOUT
        node = dialog.CreateNode("LAYOUT");
        ///NODE_NPC LAYOUT WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES LAYOUT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE LAYOUT Full
        ///NODE_VISUAL_USESCRIPT LAYOUT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~LAYOUT~|||~
        ///PROMPT LAYOUT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT LAYOUT 0 You are surprised when you come across a slave laying out in the woods. You invite him to join you, but he says he's just waiting for his master's anger to cool down before he goes back.
        prompt.Text = "You are surprised when you come across a slave laying out in the woods. You invite him to join you, but he says he's just waiting for his master's anger to cool down before he goes back.";
        ///PROMPT_IGNORE_VO LAYOUT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE LAYOUT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT LAYOUT 0 Trade with him.
        response.Text = "Trade with him.";
        ///RESPONSE_NEXT_NODE_TYPE LAYOUT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID LAYOUT 0 TRADE1
        response.NextNodeId = "TRADE1";
        response.SetCondition(LAYOUT_r0_condition);
        
        ///RESPONSE LAYOUT 1
        response = node.AddResponse();
        ///RESPONSE_TEXT LAYOUT 1 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE LAYOUT 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID LAYOUT 1 END
        response.NextNodeId = "END";
        
        ///NODE_END LAYOUT
        ///NODE_START TRADE1
        node = dialog.CreateNode("TRADE1");
        ///NODE_NPC TRADE1 WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES TRADE1 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE TRADE1 Full
        ///NODE_VISUAL_USESCRIPT TRADE1 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~TRADE1~|||~
        ///PROMPT TRADE1 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT TRADE1 0 The man shows you the food he is carrying.
        prompt.Text = "The man shows you the food he is carrying.";
        ///PROMPT_IGNORE_VO TRADE1 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE TRADE1 0
        response = node.AddResponse();
        ///RESPONSE_TEXT TRADE1 0 Trade him your blanket.
        response.Text = "Trade him your blanket.";
        ///RESPONSE_NEXT_NODE_TYPE TRADE1 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID TRADE1 0 TRADE
        response.NextNodeId = "TRADE";
        response.SetCondition(TRADE1_r0_condition);
        response.OnSelect(TRADE1_r0_select);
        
        ///RESPONSE TRADE1 1
        response = node.AddResponse();
        ///RESPONSE_TEXT TRADE1 1 Trade him the comfrey root.
        response.Text = "Trade him the comfrey root.";
        ///RESPONSE_NEXT_NODE_TYPE TRADE1 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID TRADE1 1 TRADE
        response.NextNodeId = "TRADE";
        response.SetCondition(TRADE1_r1_condition);
        response.OnSelect(TRADE1_r1_select);
        
        ///RESPONSE TRADE1 2
        response = node.AddResponse();
        ///RESPONSE_TEXT TRADE1 2 Trade him your shawl.
        response.Text = "Trade him your shawl.";
        ///RESPONSE_NEXT_NODE_TYPE TRADE1 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID TRADE1 2 TRADE
        response.NextNodeId = "TRADE";
        response.SetCondition(TRADE1_r2_condition);
        response.OnSelect(TRADE1_r2_select);
        
        ///RESPONSE TRADE1 3
        response = node.AddResponse();
        ///RESPONSE_TEXT TRADE1 3 Trade him your axe.
        response.Text = "Trade him your axe.";
        ///RESPONSE_NEXT_NODE_TYPE TRADE1 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID TRADE1 3 TRADE
        response.NextNodeId = "TRADE";
        response.SetCondition(TRADE1_r3_condition);
        response.OnSelect(TRADE1_r3_select);
        
        ///RESPONSE TRADE1 4
        response = node.AddResponse();
        ///RESPONSE_TEXT TRADE1 4 Leave instead.
        response.Text = "Leave instead.";
        ///RESPONSE_NEXT_NODE_TYPE TRADE1 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID TRADE1 4 END
        response.NextNodeId = "END";
        
        ///NODE_END TRADE1
        ///NODE_START TRADE
        node = dialog.CreateNode("TRADE");
        ///NODE_NPC TRADE WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES TRADE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE TRADE Full
        ///NODE_VISUAL_USESCRIPT TRADE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~TRADE~|||~
        ///PROMPT TRADE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT TRADE 0 He takes the blanket and gives you some food. You wish each other well.
        prompt.Text = "He takes the blanket and gives you some food. You wish each other well.";
        ///PROMPT_IGNORE_VO TRADE 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(TRADE_p0_condition);
        prompt.OnShow(TRADE_p0_show);
        
        ///PROMPT TRADE 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT TRADE 1 He takes the comfrey and gives you some food. You wish each other well.
        prompt.Text = "He takes the comfrey and gives you some food. You wish each other well.";
        ///PROMPT_IGNORE_VO TRADE 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(TRADE_p1_condition);
        prompt.OnShow(TRADE_p1_show);
        
        ///PROMPT TRADE 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT TRADE 2 He takes the shawl and gives you some food. You wish each other well.
        prompt.Text = "He takes the shawl and gives you some food. You wish each other well.";
        ///PROMPT_IGNORE_VO TRADE 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(TRADE_p2_condition);
        prompt.OnShow(TRADE_p2_show);
        
        ///PROMPT TRADE 3
        prompt = node.AddPrompt();
        ///PROMPT_TEXT TRADE 3 He takes the axe and gives you some food. You wish each other well.
        prompt.Text = "He takes the axe and gives you some food. You wish each other well.";
        ///PROMPT_IGNORE_VO TRADE 3 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(TRADE_p3_condition);
        prompt.OnShow(TRADE_p3_show);
        
        ///RESPONSE TRADE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT TRADE 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE TRADE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID TRADE 0 END
        response.NextNodeId = "END";
        
        ///NODE_END TRADE
        ///NODE_START SHOTWOLF
        node = dialog.CreateNode("SHOTWOLF");
        ///NODE_NPC SHOTWOLF WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES SHOTWOLF False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SHOTWOLF Full
        ///NODE_VISUAL_USESCRIPT SHOTWOLF false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SHOTWOLF~|||~
        ///PROMPT SHOTWOLF 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SHOTWOLF 0 You come across the body of a wolf that has been shot. There could be more wolves or hunters nearby.
        prompt.Text = "You come across the body of a wolf that has been shot. There could be more wolves or hunters nearby.";
        ///PROMPT_IGNORE_VO SHOTWOLF 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SHOTWOLF 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SHOTWOLF 0 Force yourself to go on.
        response.Text = "Force yourself to go on.";
        ///RESPONSE_NEXT_NODE_TYPE SHOTWOLF 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SHOTWOLF 0 FORCE
        response.NextNodeId = "FORCE";
        
        ///RESPONSE SHOTWOLF 1
        response = node.AddResponse();
        ///RESPONSE_TEXT SHOTWOLF 1 Rest here for the night.
        response.Text = "Rest here for the night.";
        ///RESPONSE_NEXT_NODE_TYPE SHOTWOLF 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SHOTWOLF 1 OKAYNIGHT
        response.NextNodeId = "OKAYNIGHT";
        
        ///NODE_END SHOTWOLF
        ///NODE_START OKAYNIGHT
        node = dialog.CreateNode("OKAYNIGHT");
        ///NODE_NPC OKAYNIGHT WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES OKAYNIGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE OKAYNIGHT Full
        ///NODE_VISUAL_USESCRIPT OKAYNIGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~OKAYNIGHT~|||~
        ///PROMPT OKAYNIGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT OKAYNIGHT 0 You are nervous, but the night passes uneventfully.
        prompt.Text = "You are nervous, but the night passes uneventfully.";
        ///PROMPT_IGNORE_VO OKAYNIGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE OKAYNIGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT OKAYNIGHT 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE OKAYNIGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID OKAYNIGHT 0 END
        response.NextNodeId = "END";
        
        ///NODE_END OKAYNIGHT
        ///NODE_START FORCE
        node = dialog.CreateNode("FORCE");
        ///NODE_NPC FORCE WON
        node.Npc = "WON";
        ///NODE_RANDOM_RESPONSES FORCE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FORCE Full
        ///NODE_VISUAL_USESCRIPT FORCE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FORCE~|||~
        ///PROMPT FORCE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FORCE 0 You muster just enough energy to keep going, but you exhaust yourself afterward. [Health goes down.]
        prompt.Text = "You muster just enough energy to keep going, but you exhaust yourself afterward. [Health goes down.]";
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
        ///PROMPT_TEXT PATROL_01 0 A patrol in the woods spots you.
        prompt.Text = "A patrol in the woods spots you.";
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
        ///PROMPT_TEXT PATROLPASS 0 You show the men your pass. The patrol captain sneers and rips it up. He drags you off to the local sheriff.
        prompt.Text = "You show the men your pass. The patrol captain sneers and rips it up. He drags you off to the local sheriff.";
        ///PROMPT_IGNORE_VO PATROLPASS 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE PATROLPASS 0
        response = node.AddResponse();
        ///RESPONSE_TEXT PATROLPASS 0 [More...]
        response.Text = "[More...]";
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
        ///PROMPT_TEXT PATROLBLUFF 0 The patrol captain tells you to keep your mouth shut and drags you off to the local sheriff.
        prompt.Text = "The patrol captain tells you to keep your mouth shut and drags you off to the local sheriff.";
        ///PROMPT_IGNORE_VO PATROLBLUFF 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE PATROLBLUFF 0
        response = node.AddResponse();
        ///RESPONSE_TEXT PATROLBLUFF 0 [More...]
        response.Text = "[More...]";
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
        ///PROMPT_TEXT HENRYCAUGHT 0 You and Henry run like the wind. Unfortunately Henry slips on a moss covered rock and twists his ankle. He can't keep up. \"Lucy,\" he says, \"You gotta keep running. I'll get by. Now go!\"
        prompt.Text = "You and Henry run like the wind. Unfortunately Henry slips on a moss covered rock and twists his ankle. He can't keep up. \"Lucy,\" he says, \"You gotta keep running. I'll get by. Now go!\"";
        ///PROMPT_IGNORE_VO HENRYCAUGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HENRYCAUGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HENRYCAUGHT 0 \"Goodbye, Henry. I won't forget you.\"
        response.Text = "\"Goodbye, Henry. I won't forget you.\"";
        ///RESPONSE_NEXT_NODE_TYPE HENRYCAUGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HENRYCAUGHT 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE HENRYCAUGHT 1
        response = node.AddResponse();
        ///RESPONSE_TEXT HENRYCAUGHT 1 \"I'm so sorry Henry. Goodbye.\"
        response.Text = "\"I'm so sorry Henry. Goodbye.\"";
        ///RESPONSE_NEXT_NODE_TYPE HENRYCAUGHT 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HENRYCAUGHT 1 END
        response.NextNodeId = "END";
        
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
        ///PROMPT_TEXT RUNCAUGHT 0 The men expected you to run and were ready. They quickly catch you and take you to the local sheriff.
        prompt.Text = "The men expected you to run and were ready. They quickly catch you and take you to the local sheriff.";
        ///PROMPT_IGNORE_VO RUNCAUGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE RUNCAUGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT RUNCAUGHT 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE RUNCAUGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID RUNCAUGHT 0 END
        response.NextNodeId = "END";
        response.OnSelect(RUNCAUGHT_r0_select);
        
        ///NODE_END RUNCAUGHT
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD WARM_p1_condition
    public bool WARM_p1_condition (  ) {
        ///METHOD_BODY_START WARM_p1_condition
        /*//if( hasItem("SHAWL") )*/
        return true;
        ///METHOD_BODY_END WARM_p1_condition
    }

    ///METHOD TRADE_p0_condition
    public bool TRADE_p0_condition (  ) {
        ///METHOD_BODY_START TRADE_p0_condition
        /*//if(  $pick_item =  "BLANKET" )*/
        return true;
        ///METHOD_BODY_END TRADE_p0_condition
    }

    ///METHOD TRADE_p1_condition
    public bool TRADE_p1_condition (  ) {
        ///METHOD_BODY_START TRADE_p1_condition
        /*//if(  $pick_item = "COMFREY" )*/
        return true;
        ///METHOD_BODY_END TRADE_p1_condition
    }

    ///METHOD TRADE_p2_condition
    public bool TRADE_p2_condition (  ) {
        ///METHOD_BODY_START TRADE_p2_condition
        /*//if(  $pick_item = "SHAWL" )*/
        return true;
        ///METHOD_BODY_END TRADE_p2_condition
    }

    ///METHOD TRADE_p3_condition
    public bool TRADE_p3_condition (  ) {
        ///METHOD_BODY_START TRADE_p3_condition
        /*//if( $pick_item = "AXE" )*/
        return true;
        ///METHOD_BODY_END TRADE_p3_condition
    }

    ///METHOD TRADE_p0_show
    public void TRADE_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START TRADE_p0_show
        /*// removeItem("BLANKET") */
        ///METHOD_BODY_END TRADE_p0_show
    }

    ///METHOD TRADE_p1_show
    public void TRADE_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START TRADE_p1_show
        /*// removeItem("COMFREY") */
        ///METHOD_BODY_END TRADE_p1_show
    }

    ///METHOD TRADE_p2_show
    public void TRADE_p2_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START TRADE_p2_show
        /*// removeItem("SHAWL") */
        ///METHOD_BODY_END TRADE_p2_show
    }

    ///METHOD TRADE_p3_show
    public void TRADE_p3_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START TRADE_p3_show
        /*// removeItem("AXE") */
        ///METHOD_BODY_END TRADE_p3_show
    }

    ///METHOD LAYOUT_r0_condition
    public bool LAYOUT_r0_condition (  ) {
        ///METHOD_BODY_START LAYOUT_r0_condition
        /*// if( ( hasItem("AXE") = false) AND ( hasItem("SHAWL") = false ) AND ( hasItem("COMFREY") =false) AND ( hasItem("BLANKET") = false) )    */
        return true;
        ///METHOD_BODY_END LAYOUT_r0_condition
    }

    ///METHOD TRADE1_r0_condition
    public bool TRADE1_r0_condition (  ) {
        ///METHOD_BODY_START TRADE1_r0_condition
        /*//if( hasItem("BLANKET") = true )*/
        return true;
        ///METHOD_BODY_END TRADE1_r0_condition
    }

    ///METHOD TRADE1_r1_condition
    public bool TRADE1_r1_condition (  ) {
        ///METHOD_BODY_START TRADE1_r1_condition
        /*//if( hasItem("COMFREY") =true )*/
        return true;
        ///METHOD_BODY_END TRADE1_r1_condition
    }

    ///METHOD TRADE1_r2_condition
    public bool TRADE1_r2_condition (  ) {
        ///METHOD_BODY_START TRADE1_r2_condition
        /*//if( hasItem("SHAWL") = true ) */
        return true;
        ///METHOD_BODY_END TRADE1_r2_condition
    }

    ///METHOD TRADE1_r3_condition
    public bool TRADE1_r3_condition (  ) {
        ///METHOD_BODY_START TRADE1_r3_condition
        /*// if( hasItem("AXE") = true ) */
        return true;
        ///METHOD_BODY_END TRADE1_r3_condition
    }

    ///METHOD PATROL_01_r0_condition
    public bool PATROL_01_r0_condition (  ) {
        ///METHOD_BODY_START PATROL_01_r0_condition
        /*// if( hasItem("PRESTON_PASS") OR hasItem("FORGED_PASS") ) */
        return true;
        ///METHOD_BODY_END PATROL_01_r0_condition
    }

    ///METHOD FULLTRAP_r1_select
    public void FULLTRAP_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START FULLTRAP_r1_select
        /*//			#rand = random(100)
        //			#rand = #rand + ( 15 * #escape_attempt )
        //		    if(#rand < 45)
        //				$next_node = "PATROL_01"
        //			else
        //				$next_node = "FULL"
        //			/if		*/
        ///METHOD_BODY_END FULLTRAP_r1_select
    }

    ///METHOD FULL_r0_select
    public void FULL_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FULL_r0_select
        /*//			#food = #food + 2
        //			#lucy_health = #lucy_health + 1
        //			#henry_health = #henry_health + 1
        //			post("reportHealth","")*/
        ///METHOD_BODY_END FULL_r0_select
    }

    ///METHOD COLD_r0_select
    public void COLD_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START COLD_r0_select
        /*//				#lucy_health = #lucy_health - 1
        //				#henry_health = #henry_health - 1
        //				post("reportHealth", "")			*/
        ///METHOD_BODY_END COLD_r0_select
    }

    ///METHOD TRADE1_r0_select
    public void TRADE1_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START TRADE1_r0_select
        /*//$pick_item = "BLANKET"*/
        ///METHOD_BODY_END TRADE1_r0_select
    }

    ///METHOD TRADE1_r1_select
    public void TRADE1_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START TRADE1_r1_select
        /*//$pick_item = "COMFREY"*/
        ///METHOD_BODY_END TRADE1_r1_select
    }

    ///METHOD TRADE1_r2_select
    public void TRADE1_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START TRADE1_r2_select
        /*//$pick_item = "SHAWL"*/
        ///METHOD_BODY_END TRADE1_r2_select
    }

    ///METHOD TRADE1_r3_select
    public void TRADE1_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START TRADE1_r3_select
        /*//$pick_item = "AXE"*/
        ///METHOD_BODY_END TRADE1_r3_select
    }

    ///METHOD FORCE_r0_select
    public void FORCE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START FORCE_r0_select
        /*//				#lucy_health = #lucy_health - 1
        //				#henry_health = #henry_health - 1
        //				post("reportHealth", "")*/
        ///METHOD_BODY_END FORCE_r0_select
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
        //			/if		*/
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

    ///METHOD RUNESCAPE_r0_select
    public void RUNESCAPE_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUNESCAPE_r0_select
        /*//			#LUCY_HEALTH = #LUCY_HEALTH - 1
        //			post("reportHealth", "")		*/
        ///METHOD_BODY_END RUNESCAPE_r0_select
    }

    ///METHOD RUNCAUGHT_r0_select
    public void RUNCAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START RUNCAUGHT_r0_select
        /*// endState("escape_end", "") */
        ///METHOD_BODY_END RUNCAUGHT_r0_select
    }
}
//CLASS_END Dialog_p2_won_002
