using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;

    private bool flag = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            PausePanel.SetActive(!flag);
            Time.timeScale = 0;
        }
    }


    public void BackToGame()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
        
    }
}
