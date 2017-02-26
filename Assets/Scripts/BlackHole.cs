using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float gravitationalForce;
    public float forceForPlayer;
    private Vector3 distanceFromCenter;

    GameObject gameobject;
    GameObject player;
	// Use this for initialization
	void Start ()
    {
        gameobject = GameObject.FindGameObjectWithTag("gameobject");
        player = GameObject.FindGameObjectWithTag("Player");
        distanceFromCenter = Vector3.zero;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
 

        if (collision.collider.tag == "Player")
        {
            Destroy(player);
        }
    }
}
