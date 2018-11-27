using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arms : MonoBehaviour {

    void OnCollisionEnter(Collision maCollision)
    {
        print("collision avec : " + maCollision.gameObject.name);
        if (maCollision.gameObject.name == "FireCollider(Clone)")
        {
            print("touché");
            // fireBall explose
            //gameObject.GetComponent<Rigidbody>().AddForce(-1000, 0, 0);
            maCollision.transform.GetChild(0).GetComponent<fireball>().explose = true;
            // To Do Score +1
            GameObject.Find("Score").GetComponent<score>().calculateScore(+1);

        }

    }
}
