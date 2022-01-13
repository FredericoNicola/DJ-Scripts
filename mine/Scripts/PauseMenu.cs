using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        
        if (Input.GetKey(KeyCode.Escape))
        {
            
            if (GameIsPaused == true)
            {
                
                Resume();
            }
            if (GameIsPaused == false)
            {
                Pause();
                
            }
        }


    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void quit()
    {
        Application.Quit();
    }
}
