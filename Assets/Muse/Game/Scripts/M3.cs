using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public static class M3  {

    // specify a dynamic text alert
    public static void SimpleAlert(string header, string desc)
    {
        MuseEngine.GetInstance().StartCoroutine(GuiManager.GetInstance().OnAlert(header, desc));
    }

    public static int SetInt(string id, int val)
    {
        GameFlags.SetGameFlagValue(id, "" + val);
        return val;
    }

    public static int GetInt(string id)
    {
        return GameFlags.GetGameFlagValue<int>(id);
    }

    public static string GetString(string id) {
        return GameFlags.GetGameFlagValue<string>(id);
    }

    public static int IncFlag(string name, int amount)
    {
        int value = GameFlags.GetGameFlagValue<int>(name) + amount;
        GameFlags.SetGameFlagValue(name, "" + value);

        // return new value
        return GameFlags.GetGameFlagValue<int>(name);
    }

    public static void Out(string msg)
    {
        Debug.Log(msg);
    }

    public static string StartWithCap(string s)
    {
                    // Check for empty string.  
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.  
            return char.ToUpper(s[0]) + s.Substring(1);
        
    }

    // string extension method
    public static string ToTitleCase(this string title)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
    }


    public const string pop_win = "You helped guide your people for two years. There is great uncertainty about the future. The treaty has been broken by both sides, and there is no more patience for broken promises...\n\nEND OF PART 4";
    public const string pop_lose = "Starving, your band is forced to seek aid at the Red Cloud Agency, where you receive enough rations to survive.In the winter of 1875, Agent Saville tells you that the government has declared that all Indians who are not at the agency or a reservation will be considered hostile.You miss your way of life, but it seems that now it is gone forever.";
    public const string declaration = "A Declaration...\n\nA scout from the Agency approaches your band and says: 'Because of treaty violations, all Indians must settle on the reservations by January 31st 1876. If you refuse to obey this order you will be considered hostile to the United States and soldiers will be sent to force you onto a reservation.'";
    public const string pop_leaveCrops = "You abandon your crops and decide to return to your way of life.";
    public const string stayAgency = "Do you want to stay at this agency this season?";
} // class


