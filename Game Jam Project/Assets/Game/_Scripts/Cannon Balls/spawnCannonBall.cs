using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCannonBall : MonoBehaviour {

    public GameObject ball;
   

    public float angle;
    public float offangle;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

            if (GameObject.Find("Boat").GetComponent<cannon_ball_count>().count > 0)
            {
                
            }
        
            
        
	}


    public void fire(bool hit)
    {
        Instantiate(ball, transform.position, Quaternion.identity);

       
        
            ball.GetComponent<cannonBallPlayer>().direction = angle;
        
      
       
       // GameObject.Find("Boat").GetComponent<cannon_ball_count>().count -= 1;
    }
}
