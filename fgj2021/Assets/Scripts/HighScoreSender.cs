using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class HighScoreSender : MonoBehaviour
{

    public InputField scoreInputField;
    public Text deathsText;
    public Text survivedText;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(PostScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PostScore()
    {
        Debug.Log("POSTTTTia " + scoreInputField.text);
    
        int deaths =  GameManagerScript.Instance.deaths;
        int survived =  GameManagerScript.Instance.saved;

        string dateString = System.DateTime.UtcNow.ToString("o");

        string postData = "{ \"score\": " + deaths + ", \"scorer\": \"" + scoreInputField.text.ToString() + "\", \"hash\": \"$2b$04$C6Zd8FPfp3X6GiE3M.QZJOx8dwMGvBeSn9DE1Iu4gZ9uwD3Ej5KAi\", \"date\": \"" + dateString + "\"}";
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(postData);
        Debug.Log("POSTIA:" + bytes);
        

        string url = "https://gmscoreboard-backend.herokuapp.com/games/6016887b596c0e0004f0f4bb/scores/";
        UnityWebRequest request = UnityWebRequest.Put(url, bytes);
        request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("Accept", "application/json");
        StartCoroutine(SendRequest(request));
        
        postData = "{ \"score\": " + survived + ", \"scorer\": \"" + scoreInputField.text.ToString() + "\", \"hash\": \"$2b$04$M/k1Hub5wz1FJbNz6xkgTuRsSJfTeqkI/midY8ZjsKdYTB/c7KBge\", \"date\": \"" + dateString + "\"}";
        bytes = System.Text.Encoding.UTF8.GetBytes(postData);
        Debug.Log("POSTIA:" + bytes);
        string survUrl = "https://gmscoreboard-backend.herokuapp.com/games/60168885596c0e0004f0f4bc/scores/";
        request = UnityWebRequest.Put(survUrl, bytes);
        request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("Accept", "application/json");
        StartCoroutine(SendRequest(request));

        // UnityWebRequest request = new UnityWebRequest(url, "POST");
        // byte[] rawBody = Encoding
    }

    private IEnumerator SendRequest(UnityWebRequest request)
    {
        yield return request.SendWebRequest();

        if (request.isNetworkError)
        {
            Debug.Log("POST Error while sending score " + request.GetResponseHeader(""));
        }
        else
        {
            byte[] results = request.downloadHandler.data;
            Debug.Log("POST results: " + results.ToString());
            gameObject.SetActive(false);
        }

    }
}
