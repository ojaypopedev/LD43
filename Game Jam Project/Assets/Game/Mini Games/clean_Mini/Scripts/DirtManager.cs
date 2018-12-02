using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirtManager : MonoBehaviour {
    public GameObject Dirt;
    public float SpawnX;
    public float SpawnY;
    public float spawnDelay;
    public float SpawnTime;
   public float Dirtiness;
   public Text DirtText;
    public Text TimeText;
    public float DirtToClean;
    public bool DeckClean = false;


    public GameObject parent;
	// Use this for initialization
	void Start () {
        SpawnTime = spawnDelay;
        DirtToClean = (Random.Range(25, 30));

    }
	
	// Update is called once per frame
	void Update () {
        spawnDelay -= Time.deltaTime;
        DirtText.text = ("Dirt on Screen = " + Dirtiness);
        TimeText.text = ("Dirt Left = " + DirtToClean);
        if (DirtToClean < 0)
        {
            DirtToClean = 0;
            DeckClean = true;
            
        }
        if (SpawnTime < 1f)
        {
            SpawnTime = 1f;
        }
        if(spawnDelay <= 0&& DirtToClean>0)
        {
            SpawnX = Random.Range(-6, 6)+ transform.position.x;
            SpawnY = Random.Range(-6, 6)+transform.position.y;
            Instantiate(Dirt, new Vector3(SpawnX, SpawnY), Quaternion.identity, parent.transform);
            
           // Dirt.transform.localPosition = new Vector3(SpawnX, SpawnY);
            
            SpawnTime -= 0.4f;
            spawnDelay = SpawnTime;
            Dirtiness += 1; 

        }
      
	}
}
