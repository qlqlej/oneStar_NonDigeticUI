using UnityEngine;
using System.Collections;

public class gunshot : MonoBehaviour {
    public GameObject bullet;
    private float nowtime, thattime;
	// Use this for initialization
	void Start () {
        thattime = 1.3f;        
	}
	
	// Update is called once per frame
	void Update () {
        nowtime += Time.smoothDeltaTime;
        if (nowtime > thattime)
        {
            thattime = 0.3f;
            if (boostergauge.gaugestate==false)
            {
                Instantiate(bullet, transform.position, Quaternion.identity);
                nowtime = 0;
            }
        }    
	}
}
