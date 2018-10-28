using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouleDeFeu : MonoBehaviour {

    public Transform fire;
    public Transform dragon;
    public Transform burst;
    bool flagFire = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((dragon.position.y > 3 && dragon.position.y < 3.009) && flagFire == true)
        {
            flagFire = false;
            shootFire();
        }
        if ((dragon.position.y > 4 && dragon.position.y < 4.009) && flagFire == true)
        {
            flagFire = false;
            shootFire();
        }

    }
    void shootFire()
    {
        
        print("Fire");
        Transform newFire = Instantiate(fire);
        newFire.position = dragon.position;
        if (newFire.position.z > 2)
        {
            newFire.GetComponent<Rigidbody>().AddForce(500, 20, -100);
        } else if (newFire.position.z < -2)
        {
            newFire.GetComponent<Rigidbody>().AddForce(500, 20, 100);
        } else
        {
            newFire.GetComponent<Rigidbody>().AddForce(500, 20, 0);
        }

            StartCoroutine(Example());
        
    }
    IEnumerator Example()
    {
        print("flagFire : " + flagFire);
        print("T1----------------------------------------------------------- " + Time.time);
        yield return new WaitForSeconds(100);
        print("T2----------------------------------------------------------- " + Time.time);
        flagFire = true;
        print("flagFire : " + flagFire);
    }
    void OnCollisionEnter(Collision maCollision)
    {

        if (maCollision.gameObject.name == "castel")
        {
            print("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Burst");
        }

    }
}
