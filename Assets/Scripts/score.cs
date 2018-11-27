using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    //public life[] etatScore;
    public int total;
    private SceneStart gameOver;
    public Transform castel;


    public void calculateScore(int point)
    {
        
        total = (int) transform.GetChild(0).GetChild(0).GetComponent<Slider>().value + point;
        print("score " + total);
        // To do prog. bar
        transform.GetChild(0).GetChild(0).GetComponent<Slider>().value = total;

        if ((total % 2) == 0 && point == -1)
        {
            //changeCastel
            castel.GetComponent<changeCastel>().manageCastels();
        }
    }
}
