using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class broken : MonoBehaviour {


    public bool fix = false;

    private void Update()
    {
        if (fix)
        {
            Destroy(gameObject);
        }
    }
}
