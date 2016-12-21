using UnityEngine;
using System.Collections;

public class PleyerMove : MonoBehaviour {
    Vector3 move;
    public Upgrades upg;
    public bool eit;
    // Use this for initialization
    void Start () {
        eit = true;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.touchCount > 0 && eit)
        {
            move = new Vector3(Camera.main.transform.forward.x, Camera.main.transform.forward.y);
            this.gameObject.GetComponent<Rigidbody>().velocity = move * upg.Speed;
        }
        else this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3();
    }
}
