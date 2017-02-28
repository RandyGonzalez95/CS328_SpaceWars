using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameMngr : MonoBehaviour
{
    // Access to player objects
    public GameObject player1;
    public GameObject player2;

    public GameObject restartButton;
    public GameObject pauseButton;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // If user taps the esc key exit the game
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        // Check every frame to see if characters are alive
        if (player1 == null)
        {
            DisplayEnd();
        }
        if(player2 == null)
        {
            DisplayEnd();
        }

	}

    private void DisplayEnd()
    {
        Time.timeScale = 0;

        // Activate the restart button
        if((restartButton != null) &&(pauseButton != null))
        {
            restartButton.SetActive(true);
            pauseButton.SetActive(false);
        }



    }
}
