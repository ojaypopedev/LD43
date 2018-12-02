using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCannonBall : MonoBehaviour {

    public GameObject ball;
    public bool fire;

    public float angle;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (fire)
        {

            if (GameObject.Find("Boat").GetComponent<cannon_ball_count>().count > 0)
            {
                Instantiate(ball, transform.position, Quaternion.identity);
                ball.GetComponent<cannonBallPlayer>().direction = angle;
                GameObject.Find("Boat").GetComponent<cannon_ball_count>().count -= 1;
            }
            fire = false;
            
        }
	}
}
