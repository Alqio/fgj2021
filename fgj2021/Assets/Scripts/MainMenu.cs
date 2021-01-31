using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {

    }

    public void ShowScoreboard()
    {
        Application.OpenURL("https://gmscoreboard.herokuapp.com/#/");
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LassinGameScene");
    }

    public void QuitGame()
    {
        Debug.Log("quitting");
        Application.Quit();
    }
}
