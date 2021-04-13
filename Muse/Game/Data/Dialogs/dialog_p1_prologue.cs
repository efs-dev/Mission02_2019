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
//CLASS Dialog_p1_prologue
public class Dialog_p1_prologue {
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
        ///DIALOG_ID p1_prologue
        var dialog = new Dialog();
        dialog.Id = "p1_prologue";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n00
        node = dialog.CreateNode("n00");
        ///NODE_NPC n00 PROLOGUE
        node.Npc = "PROLOGUE";
        ///NODE_RANDOM_RESPONSES n00 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n00 Full
        ///NODE_VISUAL_USESCRIPT n00 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n00~|||~
        ///PROMPT n00 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n00 0 [You wake up in your quarters. You hear your mother talking to another slave outside.]
        prompt.Text = "[You wake up in your quarters. You hear your mother talking to another slave outside.]";
        ///PROMPT_IGNORE_VO n00 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n00 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n00 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE n00 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n00 0 n01
        response.NextNodeId = "n01";
        
        ///NODE_END n00
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 PROLOGUE
        node.Npc = "PROLOGUE";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 HENRY: This time I'm going to make it up north. Past the big river. This time I'm going to get free.<br>MOTHER: This time you're going to get yourself sold south.
        prompt.Text = "HENRY: This time I'm going to make it up north. Past the big river. This time I'm going to get free.<br>MOTHER: This time you're going to get yourself sold south.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Go outside]
        response.Text = "[Go outside]";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 [Keep listening]
        response.Text = "[Keep listening]";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 PROLOGUE
        node.Npc = "PROLOGUE";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 HENRY: <moans> I'm tired of being treated worse than they treat mules. We work, work, work and never get nothing but whippings.<br>MOTHER: You can barely stand up. Running away now is a fool idea.
        prompt.Text = "HENRY: <moans> I'm tired of being treated worse than they treat mules. We work, work, work and never get nothing but whippings.<br>MOTHER: You can barely stand up. Running away now is a fool idea.";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n02_p0_show);
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [Go outside]
        response.Text = "[Go outside]";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 [Keep listening]
        response.Text = "[Keep listening]";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n03
        response.NextNodeId = "n03";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 PROLOGUE
        node.Npc = "PROLOGUE";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 HENRY: Besides, what's to keep me here? Nothing! They already sold my family. Never see them again.<br>MOTHER: Quiet now. I can hear Lucy stirring. Don't you put dangerous thoughts in her head. LUCY? TIME TO WAKE UP.
        prompt.Text = "HENRY: Besides, what's to keep me here? Nothing! They already sold my family. Never see them again.<br>MOTHER: Quiet now. I can hear Lucy stirring. Don't you put dangerous thoughts in her head. LUCY? TIME TO WAKE UP.";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n03_p0_show);
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 [Go outside]
        response.Text = "[Go outside]";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n03
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//play_sfx("audio/dlgs/p1/p1_prologue2/p1_mom_001_n01.mp3")*/
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n02_p0_show
    public void n02_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n02_p0_show
        /*//play_sfx("audio/dlgs/p1/p1_prologue2/p1_mom_001_n02.mp3")*/
        ///METHOD_BODY_END n02_p0_show
    }

    ///METHOD n03_p0_show
    public void n03_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n03_p0_show
        /*//play_sfx("audio/dlgs/p1/p1_prologue2/p1_mom_001_n03.mp3")*/
        ///METHOD_BODY_END n03_p0_show
    }
}
//CLASS_END Dialog_p1_prologue
