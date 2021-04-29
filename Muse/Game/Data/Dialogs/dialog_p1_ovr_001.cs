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
//CLASS Dialog_p1_ovr_001
public class Dialog_p1_ovr_001 {
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
        ///DIALOG_ID p1_ovr_001
        var dialog = new Dialog();
        dialog.Id = "p1_ovr_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 We need eggs from the coop and them hogs need their slop. Then you got the wash! What are you doin' here? \n
        prompt.Text = "We need eggs from the coop and them hogs need their slop. Then you got the wash! What are you doin' here? \n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Nothing, Mr. Otis, sir.
        response.Text = "Nothing, Mr. Otis, sir.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 [LIE] I was just getting a drink from the creek.
        response.Text = "[LIE] I was just getting a drink from the creek.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 I'm getting some comfrey root so momma can make a compress for Henry.
        response.Text = "I'm getting some comfrey root so momma can make a compress for Henry.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 That boy got what's coming to him. He slowed down the harvest. Let him suffer! You get to your work right now!
        prompt.Text = "That boy got what's coming to him. He slowed down the harvest. Let him suffer! You get to your work right now!";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 Yes, Mr. Otis
        response.Text = "Yes, Mr. Otis";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 But Henry's not to blame, Mr. Otis!
        response.Text = "But Henry's not to blame, Mr. Otis!";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 And don't let me catch you trying to help Henry again!
        prompt.Text = "And don't let me catch you trying to help Henry again!";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 Yes, Mr. Otis.
        response.Text = "Yes, Mr. Otis.";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 Watch your mouth girl! You care so much about Henry? Then today you'll do his work too! I'll find you later.\n
        prompt.Text = "Watch your mouth girl! You care so much about Henry? Then today you'll do his work too! I'll find you later.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Yes, Mr. Otis
        response.Text = "Yes, Mr. Otis";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 You can do that in the Yard! Now get to your work!
        prompt.Text = "You can do that in the Yard! Now get to your work!";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Yes, Mr. Otis
        response.Text = "Yes, Mr. Otis";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 OVR
        node.Npc = "OVR";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Nothing! You got plenty to do! Don't make me have to tell you again!
        prompt.Text = "Nothing! You got plenty to do! Don't make me have to tell you again!";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Yes, Mr. Otis
        response.Text = "Yes, Mr. Otis";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n06
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//set ?comfrey_tried = true*/
        GameFlags.P1ComfreyTried = true;
        ///METHOD_BODY_END n01_p0_show
    }
}
//CLASS_END Dialog_p1_ovr_001
