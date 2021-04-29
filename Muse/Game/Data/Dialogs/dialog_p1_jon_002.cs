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
//CLASS Dialog_p1_jon_002
public class Dialog_p1_jon_002 {
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
        ///DIALOG_ID p1_jon_002
        var dialog = new Dialog();
        dialog.Id = "p1_jon_002";
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
        ///PROMPT_TEXT n01 0 Lucy! What's happening?\n
        prompt.Text = "Lucy! What's happening?\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Jonah, I'm running away. I'm not going to be a slave no more.\n
        response.Text = "Jonah, I'm running away. I'm not going to be a slave no more.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Jonah, I have to leave for a while. \n
        response.Text = "Jonah, I have to leave for a while. \n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
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
        ///PROMPT_TEXT n02 0 Why? Nobody wants you to leave! \n
        prompt.Text = "Why? Nobody wants you to leave! \n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 I'm running away. I'm not going to be a slave no more.\n
        response.Text = "I'm running away. I'm not going to be a slave no more.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 I just have to. For a little while.\n
        response.Text = "I just have to. For a little while.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n06
        response.NextNodeId = "n06";
        
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
        ///PROMPT_TEXT n03 0 Is it because of the smokehouse? Is that why you're leaving? So you won't get whipped like Henry?\n
        prompt.Text = "Is it because of the smokehouse? Is that why you're leaving? So you won't get whipped like Henry?\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 Jonah, I don't have time now.\n
        response.Text = "Jonah, I don't have time now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 Mister Otis is blaming me for the fire. He's gonna beat me and Henry real bad unless we run away.\n
        response.Text = "Mister Otis is blaming me for the fire. He's gonna beat me and Henry real bad unless we run away.\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n03
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
        ///PROMPT_TEXT n05 0 I won't let him hurt you! I hate him.\n
        prompt.Text = "I won't let him hurt you! I hate him.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Jonah, calm down. I need you to listen to me now.\n
        response.Text = "Jonah, calm down. I need you to listen to me now.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n11
        response.NextNodeId = "n11";
        
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
        ///PROMPT_TEXT n06 0 Can I come? I'll be good, I promise!\n
        prompt.Text = "Can I come? I'll be good, I promise!\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 I'm sorry Jonah.\n
        response.Text = "I'm sorry Jonah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n10
        response.NextNodeId = "n10";
        
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
        ///PROMPT_TEXT n07 0 Lucy... don't go, please don't go.\n
        prompt.Text = "Lucy... don't go, please don't go.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 Jonah, don't cry.\n
        response.Text = "Jonah, don't cry.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n11
        response.NextNodeId = "n11";
        
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
        ///PROMPT_TEXT n08 0 What is it?\n
        prompt.Text = "What is it?\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 You listen to mama and be good. Family is important and she needs you. Can you do that?\n
        response.Text = "You listen to mama and be good. Family is important and she needs you. Can you do that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n12
        response.NextNodeId = "n12";
        response.OnSelect(n08_r0_select);
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 Keep practicing your letters. You learn to read in secret. Can you do that?\n
        response.Text = "Keep practicing your letters. You learn to read in secret. Can you do that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n12
        response.NextNodeId = "n12";
        response.OnSelect(n08_r1_select);
        
        ///RESPONSE n08 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 2 You can't tell anybody that you saw me and Henry go. This has to be our secret. Can you do that?\n
        response.Text = "You can't tell anybody that you saw me and Henry go. This has to be our secret. Can you do that?\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 2 n12
        response.NextNodeId = "n12";
        response.OnSelect(n08_r2_select);
        
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
        ///PROMPT_TEXT n09 0 Goodbye Lucy. I love you.\n
        prompt.Text = "Goodbye Lucy. I love you.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 I love you too.\n
        response.Text = "I love you too.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 END
        response.NextNodeId = "END";
        
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
        ///PROMPT_TEXT n10 0 Lucy? You're not coming back are you?\n
        prompt.Text = "Lucy? You're not coming back are you?\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I'm running away. I have to. Don't know if I'll be back. But there is something I want you to do for me.\n
        response.Text = "I'm running away. I have to. Don't know if I'll be back. But there is something I want you to do for me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n08
        response.NextNodeId = "n08";
        
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
        ///PROMPT_TEXT n11 0 Yes Lucy. I'll be better. I promise.\n
        prompt.Text = "Yes Lucy. I'll be better. I promise.\n";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 That's good. There is something you can do to help me.\n
        response.Text = "That's good. There is something you can do to help me.\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n08
        response.NextNodeId = "n08";
        
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
        ///PROMPT_TEXT n12 0 I can do that.\n
        prompt.Text = "I can do that.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 Thank you. Goodbye Jonah.\n
        response.Text = "Thank you. Goodbye Jonah.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n09
        response.NextNodeId = "n09";
        
        ///NODE_END n12
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n08_r0_select
    public void n08_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r0_select
        /*//$jonah_promise = "family"*/
        GameFlags.P1JonahPromise = "family";
        ///METHOD_BODY_END n08_r0_select
    }

    ///METHOD n08_r1_select
    public void n08_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r1_select
        /*//$jonah_promise = "reading"*/
        GameFlags.P1JonahPromise = "reading";
        ///METHOD_BODY_END n08_r1_select
    }

    ///METHOD n08_r2_select
    public void n08_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n08_r2_select
        /*//$jonah_promise = "secret"*/
        GameFlags.P1JonahPromise = "secret";
        ///METHOD_BODY_END n08_r2_select
    }
}
//CLASS_END Dialog_p1_jon_002
