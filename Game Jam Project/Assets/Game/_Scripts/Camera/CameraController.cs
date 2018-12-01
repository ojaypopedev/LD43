using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;
        Vector3 target = new Vector3(player.transform.position.x, player.transform.position.y, pos.z);
        pos = Vector3.Lerp(pos, target, Time.deltaTime);
        transform.position = pos;




        GetComponent<Camera>().orthographicSize += Input.GetAxisRaw("Mouse ScrollWheel");
        
	}
}
