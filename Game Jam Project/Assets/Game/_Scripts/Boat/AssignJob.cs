using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignJob : MonoBehaviour {

    public GameObject Worker;
    public string jobDone;
    public GameObject boat;
    GameObject cam;

    public GameObject cannon;
   

    float cookTime = 2f;
    float shootTime = 2f;


    private void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    private void OnCollisionEnter(Collision collision)
    {

       
        if(Worker== null)
        {
           if(collision.gameObject.tag == "crew")
                Worker = collision.gameObject;
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {

        if (Worker)
        {
            if (collision.gameObject == Worker)
            {
                Worker = null;
            }

        }
    }




    private void Update()
    {


        checkJobDone(jobDone);

        if (Worker)
        {
            Worker.GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;

            if(Worker.GetComponent<Draganddrop>().followingMouse == false)
            {
                Worker.transform.position = transform.position;
            }


            

        }
       


    }


    void checkJobDone(string job)
    {
        if(job == "steer" && Worker != null)
        {
            boat.GetComponent<BoatController>().crewHelp = 2;
        }
        else
        {
            boat.GetComponent<BoatController>().crewHelp = 1;
        }


        if(job == "cook" && Worker != null)
        {
            if(cookTime > 0)
            {
                cookTime -= Time.deltaTime;
                

            }
            else 
            {
                cookTime = 2;
                boat.GetComponent<Food>().cookFood(Mathf.RoundToInt(Random.Range(1, 3)));
            }
        }

        if(job == "sail" && Worker != null)
        {
            boat.GetComponent<BoatController>().sailLad = true;
        }
        else if(job == "sail")
        {
            
            boat.GetComponent<BoatController>().sailLad = false;
        }


        if(job == "look" && Worker != null)
        {
            cam.GetComponent<CameraController>().maxZoom = 45f;
        }else if(job == "look")
        {
            cam.GetComponent<CameraController>().maxZoom = 15f;
        }

        if(job == "shoot" && Worker != null)
        {
            if (shootTime > 0)
            {
                shootTime -= Time.deltaTime;


            }
            else
            {
                shootTime = 2;
                cannon.GetComponent<spawnCannonBall>().fire = true;
            }
        }

    }
}
