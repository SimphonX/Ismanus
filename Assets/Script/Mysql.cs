using UnityEngine;
using UnityEngine.UI;
using System;



public class Mysql : MonoBehaviour {
    [Serializable]
    class Data
    {
        public string name;
        public string score;
    }
    private Data data = new Data();
    private WWW www;
    public GlobalSettings size;
    public bool panaudotas;
    private string url = "http://donvos.stud.if.ktu.lt/Ugetsql.php";
    public Info info;
    public Test playerinfo;
    public Size Sizes;
    // Use this for initialization
    public void Start () {
    }
    public void Rodymas()
    {
        GameObject[] killEmAll;
        killEmAll = GameObject.FindGameObjectsWithTag("Remove");
        for (int i = 0; i < killEmAll.Length; i++)
        {
            Destroy(killEmAll[i].gameObject);
        }
        string dydis = size.X + "x" + size.Y;
        Text text1 = Sizes.GetComponent<Text>();
        text1.text = dydis;
        WWWForm form = new WWWForm();
        form.AddField("size", dydis);
        www = new WWW(url, form);
        panaudotas = false;
    }
    // Update is called once per frame
    void Update () {
        if (www.isDone && !panaudotas)
        {
            panaudotas = true;
            string json = www.text;
            string json1 = json.Substring(1);
            Debug.Log(www.text);
            string[] result = www.text.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < result.Length; i++)
            {
                data = JsonUtility.FromJson<Data>(result[i]);
                Test Name = Instantiate(playerinfo);
                Info player = Instantiate(info);
                Test Score = Instantiate(playerinfo);
                Text text1 = Name.GetComponent<Text>();
                text1.text = data.name;
                Name.transform.parent = player.transform;
                Text text = Score.GetComponent<Text>();
                text.text = data.score;
                Score.transform.parent = player.transform;
                player.gameObject.transform.parent = this.gameObject.transform;
            }
        }
    }

}