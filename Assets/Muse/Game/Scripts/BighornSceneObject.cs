using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BighornSceneObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

#region nodes
/*
 <map id="p4_map_bighorn" width="800" height="600" >

	<background lib="">
		<bg_element path="gfx/smartmap/map_bighorn/bighorn_bg.jpg" x="0" y="0" visible="true"/>		
	</background>

	<node_click_script><![CDATA[
		
		//escapeNodePopup()
		
		return true		
	]]></node_click_script>


	<nodes lib="">
		
		
		
		<node id="n01" x="231" y="346" icon="gfx/smartmap/map_bighorn/tipi.png" visible="true" oneshot="false" connect="" tooltip="Cheyenne Camp" >
			<arrival_script>
				<![CDATA[
					// $root_node must be set elsewhere
					// b/c multiple entry points 						
					
					endState("p4_mn_n01_home", "")
				]]>
			</arrival_script>
		</node>	

		<node id="n02" x="531" y="449" icon="gfx/smartmap/map_bighorn/woods.png" visible="true" oneshot="false" connect="" tooltip="Reno's skirmish line south of camp">
			<arrival_script>
				<![CDATA[								
					
					endState("p4_mn_n02_skirmish", "")

				]]>
			</arrival_script>
		</node>	

		<node id="n03" x="663" y="399" icon="gfx/smartmap/map_bighorn/woods.png" visible="true" oneshot="false" connect="" tooltip="Woods">
			<arrival_script>
				<![CDATA[							
					endState("p4_mn_n03_woods", "")
				]]>
			</arrival_script>
		</node>	

		<node id="n04" x="644" y="208" icon="gfx/smartmap/map_bighorn/hill.png" visible="true" oneshot="false" connect="" tooltip="Reno Hill">	
		
			<arrival_script>
				<![CDATA[							
					endState("p4_mn_n04_renohill", "")
				]]>
			</arrival_script>
		</node>
		
		<node id="n05" x="179" y="309" icon="gfx/smartmap/map_bighorn/river.png" visible="true" oneshot="false" connect="" tooltip="Ford">
			<arrival_script>
				<![CDATA[							
					endState("p4_mn_n05_ford", "")			
				]]>
			</arrival_script>
		</node>
		

		<node id="n07" x="153" y="219" icon="gfx/smartmap/map_bighorn/hill.png" visible="true" oneshot="false" connect="" tooltip="Calhoun Ridge">
			<arrival_script>
				<![CDATA[												
					endState("p4_mn_n07_ridge", "")
				]]>
			</arrival_script>
		</node>



		<node id="n09" x="57" y="183" icon="gfx/smartmap/map_bighorn/hill.png" visible="true" oneshot="false" connect="" tooltip="Custer Hill">
			<arrival_script>
				<![CDATA[							
					endState("p4_mn_n09_custerhill", "")
				]]>
			</arrival_script>
		</node>		

		<node id="n10" x="85" y="270" icon="gfx/smartmap/map_bighorn/ravine.png" visible="true" oneshot="false" connect="" tooltip="Deep Ravine">
			<arrival_script>
				<![CDATA[							
					endState("p4_mn_n10_ravine", "")
				]]>
			</arrival_script>
		</node>


	</nodes>

	<pins lib="">
		<pin id="PIN_PLAYER" node="n01" icon="gfx/pins/pin_pla_lg_yellow.png" visible="true" offsetx="0" offsety="-10" radius="125" />		
	</pins>

	<foreground lib=""></foreground>

</map>

 */
#endregion

#region substates
/*
 * 
<states>

<state name="map_bighorn" comp="smartmap" next_state="" next_transition="CROSSFADE" >
    <component_property key="definition" value="data/maps/p4_map_bighorn.xml"/>
    <event type="stateInitialized">
        <![CDATA[ 
                    //$map_start_node = "creek1"
                updateInterface("INTERFACE|SHOW")
                log("init")

        ]]>
    </event>	

    <event type="stateShowing">
        <![CDATA[
            if(?p4_bighorn_start)
                ?p4_bighorn_start = false
                $root_node = "a"
                wait(2000)
                doTrip("n01")
            else
                $root_node = $next_root
                doTrip($trip_target)
            /if
        ]]>
    </event>



    <event type="stateEnded">
        <![CDATA[
            $map_start_node = $last_map_node
        ]]>
    </event>


</state>

<!-- bighorn map dlgs -->
<state name="p4_mn_n01_home" comp="interchangeplayer" next_state="map_bighorn" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/bighorn/p4_mn_n01_home.xml"/>
    <!--component_property key="bg" value="gfx/stills/NoPonies1.jpg"/-->
    <!--component_property key="fg" value=""/-->
    <component_property key="npc1" value="gfx/swfs/npcs/hed_sis_older.swf"/>
    <event type="stateInitialized">
        <![CDATA[				
            showNpc(false,1)
        ]]>
    </event>
    <event type="stateEnded">
        <![CDATA[	
            $map_start_node = "n01"
        ]]>
    </event>


</state>

<state name="p4_mn_n02_skirmish" comp="interchangeplayer" next_state="map_bighorn" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/bighorn/p4_mn_n02_skirmish.xml"/>
    <!--component_property key="bg" value="gfx/stills/NoPonies1.jpg"/-->
    <!--component_property key="fg" value=""/-->
    <event type="stateEnded">
        <![CDATA[	
            $map_start_node = "n02"
        ]]>
    </event>
</state>

<state name="p4_mn_n03_woods" comp="interchangeplayer" next_state="map_bighorn" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/bighorn/p4_mn_n03_woods.xml"/>
    <!--component_property key="bg" value="gfx/stills/NoPonies1.jpg"/-->
    <!--component_property key="fg" value=""/-->
    <event type="stateEnded">
        <![CDATA[	
            $map_start_node = "n03"
        ]]>
    </event>
</state>

<state name="p4_mn_n04_renohill" comp="interchangeplayer" next_state="map_bighorn" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/bighorn/p4_mn_n04_renohill.xml"/>
    <!--component_property key="bg" value="gfx/stills/NoPonies1.jpg"/-->
    <!--component_property key="fg" value=""/-->
    <event type="stateEnded">
        <![CDATA[	
            $map_start_node = "n04"
        ]]>
    </event>
</state>

<state name="p4_mn_n05_ford" comp="interchangeplayer" next_state="map_bighorn" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/bighorn/p4_mn_n05_ford.xml"/>
    <!--component_property key="bg" value="gfx/stills/NoPonies1.jpg"/-->
    <!--component_property key="fg" value=""/-->
    <event type="stateEnded">
        <![CDATA[	
            $map_start_node = "n05"
        ]]>
    </event>
</state>



<state name="p4_mn_n07_ridge" comp="interchangeplayer" next_state="map_bighorn" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/bighorn/p4_mn_n07_ridge.xml"/>
    <!--component_property key="bg" value="gfx/stills/NoPonies1.jpg"/-->
    <!--component_property key="fg" value=""/-->
    <event type="stateEnded">
        <![CDATA[	
            $map_start_node = "n07"
        ]]>
    </event>
</state>



<state name="p4_mn_n09_custerhill" comp="interchangeplayer" next_state="map_bighorn" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/bighorn/p4_mn_n09_custerhill.xml"/>
    <!--component_property key="bg" value="gfx/stills/NoPonies1.jpg"/-->
    <!--component_property key="fg" value=""/-->
    <event type="stateEnded">
        <![CDATA[	
            $map_start_node = "n09"
        ]]>
    </event>
</state>

<state name="p4_mn_n10_ravine" comp="interchangeplayer" next_state="map_bighorn" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/bighorn/p4_mn_n10_ravine.xml"/>
    <!--component_property key="bg" value="gfx/stills/NoPonies1.jpg"/-->
    <!--component_property key="fg" value=""/-->
    <event type="stateEnded">
        <![CDATA[	
            $map_start_node = "n10"
        ]]>
    </event>
</state>

<state name="p4_post_bighorn" comp="animplayer" next_state="p5_lwf_001" next_transition="CROSSFADE">
        <component_property key="file" value="gfx/swfs/anims/p4_post_bighorn.swf"/>
        <component_property key="skip" value="true"/>	
        <component_property key="type" value="anim"/>

    <event type="stateInitialized" runOnRestore="true">
        <![CDATA[ 
            updateGui("GUI|HIDE")
        ]]>
    </event>

</state>

<state name="p5_lwf_001" comp="interchangeplayer" next_state="p5_sis_001" next_transition="CROSSFADE" >
    <!--component_property key="interchange" value="data/dlg/p4/p5_lwf_001.xml"/-->
    <component_property key="interchange" value="data/dlg/p4/p5_lwf_001.xml"/>
    <component_property key="bg" value="gfx/stills/dlg/camp_day_bg.jpg"/>
    <component_property key="npc1" value="gfx/swfs/npcs/hed_ltw.swf"/>

    <event type="stateInitialized">
        <![CDATA[ 
                updateInterface("INTERFACE|SHOW")
        ]]>
    </event>

    <event type="stateEnded">
    </event>
</state>

<state name="p5_sis_001" comp="interchangeplayer" next_state="p5_post_dar" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/p5_sis_001.xml"/>
    <component_property key="bg" value="gfx/stills/dlg/camp_day_bg.jpg"/>
    <component_property key="npc1" value="gfx/swfs/npcs/hed_sis_older.swf"/>

    <event type="stateInitialized">

    </event>

    <event type="stateEnded">
    </event>
</state>




<state name="p5_post_dar" comp="animplayer" next_state="p5_split_001" next_transition="CROSSFADE">
        <component_property key="file" value="gfx/swfs/anims/p5_post_dar.swf"/>
        <component_property key="skip" value="true"/>
        <component_property key="type" value="anim"/>
    <event type="stateInitialized">
        <![CDATA[ 
                updateInterface("INTERFACE|HIDE")
        ]]>
    </event>
</state>

<state name="p5_split_001" comp="interchangeplayer" next_state="p5_dullknife" next_transition="CROSSFADE" >
    <component_property key="interchange" value="data/dlg/p4/p5_split.xml"/>
    <component_property key="bg" value="gfx/stills/dlg/p5_split.jpg"/>
    <event type="stateInitialized">
        <![CDATA[ 
                updateInterface("INTERFACE|SHOW")
        ]]>
    </event>

    <event type="stateEnded">
                if ($p5_split_choice = "littlewolf")
                    $next_state = "p5_littlewolf"
                /if
    </event>




</state>

<state name="p5_dullknife" comp="animplayer" next_state="part4_sum" next_transition="CROSSFADE">
        <component_property key="file" value="gfx/swfs/anims/p5_dullknife.swf"/>
        <component_property key="skip" value="true"/>	
        <component_property key="type" value="anim"/>
    <event type="stateInitialized">
        <![CDATA[ 
                updateInterface("INTERFACE|HIDE")
        ]]>
    </event>
</state>

<state name="p5_littlewolf" comp="animplayer" next_state="part4_sum" next_transition="CROSSFADE">
        <component_property key="file" value="gfx/swfs/anims/p5_littlewolf.swf"/>
        <component_property key="skip" value="true"/>	
        <component_property key="type" value="anim"/>
    <event type="stateInitialized">
        <![CDATA[ 
                updateInterface("INTERFACE|HIDE")
        ]]>
    </event>
</state>

</states>
*/
#endregion