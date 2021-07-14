//USING
using NodeMaps;
//CLASS GameFlags
public static partial class GameFlags {
    //PROPERTY _HotspotActive_p1_sarah_Sarah
    private static int _HotspotActive_p1_sarah_Sarah = 1;

    //PROPERTY HotspotActive_p1_sarah_Sarah
    public static int HotspotActive_p1_sarah_Sarah {
        get {
            ///PROPERTY_GETTER_START HotspotActive_p1_sarah_Sarah
            return _HotspotActive_p1_sarah_Sarah;
            ///PROPERTY_GETTER_END HotspotActive_p1_sarah_Sarah
        }
        set {
            ///PROPERTY_SETTER_START HotspotActive_p1_sarah_Sarah
            var oldValue = _HotspotActive_p1_sarah_Sarah;
            _HotspotActive_p1_sarah_Sarah = value;
            GameFlagChanged("HotspotActive_p1_sarah_Sarah", oldValue, value);
            ///PROPERTY_SETTER_END HotspotActive_p1_sarah_Sarah
        }
    }

    //PROPERTY _HotspotCountClick_p1_sarah_Sarah
    private static bool _HotspotCountClick_p1_sarah_Sarah = false;

    //PROPERTY HotspotCountClick_p1_sarah_Sarah
    public static bool HotspotCountClick_p1_sarah_Sarah {
        get {
            ///PROPERTY_GETTER_START HotspotCountClick_p1_sarah_Sarah
            return _HotspotCountClick_p1_sarah_Sarah;
            ///PROPERTY_GETTER_END HotspotCountClick_p1_sarah_Sarah
        }
        set {
            ///PROPERTY_SETTER_START HotspotCountClick_p1_sarah_Sarah
            var oldValue = _HotspotCountClick_p1_sarah_Sarah;
            _HotspotCountClick_p1_sarah_Sarah = value;
            GameFlagChanged("HotspotCountClick_p1_sarah_Sarah", oldValue, value);
            ///PROPERTY_SETTER_END HotspotCountClick_p1_sarah_Sarah
        }
    }
}
//CLASS_END GameFlags
