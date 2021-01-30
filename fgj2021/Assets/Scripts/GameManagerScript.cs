using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public int lives;
    public static GameManagerScript Instance { get; private set; }
    void Awake() {
        if (Instance == null) { 
            Instance = this; 
        } else { 
            Debug.Log("Warning: multiple " + this + " in scene!"); 
        }
    }

    void Start() {
        //SpawnLifeboats lifeboats = GetComponent<SpawnLifeboats>();
        //lifeboats.Spawn();
    }

    public void lifeBoatDeath(string name) {
        lives -= 1;
        Debug.Log(name + " has died from hunger!");

        if (lives < 0) {
            Debug.Log("huutista");
        }
    }
    public string getName() {
        var nameScript = GetComponent<Names>();
        return nameScript.getName();
    }

}
