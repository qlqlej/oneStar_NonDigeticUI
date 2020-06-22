using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {
    float timer;
    int waitingTime;
    // Use this for initialization
    void Start () {
        timer = 0.0f;
        waitingTime = 2;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            if (totalmanager.nextscene == 1)
            {
                Application.LoadLevel("gamescene");
            }
            else if (totalmanager.nextscene == 0)
            {
                Application.LoadLevel("menuscene");
            }
            else
            {
                Application.LoadLevel("menuscene");
            }
        }
	}

    void OnGUI()
    {
        
    }
}
