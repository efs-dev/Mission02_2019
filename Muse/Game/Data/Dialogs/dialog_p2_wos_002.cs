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
//CLASS Dialog_p2_wos_002
public class Dialog_p2_wos_002 {
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
        ///DIALOG_ID p2_wos_002
        var dialog = new Dialog();
        dialog.Id = "p2_wos_002";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START WARM
        node = dialog.CreateNode("WARM");
        ///NODE_NPC WARM WOS
        node.Npc = "WOS";
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
        ///NODE_NPC COLD WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES COLD False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE COLD Full
        ///NODE_VISUAL_USESCRIPT COLD false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~COLD~|||~
        ///PROMPT COLD 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT COLD 0 It starts to rain and you have to stop. You spend a cold, wet night in the woods and catch a chill. [Health goes down]
        prompt.Text = "It starts to rain and you have to stop. You spend a cold, wet night in the woods and catch a chill. [Health goes down]";
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
        ///NODE_START HUNTER
        node = dialog.CreateNode("HUNTER");
        ///NODE_NPC HUNTER WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES HUNTER False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE HUNTER Full
        ///NODE_VISUAL_USESCRIPT HUNTER false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~HUNTER~|||~
        ///PROMPT HUNTER 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT HUNTER 0 Up ahead you see a hunter with a rifle. He sees you. You back away the way you came. He watches you go. Hopefully that is all he will do.
        prompt.Text = "Up ahead you see a hunter with a rifle. He sees you. You back away the way you came. He watches you go. Hopefully that is all he will do.";
        ///PROMPT_IGNORE_VO HUNTER 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE HUNTER 0
        response = node.AddResponse();
        ///RESPONSE_TEXT HUNTER 0 Leave.
        response.Text = "Leave.";
        ///RESPONSE_NEXT_NODE_TYPE HUNTER 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID HUNTER 0 END
        response.NextNodeId = "END";
        
        ///NODE_END HUNTER
        ///NODE_START GOOD_MUSH
        node = dialog.CreateNode("GOOD_MUSH");
        ///NODE_NPC GOOD_MUSH WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES GOOD_MUSH False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE GOOD_MUSH Full
        ///NODE_VISUAL_USESCRIPT GOOD_MUSH false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~GOOD_MUSH~|||~
        ///PROMPT GOOD_MUSH 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT GOOD_MUSH 0 You come to a place in the woods where many wild mushrooms grow.
        prompt.Text = "You come to a place in the woods where many wild mushrooms grow.";
        ///PROMPT_IGNORE_VO GOOD_MUSH 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE GOOD_MUSH 0
        response = node.AddResponse();
        ///RESPONSE_TEXT GOOD_MUSH 0 Leave them alone.
        response.Text = "Leave them alone.";
        ///RESPONSE_NEXT_NODE_TYPE GOOD_MUSH 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID GOOD_MUSH 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE GOOD_MUSH 1
        response = node.AddResponse();
        ///RESPONSE_TEXT GOOD_MUSH 1 Eat some.
        response.Text = "Eat some.";
        ///RESPONSE_NEXT_NODE_TYPE GOOD_MUSH 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID GOOD_MUSH 1 BLAND
        response.NextNodeId = "BLAND";
        
        ///NODE_END GOOD_MUSH
        ///NODE_START BLAND
        node = dialog.CreateNode("BLAND");
        ///NODE_NPC BLAND WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES BLAND False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE BLAND Full
        ///NODE_VISUAL_USESCRIPT BLAND false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~BLAND~|||~
        ///PROMPT BLAND 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT BLAND 0 The mushrooms don't taste like much, and they're not very filling, but at least you can eat. You take some extra with you. [Food goes up.]
        prompt.Text = "The mushrooms don't taste like much, and they're not very filling, but at least you can eat. You take some extra with you. [Food goes up.]";
        ///PROMPT_IGNORE_VO BLAND 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE BLAND 0
        response = node.AddResponse();
        ///RESPONSE_TEXT BLAND 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE BLAND 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BLAND 0 END
        response.NextNodeId = "END";
        response.OnSelect(BLAND_r0_select);
        
        ///NODE_END BLAND
        ///NODE_START BAD_MUSH
        node = dialog.CreateNode("BAD_MUSH");
        ///NODE_NPC BAD_MUSH WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES BAD_MUSH False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE BAD_MUSH Full
        ///NODE_VISUAL_USESCRIPT BAD_MUSH false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~BAD_MUSH~|||~
        ///PROMPT BAD_MUSH 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT BAD_MUSH 0 You come to a place in the woods where many wild mushrooms grow.
        prompt.Text = "You come to a place in the woods where many wild mushrooms grow.";
        ///PROMPT_IGNORE_VO BAD_MUSH 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE BAD_MUSH 0
        response = node.AddResponse();
        ///RESPONSE_TEXT BAD_MUSH 0 Leave them alone.
        response.Text = "Leave them alone.";
        ///RESPONSE_NEXT_NODE_TYPE BAD_MUSH 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BAD_MUSH 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE BAD_MUSH 1
        response = node.AddResponse();
        ///RESPONSE_TEXT BAD_MUSH 1 Eat some.
        response.Text = "Eat some.";
        ///RESPONSE_NEXT_NODE_TYPE BAD_MUSH 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BAD_MUSH 1 SICK
        response.NextNodeId = "SICK";
        
        ///NODE_END BAD_MUSH
        ///NODE_START SICK
        node = dialog.CreateNode("SICK");
        ///NODE_NPC SICK WOS
        node.Npc = "WOS";
        ///NODE_RANDOM_RESPONSES SICK False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SICK Full
        ///NODE_VISUAL_USESCRIPT SICK false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SICK~|||~
        ///PROMPT SICK 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SICK 0 Unfortunately, the mushrooms make you very sick. You stay here for a day until you feel well enough to move on. [Health goes down.]
        prompt.Text = "Unfortunately, the mushrooms make you very sick. You stay here for a day until you feel well enough to move on. [Health goes down.]";
        ///PROMPT_IGNORE_VO SICK 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(SICK_p0_show);
        
        ///RESPONSE SICK 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SICK 0 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE SICK 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SICK 0 END
        response.NextNodeId = "END";
        response.OnSelect(SICK_r0_select);
        
        ///NODE_END SICK
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD WARM_p1_condition
    public bool WARM_p1_condition (  ) {
        ///METHOD_BODY_START WARM_p1_condition
        /*//if( hasItem("SHAWL") )*/
        return GameFlags.P1HasShawl;
        ///METHOD_BODY_END WARM_p1_condition
    }

    ///METHOD SICK_p0_show
    public void SICK_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START SICK_p0_show
        /*//				play_sfx("audio/sfx/lucy_moan_b.mp3")			*/
        ///METHOD_BODY_END SICK_p0_show
    }

    ///METHOD COLD_r0_select
    public void COLD_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START COLD_r0_select
        /*//				#lucy_health = #lucy_health - 1
        //				#henry_health = #henry_health - 1
        //				post("reportHealth", "")			*/
        GameFlags.P2LucyHealth--;
        GameFlags.P2HenryHealth--;
        ///METHOD_BODY_END COLD_r0_select
    }

    ///METHOD BLAND_r0_select
    public void BLAND_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START BLAND_r0_select
        /*//				#food = #food + 2
        //				updateMessage("You got 2 food")			*/
        GameFlags.P2LucyFood+=2;
        ///METHOD_BODY_END BLAND_r0_select
    }

    ///METHOD SICK_r0_select
    public void SICK_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START SICK_r0_select
        /*//				#lucy_health = #lucy_health - 1
        //				#henry_health = #henry_health - 1
        //				post("reportHealth", "")
        //				#days_passed = #days_passed + 1
        //				updateMessage("Another day passes")						*/
        GameFlags.P2LucyHealth--;
        GameFlags.P2HenryHealth--;
        GameFlags.P2DaysPassed++;
        ///METHOD_BODY_END SICK_r0_select
    }
}
//CLASS_END Dialog_p2_wos_002
