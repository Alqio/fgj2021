﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCollider : MonoBehaviour
{
    public GameObject lowPressure, highPressure, windTrailPrefab;
    private GameObject windTrailObjects;
    private Vector3 speed;
    public float scale, maxDistance;

    private SpriteRenderer spriteRenderer;
    private List<GameObject> windTrails = new List<GameObject>();

    [Range(0, 100)]
    public int trailFrequency = 100;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        windTrailObjects = GameObject.Find("WindTrails");
    }

    // Update is called once per frame
    void Update()
    {
        //update wind speed according to the pressure areas
        float distanceBetweenPressures = NormalizeDist(Vector2.Distance(lowPressure.transform.position, highPressure.transform.position), maxDistance);
        speed = (lowPressure.transform.position - highPressure.transform.position) *
                    distanceBetweenPressures *
                    scale *
                    Time.deltaTime;
        if (Random.Range(0, trailFrequency) == 1)
        {
            GameObject w = Instantiate(windTrailPrefab, RandomPointInBounds(GetComponent<Collider2D>().bounds), new Quaternion(0, 0, 0, 0), windTrailObjects.transform);
            windTrails.Add(w);
        }
        foreach (var windTrail in windTrails)
        {
            if (windTrail && windTrail.GetComponent<WindTrail>().lifetime < 1.0f && GetComponent<Collider2D>().bounds.Contains(windTrail.transform.position))
            {

                windTrail.transform.Translate((lowPressure.transform.position - highPressure.transform.position) * 0.5f * Time.deltaTime);
            }
        }

        //wind area rotation
        Vector3 relativePos = lowPressure.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, relativePos);
        transform.rotation = rotation;

        //wind area position
        transform.position = (lowPressure.transform.position + highPressure.transform.position) / 2;

        //wind area scale
        transform.localScale = new Vector3(transform.localScale.x, Vector3.Distance(lowPressure.transform.position, highPressure.transform.position) / 2, transform.localScale.z);
    }

    public Vector3 getSpeed() { return speed; }

    float NormalizeDist(float dist, float range)
    {
        float value = (range - dist) / range;
        if (value > 1 || value < 0) return 0;
        return value;
    }

    public static Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
