using UnityEngine;
using System.Collections;

public class GlobalPlayer : MonoBehaviour {

    public static GlobalPlayer Instance;

    public PlayerSettings Name = new PlayerSettings();

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
