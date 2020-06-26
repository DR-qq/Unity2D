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

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
