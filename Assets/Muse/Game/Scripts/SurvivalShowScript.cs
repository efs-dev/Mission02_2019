using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalShowScript  {

    /*
        // this is so to have an easier place to edit
        public static IEnumerable Show()
        {








    M3.Out("p4 stateShowing script");

    // **** NOTE: i'll say it again: the individual dlgs are responsible for upping the turn #

    if (M3.GetInt("P4SupplyTurn") == 0) {
         // showtut
         GameFlags.SetGameFlagValue("TokenText", "Placeholder for show tutorial option");
         yield return Actions.OpenPopupBlocking(PopupIds.p4_popups_yn);

        if (GameFlags.P4PopupConfirm) {

            //*    	?show_tut = true
                 //    showPopup2("tut2")
                 //   showPopup2("tut3")
                  //  showPopup2("tut4")
                  // showPopup2("tut5")

        }
    }  // end tut


    if (M3.GetInt("P4SeasonCount") == 8) {
         M3.Out("declaration");

        GameFlags.SetGameFlagValue("TokenText", M3.declaration);
        yield return Actions.OpenPopupBlocking(PopupIds.p4_popups);            
    }

    string temp = "";

    // if it's turn 24 it is the end of the game
    if (M3.GetInt("P4SupplyTurn") == 24) {
        M3.Out("game over - win");
        GameFlags.SetGameFlagValue("TokenText", M3.pop_win);
        yield return Actions.OpenPopupBlocking(PopupIds.p4_popups);
        yield return Actions.LoadScene("part3_sum"); // move on

     }  else if ((M3.GetInt("P4StarveCount") == 3) && (M3.GetInt("P4SeasonCount") < 7)) {
                // third starve in a row
                // also end of the game
         GameFlags.SetGameFlagValue("TokenText", M3.pop_lose);
        yield return Actions.OpenPopupBlocking(PopupIds.p4_popups);

         yield return Actions.LoadScene("part3_sum");
    } else {
        // it's a NORMAL TURN
        M3.Out("normal turn");

        string dest = M3.GetString("P4AutoTrip");
        // check for auto trip
        if (dest != "") {
             // if something is assigned
             // do autotrip
             yield return Actions.MoveToHotspotBlocking("player", dest, 3f, 1f, 1f);
             GameFlags.SetGameFlagValue("P4AutoTrip", "");
        } else {
             M3.Out("no autotrip found");
             M3.Out("P4SupplyTurn " + M3.GetInt("P4SupplyTurn"));

             int seasonCount = M3.GetInt("P4SeasonCount");
             M3.Out("P4SeasonCount: " + seasonCount);

             if (seasonCount < 3)  {
                  // agency is not available
                  temp = "Choose a camp for the " + GameFlags.GetGameFlagValue<string>("P4Temp") + " season.";
             } else {
                  temp = "Choose a camp or the agency for the " + GameFlags.GetGameFlagValue<string>("P4Temp") + " season.";
             }

             // if player starts at an agency they have the option 
             // to stay there or find a different camp

             if ((GameFlags.GetGameFlagValue<string>("P4CurNode") == "agency")) {
                 M3.Out("beginning season at agency");
                 GameFlags.SetGameFlagValue("TokenText", M3.stayAgency);
                 yield return Actions.OpenPopupBlocking(PopupIds.p4_popups_yn);

                        if (GameFlags.P4PopupConfirm)
                        {
                            // stay
                            GameFlags.SetGameFlagValue("P4AtAgency", "true");

                            //     doTrip( $cur_node)    launch dlg

                        }
                        else
                        {
                            GameFlags.SetGameFlagValue("P4AtAgency", "false");
                            // go
                            if (GameFlags.GetGameFlagValue<bool>("P4Farming"))
                            {
                                GameFlags.SetGameFlagValue("TokenText", M3.pop_leaveCrops);
                                yield return Actions.OpenPopupBlocking(PopupIds.p4_popups_yn);

                                if (GameFlags.P4PopupConfirm)
                                {
                                    GameFlags.SetGameFlagValue("P4Farming", "false");
                                }

                                M3.SimpleAlert("", temp);
                            }
                        }
             } else  {
                   M3.Out("beginning season at a camp");
                   // if it's fall let them know about annuity
                   if (M3.GetInt("P4Season") == 4) {
                        M3.SimpleAlert("", "It is Fall. You can collect your annuity at the agency.");
                        //flashNode("AGENCY")
                   } else {
                        M3.SimpleAlert("", temp);  // otherwise tell them to make a choice
                                                   //flashNode($p3_camp1)
                                                   //flashNode($p3_camp2)
                        if ( M3.GetString("P4Camp3") == "skip" ) {
                                M3.Out("skipping 3rd winter camp flash");
                        } else {
                                //flashNode($p3_camp3)
                        }

                        if (M3.GetInt("P4SeasonCount") < 3)  {
                            M3.Out("agency is not available");
                        } else {
                            //flashNode("AGENCY")
                        }
                   }
             }
        }
    }








        } // Show

         */
}


/*
 * M3.Out("game over");
  GameFlags.TokenText = "You helped guide your people for two years. There is great uncertainty about the future. The treaty has been broken by both sides, and there is no more patience for broken promises...\n\nEND OF PART 4";
  yield return Actions.OpenPopupBlocking("p4_popups");			
  yield return Actions.LoadScene("p4_survival_sum");    if( GameFlags.P4AutoTrip != "") {
    // do autotrip
    yield return Actions.MoveToHotspotBlocking("player", GameFlags.P4AutoTrip, 3f, 1f, 1f);

      // handle otter creek
      // black_hills
      // hunting_grounds
}
yield return null;    Actions.OpenPopupBlocking("p4_popups");			
  yield return Actions.LoadScene("p4_survival_sum")*/


/*
 * 
				
	
		
		<popup id="pop_agency" template="short">
			<body>The Red Cloud Agency was built to give out supplies like blankets, kettles and tools once a year -- an annuity -- to Indian tribes in exchange for letting the white people pass through the land. The Agency will also provide rations, or food, to any tribe that camps nearby. Soldiers, at nearby Fort Robinson, guard the agency.</body>
			<choice id="c1"></choice>							
		</popup>
		
		<popup id="pop_bighorn_mountains" template="short">
			<body>Since I was a child we have camped here. There are often skirmishes with Crow and Shoshones. Once I saw an eagle carry off a buffalo calf to a high ridge in the Bighorn mountains.</body>
			<choice id="c1"></choice>							
		</popup>
		
		<popup id="pop_great_sioux" template="short">
			<body>The Sioux welcome us here, though some Cheyenne believe we should have our own reservation in this land.</body>
			<choice id="c1"></choice>							
		</popup>
		
		<popup id="pop_hunting_grounds" template="short">
			<body>The great treaty allows us to hunt in this territory as long as there are buffalo and we do not disturb the white people who are building homes here. But now that the iron horse runs nearby there are not as many buffalo as there once were.</body>
			<choice id="c1"></choice>							
		</popup>

		
		<popup id="pop_otter_creek" template="short">
			<body>My band often camps here near the Tongue River where wild turnips grow. There is good hunting with lots of small game along this creek.</body>
			<choice id="c1"></choice>							
		</popup>
		

		
		<popup id="pop_powder_river" template="short">
			<body>Many creeks flow into the Powder River giving us plenty of fresh water. The surrounding valley is covered in long grasses that feed our horses and the large herds of buffalo. In the summer, chokecherry bushes bear much fruit, which we dry for the winter.</body>
			<choice id="c1"></choice>							
		</popup>
		
		<popup id="pop_rosebud_creek" template="short">
			<body>The grassy hills and valleys around the Rosebud are home to all Cheyenne. We have held many dances, tribal councils, and ceremonies by these banks. I killed my first buffalo here.</body>
			<choice id="c1"></choice>							
		</popup>
		
		<popup id="pop_black_hills" template="short">
			<body>The old chiefs talk about how the creator gave our people this land, but now the whites think there is gold here and want to take the Black Hills from us.</body>
			<choice id="c1"></choice>							
		</popup>
		
		<popup id="pop_little_bighorn" template="short">
			<body>In the winter, the snow is deep but we are able to kill enough food to get us through it. We have fought many Shoshone and Crow warriors here.</body>
			<choice id="c1"></choice>							
		</popup>
		
		
	
				
			
		
		
		<popup id="pop_council" template="short">
			<body>The tribal elders call a great council to discuss relations with the white people.</body>
			<choice id="c1">Okay</choice>							
		</popup>
		
		
		
		
		
		
		
		
		<popup id="showtut" template="nextimage">
			<properties>
				<![CDATA[	
					{"list":[
						{
						    "type":"meta",
						    "template":"nextimage"
						},
						{
							"id":"choice02",
							"type":"button",
							"label":"No",
							"color":"0xffffff",
							"up_skin":"gfx/gui/int_button_up.png",
							"down_skin": "gfx/gui/int_button_down.png",
							"over_skin": "gfx/gui/int_button_over.png",
							"x":90,
							"y":260
						},
						{
							"id": "choice01",
							"label": "Yes",
							"x":220
						},
						{
							"id": "message",
							"text": "You will now help your Cheyenne band continue to survive on the Great Plains. Show tutorial?"
						},
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_01.jpg"
						}
					]}
				]]>
			</properties>
		</popup>
		<popup id="tut2" template="fullimagenext">
			<properties>
				<![CDATA[	
					{"list":[
						{
						    "type":"meta",
						    "template":"fullimagenext"
						},
						{ "id": "message",
						  "text":""
						},
						
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_02.png"
						}
					]}
				]]>
			</properties>
		</popup>
		<popup id="tut3" template="fullimagenext">
			<properties>
				<![CDATA[	
					{"list":[
						{
						    "type":"meta",
						    "template":"fullimagenext"
						},
						{ "id": "message",
						  "text":""
						},
						
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_03.png"
						}
					]}
				]]>
			</properties>
		</popup>
		<popup id="tut4" template="fullimagenext">
			<properties>
				<![CDATA[	
					{"list":[
						{
						    "type":"meta",
						    "template":"fullimagenext"
						},
						{ "id": "message",
						  "text":""
						},
						
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_04.png"
						}
					]}
				]]>
			</properties>
		</popup>
		<popup id="tut5" template="fullimagenext">
			<properties>
				<![CDATA[	
					{"list":[
						{
						    "type":"meta",
						    "template":"fullimagenext"
						},
						{ "id": "message",
						  "text":""
						},
						
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_05.png"
						}
					]}
				]]>
			</properties>
		</popup>
		
	</state>

	<!-- ****************************************************************** -->


	<!-- the master diaM3.Outue to run -->
	<state name="p3_master" comp="supply_player" next_state="p3_summary" next_transition="QUICKFADE">
		<component_property key="interchange" value="data/dlg/p3/map_supply/p3_map.xml"/>
		<component_property key="npc1" value="gfx/swfs/npcs/hed_sav.swf"/>

		<event type="stateShowing">
				<![CDATA[
				
				    M3.Out("supply player ")
					post("updateSurvivalStats", "")
					
					if( ?show_tut = true)					
						showPopup2("tut6")
						showPopup2("tut7")
						showPopup2("tut8")
						showPopup2("tut9")
						showPopup2("tut10")
						?show_tut = false				
					}
				]]>
		</event>
		<event type="stateInitialized">
				<![CDATA[
					showNpc(false,1)
					// figure out what bg to show
				
					pick( "P4Season" )
						= 1  // winter
							$scratch = "win"
						= 2  // spring
							$scratch = "spr"
						= 3  // summer
						 	$scratch = "sum"
						= 4  // fall
							$scratch = "fall"
					/pick
					
					$temp = "gfx/smartmap/map_supply/bg_" + $scratch + $root_node + ".jpg"
					
					setLayer("bg", $temp)
					
					?p3_prepped = false  // not ready for a hunt
					?p3_partied = false  // has not socialized	
					
					// debug
					//M3.Out("SETTING vid LAYER...")
					//setLayer("vid", "gfx/video/p3_buffalo.flv")			
				]]>
		</event>
		<popup id="tut6" template="fullimagenext">
			<properties>
				<![CDATA[	
					{"list":[
						{
						    "type":"meta",
						    "template":"fullimagenext"
						},
						{ "id": "message",
						  "text": ""
						},
						
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_06.png"
						}
					]}
				]]>
			</properties>
		</popup>
		<popup id="tut7" template="fullimagenext">
			<properties>
				<![CDATA[	
					{"list":[
						{
						    "type":"meta",
						    "template":"fullimagenext"
						},
						{ "id": "message",
						  "text": ""
						},
						
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_07.png"
						}
					]}
				]]>
			</properties>
		</popup>
		<popup id="tut8" template="fullimagenext">
			<properties>
				<![CDATA[	
					{"list":[
					    	{
							    "type":"meta",
							    "template":"fullimagenext"
							},
						{ "id": "message",
						  "text": ""
						},
						
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_08.png"
						}
					]}
				]]>
			</properties>
		</popup>
		<popup id="tut9" template="fullimagenext">
			<properties>
				<![CDATA[	
					{"list":[
						{
						    "type":"meta",
						    "template":"fullimagenext"
						},
						{ "id": "message",
						  "text": ""
						},
						
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_09.png"
						}
					]}
				]]>
			</properties>
		</popup>
		<popup id="tut10" template="fullimagenext">
			<properties>
				<![CDATA[	
					{"list":[
						{
						    "type":"meta",
						    "template":"fullimagenext"
						},
						{ "id": "message",
						  "text": ""
						},
						
						{ "id":"bg",
						  "path":"gfx/smartmap/map_supply/tut_10.png"
						}
					]}
				]]>
			</properties>
		</popup>
		
	</state>	
	
	<state name="p3_summary" comp="staticbackground" next_state="st_map_supply" next_transition="QUICKFADE">
		<component_property key="source" value="gfx/smartmap/map_supply/map_bg.jpg"/>
		<component_property key="next" value="false"/>
		<event type="stateRestored">
				<![CDATA[
					//M3.Out("state restored")
					//initSupplyGameRestore()
					//yield return Actions.LoadScene(("", "")
				]]>
		</event>
		<event type="stateShowing">
				<![CDATA[
					showPopup2("summary")
					if("P4Season" = 1 )
						// if winter
						M3.SimpleAlert("", "Your game has been saved as SPRING.")
						#CUR_PART_NUMBER = 4
						autoSave("SPRING")
						
						#temp = #p3_tribe_health + 4  // get into 2+ range
						m3Post(#temp, 33)
						
						
						
					}
					yield return Actions.LoadScene(("", "")
				]]>
		</event>
		<popup id="summary">
			<properties>
				<![CDATA[ 
		 				{"list":[
							{
								"type":"meta",
								"width":724,
								"height":300
							},

				 			{
								"id":"bg",
								"type":"image",
								"path":"gfx/smartmap/map_supply/summary_bg.jpg",
								"x":0,
								"y":0
			 	 			},
							{
								"id":"header",
								"type":"text",
								"text":"END OF SEASON",
								"font_size":18,
								"color":"0xce985c",
								"text_align":"center",
								"width": 724,
								"height": 30,
								"x":0,
								"y":5
							},
							{
								"id":"success_fb",
								"type":"text",
								"text":"###token|$p3_success_fb###",
								"font_size":16,
								"color":"0xce985c",
								"text_align":"left",
								"width": 670,
								"height": 45,
								"x":30,
								"y":50
							},
							
							{
								"id":"population_fb",
								"type":"text",
								"text":"###token|$p3_population_fb###",
								"font_size":16,
								"color":"0xce985c",
								"text_align":"left",
								"width": 670,
								"height": 45,
								"x":30,
								"y":100
							},
							{
								"id":"personal_fb",
								"type":"text",
								"text":"###token|$p3_personal_fb###",
								"font_size":16,
								"color":"0xce985c",
								"text_align":"left",
								"width": 670,
								"height": 45,
								"x":30,
								"y":150
							},
							{
								"id":"goal_fb",
								"type":"text",
								"text":"###token|$p3_goal_fb###",
								"font_size":16,
								"color":"0xce985c",
								"text_align":"left",
								"width": 670,
								"height": 45,
								"x":30,
								"y":200
							},
							{
								"id":"choice01",
								"type":"button",
								"label":"Next",
								"color":"0xffffff",
								"up_skin":"gfx/gui/int_button_up.png",
								"down_skin": "gfx/gui/int_button_down.png",
								"over_skin": "gfx/gui/int_button_over.png",
								"x":560,
								"y":260
							}
							]}
				]]>
			</properties>
			
		</popup>				
	</state>
	
</states>


    */
