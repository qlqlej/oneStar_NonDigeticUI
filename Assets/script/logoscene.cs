using UnityEngine;
using System.Collections;

public class logoscene : MonoBehaviour {
    public Texture2D whitetexture;
    private float alphablend;
    private bool fade;
	// Use this for initialization
	void Start () {
        alphablend = 1;
        fade = true;
	}
	
	// Update is called once per frame
	void Update () {
	    if (alphablend<=0.0f&&fade)
	    {
            fade = false;
            alphablend = -1;
	    }
        if (alphablend>=1.1f)
        {
            Application.LoadLevel("logo2");
        }
        
	    
	}

    void OnGUI()
    {
        if (fade)
        {
            alphablend -= Mathf.Clamp01(Time.smoothDeltaTime / 1.5f);
            GUI.color = new Color(0, 0, 0, alphablend);
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), whitetexture);
        }
        else
        {
            alphablend += Mathf.Clamp01(Time.smoothDeltaTime / 1.5f);
            GUI.color = new Color(0, 0, 0, alphablend);
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), whitetexture);
        }
    }
}
