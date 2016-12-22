using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Default : MonoBehaviour {
    public InputField X, Y, Name;
    public GlobalSettings settings;
    public Slider Diff;
	// Use this for initialization
	void Start () {
        X.text = "100";
        Y.text = "100";
        Name.text = "NoName";
        settings.X = Int32.Parse(X.text);
        settings.Y = Int32.Parse(Y.text);
        settings.playerName = Name.text;
    }
	
	// Update is called once per frame
	void Update () {
        settings.X = Int32.Parse(X.text);
        settings.Y = Int32.Parse(Y.text);
        settings.playerName = Name.text;
    }
}
