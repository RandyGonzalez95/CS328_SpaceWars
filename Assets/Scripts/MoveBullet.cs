// Space Wars Replica Game
// CS 328
// "MoveBullet.cs"
// Randy Gonzalez 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{

    public Vector2 speed;
    Rigidbody2D bullet;


	// Use this for initialization
	void Start ()
    {
        bullet = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        bullet.velocity = speed;
	}
}
