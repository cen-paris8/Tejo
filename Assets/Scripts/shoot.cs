using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    // To use fireball explose on castel
    private fireball newFireball;
    // To change castel version on explose
    private changeCastel newCastels;
    // TO change score on explose
    private score newScore;
    AudioSource source;
    // Use to define fireball direction
    public Transform castel;
    Vector3 castelPosition;
    // Use to define fireball speed
    float speed =  4;// 10; //
    float startTime;
    public ConstantForce forceBallDirection;


    // Use this for initialization
    void Start () {
        startTime = Time.time;
    }

    // Use this for initialization
    void Update()
    {
    }


    /// <summary>
    /// function manage shoot direction
    /// </summary>
    public void manageShoot()
    {
        // Patch if we can not use prefeb then first fireball stay on the scene.
        if (transform.position.z < -15)
        {
            return;
        }
        // To wait 2s before shoot
        if (Time.time - startTime > 3)
        {
            // Define fireball direction
            Vector3 direction = (castel.position - transform.position);
            direction = direction.normalized;
            forceBallDirection.force = direction * speed;
            //transform.position += direction * speed;
            //GetComponent<Rigidbody>().velocity = direction * speed;
            transform.SetParent(null);
            Destroy(gameObject, 10);

        }

    }
    /// <summary>
    /// function manage fireball collision on castel
    /// </summary>
    void OnCollisionEnter(Collision maCollision)
    {
        print("maCollision.gameObject.name : " + maCollision.gameObject.name);
        if (maCollision.gameObject.name == "CastelCollider")
        {
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
            transform.GetChild(0).GetComponent<fireball>().explosionTime = 2;
            transform.GetChild(0).GetComponent<fireball>().explose = true;
            // To Do Score -1
            GameObject.Find("Score").GetComponent<score>().calculateScore(-1);

        }
        if (maCollision.gameObject.name == "armCollider")
        {
            print("touché arm");
            // transform.position = maCollision.transform.position;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.GetChild(0).GetComponent<fireball>().explosionTime = 0.5f;
            transform.GetChild(0).GetComponent<fireball>().explose = true;
            maCollision.rigidbody.velocity = Vector3.zero;

        }
        if (maCollision.gameObject.name == "Knights")
        {
            print("touché Knight");
            // transform.position = maCollision.transform.position;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.GetChild(0).GetComponent<fireball>().explosionTime = 0.5f;
            transform.GetChild(0).GetComponent<fireball>().explose = true;
            maCollision.rigidbody.velocity = Vector3.zero;

        }
        if (maCollision.gameObject.name == "plane")
        {
            destroyFireball();
        }

        }
    /// <summary>
    /// function destroy need to be use by other components
    /// </summary>
    public void destroyFireball()
    {
            Destroy(gameObject);

    }
}