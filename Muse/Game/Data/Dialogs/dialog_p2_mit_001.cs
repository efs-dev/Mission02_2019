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
//CLASS Dialog_p2_mit_001
public class Dialog_p2_mit_001 {
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
        ///DIALOG_ID p2_mit_001
        var dialog = new Dialog();
        dialog.Id = "p2_mit_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 MIT
        node.Npc = "MIT";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 The Mitchell Farm is a small horse-farm that has a few slaves. They also keep many dogs about.
        prompt.Text = "The Mitchell Farm is a small horse-farm that has a few slaves. They also keep many dogs about.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Hide in the root cellar.
        response.Text = "Hide in the root cellar.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 CELLAR
        response.NextNodeId = "CELLAR";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Steal a horse.
        response.Text = "Steal a horse.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Script
        response.NextNodeType = DialogResponse.NextNodeTypes.Script;
        ///RESPONSE_NEXT_NODE_ID n01 1 
        response.NextNodeId = "";
        response.OnSelect(n01_r1_select);
        response.OnSelectNextNodeId(n01_r1_nextnodeid);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Make contact with the slaves.
        response.Text = "Make contact with the slaves.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 CONTACT
        response.NextNodeId = "CONTACT";
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 Keep going.
        response.Text = "Keep going.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 END
        response.NextNodeId = "END";
        
        ///NODE_END n01
        ///NODE_START CONTACT
        node = dialog.CreateNode("CONTACT");
        ///NODE_NPC CONTACT MIT
        node.Npc = "MIT";
        ///NODE_RANDOM_RESPONSES CONTACT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CONTACT Full
        ///NODE_VISUAL_USESCRIPT CONTACT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CONTACT~|||~
        ///PROMPT CONTACT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CONTACT 0 The overseer keeps a very close watch on the slaves. After awhile you decide it's too risky to try to get help from the slaves here.
        prompt.Text = "The overseer keeps a very close watch on the slaves. After awhile you decide it's too risky to try to get help from the slaves here.";
        ///PROMPT_IGNORE_VO CONTACT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE CONTACT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CONTACT 0 Move on.
        response.Text = "Move on.";
        ///RESPONSE_NEXT_NODE_TYPE CONTACT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CONTACT 0 END
        response.NextNodeId = "END";
        
        ///NODE_END CONTACT
        ///NODE_START CELLAR
        node = dialog.CreateNode("CELLAR");
        ///NODE_NPC CELLAR MIT
        node.Npc = "MIT";
        ///NODE_RANDOM_RESPONSES CELLAR False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CELLAR Full
        ///NODE_VISUAL_USESCRIPT CELLAR false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CELLAR~|||~
        ///PROMPT CELLAR 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CELLAR 0 The farm is too small and too busy to stay out of sight very well. You are discovered by one of the farm hands and turned over to the local sheriff.
        prompt.Text = "The farm is too small and too busy to stay out of sight very well. You are discovered by one of the farm hands and turned over to the local sheriff.";
        ///PROMPT_IGNORE_VO CELLAR 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE CELLAR 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CELLAR 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE CELLAR 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CELLAR 0 END
        response.NextNodeId = "END";
        response.OnSelect(CELLAR_r0_select);
        
        ///NODE_END CELLAR
        ///NODE_START STEAL
        node = dialog.CreateNode("STEAL");
        ///NODE_NPC STEAL MIT
        node.Npc = "MIT";
        ///NODE_RANDOM_RESPONSES STEAL False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE STEAL Full
        ///NODE_VISUAL_USESCRIPT STEAL false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~STEAL~|||~
        ///PROMPT STEAL 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT STEAL 0 You manage to free one of the horses. You have no experience riding. Do you still want to try?
        prompt.Text = "You manage to free one of the horses. You have no experience riding. Do you still want to try?";
        ///PROMPT_IGNORE_VO STEAL 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE STEAL 0
        response = node.AddResponse();
        ///RESPONSE_TEXT STEAL 0 Leave on foot.
        response.Text = "Leave on foot.";
        ///RESPONSE_NEXT_NODE_TYPE STEAL 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID STEAL 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE STEAL 1
        response = node.AddResponse();
        ///RESPONSE_TEXT STEAL 1 Ride away.
        response.Text = "Ride away.";
        ///RESPONSE_NEXT_NODE_TYPE STEAL 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID STEAL 1 END
        response.NextNodeId = "END";
        response.OnSelect(STEAL_r1_select);
        
        ///NODE_END STEAL
        ///NODE_START STEAL_H
        node = dialog.CreateNode("STEAL_H");
        ///NODE_NPC STEAL_H MIT
        node.Npc = "MIT";
        ///NODE_RANDOM_RESPONSES STEAL_H False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE STEAL_H Full
        ///NODE_VISUAL_USESCRIPT STEAL_H false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~STEAL_H~|||~
        ///PROMPT STEAL_H 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT STEAL_H 0 \"Are you crazy?\" Henry says, \"Two Negroes going by on a horse? That'll bring patrols on us quicker than flies to honey. Count me out!\"
        prompt.Text = "\"Are you crazy?\" Henry says, \"Two Negroes going by on a horse? That'll bring patrols on us quicker than flies to honey. Count me out!\"";
        ///PROMPT_IGNORE_VO STEAL_H 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE STEAL_H 0
        response = node.AddResponse();
        ///RESPONSE_TEXT STEAL_H 0 Keep going on foot.
        response.Text = "Keep going on foot.";
        ///RESPONSE_NEXT_NODE_TYPE STEAL_H 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID STEAL_H 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE STEAL_H 1
        response = node.AddResponse();
        ///RESPONSE_TEXT STEAL_H 1 Ride the horse anyway. [Henry stays behind.]
        response.Text = "Ride the horse anyway. [Henry stays behind.]";
        ///RESPONSE_NEXT_NODE_TYPE STEAL_H 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID STEAL_H 1 END
        response.NextNodeId = "END";
        response.OnSelect(STEAL_H_r1_select);
        
        ///NODE_END STEAL_H
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//				if($escape_type = "henry" )
        //					$next_node = "STEAL_H"
        //				/if			*/
        if (GameFlags.P2EscapeType == "henry"){
        	DialogGameFlags.next_node = "STEAL_H";
        }
        else {
        	DialogGameFlags.next_node = "STEAL";
        }
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD CELLAR_r0_select
    public void CELLAR_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START CELLAR_r0_select
        /*//  endState("escape_end", "") */
        GlobalScripts.LosePart2();
        ///METHOD_BODY_END CELLAR_r0_select
    }

    ///METHOD STEAL_r1_select
    public void STEAL_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START STEAL_r1_select
        /*//   $pick_result = "ride" */
        ///METHOD_BODY_END STEAL_r1_select
    }

    ///METHOD STEAL_H_r1_select
    public void STEAL_H_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START STEAL_H_r1_select
        /*//				$pick_result = "ride"
        //				killHenry()*/
        GlobalScripts.KillHenry();
        ///METHOD_BODY_END STEAL_H_r1_select
    }

    ///METHOD n01_r1_nextnodeid
    public string n01_r1_nextnodeid ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_nextnodeid
        return DialogGameFlags.next_node;
        ///METHOD_BODY_END n01_r1_nextnodeid
    }
}
//CLASS_END Dialog_p2_mit_001
