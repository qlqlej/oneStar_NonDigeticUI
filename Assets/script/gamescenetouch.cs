using UnityEngine;
using System.Collections;

public class gamescenetouch : MonoBehaviour {
    private RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 vec = Vector3.zero;
            vec = Input.GetTouch(0).position;
            Ray ray = GetComponent<Camera>().ScreenPointToRay(vec);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag=="STOP")
                {
                    resultscene.km = GameManager.km;
                    resultscene.score = GameManager.score;
                    Application.LoadLevel("resultscene");
                }
            }
        }
	}
}
