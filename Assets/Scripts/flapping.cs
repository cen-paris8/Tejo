using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// To make the left wing flap:
public class flapping : MonoBehaviour 
{

    private float clock;
    private double flapping_frequency = 0.4;
    private double instantN = 0.5;
    private double instantN1 = 0.6;
    private int rotationValue = -40;
    public bool right = true;

    // Use this for initialization
    void Start () 
    {
        if (right)
        {
            rotationValue = -rotationValue;
        }	
	}
	
	// Update is called once per frame
	void Update () {
    
        clock = Time.time;
        
        if ((clock > instantN) && (clock < instantN1)) // The wing rotates during 0.1 sec
        {

            transform.Rotate(0, rotationValue, 0); 

            rotationValue = -rotationValue; // The next rotation will occur in the opposite way

            instantN += flapping_frequency;
            instantN1 += flapping_frequency;

        }


}
}
