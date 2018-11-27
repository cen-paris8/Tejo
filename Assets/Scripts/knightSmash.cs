using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightSmash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Smashing with the sword 
        if (Input.GetKeyDown(KeyCode.Space))
        {

            transform.Rotate(0, 0, 50); // Sword up
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {

            transform.Rotate(0, 0, -50); // Sword down again
        }
    }
}
