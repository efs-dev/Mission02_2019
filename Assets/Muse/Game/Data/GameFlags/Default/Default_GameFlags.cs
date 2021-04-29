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
//USING
///GAMEFLAG_FOLDER P1CookWarning 
//USING
///GAMEFLAG_FOLDER P1SarMad 
//USING
///GAMEFLAG_FOLDER P1HasAuctionPoster 
//USING
///GAMEFLAG_FOLDER P1FirstDoc 
//USING
///GAMEFLAG_FOLDER P1ComfreyComplete 
//USING
///GAMEFLAG_FOLDER P1ComfreyTried 
//USING
///GAMEFLAG_FOLDER P1EstComfrey 
//USING
///GAMEFLAG_FOLDER P1HasComfrey 
//USING
///GAMEFLAG_FOLDER P1KnowLexington 
//USING
///GAMEFLAG_FOLDER P1KnowEstDawsons 
//USING
///GAMEFLAG_FOLDER P2EscapeType 
//USING
///GAMEFLAG_FOLDER P1KnowKingTime 
//USING
///GAMEFLAG_FOLDER P1TotalTasks 
//USING
///GAMEFLAG_FOLDER P1TasksComplete 
//USING
///GAMEFLAG_FOLDER P1EggCode 
//USING
///GAMEFLAG_FOLDER P1ResistancePoints 
//USING
///GAMEFLAG_FOLDER P1HogCode 
//USING
///GAMEFLAG_FOLDER P1BookHidden 
//USING
///GAMEFLAG_FOLDER P1JonTrouble 
//USING
///GAMEFLAG_FOLDER P1PracticePromise 
//USING
///GAMEFLAG_FOLDER P1JonahPromise 
//USING
///GAMEFLAG_FOLDER P1HasBlanket 
//USING
///GAMEFLAG_FOLDER P1PassTaken 
//USING
///GAMEFLAG_FOLDER P1EggsComplete 
//USING
///GAMEFLAG_FOLDER P1LaundryComplete 
//USING
///GAMEFLAG_FOLDER P1HogsComplete 
//USING
///GAMEFLAG_FOLDER P1HasSmokehouseKey 
//USING
///GAMEFLAG_FOLDER P1HasPass 
//USING
///GAMEFLAG_FOLDER P1SarMood 
//USING
///GAMEFLAG_FOLDER P1HasShawl 
//USING
///GAMEFLAG_FOLDER P1Persuade 
//USING
///GAMEFLAG_FOLDER P1NegotiateSar 
//USING
///GAMEFLAG_FOLDER P1PrimerPromise 
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

    //PROPERTY _P1CookWarning
    private static bool _P1CookWarning = false;

    //PROPERTY P1CookWarning
    public static bool P1CookWarning {
        get {
            ///PROPERTY_GETTER_START P1CookWarning
            return _P1CookWarning;
            ///PROPERTY_GETTER_END P1CookWarning
        }
        set {
            ///PROPERTY_SETTER_START P1CookWarning
            var oldValue = value;
_P1CookWarning = value;
GameFlagChanged("P1CookWarning", oldValue, value);
            ///PROPERTY_SETTER_END P1CookWarning
        }
    }

    //PROPERTY _P1SarMad
    private static bool _P1SarMad = false;

    //PROPERTY P1SarMad
    public static bool P1SarMad {
        get {
            ///PROPERTY_GETTER_START P1SarMad
            return _P1SarMad;
            ///PROPERTY_GETTER_END P1SarMad
        }
        set {
            ///PROPERTY_SETTER_START P1SarMad
            var oldValue = value;
_P1SarMad = value;
GameFlagChanged("P1SarMad", oldValue, value);
            ///PROPERTY_SETTER_END P1SarMad
        }
    }

    //PROPERTY _P1HasAuctionPoster
    private static bool _P1HasAuctionPoster = false;

    //PROPERTY P1HasAuctionPoster
    public static bool P1HasAuctionPoster {
        get {
            ///PROPERTY_GETTER_START P1HasAuctionPoster
            return _P1HasAuctionPoster;
            ///PROPERTY_GETTER_END P1HasAuctionPoster
        }
        set {
            ///PROPERTY_SETTER_START P1HasAuctionPoster
            var oldValue = value;
_P1HasAuctionPoster = value;
GameFlagChanged("P1HasAuctionPoster", oldValue, value);
            ///PROPERTY_SETTER_END P1HasAuctionPoster
        }
    }

    //PROPERTY _P1FirstDoc
    private static bool _P1FirstDoc = true;

    //PROPERTY P1FirstDoc
    public static bool P1FirstDoc {
        get {
            ///PROPERTY_GETTER_START P1FirstDoc
            return _P1FirstDoc;
            ///PROPERTY_GETTER_END P1FirstDoc
        }
        set {
            ///PROPERTY_SETTER_START P1FirstDoc
            var oldValue = value;
_P1FirstDoc = value;
GameFlagChanged("P1FirstDoc", oldValue, value);
            ///PROPERTY_SETTER_END P1FirstDoc
        }
    }

    //PROPERTY _P1ComfreyComplete
    private static bool _P1ComfreyComplete = false;

    //PROPERTY P1ComfreyComplete
    public static bool P1ComfreyComplete {
        get {
            ///PROPERTY_GETTER_START P1ComfreyComplete
            return _P1ComfreyComplete;
            ///PROPERTY_GETTER_END P1ComfreyComplete
        }
        set {
            ///PROPERTY_SETTER_START P1ComfreyComplete
            var oldValue = value;
_P1ComfreyComplete = value;
GameFlagChanged("P1ComfreyComplete", oldValue, value);
            ///PROPERTY_SETTER_END P1ComfreyComplete
        }
    }

    //PROPERTY _P1ComfreyTried
    private static bool _P1ComfreyTried = false;

    //PROPERTY P1ComfreyTried
    public static bool P1ComfreyTried {
        get {
            ///PROPERTY_GETTER_START P1ComfreyTried
            return _P1ComfreyTried;
            ///PROPERTY_GETTER_END P1ComfreyTried
        }
        set {
            ///PROPERTY_SETTER_START P1ComfreyTried
            var oldValue = value;
_P1ComfreyTried = value;
GameFlagChanged("P1ComfreyTried", oldValue, value);
            ///PROPERTY_SETTER_END P1ComfreyTried
        }
    }

    //PROPERTY _P1EstComfrey
    private static bool _P1EstComfrey = false;

    //PROPERTY P1EstComfrey
    public static bool P1EstComfrey {
        get {
            ///PROPERTY_GETTER_START P1EstComfrey
            return _P1EstComfrey;
            ///PROPERTY_GETTER_END P1EstComfrey
        }
        set {
            ///PROPERTY_SETTER_START P1EstComfrey
            var oldValue = value;
_P1EstComfrey = value;
GameFlagChanged("P1EstComfrey", oldValue, value);
            ///PROPERTY_SETTER_END P1EstComfrey
        }
    }

    //PROPERTY _P1HasComfrey
    private static bool _P1HasComfrey = false;

    //PROPERTY P1HasComfrey
    public static bool P1HasComfrey {
        get {
            ///PROPERTY_GETTER_START P1HasComfrey
            return _P1HasComfrey;
            ///PROPERTY_GETTER_END P1HasComfrey
        }
        set {
            ///PROPERTY_SETTER_START P1HasComfrey
            var oldValue = value;
_P1HasComfrey = value;
GameFlagChanged("P1HasComfrey", oldValue, value);
            ///PROPERTY_SETTER_END P1HasComfrey
        }
    }

    //PROPERTY _P1KnowLexington
    private static bool _P1KnowLexington = false;

    //PROPERTY P1KnowLexington
    public static bool P1KnowLexington {
        get {
            ///PROPERTY_GETTER_START P1KnowLexington
            return _P1KnowLexington;
            ///PROPERTY_GETTER_END P1KnowLexington
        }
        set {
            ///PROPERTY_SETTER_START P1KnowLexington
            var oldValue = value;
_P1KnowLexington = value;
GameFlagChanged("P1KnowLexington", oldValue, value);
            ///PROPERTY_SETTER_END P1KnowLexington
        }
    }

    //PROPERTY _P1KnowEstDawsons
    private static bool _P1KnowEstDawsons = false;

    //PROPERTY P1KnowEstDawsons
    public static bool P1KnowEstDawsons {
        get {
            ///PROPERTY_GETTER_START P1KnowEstDawsons
            return _P1KnowEstDawsons;
            ///PROPERTY_GETTER_END P1KnowEstDawsons
        }
        set {
            ///PROPERTY_SETTER_START P1KnowEstDawsons
            var oldValue = value;
_P1KnowEstDawsons = value;
GameFlagChanged("P1KnowEstDawsons", oldValue, value);
            ///PROPERTY_SETTER_END P1KnowEstDawsons
        }
    }

    //PROPERTY _P2EscapeType
    private static string _P2EscapeType = "";

    //PROPERTY P2EscapeType
    public static string P2EscapeType {
        get {
            ///PROPERTY_GETTER_START P2EscapeType
            return _P2EscapeType;
            ///PROPERTY_GETTER_END P2EscapeType
        }
        set {
            ///PROPERTY_SETTER_START P2EscapeType
            var oldValue = value;
_P2EscapeType = value;
GameFlagChanged("P2EscapeType", oldValue, value);
            ///PROPERTY_SETTER_END P2EscapeType
        }
    }

    //PROPERTY _P1KnowKingTime
    private static bool _P1KnowKingTime = false;

    //PROPERTY P1KnowKingTime
    public static bool P1KnowKingTime {
        get {
            ///PROPERTY_GETTER_START P1KnowKingTime
            return _P1KnowKingTime;
            ///PROPERTY_GETTER_END P1KnowKingTime
        }
        set {
            ///PROPERTY_SETTER_START P1KnowKingTime
            var oldValue = value;
_P1KnowKingTime = value;
GameFlagChanged("P1KnowKingTime", oldValue, value);
            ///PROPERTY_SETTER_END P1KnowKingTime
        }
    }

    //PROPERTY _P1TotalTasks
    private static int _P1TotalTasks = 0;

    //PROPERTY P1TotalTasks
    public static int P1TotalTasks {
        get {
            ///PROPERTY_GETTER_START P1TotalTasks
            return _P1TotalTasks;
            ///PROPERTY_GETTER_END P1TotalTasks
        }
        set {
            ///PROPERTY_SETTER_START P1TotalTasks
            var oldValue = value;
_P1TotalTasks = value;
GameFlagChanged("P1TotalTasks", oldValue, value);
            ///PROPERTY_SETTER_END P1TotalTasks
        }
    }

    //PROPERTY _P1TasksComplete
    private static int _P1TasksComplete = 0;

    //PROPERTY P1TasksComplete
    public static int P1TasksComplete {
        get {
            ///PROPERTY_GETTER_START P1TasksComplete
            return _P1TasksComplete;
            ///PROPERTY_GETTER_END P1TasksComplete
        }
        set {
            ///PROPERTY_SETTER_START P1TasksComplete
            var oldValue = value;
_P1TasksComplete = value;
GameFlagChanged("P1TasksComplete", oldValue, value);
            ///PROPERTY_SETTER_END P1TasksComplete
        }
    }

    //PROPERTY _P1EggCode
    private static int _P1EggCode = 0;

    //PROPERTY P1EggCode
    public static int P1EggCode {
        get {
            ///PROPERTY_GETTER_START P1EggCode
            return _P1EggCode;
            ///PROPERTY_GETTER_END P1EggCode
        }
        set {
            ///PROPERTY_SETTER_START P1EggCode
            var oldValue = value;
_P1EggCode = value;
GameFlagChanged("P1EggCode", oldValue, value);
            ///PROPERTY_SETTER_END P1EggCode
        }
    }

    //PROPERTY _P1ResistancePoints
    private static int _P1ResistancePoints = 0;

    //PROPERTY P1ResistancePoints
    public static int P1ResistancePoints {
        get {
            ///PROPERTY_GETTER_START P1ResistancePoints
            return _P1ResistancePoints;
            ///PROPERTY_GETTER_END P1ResistancePoints
        }
        set {
            ///PROPERTY_SETTER_START P1ResistancePoints
            var oldValue = value;
_P1ResistancePoints = value;
GameFlagChanged("P1ResistancePoints", oldValue, value);
            ///PROPERTY_SETTER_END P1ResistancePoints
        }
    }

    //PROPERTY _P1HogCode
    private static int _P1HogCode = 0;

    //PROPERTY P1HogCode
    public static int P1HogCode {
        get {
            ///PROPERTY_GETTER_START P1HogCode
            return _P1HogCode;
            ///PROPERTY_GETTER_END P1HogCode
        }
        set {
            ///PROPERTY_SETTER_START P1HogCode
            var oldValue = value;
_P1HogCode = value;
GameFlagChanged("P1HogCode", oldValue, value);
            ///PROPERTY_SETTER_END P1HogCode
        }
    }

    //PROPERTY _P1BookHidden
    private static bool _P1BookHidden = false;

    //PROPERTY P1BookHidden
    public static bool P1BookHidden {
        get {
            ///PROPERTY_GETTER_START P1BookHidden
            return _P1BookHidden;
            ///PROPERTY_GETTER_END P1BookHidden
        }
        set {
            ///PROPERTY_SETTER_START P1BookHidden
            var oldValue = value;
_P1BookHidden = value;
GameFlagChanged("P1BookHidden", oldValue, value);
            ///PROPERTY_SETTER_END P1BookHidden
        }
    }

    //PROPERTY _P1JonTrouble
    private static bool _P1JonTrouble = false;

    //PROPERTY P1JonTrouble
    public static bool P1JonTrouble {
        get {
            ///PROPERTY_GETTER_START P1JonTrouble
            return _P1JonTrouble;
            ///PROPERTY_GETTER_END P1JonTrouble
        }
        set {
            ///PROPERTY_SETTER_START P1JonTrouble
            var oldValue = value;
_P1JonTrouble = value;
GameFlagChanged("P1JonTrouble", oldValue, value);
            ///PROPERTY_SETTER_END P1JonTrouble
        }
    }

    //PROPERTY _P1PracticePromise
    private static bool _P1PracticePromise = false;

    //PROPERTY P1PracticePromise
    public static bool P1PracticePromise {
        get {
            ///PROPERTY_GETTER_START P1PracticePromise
            return _P1PracticePromise;
            ///PROPERTY_GETTER_END P1PracticePromise
        }
        set {
            ///PROPERTY_SETTER_START P1PracticePromise
            var oldValue = value;
_P1PracticePromise = value;
GameFlagChanged("P1PracticePromise", oldValue, value);
            ///PROPERTY_SETTER_END P1PracticePromise
        }
    }

    //PROPERTY _P1JonahPromise
    private static string _P1JonahPromise = "";

    //PROPERTY P1JonahPromise
    public static string P1JonahPromise {
        get {
            ///PROPERTY_GETTER_START P1JonahPromise
            return _P1JonahPromise;
            ///PROPERTY_GETTER_END P1JonahPromise
        }
        set {
            ///PROPERTY_SETTER_START P1JonahPromise
            var oldValue = value;
_P1JonahPromise = value;
GameFlagChanged("P1JonahPromise", oldValue, value);
            ///PROPERTY_SETTER_END P1JonahPromise
        }
    }

    //PROPERTY _P1HasBlanket
    private static bool _P1HasBlanket = false;

    //PROPERTY P1HasBlanket
    public static bool P1HasBlanket {
        get {
            ///PROPERTY_GETTER_START P1HasBlanket
            return _P1HasBlanket;
            ///PROPERTY_GETTER_END P1HasBlanket
        }
        set {
            ///PROPERTY_SETTER_START P1HasBlanket
            var oldValue = value;
_P1HasBlanket = value;
GameFlagChanged("P1HasBlanket", oldValue, value);
            ///PROPERTY_SETTER_END P1HasBlanket
        }
    }

    //PROPERTY _P1PassTaken
    private static bool _P1PassTaken = false;

    //PROPERTY P1PassTaken
    public static bool P1PassTaken {
        get {
            ///PROPERTY_GETTER_START P1PassTaken
            return _P1PassTaken;
            ///PROPERTY_GETTER_END P1PassTaken
        }
        set {
            ///PROPERTY_SETTER_START P1PassTaken
            var oldValue = value;
_P1PassTaken = value;
GameFlagChanged("P1PassTaken", oldValue, value);
            ///PROPERTY_SETTER_END P1PassTaken
        }
    }

    //PROPERTY _P1EggsComplete
    private static bool _P1EggsComplete = false;

    //PROPERTY P1EggsComplete
    public static bool P1EggsComplete {
        get {
            ///PROPERTY_GETTER_START P1EggsComplete
            return _P1EggsComplete;
            ///PROPERTY_GETTER_END P1EggsComplete
        }
        set {
            ///PROPERTY_SETTER_START P1EggsComplete
            var oldValue = value;
_P1EggsComplete = value;
GameFlagChanged("P1EggsComplete", oldValue, value);
            ///PROPERTY_SETTER_END P1EggsComplete
        }
    }

    //PROPERTY _P1LaundryComplete
    private static bool _P1LaundryComplete = false;

    //PROPERTY P1LaundryComplete
    public static bool P1LaundryComplete {
        get {
            ///PROPERTY_GETTER_START P1LaundryComplete
            return _P1LaundryComplete;
            ///PROPERTY_GETTER_END P1LaundryComplete
        }
        set {
            ///PROPERTY_SETTER_START P1LaundryComplete
            var oldValue = value;
_P1LaundryComplete = value;
GameFlagChanged("P1LaundryComplete", oldValue, value);
            ///PROPERTY_SETTER_END P1LaundryComplete
        }
    }

    //PROPERTY _P1HogsComplete
    private static bool _P1HogsComplete = false;

    //PROPERTY P1HogsComplete
    public static bool P1HogsComplete {
        get {
            ///PROPERTY_GETTER_START P1HogsComplete
            return _P1HogsComplete;
            ///PROPERTY_GETTER_END P1HogsComplete
        }
        set {
            ///PROPERTY_SETTER_START P1HogsComplete
            var oldValue = value;
_P1HogsComplete = value;
GameFlagChanged("P1HogsComplete", oldValue, value);
            ///PROPERTY_SETTER_END P1HogsComplete
        }
    }

    //PROPERTY _P1HasSmokehouseKey
    private static bool _P1HasSmokehouseKey = false;

    //PROPERTY P1HasSmokehouseKey
    public static bool P1HasSmokehouseKey {
        get {
            ///PROPERTY_GETTER_START P1HasSmokehouseKey
            return _P1HasSmokehouseKey;
            ///PROPERTY_GETTER_END P1HasSmokehouseKey
        }
        set {
            ///PROPERTY_SETTER_START P1HasSmokehouseKey
            var oldValue = value;
_P1HasSmokehouseKey = value;
GameFlagChanged("P1HasSmokehouseKey", oldValue, value);
            ///PROPERTY_SETTER_END P1HasSmokehouseKey
        }
    }

    //PROPERTY _P1HasPass
    private static bool _P1HasPass = false;

    //PROPERTY P1HasPass
    public static bool P1HasPass {
        get {
            ///PROPERTY_GETTER_START P1HasPass
            return _P1HasPass;
            ///PROPERTY_GETTER_END P1HasPass
        }
        set {
            ///PROPERTY_SETTER_START P1HasPass
            var oldValue = value;
_P1HasPass = value;
GameFlagChanged("P1HasPass", oldValue, value);
            ///PROPERTY_SETTER_END P1HasPass
        }
    }

    //PROPERTY _P1SarMood
    private static int _P1SarMood = 0;

    //PROPERTY P1SarMood
    public static int P1SarMood {
        get {
            ///PROPERTY_GETTER_START P1SarMood
            return _P1SarMood;
            ///PROPERTY_GETTER_END P1SarMood
        }
        set {
            ///PROPERTY_SETTER_START P1SarMood
            var oldValue = value;
_P1SarMood = value;
GameFlagChanged("P1SarMood", oldValue, value);
            ///PROPERTY_SETTER_END P1SarMood
        }
    }

    //PROPERTY _P1HasShawl
    private static bool _P1HasShawl = false;

    //PROPERTY P1HasShawl
    public static bool P1HasShawl {
        get {
            ///PROPERTY_GETTER_START P1HasShawl
            return _P1HasShawl;
            ///PROPERTY_GETTER_END P1HasShawl
        }
        set {
            ///PROPERTY_SETTER_START P1HasShawl
            var oldValue = value;
_P1HasShawl = value;
GameFlagChanged("P1HasShawl", oldValue, value);
            ///PROPERTY_SETTER_END P1HasShawl
        }
    }

    //PROPERTY _P1Persuade
    private static bool _P1Persuade = false;

    //PROPERTY P1Persuade
    public static bool P1Persuade {
        get {
            ///PROPERTY_GETTER_START P1Persuade
            return _P1Persuade;
            ///PROPERTY_GETTER_END P1Persuade
        }
        set {
            ///PROPERTY_SETTER_START P1Persuade
            var oldValue = value;
_P1Persuade = value;
GameFlagChanged("P1Persuade", oldValue, value);
            ///PROPERTY_SETTER_END P1Persuade
        }
    }

    //PROPERTY _P1NegotiateSar
    private static bool _P1NegotiateSar = false;

    //PROPERTY P1NegotiateSar
    public static bool P1NegotiateSar {
        get {
            ///PROPERTY_GETTER_START P1NegotiateSar
            return _P1NegotiateSar;
            ///PROPERTY_GETTER_END P1NegotiateSar
        }
        set {
            ///PROPERTY_SETTER_START P1NegotiateSar
            var oldValue = value;
_P1NegotiateSar = value;
GameFlagChanged("P1NegotiateSar", oldValue, value);
            ///PROPERTY_SETTER_END P1NegotiateSar
        }
    }

    //PROPERTY _P1PrimerPromise
    private static bool _P1PrimerPromise = false;

    //PROPERTY P1PrimerPromise
    public static bool P1PrimerPromise {
        get {
            ///PROPERTY_GETTER_START P1PrimerPromise
            return _P1PrimerPromise;
            ///PROPERTY_GETTER_END P1PrimerPromise
        }
        set {
            ///PROPERTY_SETTER_START P1PrimerPromise
            var oldValue = value;
_P1PrimerPromise = value;
GameFlagChanged("P1PrimerPromise", oldValue, value);
            ///PROPERTY_SETTER_END P1PrimerPromise
        }
    }
}
//CLASS_END GameFlags
