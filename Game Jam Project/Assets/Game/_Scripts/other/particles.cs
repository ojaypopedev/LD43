using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour {

    public GameObject manager;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(0, 0, manager.GetComponent<Wind>().windAngle);
        
	}
}
