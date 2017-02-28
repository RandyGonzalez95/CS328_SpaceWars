using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject resumeButton;



    public void OnPause()
    {

        if(resumeButton != null && pauseButton != null)
        {
            Time.timeScale = 0;
            resumeButton.SetActive(true);
            pauseButton.SetActive(false);
        }

    }

    public void OnResume()
    {

        if (resumeButton != null && pauseButton != null)
        {
            Time.timeScale = 1;
            resumeButton.SetActive(false);
            pauseButton.SetActive(true);
        }

    }
}
