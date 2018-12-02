using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagedShip : MonoBehaviour {

    public int parts;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        parts = 0;
        broken[] brokenparts = GetComponentsInChildren<broken>();
        foreach (var item in brokenparts)
        {
            parts++;
        }

       

        


	}
}
