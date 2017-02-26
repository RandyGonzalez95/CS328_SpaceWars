using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY, maxY;
    	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float x = transform.position.x;
        float y = transform.position.y;

        // if we go off screen reset our character
        if (x < minX)
            x = maxX;
        else if (x > maxX)
            x = minX;

        if (y < minY)
            y = maxY;
        else if (y > maxY)
            y = minY;

        // Reset our new position
        transform.position = new Vector3(x, y, transform.position.z);
	}
}
