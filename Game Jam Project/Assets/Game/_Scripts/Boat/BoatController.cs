using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour {


    [Range(-20,20)]
    public float directionChange;

    public GameObject manager;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float speed = manager.GetComponent<Wind>().windStrength;
        MoveTowardsRotation(transform.rotation.eulerAngles.z, Mathf.Sqrt(speed)* Time.deltaTime, Mathf.Sqrt(Mathf.Sqrt(speed))*directionChange*Time.deltaTime);


        if (Input.GetKey(KeyCode.A))
        {
            directionChange = -20;
        }
        else if (Input.GetKey(KeyCode.D))
        {

            directionChange = 20;
        }
        else
        {
            directionChange = 0;
        }

	}



   void MoveTowardsRotation(float rotation, float speed, float rotationChange)
    {

        Vector2 pos = transform.position;
        pos += GetDirFromAngle(rotation) * speed;
        transform.position = pos;
        transform.Rotate(0, 0, rotationChange);
    }

    Vector2 GetDirFromAngle(float angle)
    {
        float x = Mathf.Cos(angle*Mathf.Deg2Rad);
        float y = Mathf.Sin(angle * Mathf.Deg2Rad);
        return new Vector2(x, y);
    }
}
