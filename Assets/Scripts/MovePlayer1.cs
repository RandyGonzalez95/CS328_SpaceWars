// Space Wars Replica Game
// CS 328
// "MovePlayer1.cs"
// Randy Gonzalez 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer1 : MonoBehaviour
{
    // Player Speed
    public float speed = 1.5f;

    // Flares to fire
    public GameObject left;
    public GameObject right;
    private GameObject actualFlare;   

    // Delay fire variables 
    public float delayTime = 0.5f;
    private float counter = 0;

    Transform firePoint;

    // Use this for initialization
    void Start ()
    {
        // Defualt variables
        actualFlare = left;

        firePoint = transform.FindChild("FirePoint");
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Move the character sprite
        Move();

    }

    private void Move()
    {
        // Character Goes UP
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.up * speed * Time.deltaTime; 
        }
        // Character goes left
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
            this.transform.rotation = new Quaternion(0, 0f, 0, 1);
            actualFlare = left;
        }
        // Character Goes Down
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.down * speed * Time.deltaTime;        
        }
        // Character Goes Right
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
            this.transform.rotation = new Quaternion(0, 180f, 0, 1);
            actualFlare = right;
        }

        // Fire Gun
        Fire();

    } // End Move

    private void Fire()
    {
        // When the player presses space bar, flare is shot
        if (Input.GetKey(KeyCode.Space) && (counter > delayTime))
        {
            Instantiate(actualFlare, firePoint.transform.position, firePoint.transform.rotation);
            GetComponent<AudioSource>().Play();
            counter = 0;
        }

        counter += 1 * Time.deltaTime;
    }
    
}
