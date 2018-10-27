using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour {

    public float boundHeightMin = 2.0f;
    public float boundHeightMax = 13.0f;
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
            gameObject.GetComponent<Rigidbody>().AddForce(10, 50, -2);
            flagStop = false;
            countBound = 0;
            countBoundinit = 0;
            print("S");
        }
        if (countBoundinit >= 10 && countBoundinit < 100 && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(2, 30, -20);
            print("countBoundinit");
            countBoundinit = 100;

        }
        if (countBound % 200 == 0 && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(5, 30, 3);
            countBound++;
            print("Bong");
        }
        if (countBound % 45 == 0 && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-2, 10, -5);
            countBound++;
            print("Bing");
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
            gameObject.GetComponent<Rigidbody>().AddForce(0, 50, 0);
            countBound++;
            countBoundinit++;
        }
        
        if (transform.position.y > boundHeightMax && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, -20, 3);
        }
        if (transform.position.x <= boundRightMin && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(3, 0, 0);
            countBound++;
        }
        if (transform.position.x > boundRightMax && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-5, 0, 0);
            countBound++;
        }
        if (transform.position.z <= boundLeftMin && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().AddForce(0, 5, 10);
        }
        if (transform.position.z > boundLeftMax && flagStop == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 5, -10);
        }
        

    }
}
