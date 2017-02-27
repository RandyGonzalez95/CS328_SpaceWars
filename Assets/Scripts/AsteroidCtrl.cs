using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCtrl : MonoBehaviour
{
    public float minTorque;
    public float maxTorque;
    public float minForce;
    public float maxForce;

	// Use this for initialization
	void Start ()
    {
        // Set Random range for force and torque
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
