using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOn : MonoBehaviour {

    public string miniGame;

    public GameObject miniGameCam;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(Camera.main.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));
            RaycastHit hit;
            Physics.Raycast(ray, out hit);


           
            //print(1);
            if (hit.collider != null)
            {
                

                if (hit.collider.gameObject==gameObject)
                {

                   
                    miniGameCam.GetComponent<gotoMiniGame>().gameActive = miniGame;
                }

            }

        }
    }
}
