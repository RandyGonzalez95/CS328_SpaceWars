// Space Wars Replica Game
// CS 328
// "MoveBullet.cs"
// Randy Gonzalez 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{

    public float speed = 15f;

	// Use this for initialization
	void Start ()
    {   
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().AddForce(-transform.right * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "blackhole")
        {
            Destroy(this.gameObject);
        }
    }
}
