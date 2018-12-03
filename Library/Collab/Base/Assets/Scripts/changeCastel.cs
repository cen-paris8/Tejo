using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCastel : MonoBehaviour {

    public castel[] etatCastel;
    private castel CastelNum;
    private castel CastelNext;

    /// <summary>
    /// function to change renderer when castel hit
    /// </summary>
    public void manageCastels()
    {
        print("changeCastel");
        for (var i = 0; i < etatCastel.Length; i++)
        {
            CastelNum = etatCastel[i].GetComponent<castel>();

            if (CastelNum.isUp() == true)
            {
                if (i >= 2)
                {
                    // Go To Game Over
                    GameObject.Find("Main Camera").GetComponent<SceneStart>().ChangeScene("gameover");
                    return;
                } 
                CastelNum.changeRenderer(false);
                CastelNext = etatCastel[i + 1].GetComponent<castel>();
                CastelNext.changeRenderer(true);
                return;
                
                
            }
            
        }
    }
}
