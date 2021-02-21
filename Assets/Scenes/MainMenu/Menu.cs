using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MusicObject;
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void SettingsGame()
    {
        SceneManager.LoadScene("Settings"); 
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
