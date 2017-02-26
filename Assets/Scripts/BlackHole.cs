using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float gravitationalForce = 5f;
    private Vector3 distanceFromCenter;

    GameObject gameobject;
	// Use this for initialization
	void Start ()
    {
        gameobject = GameObject.FindGameObjectWithTag("gameobject");
        distanceFromCenter = Vector3.zero;

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if(gameobject != null)
        {
            distanceFromCenter = (transform.position - gameobject.transform.position).normalized;
            gameobject.GetComponent<Rigidbody2D>().AddForce(distanceFromCenter * gravitationalForce);
        }      
       
    }
}
