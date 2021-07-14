//USING
using NodeMaps;
//CLASS GameFlags
public static partial class GameFlags {
    //PROPERTY _HotspotActive_p1_creek_Otis
    private static int _HotspotActive_p1_creek_Otis = 1;

    //PROPERTY HotspotActive_p1_creek_Otis
    public static int HotspotActive_p1_creek_Otis {
        get {
            ///PROPERTY_GETTER_START HotspotActive_p1_creek_Otis
            return _HotspotActive_p1_creek_Otis;
            ///PROPERTY_GETTER_END HotspotActive_p1_creek_Otis
        }
        set {
            ///PROPERTY_SETTER_START HotspotActive_p1_creek_Otis
            var oldValue = _HotspotActive_p1_creek_Otis;
            _HotspotActive_p1_creek_Otis = value;
            GameFlagChanged("HotspotActive_p1_creek_Otis", oldValue, value);
            ///PROPERTY_SETTER_END HotspotActive_p1_creek_Otis
        }
    }

    //PROPERTY _HotspotCountClick_p1_creek_Otis
    private static bool _HotspotCountClick_p1_creek_Otis = false;

    //PROPERTY HotspotCountClick_p1_creek_Otis
    public static bool HotspotCountClick_p1_creek_Otis {
        get {
            ///PROPERTY_GETTER_START HotspotCountClick_p1_creek_Otis
            return _HotspotCountClick_p1_creek_Otis;
            ///PROPERTY_GETTER_END HotspotCountClick_p1_creek_Otis
        }
        set {
            ///PROPERTY_SETTER_START HotspotCountClick_p1_creek_Otis
            var oldValue = _HotspotCountClick_p1_creek_Otis;
            _HotspotCountClick_p1_creek_Otis = value;
            GameFlagChanged("HotspotCountClick_p1_creek_Otis", oldValue, value);
            ///PROPERTY_SETTER_END HotspotCountClick_p1_creek_Otis
        }
    }
}
//CLASS_END GameFlags
