using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {

    public float windAngle = 0;
    public float windStrength = 4;
    public float FullTimeToNextStrength = 2;
    float timeToNextStrength;


    public float FullTimeToNextAngle = 0.5f;
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
        SetWindAngle();

        //print(windAngle);

    }


    void SetWindAngle()
    {

        if (timeToNextAngle > 0)
        {
            timeToNextAngle -= Time.deltaTime;

        }
        else
        {


          newAngle = windAngle + Random.Range(-20, 20);
            if (true)
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
            if(windAngle < newAngle)
            {
                windAngle += 10 * Time.deltaTime;
            }
            else if(windAngle > newAngle)
            {
                windAngle += 10 * Time.deltaTime;
            }

            if (Mathf.Abs(windAngle - newAngle) < 1)
            {
                windAngle = newAngle;
                ChangeAngle = false;
                timeToNextAngle = FullTimeToNextAngle;
                if(windAngle > 360)
                {
                    windAngle -= 360;
                }

                if(windAngle < 0)
                {
                    windAngle += 360;
                }
            }



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
            // windStrength = 5;


            timeToNextStrength = FullTimeToNextStrength;

        }
    }
	}

