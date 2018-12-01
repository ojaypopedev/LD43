using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactiveCrew : MonoBehaviour {

    public GameObject boat;
    public bool swim;

    public bool eat;
    public float hungerTimer;

	void Start () {
        hungerTimer = Random.Range(10, 30);
    }
	
	// Update is called once per frame
	void Update () {

        if (eat)
        {
            eat = false;
            if (boat.GetComponent<Food>().cookedFood > 0)
            {
                boat.GetComponent<Food>().cookedFood -= 1;
            }
            else
            {
                // you are dead
                GameObject.Destroy(gameObject);
       
            }
           
        }

        if(hungerTimer < 0)
        {
            hungerTimer = Random.Range(10, 30);
            eat = true;
        }
        else
        {
            hungerTimer -= Time.deltaTime;
        }



        if (swim)
            transform.position = Vector2.Lerp(transform.position,boat.transform.position, Time.deltaTime / 30);

	}
}
