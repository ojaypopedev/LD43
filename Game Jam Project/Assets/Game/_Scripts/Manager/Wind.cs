using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {

    public float windAngle = 0;
    public float windStrength = 4;
    public float FullTimeToNextStrength = 2;
    float timeToNextStrength;


    public float FullTimeToNextAngle = 2;
    float timeToNextAngle;
    public float minStrength = 1;
    public float maxStrength = 20;
    public float increment = 2;
    bool ChangeAngle;

    float newAngle;


	void Start () {
        timeToNextStrength = FullTimeToNextStrength;
        timeToNextAngle = FullTimeToNextAngle;
	}
	
	// Update is called once per frame
	void Update () {


        WindStrength();
        WindAngle();
       





    }


    void WindAngle()
    {

        if (timeToNextAngle > 0)
        {
            timeToNextAngle -= Time.deltaTime;

        }
        else
        {


          newAngle = windAngle + Random.Range(-20, 20);
            if (Random.Range(0, 2) > 1)
            {
                ChangeAngle = true;
            }
            else
            {
                timeToNextAngle = FullTimeToNextAngle;
            }

            

        }


        if (ChangeAngle)
        {
            if(WindAngle <)



        }

    }


    void WindStrength()
    {
        if (timeToNextStrength > 0)
        {
            timeToNextStrength -= Time.deltaTime;

        }
        else
        {

            windStrength += Mathf.Round(Random.Range(-increment, increment));

            if (windStrength > maxStrength)
            { windStrength = maxStrength; }

            if (windStrength < minStrength)
            { windStrength = minStrength; }


            timeToNextStrength = FullTimeToNextStrength;

        }
    }
	}

