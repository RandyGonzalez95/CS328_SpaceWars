using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject resumeButton;
    public GameObject restartButton;


    public void OnPause()
    {

        if(resumeButton != null && pauseButton != null)
        {
            Time.timeScale = 0;
            resumeButton.SetActive(true);
            pauseButton.SetActive(false);
            restartButton.SetActive(true);
        }

    }

    public void OnResume()
    {

        if (resumeButton != null && pauseButton != null)
        {
            Time.timeScale = 1;
            resumeButton.SetActive(false);
            pauseButton.SetActive(true);
            restartButton.SetActive(false);
        }

    }

    public void OnRestart()
    {
        if (resumeButton != null && pauseButton != null)
        {
            Time.timeScale = 1;
            resumeButton.SetActive(false);
            pauseButton.SetActive(true);
            restartButton.SetActive(false);
            Application.LoadLevel("GameScreen");
        }
    }
}
