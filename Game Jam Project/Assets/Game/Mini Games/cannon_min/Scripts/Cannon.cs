using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {
    string RotationDirection = "Right";
   public bool fired = false;
    public float timer = 0f;
    public GameObject CannonBall;
    public float FireSpeed;
    public  bool reloaded = true;
    BoxCollider2D bd;
    public GameObject BallManager;

    public cannon_ball_count balls;

    public string cannonGame;


    public GameObject parent;

    // Use this for initialization
    void Start () {
        bd = GetComponent<BoxCollider2D>();

        balls = GameObject.Find("Boat").GetComponent<cannon_ball_count>();
    }
	
	// Update is called once per frame
	void Update () {
        //print("Current Rotation = " + transform.rotation.eulerAngles.z);
        //print("Rotation Time" + timer);
        timer -= 1;
       // print("Current Rotation =" + RotationDirection);
        print("is The Cannon Ball fired?" + fired);
       // print("Cannonball Velocity" + CannonBall.GetComponent<Rigidbody2D>().velocity);

        if (Input.GetKeyDown(KeyCode.Space) && GameObject.Find("MiniGame Cam").GetComponent<gotoMiniGame>().gameActive == cannonGame)
        {
            fired = true;
            if (reloaded)
            {


                balls.count -= 1;


            }
           
        }

        if (RotationDirection == "Left")
        {
            RotateLeft();
        }
          
      if(RotationDirection == "Right")
        {
            RotateRight();
        }
        


      if(timer == 0 && RotationDirection == "Right")
        {
            RotationDirection = "Left";
            timer = 180;
        }
      if(timer == 0 && RotationDirection == "Left")
        {
            RotationDirection = "Right";
            timer = 180;
        }

    if(fired == false)
        {
            CannonBall.transform.position = Vector2.one * 100;
           


            if (reloaded == true)
            {
                CannonBall.transform.position = this.transform.position;
                CannonBall.transform.rotation = this.transform.rotation;

            }
         


        }

       if(fired == true)
        {
            print("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHH");
            
            CannonBall.GetComponent<Rigidbody2D>().velocity = transform.up * FireSpeed;
            reloaded = false;

            
            if (CannonBall.transform.position.y > 6+parent.transform.position.y)
            {
                fired = false;
            }
        }



        if (bd.IsTouchingLayers(LayerMask.GetMask("CursorBall")))
        {
            reloaded = true;
        }





    }

   


    void RotateRight()
    {
        
        transform.Rotate(0, 0, 0.25f);


    }
    void RotateLeft()
    {
        transform.Rotate(0, 0, -0.25f);

    }



}
