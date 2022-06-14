using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void ExitButton()
    {
        // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void RestartGame()
    {
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene("NinjavsZombie");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
