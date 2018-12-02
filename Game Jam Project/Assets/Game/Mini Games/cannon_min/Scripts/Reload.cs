using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {
    public GameObject CursorBoi;
    public GameObject CannonOrigin;


    public Camera miniGameCam;

    bool followingMouse;
    cannon_ball_count balls;
    

	// Use this for initialization
	void Start () {

	
	}

    // Update is called once per frame
    void Update() {


        balls = GameObject.Find("Boat").GetComponent<cannon_ball_count>();
        print("BALLS"+ balls);



        if (Input.GetMouseButtonUp(0))
            {
                followingMouse = false;
                CursorBoi.transform.position = new Vector3(100, 100, 0);


        }

            if(followingMouse)
            {
                Vector3 camPos = miniGameCam.ScreenToWorldPoint(Input.mousePosition);
                CursorBoi.transform.position = new Vector3(camPos.x, camPos.y, 0);
                 

            }


        if (CannonOrigin.GetComponent<Cannon>().reloaded == false)
        {
            Debug.DrawRay(miniGameCam.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));
            if (Input.GetMouseButtonDown(0)&& balls.count > 0)
            {
                Ray ray = new Ray(miniGameCam.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));
                RaycastHit hit;
                Physics.Raycast(ray, out hit);


                print(1);
                if (hit.collider != null)
                {

                    if (hit.collider.gameObject == gameObject)
                    {
                        
                        followingMouse = true;
                        CursorBoi.GetComponent<SpriteRenderer>().enabled = true;
                    }

                    
                }
            }

         


        }

        if (CannonOrigin.GetComponent<Cannon>().reloaded == true)
        {
            CursorBoi.transform.position = transform.position;
            CursorBoi.GetComponent<SpriteRenderer>().enabled = false;

        }

    }
}
