//CLASS UserFlags
public static partial class UserFlags {
    //PROPERTY _ShowTutorial
    private static bool _ShowTutorial = true;

    //PROPERTY ShowTutorial
    public static bool ShowTutorial {
        get {
            ///PROPERTY_GETTER_START ShowTutorial
            return _ShowTutorial;
            ///PROPERTY_GETTER_END ShowTutorial
        }
        set {
            ///PROPERTY_SETTER_START ShowTutorial
            _ShowTutorial = value;
            ///PROPERTY_SETTER_END ShowTutorial
        }
    }

    //PROPERTY _test
    private static bool _test = false;

    //PROPERTY test
    public static bool test {
        get {
            ///PROPERTY_GETTER_START test
            return _test;
            ///PROPERTY_GETTER_END test
        }
        set {
            ///PROPERTY_SETTER_START test
            _test = value;
            ///PROPERTY_SETTER_END test
        }
    }
}
//CLASS_END UserFlags
