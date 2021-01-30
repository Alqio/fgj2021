using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    private int survived = 0;
    private int dead = 0;
    public Text survivedText;
    public Text deadText;

    void Start()
    {
        survivedText = GameObject.Find("SurvivedText").GetComponent<Text>();
        deadText = GameObject.Find("DeadText").GetComponent<Text>();
    }

    void Update()
    {
        survivedText.text = "Survived: " + survived;
        deadText.text = "Dead: " + dead;
    }
}