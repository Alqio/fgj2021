using System.Collections;
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

    void FixedUpdate() {
        if (Random.Range(0, trailFrequency) == 1)
        {
            //Transform parent = GameObject.FindGameObjectWithTag("MainCanvas").gameObject.transform;
            Vector2 point = RandomPointInBounds(GetComponent<Collider2D>().bounds);
            GameObject w = Instantiate(windTrailPrefab, point, new Quaternion(0, 0, 0, 0), windTrailObjects.transform);
            windTrails.Add(w);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //update wind speed according to the pressure areas
        float distanceBetweenPressures = NormalizeDist(Vector2.Distance(lowPressure.transform.position, highPressure.transform.position), maxDistance);
        speed = (lowPressure.transform.position - highPressure.transform.position) *
                    distanceBetweenPressures *
                    scale;

        foreach (var windTrail in windTrails)
        {
            if (windTrail)
            {
                // Debug.Log(GetComponent<Collider2D>().bounds.Contains(windTrail.transform.position));
                // Debug.Log(GetComponent<Collider2D>().bounds.ClosestPoint(windTrail.transform.position));
                // Debug.Log(windTrail.transform.position);
                Vector3 closestPoint = GetComponent<Collider2D>().bounds.ClosestPoint(windTrail.transform.position);
                Vector2 closestPoint2D = (Vector2) closestPoint;
                
                Vector2 windTrailPosition = (Vector2) windTrail.transform.position; // closestPoint2D == windTrailPosition
                if (windTrail && windTrail.GetComponent<WindTrail>().lifetime < 1.0f)// && closestPoint2D == windTrailPosition)//GetComponent<Collider2D>().bounds.Contains( (Vector2) windTrail.transform.position))
                {

                    windTrail.transform.Translate((lowPressure.transform.position - highPressure.transform.position) * 0.5f * Time.deltaTime);
                }
            }
        }

        //wind area rotation
        Vector3 relativePos = lowPressure.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, relativePos);
        transform.rotation = rotation;

        //wind area position
        transform.position = (lowPressure.transform.position + highPressure.transform.position) / 2;

        //wind area scale
        Vector3 localScale = new Vector3(transform.localScale.x, Vector3.Distance(lowPressure.transform.position, highPressure.transform.position) / 2, transform.localScale.z);
        float canvasScale = GameObject.FindGameObjectWithTag("MainCanvas").transform.localScale.x;
        localScale.y *= 0.2f / canvasScale;
        transform.localScale = localScale;
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
