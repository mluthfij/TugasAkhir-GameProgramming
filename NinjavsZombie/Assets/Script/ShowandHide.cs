using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowandHide : MonoBehaviour
{
    public GameObject pauseButton;

    // Update is called once per frame
    void Update()
    {
        // if (!PauseScript.isPaused)
        if (PauseScript.isPaused == true)
        {
            Hide();
        } else if (PauseScript.isPaused == false)
        {
            Show();
        }
    }

    public void Hide()
    {
        pauseButton.SetActive(false);
    }
    
    public void Show()
    {
        pauseButton.SetActive(true);
    }
}
