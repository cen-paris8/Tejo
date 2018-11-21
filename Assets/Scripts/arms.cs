using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arms : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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


        }

    }
}
