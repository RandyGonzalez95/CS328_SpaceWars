using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour {

    public GameObject bullet;
    public float delayTime = 0.5f;

    private float counter = 0;

    public GameObject left;
    public GameObject right;

    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        // When player presses Space the gun will shoot
		if(Input.GetKey(KeyCode.Space) && (counter > delayTime))
        {
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            GetComponent<AudioSource>().Play();
            counter = 0;
        }

        counter += 1 * Time.deltaTime;

        //Destroy(bullet);
        //CheckBoundary();

    }

    private void CheckBoundary()
    {
        if ((bullet.transform.position.x < left.transform.position.x))
        {
           
        }
    }
}
