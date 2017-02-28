using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustMovment : MonoBehaviour
{
    public float speed;
    public float thrustForce;
    Rigidbody2D player;
    public int health;

    public GameObject bullet;
    Transform firePosition;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Rigidbody2D>();
        firePosition = transform.FindChild("FirePoint");

	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, firePosition.transform.position, firePosition.transform.rotation);
            GetComponent<AudioSource>().Play();
        }
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        // Character Goes UP
        if (Input.GetKey(KeyCode.W))
        {
            // move char up
            player.AddForce(transform.up * thrustForce);
        }
        // Character goes left
        else if (Input.GetKey(KeyCode.A))
        {
            player.angularVelocity = speed;
        }
        // Character Goes Down
        else if (Input.GetKey(KeyCode.S))
        {
           
        }
        // Character Goes Right
        else if (Input.GetKey(KeyCode.D))
        {
            player.angularVelocity = -speed;
        }
        else
        {
            player.angularVelocity = 0f;
        }
    }

    private void OnCollisionEnter2D(Collider2D collision)
    {

    }
}
