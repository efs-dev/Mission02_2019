using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;

public class SurvivalTopBar : MonoBehaviour
{
    public GameObject Contents;
    public TMP_Text People;
    public TMP_Text Status;
    public TMP_Text Food;
    public TMP_Text Supplies;
    public TMP_Text Date;
    public TMP_Text Location;

    public List<Image> SeasonBanners;

    public void Update()
    {
        People.text = "People: " + GameFlags.GetGameFlagValue<int>("P4Population");
        Status.text = "Status: " + SurvivalGame.condition.Capitalize(true);

        var year = GameFlags.GetGameFlagValue<int>("P4SeasonCount") <= 4 ? 1874 : 1875;
        Date.text = GameFlags.GetGameFlagValue<string>("P4SeasonStr").Capitalize() + " " + year;

        for (var i = 0; i < SeasonBanners.Count; i++)
        {
            SeasonBanners[i].gameObject.SetActive(GameFlags.GetGameFlagValue<int>("P4Season") == (i+1));
        }

        Location.text = GameFlags.GetGameFlagValue<string>("P4Location");

        var deltaFood = GameFlags.GetGameFlagValue<float>("P4Population") - GameFlags.GetGameFlagValue<int>("P4Food");
        if (deltaFood > 0)
            Food.text = "Food: " + GameFlags.GetGameFlagValue<int>("P4Food") + "\n<size=28>(Need " + deltaFood + ")</size>";
        else if (deltaFood < 0)
            Food.text = "Food: " + GameFlags.GetGameFlagValue<int>("P4Food") + "\n<size=28>(" + -deltaFood + " surplus)</size>";
        else
            Food.text = "Food: " + GameFlags.GetGameFlagValue<int>("P4Food");

        Supplies.text = "Supplies: " + GameFlags.GetGameFlagValue<int>("P4Supplies");

        var wasShowingContents = Contents.activeSelf;
        Contents.SetActive(!GuiManager.GetInstance().SettingsLayer.activeSelf && !GuiManager.GetInstance().BadgeLayer.activeSelf && !GuiManager.GetInstance().SmartwordsLayer.activeSelf);

        if (Contents.activeSelf && !wasShowingContents)
        {
            // lower the top right buttons
            var rt = GuiManager.GetInstance().TopRightButtons.GetComponent<RectTransform>();
            var pos = rt.anchoredPosition;
            pos.y = -976;
            rt.anchoredPosition = pos;
        }
        else if (!Contents.activeSelf && wasShowingContents)
        {
            // raise the top right buttons
            var rt = GuiManager.GetInstance().TopRightButtons.GetComponent<RectTransform>();
            var pos = rt.anchoredPosition;
            pos.y = -768;
            rt.anchoredPosition = pos;
        }
    }

}
