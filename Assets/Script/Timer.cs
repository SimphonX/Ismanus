using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private int h = 0, m = 0, s = 0;
    public Text text;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Skaicevimas", 0, (float)1.0);
    }
	
	// Update is called once per frame
	void Update () {
        if (s >= 60) { s = 0; m++; }
        if (m >= 60) { m = 0; h++; }
        text.text = h + ":" + m + ":" + s;
    }

    void Skaicevimas()
    {
        s++;
    }
}
