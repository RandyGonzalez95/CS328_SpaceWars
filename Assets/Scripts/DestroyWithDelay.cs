// Space Wars Replica Game
// CS 328
// "DestroyWithDelay.cs"
// Randy Gonzalez 
using UnityEngine;

public class DestroyWithDelay : MonoBehaviour
{
    public float delay;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, delay);
    }
}
