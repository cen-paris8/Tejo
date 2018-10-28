using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour {

    public float boundHeightMin = 3.0f;
    public float boundHeightMax = 7.0f;
    public float boundRightMin = -2.0f;
    public float boundRightMax = 7.0f;
    public float boundLeftMin = -5.0f;
    public float boundLeftMax = 8.0f;
    public int countBound = 0;
    public int countBoundinit = 0;
    public bool flagStop = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(5, 10, -20);
            flagStop = false;
            countBound = 0;
            countBoundinit = 0;
            print("S 5, 20, -20");
        }
        if (countBoundinit >= 10 && countBoundinit < 100 && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(2, 15, 20);
            print("countBoundinit 2,15,20");
            countBoundinit = 100;

        }
        if (countBound % 200 == 0 && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(5, 15, -20);
            countBound++;
            print("Bong 5, 15 -20");
        }
        if (countBound % 45 == 0 && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-2, 10, 20);
            countBound++;
            print("Bing -2,10,20");
        }
        if (countBound > 1000)
        {
            print("go down");
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            countBound = 0;
            countBoundinit = 0;
            flagStop = true;
        }
        
        if (transform.position.y <= boundHeightMin && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 20, 0);
            countBound++;
            countBoundinit++;
            print("MinHeight + 20");
        }
        
        if (transform.position.y > boundHeightMax && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, -10, 3);
            print("MaxHeight + -20, 3");
        }
        if (transform.position.x <= boundRightMin && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(3, 1, 0);
            countBound++;
        }
        if (transform.position.x > boundRightMax && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-5, 0, 0);
            countBound++;
        }
        if (transform.position.z <= boundLeftMin && flagStop == false)
        {
            // gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            // gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().AddForce(0, 5, 20);
            print("LeftMin + (5, 10");
        }
        if (transform.position.z > boundLeftMax && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 5, -20);
            print("LeftMax + 5, -10");
        }
        

    }
}
