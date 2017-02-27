﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if asteroid collides with the black hole destroy it
        if (collision.collider.tag == "blackhole")
        {
            Destroy(this.gameObject);
        }
    }
}
