using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCastel : MonoBehaviour {

    public castel[] etatCastel;
    public bool isChangeCastel = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isChangeCastel == true)
        {
            for (var i=0; i < etatCastel.Length; i++)
            {

                if (etatCastel[i].isUp == true)
                {
                    etatCastel[i].isUp = false;
                    etatCastel[i+1].isUp = true;
                }
                if (i >= 3)
                {
                    // Go To Game Over
                }
            }
        }
	}
}
