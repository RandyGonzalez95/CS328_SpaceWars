using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrustMovment : MonoBehaviour
{
    // Player Movement
    public float speed;
    public float thrustForce;
    Rigidbody2D player;
    private int health = 100;

    // Bullet fire position and gameobject
    public GameObject bullet;
    Transform firePosition;

    // Health Amount
    public Image HealthBar;
    public float fillAmount;

    // HyperSpace variables
    private float delayTime = 10f, counter = 10;



	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Rigidbody2D>();
        firePosition = transform.FindChild("FirePoint");

	}

    void Update()
    {
        // if at anytime we are at 0 HP we die
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        // Fire Gun
        Fire();

        // Update Character Health Bar
        UpdateHeatlth();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        // Check for Character Movement
        Movement();

        // Check for HyperSpace
        HyperSpace();
    }

    private void UpdateHeatlth()
    {
        HealthBar.fillAmount = fillAmount;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Handle player collisions
        if(collision.collider.tag == "gameobject")
        {
            fillAmount -= 0.1f;
            health -= 10;
            Destroy(collision.collider.gameObject);
        }
        if (collision.collider.tag == "asteroid")
        {
            fillAmount -= 0.1f;
            health -= 10;
            Destroy(collision.collider.gameObject);
        }


    }

    private void Fire()
    {
        // Shoot bullets
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, firePosition.transform.position, firePosition.transform.rotation);
            GetComponent<AudioSource>().Play();
        }

    }

    private void HyperSpace()
    {
        float x;
        float y;

        // Randomize Location
        x = Random.Range(-18, 18);
        y = Random.Range(-8, 8);

        // Activate HyperSpace
        if (Input.GetKeyDown(KeyCode.S) && (counter > delayTime))
        {
            this.transform.position = new Vector3(x, y, 0);
            counter = 0;
        }

        counter += 1 * Time.deltaTime;
    }

    private void Movement()
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
