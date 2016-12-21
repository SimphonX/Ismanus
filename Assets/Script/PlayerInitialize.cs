using UnityEngine;
using System.Collections;

public class PlayerInitialize : MonoBehaviour
{
	public GameObject cam;
	// Use this for initialization
	void Start () {
			GameObject maincamera = Instantiate (cam);
        maincamera.transform.parent = this.gameObject.transform;
			maincamera.transform.position = this.gameObject.transform.localPosition;
        maincamera.transform.Translate (0,0,0,Space.World);
	}
}