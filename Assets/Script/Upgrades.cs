using UnityEngine;
using System.Collections;

public class Upgrades : MonoBehaviour {
    public int Points;
    public float Speed;
    public Transform player, camera, goal, light;
    public GameObject Gbt;
    public GameObject Pbt;
    public GameObject Sbt;
    public GameObject Bbt;
    public GameObject Lbt;
    // Use this for initialization
    void Start () {
        Points = 0;
        Speed = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void incSpeed()
    {
        Speed += 0.4f;
        Points--;
        if (Speed > 5) Destroy(Sbt);
    }
    public void showPlayer()
    {
        player.gameObject.SetActive(true);
        Points -= 2;
        Destroy(Pbt);
    }
    public void CamDist()
    {
        camera.position = new Vector3(camera.position.x, camera.position.y, camera.position.z-5);
        Points -= 2;
    }

    public void showGoal()
    {
        goal.gameObject.SetActive(true);
        Points --;
        Destroy(Gbt);
    }
    public void showBoosts()
    {
        GameObject[] boosts = GameObject.FindGameObjectsWithTag("Boost");
        foreach (GameObject respawn in boosts)
            respawn.transform.GetChild(1).gameObject.SetActive(true);
        Points -=4;
        Destroy(Bbt);
    }
    public void showLight()
    {
        light.gameObject.SetActive(true);
        Points-=3;
        Destroy(Lbt);
    }
}
