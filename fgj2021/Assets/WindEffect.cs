using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindEffect : MonoBehaviour
{
    public float thrust;
    private Rigidbody2D rb;
    public GameObject highPressure, lowPressure;
    public Collider2D windCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (rb.IsTouching(windCollider))
        {
            rb.AddForce(
                (highPressure.transform.position - lowPressure.transform.position) *
                NormalizeDist(Vector2.Distance(lowPressure.transform.position, highPressure.transform.position), 15) *
                thrust *
                Time.deltaTime, ForceMode2D.Impulse
            );
        }
    }

    float NormalizeDist(float dist, float range)
    {
        float value = -1 / range * dist + 1;
        if (value > 1) return 0;
        return value;
    }

}
