using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    PlayerControls controls;


    void Awake() {
        controls = new PlayerControls();

        controls.MenuActions.Pause.started += ctx => PauseGame();//Debug.Log("hjasd");
        //controls.MenuActions.Pause.canceled += ctx => move = Vector2.zero;
    }

    void Start() {
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    void Update() {
        Debug.Log(Time.timeScale);
        
    }

    void PauseGame() {
        if(GameIsPaused)
        {
            Resume();
        } else {
            Pause();
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

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
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
