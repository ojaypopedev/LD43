using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGrab : MonoBehaviour {

    public GameObject servingPlate;

    Rigidbody body;

    public float xSpeed;
    public float ySpeed;

    public float maxX;
    public float minX;

    public bool grabbed = false;
    public bool grab = false;


    string dir = "none";

	// Use this for initialization
	void Start () {

        body = GetComponent<Rigidbody>();

        dir = "none";

	}
	
	// Update is called once per frame
	void Update () {


        if(transform.localPosition.x >  maxX)
        {
            transform.localPosition = new Vector3(maxX, transform.localPosition.y, 0);
        }

        print(transform.localPosition.x > maxX);

        print("xPos = "+ transform.localPosition.x);
        //print(dir);

        body.velocity = (new Vector3(xSpeed, ySpeed, 0));

        if (dir == "none")
        {

            xSpeed = 0;

        }

       // print(dir);

        if (transform.localPosition.x == maxX && grabbed == true)
        {

            print("Max");
            dir = "none";
            grab = false;
            grabbed = false;

        }

        if (servingPlate.GetComponent<ServingPlate>().serve == true && grab == false)
        {
          
            grab = true;
            
        }

        if(grab == true)
        {

           

            if(transform.localPosition.x <= maxX && grabbed == false)
            {
                dir = "left";

            }

            

            if (transform.localPosition.x < minX)
            {
                
                dir = "right";
                grabbed = true;

            }

           

            if(dir == "left")
            {

                xSpeed = -6f;

            }

            if (dir == "right")
            {

                xSpeed = 6f;

            }

            

        }

	}
}
