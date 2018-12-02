using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffScreen : MonoBehaviour {

    public bool on;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Animator>().SetBool("ON", on);
	}
}
