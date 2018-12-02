using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireCannonBall : MonoBehaviour {

    public GameObject ball;
    float timer = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

        if(timer > 0)
        {
            timer -= Time.deltaTime;
            

        }
        else
        {
            timer = Random.Range(1, 5);
            Instantiate(ball, transform.position, Quaternion.identity);
        }
	}
}
