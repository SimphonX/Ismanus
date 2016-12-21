using UnityEngine;
using System.Collections;

public class Restrict : MonoBehaviour {
    public Upgrades upg;
    public Transform butt;
    public int points;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(upg.Points >= points)
        {
            butt.gameObject.SetActive(true);
        }
        else butt.gameObject.SetActive(false);
    }
}
