using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTrail : MonoBehaviour
{
    public float lifetime = 0.0f;

    private float maxLifeTime;

    void Start()
    {
        maxLifeTime = Random.Range(1.5f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        lifetime += Time.deltaTime;
        if (lifetime > maxLifeTime)
        {

            DestroyImmediate(this.gameObject);
        }
    }
}
