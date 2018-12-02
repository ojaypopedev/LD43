using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour {
    BoxCollider2D CS;

    
	// Use this for initialization
	void Start () {
        CS = GetComponent<BoxCollider2D>();
    
	}
	
	// Update is called once per frame
	void Update () {



        if (CS.IsTouchingLayers(LayerMask.GetMask("Steak Layer")))
        {
            print("AAAAAAAAAAAAAAAAAH");





        }

    }
}
