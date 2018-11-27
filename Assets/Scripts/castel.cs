using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castel : MonoBehaviour {

    private MeshRenderer m;

    public bool isUp()
    {
        m = GetComponent<MeshRenderer>();
        return m.enabled;
        
    }

    public void changeRenderer(bool flag)
    {
        m = GetComponent<MeshRenderer>();
        if (flag)
        {
            m.enabled = true;
        }
        else
        {
            m.enabled = false;
        }
    }

}
