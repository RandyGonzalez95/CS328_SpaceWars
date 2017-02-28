using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    
    public GameObject smallerAsteroid;
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

        if(collision.collider.tag == "gameobject" || collision.collider.tag == "asteroid")
        {
            Destroy(this.gameObject);

            // Create 4 smaller asteroids after destroying the first one
            Instantiate(smallerAsteroid, this.transform.position, Quaternion.identity);
            Instantiate(smallerAsteroid, this.transform.position, Quaternion.identity);
            Instantiate(smallerAsteroid, this.transform.position, Quaternion.identity);
            Instantiate(smallerAsteroid, this.transform.position, Quaternion.identity);
        }
    }
}
