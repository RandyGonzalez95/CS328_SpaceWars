using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrustMovment : MonoBehaviour
{
    public float speed;
    public float thrustForce;
    Rigidbody2D player;
    public int health;

    public GameObject bullet;
    Transform firePosition;

    // Health Amount
    public Image HealthBar;
    public float fillAmount;


	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Rigidbody2D>();
        firePosition = transform.FindChild("FirePoint");

	}

    void Update()
    {
        //if at any point we want to exit the game
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        // if at anytime we are at 0 HP we die
        if (fillAmount == 0f)
        {
            Destroy(this.gameObject);
        }

        // Shoot bullets
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, firePosition.transform.position, firePosition.transform.rotation);
            GetComponent<AudioSource>().Play();
        }

        UpdateHeatlth();
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

    private void UpdateHeatlth()
    {
        HealthBar.fillAmount = fillAmount;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "gameobject")
        {
            fillAmount -= 0.1f;
            Destroy(collision.collider.gameObject);
        }
        if (collision.collider.tag == "asteroid")
        {
            fillAmount -= 0.1f;
            Destroy(collision.collider.gameObject);
        }
    }
}
