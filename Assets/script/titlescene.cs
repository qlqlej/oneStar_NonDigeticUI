using UnityEngine;
using System.Collections;

public class titlescene : MonoBehaviour {
    public Texture2D whitetexture;
    private float alphablend;
    private bool fade;
    private bool touched;
    // Use this for initialization
    void Start()
    {
        alphablend = 1;
        fade = true;
        touched = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (alphablend <= 0.0f && fade)
        {
            fade = false;
        }
        if (!fade)
        {
            if (alphablend>=1.1f&&touched)
            {
                Application.LoadLevel("loadingscene");
            }
            if (!touched&&Input.touchCount>0)
            {
                touched = true;
            }
            
        }

        if (Input.GetKeyDown("mouse 0")) // R을 누르면
        {
            Application.LoadLevel("loadingscene");
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
        if (!fade&&touched)
        {
            alphablend += Mathf.Clamp01(Time.smoothDeltaTime / 1.5f);
            GUI.color = new Color(0, 0, 0, alphablend);
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), whitetexture);
        }
    }

   
}
