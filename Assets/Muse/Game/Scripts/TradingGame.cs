#define SKIPPY

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


#if !IGNORE_CUSTOM_SCRIPTS

public static class TradingGame {
    /*
    #region vars
    public static bool DEBUG = true;
    static string breadcrumb = "";

    public static string NEXT_SCENE_ID = "loc_test";

    private static string lastItemClickedId;

    public static int trader_item_count = 0;   // table has no trader items
    public static int player_item_count = 0; // table has no player items
    public static int num_offers = 0; // player has not made any offers yet
    public static int max_offers = 5; // the max number of offers if at least one successful trade has been made. 
    public static int num_fair_offers = 0; // the number of offers that have been accepted/happily accepted by trader.
    public static int items_traded_for = 0; // final number of items you have traded for.  P2NumItemsTradedFor
    public static int total_trade = 0;

    public static int num_happily_fair_offers = 0;
    public static int num_unfair_offers = 0;
    public static int num_angrily_unfair_offers = 0;
    public static int fair_offer_modifier = 6; // the bonus on the trader's attitude from when you offer a fair trade.
    public static int unfair_offer_modifier = -6; //the bonus on the trader's attitude from when you make an unfair trade.
    public static int wisdom_bonus_modifier = 3; //wisdom bonus modifier
    public static int trader_happily_accepts = 35;
    public static int trader_accepts = 10;
    public static int trader_not_accepts = -10;
    public static int trader_angrily_not_accepts = -35;
    public static int attitude_offset_min_cap = -30;
    public static int attitude_offset_max_cap = 50;
    public static int attitude_offset = 0;

    public static int wisdom_offset; // init to = #T_WISDOM * #wisdom_bonus_modifier

    public static int unadjusted_attitude_offset; // init to = #attitude_offset - #wisdom_offset


    public static bool made_trade = false; //player has not made any successful trades yet.
    public static bool lak_helped = false; //has Many Horses helped you?
    public static bool lak_warned_you = false; //has Many Horses warned you about making bad trades?
    public static bool lak_warned_you2 = false;
    public static bool asked_spyglass = false;
    public static bool asked_knife = false;
    public static bool asked_money = false;
    public static bool accepted_offer_wisdom = false; //have you gotten a message already saying how your wisdom helped you
    public static bool warned_gun = false;
    public static bool sweetening_mode = false;
    public static bool lak_money_comment = false;
    public static string last_popup_choice = String.Empty;
    public static int offers_wisdom;  // used by dlg

    public static bool p2_hides1_on_table;
    public static bool p2_hides2_on_table;
    public static bool p2_hides3_on_table;
    public static bool p2_spyglass_on_table;
    public static bool p2_money_on_table;
    public static bool p2_large_knife_on_table;
    public static bool p2_robe_on_table;
    public static bool p2_powder1_on_table;
    public static bool p2_powder2_on_table;
    public static bool p2_hat_on_table;
    public static bool p2_gun_on_table;
    public static bool p2_blanket_on_table;
    public static bool p2_kettle_on_table;
    public static bool p2_axe_on_table;
    public static bool current_offer_rejected;

    static List<Hotspot> traderList = new List<Hotspot>();
    static List<Hotspot> playerList = new List<Hotspot>();
    static List<Hotspot> tradeZoneList = new List<Hotspot>();

    static Dictionary<string, Vector3> itemOrigPosition;
    static Dictionary<string, Vector3> itemTablePosition;
    static Dictionary<string, int> itemValue;


    static TradingGameSceneObject sceneObject = TradingGameSceneObject.GetInstance();

    //public static bool popupClosed;  // to control pop duration outside MUSE loop

    //public static bool DEBUG_SWEETEN_ACCEPT = false;
    //public static bool DEBUG_SWEETEN_REJECT = false;

    public static TMPro.TextMeshPro debugText;
    */

    // private static string dLG_RESULT = String.Empty;

    //public static bool OFFER_FINISHED = false;
    //public static bool END_GAME = false;

    /*
    public static string DLG_RESULT
    {
        get
        {
            return dLG_RESULT;
        }

        set
        {
            //Debug.Log("DLG_RESULT set to " + value);
            dLG_RESULT = value;
        }
    }
    #endregion
    */


    /*
    static bool hasSpyglass = GameFlags.GetGameFlagValue<bool>("HasSpyglass");
    static bool P2SpyglassTraded = GameFlags.GetGameFlagValue<bool>("P2SpyglassTraded");
    static bool hasLargeKnife = GameFlags.GetGameFlagValue<bool>("HasLargeKnife");
    static bool P2LargeKnifeTraded = GameFlags.GetGameFlagValue<bool>("P2LargeKnifeTraded");
    */

    /*
    public static void AddToTraderList(string itemId)
    {
        itemId = itemId.ToUpper();
        var item = Actions.GetHotspot(itemId);
        traderList.Add(item);
    }

    public static void AddToPlayerList(string itemId)
    {
        itemId = itemId.ToUpper();
        var item = Actions.GetHotspot(itemId);
        playerList.Add(item);
    }
    */

    /*
    private static IEnumerator AngrilyDoesntAcceptOffer()
    {
        Debug.Log("angrily doesn't accept offer");
        breadcrumb += " >> " + "angrily doesn't";
#if !SKIP
        //       Debug.Log("angrily not accepting offer")
        if (current_offer_rejected)
        {
            popupClosed = false;
            Actions.OpenPopup("p2_not_changed");
            //Actions.OpenPopup(PopupIds.p2_not_changed); // tested 5/14 ("You have not even changed your offer. Did you think I would not notice?"
            yield return new WaitUntil(() => popupClosed);
            breadcrumb += " >> " + "not changed";
        }
        else if (num_angrily_unfair_offers == 0)
        {
            //Debug.Log("ShowPopup " + "p2_new_trader");
            popupClosed = false;
            Actions.OpenPopup("p2_new_trader");
            //Actions.OpenPopup(PopupIds.p2_new_trader);
            yield return new WaitUntil(() => popupClosed);
            // "You are indeed a new trader. This offer is too much in your favor.",

            //Debug.Log("*** lakota is warning you!!! ***");
            popupClosed = false;
            Actions.OpenPopup("p2_lak_warn");
            //Actions.OpenPopup(PopupIds.p2_lak_warn);
            yield return new WaitUntil(() => popupClosed);
            // TODO test("Think carefully about your offers, Little Fox. If they are unfair, the trader will not trust you.", 
            breadcrumb += " >> " + "too much ur favor - lak warn";

        }
        else if (num_angrily_unfair_offers == 1)
        {
            popupClosed = false;
            Actions.OpenPopup("p2_trader_looking");
            //Actions.OpenPopup(PopupIds.p2_trader_looking);
            yield return new WaitUntil(() => popupClosed);
            // TODO test Are we looking at the same trade? Absolutely not.", 
            breadcrumb += " >> " + "looking at same?";
        }
        else  // num_angrily > 1
        {
            popupClosed = false;
            Actions.OpenPopup("p2_trader_cannot");
            //Actions.OpenPopup(PopupIds.p2_trader_cannot);
            yield return new WaitUntil(() => popupClosed);
            // TODO test("I cannot trade with someone who does not respect the value of my items."
            breadcrumb += " >> " + "no respect";
        }

        current_offer_rejected = true;
        num_angrily_unfair_offers += 1;

        UpdateTraderAttitude("negative");

        yield return IsFinishedTrading();
#else
        yield return null;
#endif
    }
    */

    /*  
  // clear contents of trading table and flags
  static void ClearTable()
  {
      //Debug.Log("ClearTable()");

      foreach (var item in tradeZoneList)
      {
          GameObject.Destroy(item.gameObject);
      }

      // reset the bool on table vars
      p2_powder1_on_table = false;
      p2_powder2_on_table = false;
      p2_gun_on_table = false;
      p2_hat_on_table = false;
      p2_blanket_on_table = false;
      p2_kettle_on_table = false;
      p2_axe_on_table = false;
      p2_spyglass_on_table = false;
      p2_money_on_table = false;
      p2_hides1_on_table = false;
      p2_hides2_on_table = false;
      p2_hides3_on_table = false;
      p2_large_knife_on_table = false;
      p2_robe_on_table = false;
      tradeZoneList.Clear();

  }
  */

    /*
public static void Init()
{
    //Debug.Log("Trading Game Init()");

    // in scene object for coroutines
    if (sceneObject == null)
    {
        Debug.Log("null scene object");
    }

#if !SKIP
    itemOrigPosition = new Dictionary<string, Vector3>();
    itemTablePosition = new Dictionary<string, Vector3>();
    itemValue = new Dictionary<string, int>();

    // create inventory lists
    traderList = new List<Hotspot>();
    playerList = new List<Hotspot>();
    tradeZoneList = new List<Hotspot>();

#region populate inventory lists
    AddToTraderList("powder1");
    AddToTraderList("powder2");
    AddToTraderList("gun");
    AddToTraderList("hat");
    AddToTraderList("blanket");
    AddToTraderList("kettle");

    AddToPlayerList("spyglass");
    AddToPlayerList("hides1");
    AddToPlayerList("hides2");
    AddToPlayerList("hides3");
    AddToPlayerList("money");
    AddToPlayerList("knife");
    AddToPlayerList("robe");
#endregion


    trader_item_count = 0;   // table has no trader items
    player_item_count = 0; // table has no player items
    num_offers = 0; // player has not made any offers yet
    max_offers = 5; // the max number of offers if at least one successful trade has been made. 
    num_fair_offers = 0; // the number of offers that have been accepted/happily accepted by trader.
    items_traded_for = 0; // final number of items you have traded for.

    num_happily_fair_offers = 0;
    num_unfair_offers = 0;
    num_angrily_unfair_offers = 0;
    fair_offer_modifier = 6; // the bonus on the trader's attitude from when you offer a fair trade.
    unfair_offer_modifier = -6; //the bonus on the trader's attitude from when you make an unfair trade.
    wisdom_bonus_modifier = 3; //wisdom bonus modifier
    trader_happily_accepts = 35;
    trader_accepts = 10;
    trader_not_accepts = -10;
    trader_angrily_not_accepts = -35;
    attitude_offset_min_cap = -30;
    attitude_offset_max_cap = 50;
    attitude_offset = 0;


    wisdom_offset = GameFlags.GetGameFlagValue<int>("tWisdom") * wisdom_bonus_modifier;
    attitude_offset = wisdom_offset;
    unadjusted_attitude_offset = attitude_offset - wisdom_offset;


    made_trade = false; //player has not made any successful trades yet.
    lak_helped = false; //has Many Horses helped you?
    lak_warned_you = false; //has Many Horses warned you about making bad trades?
    lak_warned_you2 = false;
    asked_spyglass = false;
    asked_knife = false;
    asked_money = false;
    accepted_offer_wisdom = false; //have you gotten a message already saying how your wisdom helped you
    warned_gun = false;
    sweetening_mode = false;
    lak_money_comment = false;
#endif

    debugText = (TextMeshPro)GameObject.Find("debug").GetComponent<TextMeshPro>();
    if (debugText == null) Debug.LogError("null debugText");
}
*/

    /*
static void UpdateDebug()
{
    debugText.text = "attitude offset: " + attitude_offset;
    debugText.text += ", total trade: " + total_trade;
    debugText.text += " (adjusted trade: " + (total_trade + attitude_offset) + ")";
    debugText.text += "\ncur offer rejected: " + current_offer_rejected;
    debugText.text += "\nnum_offers: " + num_offers + ", num_fair_offers: " + num_fair_offers + ", num_happily_fair: " +
        num_happily_fair_offers + ", num_unfair: " + num_unfair_offers + ", num_angrily_unfair: " + num_angrily_unfair_offers;
    debugText.text += "\n" + breadcrumb;
}*/
/*
    public static IEnumerator OnDropInTradeZone(Hotspot item)
    {
#if !SKIP
        //Debug.Log("OnDropInTradeZone() " + item.Id);

        // something have been dropped in trade area

        var id = item.Id.ToUpper();
        var value = itemValue[id];

        // if it's player item, add to total trade value, if trader, subtract
        if (id == "HIDES1" || id == "HIDES2" || id == "HIDES3" || id == "MONEY" || id == "SPYGLASS" || id == "LARGE_KNIFE" || id == "ROBE") {
            player_item_count += 1;
            total_trade += value;
        } else {
            // it's a trader item
            trader_item_count += 1; // there is at least one trader item
            total_trade -= value;
        }

        //UpdateDebug();

        // track which item added
        switch (id) {
            case "HIDES1":
                p2_hides1_on_table = true; break;
            case "HIDES2":
                p2_hides2_on_table = true; break;
            case "HIDES3":
                p2_hides3_on_table = true; break;
            case "MONEY":
                p2_money_on_table = true;

                if ((lak_money_comment == false) && GameFlags.GetGameFlagValue<bool>("P1BoughtKnife")) {
                    Actions.OpenPopup("p2_lak_money1");
                    // If you had not already bought a knife from me, your money would be worth a kettle and powder and shot. Now it is maybe worth a blanket.", "gfx/stills/mh_thumb.png", "Okay.", 16)
                    lak_money_comment = true;
                } else if ((lak_money_comment == false) && (GameFlags.GetGameFlagValue<bool>("P1AskedMoney"))) {
                    Actions.OpenPopup("p2_lak_money2");
                    // Ah, I am glad you have held on to that money. I believe it is worth a kettle and powder and shot.", "gfx/stills/mh_thumb.png", "Okay.", 16)
                    lak_money_comment = true;
                } else if (lak_money_comment == false) {
                    Actions.OpenPopup("p2_lak_money3");
                    // "Little Fox, you must tell me how you came across this money. I believe it is worth a kettle and powder and shot.", "gfx/stills/mh_thumb.png", "Okay.", 16)
                    lak_money_comment = true;
                }

                break;
            case "SPYGLASS":
                p2_spyglass_on_table = true; break;
            case "LARGE_KNIFE":
                p2_large_knife_on_table = true; break;
            case "ROBE":
                p2_robe_on_table = true; break;
            case "POWDER1":
                p2_powder1_on_table = true; break;
            case "POWDER2":
                p2_powder2_on_table = true; break;
            case "GUN":
                p2_gun_on_table = true;
                if (warned_gun == false) {
                    Actions.OpenPopup("p2_trader_fine_gun");
                    // That is a fine weapon. You will need a big offer to convince me to trade it.", "gfx/stills/trader_small.png", "Okay", 16)
                    warned_gun = true;
                }

                break;
            case "HAT":
                p2_hat_on_table = true; break;
            case "BLANKET":
                p2_blanket_on_table = true; break;
            case "KETTLE":
                p2_kettle_on_table = true; break;
            case "AXE":
                p2_axe_on_table = true; break;
        } // switch

        if ((num_offers == 0) && (player_item_count >= 4) && (lak_warned_you2 == false)) {
            Actions.OpenPopup("p2_lak_smaller");
            // You have put many items down on the table, Little Fox. But maybe you should make a smaller trade first, to see what your robes are worth.
            lak_warned_you2 = true;
        }

        //Debug.Log("total " + total_trade);
        current_offer_rejected = false;
#endif
        yield return null; // minimum stub
    }
    */
    /*
    // item removed from table
    public static IEnumerator OnItemRemoved(Hotspot item)
    {
        var id = item.Id.ToUpper();
        var value = itemValue[id];

        //ebug.Log("heard item removed");
        //Debug.Log("THE ID IS " + id);

        if (id == "HIDES1" || id == "HIDES2" || id == "HIDES3" || id == "MONEY" || id == "SPYGLASS" || id == "LARGE_KNIFE" || id == "ROBE")
        {
            player_item_count -= 1;
            total_trade -= value;
        }
        else
        {
            // it's a trader item
            trader_item_count -= 1;
            total_trade += value;
        }

        // track which item removed
        switch (id)
        {
            case "HIDES1":
                p2_hides1_on_table = false; break;
            case "HIDES2":
                p2_hides2_on_table = false; break;
            case "HIDES3":
                p2_hides3_on_table = false; break;
            case "MONEY":
                p2_money_on_table = false;
                break;
            case "SPYGLASS":
                p2_spyglass_on_table = false; break;
            case "LARGE_KNIFE":
                p2_large_knife_on_table = false; break;
            case "ROBE":
                p2_robe_on_table = false; break;
            case "POWDER1":
                p2_powder1_on_table = false; break;
            case "POWDER2":
                p2_powder2_on_table = false; break;
            case "GUN":
                p2_gun_on_table = false;
                break;
            case "HAT":
                p2_hat_on_table = false; break;
            case "BLANKET":
                p2_blanket_on_table = false; break;
            case "KETTLE":
                p2_kettle_on_table = false; break;
            case "AXE":
                p2_axe_on_table = false; break;

        }

        //Debug.Log("value:" + value);
        //Debug.Log("trader attitude " + attitude_offset);
        //Debug.Log("total " + total_trade);
        current_offer_rejected = false;  // reset


        //UpdateDebug();

        yield return null;
    }
    */

    /*
#region SetItemTablePosition set item coord spaces on tables
    public static void SetItemTablePosition(string itemId, string spotId)
    {
        itemId = itemId.ToUpper();
        var item = Actions.GetHotspot(itemId);
        var spot = Actions.GetHotspot(spotId);


        //Debug.Log("SetItemTablePosition() " + itemId + " " + spot.transform.position);

        itemOrigPosition[itemId] = item.transform.position;
        itemTablePosition[itemId] = spot.transform.position;


    }
#endregion

    public static void SetItemValue(string itemId, int value)
    {
        itemId = itemId.ToUpper();
        //Debug.Log("SetItemValue() " + itemId + " " + value);

        itemValue[itemId] = value;
    }
    */

    /*
    public static void Start()
    {
        //Debug.Log("Trading Game Start() 19");
        if (Input.multiTouchEnabled)
        {
            Debug.LogWarning("TODO multitouch not supported");
        }

    }


    // toggle positions, etc
    public static void TradeItemClicked(string itemId)
    {
        //itemClickedLock = true;  // ? obsolete ?

        //Debug.Log("TradingGame starting coroutine on scene obj");

        sceneObject.StartCoroutine(_TradeItemClicked(itemId));
    }


    // internal
    static IEnumerator _TradeItemClicked(string itemId)
    {
        itemId = itemId.ToUpper();

        Debug.Log("trade item clicked: " + itemId);

        var item = Actions.GetHotspot(itemId);

        var orig = itemOrigPosition[itemId];
        var spot = itemTablePosition[itemId];

        lastItemClickedId = itemId;

        if (tradeZoneList.Contains(item))
        {
            item.transform.position = orig;  // move back
            tradeZoneList.Remove(item);
            traderList.Add(item);
            yield return OnItemRemoved(item);
        }
        else if (traderList.Contains(item))
        {
            item.transform.position = spot;  // move to table
            traderList.Remove(item);
            tradeZoneList.Add(item);
            yield return OnDropInTradeZone(item);
        }
        else
        {
            item.transform.position = spot;  // move to table
            playerList.Remove(item);
            tradeZoneList.Add(item);
            yield return OnDropInTradeZone(item);
        }
    }
    */

    /*
    public static void MakeOffer()
    {
        OFFER_FINISHED = false;

        Debug.Log("MakeOffer()");
        breadcrumb += "\n" + "MakeOffer ";

        sceneObject.StartCoroutine(_MakeOffer());
    }

    // internal implementation
    static IEnumerator _MakeOffer()
    {
        num_offers += 1;   //          Debug.Log("NUM OFFERS INCREMENT 1")

        int adjusted_trade = total_trade + attitude_offset;

        UpdateDebug();

        if (adjusted_trade >= trader_happily_accepts)
        {
            // heavily in trader's favor
            yield return HappilyAcceptOffer();
        }
        else if (adjusted_trade >= trader_accepts)
        {
            yield return AcceptOffer();
        }
        else if ((adjusted_trade < trader_accepts) && (adjusted_trade >= trader_not_accepts))
        {
            yield return ConsiderOffer();
        }
        else if ((adjusted_trade < trader_not_accepts) && (adjusted_trade >= trader_angrily_not_accepts))
        {
            yield return DoesntAcceptOffer();
        }
        else
        {
            // trader angrily does not accept
            yield return AngrilyDoesntAcceptOffer();
        }

        Debug.Log("_MakeOffer() finished");
        OFFER_FINISHED = true;
        yield return null;
    }
    */

        /*
    private static IEnumerator DoesntAcceptOffer()
    {
        Debug.Log("doesn't accept offer");
       
            breadcrumb += " >> " + "doesn't accept";
#if !SKIP
            if (DEBUG_SWEETEN_ACCEPT || DEBUG_SWEETEN_REJECT)
            {
                sweetening_mode = true;
            }

            

        if (hasSpyglass && (asked_spyglass == false) && (p2_spyglass_on_table == false) && (P2SpyglassTraded == false)
                && ((total_trade + 10) > (trader_accepts - attitude_offset)))
            {

                asked_spyglass = true;
                // TODO test
                popupClosed = false;
                Actions.OpenPopup("p2_sweeten_spyglass");
                yield return new WaitUntil(() => popupClosed);
                sweetening_mode = true;
                breadcrumb += " >> " + "sweeten spyglass";
            }
            else if (hasLargeKnife && (asked_knife == false) && (p2_large_knife_on_table == false) && (GameFlags.GetGameFlagValue<bool>("P2LargeKnifeTraded") == false) &&
                   ((total_trade + 20) > (trader_accepts - attitude_offset)))
            {
                asked_knife = true;
                // TODO test
                popupClosed = false;
                Actions.OpenPopup("p2_sweeten_knife");
                yield return new WaitUntil(() => popupClosed);
                sweetening_mode = true;
                breadcrumb += " >> " + "sweeten knife";

            }
            else if (GameFlags.GetGameFlagValue<bool>("HasMoney") && GameFlags.GetGameFlagValue<bool>("P1BoughtKnife") && (asked_money == false) && (p2_money_on_table == false) && (GameFlags.GetGameFlagValue<bool>("P2MoneyTraded") == false) &&
             ((total_trade + 25) > (trader_accepts - attitude_offset)))
            {
                asked_money = true;
                // TODO test
                popupClosed = false;
                Actions.OpenPopup("p2_sweeten_money2");
                yield return new WaitUntil(() => popupClosed);
                sweetening_mode = true;
                breadcrumb += " >> " + "sweeten money2";
            }
            else if (GameFlags.GetGameFlagValue<bool>("HasMoney") && (GameFlags.GetGameFlagValue<bool>("P1BoughtKnife") == false) && (asked_money == false) && (p2_money_on_table == false) && (GameFlags.GetGameFlagValue<bool>("P2MoneyTraded") == false) &&
            ((total_trade + 50) > (trader_accepts - attitude_offset)))
            {
                asked_money = true;
                // TODO test
                popupClosed = false;
                Actions.OpenPopup("p2_sweeten_money1");
                yield return new WaitUntil(() => popupClosed);
                breadcrumb += " >> " + "sweeten money1";
                //< body > Now where would a young Cheyenne boy come across four dollars? You've got no use for that. Add the money, and we can finish this trade.</body>
                //< choice id = "sweeten_add_item" > I will add the money.</ choice >        
                //< choice id = "sweeten_deal_with_it" > No, the trade will stay the same.</ choice >
                // SG seems like a bug in the orig. sweetening was always set true, even if you rejected
                if (DLG_RESULT == "YES") sweetening_mode = true;

            }
            else if (current_offer_rejected)
            {
                // TODO test
                popupClosed = false;
                Actions.OpenPopup("p2_not_changed");
                yield return new WaitUntil(() => popupClosed);
                // "You have not even changed your offer. Did you think I would not notice?", 
                breadcrumb += " >> " + "not changed";
            }
            else if (num_unfair_offers == 0)
            {
                popupClosed = false;
                Actions.OpenPopup("p2_not_accept");
                yield return new WaitUntil(() => popupClosed);
                // "I do not accept your offer. Please offer more of your items, or request less of mine.

                IsFinishedTrading();
                breadcrumb += " >> " + "offer more";
            }
            else if (num_unfair_offers == 1)
            {
                popupClosed = false;
                Actions.OpenPopup("p2_not_quite");
                yield return new WaitUntil(() => popupClosed);
                // "This offer is not quite fair for me. Please make another offer.",
                breadcrumb += " >> " + "not quite";
            }
            else
            {
                popupClosed = false;
                Actions.OpenPopup("p2_less_valuable");
                yield return new WaitUntil(() => popupClosed);
                // TODO test ("Your items are less valuable than you think. I cannot make this trade.", 
                breadcrumb += " >> " + "less valuable";
            }

            breadcrumb += " >> " + "how did we get here?";


            if (sweetening_mode)
            {
                Debug.Log("in sweetening mode");
                sweetening_mode = false;

                if (last_popup_choice == "sweeten_deal_with_it")
                {
                    int randRoll = UnityEngine.Random.Range(1, 101);
                    Debug.Log("RANDROLL VALUE " + randRoll);

                    if (randRoll >= 70 || DEBUG_SWEETEN_ACCEPT)
                    {
                        popupClosed = false;
                        Actions.OpenPopup("p2_sweeten_accept");
                        yield return new WaitUntil(() => popupClosed);
                        // TODO test ("sweeten_accept")
                        TradeSuccess();
                    }
                    else
                    {
                        popupClosed = false;
                        Actions.OpenPopup("p2_sweeten_reject");
                        yield return new WaitUntil(() => popupClosed);
                        // TODO  test("sweeten_reject")
                    }
                }
                else
                {
                    num_offers -= 1; //want to give the player a chance to place it on the table
                    num_unfair_offers -= 1;
                    //Debug.Log("NUM OFFERS DECREMENT FROM SWEETEN");
                }
            }

            yield return IsFinishedTrading();

            num_unfair_offers += 1;
            current_offer_rejected = true;
#endif
        
        yield return null;
    }
    */

        /*
    private static IEnumerator ConsiderOffer()
    {
        //Debug.Log("consider offer");
        breadcrumb += " >> " + "consider";
#if !SKIP
        if (current_offer_rejected == false) {
            DLG_RESULT = String.Empty;  // clear
            popupClosed = false;
            Actions.OpenPopup("p2_wisdom_exchange");
            yield return new WaitUntil(() => popupClosed);
            //TODO test ("wisdom_exchange")

            offers_wisdom += 1;
            yield return HandleTraderWisdom();
            breadcrumb += " >> " + "wisdom exchange";
        } else if (current_offer_rejected) {
            popupClosed = false;
            Actions.OpenPopup("p2_not_changed");
            yield return new WaitUntil(() => popupClosed);
            // TODO test "You have not even changed your offer. Did you think I would not notice?", 
            breadcrumb += " >> " + "haven't  changed";
            IsFinishedTrading();

        }
#endif
        yield return null;
    }
    */

        /*
    private static IEnumerator HandleTraderWisdom()
    {
        Debug.Log("HandleTraderWisdom()");

        switch (DLG_RESULT)
        {
            case "ACCEPT_OFFER":
                yield return AcceptOffer();
                break;
            case "DOESNT_ACCEPT_OFFER":
                yield return DoesntAcceptOffer();
                break;
            case "":
                // ignore
                Debug.Log("ignoring");
                break;
            default:
                Debug.LogError("HandleTraderWisdom - Unhandled case: " + DLG_RESULT);
                break;
        }
        yield return null;
    }
    */

        /*
    private static IEnumerator AcceptOffer()
    {
        Debug.Log("accept offer");
        breadcrumb += " >> " + "accept";
#if !SKIP

        if ((num_fair_offers + num_happily_fair_offers) == 0) {
            popupClosed = false;
            Actions.OpenPopup("p2_fair_deal");
            yield return new WaitUntil(() => popupClosed);
            //// TODO test p2_fair_deal ("A fair deal!", 

        } else if ((num_fair_offers + num_happily_fair_offers) == 1) {
            popupClosed = false;
            Actions.OpenPopup("p2_another_offer");
            yield return new WaitUntil(() => popupClosed);
            //// TODO test p2_another_offer ("Another offer, another deal.", 

        } else {
            popupClosed = false;
            Actions.OpenPopup("p2_another_fair_deal");
            yield return new WaitUntil(() => popupClosed);
            //  TODO test p2_another_fair ("Another fair deal! You are an excellent trading partner.",

        }

        if (num_fair_offers == 0) {
            popupClosed = false;
            Actions.OpenPopup("p2_this_good");
            yield return new WaitUntil(() => popupClosed);
            //TODO p2_this_good ("This is good, Little Fox. The more fair trades you make, the more the trader will trust you."
        }

        yield return TradeSuccess();

        num_fair_offers += 1;
        current_offer_rejected = false;
#endif
        yield return null;
    }
    */

        /*
    private static IEnumerator HappilyAcceptOffer()
    {
        Debug.Log("happily accept offer");
        breadcrumb += " >> " + "happily accept";
#if !SKIP
        if (num_happily_fair_offers == 0 && (lak_warned_you == false)) {
            popupClosed = false;
            Actions.OpenPopup("p2_ask_more");// TODO test
            // ("Little Fox, I think you can ask for more. Why don't you request another item from the trader?",
            //[Many Horses speaks to you in Cheyenne so the trader cannot understand.]
            yield return new WaitUntil(() => popupClosed);
            
            num_offers -= 1; //from the "make offer" event
            //Debug.Log("NUM OFFERS DECREMENT FROM MANY HORSES");
            num_happily_fair_offers -= 1; //from the "make offer" event
            lak_warned_you = true;

            popupClosed = false;
            Actions.OpenPopup("p2_let_boy"); //  ("Let the boy make his own trades, Many Horses."
            yield return new WaitUntil(() => popupClosed);
            // TODO test

        } else if (num_happily_fair_offers == 0) {
            popupClosed = false;
            Actions.OpenPopup("p2_willing");
            yield return new WaitUntil(() => popupClosed);
            // TODO test ("You're willing to make this trade? Well, that's fine with me.", 

            yield return TradeSuccess();

        } else if (num_happily_fair_offers >= 1) {
            popupClosed = false;
            Actions.OpenPopup("p2_great_trade");
            yield return new WaitUntil(() => popupClosed);
            // TODO test ("This is a great trade. I accept.", 

            yield return TradeSuccess();

        }
        num_happily_fair_offers += 1;
        current_offer_rejected = false;
#endif
        yield return null;
    }
    */

        /*
    public static IEnumerator TradeSuccess()
    {
#if !SKIP
        //Debug.Log("DO YOU HAVE THE HIDE?? " + hasItem('ITEM_HIDES1'))
        Debug.Log("trade success");
        breadcrumb += " >> " + "TradeSuccess";
        made_trade = true;

        UpdateTraderAttitude("positive");

        // add items gotten in trade			
        if (p2_powder1_on_table) {
            GameFlags.SetGameFlagValue("P2Powder1Traded", true);
        }

        if (p2_powder2_on_table)
        {
            GameFlags.SetGameFlagValue("P2Powder2Traded", true);
        }

        if (p2_gun_on_table)
        {
            GameFlags.SetGameFlagValue("P2GunTraded", true);
            GameFlags.SetGameFlagValue("P4GunCount", GameFlags.GetGameFlagValue<int>("P4GunCount") + 1);
        }

        if (p2_blanket_on_table)
        {
            GameFlags.SetGameFlagValue("P2BlanketTraded", true);
        }

        if (p2_kettle_on_table)
        {
            GameFlags.SetGameFlagValue("P2KettleTraded", true);
        }

        if (p2_axe_on_table)
        {
            GameFlags.SetGameFlagValue("P2AxeTraded", true);
        }

        if (p2_hat_on_table)
        {
            GameFlags.SetGameFlagValue("P2HatTraded", true);
        }

        // remove traded items				
        if (p2_money_on_table)
        {
            GameFlags.SetGameFlagValue("P2MoneyTraded", true);
        }

        if (p2_hides1_on_table)
        {
            GameFlags.SetGameFlagValue("P2Hides1Traded", true);
        }

        if (p2_hides2_on_table)
        {
            GameFlags.SetGameFlagValue("P2Hides2Traded", true);
        }

        if (p2_hides3_on_table)
        {
            GameFlags.SetGameFlagValue("P2Hides3Traded", true);
        }

        if (p2_robe_on_table)
        {
            GameFlags.SetGameFlagValue("P2RobeTraded", true);
        }

        if (p2_spyglass_on_table)
        {
            GameFlags.SetGameFlagValue("P2SpyglassTraded", true);
        }

        if (p2_large_knife_on_table) {
            p2_large_knife_on_table = false;
            GameFlags.SetGameFlagValue("P2LargeKnifeTraded", true);
        }

        ClearTable();

        player_item_count = 0;
        trader_item_count = 0;
        total_trade = 0;
#endif
        yield return IsFinishedTrading();

    }
    */

        /*
    public static IEnumerator IsFinishedTrading()
    {
        Debug.Log("IsFinishedTrading()");
        breadcrumb += " >> " + "finished? ";
#if !SKIP

        Debug.Log("player item count " + player_item_count);
        //Debug.Log( " is money on table " + p2_money_on_table);
        //Debug.Log( " is spyglass on table " + p2_spyglass_on_table);
        //Debug.Log( " is knife on table " + p2_large_knife_on_table);

        
        if ( ( (GameFlags.GetGameFlagValue<bool>("HasMoney") == false) || GameFlags.GetGameFlagValue<bool>("P2MoneyTraded")) && 
            GameFlags.GetGameFlagValue<bool>("P2Hides1Traded") && GameFlags.GetGameFlagValue<bool>("P2Hides2Traded") && GameFlags.GetGameFlagValue<bool>("P2Hides3Traded") && GameFlags.GetGameFlagValue<bool>("P2RobeTraded") &&
            ((GameFlags.GetGameFlagValue<bool>("HasSpyglass") == false) || GameFlags.GetGameFlagValue<bool>("P2SpyglassTraded")) &&
            ((GameFlags.GetGameFlagValue<bool>("HasLargeKnife") == false) || GameFlags.GetGameFlagValue<bool>("P2LargeKnifeTraded")) &&
            GameFlags.GetGameFlagValue<bool>("P2Powder1Traded") && GameFlags.GetGameFlagValue<bool>("P2Powder2Traded") && GameFlags.GetGameFlagValue<bool>("P2GunTraded") && GameFlags.GetGameFlagValue<bool>("P2BlanketTraded") && GameFlags.GetGameFlagValue<bool>("P2KettleTraded") && GameFlags.GetGameFlagValue<bool>("P2AxeTraded") && GameFlags.GetGameFlagValue<bool>("P2HatTraded")) {
            // TODO test
            popupClosed = false;
            Actions.OpenPopup("p2_both_traded_all");
            yield return new WaitUntil(() => popupClosed);
            //hint("Both you and the trader have traded all your items.")
            breadcrumb += " >> " + "traded all!";
            END_GAME = true;
        } else if ( ( (!GameFlags.GetGameFlagValue<bool>("HasMoney")) || GameFlags.GetGameFlagValue<bool>("P2MoneyTraded")) &&
            GameFlags.GetGameFlagValue<bool>("P2Hides1Traded") && GameFlags.GetGameFlagValue<bool>("P2Hides2Traded") && GameFlags.GetGameFlagValue<bool>("P2Hides3Traded") && GameFlags.GetGameFlagValue<bool>("P2RobeTraded") && 
            (( ! GameFlags.GetGameFlagValue<bool>("HasSpyglass")) || GameFlags.GetGameFlagValue<bool>("P2SpyglassTraded")) && 
            ((! GameFlags.GetGameFlagValue<bool>("HasLargeKnife") ) || GameFlags.GetGameFlagValue<bool>("P2LargeKnifeTraded"))) { 
            // TODO test
            popupClosed = false;
            Actions.OpenPopup("p2_fox_none_left"); //hint("You have no items left to trade.")
            yield return new WaitUntil(() => popupClosed);
            breadcrumb += " >> " + "you: none left";
            END_GAME = true;
        } else if  (GameFlags.GetGameFlagValue<bool>("P2Powder1Traded") && GameFlags.GetGameFlagValue<bool>("P2Powder2Traded") && GameFlags.GetGameFlagValue<bool>("P2GunTraded") && GameFlags.GetGameFlagValue<bool>("P2BlanketTraded") && GameFlags.GetGameFlagValue<bool>("P2KettleTraded") && GameFlags.GetGameFlagValue<bool>("P2AxeTraded") 
            && GameFlags.GetGameFlagValue<bool>("P2HatTraded")) { 
                //TODO test
                popupClosed = false;
                Actions.OpenPopup("p2_trader_none_left");  //hint("The trader has no items left to trade.")
                yield return new WaitUntil(() => popupClosed);
                END_GAME = true;
                breadcrumb += " >> " + "trader none left";
        } else if  (num_offers >= max_offers && made_trade) {
                // TODO test
                popupClosed = false;
                Actions.OpenPopup("p2_made_enough"); // hint("You have made enough offers to the trader.")
                yield return new WaitUntil(() => popupClosed);
				END_GAME = true;
            breadcrumb += " >> " + "made enough";
        } else if  (made_trade && (DLG_RESULT != "YES")) { 
			if (num_offers == 4) {
                popupClosed = false;
                Actions.OpenPopup("p2_new_trade1"); //You have 1 offer left. Would you like to make another offer?
                yield return new WaitUntil(() => popupClosed);
                breadcrumb += " >> " + "1 left";
                // TODO test
            } else if (num_offers == 3) { 
                popupClosed = false;
                Actions.OpenPopup("p2_new_trade2"); //You have 2 offers left. Would you like to make another offer?</body>
                yield return new WaitUntil(() => popupClosed);
                breadcrumb += " >> " + "2 left";
                // TODO test
            } else if (num_offers == 2) {
                popupClosed = false;
                Actions.OpenPopup("p2_new_trade3"); //You have 3 offers left. Would you like to make another offer?</body>
                yield return new WaitUntil(() => popupClosed);
                // TODO test
                breadcrumb += " >> " + "3 left";
            } else if (num_offers == 1) {
                popupClosed = false;
                Actions.OpenPopup("p2_new_trade4"); // You have 4 offers left. Would you like to make another offer?</body>
                yield return new WaitUntil(() => popupClosed);
                // TODO test
                breadcrumb += " >> " + "4 left";
            }

            // HACK:  To fix problem where the minigame ends when the player refuses to sweeten a deal, the below is commented out.

			//if (DLG_RESULT == "NO") {
				//END_GAME = true;
			//}
		} else if  ((made_trade == false) && (DLG_RESULT != "YES")) {
			if (num_offers == 4) {
                popupClosed = false;
                Actions.OpenPopup("p2_new_trade1_nosuccess"); //showPopup("new_trade1_nosuccess")
                yield return new WaitUntil(() => popupClosed);
                // TODO test
                breadcrumb += " >> " + "1 left no success";
            } else if (num_offers == 3) {
                popupClosed = false;
                Actions.OpenPopup("p2_new_trade2_nosuccess");
                yield return new WaitUntil(() => popupClosed);
                // TODO test
                breadcrumb += " >> " + "2 left no success";
            } else if (num_offers == 2) {
                popupClosed = false;
                Actions.OpenPopup("p2_new_trade3_nosuccess");
                yield return new WaitUntil(() => popupClosed);
                //showPopup("new_trade3_nosuccess")
                breadcrumb += " >> " + "3 left no success";
            } else if (num_offers == 1) {
				//showPopup("new_trade4_nosuccess")
                popupClosed = false;
                Actions.OpenPopup("p2_new_trade4_nosuccess");
                yield return new WaitUntil(() => popupClosed);
                breadcrumb += " >> " + "4 left no success";
            } else if  (num_offers > 4) {
				//showPopup("new_trade_inf")
                popupClosed = false;
                Actions.OpenPopup("p2_new_trade_inf"); // You have made at least five offers, but you have not yet made a successful trade. Please make another offer.
                yield return new WaitUntil(() => popupClosed);
                breadcrumb += " >> " + "5+ no success";
            }
		} else if(DLG_RESULT == "sweeten_add_item") {
			DLG_RESULT = "";
		}
        UpdateDebug();

#endif
        yield return null;
    }
   */

        
    public static void MakeTrade()
    {
        Debug.Log("make trade() ");

#if !SKIP
        /*
          
                  // player has clicked the submit button

                  Debug.Log("make trade");
                  Debug.Log("total trade value " + #total_trade)
                  Debug.Log("# trader items " + #trader_item_count)
                  Debug.Log("# player items " + #player_item_count)
                  Debug.Log ("trader attitude " + #attitude_offset)

                  if ((trader_item_count == 0) AND (#player_item_count == 0))
                      hint("You haven't placed any items on the table. Drag items onto the table to trade them.")

                  // if trader has put nothing on the table, or nobody has put anything on the table

                  else if {(trader_item_count = 0)
                      hint("You must trade for at least one item. Drag one of the trader's items down to the table.")
                      //// showPopupEx("Please let me know what you would like to trade for.", "gfx/stills/trader_small.png", "Okay", 16)

                  // if trader has put something on table, but player has not put anything on table
                  else if {(player_item_count = 0)
                      hint("You must offer at least one item to the trader. Drag one of your items up to the table.")

                  else
                      makeOffer();
                  }
              */
#endif
    }

    /*
    static void UpdateTraderAttitude(string trade_type)
    {
        Debug.Log("update attitude: " + trade_type);
        if (trade_type == "positive") {
            if (attitude_offset < attitude_offset_max_cap)
            {
                attitude_offset += fair_offer_modifier;
                unadjusted_attitude_offset += fair_offer_modifier;
            }
        } else if (trade_type == "negative") {

            if (attitude_offset > attitude_offset_min_cap)
            {
                attitude_offset += unfair_offer_modifier;
                unadjusted_attitude_offset += unfair_offer_modifier;
            }

        }
    }
    */

        /*
    // TODO add to makeOffer
    public static IEnumerator End()
    {
        Debug.Log("End()");
#if !SKIP
        GameFlags.SetGameFlagValue("P2TradedAll", true);



        if (unadjusted_attitude_offset < 0) {
            popupClosed = false;
            Actions.OpenPopup("p2_grumble");
            yield return new WaitUntil(() => popupClosed);
            //test info p2_grumble
            //hint("The trader grumbles about something to Many Horses. You leave the trading room.")
        } else {
            popupClosed = false;
            Actions.OpenPopup("p2_come_again"); // The trader thanks you and says that he hopes you come again. You leave the trading room.")
            yield return new WaitUntil(() => popupClosed);
            //test 
        }

        // add items gotten in trade			
        if (GameFlags.GetGameFlagValue<bool>("P2Powder1Traded")) {
            //addItem("ITEM_POWDER1")
            Debug.Log("TRADED FOR POWEDER1");
            items_traded_for += 1;
        }

        if (GameFlags.GetGameFlagValue<bool>("P2Powder2Traded")) {
            //addItem("ITEM_POWDER2")
            items_traded_for += 1;
            Debug.Log("TRADED FOR POWEDER2");
        }

        if (GameFlags.GetGameFlagValue<bool>("P2GunTraded")) {
            //addItem("ITEM_MUSKET")
            items_traded_for += 1;
            GameFlags.SetGameFlagValue("P4GunCount", GameFlags.GetGameFlagValue<int>("P4GunCount") + 1);
            Debug.Log("TRADED FOR MUSKET");
        }

        if (GameFlags.GetGameFlagValue<bool>("P2BlanketTraded")) {
            //addItem("ITEM_BLANKET")

            Debug.Log("TRADED FOR BLANKET");
            items_traded_for += 1;
        }

        if (GameFlags.GetGameFlagValue<bool>("P2KettleTraded")) {
            // addItem("ITEM_KETTLE")

            Debug.Log("TRADED FOR KETTLE");
            items_traded_for += 1;
        }

        if (GameFlags.GetGameFlagValue<bool>("P2AxeTraded")) {
            //addItem("ITEM_AXE")

            Debug.Log("TRADED FOR AXE");
            items_traded_for += 1;
        }

        if (GameFlags.GetGameFlagValue<bool>("P2HatTraded")) {
            //addItem("ITEM_HAT")

            Debug.Log("TRADED FOR HAT");
            items_traded_for += 1;
        }

        // set P2NumItemsTradedFor to items_traded_for

        GameFlags.SetGameFlagValue("P2NumItemsTradedFor", items_traded_for);

        // remove traded items				

        if (GameFlags.GetGameFlagValue<bool>("P2MoneyTraded")) {
            //removeItem("ITEM_MONEY")
        } else if (GameFlags.GetGameFlagValue<bool>("HasMoney")) { 
            GameFlags.SetGameFlagValue("P2TradedAll", false);
        }
				
	    if(GameFlags.GetGameFlagValue<bool>("P2Hides1Traded")) {
                    //removeItem("ITEM_HIDES1")
    } else {
            GameFlags.SetGameFlagValue("P2TradedAll", false);

         }

        if (GameFlags.GetGameFlagValue<bool>("P2Hides2Traded")) {
            //removeItem("ITEM_HIDES2")
        } else {
            GameFlags.SetGameFlagValue("P2TradedAll", false);

        }

        if (GameFlags.GetGameFlagValue<bool>("P2Hides3Traded")) {
            //removeItem("ITEM_HIDES3")
        } else {
            GameFlags.SetGameFlagValue("P2TradedAll", false);

        }

        if (GameFlags.GetGameFlagValue<bool>("P2RobeTraded")) {
            //removeItem("ITEM_ROBE")
        } else {
            GameFlags.SetGameFlagValue("P2TradedAll", false);

          }

        if (GameFlags.GetGameFlagValue<bool>("P2SpyglassTraded")) {
            //removeItem("ITEM_SPYGLASS")
        } else if ( GameFlags.GetGameFlagValue<bool>("HasSpyglass")) {
            GameFlags.SetGameFlagValue("P2TradedAll", false);
        }

        if (GameFlags.GetGameFlagValue<bool>("P2LargeKnifeTraded")) {
            //removeItem("ITEM_LARGEKNIFE")
        } else if (GameFlags.GetGameFlagValue<bool>("HasLargeKnife")) {
            GameFlags.SetGameFlagValue("P2TradedAll", false);
		}
				
        // TODO      NEXT_SCENE_ID = "p2_trade_return";  // TODO the real place to nav to
#else
        yield return null;
#endif
    }
    */

   
}

#endif