// Space Wars Replica Game
// CS 328
// "MovePlayer1.cs"
// Randy Gonzalez 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer1 : MonoBehaviour
{
    public float speed = 1.5f;
    private float degrees = 180.0f;
    private bool turn = false;

	// Use this for initialization
	void Start ()
    {
       
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
            turn = false;      
        }
        // Character goes left
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
            this.transform.rotation = new Quaternion(0, 0f, 0, 1);             
        }
        // Character Goes Down
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.down * speed * Time.deltaTime;
            turn = false;            
        }
        // Character Goes Right
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
            this.transform.rotation = new Quaternion(0, 180f, 0, 1);
        }

    } // End Move


}
