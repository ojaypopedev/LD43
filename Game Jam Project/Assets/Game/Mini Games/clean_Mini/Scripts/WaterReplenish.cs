using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterReplenish : MonoBehaviour {
    public GameObject MOP;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Mop")
        {
            MOP.GetComponent<Clean>().Water += 0.5f;

        }



    }



}
