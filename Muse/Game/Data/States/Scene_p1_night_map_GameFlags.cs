//USING
using NodeMaps;
//CLASS GameFlags
public static partial class GameFlags {
    //PROPERTY _HotspotActive_p1_night_map_map_plantation_night
    private static int _HotspotActive_p1_night_map_map_plantation_night = 1;

    //PROPERTY HotspotActive_p1_night_map_map_plantation_night
    public static int HotspotActive_p1_night_map_map_plantation_night {
        get {
            ///PROPERTY_GETTER_START HotspotActive_p1_night_map_map_plantation_night
            return _HotspotActive_p1_night_map_map_plantation_night;
            ///PROPERTY_GETTER_END HotspotActive_p1_night_map_map_plantation_night
        }
        set {
            ///PROPERTY_SETTER_START HotspotActive_p1_night_map_map_plantation_night
            var oldValue = _HotspotActive_p1_night_map_map_plantation_night;
            _HotspotActive_p1_night_map_map_plantation_night = value;
            GameFlagChanged("HotspotActive_p1_night_map_map_plantation_night", oldValue, value);
            ///PROPERTY_SETTER_END HotspotActive_p1_night_map_map_plantation_night
        }
    }

    //PROPERTY _HotspotCountClick_p1_night_map_map_plantation_night
    private static bool _HotspotCountClick_p1_night_map_map_plantation_night = false;

    //PROPERTY HotspotCountClick_p1_night_map_map_plantation_night
    public static bool HotspotCountClick_p1_night_map_map_plantation_night {
        get {
            ///PROPERTY_GETTER_START HotspotCountClick_p1_night_map_map_plantation_night
            return _HotspotCountClick_p1_night_map_map_plantation_night;
            ///PROPERTY_GETTER_END HotspotCountClick_p1_night_map_map_plantation_night
        }
        set {
            ///PROPERTY_SETTER_START HotspotCountClick_p1_night_map_map_plantation_night
            var oldValue = _HotspotCountClick_p1_night_map_map_plantation_night;
            _HotspotCountClick_p1_night_map_map_plantation_night = value;
            GameFlagChanged("HotspotCountClick_p1_night_map_map_plantation_night", oldValue, value);
            ///PROPERTY_SETTER_END HotspotCountClick_p1_night_map_map_plantation_night
        }
    }
}
//CLASS_END GameFlags
