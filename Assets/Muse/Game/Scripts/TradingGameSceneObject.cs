using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This only serves as a game object in the scene so that the trading game can run coroutines.
/// </summary>
public class TradingGameSceneObject : MonoBehaviour {

    static TradingGameSceneObject _instance = null;
    public static TradingGameSceneObject GetInstance()
    {
        return _instance;
    }

    void Awake()
    {
        _instance = this;
    }

	
	
	
}
