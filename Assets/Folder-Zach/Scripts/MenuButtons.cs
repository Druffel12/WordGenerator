using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject optionsUI;

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Options()
    {
        optionsUI.SetActive(true);
    }

    public void Back()
    {
        optionsUI.SetActive(false);
    }
}
