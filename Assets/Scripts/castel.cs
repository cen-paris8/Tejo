using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castel : MonoBehaviour {

    public bool isUp = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isUp == true)
        {
            MeshRenderer m = GetComponent<MeshRenderer>();
            m.enabled = true;
        }
    }
}
