using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer2 : MonoBehaviour
{
    public float speed;
    public float thrustForce;
    Rigidbody2D player;

    public GameObject bullet;
    Transform firePosition;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        firePosition = transform.FindChild("FirePoint");

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(bullet, firePosition.transform.position, firePosition.transform.rotation);
            //GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Character Goes UP
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // move char up
            player.AddForce(transform.up * thrustForce);
        }
        // Character goes left
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.angularVelocity = speed;
        }
        // Character Goes Down
        else if (Input.GetKey(KeyCode.S))
        {

        }
        // Character Goes Right
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            player.angularVelocity = -speed;
        }
        else
        {
            player.angularVelocity = 0f;
        }
    }
}
