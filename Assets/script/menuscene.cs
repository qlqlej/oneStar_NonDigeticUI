using UnityEngine;
using System.Collections;

public class menuscene : MonoBehaviour {
    private RaycastHit hit;
    public GameObject endmessage,endmessage1,endmessage2;
    private bool messageon;
	// Use this for initialization
	void Start () {
        endmessage.GetComponent<Renderer>().enabled = false;
        endmessage1.GetComponent<Renderer>().enabled = false;
        endmessage2.GetComponent<Renderer>().enabled = false;
        messageon = false;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (messageon == false)
            {
                endmessage.GetComponent<Renderer>().enabled = true;
                endmessage1.GetComponent<Renderer>().enabled = true;
                endmessage2.GetComponent<Renderer>().enabled = true;
                messageon = true;
            }
            else if (messageon == true)
            {
                endmessage.GetComponent<Renderer>().enabled = false;
                endmessage1.GetComponent<Renderer>().enabled = false;
                endmessage2.GetComponent<Renderer>().enabled = false;
                messageon = false;
            }
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 vec = Vector3.zero;
            vec = Input.GetTouch(0).position;
            Ray ray = GetComponent<Camera>().ScreenPointToRay(vec);
            if (Physics.Raycast(ray, out hit))
            {
                if (messageon == false)
                {
                    switch (hit.collider.tag)
                    {
                        case "START":
                            totalmanager.nextscene = 1;
                            Application.LoadLevel("loadingscene");
                            break;
                        case "INVENTORY":
                            Application.LoadLevel("minishopscene");
                            Application.Quit();
                            break;
                        case "END":
                            endmessage.GetComponent<Renderer>().enabled = true;
                            endmessage1.GetComponent<Renderer>().enabled = true;
                            endmessage2.GetComponent<Renderer>().enabled = true;
                            messageon = true;
                            break;
                    }
                }
                else if (messageon == true)
                {
                    switch (hit.collider.tag)
                    {
                        case "TRUEEND":
                            Application.Quit();
                            break;
                        case "NO":
                            endmessage.GetComponent<Renderer>().enabled = false;
                            endmessage1.GetComponent<Renderer>().enabled = false;
                            endmessage2.GetComponent<Renderer>().enabled = false;
                            messageon = false;
                            break;
                    }
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
                if (messageon == false)
                {
                    switch (hit.collider.tag)
                    {
                        case "START":
                            totalmanager.nextscene = 1;
                            Application.LoadLevel("loadingscene");
                            break;
                        case "INVENTORY":
                            Application.LoadLevel("minishopscene");
                            Application.Quit();
                            break;
                        case "END":
                            endmessage.GetComponent<Renderer>().enabled = true;
                            endmessage1.GetComponent<Renderer>().enabled = true;
                            endmessage2.GetComponent<Renderer>().enabled = true;
                            messageon = true;
                            break;
                    }
                }
                else if (messageon == true)
                {
                    switch (hit.collider.tag)
                    {
                        case "TRUEEND":
                            Application.Quit();
                            break;
                        case "NO":
                            endmessage.GetComponent<Renderer>().enabled = false;
                            endmessage1.GetComponent<Renderer>().enabled = false;
                            endmessage2.GetComponent<Renderer>().enabled = false;
                            messageon = false;
                            break;
                    }
                }
            }
        }
    }
}
