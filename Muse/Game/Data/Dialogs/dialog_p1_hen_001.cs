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
//CLASS Dialog_p1_hen_001
public class Dialog_p1_hen_001 {
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
        ///DIALOG_ID p1_hen_001
        var dialog = new Dialog();
        dialog.Id = "p1_hen_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 That settles it. I'm running tonight.\n
        prompt.Text = "That settles it. I'm running tonight.\n";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 I'm running too. I don't want to get sold down the river.\n
        response.Text = "I'm running too. I don't want to get sold down the river.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 Tonight? How you going to get enough food? What's your plan?\n
        response.Text = "Tonight? How you going to get enough food? What's your plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n04
        response.NextNodeId = "n04";
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 What if you get caught again? That'll be even worse.\n
        response.Text = "What if you get caught again? That'll be even worse.\n";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 But Henry, Mama says you're too hurt.
        response.Text = "But Henry, Mama says you're too hurt.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 Your mama is probably right. I'm still hurtin' and weak. But I can't take another whipping. And I'm not going south.\n
        prompt.Text = "Your mama is probably right. I'm still hurtin' and weak. But I can't take another whipping. And I'm not going south.\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 What's your plan?\n
        response.Text = "What's your plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 I have to run too. I'm not going south neither. We can help each other.\n
        response.Text = "I have to run too. I'm not going south neither. We can help each other.\n";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n05
        response.NextNodeId = "n05";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 I just gotta make it. And I learned some things when I ran a couple of years ago.\n
        prompt.Text = "I just gotta make it. And I learned some things when I ran a couple of years ago.\n";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 What did you learn Henry? What's your plan?\n
        response.Text = "What did you learn Henry? What's your plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 I knew this day would come. So I've been saving food. And I've made a plan.\n
        prompt.Text = "I knew this day would come. So I've been saving food. And I've made a plan.\n";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 What's your plan?\n
        response.Text = "What's your plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 How you gonna run? Do you have a plan? You can't come with me, you'd just slow me down.\n
        prompt.Text = "How you gonna run? Do you have a plan? You can't come with me, you'd just slow me down.\n";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 Who said I wanted to go with you?\n
        response.Text = "Who said I wanted to go with you?\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n13
        response.NextNodeId = "n13";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 What's your plan? You ran before and now you're back here.\n
        response.Text = "What's your plan? You ran before and now you're back here.\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n05 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 2 Henry, from the look of you I can walk faster than you can run!\n
        response.Text = "Henry, from the look of you I can walk faster than you can run!\n";
        ///RESPONSE_NEXT_NODE_TYPE n05 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 2 n11
        response.NextNodeId = "n11";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 I'm going stay off the roads. Too many ###smartword|patrollers|PATROLLERS###. I know a cave where I can rest a bit and then keep going.\n
        prompt.Text = "I'm going stay off the roads. Too many ###smartword|patrollers|PATROLLERS###. I know a cave where I can rest a bit and then keep going.\n";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 I have a better idea.\n
        response.Text = "I have a better idea.\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 And then what?\n
        response.Text = "And then what?\n";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 What do you mean? I just keep going north through the woods until I get to the big river and then I'll do whatever it takes. Even float on a log.\n
        prompt.Text = "What do you mean? I just keep going north through the woods until I get to the big river and then I'll do whatever it takes. Even float on a log.\n";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 I have a better idea.
        response.Text = "I have a better idea.";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n07
        ///NODE_START n07b
        node = dialog.CreateNode("n07b");
        ///NODE_NPC n07b HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n07b False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07b Full
        ///NODE_VISUAL_USESCRIPT n07b false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07b~|||~
        ///PROMPT n07b 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07b 0 And then I hear folks there will hide you from the slave catchers and help you get free.\n
        prompt.Text = "And then I hear folks there will hide you from the slave catchers and help you get free.\n";
        ///PROMPT_IGNORE_VO n07b 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07b 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07b 0 I have a better plan.\n
        response.Text = "I have a better plan.\n";
        ///RESPONSE_NEXT_NODE_TYPE n07b 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07b 0 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n07b 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07b 1 Where did you hear about the house?\n
        response.Text = "Where did you hear about the house?\n";
        ///RESPONSE_NEXT_NODE_TYPE n07b 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07b 1 n14
        response.NextNodeId = "n14";
        
        ///NODE_END n07b
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 You do? Well I'd sure like to hear it then.\n
        prompt.Text = "You do? Well I'd sure like to hear it then.\n";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 I'm thinking about it. But it'll be better than floating on some old log.\n
        response.Text = "I'm thinking about it. But it'll be better than floating on some old log.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 I'd go to Lexington. Esther told me about a church that you can go to. They help runaway slaves get north.\n
        response.Text = "I'd go to Lexington. Esther told me about a church that you can go to. They help runaway slaves get north.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n08_r1_condition);
        
        ///RESPONSE n08 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 2 I got this map. I took it from Sarah's room. Shows the way up the road all the way to the river.\n
        response.Text = "I got this map. I took it from Sarah's room. Shows the way up the road all the way to the river.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 2 n09
        response.NextNodeId = "n09";
        response.SetCondition(n08_r2_condition);
        
        ///RESPONSE n08 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 3 I'd go to the plantation where my papa is. He'd give me some help and tell me where to go next.\n
        response.Text = "I'd go to the plantation where my papa is. He'd give me some help and tell me where to go next.\n";
        ///RESPONSE_NEXT_NODE_TYPE n08 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 3 n15
        response.NextNodeId = "n15";
        
        ///NODE_END n08
        ///NODE_START n09
        node = dialog.CreateNode("n09");
        ///NODE_NPC n09 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n09 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n09 Full
        ///NODE_VISUAL_USESCRIPT n09 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n09~|||~
        ///PROMPT n09 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n09 0 I don't know. The roads are dangerous. But I never had no map to show the way.\n
        prompt.Text = "I don't know. The roads are dangerous. But I never had no map to show the way.\n";
        ///PROMPT_IGNORE_VO n09 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n09 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 0 I think we'll be safer if we don't run together. Folks will be suspicious of two Negroes traveling together.\n
        response.Text = "I think we'll be safer if we don't run together. Folks will be suspicious of two Negroes traveling together.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 0 n19
        response.NextNodeId = "n19";
        
        ///RESPONSE n09 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n09 1 I have to run too. With this map I can lead us until you get better. And one can watch while the other sleeps.\n
        response.Text = "I have to run too. With this map I can lead us until you get better. And one can watch while the other sleeps.\n";
        ///RESPONSE_NEXT_NODE_TYPE n09 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n09 1 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n09
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 Going south to Lexington sounds like the wrong way. But I trust Esther, she knows lots of folks in town and hears everything.\n
        prompt.Text = "Going south to Lexington sounds like the wrong way. But I trust Esther, she knows lots of folks in town and hears everything.\n";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 I think we'll be safer if we don't run together. Folks will be suspicious of two Negroes traveling together.\n
        response.Text = "I think we'll be safer if we don't run together. Folks will be suspicious of two Negroes traveling together.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n19
        response.NextNodeId = "n19";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 So we run together. I'll lead us until you get better. And one can watch while the other sleeps.\n
        response.Text = "So we run together. I'll lead us until you get better. And one can watch while the other sleeps.\n";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 Yeah, that's probably the truth. I'm hurting mighty bad.
        prompt.Text = "Yeah, that's probably the truth. I'm hurting mighty bad.";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 Then what's your plan?\n
        response.Text = "Then what's your plan?\n";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 That's what I thought. You don't have a plan. I better get started, gotta lot to do before the moon is high.\n
        prompt.Text = "That's what I thought. You don't have a plan. I better get started, gotta lot to do before the moon is high.\n";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 I'm still going to run. Good luck. Maybe I'll see you on the other side of the river.\n
        response.Text = "I'm still going to run. Good luck. Maybe I'll see you on the other side of the river.\n";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 END
        response.NextNodeId = "END";
        response.OnSelect(n12_r0_select);
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Full
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n13~|||~
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 Lucy, you're braver than most. But you'll need more than that. Most folks don't make it.\n
        prompt.Text = "Lucy, you're braver than most. But you'll need more than that. Most folks don't make it.\n";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 I'll be fine. Maybe I'll see you on the other side of the river.\n
        response.Text = "I'll be fine. Maybe I'll see you on the other side of the river.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 END
        response.NextNodeId = "END";
        response.OnSelect(n13_r0_select);
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 You'll see Henry. I'm fast and strong. I'll make it across that river before you.\n
        response.Text = "You'll see Henry. I'm fast and strong. I'll make it across that river before you.\n";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n11
        response.NextNodeId = "n11";
        
        ///RESPONSE n13 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 2 What's your plan?
        response.Text = "What's your plan?";
        ///RESPONSE_NEXT_NODE_TYPE n13 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 2 n06
        response.NextNodeId = "n06";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Full
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n14~|||~
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 Esther told me about it. She heard tell from a cousin of hers who knows someone who made it across the river.
        prompt.Text = "Esther told me about it. She heard tell from a cousin of hers who knows someone who made it across the river.";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 That sounds like a good plan. But it doesn't sound like you want help. I'm still going to run though. Good luck.\n
        response.Text = "That sounds like a good plan. But it doesn't sound like you want help. I'm still going to run though. Good luck.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 END
        response.NextNodeId = "END";
        response.OnSelect(n14_r0_select);
        
        ///RESPONSE n14 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 1 That sounds like a story to me. I have a better plan.\n
        response.Text = "That sounds like a story to me. I have a better plan.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 1 n08
        response.NextNodeId = "n08";
        
        ///RESPONSE n14 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 2 Esther told me about a church in Lexington. They help runaway slaves get north.\n
        response.Text = "Esther told me about a church in Lexington. They help runaway slaves get north.\n";
        ///RESPONSE_NEXT_NODE_TYPE n14 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 2 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n14
        ///NODE_START n15
        node = dialog.CreateNode("n15");
        ///NODE_NPC n15 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n15 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n15 Full
        ///NODE_VISUAL_USESCRIPT n15 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n15~|||~
        ///PROMPT n15 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n15 0 Your papa is a good man. Now I'm sure he can help. But that might be the first place they look for you.\n
        prompt.Text = "Your papa is a good man. Now I'm sure he can help. But that might be the first place they look for you.\n";
        ///PROMPT_IGNORE_VO n15 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n15 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 0 I won't be staying long. But I have to say goodbye to him.\n
        response.Text = "I won't be staying long. But I have to say goodbye to him.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 0 n18
        response.NextNodeId = "n18";
        
        ///RESPONSE n15 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n15 1 Sarah said Master and the whole family will be away a few days. They won't be able to start looking for us right away.\n
        response.Text = "Sarah said Master and the whole family will be away a few days. They won't be able to start looking for us right away.\n";
        ///RESPONSE_NEXT_NODE_TYPE n15 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n15 1 n17
        response.NextNodeId = "n17";
        response.SetCondition(n15_r1_condition);
        
        ///NODE_END n15
        ///NODE_START n16
        node = dialog.CreateNode("n16");
        ///NODE_NPC n16 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n16 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n16 Full
        ///NODE_VISUAL_USESCRIPT n16 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n16~|||~
        ///PROMPT n16 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n16 0 That sounds like a smart idea. Meet me by the creek when the moon is high and we'll go. Find as much food as you can. We'll need it.\n
        prompt.Text = "That sounds like a smart idea. Meet me by the creek when the moon is high and we'll go. Find as much food as you can. We'll need it.\n";
        ///PROMPT_IGNORE_VO n16 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n16 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n16 0 I'll meet you there.\n
        response.Text = "I'll meet you there.\n";
        ///RESPONSE_NEXT_NODE_TYPE n16 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n16 0 END
        response.NextNodeId = "END";
        response.OnSelect(n16_r0_select);
        
        ///NODE_END n16
        ///NODE_START n17
        node = dialog.CreateNode("n17");
        ///NODE_NPC n17 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n17 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n17 Full
        ///NODE_VISUAL_USESCRIPT n17 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n17~|||~
        ///PROMPT n17 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n17 0 A few days you say. You may be right.
        prompt.Text = "A few days you say. You may be right.";
        ///PROMPT_IGNORE_VO n17 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n17 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 0 That's my plan. You got your plan. Safer if we don't run together. Folks will be more suspicious of two slaves.\n
        response.Text = "That's my plan. You got your plan. Safer if we don't run together. Folks will be more suspicious of two slaves.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 0 n19
        response.NextNodeId = "n19";
        
        ///RESPONSE n17 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n17 1 So we run together. I'll lead us until you get better. And one can watch while the other sleeps.\n
        response.Text = "So we run together. I'll lead us until you get better. And one can watch while the other sleeps.\n";
        ///RESPONSE_NEXT_NODE_TYPE n17 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n17 1 n16
        response.NextNodeId = "n16";
        
        ///NODE_END n17
        ///NODE_START n18
        node = dialog.CreateNode("n18");
        ///NODE_NPC n18 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n18 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n18 Full
        ///NODE_VISUAL_USESCRIPT n18 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n18~|||~
        ///PROMPT n18 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n18 0 I don't have time for goodbyes. I hope you make it though. I better get started, gotta lot to do before the moon is high.\n
        prompt.Text = "I don't have time for goodbyes. I hope you make it though. I better get started, gotta lot to do before the moon is high.\n";
        ///PROMPT_IGNORE_VO n18 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n18 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n18 0 I'll be fine. Maybe I'll see you on the other side of the river.\n
        response.Text = "I'll be fine. Maybe I'll see you on the other side of the river.\n";
        ///RESPONSE_NEXT_NODE_TYPE n18 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n18 0 END
        response.NextNodeId = "END";
        response.OnSelect(n18_r0_select);
        
        ///NODE_END n18
        ///NODE_START n19
        node = dialog.CreateNode("n19");
        ///NODE_NPC n19 HEN
        node.Npc = "HEN";
        ///NODE_RANDOM_RESPONSES n19 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n19 Full
        ///NODE_VISUAL_USESCRIPT n19 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n19~|||~
        ///PROMPT n19 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n19 0 That's true. I better get started, gotta lot to do before the moon is high. Good luck to you, Lucy.\n
        prompt.Text = "That's true. I better get started, gotta lot to do before the moon is high. Good luck to you, Lucy.\n";
        ///PROMPT_IGNORE_VO n19 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n19 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n19 0 Good luck to you.
        response.Text = "Good luck to you.";
        ///RESPONSE_NEXT_NODE_TYPE n19 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n19 0 END
        response.NextNodeId = "END";
        response.OnSelect(n19_r0_select);
        
        ///NODE_END n19
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n08_r1_condition
    public bool n08_r1_condition (  ) {
        ///METHOD_BODY_START n08_r1_condition
        /*//if (?know_lexington)*/
        return true;
        ///METHOD_BODY_END n08_r1_condition
    }

    ///METHOD n08_r2_condition
    public bool n08_r2_condition (  ) {
        ///METHOD_BODY_START n08_r2_condition
        /*//if (hasItem("invitation"))*/
        return true;
        ///METHOD_BODY_END n08_r2_condition
    }

    ///METHOD n15_r1_condition
    public bool n15_r1_condition (  ) {
        ///METHOD_BODY_START n15_r1_condition
        /*//if (?know_king_time)*/
        return true;
        ///METHOD_BODY_END n15_r1_condition
    }

    ///METHOD n12_r0_select
    public void n12_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n12_r0_select
        /*//set $escape_type = "alone"
        //wait(2000)*/
        ///METHOD_BODY_END n12_r0_select
    }

    ///METHOD n13_r0_select
    public void n13_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n13_r0_select
        /*//set $escape_type = "alone"
        //wait(2000)*/
        ///METHOD_BODY_END n13_r0_select
    }

    ///METHOD n14_r0_select
    public void n14_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n14_r0_select
        /*//set $escape_type = "alone"
        //wait(2000)*/
        ///METHOD_BODY_END n14_r0_select
    }

    ///METHOD n16_r0_select
    public void n16_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n16_r0_select
        /*//set $escape_type = "henry"*/
        ///METHOD_BODY_END n16_r0_select
    }

    ///METHOD n18_r0_select
    public void n18_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n18_r0_select
        /*//set $escape_type = "alone"
        //wait(2000)*/
        ///METHOD_BODY_END n18_r0_select
    }

    ///METHOD n19_r0_select
    public void n19_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n19_r0_select
        /*//set $escape_type = "alone"
        //wait(2000)*/
        ///METHOD_BODY_END n19_r0_select
    }
}
//CLASS_END Dialog_p1_hen_001
