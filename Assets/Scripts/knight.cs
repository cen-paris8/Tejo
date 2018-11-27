using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour {

    //private fireball newFireball;
    GameObject currentFireball;
	
	// Update is called once per frame
	void Update () {

        // Moving knight to the left
        if (Input.GetKey(KeyCode.LeftArrow)){

            transform.Translate(0, 0, -0.2f);

        }

        // Moving knight to the rignt
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(0, 0, 0.2f);

        }


        // Moving knight to background
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.x > 8)
        {

            transform.Translate(-0.2f, 0, 0);

        }


        // Moving knight to foreground
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.x < 11)
        {

            transform.Translate(0.2f, 0, 0);

        }


        // To Jump
        if (Input.GetKey(KeyCode.J)) //RightCommand
        {
            print("Key J");
            //transform.Translate(0, 0.4f, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(-50f, 500f, 0f);

        }

	}

   
}
