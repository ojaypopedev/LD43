using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteakCooked : MonoBehaviour {
    public bool IsCooking = false;
    public float CookingTime;
    public string CookingState = "Raw";
   
	// Use this for initialization
	void Start () {
        CookingTime = 10;
	}
	
	// Update is called once per frame
	void Update () {
        //print("Time Left To Cook = " + CookingTime);
		if(IsCooking)
        {
            CookingTime -= Time.deltaTime;
            if(CookingTime < 3)
            {
                CookingState = "Cooked";

            }

               if(CookingTime < 1)
            {
                CookingState = "Burnt";

            }
        }

        if(CookingState == "Burnt")
        {
            IsCooking = false;
            CookingTime = 5;


        }


      

        }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Grill")
        {


            print("AAAHhh");
            IsCooking = true;

        }

    }
}
