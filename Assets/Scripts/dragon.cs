using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour {

    private float boundLeftMin = 1f;
    private float boundLeftMax = 8f;
    private float boundHeightMin = 2.5f;
    private float boundHeightMax = 7f;
    private float boundRightMin = -11f;
    private float boundRightMax = 3f;
    private bool inGo = false; // le dragon est en chemin à true
    private float speed = 0.2f;
    private Vector3 newDestination;

    public Transform colliderFire;
    private Transform newColliderFire;


    // Update is called once per frame
    void Update()
    {
        if (!inGo)
        {
            NewDest();
        }
        else
        {
            if (Vector3.Distance(transform.position, newDestination) > 1.5f)
            {
                Vector3 direction = (newDestination - transform.position);
                direction = direction.normalized;
                transform.position += direction * speed;
            }
            else
            {
                inGo = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            newColliderFire = Instantiate(colliderFire); 
            Vector3 dragonMouth = new Vector3(0.1f, 2, -1);
            newColliderFire.position = GetComponent<Transform>().position + dragonMouth;
            newColliderFire.SetParent(transform);
            newColliderFire.GetComponent<shoot>().manageShoot();
        }
    }
    /// <summary>
    /// fonction calculant la nouvelle destination
    /// </summary>
     void NewDest()
    {
        newDestination = new Vector3(Random.Range(boundLeftMin, boundLeftMax), Random.Range(boundHeightMin, boundHeightMax), Random.Range(boundRightMin, boundRightMax));
        inGo = true;
    }
}
