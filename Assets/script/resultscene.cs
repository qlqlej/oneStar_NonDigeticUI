using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class resultscene : MonoBehaviour {

    private float nowtime;
    public Text SCORE, KM, COIN;
    public static float score,km,coin;
	// Use this for initialization
	void Start () {
        nowtime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        coin = (score / 100) + (km/10);
        nowtime+=Time.smoothDeltaTime;
        
        if (Input.GetKeyDown("mouse 0") && nowtime>1)
        {
            Application.LoadLevel("menuscene");
        }
	}

    void OnGUI()
    {
        SCORE.text = "" + (int)score;
        KM.text = "" + (int)km;
        COIN.text = "" + (int)coin;
    }
}
