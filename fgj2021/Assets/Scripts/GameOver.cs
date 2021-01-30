using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class GameOver : MonoBehaviour
{


    public GameObject GameOverUI;
    PlayerControls controls;


    void Awake() {
        controls = new PlayerControls();
    }

    void Update() {
        if(GameManagerScript.Instance.deaths > 10)
        {
            GameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void OnEnable()
    {
        controls.MenuActions.Enable();
    }


    void OnDisable()
    {
        controls.MenuActions.Disable();
    }

    public void Restart()
    {
        GameOverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        Debug.Log("menuing");
        SceneManager.LoadScene("LassinMainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("quitting");
        Application.Quit();
    }
}

