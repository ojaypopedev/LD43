using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSteak : MonoBehaviour {
    public GameObject Steak;
    public GameObject Cooker;
    public GameObject SteakPile;


    public float rawSteakNum;
    bool followingMouse;
    bool onGrill = false;
    public float FoodNum;


    public GameObject parent;


    public Camera miniGameCam;


    // Use this for initialization
    void Start () {
        //Steak.GetComponent<SpriteRenderer>().enabled = false;

    }

    // Update is called once per frame
    void Update() {
        print("Following mouse? " + followingMouse);


        /*if (followingMouse)
        {
            Steak.GetComponent<SpriteRenderer>().enabled = true;
            Vector3 camPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Steak.transform.position = new Vector3(camPos.x, camPos.y, 0);


        }*/



        Debug.DrawRay(miniGameCam.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(miniGameCam.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));
            RaycastHit hit;
            Physics.Raycast(ray, out hit);

            

            print(1);
            if (hit.collider != null)
            {

                if (hit.collider.gameObject == SteakPile && rawSteakNum > 0)
                {
                    rawSteakNum -= 1;
                    Instantiate(Steak, transform.position, Quaternion.identity);
                   

                }

            }
        }


       



        //if (Cooker.GetComponent<Cannon>().reloaded == true)
        //{
        //    Steak.transform.position = transform.position;
        //    Steak.GetComponent<SpriteRenderer>().enabled = false;

        //}
    }

   

}

