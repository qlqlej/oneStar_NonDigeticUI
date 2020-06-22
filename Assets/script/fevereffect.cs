using UnityEngine;
using System.Collections;

public class fevereffect : MonoBehaviour {
    private Material m;
    private float frametime, nowtime, nowframe;
    // Use this for initialization
    void Start()
    {
        m = gameObject.GetComponent<Renderer>().material;
        hideeffect(false);
        frametime = 0.1f;
        nowtime = 0.0f;
        nowframe = 2;
    }

    // Update is called once per frame
    void Update()
    {
        nowtime += Time.smoothDeltaTime;
        if (nowtime > frametime)
        {
            nowframe--;
            if (nowframe < 0)
            {
                nowframe = 2;
            }
            Vector2 v = m.GetTextureOffset("_MainTex");
            v.y = nowframe * 0.34f;
            m.SetTextureOffset("_MainTex", v);
            nowtime = 0.0f;
        }
    }
    void hideeffect(bool i)
    {
        if (i)
        {
            playercontrol.isfever = true;
            gameObject.GetComponent<Collider>().enabled = true;
            gameObject.GetComponent<Renderer>().enabled = true;
			GameManager.SPEED=GameManager.SPEED*2;
        }
        else if (!i)
        {
            playercontrol.isfever = false;
            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
