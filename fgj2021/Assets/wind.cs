using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{

    public GameObject windColliderPrefab;
    private GameObject[] otherWinds;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "HighPressure")
        {
            otherWinds = GameObject.FindGameObjectsWithTag("LowPressure");
            foreach (var wind in otherWinds)
            {
                GameObject w = Instantiate(windColliderPrefab, transform);
                w.GetComponent<WindCollider>().highPressure = gameObject;
                w.GetComponent<WindCollider>().lowPressure = wind;
            }
        }
        else if (gameObject.tag == "LowPressure")
        {
            otherWinds = GameObject.FindGameObjectsWithTag("HighPressure");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {

        }


    }

}
