using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Points : MonoBehaviour {
    public Upgrades upg;
    public Text text;
	
	// Update is called once per frame
	void Update () {
        text.text = "Upgrades " + upg.Points;
    }
}
