using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBallPlayer : MonoBehaviour {

    public float direction;
    // Use this for initialization
    void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        MoveTowardsRotation(direction, 10*Time.deltaTime, 0);
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
        float x = Mathf.Cos(angle * Mathf.Deg2Rad);
        float y = Mathf.Sin(angle * Mathf.Deg2Rad);
        return new Vector2(x, y);
    }
}
