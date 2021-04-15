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
//CLASS Dialog_p2_may_001
public class Dialog_p2_may_001 {
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
        ///DIALOG_ID p2_may_001
        var dialog = new Dialog();
        dialog.Id = "p2_may_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 MAY
        node.Npc = "MAY";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You are on the outskirts of the bustling town of Maysville on the Ohio River.
        prompt.Text = "You are on the outskirts of the bustling town of Maysville on the Ohio River.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Try to sneak aboard the next ferry.
        response.Text = "Try to sneak aboard the next ferry.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 SNEAK
        response.NextNodeId = "SNEAK";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Wait for the morning ferry.
        response.Text = "Wait for the morning ferry.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 STEWARD
        response.NextNodeId = "STEWARD";
        response.SetCondition(n01_r3_condition);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Go to the back door of the Maysville tavern.
        response.Text = "Go to the back door of the Maysville tavern.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 TAVERN
        response.NextNodeId = "TAVERN";
        response.SetCondition(n01_r2_condition);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 Search the town looking for help.
        response.Text = "Search the town looking for help.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 LOOKING
        response.NextNodeId = "LOOKING";
        response.OnSelect(n01_r1_select);
        
        ///RESPONSE n01 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 4 Go somewhere else.
        response.Text = "Go somewhere else.";
        ///RESPONSE_NEXT_NODE_TYPE n01 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 4 END
        response.NextNodeId = "END";
        
        ///NODE_END n01
        ///NODE_START STEWARD
        node = dialog.CreateNode("STEWARD");
        ///NODE_NPC STEWARD MAY
        node.Npc = "MAY";
        ///NODE_RANDOM_RESPONSES STEWARD False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE STEWARD Full
        ///NODE_VISUAL_USESCRIPT STEWARD false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~STEWARD~|||~
        ///PROMPT STEWARD 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT STEWARD 0 The steward agrees to help you. He hides you in the cargo hold. He says when you get across go find Reverend Rankin's house on the hill.
        prompt.Text = "The steward agrees to help you. He hides you in the cargo hold. He says when you get across go find Reverend Rankin's house on the hill.";
        ///PROMPT_IGNORE_VO STEWARD 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT STEWARD 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT STEWARD 1 The steward agrees to help you. He hides you and Henry in different parts of the cargo hold. He says when you get across go find Reverend Rankin's house on the hill.
        prompt.Text = "The steward agrees to help you. He hides you and Henry in different parts of the cargo hold. He says when you get across go find Reverend Rankin's house on the hill.";
        ///PROMPT_IGNORE_VO STEWARD 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(STEWARD_p1_condition);
        
        ///RESPONSE STEWARD 0
        response = node.AddResponse();
        ///RESPONSE_TEXT STEWARD 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE STEWARD 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID STEWARD 0 END
        response.NextNodeId = "END";
        response.OnSelect(STEWARD_r0_select);
        
        ///NODE_END STEWARD
        ///NODE_START SNEAK
        node = dialog.CreateNode("SNEAK");
        ///NODE_NPC SNEAK MAY
        node.Npc = "MAY";
        ///NODE_RANDOM_RESPONSES SNEAK False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SNEAK Full
        ///NODE_VISUAL_USESCRIPT SNEAK false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SNEAK~|||~
        ///PROMPT SNEAK 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SNEAK 0 The ferries are watched very closely. The captain spots you while inspecting the cargo and raises a cry. You are captured and returned to the King Plantation.
        prompt.Text = "The ferries are watched very closely. The captain spots you while inspecting the cargo and raises a cry. You are captured and returned to the King Plantation.";
        ///PROMPT_IGNORE_VO SNEAK 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SNEAK 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SNEAK 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE SNEAK 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SNEAK 0 END
        response.NextNodeId = "END";
        response.OnSelect(SNEAK_r0_select);
        
        ///NODE_END SNEAK
        ///NODE_START LOOKING
        node = dialog.CreateNode("LOOKING");
        ///NODE_NPC LOOKING MAY
        node.Npc = "MAY";
        ///NODE_RANDOM_RESPONSES LOOKING False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE LOOKING Full
        ///NODE_VISUAL_USESCRIPT LOOKING false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~LOOKING~|||~
        ///PROMPT LOOKING 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT LOOKING 0 Your actions are suspicious and draw the attention of a slavecatcher and his boys. They have you locked up and returned to the King Plantation.
        prompt.Text = "Your actions are suspicious and draw the attention of a slavecatcher and his boys. They have you locked up and returned to the King Plantation.";
        ///PROMPT_IGNORE_VO LOOKING 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE LOOKING 0
        response = node.AddResponse();
        ///RESPONSE_TEXT LOOKING 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE LOOKING 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID LOOKING 0 END
        response.NextNodeId = "END";
        response.OnSelect(LOOKING_r0_select);
        
        ///NODE_END LOOKING
        ///NODE_START TAVERN_HINT
        node = dialog.CreateNode("TAVERN_HINT");
        ///NODE_NPC TAVERN_HINT MAY
        node.Npc = "MAY";
        ///NODE_RANDOM_RESPONSES TAVERN_HINT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE TAVERN_HINT Full
        ///NODE_VISUAL_USESCRIPT TAVERN_HINT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~TAVERN_HINT~|||~
        ///PROMPT TAVERN_HINT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT TAVERN_HINT 0 You happen upon another slave who whispers that you should ask for help at the back of the Maysville tavern.
        prompt.Text = "You happen upon another slave who whispers that you should ask for help at the back of the Maysville tavern.";
        ///PROMPT_IGNORE_VO TAVERN_HINT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE TAVERN_HINT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT TAVERN_HINT 0 [Go to the tavern.]
        response.Text = "[Go to the tavern.]";
        ///RESPONSE_NEXT_NODE_TYPE TAVERN_HINT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID TAVERN_HINT 0 TAVERN
        response.NextNodeId = "TAVERN";
        
        ///NODE_END TAVERN_HINT
        ///NODE_START TAVERN
        node = dialog.CreateNode("TAVERN");
        ///NODE_NPC TAVERN MAY
        node.Npc = "MAY";
        ///NODE_RANDOM_RESPONSES TAVERN False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE TAVERN Full
        ///NODE_VISUAL_USESCRIPT TAVERN false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~TAVERN~|||~
        ///PROMPT TAVERN 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT TAVERN 0 A man lets you in the back door and takes you down to the cellar where you meet some other fugitive slaves. That night you sneak out and are rowed across the Ohio River. You made it!
        prompt.Text = "A man lets you in the back door and takes you down to the cellar where you meet some other fugitive slaves. That night you sneak out and are rowed across the Ohio River. You made it!";
        ///PROMPT_IGNORE_VO TAVERN 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE TAVERN 0
        response = node.AddResponse();
        ///RESPONSE_TEXT TAVERN 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE TAVERN 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID TAVERN 0 END
        response.NextNodeId = "END";
        response.OnSelect(TAVERN_r0_select);
        
        ///NODE_END TAVERN
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD STEWARD_p1_condition
    public bool STEWARD_p1_condition (  ) {
        ///METHOD_BODY_START STEWARD_p1_condition
        /*// if($escape_type="henry") */
        return true;
        ///METHOD_BODY_END STEWARD_p1_condition
    }

    ///METHOD n01_r3_condition
    public bool n01_r3_condition (  ) {
        ///METHOD_BODY_START n01_r3_condition
        /*// if(?p2_know_steward = true )*/
        return true;
        ///METHOD_BODY_END n01_r3_condition
    }

    ///METHOD n01_r2_condition
    public bool n01_r2_condition (  ) {
        ///METHOD_BODY_START n01_r2_condition
        /*// if(?know_tavern)*/
        return true;
        ///METHOD_BODY_END n01_r2_condition
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//				#rand = random(100)
        //				if( $escape_type = "henry" )
        //					#rand = (#rand - 15)
        //				/if
        //				if( #escape_attempt > 1 )
        //					#rand = #rand + 30
        //				/if
        //				if( #rand > 70 )
        //					$next_node = "TAVERN_HINT"
        //				/if*/
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD STEWARD_r0_select
    public void STEWARD_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START STEWARD_r0_select
        /*//  $pick_result="steward" */
        ///METHOD_BODY_END STEWARD_r0_select
    }

    ///METHOD SNEAK_r0_select
    public void SNEAK_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START SNEAK_r0_select
        /*//  endState("escape_end", "")  */
        ///METHOD_BODY_END SNEAK_r0_select
    }

    ///METHOD LOOKING_r0_select
    public void LOOKING_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START LOOKING_r0_select
        /*//  endState("escape_end", "")  */
        ///METHOD_BODY_END LOOKING_r0_select
    }

    ///METHOD TAVERN_r0_select
    public void TAVERN_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START TAVERN_r0_select
        /*// $pick_result ="farside"  */
        ///METHOD_BODY_END TAVERN_r0_select
    }
}
//CLASS_END Dialog_p2_may_001
