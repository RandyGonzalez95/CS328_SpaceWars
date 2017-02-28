using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameMngr : MonoBehaviour
{
    // Access to player objects
    public GameObject player1;
    public GameObject player2;

    public GameObject restartButton;
    public GameObject pauseButton;

    private bool flag;

    public GameObject endPanel;
    public Text text;

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
            flag = true;
        }
        if(player2 == null)
        {
            DisplayEnd();
            flag = false;
        }

	}

    private void DisplayEnd()
    {
        Time.timeScale = 0;
        endPanel.SetActive(true);

        // Activate the restart button
        if((restartButton != null) &&(pauseButton != null))
        {
            restartButton.SetActive(true);
            pauseButton.SetActive(false);
        }

        if(flag)
        {
            text.text = "Player 2 Wins!";
        }
        else
        {
            text.text = "Player 1 Wins!";
        }



    }
}
