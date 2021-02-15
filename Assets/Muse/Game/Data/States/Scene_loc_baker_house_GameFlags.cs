//USING
using NodeMaps;
//CLASS GameFlags
public static partial class GameFlags {
    //PROPERTY _HotspotActive_loc_baker_house_SisOld
    private static int _HotspotActive_loc_baker_house_SisOld = 1;

    //PROPERTY HotspotActive_loc_baker_house_SisOld
    public static int HotspotActive_loc_baker_house_SisOld {
        get {
            ///PROPERTY_GETTER_START HotspotActive_loc_baker_house_SisOld
            return _HotspotActive_loc_baker_house_SisOld;
            ///PROPERTY_GETTER_END HotspotActive_loc_baker_house_SisOld
        }
        set {
            ///PROPERTY_SETTER_START HotspotActive_loc_baker_house_SisOld
            var oldValue = _HotspotActive_loc_baker_house_SisOld;
            _HotspotActive_loc_baker_house_SisOld = value;
            GameFlagChanged("HotspotActive_loc_baker_house_SisOld", oldValue, value);
            ///PROPERTY_SETTER_END HotspotActive_loc_baker_house_SisOld
        }
    }

    //PROPERTY _HotspotCountClick_loc_baker_house_SisOld
    private static bool _HotspotCountClick_loc_baker_house_SisOld = false;

    //PROPERTY HotspotCountClick_loc_baker_house_SisOld
    public static bool HotspotCountClick_loc_baker_house_SisOld {
        get {
            ///PROPERTY_GETTER_START HotspotCountClick_loc_baker_house_SisOld
            return _HotspotCountClick_loc_baker_house_SisOld;
            ///PROPERTY_GETTER_END HotspotCountClick_loc_baker_house_SisOld
        }
        set {
            ///PROPERTY_SETTER_START HotspotCountClick_loc_baker_house_SisOld
            var oldValue = _HotspotCountClick_loc_baker_house_SisOld;
            _HotspotCountClick_loc_baker_house_SisOld = value;
            GameFlagChanged("HotspotCountClick_loc_baker_house_SisOld", oldValue, value);
            ///PROPERTY_SETTER_END HotspotCountClick_loc_baker_house_SisOld
        }
    }
}
//CLASS_END GameFlags
