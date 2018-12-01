using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draganddrop : MonoBehaviour
{

    public bool followingMouse = false;
    bool onBoat = true;
    bool allowDrag = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));
        if (Input.GetMouseButtonDown(0) && allowDrag)
        {
            Ray ray = new Ray(Camera.main.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));
            RaycastHit hit;
            Physics.Raycast(ray, out hit);


            print(1);
            if (hit.collider != null)
            {
                
                if (hit.collider.gameObject == gameObject)
                {
                    followingMouse = true;   
                }

            }

        }

        if ((Input.GetMouseButtonUp(0))){
            followingMouse = false;

            if (!onBoat)
            {
                transform.SetParent(null);
                allowDrag = false;
                if(gameObject.tag == "crew")
                {
                    GetComponent<reactiveCrew>().swim = true;
                }
            }
        }

        if (followingMouse)
        {

            Vector3 camPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(camPos.x, camPos.y, 0);

         
           
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "boat")
        {
            onBoat = true;
            print("ON");
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "boat")
        {
            onBoat = false;
            print("OFF");
        }
    }

}
