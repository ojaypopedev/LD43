using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {


    public bool follow = true;
    public Camera miniGameCam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        follow = miniGameCam.GetComponent<gotoMiniGame>().gameActive == "clean";

        if (follow)
        {
            Vector3 camPos = miniGameCam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(camPos.x, camPos.y, 0);
        }
       

    }
}
