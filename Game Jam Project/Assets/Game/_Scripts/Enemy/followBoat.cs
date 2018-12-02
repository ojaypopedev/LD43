using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followBoat : MonoBehaviour {

    public GameObject boat;
    public float speed = 2f;
    public Vector3 offset;





    private void Start()
    {
        //boat = new GameObject();
    }

    private void Update()
    {

        if (boat.transform.position.y < transform.position.y)
        {
            offset = new Vector3(0, 8, 0);
        }


        if (boat.transform.position.y > transform.position.y)
        {
            offset = new Vector3(0, -8, 0);
        }

        Vector2 direction = (boat.transform.position+offset) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x);


        transform.rotation = Quaternion.Euler(0, 0, angle*Mathf.Rad2Deg);


      

        transform.position = Vector2.MoveTowards(transform.position, boat.transform.position+offset, speed* Time.deltaTime);
    }
}
