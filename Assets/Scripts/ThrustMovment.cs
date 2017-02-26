using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustMovment : MonoBehaviour
{
    public float speed;
    public float thrustForce;
    Rigidbody2D player;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Rigidbody2D>();       

	}
	
	// Update is called once per frame
	void Update ()
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
}
