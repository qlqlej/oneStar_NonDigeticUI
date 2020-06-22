using UnityEngine;
using System.Collections;

public class nongamebgmove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var amtToMove = 2.5f * Time.deltaTime;
        transform.Translate(Vector3.up * amtToMove);
        if (transform.position.y > 30)
        {
            Vector3 v = transform.position;
            v.y = -10;
            transform.position = v;
        }
	}
}
