using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wings : MonoBehaviour {

    public Transform dragon;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 10f, 0);
            //transform.Rotate(0, -10f, 0);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(0, -10f, 0);
            //transform.Rotate(0, -10f, 0);
        }
    }
}
