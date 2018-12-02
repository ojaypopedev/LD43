using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtRemove : MonoBehaviour {
  public  SpriteRenderer Colour;
	// Use this for initialization
	void Start () {
        Colour = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Colour.color.a < 0)
        {
            GameObject.Find("Ship Decking").GetComponent<DirtManager>().DirtToClean -= 1;
            GameObject.Find("Ship Decking").GetComponent<DirtManager>().Dirtiness-= 1;
            Destroy(gameObject);

        }
    }

     void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Mop")
        {
            
            if (GameObject.FindGameObjectWithTag("Mop").GetComponent<Clean>().Cleaning == true)
            {
              
                Colour.color -= new Color(0, 0, 0,Time.deltaTime);
                

            }
        }

       

    }


    
    
}
