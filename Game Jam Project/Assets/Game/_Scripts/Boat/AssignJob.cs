using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignJob : MonoBehaviour {

    public GameObject Worker;
    public string jobDone;
    public GameObject boat;

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

    }
}
