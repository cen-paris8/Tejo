using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    //public ParticleSystem myFireBall;
    private fireball newFireball;
    private changeCastel newCastels;
    private score newScore;
    AudioSource source;
    public Transform castel;
    float speed = 0.1f;
    // Define level game
    public int level = 1;


    // Use this for initialization
    void Start () {
		//myfireball = GetComponent<ParticleSystem>();	
	}

    void Update()
    {
        if (transform.position.z < -15)
        {
            return;
        }
        Vector3 direction = (castel.position - transform.position);
        direction = direction.normalized;
        //print("direction  " + direction);
        transform.position += direction * speed;
        //print("transform.position  " + transform.position);

        if (transform.position.x > 15)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision maCollision)
    {
        print("maCollision.gameObject.name : " + maCollision.gameObject.name);
        if (maCollision.gameObject.name == "CastelsCollider")
        {
            print("Crasshhhhh -----");
            // fireBall explose
            newFireball = GetComponent<fireball>();
            newFireball.explose = true;
            // castels change
            newCastels = GetComponent<changeCastel>();
            newCastels.isChangeCastel = true;
            // Score -1
            newScore = GetComponent<score>();
            newScore.total = newScore.total - 1;

        }
        //Destroy(gameObject);
        //isShoot = false;

    }

    /*
    void dragonShoot()
    {
        startShoot = Time.time;
        print("Fire");
        
        Transform newFire = Instantiate(colliderFire);
        print("newFire : " + newFire);
        //newFire.setActive(true);
        myFireBall = newFire.GetComponent<ParticleSystem>();
        newFire.position = dragon.position;
        Vector3 direction = newFire.position - burst.position;
        direction = direction.normalized;
        print("direction  " + direction);
        newFire.transform.position += direction * speed;
        print("transform.position  " + transform.position);
        if (startShoot - Time.time > shootTime2)
        {
            print("Destroy(newFire)");
            Destroy(newFire);
        }

        //    StartCoroutine(Example());
        
        
    }

/*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision");
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }

    // Update is called once per frame
    void Update () {
        if ((dragon.position.y > 3 && dragon.position.y < 3.009) && flagFire == true)
        {
            flagFire = false;
            shootFire();
        }
        if ((dragon.position.y > 4 && dragon.position.y < 4.009) && flagFire == true)
        {
            flagFire = false;
            shootFire();
        }

    }
    void shootFire()
    {
        
        print("Fire");
        Transform newFire = Instantiate(fire);
        newFire.position = dragon.position;
        if (newFire.position.z > 2)
        {
            newFire.GetComponent<Rigidbody>().AddForce(500, 20, -100);
        } else if (newFire.position.z < -2)
        {
            newFire.GetComponent<Rigidbody>().AddForce(500, 20, 100);
        } else
        {
            newFire.GetComponent<Rigidbody>().AddForce(500, 20, 0);
        }

            StartCoroutine(Example());
        
    }
    IEnumerator Example()
    {
        
      //  print("flagFire : " + flagFire);
       // print("T1----------------------------------------------------------- " + Time.time);
        yield return new WaitForSeconds(100);
       // print("T2----------------------------------------------------------- " + Time.time);
        flagFire = true;
        //print("flagFire : " + flagFire);*/
    /*
    }
     
    void OnCollisionEnter(Collision maCollision)
    {

        if (maCollision.gameObject.name == "castel")
        {
            // audio SOurce
            // https://docs.unity3d.com/ScriptReference/AudioSource.html

            print("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Burst");
        }

    }
    */
}
