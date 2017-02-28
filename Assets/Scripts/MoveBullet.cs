// Space Wars Replica Game
// CS 328
// "MoveBullet.cs"
// Randy Gonzalez 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public bool flag; // this specifies wheter we shoot left or right
    public float speed;

	// Use this for initialization
	void Start ()
    {   
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Apply force to move bullet
        if(flag)
        {
            GetComponent<Rigidbody2D>().AddForce(-transform.right * speed);
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if bullet goes into black hole, destroy it
        if (collision.collider.tag == "blackhole")
        {
            Destroy(this.gameObject);
        }

        // Destroy asteriod if we hit it with bullet
        if(collision.collider.tag == "asteroid")
        {
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);
        }
    }
}
