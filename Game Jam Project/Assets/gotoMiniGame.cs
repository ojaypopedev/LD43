using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotoMiniGame : MonoBehaviour {

    public GameObject noneGame;
    public GameObject cookGame;
    public GameObject cleanGame;
    public GameObject cannonBottom;
    public GameObject cannonTop;

  
    public string gameActive = "cook"; //cook clean anchor repair cannon//

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameActive = "none";
        }


		if(gameActive == "cook")
        {

            setCamGame(cookGame);
                
               
        }

        if(gameActive == "clean")
        {
            setCamGame(cleanGame);
        }


        if (gameActive == "cannonbottom")
        {
            setCamGame(cannonBottom);
        }

        if (gameActive == "cannontop")
        {
            setCamGame(cannonTop);
        }

        if (gameActive == "none")
        {
            setCamGame(noneGame);
        }



    }



    void setCamGame(GameObject game)
    {
        Vector3 newPos = new Vector3(game.transform.position.x, game.transform.position.y, -10);
        transform.position = newPos;
    }
}
