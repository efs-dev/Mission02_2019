//USING
using NodeMaps;
//CLASS GameFlags
public static partial class GameFlags {
    //PROPERTY _HotspotActive_loc_overlook_CrkRbt
    private static int _HotspotActive_loc_overlook_CrkRbt = 1;

    //PROPERTY HotspotActive_loc_overlook_CrkRbt
    public static int HotspotActive_loc_overlook_CrkRbt {
        get {
            ///PROPERTY_GETTER_START HotspotActive_loc_overlook_CrkRbt
            return _HotspotActive_loc_overlook_CrkRbt;
            ///PROPERTY_GETTER_END HotspotActive_loc_overlook_CrkRbt
        }
        set {
            ///PROPERTY_SETTER_START HotspotActive_loc_overlook_CrkRbt
            var oldValue = _HotspotActive_loc_overlook_CrkRbt;
            _HotspotActive_loc_overlook_CrkRbt = value;
            GameFlagChanged("HotspotActive_loc_overlook_CrkRbt", oldValue, value);
            ///PROPERTY_SETTER_END HotspotActive_loc_overlook_CrkRbt
        }
    }

    //PROPERTY _HotspotCountClick_loc_overlook_CrkRbt
    private static bool _HotspotCountClick_loc_overlook_CrkRbt = false;

    //PROPERTY HotspotCountClick_loc_overlook_CrkRbt
    public static bool HotspotCountClick_loc_overlook_CrkRbt {
        get {
            ///PROPERTY_GETTER_START HotspotCountClick_loc_overlook_CrkRbt
            return _HotspotCountClick_loc_overlook_CrkRbt;
            ///PROPERTY_GETTER_END HotspotCountClick_loc_overlook_CrkRbt
        }
        set {
            ///PROPERTY_SETTER_START HotspotCountClick_loc_overlook_CrkRbt
            var oldValue = _HotspotCountClick_loc_overlook_CrkRbt;
            _HotspotCountClick_loc_overlook_CrkRbt = value;
            GameFlagChanged("HotspotCountClick_loc_overlook_CrkRbt", oldValue, value);
            ///PROPERTY_SETTER_END HotspotCountClick_loc_overlook_CrkRbt
        }
    }

    //PROPERTY _HotspotActive_loc_overlook_sis
    private static int _HotspotActive_loc_overlook_sis = 1;

    //PROPERTY HotspotActive_loc_overlook_sis
    public static int HotspotActive_loc_overlook_sis {
        get {
            ///PROPERTY_GETTER_START HotspotActive_loc_overlook_sis
            return _HotspotActive_loc_overlook_sis;
            ///PROPERTY_GETTER_END HotspotActive_loc_overlook_sis
        }
        set {
            ///PROPERTY_SETTER_START HotspotActive_loc_overlook_sis
            var oldValue = _HotspotActive_loc_overlook_sis;
            _HotspotActive_loc_overlook_sis = value;
            GameFlagChanged("HotspotActive_loc_overlook_sis", oldValue, value);
            ///PROPERTY_SETTER_END HotspotActive_loc_overlook_sis
        }
    }

    //PROPERTY _HotspotCountClick_loc_overlook_sis
    private static bool _HotspotCountClick_loc_overlook_sis = false;

    //PROPERTY HotspotCountClick_loc_overlook_sis
    public static bool HotspotCountClick_loc_overlook_sis {
        get {
            ///PROPERTY_GETTER_START HotspotCountClick_loc_overlook_sis
            return _HotspotCountClick_loc_overlook_sis;
            ///PROPERTY_GETTER_END HotspotCountClick_loc_overlook_sis
        }
        set {
            ///PROPERTY_SETTER_START HotspotCountClick_loc_overlook_sis
            var oldValue = _HotspotCountClick_loc_overlook_sis;
            _HotspotCountClick_loc_overlook_sis = value;
            GameFlagChanged("HotspotCountClick_loc_overlook_sis", oldValue, value);
            ///PROPERTY_SETTER_END HotspotCountClick_loc_overlook_sis
        }
    }
}
//CLASS_END GameFlags
