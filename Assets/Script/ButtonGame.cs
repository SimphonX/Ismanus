using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonGame : MonoBehaviour {
    public Transform mainMenu, butt, stats, map, upg, ret, item1;
    public PleyerMove pl;

    public new Camera camera;
    public new Camera camera2;

    // Use this for initialization
    void Start () {
        mainMenu.gameObject.SetActive(true);
        butt.gameObject.SetActive(false);
        camera.enabled = true;
        camera2.enabled = false;
}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void SettingMenu(bool clicked)
    {
        pl.eit = !clicked;
        butt.gameObject.SetActive(clicked);
        mainMenu.gameObject.SetActive(!clicked);
        item1.gameObject.SetActive(!clicked);
    }
    public void statsMenu(bool clicked)
    {
        stats.gameObject.SetActive(clicked);
        upg.gameObject.SetActive(!clicked);
        
    }
    public void upgMenu(bool clicked)
    {
        upg.gameObject.SetActive(clicked);
        butt.gameObject.SetActive(!clicked);

    }
    public void mapMenu(bool clicked)
    {
        map.gameObject.SetActive(clicked);
        upg.gameObject.SetActive(!clicked);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadScean(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void mapView()
    {
        camera.enabled = !camera.enabled;
        camera2.enabled = !camera2.enabled;
    }
    public void ViewMenu(bool clicked)
    {
        pl.eit = !clicked;
        ret.gameObject.SetActive(clicked);
        mainMenu.gameObject.SetActive(!clicked);
        item1.gameObject.SetActive(!clicked);
    }
}
