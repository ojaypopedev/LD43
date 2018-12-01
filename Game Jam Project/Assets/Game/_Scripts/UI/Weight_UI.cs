using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weight_UI : MonoBehaviour {

    public Boat_Weight weight;
    public Food foodWeight;
    public Text weightText;
    public Text crewText;
    public Text lootText;


    public Text rawText;
    public Text cookedText;
    public Text foodText;
  

    public Text maxText;






    void Start () {
        foodWeight = weight.gameObject.GetComponent<Food>();
	}
	
	// Update is called once per frame
	void Update () {
        weightText.text = weight.boatWeight.ToString();
        crewText.text = weight.crewWeight.ToString();
        lootText.text = weight.lootWeight.ToString();
        maxText.text = weight.maxSafeWeight.ToString();


        rawText.text = foodWeight.rawFood.ToString();
        cookedText.text = foodWeight.cookedFood.ToString();
        foodText.text = foodWeight.foodWeight.ToString();



    }
}
