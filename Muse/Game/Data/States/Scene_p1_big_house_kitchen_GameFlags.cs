//USING
using NodeMaps;
//CLASS GameFlags
public static partial class GameFlags {
    //PROPERTY _HotspotActive_p1_big_house_kitchen_esther
    private static int _HotspotActive_p1_big_house_kitchen_esther = 1;

    //PROPERTY HotspotActive_p1_big_house_kitchen_esther
    public static int HotspotActive_p1_big_house_kitchen_esther {
        get {
            ///PROPERTY_GETTER_START HotspotActive_p1_big_house_kitchen_esther
            return _HotspotActive_p1_big_house_kitchen_esther;
            ///PROPERTY_GETTER_END HotspotActive_p1_big_house_kitchen_esther
        }
        set {
            ///PROPERTY_SETTER_START HotspotActive_p1_big_house_kitchen_esther
            var oldValue = _HotspotActive_p1_big_house_kitchen_esther;
            _HotspotActive_p1_big_house_kitchen_esther = value;
            GameFlagChanged("HotspotActive_p1_big_house_kitchen_esther", oldValue, value);
            ///PROPERTY_SETTER_END HotspotActive_p1_big_house_kitchen_esther
        }
    }

    //PROPERTY _HotspotCountClick_p1_big_house_kitchen_esther
    private static bool _HotspotCountClick_p1_big_house_kitchen_esther = false;

    //PROPERTY HotspotCountClick_p1_big_house_kitchen_esther
    public static bool HotspotCountClick_p1_big_house_kitchen_esther {
        get {
            ///PROPERTY_GETTER_START HotspotCountClick_p1_big_house_kitchen_esther
            return _HotspotCountClick_p1_big_house_kitchen_esther;
            ///PROPERTY_GETTER_END HotspotCountClick_p1_big_house_kitchen_esther
        }
        set {
            ///PROPERTY_SETTER_START HotspotCountClick_p1_big_house_kitchen_esther
            var oldValue = _HotspotCountClick_p1_big_house_kitchen_esther;
            _HotspotCountClick_p1_big_house_kitchen_esther = value;
            GameFlagChanged("HotspotCountClick_p1_big_house_kitchen_esther", oldValue, value);
            ///PROPERTY_SETTER_END HotspotCountClick_p1_big_house_kitchen_esther
        }
    }
}
//CLASS_END GameFlags
