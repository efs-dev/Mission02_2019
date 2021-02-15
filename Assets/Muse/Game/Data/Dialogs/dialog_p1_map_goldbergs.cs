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
//CLASS Dialog_p1_map_goldbergs
public class Dialog_p1_map_goldbergs {
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
        ///DIALOG_ID p1_map_goldbergs
        var dialog = new Dialog();
        dialog.Id = "p1_map_goldbergs";
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
        ///NODE_VISUAL_TYPE n01 Popup
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n01~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 [Sign] Goldberg's .... The Complete Shoe Store
        prompt.Text = "[Sign] Goldberg's .... The Complete Shoe Store";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Keep walking]
        response.Text = "[Keep walking]";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 [Enter the store]
        response.Text = "[Enter the store]";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n02
        response.NextNodeId = "n02";
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 Addie
        node.Npc = "Addie";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Popup
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n02~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 We sit here and wait for the clerk. Do you know what you want?
        prompt.Text = "We sit here and wait for the clerk. Do you know what you want?";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 Depends on the price.
        response.Text = "Depends on the price.";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 Can I look at the different styles?
        response.Text = "Can I look at the different styles?";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n03
        response.NextNodeId = "n03";
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 Addie
        node.Npc = "Addie";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Popup
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n03~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 This discount wall is over there.
        prompt.Text = "This discount wall is over there.";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 >>to shoe wall
        response.Text = ">>to shoe wall";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n04
        response.NextNodeId = "n04";
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Popup
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n04~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 [Shoe Wall]\nSelect a shoe to learn more about it.
        prompt.Text = "[Shoe Wall]\nSelect a shoe to learn more about it.";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 [Return to Addie]
        response.Text = "[Return to Addie]";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n04 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 1 [Saddle Shoes]
        response.Text = "[Saddle Shoes]";
        ///RESPONSE_NEXT_NODE_TYPE n04 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 1 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n04 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 2 [Mary Janes]
        response.Text = "[Mary Janes]";
        ///RESPONSE_NEXT_NODE_TYPE n04 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 2 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n04 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 3 [Penny Loafers]
        response.Text = "[Penny Loafers]";
        ///RESPONSE_NEXT_NODE_TYPE n04 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 3 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n04 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 4 [Pointed Flatties]
        response.Text = "[Pointed Flatties]";
        ///RESPONSE_NEXT_NODE_TYPE n04 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 4 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Popup
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n05~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 Cute but uncomfortable...and you'll have to polish them every night to keep them sparkling white.
        prompt.Text = "Cute but uncomfortable...and you'll have to polish them every night to keep them sparkling white.";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 [Check price]
        response.Text = "[Check price]";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n12
        response.NextNodeId = "n12";
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 [Return to shoe wall]
        response.Text = "[Return to shoe wall]";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Popup
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n06~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 Just like your old shoes.
        prompt.Text = "Just like your old shoes.";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [Check price]
        response.Text = "[Check price]";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n11
        response.NextNodeId = "n11";
        
        ///RESPONSE n06 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 1 [Return to shoe wall]
        response.Text = "[Return to shoe wall]";
        ///RESPONSE_NEXT_NODE_TYPE n06 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Popup
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n07~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 Comfortable, but still look neat and stylish.
        prompt.Text = "Comfortable, but still look neat and stylish.";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 [Check price]
        response.Text = "[Check price]";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n13
        response.NextNodeId = "n13";
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 [Return to shoe wall]
        response.Text = "[Return to shoe wall]";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Popup
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n08~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 Trendy … but can they hold up to lots of walking?
        prompt.Text = "Trendy … but can they hold up to lots of walking?";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 [Check price]
        response.Text = "[Check price]";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 n14
        response.NextNodeId = "n14";
        
        ///RESPONSE n08 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 1 [Return to shoe wall]
        response.Text = "[Return to shoe wall]";
        ///RESPONSE_NEXT_NODE_TYPE n08 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 1 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n08
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Popup
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n10~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 [You look over all the shoes.]
        prompt.Text = "[You look over all the shoes.]";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 [Return to Addie]
        response.Text = "[Return to Addie]";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n20
        response.NextNodeId = "n20";
        
        ///RESPONSE n10 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 1 [Saddle shoes]
        response.Text = "[Saddle shoes]";
        ///RESPONSE_NEXT_NODE_TYPE n10 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 1 n05
        response.NextNodeId = "n05";
        
        ///RESPONSE n10 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 2 [Mary Janes]
        response.Text = "[Mary Janes]";
        ///RESPONSE_NEXT_NODE_TYPE n10 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 2 n06
        response.NextNodeId = "n06";
        
        ///RESPONSE n10 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 3 [Loafers]
        response.Text = "[Loafers]";
        ///RESPONSE_NEXT_NODE_TYPE n10 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 3 n07
        response.NextNodeId = "n07";
        
        ///RESPONSE n10 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 4 [Flatties]
        response.Text = "[Flatties]";
        ///RESPONSE_NEXT_NODE_TYPE n10 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 4 n08
        response.NextNodeId = "n08";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Popup
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n11~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 $2.75. You have [remaining money] to spend today.
        prompt.Text = "$2.75. You have [remaining money] to spend today.";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 [Return to shoe wall]
        response.Text = "[Return to shoe wall]";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 [Select this shoe]
        response.Text = "[Select this shoe]";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n20
        response.NextNodeId = "n20";
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Popup
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n12~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 $3.00. You have [remaining money] to spend today.
        prompt.Text = "$3.00. You have [remaining money] to spend today.";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 [Return to shoe wall]
        response.Text = "[Return to shoe wall]";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n12 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 1 [Select this shoe]
        response.Text = "[Select this shoe]";
        ///RESPONSE_NEXT_NODE_TYPE n12 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 1 n20
        response.NextNodeId = "n20";
        
        ///NODE_END n12
        ///NODE_START n13
        node = dialog.CreateNode("n13");
        ///NODE_NPC n13 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n13 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n13 Popup
        ///NODE_VISUAL_USESCRIPT n13 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n13~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n13 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n13 0 $3.00. You have [remaining money] to spend today.
        prompt.Text = "$3.00. You have [remaining money] to spend today.";
        ///PROMPT_IGNORE_VO n13 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n13 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 0 [Return to shoe wall]
        response.Text = "[Return to shoe wall]";
        ///RESPONSE_NEXT_NODE_TYPE n13 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 0 n10
        response.NextNodeId = "n10";
        
        ///RESPONSE n13 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n13 1 [Select this shoe]
        response.Text = "[Select this shoe]";
        ///RESPONSE_NEXT_NODE_TYPE n13 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n13 1 n20
        response.NextNodeId = "n20";
        
        ///NODE_END n13
        ///NODE_START n14
        node = dialog.CreateNode("n14");
        ///NODE_NPC n14 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n14 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n14 Popup
        ///NODE_VISUAL_USESCRIPT n14 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n14~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n14 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n14 0 $3.50. You have [remaining money] to spend today.
        prompt.Text = "$3.50. You have [remaining money] to spend today.";
        ///PROMPT_IGNORE_VO n14 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n14 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n14 0 [Too expensive; return to shoe wall]
        response.Text = "[Too expensive; return to shoe wall]";
        ///RESPONSE_NEXT_NODE_TYPE n14 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n14 0 n10
        response.NextNodeId = "n10";
        
        ///NODE_END n14
        ///NODE_START n20
        node = dialog.CreateNode("n20");
        ///NODE_NPC n20 Addie
        node.Npc = "Addie";
        ///NODE_RANDOM_RESPONSES n20 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n20 Popup
        ///NODE_VISUAL_USESCRIPT n20 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n20~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n20 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n20 0 Find what you were looking for?
        prompt.Text = "Find what you were looking for?";
        ///PROMPT_IGNORE_VO n20 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n20 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 0 Not really. The selection is limited.
        response.Text = "Not really. The selection is limited.";
        ///RESPONSE_NEXT_NODE_TYPE n20 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 0 n21
        response.NextNodeId = "n21";
        response.SetCondition(n20_r0_condition);
        
        ///RESPONSE n20 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n20 1 Yes, I like the [selected shoe]
        response.Text = "Yes, I like the [selected shoe]";
        ///RESPONSE_NEXT_NODE_TYPE n20 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n20 1 n21
        response.NextNodeId = "n21";
        response.SetCondition(n20_r1_condition);
        
        ///NODE_END n20
        ///NODE_START n21
        node = dialog.CreateNode("n21");
        ///NODE_NPC n21 Clerk
        node.Npc = "Clerk";
        ///NODE_RANDOM_RESPONSES n21 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n21 Popup
        ///NODE_VISUAL_USESCRIPT n21 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n21~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n21 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n21 0 How can I help you girls today?
        prompt.Text = "How can I help you girls today?";
        ///PROMPT_IGNORE_VO n21 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n21 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 0 I'd like to try [shoe], please, ma'am, but I'm not sure what size.
        response.Text = "I'd like to try [shoe], please, ma'am, but I'm not sure what size.";
        ///RESPONSE_NEXT_NODE_TYPE n21 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 0 n22
        response.NextNodeId = "n22";
        response.SetCondition(n21_r0_condition);
        
        ///RESPONSE n21 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n21 1 What do you reccomend--the loafer or the flatties?
        response.Text = "What do you reccomend--the loafer or the flatties?";
        ///RESPONSE_NEXT_NODE_TYPE n21 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n21 1 n26
        response.NextNodeId = "n26";
        response.SetCondition(n21_r1_condition);
        
        ///NODE_END n21
        ///NODE_START n22
        node = dialog.CreateNode("n22");
        ///NODE_NPC n22 Clerk
        node.Npc = "Clerk";
        ///NODE_RANDOM_RESPONSES n22 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n22 Popup
        ///NODE_VISUAL_USESCRIPT n22 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n22~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n22 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n22 0 Why don't I take your measurements?
        prompt.Text = "Why don't I take your measurements?";
        ///PROMPT_IGNORE_VO n22 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n22 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n22 0 That would be a help, thank you.
        response.Text = "That would be a help, thank you.";
        ///RESPONSE_NEXT_NODE_TYPE n22 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n22 0 n23
        response.NextNodeId = "n23";
        
        ///NODE_END n22
        ///NODE_START n23
        node = dialog.CreateNode("n23");
        ///NODE_NPC n23 Clerk
        node.Npc = "Clerk";
        ///NODE_RANDOM_RESPONSES n23 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n23 Popup
        ///NODE_VISUAL_USESCRIPT n23 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n23~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n23 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n23 0 The clerk measures your foot and returns with two sizes, just to be sure. She waits for you to try them on.
        prompt.Text = "The clerk measures your foot and returns with two sizes, just to be sure. She waits for you to try them on.";
        ///PROMPT_IGNORE_VO n23 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n23 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n23 0 [Try on shoes]
        response.Text = "[Try on shoes]";
        ///RESPONSE_NEXT_NODE_TYPE n23 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n23 0 n24
        response.NextNodeId = "n24";
        
        ///NODE_END n23
        ///NODE_START n24
        node = dialog.CreateNode("n24");
        ///NODE_NPC n24 
        node.Npc = "";
        ///NODE_RANDOM_RESPONSES n24 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n24 Popup
        ///NODE_VISUAL_USESCRIPT n24 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n24~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n24 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n24 0 The size 7 shoe pinches, but the size 8 is just right. Good thing you tried them on.
        prompt.Text = "The size 7 shoe pinches, but the size 8 is just right. Good thing you tried them on.";
        ///PROMPT_IGNORE_VO n24 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n24 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 0 [Ready to pay] I'll take the 8, thank you.
        response.Text = "[Ready to pay] I'll take the 8, thank you.";
        ///RESPONSE_NEXT_NODE_TYPE n24 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 0 n30
        response.NextNodeId = "n30";
        
        ///RESPONSE n24 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n24 1 [Hesitating over the price] Is this shoe on sale today?
        response.Text = "[Hesitating over the price] Is this shoe on sale today?";
        ///RESPONSE_NEXT_NODE_TYPE n24 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n24 1 n25
        response.NextNodeId = "n25";
        
        ///NODE_END n24
        ///NODE_START n25
        node = dialog.CreateNode("n25");
        ///NODE_NPC n25 Clerk
        node.Npc = "Clerk";
        ///NODE_RANDOM_RESPONSES n25 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n25 Popup
        ///NODE_VISUAL_USESCRIPT n25 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n25~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n25 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n25 0 Price as marked, I'm afraid. Do you still want them?
        prompt.Text = "Price as marked, I'm afraid. Do you still want them?";
        ///PROMPT_IGNORE_VO n25 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n25 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 0 Yes ma'am.
        response.Text = "Yes ma'am.";
        ///RESPONSE_NEXT_NODE_TYPE n25 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 0 n40
        response.NextNodeId = "n40";
        
        ///RESPONSE n25 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n25 1 Let me think about it.
        response.Text = "Let me think about it.";
        ///RESPONSE_NEXT_NODE_TYPE n25 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n25 1 n40
        response.NextNodeId = "n40";
        
        ///NODE_END n25
        ///NODE_START n26
        node = dialog.CreateNode("n26");
        ///NODE_NPC n26 Clerk
        node.Npc = "Clerk";
        ///NODE_RANDOM_RESPONSES n26 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n26 Popup
        ///NODE_VISUAL_USESCRIPT n26 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n26~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n26 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n26 0 Let me think. Is this for school? I see all the girls wear penny loafers, and this pair would suit you well.
        prompt.Text = "Let me think. Is this for school? I see all the girls wear penny loafers, and this pair would suit you well.";
        ///PROMPT_IGNORE_VO n26 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n26 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n26 0 Thanks, I'll take the loafers.
        response.Text = "Thanks, I'll take the loafers.";
        ///RESPONSE_NEXT_NODE_TYPE n26 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n26 0 n40
        response.NextNodeId = "n40";
        
        ///NODE_END n26
        ///NODE_START n30
        node = dialog.CreateNode("n30");
        ///NODE_NPC n30 Clerk
        node.Npc = "Clerk";
        ///NODE_RANDOM_RESPONSES n30 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n30 Popup
        ///NODE_VISUAL_USESCRIPT n30 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n30~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n30 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n30 0 Meet me at the register when you are ready.
        prompt.Text = "Meet me at the register when you are ready.";
        ///PROMPT_IGNORE_VO n30 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n30 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 0 [Follow her to the register]
        response.Text = "[Follow her to the register]";
        ///RESPONSE_NEXT_NODE_TYPE n30 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 0 n31
        response.NextNodeId = "n31";
        
        ///RESPONSE n30 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n30 1 Addie, these cost more than half of my budget. Is there anywhere shoes will be on sale?
        response.Text = "Addie, these cost more than half of my budget. Is there anywhere shoes will be on sale?";
        ///RESPONSE_NEXT_NODE_TYPE n30 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n30 1 n40
        response.NextNodeId = "n40";
        
        ///NODE_END n30
        ///NODE_START n31
        node = dialog.CreateNode("n31");
        ///NODE_NPC n31 Clerk
        node.Npc = "Clerk";
        ///NODE_RANDOM_RESPONSES n31 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n31 Popup
        ///NODE_VISUAL_USESCRIPT n31 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n31~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n31 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n31 0 That will be [$2.75/$3.00].
        prompt.Text = "That will be [$2.75/$3.00].";
        ///PROMPT_IGNORE_VO n31 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n31 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n31 0 [You hand the money to the clerk]
        response.Text = "[You hand the money to the clerk]";
        ///RESPONSE_NEXT_NODE_TYPE n31 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n31 0 n32
        response.NextNodeId = "n32";
        
        ///NODE_END n31
        ///NODE_START n32
        node = dialog.CreateNode("n32");
        ///NODE_NPC n32 Clerk
        node.Npc = "Clerk";
        ///NODE_RANDOM_RESPONSES n32 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n32 Popup
        ///NODE_VISUAL_USESCRIPT n32 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n32~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n32 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n32 0 I'm glad you picked the [shoe], it looks great. Have a nice day.
        prompt.Text = "I'm glad you picked the [shoe], it looks great. Have a nice day.";
        ///PROMPT_IGNORE_VO n32 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n32 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n32 0 >>>back to map
        response.Text = ">>>back to map";
        ///RESPONSE_NEXT_NODE_TYPE n32 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n32 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n32
        ///NODE_START n40
        node = dialog.CreateNode("n40");
        ///NODE_NPC n40 Addie
        node.Npc = "Addie";
        ///NODE_RANDOM_RESPONSES n40 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n40 Popup
        ///NODE_VISUAL_USESCRIPT n40 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n40~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n40 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n40 0 There's a discount shoe shop over on [street], but the clerk will treat us like something the cat dragged in.  Don't give a business like that your Grandmother's savings.
        prompt.Text = "There's a discount shoe shop over on [street], but the clerk will treat us like something the cat dragged in.  Don't give a business like that your Grandmother's savings.";
        ///PROMPT_IGNORE_VO n40 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n40 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n40 0 What's the worst that can happen? At least I'll have some of my Grandmother's money left...
        response.Text = "What's the worst that can happen? At least I'll have some of my Grandmother's money left...";
        ///RESPONSE_NEXT_NODE_TYPE n40 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n40 0 n41
        response.NextNodeId = "n41";
        
        ///RESPONSE n40 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n40 1 You're right, I'll get the shoes here. [Go to the register]
        response.Text = "You're right, I'll get the shoes here. [Go to the register]";
        ///RESPONSE_NEXT_NODE_TYPE n40 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n40 1 n31
        response.NextNodeId = "n31";
        
        ///NODE_END n40
        ///NODE_START n41
        node = dialog.CreateNode("n41");
        ///NODE_NPC n41 Addie
        node.Npc = "Addie";
        ///NODE_RANDOM_RESPONSES n41 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n41 Popup
        ///NODE_VISUAL_USESCRIPT n41 false
        node.VisualDataType = "popup";
        ///NODE_VISUAL_DATA~|||~n41~|||~Header~||~~|~ImagePath~||~
        node.VisualData.Add("Header", "");
        node.VisualData.Add("ImagePath", "");
        ///PROMPT n41 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n41 0 Suit yourself.
        prompt.Text = "Suit yourself.";
        ///PROMPT_IGNORE_VO n41 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n41 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n41 0 [Return the shoes to the sales clerk and leave.]
        response.Text = "[Return the shoes to the sales clerk and leave.]";
        ///RESPONSE_NEXT_NODE_TYPE n41 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n41 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n41
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n20_r0_condition
    public bool n20_r0_condition (  ) {
        ///METHOD_BODY_START n20_r0_condition
        /*//if no selection*/
        return true;
        ///METHOD_BODY_END n20_r0_condition
    }

    ///METHOD n20_r1_condition
    public bool n20_r1_condition (  ) {
        ///METHOD_BODY_START n20_r1_condition
        /*//based on selection*/
        return true;
        ///METHOD_BODY_END n20_r1_condition
    }

    ///METHOD n21_r0_condition
    public bool n21_r0_condition (  ) {
        ///METHOD_BODY_START n21_r0_condition
        /*//if selected shoe*/
        return true;
        ///METHOD_BODY_END n21_r0_condition
    }

    ///METHOD n21_r1_condition
    public bool n21_r1_condition (  ) {
        ///METHOD_BODY_START n21_r1_condition
        /*//if no shoe selected*/
        return true;
        ///METHOD_BODY_END n21_r1_condition
    }
}
//CLASS_END Dialog_p1_map_goldbergs
