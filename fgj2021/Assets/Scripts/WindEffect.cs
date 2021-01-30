using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindEffect : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject[] windColliders;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        windColliders = GameObject.FindGameObjectsWithTag("WindArea");
    }

    void FixedUpdate()
    {
        foreach (var windCollider in windColliders)
        {
            if (rb.IsTouching(windCollider.GetComponent<BoxCollider2D>()))
            {
                rb.AddForce(windCollider.GetComponent<WindCollider>().getSpeed(), ForceMode2D.Impulse);
            }
        }
    }



}
