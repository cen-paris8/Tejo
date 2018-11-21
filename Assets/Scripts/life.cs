using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour {

    public bool active = false;
	
	// Update is called once per frame
	void Update () {
        if (active == true)
        {
            MeshRenderer m = GetComponent<MeshRenderer>();
            m.enabled = true;
        }
		
	}
}
