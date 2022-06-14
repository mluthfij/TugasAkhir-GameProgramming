using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public static bool isDestroy;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);    
    }

    public void PauseGame()
    {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void RestartGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene("NinjavsZombie");
    }
    public void ExitButton()
    {
        // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void GotoMainMenu()
    {
        DestroyMusic();
        // pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void DestroyMusic()
    {
        isDestroy = true;
    }
}
