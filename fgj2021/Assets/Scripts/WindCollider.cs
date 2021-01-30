using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCollider : MonoBehaviour
{
    public GameObject lowPressure, highPressure;
    private Vector3 speed;
    public float scale, maxDistance;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        //Color newColor = new Color(distanceBetweenPressures * 255, distanceBetweenPressures * 255, distanceBetweenPressures * 255);

        //wind area rotation
        Vector3 relativePos = lowPressure.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, relativePos);
        transform.rotation = rotation;

        //wind area position
        transform.position = (lowPressure.transform.position + highPressure.transform.position) / 2;

        //wind area scale
        Vector3 localScale = new Vector3(transform.localScale.x, Vector3.Distance(lowPressure.transform.position, highPressure.transform.position) / 2, transform.localScale.z);
        float canvasScale = GameObject.FindGameObjectWithTag("MainCanvas").transform.localScale.x;
        localScale.y *= 0.1f / canvasScale;
        transform.localScale = localScale;
    }

    public Vector3 getSpeed() { return speed; }

    float NormalizeDist(float dist, float range)
    {
        float value = (range - dist) / range;
        if (value > 1 || value < 0) return 0;
        return value;
    }
}
