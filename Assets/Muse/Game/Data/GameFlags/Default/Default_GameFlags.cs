//USING
using System.Collections.Generic;
//USING
///FOLDER TraitsSkills Default white
//USING
///GAMEFLAG_FOLDER P1HorseFail 
//USING
///GAMEFLAG_FOLDER P1HorseSuccess 
//USING
///GAMEFLAG_FOLDER tArchery TraitsSkills
//USING
///GAMEFLAG_FOLDER tBravery TraitsSkills
//USING
///GAMEFLAG_FOLDER tCrazy TraitsSkills
//USING
///GAMEFLAG_FOLDER tElkCount TraitsSkills
//USING
///GAMEFLAG_FOLDER tEnglish TraitsSkills
//USING
///GAMEFLAG_FOLDER tGenerosity TraitsSkills
//USING
///GAMEFLAG_FOLDER tHorseSense TraitsSkills
//USING
///GAMEFLAG_FOLDER tRiflery TraitsSkills
//USING
///GAMEFLAG_FOLDER tWisdom TraitsSkills
//USING
///GAMEFLAG_FOLDER version 
//USING
///GAMEFLAG_FOLDER zBool1 
//USING
///GAMEFLAG_FOLDER zBool2 
//USING
///GAMEFLAG_FOLDER zBool3 
//USING
///GAMEFLAG_FOLDER zInt1 
//USING
///GAMEFLAG_FOLDER zInt2 
//USING
///GAMEFLAG_FOLDER zInt3 
//USING
///GAMEFLAG_FOLDER zString1 
//USING
///GAMEFLAG_FOLDER zString2 
//USING
///GAMEFLAG_FOLDER zString3 
//USING
///GAMEFLAG_FOLDER MapMinutes 
//USING
///GAMEFLAG_FOLDER MapHours 
//USING
///GAMEFLAG_FOLDER MapDisplayMinutes 
//USING
///GAMEFLAG_FOLDER P1DressFinished 
//USING
///GAMEFLAG_FOLDER P1DressPacked 
//USING
///GAMEFLAG_FOLDER P1DressQuality 
//USING
///GAMEFLAG_FOLDER P1PrimerReturn 
//USING
///GAMEFLAG_FOLDER P1HasPrimer 
//USING
///GAMEFLAG_FOLDER P1HasInvitation 
//CLASS GameFlags
public static partial class GameFlags {
    //PROPERTY _P1HorseFail
    private static bool _P1HorseFail = false;

    //PROPERTY P1HorseFail
    public static bool P1HorseFail {
        get {
            ///PROPERTY_GETTER_START P1HorseFail
            return _P1HorseFail;
            ///PROPERTY_GETTER_END P1HorseFail
        }
        set {
            ///PROPERTY_SETTER_START P1HorseFail
            var oldValue = value;
_P1HorseFail = value;
GameFlagChanged("P1HorseFail", oldValue, value);
            ///PROPERTY_SETTER_END P1HorseFail
        }
    }

    //PROPERTY _P1HorseSuccess
    private static bool _P1HorseSuccess = false;

    //PROPERTY P1HorseSuccess
    public static bool P1HorseSuccess {
        get {
            ///PROPERTY_GETTER_START P1HorseSuccess
            return _P1HorseSuccess;
            ///PROPERTY_GETTER_END P1HorseSuccess
        }
        set {
            ///PROPERTY_SETTER_START P1HorseSuccess
            var oldValue = value;
_P1HorseSuccess = value;
GameFlagChanged("P1HorseSuccess", oldValue, value);
            ///PROPERTY_SETTER_END P1HorseSuccess
        }
    }

    //PROPERTY _tArchery
    private static int _tArchery = 0;

    //PROPERTY tArchery
    public static int tArchery {
        get {
            ///PROPERTY_GETTER_START tArchery
            return _tArchery;
            ///PROPERTY_GETTER_END tArchery
        }
        set {
            ///PROPERTY_SETTER_START tArchery
            var oldValue = value;
_tArchery = value;
GameFlagChanged("tArchery", oldValue, value);
            ///PROPERTY_SETTER_END tArchery
        }
    }

    //PROPERTY _tBravery
    private static int _tBravery = 0;

    //PROPERTY tBravery
    public static int tBravery {
        get {
            ///PROPERTY_GETTER_START tBravery
            return _tBravery;
            ///PROPERTY_GETTER_END tBravery
        }
        set {
            ///PROPERTY_SETTER_START tBravery
            var oldValue = value;
_tBravery = value;
GameFlagChanged("tBravery", oldValue, value);
            ///PROPERTY_SETTER_END tBravery
        }
    }

    //PROPERTY _tCrazy
    private static int _tCrazy = 0;

    //PROPERTY tCrazy
    public static int tCrazy {
        get {
            ///PROPERTY_GETTER_START tCrazy
            return _tCrazy;
            ///PROPERTY_GETTER_END tCrazy
        }
        set {
            ///PROPERTY_SETTER_START tCrazy
            var oldValue = value;
_tCrazy = value;
GameFlagChanged("tCrazy", oldValue, value);
            ///PROPERTY_SETTER_END tCrazy
        }
    }

    //PROPERTY _tElkCount
    private static int _tElkCount = 0;

    //PROPERTY tElkCount
    public static int tElkCount {
        get {
            ///PROPERTY_GETTER_START tElkCount
            return _tElkCount;
            ///PROPERTY_GETTER_END tElkCount
        }
        set {
            ///PROPERTY_SETTER_START tElkCount
            var oldValue = value;
_tElkCount = value;
GameFlagChanged("tElkCount", oldValue, value);
            ///PROPERTY_SETTER_END tElkCount
        }
    }

    //PROPERTY _tEnglish
    private static int _tEnglish = 0;

    //PROPERTY tEnglish
    public static int tEnglish {
        get {
            ///PROPERTY_GETTER_START tEnglish
            return _tEnglish;
            ///PROPERTY_GETTER_END tEnglish
        }
        set {
            ///PROPERTY_SETTER_START tEnglish
            var oldValue = value;
_tEnglish = value;
GameFlagChanged("tEnglish", oldValue, value);
            ///PROPERTY_SETTER_END tEnglish
        }
    }

    //PROPERTY _tGenerosity
    private static int _tGenerosity = 0;

    //PROPERTY tGenerosity
    public static int tGenerosity {
        get {
            ///PROPERTY_GETTER_START tGenerosity
            return _tGenerosity;
            ///PROPERTY_GETTER_END tGenerosity
        }
        set {
            ///PROPERTY_SETTER_START tGenerosity
            var oldValue = value;
_tGenerosity = value;
GameFlagChanged("tGenerosity", oldValue, value);
            ///PROPERTY_SETTER_END tGenerosity
        }
    }

    //PROPERTY _tHorseSense
    private static int _tHorseSense = 0;

    //PROPERTY tHorseSense
    public static int tHorseSense {
        get {
            ///PROPERTY_GETTER_START tHorseSense
            return _tHorseSense;
            ///PROPERTY_GETTER_END tHorseSense
        }
        set {
            ///PROPERTY_SETTER_START tHorseSense
            var oldValue = value;
_tHorseSense = value;
GameFlagChanged("tHorseSense", oldValue, value);
            ///PROPERTY_SETTER_END tHorseSense
        }
    }

    //PROPERTY _tRiflery
    private static int _tRiflery = 0;

    //PROPERTY tRiflery
    public static int tRiflery {
        get {
            ///PROPERTY_GETTER_START tRiflery
            return _tRiflery;
            ///PROPERTY_GETTER_END tRiflery
        }
        set {
            ///PROPERTY_SETTER_START tRiflery
            var oldValue = value;
_tRiflery = value;
GameFlagChanged("tRiflery", oldValue, value);
            ///PROPERTY_SETTER_END tRiflery
        }
    }

    //PROPERTY _tWisdom
    private static int _tWisdom = 0;

    //PROPERTY tWisdom
    public static int tWisdom {
        get {
            ///PROPERTY_GETTER_START tWisdom
            return _tWisdom;
            ///PROPERTY_GETTER_END tWisdom
        }
        set {
            ///PROPERTY_SETTER_START tWisdom
            var oldValue = value;
_tWisdom = value;
GameFlagChanged("tWisdom", oldValue, value);
            ///PROPERTY_SETTER_END tWisdom
        }
    }

    //PROPERTY _version
    private static string _version = "rc2_011521";

    //PROPERTY version
    public static string version {
        get {
            ///PROPERTY_GETTER_START version
            return _version;
            ///PROPERTY_GETTER_END version
        }
        set {
            ///PROPERTY_SETTER_START version
            var oldValue = value;
_version = value;
GameFlagChanged("version", oldValue, value);
            ///PROPERTY_SETTER_END version
        }
    }

    //PROPERTY _zBool1
    private static bool _zBool1 = false;

    //PROPERTY zBool1
    public static bool zBool1 {
        get {
            ///PROPERTY_GETTER_START zBool1
            return _zBool1;
            ///PROPERTY_GETTER_END zBool1
        }
        set {
            ///PROPERTY_SETTER_START zBool1
            var oldValue = value;
_zBool1 = value;
GameFlagChanged("zBool1", oldValue, value);
            ///PROPERTY_SETTER_END zBool1
        }
    }

    //PROPERTY _zBool2
    private static bool _zBool2 = false;

    //PROPERTY zBool2
    public static bool zBool2 {
        get {
            ///PROPERTY_GETTER_START zBool2
            return _zBool2;
            ///PROPERTY_GETTER_END zBool2
        }
        set {
            ///PROPERTY_SETTER_START zBool2
            var oldValue = value;
_zBool2 = value;
GameFlagChanged("zBool2", oldValue, value);
            ///PROPERTY_SETTER_END zBool2
        }
    }

    //PROPERTY _zBool3
    private static bool _zBool3 = false;

    //PROPERTY zBool3
    public static bool zBool3 {
        get {
            ///PROPERTY_GETTER_START zBool3
            return _zBool3;
            ///PROPERTY_GETTER_END zBool3
        }
        set {
            ///PROPERTY_SETTER_START zBool3
            var oldValue = value;
_zBool3 = value;
GameFlagChanged("zBool3", oldValue, value);
            ///PROPERTY_SETTER_END zBool3
        }
    }

    //PROPERTY _zInt1
    private static int _zInt1 = 0;

    //PROPERTY zInt1
    public static int zInt1 {
        get {
            ///PROPERTY_GETTER_START zInt1
            return _zInt1;
            ///PROPERTY_GETTER_END zInt1
        }
        set {
            ///PROPERTY_SETTER_START zInt1
            var oldValue = value;
_zInt1 = value;
GameFlagChanged("zInt1", oldValue, value);
            ///PROPERTY_SETTER_END zInt1
        }
    }

    //PROPERTY _zInt2
    private static int _zInt2 = 0;

    //PROPERTY zInt2
    public static int zInt2 {
        get {
            ///PROPERTY_GETTER_START zInt2
            return _zInt2;
            ///PROPERTY_GETTER_END zInt2
        }
        set {
            ///PROPERTY_SETTER_START zInt2
            var oldValue = value;
_zInt2 = value;
GameFlagChanged("zInt2", oldValue, value);
            ///PROPERTY_SETTER_END zInt2
        }
    }

    //PROPERTY _zInt3
    private static int _zInt3 = 0;

    //PROPERTY zInt3
    public static int zInt3 {
        get {
            ///PROPERTY_GETTER_START zInt3
            return _zInt3;
            ///PROPERTY_GETTER_END zInt3
        }
        set {
            ///PROPERTY_SETTER_START zInt3
            var oldValue = value;
_zInt3 = value;
GameFlagChanged("zInt3", oldValue, value);
            ///PROPERTY_SETTER_END zInt3
        }
    }

    //PROPERTY _zString1
    private static string _zString1 = "";

    //PROPERTY zString1
    public static string zString1 {
        get {
            ///PROPERTY_GETTER_START zString1
            return _zString1;
            ///PROPERTY_GETTER_END zString1
        }
        set {
            ///PROPERTY_SETTER_START zString1
            var oldValue = value;
_zString1 = value;
GameFlagChanged("zString1", oldValue, value);
            ///PROPERTY_SETTER_END zString1
        }
    }

    //PROPERTY _zString2
    private static string _zString2 = "";

    //PROPERTY zString2
    public static string zString2 {
        get {
            ///PROPERTY_GETTER_START zString2
            return _zString2;
            ///PROPERTY_GETTER_END zString2
        }
        set {
            ///PROPERTY_SETTER_START zString2
            var oldValue = value;
_zString2 = value;
GameFlagChanged("zString2", oldValue, value);
            ///PROPERTY_SETTER_END zString2
        }
    }

    //PROPERTY _zString3
    private static string _zString3 = "";

    //PROPERTY zString3
    public static string zString3 {
        get {
            ///PROPERTY_GETTER_START zString3
            return _zString3;
            ///PROPERTY_GETTER_END zString3
        }
        set {
            ///PROPERTY_SETTER_START zString3
            var oldValue = value;
_zString3 = value;
GameFlagChanged("zString3", oldValue, value);
            ///PROPERTY_SETTER_END zString3
        }
    }

    //PROPERTY _MapMinutes
    private static int _MapMinutes = 540;

    //PROPERTY MapMinutes
    public static int MapMinutes {
        get {
            ///PROPERTY_GETTER_START MapMinutes
            return _MapMinutes;
            ///PROPERTY_GETTER_END MapMinutes
        }
        set {
            ///PROPERTY_SETTER_START MapMinutes
            var oldValue = value;
_MapMinutes = value;
GameFlagChanged("MapMinutes", oldValue, value);
            ///PROPERTY_SETTER_END MapMinutes
        }
    }

    //PROPERTY _MapHours
    private static int _MapHours = 0;

    //PROPERTY MapHours
    public static int MapHours {
        get {
            ///PROPERTY_GETTER_START MapHours
            return _MapHours;
            ///PROPERTY_GETTER_END MapHours
        }
        set {
            ///PROPERTY_SETTER_START MapHours
            var oldValue = value;
_MapHours = value;
GameFlagChanged("MapHours", oldValue, value);
            ///PROPERTY_SETTER_END MapHours
        }
    }

    //PROPERTY _MapDisplayMinutes
    private static int _MapDisplayMinutes = 0;

    //PROPERTY MapDisplayMinutes
    public static int MapDisplayMinutes {
        get {
            ///PROPERTY_GETTER_START MapDisplayMinutes
            return _MapDisplayMinutes;
            ///PROPERTY_GETTER_END MapDisplayMinutes
        }
        set {
            ///PROPERTY_SETTER_START MapDisplayMinutes
            var oldValue = value;
_MapDisplayMinutes = value;
GameFlagChanged("MapDisplayMinutes", oldValue, value);
            ///PROPERTY_SETTER_END MapDisplayMinutes
        }
    }

    //PROPERTY _P1DressFinished
    private static bool _P1DressFinished = false;

    //PROPERTY P1DressFinished
    public static bool P1DressFinished {
        get {
            ///PROPERTY_GETTER_START P1DressFinished
            return _P1DressFinished;
            ///PROPERTY_GETTER_END P1DressFinished
        }
        set {
            ///PROPERTY_SETTER_START P1DressFinished
            var oldValue = value;
_P1DressFinished = value;
GameFlagChanged("P1DressFinished", oldValue, value);
            ///PROPERTY_SETTER_END P1DressFinished
        }
    }

    //PROPERTY _P1DressPacked
    private static bool _P1DressPacked = false;

    //PROPERTY P1DressPacked
    public static bool P1DressPacked {
        get {
            ///PROPERTY_GETTER_START P1DressPacked
            return _P1DressPacked;
            ///PROPERTY_GETTER_END P1DressPacked
        }
        set {
            ///PROPERTY_SETTER_START P1DressPacked
            var oldValue = value;
_P1DressPacked = value;
GameFlagChanged("P1DressPacked", oldValue, value);
            ///PROPERTY_SETTER_END P1DressPacked
        }
    }

    //PROPERTY _P1DressQuality
    private static int _P1DressQuality = 0;

    //PROPERTY P1DressQuality
    public static int P1DressQuality {
        get {
            ///PROPERTY_GETTER_START P1DressQuality
            return _P1DressQuality;
            ///PROPERTY_GETTER_END P1DressQuality
        }
        set {
            ///PROPERTY_SETTER_START P1DressQuality
            var oldValue = value;
_P1DressQuality = value;
GameFlagChanged("P1DressQuality", oldValue, value);
            ///PROPERTY_SETTER_END P1DressQuality
        }
    }

    //PROPERTY _P1PrimerReturn
    private static bool _P1PrimerReturn = false;

    //PROPERTY P1PrimerReturn
    public static bool P1PrimerReturn {
        get {
            ///PROPERTY_GETTER_START P1PrimerReturn
            return _P1PrimerReturn;
            ///PROPERTY_GETTER_END P1PrimerReturn
        }
        set {
            ///PROPERTY_SETTER_START P1PrimerReturn
            var oldValue = value;
_P1PrimerReturn = value;
GameFlagChanged("P1PrimerReturn", oldValue, value);
            ///PROPERTY_SETTER_END P1PrimerReturn
        }
    }

    //PROPERTY _P1HasPrimer
    private static bool _P1HasPrimer = false;

    //PROPERTY P1HasPrimer
    public static bool P1HasPrimer {
        get {
            ///PROPERTY_GETTER_START P1HasPrimer
            return _P1HasPrimer;
            ///PROPERTY_GETTER_END P1HasPrimer
        }
        set {
            ///PROPERTY_SETTER_START P1HasPrimer
            var oldValue = value;
_P1HasPrimer = value;
GameFlagChanged("P1HasPrimer", oldValue, value);
            ///PROPERTY_SETTER_END P1HasPrimer
        }
    }

    //PROPERTY _P1HasInvitation
    private static bool _P1HasInvitation = false;

    //PROPERTY P1HasInvitation
    public static bool P1HasInvitation {
        get {
            ///PROPERTY_GETTER_START P1HasInvitation
            return _P1HasInvitation;
            ///PROPERTY_GETTER_END P1HasInvitation
        }
        set {
            ///PROPERTY_SETTER_START P1HasInvitation
            var oldValue = value;
_P1HasInvitation = value;
GameFlagChanged("P1HasInvitation", oldValue, value);
            ///PROPERTY_SETTER_END P1HasInvitation
        }
    }
}
//CLASS_END GameFlags
