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
//CLASS Dialog_p1_jon_001
public class Dialog_p1_jon_001 {
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
        ///DIALOG_ID p1_jon_001
        var dialog = new Dialog();
        dialog.Id = "p1_jon_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 [Jonah shoves something behind his back.]
        prompt.Text = "[Jonah shoves something behind his back.]";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 What are you doing?
        response.Text = "What are you doing?";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 N-nothing.  I mean--tending the garden.
        prompt.Text = "N-nothing.  I mean--tending the garden.";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 Jonah, you're looking at Sarah's school book. You can't keep taking it.
        response.Text = "Jonah, you're looking at Sarah's school book. You can't keep taking it.";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 But she don't use it no more. She knows how to read. I want to learn too.\n
        prompt.Text = "But she don't use it no more. She knows how to read. I want to learn too.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 Why do you want to learn to read so much?
        response.Text = "Why do you want to learn to read so much?";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 We aren't allowed to read.
        response.Text = "We aren't allowed to read.";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n03 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 2 If Mr. Otis catches you with it, you're going to be in trouble.
        response.Text = "If Mr. Otis catches you with it, you're going to be in trouble.";
        ///RESPONSE_NEXT_NODE_TYPE n03 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 2 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 Is he going to whip me, like Henry?
        prompt.Text = "Is he going to whip me, like Henry?";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 Probably not. But he'll do something bad. Maybe make you work in the fields.\n
        response.Text = "Probably not. But he'll do something bad. Maybe make you work in the fields.\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 Why not?
        prompt.Text = "Why not?";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Reading doesn't help us do our work.
        response.Text = "Reading doesn't help us do our work.";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Master King can read. And Miss Sarah too. And even Mr. Otis. They all learned.\n
        prompt.Text = "Master King can read. And Miss Sarah too. And even Mr. Otis. They all learned.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 Doesn't matter. If Mr. Otis catches you, you're going to be in trouble.
        response.Text = "Doesn't matter. If Mr. Otis catches you, you're going to be in trouble.";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n04
        response.NextNodeId = "n04";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 But they are white. Learning ain't meant for us.\n
        response.Text = "But they are white. Learning ain't meant for us.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 That would be real hard. I don't know if I'm strong enough. What should I do?
        prompt.Text = "That would be real hard. I don't know if I'm strong enough. What should I do?";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 You better give it to me. I'll think of something.
        response.Text = "You better give it to me. I'll think of something.";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 You better hide it someplace safe.
        response.Text = "You better hide it someplace safe.";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Then how come Miss Sarah used to teach you?
        prompt.Text = "Then how come Miss Sarah used to teach you?";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 She wasn't supposed to. When Master King found out, he got mad and made her stop.\n
        response.Text = "She wasn't supposed to. When Master King found out, he got mad and made her stop.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 Let me just do one more word and then I'll hide it.
        prompt.Text = "Let me just do one more word and then I'll hide it.";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 You better give it to me.
        response.Text = "You better give it to me.";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 OK, one more and then you hide it.
        response.Text = "OK, one more and then you hide it.";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n13
        response.NextNodeId = "n13";
        response.OnSelect(n09_r1_select);
        
        ///RESPONSE n09 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 2 No Jonah, hide it now.
        response.Text = "No Jonah, hide it now.";
        ///RESPONSE_NEXT_NODE_TYPE n09 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 2 n12
        response.NextNodeId = "n12";
        response.OnSelect(n09_r2_select);
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 Yes, Lucy. [He gives you the book.] But I'm going to learn to read. You'll see.
        prompt.Text = "Yes, Lucy. [He gives you the book.] But I'm going to learn to read. You'll see.";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n10_p0_show);
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I understand. But Mama and me need you to do your work. We don't want trouble from Mr. Otis.
        response.Text = "I understand. But Mama and me need you to do your work. We don't want trouble from Mr. Otis.";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 I know you will. How about we practice letters before we go to bed?
        response.Text = "I know you will. How about we practice letters before we go to bed?";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n11
        response.NextNodeId = "n11";
        response.OnSelect(n10_r1_select);
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 Yes Lucy!
        prompt.Text = "Yes Lucy!";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 I'll see you later, Jonah. Now do your work.
        response.Text = "I'll see you later, Jonah. Now do your work.";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 Yes, Miss Lucy.
        prompt.Text = "Yes, Miss Lucy.";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 I'll see you later. Now do your work.\n
        response.Text = "I'll see you later. Now do your work.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Thank you. Okay... F-A-N...  Fan... F-A-N...
        prompt.Text = "Thank you. Okay... F-A-N...  Fan... F-A-N...";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 [Leave]
        response.Text = "[Leave]";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 JON
        node.Npc = "JON";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 I think they scared of us learning to read. Then we'd know everything they do.
        prompt.Text = "I think they scared of us learning to read. Then we'd know everything they do.";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 Maybe. But if Mr. Otis catches you with it, you're going to be in trouble.
        response.Text = "Maybe. But if Mr. Otis catches you with it, you're going to be in trouble.";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n14
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        GameFlags.P1TotalTasks += 2;
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n10_p0_show
    public void n10_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n10_p0_show
        /*//addItem ("primer")*/
        GameFlags.P1HasPrimer = true;
        ///METHOD_BODY_END n10_p0_show
    }

    ///METHOD n09_r1_select
    public void n09_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n09_r1_select
        /*//set ?jon_trouble = true*/
        GameFlags.P1JonTrouble = true;
        ///METHOD_BODY_END n09_r1_select
    }

    ///METHOD n09_r2_select
    public void n09_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n09_r2_select
        /*//set ?book_hidden = true*/
        GameFlags.P1BookHidden = true;
        ///METHOD_BODY_END n09_r2_select
    }

    ///METHOD n10_r1_select
    public void n10_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n10_r1_select
        /*//set ?practice_promise = true*/
        GameFlags.P1PracticePromise = true;
        ///METHOD_BODY_END n10_r1_select
    }
}
//CLASS_END Dialog_p1_jon_001
