using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour {


    [Range(-20,20)]
    public float directionChange;

    public GameObject manager;
    public GameObject sail;

    float windImpact = 1;


    public float crewHelp = 1;


    float sailChange = 5;

    public float weightAffect = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float speed = weightAffect*manager.GetComponent<Wind>().windStrength;
        float angle = transform.rotation.eulerAngles.z;


        MoveTowardsRotation(angle , windImpact * Mathf.Sqrt(speed)* Time.deltaTime, Mathf.Sqrt(Mathf.Sqrt(speed))*directionChange*Time.deltaTime);
        input();

        // print(speed);



        //auto
        float SailAngle = sail.transform.rotation.eulerAngles.z;
        //SailAngle = manager.GetComponent<Wind>().windAngle - 90;

        //sail.transform.rotation = Quaternion.Euler(0, 0, SailAngle);

        //if (sail.transform.localRotation.eulerAngles.z < 20)
        //{
        //    sail.transform.localRotation = Quaternion.Euler(0, 0, 20);
        //}

        //else if (sail.transform.localRotation.eulerAngles.z > 160)
        //{
        //    sail.transform.localRotation = Quaternion.Euler(0, 0, 160);
        //}



        //manual
        sail.transform.Rotate(0, 0, sailChange);




        if (sail.transform.localRotation.eulerAngles.z < 20)
        {
            sail.transform.localRotation = Quaternion.Euler(0, 0, 20);
        }

        else if (sail.transform.localRotation.eulerAngles.z > 160)
        {
            sail.transform.localRotation = Quaternion.Euler(0, 0, 160);
        }


       

        float windAngle = manager.GetComponent<Wind>().windAngle;
        float Efficiency = 1 - Mathf.Abs((Mathf.Abs(sail.transform.rotation.eulerAngles.z - manager.GetComponent<Wind>().windAngle)-90)/90);

        //float direction = (SailAngle + windAngle) / 2;

        float lowestAngle = angle - 90;
        float highestAngle = angle + 90;






        //print("Sail Angle = " + sail.transform.rotation.eulerAngles.z);
        //print("Wind Angle = " + manager.GetComponent<Wind>().windAngle);

        //print("Efficiency = " + Efficiency);
        //windImpact = Efficiency;

        //print(Efficiency);


        //print("Difference = " + Mathf.Abs(SailAngle-manager.GetComponent<Wind>().windAngle));


       



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


    void input()
    {

       

        if (Input.GetKey(KeyCode.A))
        {
            directionChange = -5*crewHelp;
        }
        else if (Input.GetKey(KeyCode.D))
        {

            directionChange = 5*crewHelp;
        }
        else
        {
            directionChange = 0;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            sailChange = 2;
        }

        else if (Input.GetKey(KeyCode.E))
        {
            sailChange = -2;
        }
        else
        {
            sailChange = 0;
        }
    }
}
