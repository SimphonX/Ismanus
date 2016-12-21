using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GlobalSettings : MonoBehaviour {

    public static GlobalSettings Instance;

    public int X, Y;

    public string playerName;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
