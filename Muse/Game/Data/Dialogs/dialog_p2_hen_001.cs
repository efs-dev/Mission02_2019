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
//CLASS Dialog_p2_hen_001
public class Dialog_p2_hen_001 {
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
        ///DIALOG_ID p2_hen_001
        var dialog = new Dialog();
        dialog.Id = "p2_hen_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START N01
        node = dialog.CreateNode("N01");
        ///NODE_NPC N01 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES N01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE N01 Full
        ///NODE_VISUAL_USESCRIPT N01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~N01~|||~
        ///PROMPT N01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT N01 0 Henry is utterly exhausted and can't move on. \"Keep going, Lucy. Don't stop. It's the only way. I'll follow when I'm able. You gotta do this.\"
        prompt.Text = "Henry is utterly exhausted and can't move on. \"Keep going, Lucy. Don't stop. It's the only way. I'll follow when I'm able. You gotta do this.\"";
        ///PROMPT_IGNORE_VO N01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE N01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT N01 0 Sadly say goodbye and leave.
        response.Text = "Sadly say goodbye and leave.";
        ///RESPONSE_NEXT_NODE_TYPE N01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID N01 0 END
        response.NextNodeId = "END";
        
        ///NODE_END N01
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }
}
//CLASS_END Dialog_p2_hen_001
