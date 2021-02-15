//CLASS GameFlags
public static partial class GameFlags {
    //PROPERTY _StartingState
    private static string _StartingState = "";

    //PROPERTY StartingState
    public static string StartingState {
        get {
            ///PROPERTY_GETTER_START StartingState
            return _StartingState;
            ///PROPERTY_GETTER_END StartingState
        }
        set {
            ///PROPERTY_SETTER_START StartingState
            _StartingState = value;
            ///PROPERTY_SETTER_END StartingState
        }
    }
}
//CLASS_END GameFlags
