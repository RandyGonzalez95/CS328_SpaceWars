using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    // Variables
    int spawnCounter = 0, maxSpawn = 10;
    public GameObject asteroid;
    public float spawnrate;
    Vector3 randomLoc;
    float x, y, z = 0f;
    
    // Use this for initialization
	void Start ()
    {
        randomLoc = Vector3.zero;
        
        StartCoroutine("delayCall");
	}

    IEnumerator delayCall()
    {
        // Spawn Asteroid at random location
        if(spawnCounter < maxSpawn)
        {
            // Loop for 10 asteroids
            for(int i = 0; i < 100; i++)
            {
                // Randomize location for asteroid
                x = Random.Range(-18f, 18f);
                y = Random.Range(-8f, 8f);
                randomLoc = new Vector3(x, y, z);

                // Spawn Asteroid at random loc                     
                Instantiate(asteroid, randomLoc, Quaternion.identity);

                // Wait for 2.5 seconds
                yield return new WaitForSeconds(spawnrate);
            }  // end for loop          
        } 
    }// end IEnumerator
}
