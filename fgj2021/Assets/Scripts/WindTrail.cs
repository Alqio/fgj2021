using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTrail : MonoBehaviour
{
    public float lifetime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        lifetime += Time.deltaTime;
        if (lifetime > 1.5f)
        {

            DestroyImmediate(this.gameObject);
        }
    }
}
