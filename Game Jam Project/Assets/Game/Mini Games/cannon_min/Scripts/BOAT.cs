using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOAT : MonoBehaviour {
    bool GoingRight = false;
    public GameObject TargetPoint;

    public float minX = -1;
    public float maxX = 1;

    public GameObject parent; 


	// Use this for initialization
	void Start () {
        TargetPoint.transform.position = new Vector3(transform.position.x+(Random.Range(-1.6f, 2.2f)), transform.position.y+(Random.Range(-0.5f, 0.5f)), 0);
	}
	
	// Update is called once per frame
	void Update () {
      //  print("Going Right? " + GoingRight);
        if (transform.position.x >= maxX + parent.transform.position.x)
        {
            GoingRight = false;
            GetComponent<SpriteRenderer>().flipX = false; 
        }
       
        if(transform.position.x <= minX + parent.transform.position.x)
        {
            GoingRight = true;
            GetComponent<SpriteRenderer>().flipX = true;

        }
        if (GoingRight == false)
        {
            transform.position -= new Vector3(3*Time.deltaTime, 0, 0);
        }
       
        if(GoingRight == true)
        {
            transform.position += new Vector3(3*Time.deltaTime, 0, 0);
        }

		
	}
}
