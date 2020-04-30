using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadMenu()
    {
        //Time.timeScale = 1f;
        Debug.Log("TODO: Make a menu");
    }

    public void QuitGame()
    {
        Debug.Log("TODO: Make an actual quit function (that will work in the editor and out of it)");
        Application.Quit();
    }

    public void LoadDebugMenu()
    {
        Debug.Log("TODO: Make a debug menu");
    }
}
