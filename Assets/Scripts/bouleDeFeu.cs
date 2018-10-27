using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouleDeFeu : MonoBehaviour {

    public Transform fire;
    public Transform dragon;
    public Transform burst;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((dragon.position.y > 3 && dragon.position.y < 3.009) || (dragon.position.y > 4 && dragon.position.y < 4.009))
        {
            print("Fire");
            Transform newFire = Instantiate(fire);
            newFire.position = dragon.position;
            newFire.GetComponent<Rigidbody>().AddForce(1500, 20, 0);
    
        }

    }
    void OnCollisionEnter(Collision maCollision)
    {

        if (maCollision.gameObject.name == "castel")
        {
            print("Burst");
        }

    }
}
