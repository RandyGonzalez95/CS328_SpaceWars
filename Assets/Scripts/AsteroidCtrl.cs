using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCtrl : MonoBehaviour
{
    float minTorque = -100f;
    float maxTorque = 100f;
    float minForce = 20f;
    float maxForce = 40f;
	// Use this for initialization
	void Start ()
    {
        float magnitude = Random.Range(minForce, maxForce);
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        GetComponent<Rigidbody2D>().AddForce(magnitude * new Vector2(x,y));

        float torque = Random.Range(minTorque, maxTorque);
        GetComponent<Rigidbody2D>().AddTorque(torque);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
