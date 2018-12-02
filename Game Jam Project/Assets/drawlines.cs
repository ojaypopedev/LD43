using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawlines : MonoBehaviour {



    public PolygonCollider2D poly;

    public GameObject rendererObject;

    GameObject[] renderers;

    public GameObject parent;

	void Start () {

       
        renderers = new GameObject[poly.pathCount];

        for (int i = 0; i < poly.pathCount; i++)
        {
           

            Vector3[] pos = new Vector3[poly.GetPath(i).Length];
            for (int j = 0; j < poly.GetPath(i).Length; j++)
            {
                pos[j] = poly.GetPath(i)[j];

            }
            renderers[i] = Instantiate(rendererObject, parent.transform);
            renderers[i].GetComponent<LineRenderer>().positionCount = pos.Length - 1;

            renderers[i].GetComponent<LineRenderer>().SetPositions(pos);
            // renderers[i] = gameObject.AddComponent<LineRenderer>();
            //  renderers[i].SetPositions(pos);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
       


	}
}
