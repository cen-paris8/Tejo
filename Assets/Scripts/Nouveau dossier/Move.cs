using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

        // Moving knight to the left
        if (Input.GetKey(KeyCode.LeftArrow)){

            transform.Translate(-0.5f , 0, 0);

        }


        // Moving knight to the rignt
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(0.5f , 0, 0);

        }


        // Moving knight to background
        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.Translate(0, 0, 0.5f);

        }


        // Moving knight to foreground
        if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(0, 0, -0.5f);

        }


        // Jumping :
        if (Input.GetKey(KeyCode.RightCommand))
        {

            transform.Translate(0, 0.4f, 0);

        }


    }
}
