using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCollider : MonoBehaviour
{
    public GameObject lowPressure, highPressure;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (lowPressure.transform.position + highPressure.transform.position) / 2;
        transform.localScale = new Vector3(transform.localScale.x, Vector3.Distance(lowPressure.transform.position, highPressure.transform.position) / 2, transform.localScale.z);
    }
}
