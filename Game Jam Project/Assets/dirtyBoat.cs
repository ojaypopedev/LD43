using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirtyBoat : MonoBehaviour {

    public int dirtCount = 0;

    float dirtRate = 10;

    float timer = 10;


    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            dirtCount += Random.Range(1, 3);
            timer = dirtRate;
        }
    }



}

