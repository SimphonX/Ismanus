using UnityEngine;
using System.Collections;

public class PlayerCam : MonoBehaviour {
    public Camera cam;
    // Use this for initialization
    void Start () {
        Input.gyro.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
            cam.transform.rotation = new Quaternion(-Input.gyro.attitude.x, -Input.gyro.attitude.y, Input.gyro.attitude.z, Input.gyro.attitude.w);
    }
}
