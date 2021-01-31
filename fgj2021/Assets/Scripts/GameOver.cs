using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{


    public GameObject GameOverUI;
    PlayerControls controls;
    public float matchDuration = 5;
    public Text timeRemainingText;
    float timeRemaining;
    void Awake() {
        controls = new PlayerControls();
    }

    void Start() {
        InvokeRepeating("DecreaseSeconds", 0, 1);
        timeRemaining = matchDuration;
    }

    void DecreaseSeconds()
    {
        timeRemaining -= 1;
        string prefix = "Time: ";
        
        string time = timeRemaining.ToString();
        string suffix = "";
        if (timeRemaining >= 60)
        {
            float minutes_left = (int) timeRemaining / 60;
            float seconds_left = timeRemaining - minutes_left * 60;

            time = minutes_left + ":" + seconds_left;
        }
        else if (timeRemaining < 60 && timeRemaining >= 10)
        {
            suffix = "s";
        }
        else
        {
            timeRemainingText.color = new Color(0.8f, 0.1f, 0.1f);
            suffix = "s";
        }

        timeRemainingText.text = prefix + time + suffix;
        Debug.Log("Time remaining: " + time);
        if (timeRemaining <= 0)
        {
            EndMatch();
        }
    }

    void Update() {
      
    }

    void EndMatch()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
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

