using UnityEngine;
using System.Collections;

public class bgmove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var amtToMove = GameManager.SPEED * Time.deltaTime;
        transform.Translate(Vector3.up * amtToMove);
        if (transform.position.y > 40)
        {
            Vector3 v = transform.position;
            v.y = -10;
            transform.position = v;
        }
	}
}
