using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {

    ParticleSystem myfireball;
    public bool explose = false;
    private bool formerExpose = false;
    public float explosionTime = 0;
    private float startExplosion;

	// Use this for initialization
	void Start () {
        myfireball = GetComponent<ParticleSystem>();	
	}
	
	// Update is called once per frame
	void Update () {
        if(explose){
            // AudioSource source = GetComponent<AudioSource>();
            //source.Play();
            myfireball.startSpeed = 10;
            if(!formerExpose){
                startExplosion = Time.time;
            }
            
            // castels change
            // GameObject.Find("CastelsCollider").GetComponent<changeCastel>().manageCastels();

            // Destroy Fireball once explosion done
            if (Time.time - startExplosion  > explosionTime){
                GetComponentInParent<shoot>().destroyFireball(); 
            }

        }
        formerExpose = explose;
	}
}
