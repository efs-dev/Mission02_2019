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
//CLASS Dialog_p1_smokehouse
public class Dialog_p1_smokehouse {
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
        ///DIALOG_ID p1_smokehouse
        var dialog = new Dialog();
        dialog.Id = "p1_smokehouse";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You unlock the smokehouse door and take the wood inside. Henry hasn't been too tidy in here. Dry leaves and twigs are scattered on the floor.
        prompt.Text = "You unlock the smokehouse door and take the wood inside. Henry hasn't been too tidy in here. Dry leaves and twigs are scattered on the floor.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Obey Mr. Otis] carefully build a fire to evenly smoke the meats.
        response.Text = "[Obey Mr. Otis] carefully build a fire to evenly smoke the meats.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Build a fire under the meats quickly and carelessly.
        response.Text = "Build a fire under the meats quickly and carelessly.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 In a short while you have taken care of your work here.
        prompt.Text = "In a short while you have taken care of your work here.";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [Do extra work] Clean up some of the leaves and twigs on the floor.
        response.Text = "[Do extra work] Clean up some of the leaves and twigs on the floor.";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Leave and 'forget' to lock the door.
        response.Text = "Leave and 'forget' to lock the door.";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 End
        response.NextNodeType = DialogResponse.NextNodeTypes.End;
        ///RESPONSE_NEXT_NODE_ID n02 1 end
        response.NextNodeId = "end";
        
        ///RESPONSE n02 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 2 [Obey Mr. Otis] Leave and lock the door behind you.
        response.Text = "[Obey Mr. Otis] Leave and lock the door behind you.";
        ///RESPONSE_NEXT_NODE_TYPE n02 2 End
        response.NextNodeType = DialogResponse.NextNodeTypes.End;
        ///RESPONSE_NEXT_NODE_ID n02 2 end
        response.NextNodeId = "end";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 Soon the place is cleaner and probably a bit safer.
        prompt.Text = "Soon the place is cleaner and probably a bit safer.";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 Leave and 'forget' to lock the door.
        response.Text = "Leave and 'forget' to lock the door.";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 
        response.NextNodeId = "";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 [Obey Mr. Otis] Leave and lock the door behind you.
        response.Text = "[Obey Mr. Otis] Leave and lock the door behind you.";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 
        response.NextNodeId = "";
        
        ///NODE_END n03
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }
}
//CLASS_END Dialog_p1_smokehouse
