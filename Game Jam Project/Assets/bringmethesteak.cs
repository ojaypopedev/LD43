using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bringmethesteak : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject[] steaks = GameObject.FindGameObjectsWithTag("Steak");
        foreach (var steak in steaks)
        {
            steak.transform.SetParent(transform);
        }
	}
}
