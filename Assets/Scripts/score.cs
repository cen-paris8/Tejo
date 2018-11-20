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
        if ( total > 3 )
        {
            total = 3;
        }
        // Print All Red (Pair)
        for (var i = 2; i <= 6; i = i +2)
        {
            etatScore[i].active = true;
        }
        // Impair Green Pair Red
        if (total > 0)
        {
            for (var i = 1; i <= total * 2; i++)
            {
                if (i % 2 != 0)
                {
                    etatScore[i].active = true;
                }
            }
        } else
        {
            gameOver = GetComponent<SceneStart>();
            gameOver.ChangeScene("gameover");
            //gameOver.ChangeScene("menu");
        }
    }
}
