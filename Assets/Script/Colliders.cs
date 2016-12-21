using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Colliders : MonoBehaviour {
    public Upgrades upg;
    public GameObject settings;
    public GlobalSettings sett;
    public Text text;
    public GameObject Text;
    private WWW www;
    private string url = "http://donvos.stud.if.ktu.lt/Uadd.php";
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * 0.01f);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (this.gameObject.tag == "Finish" && other.gameObject.tag == "Player")
        {
            settings = GameObject.FindGameObjectWithTag("Settings") as GameObject;
            sett = settings.GetComponent<GlobalSettings>();
            string dydis = sett.X + "x" + sett.Y;
            WWWForm form = new WWWForm();
            form.AddField("size", dydis);
            form.AddField("name", sett.playerName);
            Text = GameObject.FindGameObjectWithTag("Timer") as GameObject;
            text = Text.GetComponent<Text>();
            Debug.Log(text.text);
            form.AddField("score", text.text);
            www = new WWW(url, form);
            SceneManager.LoadScene("Menu");
        }
        if (this.gameObject.tag == "Boosts" && other.gameObject.tag == "Player")
        {
            settings = GameObject.FindGameObjectWithTag("Player") as GameObject;
            upg = settings.GetComponent<Upgrades>();
            upg.Points++;
            Debug.Log(upg.Points);
            Destroy(this.gameObject.transform.parent.gameObject);
        }
    }
}
