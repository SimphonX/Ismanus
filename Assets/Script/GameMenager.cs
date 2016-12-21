using UnityEngine;
using System.Collections;
using System;


public class GameMenager : MonoBehaviour
{
    public Maze mazePref;
    private Maze mazeint;
    public Transform player;
    public GameObject settings;
    public GlobalSettings sett;
    public Goal tiks;
    public Goal boost;
    // Use this for initialization
    void Start(){
		BeginGame ();
        int x, y;
        GameObject Boosts = new GameObject();
        Boosts.name = "Boosts";
        System.Random rnd = new System.Random();
        settings = GameObject.FindGameObjectWithTag("Settings") as GameObject;
        sett = settings.GetComponent<GlobalSettings>();
        tiks.transform.position = new Vector3(sett.X-1, sett.Y-1, 0);

        for (int i = 0; i <= Math.Max(sett.X, sett.Y); i++)
        {
            Goal task = Instantiate(boost);
            x = rnd.Next(2, sett.X/2);
            y = rnd.Next(2, sett.Y/2);
            task.name = "Boost"+i;
            task.transform.position = new Vector3(x*2-1, y*2-1, 0);
            task.transform.parent = Boosts.transform;
        }
    }
	
	// Update is called once per frame
	void Update () { 
	}

    private void RestartGame()
    {
        Destroy(mazeint.gameObject);
        BeginGame();
    }

    private void BeginGame()
    {
		mazeint = Instantiate (mazePref) as Maze;
		mazeint.Generate ();
    }
}
