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
//CLASS Dialog_p4_choice_telegraph
public class Dialog_p4_choice_telegraph {
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
        ///DIALOG_ID p4_choice_telegraph
        var dialog = new Dialog();
        dialog.Id = "p4_choice_telegraph";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START three_more
        node = dialog.CreateNode("three_more");
        ///NODE_NPC three_more CHOICE
        node.Npc = "CHOICE";
        ///NODE_RANDOM_RESPONSES three_more False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE three_more Full
        ///NODE_VISUAL_USESCRIPT three_more false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~three_more~|||~
        ///PROMPT three_more 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT three_more 0 You still have time to do THREE more things before the commissioner arrives.
        prompt.Text = "You still have time to do THREE more things before the commissioner arrives.";
        ///PROMPT_IGNORE_VO three_more 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE three_more 0
        response = node.AddResponse();
        ///RESPONSE_TEXT three_more 0 Send a telegraph message to Morgan's family in Philadelphia.
        response.Text = "Send a telegraph message to Morgan's family in Philadelphia.";
        ///RESPONSE_NEXT_NODE_TYPE three_more 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID three_more 0 END
        response.NextNodeId = "END";
        response.SetCondition(three_more_r0_condition);
        response.OnSelect(three_more_r0_select);
        
        ///RESPONSE three_more 1
        response = node.AddResponse();
        ///RESPONSE_TEXT three_more 1 Go to the place where Morgan was grabbed and look for evidence.
        response.Text = "Go to the place where Morgan was grabbed and look for evidence.";
        ///RESPONSE_NEXT_NODE_TYPE three_more 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID three_more 1 END
        response.NextNodeId = "END";
        response.OnSelect(three_more_r1_select);
        
        ///RESPONSE three_more 2
        response = node.AddResponse();
        ///RESPONSE_TEXT three_more 2 Talk to people in Ripley and try to find witnesses.
        response.Text = "Talk to people in Ripley and try to find witnesses.";
        ///RESPONSE_NEXT_NODE_TYPE three_more 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID three_more 2 END
        response.NextNodeId = "END";
        response.OnSelect(three_more_r2_select);
        
        ///NODE_END three_more
        ///NODE_START two_more
        node = dialog.CreateNode("two_more");
        ///NODE_NPC two_more CHOICE
        node.Npc = "CHOICE";
        ///NODE_RANDOM_RESPONSES two_more False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE two_more Full
        ///NODE_VISUAL_USESCRIPT two_more false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~two_more~|||~
        ///PROMPT two_more 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT two_more 0 You have time to do TWO more things before the commissioner arrives.
        prompt.Text = "You have time to do TWO more things before the commissioner arrives.";
        ///PROMPT_IGNORE_VO two_more 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE two_more 0
        response = node.AddResponse();
        ///RESPONSE_TEXT two_more 0 Go to the place where Morgan was grabbed and look for evidence.
        response.Text = "Go to the place where Morgan was grabbed and look for evidence.";
        ///RESPONSE_NEXT_NODE_TYPE two_more 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID two_more 0 END
        response.NextNodeId = "END";
        response.SetCondition(two_more_r0_condition);
        response.OnSelect(two_more_r0_select);
        
        ///RESPONSE two_more 1
        response = node.AddResponse();
        ///RESPONSE_TEXT two_more 1 Talk to people in Ripley and try to find witnesses.
        response.Text = "Talk to people in Ripley and try to find witnesses.";
        ///RESPONSE_NEXT_NODE_TYPE two_more 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID two_more 1 END
        response.NextNodeId = "END";
        response.SetCondition(two_more_r1_condition);
        response.OnSelect(two_more_r1_select);
        
        ///NODE_END two_more
        ///NODE_START one_more
        node = dialog.CreateNode("one_more");
        ///NODE_NPC one_more CHOICE
        node.Npc = "CHOICE";
        ///NODE_RANDOM_RESPONSES one_more False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE one_more Full
        ///NODE_VISUAL_USESCRIPT one_more false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~one_more~|||~
        ///PROMPT one_more 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT one_more 0 You have time to do ONE more thing before the commissioner arrives.
        prompt.Text = "You have time to do ONE more thing before the commissioner arrives.";
        ///PROMPT_IGNORE_VO one_more 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE one_more 0
        response = node.AddResponse();
        ///RESPONSE_TEXT one_more 0 Go to the place where Morgan was grabbed and look for evidence.
        response.Text = "Go to the place where Morgan was grabbed and look for evidence.";
        ///RESPONSE_NEXT_NODE_TYPE one_more 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID one_more 0 END
        response.NextNodeId = "END";
        response.SetCondition(one_more_r0_condition);
        response.OnSelect(one_more_r0_select);
        
        ///RESPONSE one_more 1
        response = node.AddResponse();
        ///RESPONSE_TEXT one_more 1 Talk to people in Ripley and try to find witnesses.
        response.Text = "Talk to people in Ripley and try to find witnesses.";
        ///RESPONSE_NEXT_NODE_TYPE one_more 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID one_more 1 END
        response.NextNodeId = "END";
        response.SetCondition(one_more_r1_condition);
        response.OnSelect(one_more_r1_select);
        
        ///NODE_END one_more
        ///NODE_START finished
        node = dialog.CreateNode("finished");
        ///NODE_NPC finished CHOICE
        node.Npc = "CHOICE";
        ///NODE_RANDOM_RESPONSES finished False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE finished Full
        ///NODE_VISUAL_USESCRIPT finished false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~finished~|||~
        ///PROMPT finished 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT finished 0 You are out of time.
        prompt.Text = "You are out of time.";
        ///PROMPT_IGNORE_VO finished 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE finished 0
        response = node.AddResponse();
        ///RESPONSE_TEXT finished 0 Go to the commissioner.
        response.Text = "Go to the commissioner.";
        ///RESPONSE_NEXT_NODE_TYPE finished 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID finished 0 END
        response.NextNodeId = "END";
        response.OnSelect(finished_r0_select);
        
        ///NODE_END finished
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD three_more_r0_condition
    public bool three_more_r0_condition (  ) {
        ///METHOD_BODY_START three_more_r0_condition
        /*//					if( ?P3_TELEGRAPH  )*/
        return true;
        ///METHOD_BODY_END three_more_r0_condition
    }

    ///METHOD two_more_r0_condition
    public bool two_more_r0_condition (  ) {
        ///METHOD_BODY_START two_more_r0_condition
        /*//				if( (visitCount("ambush2") = 0)  )*/
        return true;
        ///METHOD_BODY_END two_more_r0_condition
    }

    ///METHOD two_more_r1_condition
    public bool two_more_r1_condition (  ) {
        ///METHOD_BODY_START two_more_r1_condition
        /*//				if( (visitCount("witness2") = 0)  )*/
        return true;
        ///METHOD_BODY_END two_more_r1_condition
    }

    ///METHOD one_more_r0_condition
    public bool one_more_r0_condition (  ) {
        ///METHOD_BODY_START one_more_r0_condition
        /*//				if( (visitCount("ambush2") = 0)  )*/
        return true;
        ///METHOD_BODY_END one_more_r0_condition
    }

    ///METHOD one_more_r1_condition
    public bool one_more_r1_condition (  ) {
        ///METHOD_BODY_START one_more_r1_condition
        /*//				if( (visitCount("witness2") = 0)  )*/
        return true;
        ///METHOD_BODY_END one_more_r1_condition
    }

    ///METHOD three_more_r0_select
    public void three_more_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START three_more_r0_select
        /*//				endState("telegraph", "CROSSFADE")	*/
        ///METHOD_BODY_END three_more_r0_select
    }

    ///METHOD three_more_r1_select
    public void three_more_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START three_more_r1_select
        /*//				endState("ambush", "CROSSFADE")*/
        ///METHOD_BODY_END three_more_r1_select
    }

    ///METHOD three_more_r2_select
    public void three_more_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START three_more_r2_select
        /*//					endState("witness", "CROSSFADE")*/
        ///METHOD_BODY_END three_more_r2_select
    }

    ///METHOD two_more_r0_select
    public void two_more_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START two_more_r0_select
        /*//				// 1st ambush
        //				endState("ambush", "CROSSFADE")				*/
        ///METHOD_BODY_END two_more_r0_select
    }

    ///METHOD two_more_r1_select
    public void two_more_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START two_more_r1_select
        /*//					// first witness
        //					endState("witness", "CROSSFADE")					*/
        ///METHOD_BODY_END two_more_r1_select
    }

    ///METHOD one_more_r0_select
    public void one_more_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START one_more_r0_select
        /*//				if( visitCount("ambush") = 0)
        //					endState("ambush", "CROSSFADE")
        //				else
        //					endState("ambush2", "")
        //				/if*/
        ///METHOD_BODY_END one_more_r0_select
    }

    ///METHOD one_more_r1_select
    public void one_more_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START one_more_r1_select
        /*//					if( visitCount("witness") = 0)
        //						endState("witness", "CROSSFADE")
        //					else
        //						endState("witness2", "")
        //					/if*/
        ///METHOD_BODY_END one_more_r1_select
    }

    ///METHOD finished_r0_select
    public void finished_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START finished_r0_select
        /*//					endState("commissioner", "CROSSFADE")*/
        ///METHOD_BODY_END finished_r0_select
    }
}
//CLASS_END Dialog_p4_choice_telegraph
