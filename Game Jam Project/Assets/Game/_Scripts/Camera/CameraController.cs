using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;
    public Vector3 Offset;
    public GameObject UI;

    public float maxZoom = 15f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;
        Vector3 target = new Vector3(player.transform.position.x, player.transform.position.y, pos.z) + Offset;
        pos = Vector3.Lerp(pos, target, Time.deltaTime);
        transform.position = pos;

        float size = GetComponent<Camera>().orthographicSize;

        if (UI.GetComponent<OnOffScreen>().on)
        {
            Offset = new Vector2((size / 7.5f) * 5, (size / 7.5f) * -1);
        }
        else
        {
            Offset = Vector3.zero;
        }
       
        if(GetComponent<Camera>().orthographicSize >= 7.5f && GetComponent<Camera>().orthographicSize <= maxZoom)
        {

        GetComponent<Camera>().orthographicSize -= 10*Input.GetAxisRaw("Mouse ScrollWheel");
        }
        
        if(GetComponent<Camera>().orthographicSize < 7.5f)
        {
            GetComponent<Camera>().orthographicSize = 7.5f;
        }


        if (GetComponent<Camera>().orthographicSize > maxZoom)
        {
            GetComponent<Camera>().orthographicSize = maxZoom;
        }

    }
}
