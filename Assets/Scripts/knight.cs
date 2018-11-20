using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour {

    private fireball newFireball;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Moving knight to the left
        if (Input.GetKey(KeyCode.LeftArrow)){

            transform.Translate(0.5f, 0, 0);

        }


        // Moving knight to the rignt
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(-0.5f, 0, 0);

        }


        // Moving knight to background
        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.Translate(0, 0, -0.5f);

        }


        // Moving knight to foreground
        if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(0, 0, 0.5f);

        }


        // Jumping : Error
        if (Input.GetKey(KeyCode.J)) //RightCommand
        {
            print("Key J");
            //transform.Translate(0, 0.4f, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(1f, 10f, 1f);

        }

	}

    void OnCollisionEnter(Collision maCollision)
    {
        print("maCollision.gameObject.name : " + maCollision.gameObject.name);
        if (maCollision.gameObject.name == "FireCollider")
        {
            print("Crasshhhhh -----");
            // fireBall explose
            newFireball = GetComponent<fireball>();
            newFireball.explose = true;
            // Knight win score +1

        }
        //Destroy(gameObject);

    }
}
