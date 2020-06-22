using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    private int stagetype;
    public static int stagenum;
    public static float bulletdamage;
    public static float SPEED;//속도 
    public static float km;
    public static float score;
    private float spawntime, timetospawn;
    public GameObject spa1, spa2, spa3, spa4, spa5, spa6;
    public GameObject sat1, sat2, sat3, sat4, sat5, sat6, sat7, satboss;
    public GameObject jup1, jup2, jup3, jup4, jup5, jup6, jupboss;
    public GameObject mar1, mar2, mar3, mar4, mar5, mar6, marboss;
    public GameObject nep1, nep2, nep3, nep4, nep5, nep6, nepboss;
    public GameObject ura1, ura2, ura3, ura4, ura5, ura6, uraboss;
    public enum STAGE { SPA=1, SAT, JUP, MAR, NEP, URA };
    public Text KM,SCORE;
    public Texture2D spabg, satbg, jubbg, marbg, nepbg, urabg;
    public GameObject bg1, bg2;
	// Use this for initialization
	void Start () {
        stagenum = 1;
        stagetype = (int)STAGE.SPA;//Random.Range(2,6);
        timetospawn = 1.5f;
        spawntime = 0.0f;
        bulletdamage = 5.0f;
        SPEED = 3f;
        km = 0;
        score = 0;
   //     SCORE.fontSize=KM.fontSize = Mathf.RoundToInt(Camera.main.pixelHeight / 10f);
	}
	
	// Update is called once per frame
	void Update () {

		//피버시 몬스터 마구생성
		if(playercontrol.isfever)
		{
			timetospawn=0.3f;
		}
		else if(!playercontrol.isfever)
		{
			timetospawn=1.5f;
		}

        km += (SPEED/1.5f) *Time.smoothDeltaTime;
        if (km/(20+(stagenum-1)*10)>=stagenum)
        {
            stagenum++;
            stagetype = Random.Range(1, 7);
           if(playercontrol.isfever)
			{	SPEED = SPEED+2;
			}
				else if(!playercontrol.isfever){
				SPEED=SPEED+1;
			}

            switch(stagetype)
            {
                case 1:
                    bg1.GetComponent<Renderer>().material.mainTexture = spabg;
                    bg2.GetComponent<Renderer>().material.mainTexture = spabg;
                    break;
                case 2:
                    bg1.GetComponent<Renderer>().material.mainTexture = satbg;
                    bg2.GetComponent<Renderer>().material.mainTexture = satbg;
                    break;
                case 3:
                    bg1.GetComponent<Renderer>().material.mainTexture = jubbg;
                    bg2.GetComponent<Renderer>().material.mainTexture = jubbg;
                    break;
                case 4:
                    bg1.GetComponent<Renderer>().material.mainTexture = marbg;
                    bg2.GetComponent<Renderer>().material.mainTexture = marbg;
                    break;
                case 5:
                    bg1.GetComponent<Renderer>().material.mainTexture = nepbg;
                    bg2.GetComponent<Renderer>().material.mainTexture = nepbg;
                    break;
                case 6:
                    bg1.GetComponent<Renderer>().material.mainTexture = urabg;
                    bg2.GetComponent<Renderer>().material.mainTexture = urabg;
                    break;
            }
        }
        O2Gauge.O2 -= Time.smoothDeltaTime * 1f;
        spawntime += Time.smoothDeltaTime;
        if (spawntime>=timetospawn)
        {
		
            GameObject tempobj;
            int temp;
            switch (stagetype)
            {
                case (int)STAGE.SPA:
                    temp = Random.Range(1, 7);
                    switch(temp)
                    {
                        case 1:
                            tempobj=(GameObject)Instantiate(spa1,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP",6+(stagenum*4),SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5+(SPEED/5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 2:
                            tempobj=(GameObject)Instantiate(spa2,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6+(stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 3:
                            tempobj=(GameObject)Instantiate(spa3,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 3 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 4:
                            tempobj=(GameObject)Instantiate(spa4,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 6 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 5:
                            tempobj=(GameObject)Instantiate(spa5,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 6:
                            tempobj=(GameObject)Instantiate(spa6,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                    }
                    break;
                case (int)STAGE.SAT:
                    temp = Random.Range(1, 8);
                    switch(temp)
                    {
                        case 1:
                            tempobj=(GameObject)Instantiate(sat1,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP",6+(stagenum*4),SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5+(SPEED/5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 2:
                            tempobj=(GameObject)Instantiate(sat2,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6+(stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 3:
                            tempobj=(GameObject)Instantiate(sat3,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 3 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 4:
                            tempobj=(GameObject)Instantiate(sat4,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 6 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 5:
                            tempobj=(GameObject)Instantiate(sat5,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 6:
                            tempobj=(GameObject)Instantiate(sat6,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 7:
                            tempobj = (GameObject)Instantiate(sat7, new Vector3(Random.Range(-4f, 4f), -11, -3), Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                    }
                    break;
                case (int)STAGE.JUP:
                    temp = Random.Range(1, 7);
                    switch(temp)
                    {
                        case 1:
                            tempobj=(GameObject)Instantiate(jup1,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP",6+(stagenum*4),SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5+(SPEED/5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 2:
                            tempobj=(GameObject)Instantiate(jup2,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6+(stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 3:
                            tempobj=(GameObject)Instantiate(jup3,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 3 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 4:
                            tempobj=(GameObject)Instantiate(jup4,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 6 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 5:
                            tempobj=(GameObject)Instantiate(jup5,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 6:
                            tempobj=(GameObject)Instantiate(jup6,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                    }
                    break;
                case (int)STAGE.MAR:
                    temp = Random.Range(1, 7);
                    switch(temp)
                    {
                        case 1:
                            tempobj=(GameObject)Instantiate(mar1,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP",6+(stagenum*4),SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5+(SPEED/5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 2:
                            tempobj=(GameObject)Instantiate(mar2,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6+(stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 3:
                            tempobj=(GameObject)Instantiate(mar3,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 3 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 4:
                            tempobj=(GameObject)Instantiate(mar4,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 6 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 5:
                            tempobj=(GameObject)Instantiate(mar5,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 6:
                            tempobj=(GameObject)Instantiate(mar6,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                    }
                    break;
                case (int)STAGE.NEP:
                    temp = Random.Range(1, 7);
                    switch(temp)
                    {
                        case 1:
                            tempobj=(GameObject)Instantiate(nep1,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP",6+(stagenum*4),SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5+(SPEED/5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 2:
                            tempobj=(GameObject)Instantiate(nep2,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6+(stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 3:
                            tempobj=(GameObject)Instantiate(nep3,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 3 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 4:
                            tempobj=(GameObject)Instantiate(nep4,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 6 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 5:
                            tempobj=(GameObject)Instantiate(nep5,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 6:
                            tempobj=(GameObject)Instantiate(nep6,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                    }
                    break;
                case (int)STAGE.URA:
                    temp = Random.Range(1, 7);
                    switch(temp)
                    {
                        case 1:
                            tempobj=(GameObject)Instantiate(ura1,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP",6+(stagenum*4),SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5+(SPEED/5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 2:
                            tempobj=(GameObject)Instantiate(ura2,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6+(stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 3:
                            tempobj=(GameObject)Instantiate(ura3,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 3 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 4:
                            tempobj=(GameObject)Instantiate(ura4,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 6 + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 5:
                            tempobj=(GameObject)Instantiate(ura5,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 4.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                        case 6:
                            tempobj=(GameObject)Instantiate(ura6,new Vector3(Random.Range(-4f,4f), -11, -3),Quaternion.identity);
                            tempobj.SendMessage("initHP", 6 + (stagenum * 4), SendMessageOptions.DontRequireReceiver);
                            tempobj.SendMessage("initSPEED", 5.5f + (SPEED / 5), SendMessageOptions.DontRequireReceiver);
                            break;
                    }
                    break;
            }
            spawntime = 0.0f;
        }
        
	}
    void OnGUI()
    {
        KM.text = (int)km + "KM";
        SCORE.text = (int)score + "점";
    }
}
