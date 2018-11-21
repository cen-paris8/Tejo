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
    float speed =  3;// 10; //
    // Use to define level game
    private int level = 1;
    float startTime;
    Vector3 sup;


    // Use this for initialization
    void Start () {
        startTime = Time.time;
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
            print("castelPosition : " + castelPosition);
            sup = new Vector3(0, -1, -1);
            Vector3 direction = (castel.position - transform.position + sup); // + sup
            direction = direction.normalized;
            GetComponent<ConstantForce>().force = direction * speed;
            //transform.position += direction * speed;
            //GetComponent<Rigidbody>().velocity = direction * speed;
            transform.SetParent(null);

        }

        // destroy if firewall get out of the scene
        if (transform.position.x > 15)
        {
            Destroy(gameObject);
        }
    }
    /// <summary>
    /// function manage fireball collision on castel
    /// </summary>
    void OnCollisionEnter(Collision maCollision)
    {
        if (maCollision.gameObject.name == "CastelCollider")
        {
            // fireBall explose
            transform.GetChild(0).GetComponent<fireball>().explose = true;

            // To Do Score -1
            // GameObject.Find("Score").GetComponent<score>().claculateScore(-1);

            // at least
            // Destroy(gameObject);
            // Destroy(maCollision.gameObject);


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
        print("destroy");
            Destroy(gameObject);

    }
}