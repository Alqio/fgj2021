using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript Instance { get; private set; }
    void Awake() {
        if (Instance == null) { 
            Instance = this; 
        } else { 
            Debug.Log("Warning: multiple " + this + " in scene!"); 
        }
    }

    void Start() {
        SpawnLifeboats lifeboats = GetComponent<SpawnLifeboats>();
        lifeboats.Spawn();
    }

    public string getName() {
        var nameScript = GetComponent<Names>();
        return nameScript.getName();
    }

}
