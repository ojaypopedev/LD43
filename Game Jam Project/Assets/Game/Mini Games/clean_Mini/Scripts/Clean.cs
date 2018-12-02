using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clean : MonoBehaviour {
    public bool Cleaning = false;
    public float Water;
    public Text WaterText;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Water > 30f)
        {
            Water = 30f;
        }
        if (Water < 0f)
        {
            Water = 0f;
        }
        WaterText.text = ("Water Level = " + Water);
        Mathf.RoundToInt(Water);
       // print("Water Left" + Water);
        if (Input.GetMouseButtonDown(0) && Water > 0)
        {
            Cleaning = true;

        }

        if (Input.GetMouseButtonUp(0))
        {
            Cleaning = false;
        }
        if (Cleaning == true)
        {
            Water -= 0.1f;
        }



    }
  
    
        
    

}
