using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour {

    public List<GameObject> lifePoints;
    int LifeLeft;

	void Start () {
        LifeLeft = lifePoints.Count;
	}
	
	// Update is called once per frame
	void Update () {
		if(LifeLeft == 0)
        {
            Destroy(gameObject);
        }
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "cannonball_player")

        LifeLeft -= 1;
        Destroy(lifePoints[LifeLeft]);
    }
}
