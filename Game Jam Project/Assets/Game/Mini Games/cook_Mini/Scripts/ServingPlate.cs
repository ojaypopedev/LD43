using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServingPlate : MonoBehaviour {

    public bool serve = false;

    public GameObject Steak;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(serve == true)
        {
            Steak.GetComponent<Steak>().snapToPlate = true;

           

            

        }


	}

    void OnTriggerStay(Collider col)
    {

        print("Hit");

        if(col.gameObject.tag == "Steak")
        {

            Steak = col.gameObject;

            if(col.gameObject.GetComponent<Steak>().CookingState == "Cooked")
            {

                serve = true;

            }

        }
        
    }
}
