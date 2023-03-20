using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneManager : MonoBehaviour
{
    public GameObject tutorial;
    
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Tutorial()
    {
        tutorial.SetActive(true);
    }

    public void returnButton()
    {
        tutorial.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
