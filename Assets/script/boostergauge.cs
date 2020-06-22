using UnityEngine;
using System.Collections;

public class boostergauge : MonoBehaviour {
    public static float booster;
    public static bool gaugestate;
    public GameObject fevercutscene;
    private int cutscenestate;
	// Use this for initialization
	void Start () {
        cutscenestate = 0;
        booster = 0;
        gaugestate = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (fevercutscene.transform.position.x>=1&&cutscenestate==1)
        {
            fevercutscene.transform.Translate(20 * Vector3.left * Time.deltaTime);
        }
        else if(cutscenestate==1)
        {
            cutscenestate = 2;
        }
        else if (fevercutscene.transform.position.x<=1.15&&cutscenestate==2)
        {
            fevercutscene.transform.Translate(0.7f * Vector3.right * Time.deltaTime);
        }
        else if (cutscenestate==2)
        {
            cutscenestate = 3;
        }
        else if (fevercutscene.transform.position.x <= 11 && cutscenestate == 3)
        {
            fevercutscene.transform.Translate(25 * Vector3.right * Time.deltaTime);
        }
        else if (cutscenestate==3)
        {
            cutscenestate = 0;
        }
        if (booster>=1000f)
        {
            gaugestate = true;
            cutscenestate = 1;
            GameObject.Find("fevereffect").SendMessage("hideeffect",true, SendMessageOptions.DontRequireReceiver);

        }
        if (gaugestate)
        {
            booster -= 100f * Time.smoothDeltaTime;
            if (booster<=0f)
            {
                booster = 0;
                gaugestate = false;
                GameObject.Find("fevereffect").SendMessage("hideeffect",false, SendMessageOptions.DontRequireReceiver);
            }
            
        }
        transform.localScale = new Vector3(booster / 1000f, transform.localScale.y, transform.localScale.z);
	}
}
