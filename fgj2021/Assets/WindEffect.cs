using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindEffect : MonoBehaviour
{
    public float thrust;
    private Rigidbody2D rb;
    public GameObject highPressure, lowPressure;
    private Collider2D windCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lowPressure = GameObject.Find("LowPressure");
        highPressure = GameObject.Find("HighPressure");
        windCollider = highPressure.transform.Find("WindCollider").GetComponent<Collider2D>();
    }

    void FixedUpdate()
    {
        if (rb.IsTouching(windCollider))
        {
            rb.AddForce(
                (lowPressure.transform.position - highPressure.transform.position) *
                NormalizeDist(Vector2.Distance(lowPressure.transform.position, highPressure.transform.position), 50) *
                thrust *
                Time.deltaTime, ForceMode2D.Impulse
            );
        }
    }

    float NormalizeDist(float dist, float range)
    {
        float value = (range - dist) / range;
        if (value > 1 || value < 0) return 0;
        return value;
    }

}