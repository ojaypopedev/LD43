using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatCamera : MonoBehaviour {

    public GameObject boatCam;
    public bool isOn = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            boatCam.SetActive(isOn);
           
        }
	}
}
