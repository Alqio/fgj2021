using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    public Text survivedText;
    public Text deadText;

    void Start()
    {
        survivedText = GameObject.Find("SurvivedText").GetComponent<Text>();
        deadText = GameObject.Find("DeadText").GetComponent<Text>();
    }

}