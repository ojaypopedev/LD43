using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;
    public Vector3 Offset;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;
        Vector3 target = new Vector3(player.transform.position.x, player.transform.position.y, pos.z) + Offset;
        pos = Vector3.Lerp(pos, target, Time.deltaTime);
        transform.position = pos;

        float size = GetComponent<Camera>().orthographicSize;
        Offset = new Vector2((size / 7.5f)*5,(size / 7.5f) *-1);

        GetComponent<Camera>().orthographicSize += Input.GetAxisRaw("Mouse ScrollWheel");
        
	}
}
