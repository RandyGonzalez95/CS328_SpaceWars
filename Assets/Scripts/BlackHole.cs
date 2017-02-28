using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackHole : MonoBehaviour
{
    // Gravity Variables
    public float gravitationalForce;
    public float forceForPlayer;
    private Vector3 distanceFromCenter;

    // Access to game objects
    GameObject gameobject;
    GameObject player;
    GameObject player2;

    // Access to character health bars
    public Image HP_1;
    public Image HP_2;
	// Use this for initialization
	void Start ()
    {
        // Initalize all public vars
        gameobject = GameObject.FindGameObjectWithTag("gameobject");
        player = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        distanceFromCenter = Vector3.zero;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        // Apply gravity to all objects
        if(gameobject != null)
        {
            distanceFromCenter = (transform.position - gameobject.transform.position).normalized;
            gameobject.GetComponent<Rigidbody2D>().AddForce(distanceFromCenter * gravitationalForce);
        } 
        
        if(player != null)
        {
            distanceFromCenter = (transform.position - player.transform.position).normalized;
            player.GetComponent<Rigidbody2D>().AddForce(distanceFromCenter * forceForPlayer);
        }

        if (player2 != null)
        {
            distanceFromCenter = (transform.position - player2.transform.position).normalized;
            player2.GetComponent<Rigidbody2D>().AddForce(distanceFromCenter * forceForPlayer);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
 
        // Check if a player has been sucked in
        if (collision.collider.tag == "Player")
        {
            HP_1.fillAmount = 0f;
            // End game
            Destroy(player);
        }

        if (collision.collider.tag == "Player2")
        {
            HP_2.fillAmount = 0f;
            // End game
            Destroy(player2);
        }
    }
}
