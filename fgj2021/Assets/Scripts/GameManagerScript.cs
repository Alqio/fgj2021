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

    public string getName() {
        var nameScript = GetComponent<Names>();
        return nameScript.getName();
    }

}
