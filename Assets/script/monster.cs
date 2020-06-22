using UnityEngine;
using System.Collections;

public class monster : MonoBehaviour {
    public float HP;
    public float SPEED;
	public GameObject deadparticle;
	public GameObject o2particle;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 v=gameObject.transform.position;
        v.y += SPEED * Time.smoothDeltaTime;
        gameObject.transform.position = v;
        if (v.y >= 11)
        {
            Destroy(gameObject);
        }
	}

    void initHP(float hp)
    {
        HP = hp;
    }

    void initSPEED(float speed)
    {
        SPEED = speed;
    }

    void Damaged()
    {
        HP -= GameManager.bulletdamage;
        if (HP <= 0.0f)
        {
			Instantiate(deadparticle,gameObject.transform.position,Quaternion.identity);
            Destroy(gameObject);
            if (boostergauge.booster>=950f)
            {
                boostergauge.booster = 1000f;
                GameManager.score += 50 + ((GameManager.stagenum - 1) * 10);
            }
            else
            {
                GameManager.score += 50 + ((GameManager.stagenum - 1) * 10);
                boostergauge.booster += 50f;
            }
            
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag=="CHARACTER")
        {
            O2Gauge.O2 -= 30.0f;

			Instantiate(o2particle,coll.gameObject.transform.position,Quaternion.identity);

            if (boostergauge.booster>300.0f)
            {
                boostergauge.booster -= 300.0f;
            }
            else
            {
                boostergauge.booster = 0;
            }
            Destroy(gameObject);
        }
        if (coll.gameObject.tag=="FEVER")
        {
			Instantiate(deadparticle,gameObject.transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
