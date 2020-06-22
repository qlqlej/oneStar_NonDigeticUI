using UnityEngine;
using System.Collections;

public class O2Gauge : MonoBehaviour {
    public static float O2;
	// Use this for initialization
	void Start () {
        O2 = 100f;
	}
	
	// Update is called once per frame
	void Update () {
        if (O2<=0f)
        {
            resultscene.km = GameManager.km;
            resultscene.score = GameManager.score;
            Application.LoadLevel("resultscene");
        }
        transform.localScale=new Vector3(O2 / 100f, transform.localScale.y, transform.localScale.z);
	}
}
