using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCastel : MonoBehaviour {

    public castel[] etatCastel;

    /// <summary>
    /// function to change renderer when castel hit
    /// </summary>
    public void manageCastels()
    {
        for (var i = 0; i < etatCastel.Length; i++)
        {
            etatCastel[i] = GetComponent<castel>();

            if (etatCastel[i].isUp == true)
            {
                etatCastel[i].isUp = false;
                etatCastel[i+1] = transform.GetChild(0).GetComponent<castel>();
                etatCastel[i + 1].isUp = true;
            }
            if (i >= 3)
            {
                // Go To Game Over
                GameObject.Find("Main Camera").GetComponent<SceneStart>().ChangeScene("gameover");
            }
        }
    }
}
