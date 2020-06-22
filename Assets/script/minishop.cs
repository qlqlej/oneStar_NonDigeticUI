using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class minishop : MonoBehaviour {
    private RaycastHit hit;
    public GameObject itemexplain;
    public Texture2D ex1, ex2, ex3, ex4;
    public Text it1, it2, it3, it4,cointxt,startxt;
    int nowselected;
	// Use this for initialization
	void Start () {
        nowselected = 0;
        totalmanager.coin = 100000;
       // it1.fontSize = it2.fontSize = it3.fontSize = it4.fontSize = Mathf.RoundToInt(Camera.main.pixelHeight / 17f);
      //  cointxt.fontSize = startxt.fontSize = Mathf.RoundToInt(Camera.main.pixelHeight / 26f);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("menuscene");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition.x);
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 vec = Vector3.zero;
            vec = Input.GetTouch(0).position;
            Ray ray = GetComponent<Camera>().ScreenPointToRay(vec);
            if (Physics.Raycast(ray, out hit))
            {
                switch (hit.collider.tag)
                {
                    case "ITEM1":
                        nowselected = 0;
                        itemexplain.GetComponent<Renderer>().material.mainTexture = ex1;
                        break;
                    case "ITEM2":
                        nowselected = 1;
                        itemexplain.GetComponent<Renderer>().material.mainTexture = ex2;
                        break;
                    case "ITEM3":
                        nowselected = 2;
                        itemexplain.GetComponent<Renderer>().material.mainTexture = ex3;
                        break;
                    case "ITEM4":
                        nowselected = 3;
                        itemexplain.GetComponent<Renderer>().material.mainTexture = ex4;
                        break;
                    case "START":
                        totalmanager.nextscene = 1;
                        Application.LoadLevel("loadingscene");
                        break;
                    case "END":
                        Application.LoadLevel("menuscene");
                        break;
                    case "BUY":
                        itembuy();
                        //구매
                        break;
                }
            }
        }
        if (Input.GetKeyDown("mouse 0"))
        {
            Vector3 vec = Vector3.zero;
            vec = Input.mousePosition;
            Ray ray = GetComponent<Camera>().ScreenPointToRay(vec);
            if (Physics.Raycast(ray, out hit))
            {
                switch (hit.collider.tag)
                {
                    case "ITEM1":
                        nowselected = 0;
                        itemexplain.GetComponent<Renderer>().material.mainTexture = ex1;
                        break;
                    case "ITEM2":
                        nowselected = 1;
                        itemexplain.GetComponent<Renderer>().material.mainTexture = ex2;
                        break;
                    case "ITEM3":
                        nowselected = 2;
                        itemexplain.GetComponent<Renderer>().material.mainTexture = ex3;
                        break;
                    case "ITEM4":
                        nowselected = 3;
                        itemexplain.GetComponent<Renderer>().material.mainTexture = ex4;
                        break;
                    case "START":
                        totalmanager.nextscene = 1;
                        Application.LoadLevel("loadingscene");
                        break;
                    case "END":
                        Application.LoadLevel("menuscene");
                        break;
                    case "BUY":
                        itembuy();
                        //구매
                        break;
                }
            }
        }
    }
    void itembuy()
    {
        
        if (nowselected==0)
        {
            if (totalmanager.coin>1000)
            {
                totalmanager.coin -= 1000;
                totalmanager.item1++;
            }
            
        }
        else if (nowselected==1)
        {
            if (totalmanager.coin > 1500)
            {
                totalmanager.coin -= 1500;
                totalmanager.item2++;
            }
        }
        else if (nowselected==2)
        {
            if (totalmanager.coin > 2000)
            {
                totalmanager.coin -= 2000;
                totalmanager.item3++;
            }
        }
        else if (nowselected==3)
        {
            if (totalmanager.coin > 2500)
            {
                totalmanager.coin -= 2500;
                totalmanager.item4++;
            }
        }
    }
    void OnGUI()
    {
        it1.text = "" + totalmanager.item1;
        it2.text = "" + totalmanager.item2;
        it3.text = "" + totalmanager.item3;
        it4.text = "" + totalmanager.item4; 
        cointxt.text = "" + totalmanager.coin;
    }
}
