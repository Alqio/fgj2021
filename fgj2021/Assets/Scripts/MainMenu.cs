using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {

    }

    public void StartGame()
    {
        
        SceneManager.LoadScene("LassinGameScene");
    }

    public void QuitGame()
    {
        Debug.Log("quitting");
        Application.Quit();
    }
}
