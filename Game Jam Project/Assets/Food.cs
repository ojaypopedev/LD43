 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    public float cookedFood;
    public float rawFood;
    public float foodWeight;
    

    public float weightperFood = 0.1f;


    public bool cookOne;

    void cookFood(int amount)
    {
        if(amount <= rawFood)
        {
            cookedFood += amount;
            rawFood -= amount;

        }
        
    }

    private void Update()
    {
        foodWeight = weightperFood * (cookedFood + rawFood);

        if (cookOne)
        {
            cookOne = false;
            cookFood(1);
        }
    }









}
