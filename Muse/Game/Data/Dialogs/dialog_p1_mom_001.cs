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
//CLASS Dialog_p1_mom_001
public class Dialog_p1_mom_001 {
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
        ///DIALOG_ID p1_mom_001
        var dialog = new Dialog();
        dialog.Id = "p1_mom_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 Morning Lucy. Henry's back is still real bad. He can't work today.
        prompt.Text = "Morning Lucy. Henry's back is still real bad. He can't work today.";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Is there anything I can do to help?
        response.Text = "Is there anything I can do to help?";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 Mr. Otis is going to be mad if Henry doesn't work.
        response.Text = "Mr. Otis is going to be mad if Henry doesn't work.";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n13
        response.NextNodeId = "n13";
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 I saw Mr. Otis whipping him.  He wouldn't stop til Henry told the truth.
        response.Text = "I saw Mr. Otis whipping him.  He wouldn't stop til Henry told the truth.";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n04 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 3 What were you just talking about?
        response.Text = "What were you just talking about?";
        ///RESPONSE_NEXT_NODE_TYPE n04 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 3 n05_mom
        response.NextNodeId = "n05_mom";
        
        ///NODE_END n04
        ///NODE_START n05_henry
        node = dialog.CreateNode("n05_henry");
        ///NODE_NPC n05_henry MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n05_henry False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05_henry Full
        ///NODE_VISUAL_USESCRIPT n05_henry false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05_henry~|||~
        ///PROMPT n05_henry 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05_henry 0 I'm running off. No more ###smartword|master|MASTER###. I'm going to be a free man.
        prompt.Text = "I'm running off. No more ###smartword|master|MASTER###. I'm going to be a free man.";
        ///PROMPT_IGNORE_VO n05_henry 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05_henry 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05_henry 0 Where will you go?
        response.Text = "Where will you go?";
        ///RESPONSE_NEXT_NODE_TYPE n05_henry 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05_henry 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n05_henry 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05_henry 1 What if you get caught?
        response.Text = "What if you get caught?";
        ///RESPONSE_NEXT_NODE_TYPE n05_henry 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05_henry 1 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n05_henry
        ///NODE_START n05_mom
        node = dialog.CreateNode("n05_mom");
        ///NODE_NPC n05_mom MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n05_mom False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05_mom Full
        ///NODE_VISUAL_USESCRIPT n05_mom false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05_mom~|||~
        ///PROMPT n05_mom 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05_mom 0 You hush, Henry!
        prompt.Text = "You hush, Henry!";
        ///PROMPT_IGNORE_VO n05_mom 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05_mom 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05_mom 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n05_mom 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05_mom 0 n05_henry
        response.NextNodeId = "n05_henry";
        
        ///NODE_END n05_mom
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 That's enough of that talk! Lucy I need your help.
        prompt.Text = "That's enough of that talk! Lucy I need your help.";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [Continue]
        response.Text = "[Continue]";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 Before you do your morning work, go down by the creek and bring back some comfrey root.
        prompt.Text = "Before you do your morning work, go down by the creek and bring back some comfrey root.";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 Why's that, Mama?
        response.Text = "Why's that, Mama?";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Comfrey will help heal Henry's back.
        prompt.Text = "Comfrey will help heal Henry's back.";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 I see.
        response.Text = "I see.";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n08b
        response.NextNodeId = "n08b";
        
        ///NODE_END n08
        ///NODE_START n08b
        node = dialog.CreateNode("n08b");
        ///NODE_NPC n08b MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n08b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08b Full
        ///NODE_VISUAL_USESCRIPT n08b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08b~|||~
        ///PROMPT n08b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08b 0 There's the bell. I have to get to the field. I'll mash it up and put it on him when I get back.
        prompt.Text = "There's the bell. I have to get to the field. I'll mash it up and put it on him when I get back.";
        ///PROMPT_IGNORE_VO n08b 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n08b_p0_show);
        
        ///RESPONSE n08b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08b 0 Okay, I'll go now.
        response.Text = "Okay, I'll go now.";
        ///RESPONSE_NEXT_NODE_TYPE n08b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08b 0 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n08b
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 Best to not let Mr. Otis see what you're up to. After that find your brother in the Yard and make sure he's doing his work.
        prompt.Text = "Best to not let Mr. Otis see what you're up to. After that find your brother in the Yard and make sure he's doing his work.";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 Yes, Mama. [Leave]
        response.Text = "Yes, Mama. [Leave]";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 That weren't the truth! I'd say anything to the ###smartword|overseer|OVERSEER### to make him stop!
        prompt.Text = "That weren't the truth! I'd say anything to the ###smartword|overseer|OVERSEER### to make him stop!";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 But Mr. Otis says he saw you messing with the hemp-break.
        response.Text = "But Mr. Otis says he saw you messing with the hemp-break.";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 That old hemp-break was already falling apart! Wish I had busted it if I'm going to get blamed anyway!
        prompt.Text = "That old hemp-break was already falling apart! Wish I had busted it if I'm going to get blamed anyway!";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 Why would he blame you for it?
        response.Text = "Why would he blame you for it?";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n12_henry
        response.NextNodeId = "n12_henry";
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 It's just not fair!
        response.Text = "It's just not fair!";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n12_henry
        response.NextNodeId = "n12_henry";
        
        ///NODE_END n11
        ///NODE_START n12_henry
        node = dialog.CreateNode("n12_henry");
        ///NODE_NPC n12_henry MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n12_henry False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12_henry Full
        ///NODE_VISUAL_USESCRIPT n12_henry false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12_henry~|||~
        ///PROMPT n12_henry 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12_henry 0 Ain't nothing fair for us. We're just the master's property.
        prompt.Text = "Ain't nothing fair for us. We're just the master's property.";
        ///PROMPT_IGNORE_VO n12_henry 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12_henry 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12_henry 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n12_henry 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12_henry 0 n12_mom
        response.NextNodeId = "n12_mom";
        
        ///NODE_END n12_henry
        ///NODE_START n12_mom
        node = dialog.CreateNode("n12_mom");
        ///NODE_NPC n12_mom MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n12_mom False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12_mom Full
        ///NODE_VISUAL_USESCRIPT n12_mom false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12_mom~|||~
        ///PROMPT n12_mom 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12_mom 0 Calm yourself, Henry. Now Lucy I need help.
        prompt.Text = "Calm yourself, Henry. Now Lucy I need help.";
        ///PROMPT_IGNORE_VO n12_mom 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12_mom 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12_mom 0 What's that Mama?
        response.Text = "What's that Mama?";
        ///RESPONSE_NEXT_NODE_TYPE n12_mom 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12_mom 0 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n12_mom
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 MOM
        node.Npc = "MOM";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Mr. Otis don't need much to get him angry. If he say you did something then it don't matter what's true.
        prompt.Text = "Mr. Otis don't need much to get him angry. If he say you did something then it don't matter what's true.";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 [Continue]
        response.Text = "[Continue]";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n13
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n08b_p0_show
    public void n08b_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n08b_p0_show
        /*//play_sfx("audio/sfx/bell.mp3")*/
        ///METHOD_BODY_END n08b_p0_show
    }
}
//CLASS_END Dialog_p1_mom_001
