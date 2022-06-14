using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject generalMenu;

    void Start()
    {
        generalMenu.SetActive(false);    
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void StartGame()
    {
        PauseScript.isPaused = false;
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene("NinjavsZombie");
    }

    public void GeneralMenu()
    {
            generalMenu.SetActive(true);
    }
    public void BackButton()
    {
            generalMenu.SetActive(false);
    }
}
