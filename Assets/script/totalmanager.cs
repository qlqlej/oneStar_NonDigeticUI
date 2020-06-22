using UnityEngine;
using System.Collections;

public class totalmanager : MonoBehaviour {
    public static int item1,item2,item3,item4;
    public static int coin, star;
    public static int nextscene;
	// Use this for initialization
	void Start () {
        item1 = item2 = item3 = item4 = 0;
        coin = star = 100000;
        nextscene = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
