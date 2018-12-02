using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weight_UI : MonoBehaviour {

    public Boat_Weight weight;
    public damagedShip damage;
    public cannon_ball_count cannon;
    public dirtyBoat dirt;
    public Food foodWeight;
    public Text weightText;
    public Text crewText;
    public Text lootText;


    public Text rawText;
    public Text cookedText;
    public Text foodText;
  

    public Text maxText;


    public Text brokenText;

    public Text cannonText;


    public Text dirtText;










    void Start () {
        foodWeight = weight.gameObject.GetComponent<Food>();
        damage = weight.gameObject.GetComponent<damagedShip>();
        cannon = weight.gameObject.GetComponent<cannon_ball_count>();
        dirt = weight.gameObject.GetComponent<dirtyBoat>();

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

        brokenText.text = damage.parts.ToString();


        cannonText.text = cannon.count.ToString();

        dirtText.text = dirt.dirtCount.ToString();
   }
}