using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steak : MonoBehaviour {

    public bool IsCooking = false;
    public float CookingTime = 10;
    public string CookingState = "Raw";

    public bool onGrill = false;
    public bool followingMouse;
    public bool canDrag = true;
    public bool snapToPlate = false;

    public Color cooked;
    public Color burnt;

    public bool followHand = false;

    Animator cookingAn;

    public GameObject plate;
    public GameObject hand;


    public Camera miniGameCam;


    public Food food;

	// Use this for initialization
	void Start () {


        food = GameObject.Find("Boat").GetComponent<Food>();

        miniGameCam = GameObject.Find("MiniGame Cam").GetComponent<Camera>();

        canDrag = true;

        followingMouse = true;

        cookingAn = GetComponent<Animator>();

        plate = GameObject.FindGameObjectWithTag("Plate");
        hand = GameObject.FindGameObjectWithTag("Hand");

        CookingState = "Raw";

        CookingTime = 10;
	}
	
	// Update is called once per frame
	void Update () {


        if (followHand == false)
        {

            cookingAn.SetTrigger(CookingState);

            //print("Time Left To Cook = " + CookingTime);

            Debug.DrawRay(miniGameCam.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));

            //print(miniGameCam.ScreenToWorldPoint(Input.mousePosition));

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = new Ray(miniGameCam.ScreenToWorldPoint(Input.mousePosition), new Vector3(0, 0, 20));
                RaycastHit hit;
                Physics.Raycast(ray, out hit);

                if (hit.collider.gameObject == gameObject)
                {

                    followingMouse = true;

                }

            }

            if (followingMouse == true && onGrill == false && canDrag == true)
            {

                Vector3 camPos = miniGameCam.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector3(camPos.x, camPos.y, 0);


            }

            if (Input.GetMouseButtonUp(0))
            {

                followingMouse = false;

            }


            if (IsCooking)
            {
                CookingTime -= Time.deltaTime;
                if (CookingTime < 8)
                {
                    CookingState = "Cooked";

                }

                if (CookingTime < 2)
                {
                    CookingState = "Burnt";

                }
            }

            if (CookingState == "Burnt")
            {
                IsCooking = false;
                CookingTime = 10;


            }

            if (GetComponent<SpriteRenderer>().color.a == 0)
            {

                Destroy(gameObject);

            }

            if (CookingState != "Raw")
            {
                onGrill = false;

            }

            if (snapToPlate == true)
            {
                canDrag = false;
                transform.position = new Vector3(plate.transform.position.x, plate.transform.position.y, 0);

            }

        }


        if(followHand == true)
        {
            print("Steakpos" + transform.localPosition.x);
            transform.position = new Vector3(hand.transform.position.x - 6, transform.position.y, 0);
            hand.GetComponent<HandGrab>().grabbed = true;

            if(this.transform.localPosition.x == hand.GetComponent<HandGrab>().maxX - 6){


                plate.GetComponent<ServingPlate>().serve = false;
                Destroy(gameObject);
                food.cookedFood++;


            }

        }

    }

    void OnTriggerStay(Collider col)
    {

        

        if (col.gameObject.tag == "Grill" && followingMouse == false && CookingState == "Raw")
        {

            onGrill = true;
            IsCooking = true;

        }

        if(col.gameObject.tag == "Hand" && hand.GetComponent<HandGrab>().grabbed == false && CookingState == "Cooked")
        {
            print("HandCol" + col.gameObject.name);

            followHand = true;

        }

    }

    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "Grill")
        {

            onGrill = false;
            IsCooking = false;

        }

    }
}
