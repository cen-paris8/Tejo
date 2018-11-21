using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour {

    //private fireball newFireball;
    GameObject currentFireball;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Moving knight to the left
        if (Input.GetKey(KeyCode.LeftArrow)){

            transform.Translate(0.2f, 0, 0);

        }


        // Moving knight to the rignt
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(-0.2f, 0, 0);

        }


        // Moving knight to background
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.x > 8)
        {

            transform.Translate(0, 0, -0.2f);

        }


        // Moving knight to foreground
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.x < 11)
        {

            transform.Translate(0, 0, 0.2f);

        }


        // Jumping : Error
        if (Input.GetKey(KeyCode.J)) //RightCommand
        {
            print("Key J");
            //transform.Translate(0, 0.4f, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(1f, 100f, 1f);

        }

	}

    void OnCollisionEnter(Collision maCollision)
    {
        print("knight maCollision.gameObject.name : " + maCollision.gameObject.name);
        if (maCollision.gameObject.name == "FireCollider(Clone)")
        {
            print("j'y suis ");
            // fireBall explose
            gameObject.GetComponent<Rigidbody>().AddForce(-1000, 0, 0);
            GameObject.Find("FireCollider(Clone)").transform.GetChild(0).GetComponent<fireball>().explose = true;
            //currentFireball = GameObject.Find("FireCollider(Clone)");
            //currentFireball.transform.GetChild(0).GetComponent<fireball>().explose = true;
            // maCollision.transform.GetChild(0).GetComponent<fireball>().explose = true;
            // at least
            Destroy(GameObject.Find("FireCollider(Clone)"));
            Destroy(maCollision.gameObject);


        }

    }
}
