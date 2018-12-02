using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour {
    CircleCollider2D CD;

    public GameObject cannon;

   


    public Cannon cannonmini;

	// Use this for initialization
	void Start () {
        CD = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (CD.IsTouchingLayers(LayerMask.GetMask("CannonBall")))
        {
            cannon.GetComponent<spawnCannonBall>().fire(true);



            cannonmini.fired = false;

        }

    }
}
