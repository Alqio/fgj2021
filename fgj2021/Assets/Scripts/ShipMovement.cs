using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    Vector2 initialDirection;
    private Rigidbody2D rb;
    private float lifeDuration;
    private Vector2 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float random_x = Random.Range(-1.0f, 1.0f);
        float random_y = Random.Range(-1.0f, 1.0f);
        initialDirection = new Vector2(random_x, random_y);
        initialDirection.Normalize();
        lifeDuration = Random.Range(1, 3);
        rb.AddForce(initialDirection*3.0f, ForceMode2D.Impulse);
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(initial_direction  * Time.deltaTime, Camera.main.transform);
        float delta = (new Vector2(transform.position.x, transform.position.y) - initialPosition).magnitude;

        if (delta > lifeDuration)
        {
            SpawnLifeBoats lifeBoatSpawner = GetComponent<SpawnLifeBoats>();
            lifeBoatSpawner.Spawn();
            DestroyImmediate(this.gameObject);
            return;
        }

        transform.rotation = Quaternion.LookRotation(Vector3.forward, rb.velocity);//initial_direction, Camera.main.transform.forward);//transform.forward, Camera.main.transform.forward);
    }
}
