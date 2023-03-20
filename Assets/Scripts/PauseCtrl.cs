using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseCtrl : MonoBehaviour
{
    public GameObject pauseMenu;
    
    public void PauseBtn()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeBtn()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void HomeBtn()
    {
        SceneManager.LoadScene("StartScene");
    }
}
