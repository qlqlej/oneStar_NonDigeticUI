using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
    private Vector3 v;
	public GameObject particle;
	// Use this for initialization
	void Start () {
        v = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        v.y -= 0.3f;
        gameObject.transform.position = v;
        if (v.y<=-11)
        {
            Destroy(gameObject);
        }
	}
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag=="OBJECT")
        {
            Destroy(gameObject);
        }
        else if (coll.gameObject.tag=="MONSTER")
        {
			Instantiate(particle,gameObject.transform.position,Quaternion.identity);


            coll.SendMessage("Damaged", SendMessageOptions.DontRequireReceiver);
            
			Destroy(gameObject);

        }
    }
}
