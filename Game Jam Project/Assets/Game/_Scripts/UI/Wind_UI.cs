using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wind_UI : MonoBehaviour {

    public Text text;

    public GameObject manager;


    public GameObject pointer;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        pointer.transform.rotation = Quaternion.Euler(0, 0, manager.GetComponent<Wind>().windAngle);

        text.text = manager.GetComponent<Wind>().windStrength.ToString();
	}
}
