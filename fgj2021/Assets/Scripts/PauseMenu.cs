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

    float menuMove = 0f;
    float menuPosition = 0f;
    float menuDelay = 0f;
    float menuWait = 0.3f;

    void Awake()
    {
        controls = new PlayerControls();

        controls.MenuActions.Pause.started += ctx => PauseGame();//Debug.Log("hjasd");

        controls.MenuActions.MenuMove.performed += ctx => menuMove = ctx.ReadValue<float>();
        controls.MenuActions.MenuMove.canceled += ctx => { menuMove = 0; menuDelay = menuWait; };
    }

    void PauseGame()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    void Update()
    {
        if (menuMove != 0f && menuDelay > menuWait)
        {
            menuPosition += menuMove;
            menuDelay = 0f;
            Debug.Log(menuPosition);
        }
        menuDelay += Time.unscaledDeltaTime;
    }

    void OnEnable()
    {
        controls.MenuActions.Pause.Enable();
    }


    void OnDisable()
    {
        controls.MenuActions.Disable();
    }

    public void Resume()
    {
        controls.MenuActions.MenuMove.Disable();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        controls.MenuActions.MenuMove.Enable();
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
