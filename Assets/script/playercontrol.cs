using UnityEngine;
using System.Collections;

public class playercontrol : MonoBehaviour {
    public static bool isfever;
	// Use this for initialization
	void Start () {
        isfever = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isfever)//피버상태 
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 4, gameObject.transform.position.z);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 8, gameObject.transform.position.z);
        }
        //if (Input.touchCount > 0)
        //{
            Vector3 v;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (gameObject.transform.position.x>-5f)
                {
                    v = new Vector3(gameObject.transform.position.x - 0.10f, gameObject.transform.position.y, gameObject.transform.position.z);
                    gameObject.transform.position = v;
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                if (gameObject.transform.position.x < 5f)
                {
                    v = new Vector3(gameObject.transform.position.x + 0.10f, gameObject.transform.position.y, gameObject.transform.position.z);
                    gameObject.transform.position = v;
                }
                }
            }
       // }
	}
}
