using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

    public life[] etatScore;
    public int total = 3;
    private SceneStart gameOver;


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    void calculateScore(int point)
    {
        total = total + point;

        // To do prog. bar
        //GameObject.Find("Bar de prog ").GetComponent<Component du Bar de prog>().value = £ de total;
    }
}
