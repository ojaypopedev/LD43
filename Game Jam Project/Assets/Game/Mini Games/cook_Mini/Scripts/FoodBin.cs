using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBin : MonoBehaviour
{

    bool dispose = false;

    public GameObject steak;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (dispose == true)
        {
            print(steak);

            steak.GetComponent<Steak>().canDrag = false;
            steak.transform.position = new Vector3(transform.position.x, transform.position.y, 0);

            steak.GetComponent<Animator>().SetTrigger("Dispose");



        }


    }

    void OnTriggerStay(Collider col)
    {

        print("Hit");

        if (col.gameObject.tag == "Steak")
        {

            steak = col.gameObject;


            

                dispose = true;

            

        }

    }
}
