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
//CLASS Dialog_p2_par_001
public class Dialog_p2_par_001 {
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
        ///DIALOG_ID p2_par_001
        var dialog = new Dialog();
        dialog.Id = "p2_par_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 As you near the town of Paris, Kentucky you see a poster nailed to a tree.
        prompt.Text = "As you near the town of Paris, Kentucky you see a poster nailed to a tree.";
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
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 NIGHTFALL
        response.NextNodeId = "NIGHTFALL";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Go through town.
        response.Text = "Go through town.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n01b
        response.NextNodeId = "n01b";
        
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
        ///NODE_NPC n01a PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n01a False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01a Full
        ///NODE_VISUAL_USESCRIPT n01a false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01a~|||~
        ///PROMPT n01a 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01a 0 You are just outside Paris, Kentucky.
        prompt.Text = "You are just outside Paris, Kentucky.";
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
        ///RESPONSE_TEXT n01a 1 Wait until nightfall.
        response.Text = "Wait until nightfall.";
        ///RESPONSE_NEXT_NODE_TYPE n01a 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01a 1 NIGHTFALL
        response.NextNodeId = "NIGHTFALL";
        
        ///RESPONSE n01a 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01a 2 Change clothes and stroll through town.
        response.Text = "Change clothes and stroll through town.";
        ///RESPONSE_NEXT_NODE_TYPE n01a 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01a 2 MAKEIT
        response.NextNodeId = "MAKEIT";
        response.SetCondition(n01a_r2_condition);
        response.OnSelect(n01a_r2_select);
        
        ///RESPONSE n01a 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01a 3 Go through town.
        response.Text = "Go through town.";
        ///RESPONSE_NEXT_NODE_TYPE n01a 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01a 3 n01b
        response.NextNodeId = "n01b";
        
        ///NODE_END n01a
        ///NODE_START n01b
        node = dialog.CreateNode("n01b");
        ///NODE_NPC n01b PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES n01b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01b Full
        ///NODE_VISUAL_USESCRIPT n01b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01b~|||~
        ///PROMPT n01b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01b 0 You're awfully hungry. You might be able to steal or beg some food at the market.
        prompt.Text = "You're awfully hungry. You might be able to steal or beg some food at the market.";
        ///PROMPT_IGNORE_VO n01b 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01b 0 Go to the market.
        response.Text = "Go to the market.";
        ///RESPONSE_NEXT_NODE_TYPE n01b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01b 0 
        response.NextNodeId = "";
        response.OnSelect(n01b_r0_select);
        
        ///RESPONSE n01b 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01b 1 Hurry along.
        response.Text = "Hurry along.";
        ///RESPONSE_NEXT_NODE_TYPE n01b 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01b 1 
        response.NextNodeId = "";
        response.OnSelect(n01b_r1_select);
        
        ///NODE_END n01b
        ///NODE_START NIGHTFALL
        node = dialog.CreateNode("NIGHTFALL");
        ///NODE_NPC NIGHTFALL PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES NIGHTFALL False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NIGHTFALL Full
        ///NODE_VISUAL_USESCRIPT NIGHTFALL false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NIGHTFALL~|||~
        ///PROMPT NIGHTFALL 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NIGHTFALL 0 You hide by the side of the road the whole day. Just after nightfall you notice that all the Negroes have left the streets of Paris.
        prompt.Text = "You hide by the side of the road the whole day. Just after nightfall you notice that all the Negroes have left the streets of Paris.";
        ///PROMPT_IGNORE_VO NIGHTFALL 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE NIGHTFALL 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NIGHTFALL 0 Take a long detour around town.
        response.Text = "Take a long detour around town.";
        ///RESPONSE_NEXT_NODE_TYPE NIGHTFALL 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NIGHTFALL 0 DETOUR
        response.NextNodeId = "DETOUR";
        
        ///RESPONSE NIGHTFALL 1
        response = node.AddResponse();
        ///RESPONSE_TEXT NIGHTFALL 1 Go through town.
        response.Text = "Go through town.";
        ///RESPONSE_NEXT_NODE_TYPE NIGHTFALL 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NIGHTFALL 1 CURFEW
        response.NextNodeId = "CURFEW";
        
        ///NODE_END NIGHTFALL
        ///NODE_START CURFEW
        node = dialog.CreateNode("CURFEW");
        ///NODE_NPC CURFEW PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES CURFEW False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CURFEW Full
        ///NODE_VISUAL_USESCRIPT CURFEW false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CURFEW~|||~
        ///PROMPT CURFEW 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CURFEW 0 You find out the hard way that Paris has a nine p.m. curfew for slaves. A patrol quickly rounds you up, questions you, and takes you to the sheriff.
        prompt.Text = "You find out the hard way that Paris has a nine p.m. curfew for slaves. A patrol quickly rounds you up, questions you, and takes you to the sheriff.";
        ///PROMPT_IGNORE_VO CURFEW 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE CURFEW 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CURFEW 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE CURFEW 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CURFEW 0 END
        response.NextNodeId = "END";
        response.OnSelect(CURFEW_r0_select);
        
        ///NODE_END CURFEW
        ///NODE_START DETOUR
        node = dialog.CreateNode("DETOUR");
        ///NODE_NPC DETOUR PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES DETOUR False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE DETOUR Full
        ///NODE_VISUAL_USESCRIPT DETOUR false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~DETOUR~|||~
        ///PROMPT DETOUR 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT DETOUR 0 You make a wide path around Paris. The way is difficult and you need to eat some extra food. [Food goes down]
        prompt.Text = "You make a wide path around Paris. The way is difficult and you need to eat some extra food. [Food goes down]";
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
        ///NODE_START MAKEIT
        node = dialog.CreateNode("MAKEIT");
        ///NODE_NPC MAKEIT PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES MAKEIT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE MAKEIT Full
        ///NODE_VISUAL_USESCRIPT MAKEIT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~MAKEIT~|||~
        ///PROMPT MAKEIT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT MAKEIT 0 [Lucky] You keep your head down and quickly move through town without drawing attention to yourself.
        prompt.Text = "[Lucky] You keep your head down and quickly move through town without drawing attention to yourself.";
        ///PROMPT_IGNORE_VO MAKEIT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE MAKEIT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT MAKEIT 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE MAKEIT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID MAKEIT 0 END
        response.NextNodeId = "END";
        
        ///NODE_END MAKEIT
        ///NODE_START SPOTTED
        node = dialog.CreateNode("SPOTTED");
        ///NODE_NPC SPOTTED PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES SPOTTED False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SPOTTED Full
        ///NODE_VISUAL_USESCRIPT SPOTTED false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SPOTTED~|||~
        ///PROMPT SPOTTED 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SPOTTED 0 Someone thinks you look suspicious and calls the sheriff. The sheriff questions you and takes you to jail.
        prompt.Text = "Someone thinks you look suspicious and calls the sheriff. The sheriff questions you and takes you to jail.";
        ///PROMPT_IGNORE_VO SPOTTED 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SPOTTED 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SPOTTED 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE SPOTTED 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SPOTTED 0 END
        response.NextNodeId = "END";
        response.OnSelect(SPOTTED_r0_select);
        
        ///NODE_END SPOTTED
        ///NODE_START MARKET_H
        node = dialog.CreateNode("MARKET_H");
        ///NODE_NPC MARKET_H PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES MARKET_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE MARKET_H Full
        ///NODE_VISUAL_USESCRIPT MARKET_H false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~MARKET_H~|||~
        ///PROMPT MARKET_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT MARKET_H 0 You and Henry go to the market hoping to steal some food, but you look very out of place and the sheriff questions you and then takes you into custody.
        prompt.Text = "You and Henry go to the market hoping to steal some food, but you look very out of place and the sheriff questions you and then takes you into custody.";
        ///PROMPT_IGNORE_VO MARKET_H 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE MARKET_H 0
        response = node.AddResponse();
        ///RESPONSE_TEXT MARKET_H 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE MARKET_H 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID MARKET_H 0 END
        response.NextNodeId = "END";
        response.OnSelect(MARKET_H_r0_select);
        
        ///NODE_END MARKET_H
        ///NODE_START MARKET
        node = dialog.CreateNode("MARKET");
        ///NODE_NPC MARKET PAR
        node.Npc = "PAR";
        ///NODE_RANDOM_RESPONSES MARKET False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE MARKET Full
        ///NODE_VISUAL_USESCRIPT MARKET false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~MARKET~|||~
        ///PROMPT MARKET 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT MARKET 0 A free Negro selling squash takes pity on you. He gives you a little food and tells you might be able to find other help behind the Maysville tavern.
        prompt.Text = "A free Negro selling squash takes pity on you. He gives you a little food and tells you might be able to find other help behind the Maysville tavern.";
        ///PROMPT_IGNORE_VO MARKET 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE MARKET 0
        response = node.AddResponse();
        ///RESPONSE_TEXT MARKET 0 [Move on.]
        response.Text = "[Move on.]";
        ///RESPONSE_NEXT_NODE_TYPE MARKET 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID MARKET 0 END
        response.NextNodeId = "END";
        response.OnSelect(MARKET_r0_select);
        
        ///NODE_END MARKET
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01a_r2_condition
    public bool n01a_r2_condition (  ) {
        ///METHOD_BODY_START n01a_r2_condition
        /*// if( hasItem("CLOTHES") ) */
        return true;
        ///METHOD_BODY_END n01a_r2_condition
    }

    ///METHOD n01_r3_select
    public void n01_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r3_select
        /*//					overlayPopup("paris_poster")
        //					?has_wanted1 = true*/
        ///METHOD_BODY_END n01_r3_select
    }

    ///METHOD n01a_r2_select
    public void n01a_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01a_r2_select
        /*//				?p2_disguised = true*/
        ///METHOD_BODY_END n01a_r2_select
    }

    ///METHOD n01b_r0_select
    public void n01b_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01b_r0_select
        /*//				if( $escape_type = "henry" )
        //					$next_node = "MARKET_H"
        //				else
        //					$next_node = "MARKET"
        //				/if*/
        ///METHOD_BODY_END n01b_r0_select
    }

    ///METHOD n01b_r1_select
    public void n01b_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01b_r1_select
        /*//				#rand = random(100)
        //				// decrease chance
        //				if( $escape_type = "henry" )
        //					#rand = #rand - 30
        //				/if
        //				#rand = #rand + (15 * #escape_attempt)
        //				if( #rand > 80 )
        //					// make it
        //					$next_node = "MAKEIT"
        //				else
        //					$next_node = "SPOTTED"
        //				/if*/
        ///METHOD_BODY_END n01b_r1_select
    }

    ///METHOD CURFEW_r0_select
    public void CURFEW_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START CURFEW_r0_select
        /*//				endState("escape_end", "")*/
        ///METHOD_BODY_END CURFEW_r0_select
    }

    ///METHOD DETOUR_r0_select
    public void DETOUR_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START DETOUR_r0_select
        /*//				doFood()*/
        ///METHOD_BODY_END DETOUR_r0_select
    }

    ///METHOD SPOTTED_r0_select
    public void SPOTTED_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START SPOTTED_r0_select
        /*//				endState("escape_end","")			*/
        ///METHOD_BODY_END SPOTTED_r0_select
    }

    ///METHOD MARKET_H_r0_select
    public void MARKET_H_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START MARKET_H_r0_select
        /*//				endState("escape_end","")			*/
        ///METHOD_BODY_END MARKET_H_r0_select
    }

    ///METHOD MARKET_r0_select
    public void MARKET_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START MARKET_r0_select
        /*//				?know_tavern = true
        //				#food = #food + 1
        //				updateMessage("The man gives you 1 food.")*/
        ///METHOD_BODY_END MARKET_r0_select
    }
}
//CLASS_END Dialog_p2_par_001
