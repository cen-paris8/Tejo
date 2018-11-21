using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {

    ParticleSystem myfireball;
    public bool explose = false;
    private bool formerExpose = false;
    public float explosionTime =1;
    private float startExplosion;

	// Use this for initialization
	void Start () {
        myfireball = GetComponent<ParticleSystem>();	
	}
	
	// Update is called once per frame
	void Update () {
        if(explose){
            print("explose");
            //var main = myfireball.main;
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
            myfireball.startSpeed = 10;
            if(!formerExpose){
                startExplosion = Time.time;
            }
            
            // castels change
            // GameObject.Find("CastelsCollider").GetComponent<changeCastel>().manageCastels();

            // Do not destroy here because init is done on colliderFire
            if (Time.time - startExplosion  > explosionTime){
                print("destroy");
                GetComponentInParent<shoot>().destroyFireball(); //destroyFireball
            }

        }
        formerExpose = explose;
	}
}
