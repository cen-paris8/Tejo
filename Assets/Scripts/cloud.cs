using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour {

    private Vector3 direction;
    private float speed = 0.01f;
    public bool isWindy = false;
    private float frequency = 0;
    private Vector3 wind;

    // Use this for initialization
    void Start () {
        wind = new Vector3(0, 0, Random.Range(0, 3));
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - frequency > 0)
        {
            isWindy = true;
        }
        if (isWindy)
        {
            wind = -wind;
            frequency = Time.time + 3;
            isWindy = false;
        }
        direction = transform.position + wind;
        direction = direction.normalized;
        transform.position += wind * speed;
    }

}
