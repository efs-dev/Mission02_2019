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
//CLASS Dialog_p2_lex_001
public class Dialog_p2_lex_001 {
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
        ///DIALOG_ID p2_lex_001
        var dialog = new Dialog();
        dialog.Id = "p2_lex_001";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 You travel south and arrive in the busy city of Lexington.
        prompt.Text = "You travel south and arrive in the busy city of Lexington.";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 Leave right away.
        response.Text = "Leave right away.";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 [Esther's Advice] Find St. Paul's church and ask there for help.
        response.Text = "[Esther's Advice] Find St. Paul's church and ask there for help.";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 CHURCH
        response.NextNodeId = "CHURCH";
        response.SetCondition(n01_r1_condition);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 Explore the city hoping to discover something useful.
        response.Text = "Explore the city hoping to discover something useful.";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 END
        response.NextNodeId = "END";
        response.OnSelect(n01_r2_select);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 Approach other slaves and appeal to them for help.
        response.Text = "Approach other slaves and appeal to them for help.";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 
        response.NextNodeId = "";
        response.OnSelect(n01_r3_select);
        
        ///NODE_END n01
        ///NODE_START STUMBLE
        node = dialog.CreateNode("STUMBLE");
        ///NODE_NPC STUMBLE LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES STUMBLE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE STUMBLE Full
        ///NODE_VISUAL_USESCRIPT STUMBLE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~STUMBLE~|||~
        ///PROMPT STUMBLE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT STUMBLE 0 You see a minister standing outside a small building with a cross on it. \"You look lost, child. Perhaps I can help\". He invites you in.
        prompt.Text = "You see a minister standing outside a small building with a cross on it. \"You look lost, child. Perhaps I can help\". He invites you in.";
        ///PROMPT_IGNORE_VO STUMBLE 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE STUMBLE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT STUMBLE 0 Politely leave.
        response.Text = "Politely leave.";
        ///RESPONSE_NEXT_NODE_TYPE STUMBLE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID STUMBLE 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE STUMBLE 1
        response = node.AddResponse();
        ///RESPONSE_TEXT STUMBLE 1 Enter the church.
        response.Text = "Enter the church.";
        ///RESPONSE_NEXT_NODE_TYPE STUMBLE 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID STUMBLE 1 CHURCH
        response.NextNodeId = "CHURCH";
        
        ///NODE_END STUMBLE
        ///NODE_START CREEPY
        node = dialog.CreateNode("CREEPY");
        ///NODE_NPC CREEPY LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES CREEPY False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CREEPY Full
        ///NODE_VISUAL_USESCRIPT CREEPY false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CREEPY~|||~
        ///PROMPT CREEPY 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CREEPY 0 After awhile of roaming the streets, you realize you are being followed by a haggard white man.
        prompt.Text = "After awhile of roaming the streets, you realize you are being followed by a haggard white man.";
        ///PROMPT_IGNORE_VO CREEPY 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE CREEPY 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CREEPY 0 Quickly leave Lexington.
        response.Text = "Quickly leave Lexington.";
        ///RESPONSE_NEXT_NODE_TYPE CREEPY 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CREEPY 0 END
        response.NextNodeId = "END";
        
        ///NODE_END CREEPY
        ///NODE_START NO_GOOD
        node = dialog.CreateNode("NO_GOOD");
        ///NODE_NPC NO_GOOD LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES NO_GOOD False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE NO_GOOD Full
        ///NODE_VISUAL_USESCRIPT NO_GOOD false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~NO_GOOD~|||~
        ///PROMPT NO_GOOD 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT NO_GOOD 0 You spend the whole day roaming the streets, but don't come upon anything helpful. There are many slavecatchers about. It's too dangerous to stay.
        prompt.Text = "You spend the whole day roaming the streets, but don't come upon anything helpful. There are many slavecatchers about. It's too dangerous to stay.";
        ///PROMPT_IGNORE_VO NO_GOOD 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(NO_GOOD_p0_show);
        
        ///RESPONSE NO_GOOD 0
        response = node.AddResponse();
        ///RESPONSE_TEXT NO_GOOD 0 Leave Lexington.
        response.Text = "Leave Lexington.";
        ///RESPONSE_NEXT_NODE_TYPE NO_GOOD 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID NO_GOOD 0 END
        response.NextNodeId = "END";
        
        ///NODE_END NO_GOOD
        ///NODE_START FOOD_HELP
        node = dialog.CreateNode("FOOD_HELP");
        ///NODE_NPC FOOD_HELP LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES FOOD_HELP False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE FOOD_HELP Full
        ///NODE_VISUAL_USESCRIPT FOOD_HELP false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~FOOD_HELP~|||~
        ///PROMPT FOOD_HELP 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT FOOD_HELP 0 A slave carrying an enormous basket of bread gives you a couple of extra loaves.
        prompt.Text = "A slave carrying an enormous basket of bread gives you a couple of extra loaves.";
        ///PROMPT_IGNORE_VO FOOD_HELP 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(FOOD_HELP_p0_show);
        
        ///RESPONSE FOOD_HELP 0
        response = node.AddResponse();
        ///RESPONSE_TEXT FOOD_HELP 0 Thank him kindly and leave.
        response.Text = "Thank him kindly and leave.";
        ///RESPONSE_NEXT_NODE_TYPE FOOD_HELP 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID FOOD_HELP 0 END
        response.NextNodeId = "END";
        
        ///NODE_END FOOD_HELP
        ///NODE_START SCARED
        node = dialog.CreateNode("SCARED");
        ///NODE_NPC SCARED LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES SCARED False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE SCARED Full
        ///NODE_VISUAL_USESCRIPT SCARED false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~SCARED~|||~
        ///PROMPT SCARED 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT SCARED 0 The slaves you approach are all too scared to help you.
        prompt.Text = "The slaves you approach are all too scared to help you.";
        ///PROMPT_IGNORE_VO SCARED 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE SCARED 0
        response = node.AddResponse();
        ///RESPONSE_TEXT SCARED 0 Leave.
        response.Text = "Leave.";
        ///RESPONSE_NEXT_NODE_TYPE SCARED 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID SCARED 0 END
        response.NextNodeId = "END";
        
        ///NODE_END SCARED
        ///NODE_START BAD_HELP
        node = dialog.CreateNode("BAD_HELP");
        ///NODE_NPC BAD_HELP LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES BAD_HELP False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE BAD_HELP Full
        ///NODE_VISUAL_USESCRIPT BAD_HELP false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~BAD_HELP~|||~
        ///PROMPT BAD_HELP 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT BAD_HELP 0 A slave woman tells you she knows someone who can help you.
        prompt.Text = "A slave woman tells you she knows someone who can help you.";
        ///PROMPT_IGNORE_VO BAD_HELP 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE BAD_HELP 0
        response = node.AddResponse();
        ///RESPONSE_TEXT BAD_HELP 0 Politely leave.
        response.Text = "Politely leave.";
        ///RESPONSE_NEXT_NODE_TYPE BAD_HELP 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BAD_HELP 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE BAD_HELP 1
        response = node.AddResponse();
        ///RESPONSE_TEXT BAD_HELP 1 Go with her.
        response.Text = "Go with her.";
        ///RESPONSE_NEXT_NODE_TYPE BAD_HELP 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID BAD_HELP 1 CAUGHT
        response.NextNodeId = "CAUGHT";
        
        ///NODE_END BAD_HELP
        ///NODE_START CAUGHT
        node = dialog.CreateNode("CAUGHT");
        ///NODE_NPC CAUGHT LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES CAUGHT False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CAUGHT Full
        ///NODE_VISUAL_USESCRIPT CAUGHT false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CAUGHT~|||~
        ///PROMPT CAUGHT 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CAUGHT 0 She brings you through many streets and alleys... right up to a group of slave catchers! She betrayed you to gain favor with her master!
        prompt.Text = "She brings you through many streets and alleys... right up to a group of slave catchers! She betrayed you to gain favor with her master!";
        ///PROMPT_IGNORE_VO CAUGHT 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE CAUGHT 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CAUGHT 0 [More]
        response.Text = "[More]";
        ///RESPONSE_NEXT_NODE_TYPE CAUGHT 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CAUGHT 0 END
        response.NextNodeId = "END";
        response.OnSelect(CAUGHT_r0_select);
        
        ///NODE_END CAUGHT
        ///NODE_START GOOD_HELP
        node = dialog.CreateNode("GOOD_HELP");
        ///NODE_NPC GOOD_HELP LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES GOOD_HELP False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE GOOD_HELP Full
        ///NODE_VISUAL_USESCRIPT GOOD_HELP false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~GOOD_HELP~|||~
        ///PROMPT GOOD_HELP 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT GOOD_HELP 0 A slave woman tells you she knows someone who can help you.
        prompt.Text = "A slave woman tells you she knows someone who can help you.";
        ///PROMPT_IGNORE_VO GOOD_HELP 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE GOOD_HELP 0
        response = node.AddResponse();
        ///RESPONSE_TEXT GOOD_HELP 0 Politely leave.
        response.Text = "Politely leave.";
        ///RESPONSE_NEXT_NODE_TYPE GOOD_HELP 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID GOOD_HELP 0 END
        response.NextNodeId = "END";
        
        ///RESPONSE GOOD_HELP 1
        response = node.AddResponse();
        ///RESPONSE_TEXT GOOD_HELP 1 Go with her.
        response.Text = "Go with her.";
        ///RESPONSE_NEXT_NODE_TYPE GOOD_HELP 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID GOOD_HELP 1 TO_CHURCH
        response.NextNodeId = "TO_CHURCH";
        
        ///NODE_END GOOD_HELP
        ///NODE_START TO_CHURCH
        node = dialog.CreateNode("TO_CHURCH");
        ///NODE_NPC TO_CHURCH LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES TO_CHURCH False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE TO_CHURCH Full
        ///NODE_VISUAL_USESCRIPT TO_CHURCH false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~TO_CHURCH~|||~
        ///PROMPT TO_CHURCH 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT TO_CHURCH 0 She brings you to St. Paul's church. She tells you to go in and wishes you luck.
        prompt.Text = "She brings you to St. Paul's church. She tells you to go in and wishes you luck.";
        ///PROMPT_IGNORE_VO TO_CHURCH 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE TO_CHURCH 0
        response = node.AddResponse();
        ///RESPONSE_TEXT TO_CHURCH 0 Thank her and go in.
        response.Text = "Thank her and go in.";
        ///RESPONSE_NEXT_NODE_TYPE TO_CHURCH 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID TO_CHURCH 0 CHURCH
        response.NextNodeId = "CHURCH";
        
        ///NODE_END TO_CHURCH
        ///NODE_START CHURCH
        node = dialog.CreateNode("CHURCH");
        ///NODE_NPC CHURCH LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES CHURCH False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE CHURCH Full
        ///NODE_VISUAL_USESCRIPT CHURCH false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~CHURCH~|||~
        ///PROMPT CHURCH 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CHURCH 0 The minister in the church greets you warmly and gives you some food.
        prompt.Text = "The minister in the church greets you warmly and gives you some food.";
        ///PROMPT_IGNORE_VO CHURCH 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(CHURCH_p0_show);
        
        ///PROMPT CHURCH 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT CHURCH 1 The minister in the church greets you and Henry warmly, and gives you some food.
        prompt.Text = "The minister in the church greets you and Henry warmly, and gives you some food.";
        ///PROMPT_IGNORE_VO CHURCH 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(CHURCH_p1_condition);
        
        ///RESPONSE CHURCH 0
        response = node.AddResponse();
        ///RESPONSE_TEXT CHURCH 0 Tell him about your escape.
        response.Text = "Tell him about your escape.";
        ///RESPONSE_NEXT_NODE_TYPE CHURCH 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CHURCH 0 LISTEN
        response.NextNodeId = "LISTEN";
        
        ///RESPONSE CHURCH 1
        response = node.AddResponse();
        ///RESPONSE_TEXT CHURCH 1 Thank him and leave.
        response.Text = "Thank him and leave.";
        ///RESPONSE_NEXT_NODE_TYPE CHURCH 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID CHURCH 1 END
        response.NextNodeId = "END";
        
        ///NODE_END CHURCH
        ///NODE_START LISTEN
        node = dialog.CreateNode("LISTEN");
        ///NODE_NPC LISTEN LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES LISTEN False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE LISTEN Full
        ///NODE_VISUAL_USESCRIPT LISTEN false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~LISTEN~|||~
        ///PROMPT LISTEN 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT LISTEN 0 The minister listens closely and says he can help you further.
        prompt.Text = "The minister listens closely and says he can help you further.";
        ///PROMPT_IGNORE_VO LISTEN 0 false
        prompt.IgnoreVO = false;
        
        ///RESPONSE LISTEN 0
        response = node.AddResponse();
        ///RESPONSE_TEXT LISTEN 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE LISTEN 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID LISTEN 0 DISGUISE
        response.NextNodeId = "DISGUISE";
        
        ///NODE_END LISTEN
        ///NODE_START DISGUISE
        node = dialog.CreateNode("DISGUISE");
        ///NODE_NPC DISGUISE LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES DISGUISE False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE DISGUISE Full
        ///NODE_VISUAL_USESCRIPT DISGUISE false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~DISGUISE~|||~
        ///PROMPT DISGUISE 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT DISGUISE 0 He says it's important not to wear the clothes you were last seen in and gives you some old clothes to change into.
        prompt.Text = "He says it's important not to wear the clothes you were last seen in and gives you some old clothes to change into.";
        ///PROMPT_IGNORE_VO DISGUISE 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(DISGUISE_p0_show);
        
        ///PROMPT DISGUISE 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT DISGUISE 1 He says it's important not to wear the clothes you were last seen in so you change into the extra clothes you have.
        prompt.Text = "He says it's important not to wear the clothes you were last seen in so you change into the extra clothes you have.";
        ///PROMPT_IGNORE_VO DISGUISE 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(DISGUISE_p1_condition);
        prompt.OnShow(DISGUISE_p1_show);
        
        ///RESPONSE DISGUISE 0
        response = node.AddResponse();
        ///RESPONSE_TEXT DISGUISE 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE DISGUISE 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID DISGUISE 0 WAGON
        response.NextNodeId = "WAGON";
        
        ///NODE_END DISGUISE
        ///NODE_START WAGON
        node = dialog.CreateNode("WAGON");
        ///NODE_NPC WAGON LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES WAGON False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE WAGON Full
        ///NODE_VISUAL_USESCRIPT WAGON false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~WAGON~|||~
        ///PROMPT WAGON 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT WAGON 0 He explains he can hide you in the bottom of a haywagon that is going all the way up to Maysville.
        prompt.Text = "He explains he can hide you in the bottom of a haywagon that is going all the way up to Maysville.";
        ///PROMPT_IGNORE_VO WAGON 0 false
        prompt.IgnoreVO = false;
        
        ///PROMPT WAGON 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT WAGON 1 He explains he can hide one of you in the bottom of a haywagon that is going all the way up to Maysville. \"You go,\" says Henry, \"I'll find another way...\"
        prompt.Text = "He explains he can hide one of you in the bottom of a haywagon that is going all the way up to Maysville. \"You go,\" says Henry, \"I'll find another way...\"";
        ///PROMPT_IGNORE_VO WAGON 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(WAGON_p1_condition);
        
        ///RESPONSE WAGON 0
        response = node.AddResponse();
        ///RESPONSE_TEXT WAGON 0 Thank the minister and hide in the wagon.
        response.Text = "Thank the minister and hide in the wagon.";
        ///RESPONSE_NEXT_NODE_TYPE WAGON 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WAGON 0 n05
        response.NextNodeId = "n05";
        response.SetCondition(WAGON_r0_condition);
        
        ///RESPONSE WAGON 1
        response = node.AddResponse();
        ///RESPONSE_TEXT WAGON 1 Thank the minister, but leave town with Henry.
        response.Text = "Thank the minister, but leave town with Henry.";
        ///RESPONSE_NEXT_NODE_TYPE WAGON 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WAGON 1 END
        response.NextNodeId = "END";
        response.SetCondition(WAGON_r1_condition);
        
        ///RESPONSE WAGON 2
        response = node.AddResponse();
        ///RESPONSE_TEXT WAGON 2 Thank Henry, wish him luck and board the wagon.
        response.Text = "Thank Henry, wish him luck and board the wagon.";
        ///RESPONSE_NEXT_NODE_TYPE WAGON 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID WAGON 2 n05
        response.NextNodeId = "n05";
        response.SetCondition(WAGON_r2_condition);
        response.OnSelect(WAGON_r2_select);
        
        ///NODE_END WAGON
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 LEX
        node.Npc = "LEX";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 You hide under the scratchy hay and the wagon sets off.
        prompt.Text = "You hide under the scratchy hay and the wagon sets off.";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n05_p0_show);
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 More...
        response.Text = "More...";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n05
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD CHURCH_p1_condition
    public bool CHURCH_p1_condition (  ) {
        ///METHOD_BODY_START CHURCH_p1_condition
        /*//if($escape_type = "henry")*/
        return true;
        ///METHOD_BODY_END CHURCH_p1_condition
    }

    ///METHOD DISGUISE_p1_condition
    public bool DISGUISE_p1_condition (  ) {
        ///METHOD_BODY_START DISGUISE_p1_condition
        /*//if( hasItem("CLOTHES") )*/
        return true;
        ///METHOD_BODY_END DISGUISE_p1_condition
    }

    ///METHOD WAGON_p1_condition
    public bool WAGON_p1_condition (  ) {
        ///METHOD_BODY_START WAGON_p1_condition
        /*//if($escape_type = "henry" )*/
        return true;
        ///METHOD_BODY_END WAGON_p1_condition
    }

    ///METHOD NO_GOOD_p0_show
    public void NO_GOOD_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START NO_GOOD_p0_show
        /*//					doFood()*/
        ///METHOD_BODY_END NO_GOOD_p0_show
    }

    ///METHOD FOOD_HELP_p0_show
    public void FOOD_HELP_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START FOOD_HELP_p0_show
        /*// #food = #food + 2
        //				        updateMessage("You got 2 food.")*/
        ///METHOD_BODY_END FOOD_HELP_p0_show
    }

    ///METHOD CHURCH_p0_show
    public void CHURCH_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START CHURCH_p0_show
        /*//				#food = #food + 2
        //			    updateMessage("You got 2 food.")				*/
        ///METHOD_BODY_END CHURCH_p0_show
    }

    ///METHOD DISGUISE_p0_show
    public void DISGUISE_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START DISGUISE_p0_show
        /*// ?p2_changed_clothes = true
        //								?p2_disguised = true				*/
        ///METHOD_BODY_END DISGUISE_p0_show
    }

    ///METHOD DISGUISE_p1_show
    public void DISGUISE_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START DISGUISE_p1_show
        /*// ?p2_changed_clothes = true
        //								?p2_disguised = true				*/
        ///METHOD_BODY_END DISGUISE_p1_show
    }

    ///METHOD n05_p0_show
    public void n05_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n05_p0_show
        /*// $pick_result = "wagon" */
        ///METHOD_BODY_END n05_p0_show
    }

    ///METHOD n01_r1_condition
    public bool n01_r1_condition (  ) {
        ///METHOD_BODY_START n01_r1_condition
        /*//if(?know_lexington = true)*/
        return true;
        ///METHOD_BODY_END n01_r1_condition
    }

    ///METHOD WAGON_r0_condition
    public bool WAGON_r0_condition (  ) {
        ///METHOD_BODY_START WAGON_r0_condition
        /*//if($escape_type = "alone" )*/
        return true;
        ///METHOD_BODY_END WAGON_r0_condition
    }

    ///METHOD WAGON_r1_condition
    public bool WAGON_r1_condition (  ) {
        ///METHOD_BODY_START WAGON_r1_condition
        /*//if($escape_type = "henry" )*/
        return true;
        ///METHOD_BODY_END WAGON_r1_condition
    }

    ///METHOD WAGON_r2_condition
    public bool WAGON_r2_condition (  ) {
        ///METHOD_BODY_START WAGON_r2_condition
        /*//if($escape_type = "henry" )*/
        return true;
        ///METHOD_BODY_END WAGON_r2_condition
    }

    ///METHOD n01_r2_select
    public void n01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_select
        /*//				#rand = random(100)
        //				if( #rand < 35 )
        //					$next_node = "CREEPY"
        //				elseif( #rand < 85 )
        //					$next_node = "NO_GOOD"
        //				else
        //					$next_node = "STUMBLE"
        //				/if	*/
        ///METHOD_BODY_END n01_r2_select
    }

    ///METHOD n01_r3_select
    public void n01_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r3_select
        /*//				#rand = random(100)
        //				if( #rand < 10 )
        //					$next_node = "BAD_HELP"  // busted
        //				elseif( #rand < 40 )
        //					$next_node = "SCARED"
        //				elseif( #rand < 80 )
        //					// food
        //					$next_node = "FOOD_HELP"
        //				else
        //					// directed to church
        //					$next_node = "GOOD_HELP"
        //				/if			*/
        ///METHOD_BODY_END n01_r3_select
    }

    ///METHOD CAUGHT_r0_select
    public void CAUGHT_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START CAUGHT_r0_select
        /*//endState("escape_end", "")*/
        ///METHOD_BODY_END CAUGHT_r0_select
    }

    ///METHOD WAGON_r2_select
    public void WAGON_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START WAGON_r2_select
        /*//				#p2_henry_code = 30
        //				killHenry()*/
        ///METHOD_BODY_END WAGON_r2_select
    }
}
//CLASS_END Dialog_p2_lex_001
