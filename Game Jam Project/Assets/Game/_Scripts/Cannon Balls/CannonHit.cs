using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonHit : MonoBehaviour {

    public GameObject broken;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        print("hit");

        if (collision.gameObject.tag == "cannonball")
        {


            Instantiate(broken, collision.contacts[0].point, Quaternion.identity,GameObject.Find("Boat").transform);
            Destroy(collision.gameObject);
        }
    }
    
}
