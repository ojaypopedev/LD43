using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_Weight : MonoBehaviour {


    public float boatWeight;

    public float maxSafeWeight = 10;

    public float crewWeight;
    public float lootWeight;

    


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        findTotalWeight();
        crewWeight =findWeightOf("crew");
        lootWeight = findWeightOf("loot");

      
        

    }


    float findWeightOf(string name)
    {

        object_weight[] weights = GetComponentsInChildren<object_weight>();




        float totalWeight = 0;
        foreach (var item in weights)
        {
            if (item.gameObject.tag == name)
            {
                totalWeight += item.weight;
            }
            
        }

        

        return totalWeight;
    }

    void findTotalWeight()
    {
        boatWeight = 0;
        object_weight[] weights = GetComponentsInChildren<object_weight>();
        foreach (var item in weights)
        {
            boatWeight += item.weight;
        }

        boatWeight += GetComponent<Food>().foodWeight;

        if (boatWeight > maxSafeWeight)
        {
            float over = boatWeight - maxSafeWeight;
            over = maxSafeWeight / (maxSafeWeight + 2 * over);
            GetComponent<BoatController>().weightAffect = over;


        }
        else
        {
            GetComponent<BoatController>().weightAffect = 1;
        }
    }
}
