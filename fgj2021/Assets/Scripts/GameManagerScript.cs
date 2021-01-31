using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public Text deathsText;
    public Text savedText;

    public int saved;
    public int deaths;

    public int lives;

    public static GameManagerScript Instance { get; private set; }
    void Awake() {
        Debug.LogError( SceneManager.GetActiveScene().name);
        if (Instance == null) { 
            if (deathsText != null) {
                Instance = this; 
            } else {
                Debug.LogError("deathsText oli null????");
            }
            
        } else { 
            Debug.LogError("Warning: multiple " + this + " in scene!"); 
        }
    }

    void Start() {
        //SpawnLifeboats lifeboats = GetComponent<SpawnLifeboats>();
        //lifeboats.Spawn();
    }

    public void lifeBoatDeath(string name) {
        deaths += 1;
        Debug.Log(name + " has died from hunger!");
        
        deathsText.text = "DEATHS: " + deaths.ToString();

        if (deaths >= lives) {
            Debug.Log("huutista");
        }

    }

    public void rescueLifeBoat() {
        saved += 1;
        savedText.text = "SAVED: " + saved.ToString();
    }
    
    public string getName() {
        var nameScript = GetComponent<Names>();
        return nameScript.getName();
        //return "paska";
    }

}
