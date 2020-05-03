using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenOptionsMenu()
    {
        Debug.Log("TODO: Make an options menu");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            // Make quitting work in the editor, Application.Quit() only works in the build
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
