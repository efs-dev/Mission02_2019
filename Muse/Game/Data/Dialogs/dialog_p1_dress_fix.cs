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
//CLASS Dialog_p1_dress_fix
public class Dialog_p1_dress_fix {
    //CLASS DialogGameFlagsClass
    public class DialogGameFlagsClass {
        //PROPERTY _p1_mag
        private bool _p1_mag = false;

        //PROPERTY p1_mag
        public bool p1_mag {
                get {
                        ///PROPERTY_GETTER_START p1_mag
                        return _p1_mag;
                        ///PROPERTY_GETTER_END p1_mag
                }
                set {
                        ///PROPERTY_SETTER_START p1_mag
                        _p1_mag = value;
                        ///PROPERTY_SETTER_END p1_mag
                }
        }

        //PROPERTY _p1_neckline
        private bool _p1_neckline = false;

        //PROPERTY p1_neckline
        public bool p1_neckline {
                get {
                        ///PROPERTY_GETTER_START p1_neckline
                        return _p1_neckline;
                        ///PROPERTY_GETTER_END p1_neckline
                }
                set {
                        ///PROPERTY_SETTER_START p1_neckline
                        _p1_neckline = value;
                        ///PROPERTY_SETTER_END p1_neckline
                }
        }

        //PROPERTY _p1_rest
        private bool _p1_rest = false;

        //PROPERTY p1_rest
        public bool p1_rest {
                get {
                        ///PROPERTY_GETTER_START p1_rest
                        return _p1_rest;
                        ///PROPERTY_GETTER_END p1_rest
                }
                set {
                        ///PROPERTY_SETTER_START p1_rest
                        _p1_rest = value;
                        ///PROPERTY_SETTER_END p1_rest
                }
        }

        //PROPERTY _p1_sar_task_1
        private int _p1_sar_task_1 = 0;

        //PROPERTY p1_sar_task_1
        public int p1_sar_task_1 {
                get {
                        ///PROPERTY_GETTER_START p1_sar_task_1
                        return _p1_sar_task_1;
                        ///PROPERTY_GETTER_END p1_sar_task_1
                }
                set {
                        ///PROPERTY_SETTER_START p1_sar_task_1
                        _p1_sar_task_1 = value;
                        ///PROPERTY_SETTER_END p1_sar_task_1
                }
        }

        //PROPERTY _p1_sar_task_2
        private int _p1_sar_task_2 = 0;

        //PROPERTY p1_sar_task_2
        public int p1_sar_task_2 {
                get {
                        ///PROPERTY_GETTER_START p1_sar_task_2
                        return _p1_sar_task_2;
                        ///PROPERTY_GETTER_END p1_sar_task_2
                }
                set {
                        ///PROPERTY_SETTER_START p1_sar_task_2
                        _p1_sar_task_2 = value;
                        ///PROPERTY_SETTER_END p1_sar_task_2
                }
        }

        //PROPERTY _p1_sar_task_count
        private int _p1_sar_task_count = 0;

        //PROPERTY p1_sar_task_count
        public int p1_sar_task_count {
                get {
                        ///PROPERTY_GETTER_START p1_sar_task_count
                        return _p1_sar_task_count;
                        ///PROPERTY_GETTER_END p1_sar_task_count
                }
                set {
                        ///PROPERTY_SETTER_START p1_sar_task_count
                        _p1_sar_task_count = value;
                        ///PROPERTY_SETTER_END p1_sar_task_count
                }
        }

        //PROPERTY _p1_sloppy
        private bool _p1_sloppy = false;

        //PROPERTY p1_sloppy
        public bool p1_sloppy {
                get {
                        ///PROPERTY_GETTER_START p1_sloppy
                        return _p1_sloppy;
                        ///PROPERTY_GETTER_END p1_sloppy
                }
                set {
                        ///PROPERTY_SETTER_START p1_sloppy
                        _p1_sloppy = value;
                        ///PROPERTY_SETTER_END p1_sloppy
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
        ///DIALOG_ID p1_dress_fix
        var dialog = new Dialog();
        dialog.Id = "p1_dress_fix";
        ///DIALOG_LINKTOHOTSPOTS false
        dialog.LinkToHotspots = false;
        DialogNode node = null;
        DialogPrompt prompt = null;
        DialogResponse response = null;
        
        ///NODE_START n01
        node = dialog.CreateNode("n01");
        ///NODE_NPC n01 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n01 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n01 Full
        ///NODE_VISUAL_USESCRIPT n01 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n01~|||~
        ///PROMPT n01 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n01 0 [Sarah leaves, shuts the door and you hear her go downstairs. Now you have some time to yourself.]
        prompt.Text = "[Sarah leaves, shuts the door and you hear her go downstairs. Now you have some time to yourself.]";
        ///PROMPT_IGNORE_VO n01 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n01_p0_show);
        
        ///RESPONSE n01 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 0 [Return the Primer to Sarah desk.]
        response.Text = "[Return the Primer to Sarah desk.]";
        ///RESPONSE_NEXT_NODE_TYPE n01 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 0 n02
        response.NextNodeId = "n02";
        response.SetCondition(n01_r0_condition);
        response.OnSelect(n01_r0_select);
        
        ///RESPONSE n01 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 1 [Rest for a little while.]
        response.Text = "[Rest for a little while.]";
        ///RESPONSE_NEXT_NODE_TYPE n01 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 1 n03
        response.NextNodeId = "n03";
        response.OnSelect(n01_r1_select);
        
        ///RESPONSE n01 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 2 [Look through the fashion magazine for ideas.]
        response.Text = "[Look through the fashion magazine for ideas.]";
        ///RESPONSE_NEXT_NODE_TYPE n01 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 2 n04
        response.NextNodeId = "n04";
        response.OnSelect(n01_r2_select);
        
        ///RESPONSE n01 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 3 [Make your own 'alterations.' Lower the neckline a few extra inches.]
        response.Text = "[Make your own 'alterations.' Lower the neckline a few extra inches.]";
        ///RESPONSE_NEXT_NODE_TYPE n01 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 3 n03
        response.NextNodeId = "n03";
        response.OnSelect(n01_r3_select);
        
        ///RESPONSE n01 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 4 [Make the alterations she requested, but do a sloppy job.]
        response.Text = "[Make the alterations she requested, but do a sloppy job.]";
        ///RESPONSE_NEXT_NODE_TYPE n01 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 4 n03
        response.NextNodeId = "n03";
        response.OnSelect(n01_r4_select);
        
        ///RESPONSE n01 5
        response = node.AddResponse();
        ///RESPONSE_TEXT n01 5 [Make the alterations she requested and do the best job you can.]
        response.Text = "[Make the alterations she requested and do the best job you can.]";
        ///RESPONSE_NEXT_NODE_TYPE n01 5 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n01 5 n12
        response.NextNodeId = "n12";
        response.OnSelect(n01_r5_select);
        
        ///NODE_END n01
        ///NODE_START n02
        node = dialog.CreateNode("n02");
        ///NODE_NPC n02 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n02 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n02 Full
        ///NODE_VISUAL_USESCRIPT n02 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n02~|||~
        ///PROMPT n02 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n02 0 [You return the Primer to Sarah's desk. You still have some time.]\n
        prompt.Text = "[You return the Primer to Sarah's desk. You still have some time.]\n";
        ///PROMPT_IGNORE_VO n02 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n02_p0_show);
        
        ///RESPONSE n02 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 0 [Rest for a little while]
        response.Text = "[Rest for a little while]";
        ///RESPONSE_NEXT_NODE_TYPE n02 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 0 n03
        response.NextNodeId = "n03";
        response.OnSelect(n02_r0_select);
        
        ///RESPONSE n02 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 1 [Look through the fashion magazine for ideas.]
        response.Text = "[Look through the fashion magazine for ideas.]";
        ///RESPONSE_NEXT_NODE_TYPE n02 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 1 n04
        response.NextNodeId = "n04";
        response.OnSelect(n02_r1_select);
        
        ///RESPONSE n02 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 2 [Make your own 'alterations.' Lower the neckline a few extra inches.]
        response.Text = "[Make your own 'alterations.' Lower the neckline a few extra inches.]";
        ///RESPONSE_NEXT_NODE_TYPE n02 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 2 n03
        response.NextNodeId = "n03";
        response.OnSelect(n02_r2_select);
        
        ///RESPONSE n02 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 3 [Make the alterations she requested, but do a sloppy job.]
        response.Text = "[Make the alterations she requested, but do a sloppy job.]";
        ///RESPONSE_NEXT_NODE_TYPE n02 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 3 n03
        response.NextNodeId = "n03";
        response.OnSelect(n02_r3_select);
        
        ///RESPONSE n02 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n02 4 [Make the alterations she requested and do the best job you can.]
        response.Text = "[Make the alterations she requested and do the best job you can.]";
        ///RESPONSE_NEXT_NODE_TYPE n02 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n02 4 n12
        response.NextNodeId = "n12";
        response.OnSelect(n02_r4_select);
        
        ///NODE_END n02
        ///NODE_START n03
        node = dialog.CreateNode("n03");
        ///NODE_NPC n03 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n03 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n03 Full
        ///NODE_VISUAL_USESCRIPT n03 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n03~|||~
        ///PROMPT n03 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 0 [You make your own alterations. Many would now consider the dress to be a bit too 'daring.' You still have some time left.]
        prompt.Text = "[You make your own alterations. Many would now consider the dress to be a bit too 'daring.' You still have some time left.]";
        ///PROMPT_IGNORE_VO n03 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n03_p0_condition);
        prompt.OnShow(n03_p0_show);
        
        ///PROMPT n03 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 1 [You make the alterations, but the stitching is not very strong and may break if she chooses to dance. There is still some time before Sarah comes back.]
        prompt.Text = "[You make the alterations, but the stitching is not very strong and may break if she chooses to dance. There is still some time before Sarah comes back.]";
        ///PROMPT_IGNORE_VO n03 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n03_p1_condition);
        prompt.OnShow(n03_p1_show);
        
        ///PROMPT n03 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n03 2 [You rest awhile. It feels so good. More rest would be even better. There's still a little time before Sarah finishes lunch.]
        prompt.Text = "[You rest awhile. It feels so good. More rest would be even better. There's still a little time before Sarah finishes lunch.]";
        ///PROMPT_IGNORE_VO n03 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n03_p2_condition);
        prompt.OnShow(n03_p2_show);
        
        ///RESPONSE n03 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 0 [Do a better job on the dress.]
        response.Text = "[Do a better job on the dress.]";
        ///RESPONSE_NEXT_NODE_TYPE n03 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 0 n12
        response.NextNodeId = "n12";
        response.SetCondition(n03_r0_condition);
        response.OnSelect(n03_r0_select);
        
        ///RESPONSE n03 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 1 [Return the Primer to Sarah's desk.]
        response.Text = "[Return the Primer to Sarah's desk.]";
        ///RESPONSE_NEXT_NODE_TYPE n03 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 1 n11
        response.NextNodeId = "n11";
        response.SetCondition(n03_r1_condition);
        response.OnSelect(n03_r1_select);
        
        ///RESPONSE n03 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 2 [Rest awhile longer.]
        response.Text = "[Rest awhile longer.]";
        ///RESPONSE_NEXT_NODE_TYPE n03 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 2 n06
        response.NextNodeId = "n06";
        response.SetCondition(n03_r2_condition);
        response.OnSelect(n03_r2_select);
        
        ///RESPONSE n03 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 3 [Rest for a little while.]
        response.Text = "[Rest for a little while.]";
        ///RESPONSE_NEXT_NODE_TYPE n03 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 3 n10
        response.NextNodeId = "n10";
        response.SetCondition(n03_r3_condition);
        response.OnSelect(n03_r3_select);
        
        ///RESPONSE n03 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 4 [Look through the fashion magazine for ideas.]
        response.Text = "[Look through the fashion magazine for ideas.]";
        ///RESPONSE_NEXT_NODE_TYPE n03 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 4 n04
        response.NextNodeId = "n04";
        response.SetCondition(n03_r4_condition);
        response.OnSelect(n03_r4_select);
        
        ///RESPONSE n03 5
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 5 [Make your own 'alterations.' Lower the neckline a few extra inches.]
        response.Text = "[Make your own 'alterations.' Lower the neckline a few extra inches.]";
        ///RESPONSE_NEXT_NODE_TYPE n03 5 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 5 n10
        response.NextNodeId = "n10";
        response.SetCondition(n03_r5_condition);
        response.OnSelect(n03_r5_select);
        
        ///RESPONSE n03 6
        response = node.AddResponse();
        ///RESPONSE_TEXT n03 6 [Make the alterations she requested, but do a sloppy job.]
        response.Text = "[Make the alterations she requested, but do a sloppy job.]";
        ///RESPONSE_NEXT_NODE_TYPE n03 6 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n03 6 n10
        response.NextNodeId = "n10";
        response.SetCondition(n03_r6_condition);
        response.OnSelect(n03_r6_select);
        
        ///NODE_END n03
        ///NODE_START n04
        node = dialog.CreateNode("n04");
        ///NODE_NPC n04 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n04 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n04 Full
        ///NODE_VISUAL_USESCRIPT n04 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n04~|||~
        ///PROMPT n04 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n04 0 [As you flip through the pages, something falls out...]
        prompt.Text = "[As you flip through the pages, something falls out...]";
        ///PROMPT_IGNORE_VO n04 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n04_p0_show);
        
        ///RESPONSE n04 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n04 0 [Take it]
        response.Text = "[Take it]";
        ///RESPONSE_NEXT_NODE_TYPE n04 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n04 0 n05
        response.NextNodeId = "n05";
        response.OnSelect(n04_r0_select);
        
        ///NODE_END n04
        ///NODE_START n05
        node = dialog.CreateNode("n05");
        ///NODE_NPC n05 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n05 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n05 Full
        ///NODE_VISUAL_USESCRIPT n05 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n05~|||~
        ///PROMPT n05 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 0 [It may be about the wedding Sarah mentioned. There's also something written on the other side.]
        prompt.Text = "[It may be about the wedding Sarah mentioned. There's also something written on the other side.]";
        ///PROMPT_IGNORE_VO n05 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n05_p0_condition);
        prompt.OnShow(n05_p0_show);
        
        ///PROMPT n05 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n05 1 [It may be about the wedding Sarah mentioned. There's also something written on the other side. You still have some time before she returns.]
        prompt.Text = "[It may be about the wedding Sarah mentioned. There's also something written on the other side. You still have some time before she returns.]";
        ///PROMPT_IGNORE_VO n05 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n05_p1_condition);
        prompt.OnShow(n05_p1_show);
        
        ///RESPONSE n05 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n05 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 0 n07
        response.NextNodeId = "n07";
        response.SetCondition(n05_r0_condition);
        response.OnSelect(n05_r0_select);
        
        ///RESPONSE n05 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 1 [Rest for a little while]
        response.Text = "[Rest for a little while]";
        ///RESPONSE_NEXT_NODE_TYPE n05 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n05_r1_condition);
        response.OnSelect(n05_r1_select);
        
        ///RESPONSE n05 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 2 [Make your own 'alterations.' Lower the neckline a few extra inches.]
        response.Text = "[Make your own 'alterations.' Lower the neckline a few extra inches.]";
        ///RESPONSE_NEXT_NODE_TYPE n05 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 2 n10
        response.NextNodeId = "n10";
        response.SetCondition(n05_r2_condition);
        response.OnSelect(n05_r2_select);
        
        ///RESPONSE n05 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n05 3 [Make the alterations she requested, but do a sloppy job.]
        response.Text = "[Make the alterations she requested, but do a sloppy job.]";
        ///RESPONSE_NEXT_NODE_TYPE n05 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n05 3 n10
        response.NextNodeId = "n10";
        response.SetCondition(n05_r3_condition);
        response.OnSelect(n05_r3_select);
        
        ///NODE_END n05
        ///NODE_START n06
        node = dialog.CreateNode("n06");
        ///NODE_NPC n06 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n06 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n06 Full
        ///NODE_VISUAL_USESCRIPT n06 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n06~|||~
        ///PROMPT n06 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n06 0 [The extra rest is wonderful. You feel more refreshed than you have in weeks.]
        prompt.Text = "[The extra rest is wonderful. You feel more refreshed than you have in weeks.]";
        ///PROMPT_IGNORE_VO n06 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n06_p0_show);
        
        ///RESPONSE n06 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n06 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n06 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n06 0 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n06
        ///NODE_START n07
        node = dialog.CreateNode("n07");
        ///NODE_NPC n07 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n07 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n07 Full
        ///NODE_VISUAL_USESCRIPT n07 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n07~|||~
        ///PROMPT n07 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n07 0 [You hear the Kings finishing up lunch on the porch below.]
        prompt.Text = "[You hear the Kings finishing up lunch on the porch below.]";
        ///PROMPT_IGNORE_VO n07 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n07_p0_show);
        
        ///RESPONSE n07 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 0 [Pack Sarah's dress in her suitcase by the door]
        response.Text = "[Pack Sarah's dress in her suitcase by the door]";
        ///RESPONSE_NEXT_NODE_TYPE n07 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 0 n08
        response.NextNodeId = "n08";
        response.OnSelect(n07_r0_select);
        
        ///RESPONSE n07 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n07 1 [Lay Sarah's dress out on the bed for her to see]
        response.Text = "[Lay Sarah's dress out on the bed for her to see]";
        ///RESPONSE_NEXT_NODE_TYPE n07 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n07 1 n08
        response.NextNodeId = "n08";
        response.OnSelect(n07_r1_select);
        
        ///NODE_END n07
        ///NODE_START n08
        node = dialog.CreateNode("n08");
        ///NODE_NPC n08 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n08 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n08 Full
        ///NODE_VISUAL_USESCRIPT n08 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n08~|||~
        ///PROMPT n08 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n08 0 [You hear Sarah opening the door...]
        prompt.Text = "[You hear Sarah opening the door...]";
        ///PROMPT_IGNORE_VO n08 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n08_p0_show);
        
        ///RESPONSE n08 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n08 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n08 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n08 0 END
        response.NextNodeId = "END";
        
        ///NODE_END n08
        ///NODE_START n10
        node = dialog.CreateNode("n10");
        ///NODE_NPC n10 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n10 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n10 Full
        ///NODE_VISUAL_USESCRIPT n10 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n10~|||~
        ///PROMPT n10 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 0 [You make your own alterations. Many would now consider the dress to be a bit too 'daring.']
        prompt.Text = "[You make your own alterations. Many would now consider the dress to be a bit too 'daring.']";
        ///PROMPT_IGNORE_VO n10 0 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n10_p0_condition);
        prompt.OnShow(n10_p0_show);
        
        ///PROMPT n10 1
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 1 [You make the alteration, but the stitching is not very strong and may break if she chooses to dance.]
        prompt.Text = "[You make the alteration, but the stitching is not very strong and may break if she chooses to dance.]";
        ///PROMPT_IGNORE_VO n10 1 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n10_p1_condition);
        prompt.OnShow(n10_p1_show);
        
        ///PROMPT n10 2
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n10 2 [You rest awhile. It feels so good. More rest would have been even better.]
        prompt.Text = "[You rest awhile. It feels so good. More rest would have been even better.]";
        ///PROMPT_IGNORE_VO n10 2 false
        prompt.IgnoreVO = false;
        prompt.SetCondition(n10_p2_condition);
        prompt.OnShow(n10_p2_show);
        
        ///RESPONSE n10 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n10 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n10 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n10 0 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n10
        ///NODE_START n11
        node = dialog.CreateNode("n11");
        ///NODE_NPC n11 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n11 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n11 Full
        ///NODE_VISUAL_USESCRIPT n11 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n11~|||~
        ///PROMPT n11 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n11 0 [You return the Primer to Sarah's desk. You still have some time left.]
        prompt.Text = "[You return the Primer to Sarah's desk. You still have some time left.]";
        ///PROMPT_IGNORE_VO n11 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n11_p0_show);
        
        ///RESPONSE n11 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 0 [Rest awhile longer.]
        response.Text = "[Rest awhile longer.]";
        ///RESPONSE_NEXT_NODE_TYPE n11 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 0 n06
        response.NextNodeId = "n06";
        response.SetCondition(n11_r0_condition);
        response.OnSelect(n11_r0_select);
        
        ///RESPONSE n11 1
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 1 [Rest for a little while.]
        response.Text = "[Rest for a little while.]";
        ///RESPONSE_NEXT_NODE_TYPE n11 1 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 1 n10
        response.NextNodeId = "n10";
        response.SetCondition(n11_r1_condition);
        response.OnSelect(n11_r1_select);
        
        ///RESPONSE n11 2
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 2 [Look through the fashion magazine for ideas.]
        response.Text = "[Look through the fashion magazine for ideas.]";
        ///RESPONSE_NEXT_NODE_TYPE n11 2 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 2 n04
        response.NextNodeId = "n04";
        response.SetCondition(n11_r2_condition);
        response.OnSelect(n11_r2_select);
        
        ///RESPONSE n11 3
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 3 [Make your own 'alterations.' Lower the neckline a few extra inches.]
        response.Text = "[Make your own 'alterations.' Lower the neckline a few extra inches.]";
        ///RESPONSE_NEXT_NODE_TYPE n11 3 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 3 n10
        response.NextNodeId = "n10";
        response.SetCondition(n11_r3_condition);
        response.OnSelect(n11_r3_select);
        
        ///RESPONSE n11 4
        response = node.AddResponse();
        ///RESPONSE_TEXT n11 4 [Make the alterations Sarah requested, but do a sloppy job.]
        response.Text = "[Make the alterations Sarah requested, but do a sloppy job.]";
        ///RESPONSE_NEXT_NODE_TYPE n11 4 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n11 4 n10
        response.NextNodeId = "n10";
        response.SetCondition(n11_r4_condition);
        response.OnSelect(n11_r4_select);
        
        ///NODE_END n11
        ///NODE_START n12
        node = dialog.CreateNode("n12");
        ///NODE_NPC n12 DRESS
        node.Npc = "DRESS";
        ///NODE_RANDOM_RESPONSES n12 False
        node.RandomizeResponseOrder = false;
        ///NODE_VISUAL_TYPE n12 Full
        ///NODE_VISUAL_USESCRIPT n12 false
        node.VisualDataType = "full";
        ///NODE_VISUAL_DATA~|||~n12~|||~
        ///PROMPT n12 0
        prompt = node.AddPrompt();
        ///PROMPT_TEXT n12 0 [You spend all of the time the Kings are at lunch to do an excellent job on Sarah's dress.]
        prompt.Text = "[You spend all of the time the Kings are at lunch to do an excellent job on Sarah's dress.]";
        ///PROMPT_IGNORE_VO n12 0 false
        prompt.IgnoreVO = false;
        prompt.OnShow(n12_p0_show);
        
        ///RESPONSE n12 0
        response = node.AddResponse();
        ///RESPONSE_TEXT n12 0 [More...]
        response.Text = "[More...]";
        ///RESPONSE_NEXT_NODE_TYPE n12 0 Id
        response.NextNodeType = DialogResponse.NextNodeTypes.Id;
        ///RESPONSE_NEXT_NODE_ID n12 0 n07
        response.NextNodeId = "n07";
        
        ///NODE_END n12
        return dialog;
        ///METHOD_BODY_END CreateDialog
    }

    ///METHOD n03_p0_condition
    public bool n03_p0_condition (  ) {
        ///METHOD_BODY_START n03_p0_condition
        /*//if( ?p1_neckline )*/
        return true;
        ///METHOD_BODY_END n03_p0_condition
    }

    ///METHOD n03_p1_condition
    public bool n03_p1_condition (  ) {
        ///METHOD_BODY_START n03_p1_condition
        /*//if( ?p1_sloppy )*/
        return true;
        ///METHOD_BODY_END n03_p1_condition
    }

    ///METHOD n03_p2_condition
    public bool n03_p2_condition (  ) {
        ///METHOD_BODY_START n03_p2_condition
        /*//if( ?p1_rest )*/
        return true;
        ///METHOD_BODY_END n03_p2_condition
    }

    ///METHOD n05_p0_condition
    public bool n05_p0_condition (  ) {
        ///METHOD_BODY_START n05_p0_condition
        /*//if( #p1_sar_task_count = 2 )*/
        return true;
        ///METHOD_BODY_END n05_p0_condition
    }

    ///METHOD n05_p1_condition
    public bool n05_p1_condition (  ) {
        ///METHOD_BODY_START n05_p1_condition
        /*//if( #p1_sar_task_count = 1 )*/
        return true;
        ///METHOD_BODY_END n05_p1_condition
    }

    ///METHOD n10_p0_condition
    public bool n10_p0_condition (  ) {
        ///METHOD_BODY_START n10_p0_condition
        /*//if( #p1_sar_task_2 = 3 )*/
        return true;
        ///METHOD_BODY_END n10_p0_condition
    }

    ///METHOD n10_p1_condition
    public bool n10_p1_condition (  ) {
        ///METHOD_BODY_START n10_p1_condition
        /*//if( #p1_sar_task_2 = 1 )*/
        return true;
        ///METHOD_BODY_END n10_p1_condition
    }

    ///METHOD n10_p2_condition
    public bool n10_p2_condition (  ) {
        ///METHOD_BODY_START n10_p2_condition
        /*//if( #p1_sar_task_2 = 2 )*/
        return true;
        ///METHOD_BODY_END n10_p2_condition
    }

    ///METHOD n01_p0_show
    public void n01_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n01_p0_show
        /*//#p1_sar_task_1 = 0
        //#p1_sar_task_2 = 0
        //#p1_sar_task_count = 1
        //?dress_finished = false
        //?dress_packed = false
        //#dress_quality = 0*/
        DialogGameFlags.p1_sar_task_1 = 0;
        DialogGameFlags.p1_sar_task_2 = 0;
        DialogGameFlags.p1_sar_task_count = 1;
        GameFlags.P1DressFinished = false;
        GameFlags.P1DressPacked = false;
        GameFlags.P1DressQuality = 0;
        ///METHOD_BODY_END n01_p0_show
    }

    ///METHOD n02_p0_show
    public void n02_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n02_p0_show
        /*//log("")*/
        ///METHOD_BODY_END n02_p0_show
    }

    ///METHOD n03_p0_show
    public void n03_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n03_p0_show
        /*// #p1_sar_task_count = 2*/
        ///METHOD_BODY_END n03_p0_show
    }

    ///METHOD n03_p1_show
    public void n03_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n03_p1_show
        /*// #p1_sar_task_count = 2*/
        ///METHOD_BODY_END n03_p1_show
    }

    ///METHOD n03_p2_show
    public void n03_p2_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n03_p2_show
        /*// #p1_sar_task_count = 2*/
        ///METHOD_BODY_END n03_p2_show
    }

    ///METHOD n04_p0_show
    public void n04_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n04_p0_show
        /*//?has_invitation = true*/
        ///METHOD_BODY_END n04_p0_show
    }

    ///METHOD n05_p0_show
    public void n05_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n05_p0_show
        /*//			//hint("Words you can't yet read appear blurry.")
        //			overlayPopup("literacy_message")*/
        ///METHOD_BODY_END n05_p0_show
    }

    ///METHOD n05_p1_show
    public void n05_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n05_p1_show
        /*//			//hint("Words you can't yet read appear blurry.")
        //			overlayPopup("literacy_message")*/
        ///METHOD_BODY_END n05_p1_show
    }

    ///METHOD n06_p0_show
    public void n06_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n06_p0_show
        /*//log("")*/
        ///METHOD_BODY_END n06_p0_show
    }

    ///METHOD n07_p0_show
    public void n07_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n07_p0_show
        /*//log("")*/
        ///METHOD_BODY_END n07_p0_show
    }

    ///METHOD n08_p0_show
    public void n08_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n08_p0_show
        /*//log("")*/
        ///METHOD_BODY_END n08_p0_show
    }

    ///METHOD n10_p0_show
    public void n10_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n10_p0_show
        /*//log("")*/
        ///METHOD_BODY_END n10_p0_show
    }

    ///METHOD n10_p1_show
    public void n10_p1_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n10_p1_show
        /*//log("")*/
        ///METHOD_BODY_END n10_p1_show
    }

    ///METHOD n10_p2_show
    public void n10_p2_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n10_p2_show
        /*//log("")*/
        ///METHOD_BODY_END n10_p2_show
    }

    ///METHOD n11_p0_show
    public void n11_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n11_p0_show
        /*//removeItem( "PRIMER" )*/
        ///METHOD_BODY_END n11_p0_show
    }

    ///METHOD n12_p0_show
    public void n12_p0_show ( DialogPrompt prompt ) {
        ///METHOD_BODY_START n12_p0_show
        /*//log("")*/
        ///METHOD_BODY_END n12_p0_show
    }

    ///METHOD n01_r0_condition
    public bool n01_r0_condition (  ) {
        ///METHOD_BODY_START n01_r0_condition
        /*//if( hasItem("PRIMER") )*/
        return GameFlags.P1HasPrimer;
        ///METHOD_BODY_END n01_r0_condition
    }

    ///METHOD n03_r0_condition
    public bool n03_r0_condition (  ) {
        ///METHOD_BODY_START n03_r0_condition
        /*//if( (?p1_sloppy = false) AND (?p1_neckline = false) )*/
        return true;
        ///METHOD_BODY_END n03_r0_condition
    }

    ///METHOD n03_r1_condition
    public bool n03_r1_condition (  ) {
        ///METHOD_BODY_START n03_r1_condition
        /*//if( (?p1_neckline = false) AND (?p1_sloppy = false) )*/
        return true;
        ///METHOD_BODY_END n03_r1_condition
    }

    ///METHOD n03_r2_condition
    public bool n03_r2_condition (  ) {
        ///METHOD_BODY_START n03_r2_condition
        /*//if( ?p1_mag = false )*/
        return true;
        ///METHOD_BODY_END n03_r2_condition
    }

    ///METHOD n03_r3_condition
    public bool n03_r3_condition (  ) {
        ///METHOD_BODY_START n03_r3_condition
        /*//if( ?p1_rest = false)*/
        return true;
        ///METHOD_BODY_END n03_r3_condition
    }

    ///METHOD n03_r4_condition
    public bool n03_r4_condition (  ) {
        ///METHOD_BODY_START n03_r4_condition
        /*//if( ?p1_rest )*/
        return true;
        ///METHOD_BODY_END n03_r4_condition
    }

    ///METHOD n03_r5_condition
    public bool n03_r5_condition (  ) {
        ///METHOD_BODY_START n03_r5_condition
        /*//if( hasItem("PRIMER") )*/
        return true;
        ///METHOD_BODY_END n03_r5_condition
    }

    ///METHOD n03_r6_condition
    public bool n03_r6_condition (  ) {
        ///METHOD_BODY_START n03_r6_condition
        /*//if( #dress_quality = 2 )*/
        return true;
        ///METHOD_BODY_END n03_r6_condition
    }

    ///METHOD n05_r0_condition
    public bool n05_r0_condition (  ) {
        ///METHOD_BODY_START n05_r0_condition
        /*//if( (?p1_sloppy = false) AND ( #p1_sar_task_count = 1) )*/
        return true;
        ///METHOD_BODY_END n05_r0_condition
    }

    ///METHOD n05_r1_condition
    public bool n05_r1_condition (  ) {
        ///METHOD_BODY_START n05_r1_condition
        /*//if( (?p1_neckline = false) AND ( #p1_sar_task_count = 1) )*/
        return true;
        ///METHOD_BODY_END n05_r1_condition
    }

    ///METHOD n05_r2_condition
    public bool n05_r2_condition (  ) {
        ///METHOD_BODY_START n05_r2_condition
        /*//if( (?p1_rest = false) AND ( #p1_sar_task_count = 1) )*/
        return true;
        ///METHOD_BODY_END n05_r2_condition
    }

    ///METHOD n05_r3_condition
    public bool n05_r3_condition (  ) {
        ///METHOD_BODY_START n05_r3_condition
        /*//if( #p1_sar_task_count = 2)*/
        return true;
        ///METHOD_BODY_END n05_r3_condition
    }

    ///METHOD n11_r0_condition
    public bool n11_r0_condition (  ) {
        ///METHOD_BODY_START n11_r0_condition
        /*//if( (?p1_sloppy = false) AND (?p1_neckline = false) )*/
        return true;
        ///METHOD_BODY_END n11_r0_condition
    }

    ///METHOD n11_r1_condition
    public bool n11_r1_condition (  ) {
        ///METHOD_BODY_START n11_r1_condition
        /*//if( (?p1_sloppy = false) AND (?p1_neckline = false) )*/
        return true;
        ///METHOD_BODY_END n11_r1_condition
    }

    ///METHOD n11_r2_condition
    public bool n11_r2_condition (  ) {
        ///METHOD_BODY_START n11_r2_condition
        /*//if( ?p1_mag = false )*/
        return true;
        ///METHOD_BODY_END n11_r2_condition
    }

    ///METHOD n11_r3_condition
    public bool n11_r3_condition (  ) {
        ///METHOD_BODY_START n11_r3_condition
        /*//if( ?p1_rest = false )*/
        return true;
        ///METHOD_BODY_END n11_r3_condition
    }

    ///METHOD n11_r4_condition
    public bool n11_r4_condition (  ) {
        ///METHOD_BODY_START n11_r4_condition
        /*//if(?p1_rest = true )*/
        return true;
        ///METHOD_BODY_END n11_r4_condition
    }

    ///METHOD n01_r0_select
    public void n01_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r0_select
        /*//#dress_quality=3
        //?dress_finished = true*/
        GameFlags.P1PrimerReturn = true;
        ///METHOD_BODY_END n01_r0_select
    }

    ///METHOD n01_r1_select
    public void n01_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r1_select
        /*//?p1_sloppy = true
        //#p1_sar_task_1 = 1
        //#dress_quality = 1
        //?dress_finished = true*/
        DialogGameFlags.p1_rest = true;
        DialogGameFlags.p1_sar_task_1 = 2;
        ///METHOD_BODY_END n01_r1_select
    }

    ///METHOD n01_r2_select
    public void n01_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r2_select
        /*//?p1_neckline = true
        //#p1_sar_task_1 = 3
        //?dress_finished = true
        //#dress_quality = 2*/
        DialogGameFlags.p1_mag = true;
        DialogGameFlags.p1_sar_task_1 = 4;
        ///METHOD_BODY_END n01_r2_select
    }

    ///METHOD n01_r3_select
    public void n01_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r3_select
        /*//?p1_mag = true
        //#p1_sar_task_1 = 4*/
        DialogGameFlags.p1_neckline = true;
        DialogGameFlags.p1_sar_task_1 = 3;
        ///METHOD_BODY_END n01_r3_select
    }

    ///METHOD n01_r4_select
    public void n01_r4_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r4_select
        /*//?p1_rest = true
        //#p1_sar_task_1 = 2*/
        DialogGameFlags.p1_sar_task_1 = 1;
        GameFlags.P1DressQuality = 1;
        GameFlags.P1DressFinished = true;
        DialogGameFlags.p1_sloppy = true;
        ///METHOD_BODY_END n01_r4_select
    }

    ///METHOD n01_r5_select
    public void n01_r5_select ( DialogResponse response ) {
        ///METHOD_BODY_START n01_r5_select
        /*//removeItem( "PRIMER" )
        //?primer_return = true*/
        GameFlags.P1DressQuality = 3;
        GameFlags.P1DressFinished = true;
        ///METHOD_BODY_END n01_r5_select
    }

    ///METHOD n02_r0_select
    public void n02_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r0_select
        /*//#dress_quality = 3
        //?dress_finished = true*/
        DialogGameFlags.p1_sar_task_1 = 2;
        DialogGameFlags.p1_rest = true;
        ///METHOD_BODY_END n02_r0_select
    }

    ///METHOD n02_r1_select
    public void n02_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r1_select
        /*//#p1_sar_task_1 = 1
        //?p1_sloppy = true
        //?dress_finished = true
        //#dress_quality = 1*/
        DialogGameFlags.p1_mag = true;
        DialogGameFlags.p1_sar_task_1 = 4;
        ///METHOD_BODY_END n02_r1_select
    }

    ///METHOD n02_r2_select
    public void n02_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r2_select
        /*//#p1_sar_task_1 = 3
        //?p1_neckline = true
        //?dress_finished = true
        //#dress_quality = 2*/
        DialogGameFlags.p1_sar_task_1 = 3;
        DialogGameFlags.p1_neckline = true;
        ///METHOD_BODY_END n02_r2_select
    }

    ///METHOD n02_r3_select
    public void n02_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r3_select
        /*//#p1_sar_task_1 = 4
        //?p1_mag = true*/
        DialogGameFlags.p1_sar_task_1 = 1;
        DialogGameFlags.p1_sloppy = true;
        GameFlags.P1DressFinished = true;
        GameFlags.P1DressQuality = 1;
        ///METHOD_BODY_END n02_r3_select
    }

    ///METHOD n02_r4_select
    public void n02_r4_select ( DialogResponse response ) {
        ///METHOD_BODY_START n02_r4_select
        /*//#p1_sar_task_1 = 2
        //?p1_rest = true*/
        GameFlags.P1DressQuality = 3;
        GameFlags.P1DressFinished = true;
        ///METHOD_BODY_END n02_r4_select
    }

    ///METHOD n03_r0_select
    public void n03_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r0_select
        /*//#p1_sar_task_2 = 1
        //?dress_finished = true
        //#dress_quality = 1*/
        ///METHOD_BODY_END n03_r0_select
    }

    ///METHOD n03_r1_select
    public void n03_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r1_select
        /*//#p1_sar_task_2 = 3
        //?dress_finished = true
        //#dress_quality = 2*/
        ///METHOD_BODY_END n03_r1_select
    }

    ///METHOD n03_r2_select
    public void n03_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r2_select
        /*//#p1_sar_task_2 = 4*/
        ///METHOD_BODY_END n03_r2_select
    }

    ///METHOD n03_r3_select
    public void n03_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r3_select
        /*//#p1_sar_task_2 = 2*/
        ///METHOD_BODY_END n03_r3_select
    }

    ///METHOD n03_r4_select
    public void n03_r4_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r4_select
        /*//#p1_sar_task_2 = 2*/
        ///METHOD_BODY_END n03_r4_select
    }

    ///METHOD n03_r5_select
    public void n03_r5_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r5_select
        /*//?primer_return = true*/
        ///METHOD_BODY_END n03_r5_select
    }

    ///METHOD n03_r6_select
    public void n03_r6_select ( DialogResponse response ) {
        ///METHOD_BODY_START n03_r6_select
        /*//#dress_quality = 3*/
        ///METHOD_BODY_END n03_r6_select
    }

    ///METHOD n04_r0_select
    public void n04_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n04_r0_select
        /*//			addItem("INVITATION")			*/
        ///METHOD_BODY_END n04_r0_select
    }

    ///METHOD n05_r0_select
    public void n05_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r0_select
        /*//setLayer("fg", "")
        //#p1_sar_task_2 = 1
        //?dress_finished = true
        //#dress_quality = 1*/
        ///METHOD_BODY_END n05_r0_select
    }

    ///METHOD n05_r1_select
    public void n05_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r1_select
        /*//setLayer("fg", "")
        //#p1_sar_task_2 = 3
        //?dress_finished = true
        //#dress_quality = 2*/
        ///METHOD_BODY_END n05_r1_select
    }

    ///METHOD n05_r2_select
    public void n05_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r2_select
        /*//setLayer("fg", "")
        //#p1_sar_task_2 = 2*/
        ///METHOD_BODY_END n05_r2_select
    }

    ///METHOD n05_r3_select
    public void n05_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n05_r3_select
        /*//setLayer("fg", "")*/
        ///METHOD_BODY_END n05_r3_select
    }

    ///METHOD n07_r0_select
    public void n07_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r0_select
        /*//?dress_packed = false*/
        ///METHOD_BODY_END n07_r0_select
    }

    ///METHOD n07_r1_select
    public void n07_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n07_r1_select
        /*//?dress_packed = true*/
        ///METHOD_BODY_END n07_r1_select
    }

    ///METHOD n11_r0_select
    public void n11_r0_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r0_select
        /*//#p1_sar_task_2 = 1
        //?dress_finished = true
        //#dress_quality = 1*/
        ///METHOD_BODY_END n11_r0_select
    }

    ///METHOD n11_r1_select
    public void n11_r1_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r1_select
        /*//#p1_sar_task_2 = 3
        //?dress_finished = true
        //#dress_quality = 2*/
        ///METHOD_BODY_END n11_r1_select
    }

    ///METHOD n11_r2_select
    public void n11_r2_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r2_select
        /*//#p1_sar_task_2 = 4*/
        ///METHOD_BODY_END n11_r2_select
    }

    ///METHOD n11_r3_select
    public void n11_r3_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r3_select
        /*//#p1_sar_task_2 = 2*/
        ///METHOD_BODY_END n11_r3_select
    }

    ///METHOD n11_r4_select
    public void n11_r4_select ( DialogResponse response ) {
        ///METHOD_BODY_START n11_r4_select
        /*//#p1_sar_task_2 = 2*/
        ///METHOD_BODY_END n11_r4_select
    }
}
//CLASS_END Dialog_p1_dress_fix
