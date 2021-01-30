using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{

    public GameObject windColliderPrefab;
    public float tooCloseDistance;
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

    public bool IsTooCloseAfter(Vector2 m)
    {
        bool tooClose = false;
        foreach (var other in otherWinds)
        {
            if (Vector2.Distance((Vector2)transform.position + m, other.transform.position) < tooCloseDistance)
            {
                tooClose = true;
                break;
            }
        }
        return tooClose;
    }

}
