using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelMenager : MonoBehaviour {
    public Transform mainMenu, settings, leaderbord;
    void Start()
    {
        mainMenu.gameObject.SetActive(true);
        settings.gameObject.SetActive(false);
        leaderbord.gameObject.SetActive(false);
    }
    public void LoadScean(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void SettingMenu(bool clicked)
    {
        if(clicked == true)
        {
            settings.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(!clicked);
        }
        else
        {
            settings.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(!clicked);
        }
    }
    public void LeaderbordMenu(bool clicked)
    {
        if (clicked == true)
        {
            leaderbord.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(!clicked);
        }
        else
        {
            leaderbord.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(!clicked);
        }
    }
}
