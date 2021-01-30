using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShipMovement : MonoBehaviour
{
    public GameObject explosionParticleEffect;
    public float forceMagnitude = 40.0f;
    private Vector2 initialDirection;
    private Rigidbody2D rb;
    private float lifeDuration;
    private Vector2 initialPosition;
    public Vector2 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float random_x = Random.Range(-1.0f, 1.0f);
        float random_y = Random.Range(-1.0f, 1.0f);
        initialDirection = Vector2.right;//new Vector2(random_x, random_y);
        initialDirection.Normalize();
        lifeDuration = Random.Range(15, 40);
        // rb.AddForce(initialDirection*3.0f, ForceMode2D.Impulse);
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position2d = new Vector2(transform.position.x, transform.position.y);
        float delta = (position2d - initialPosition).magnitude;

        float speed = rb.velocity.magnitude;
        if (delta > lifeDuration)// || speed <= 0)
        {
            
            DestroyBoat();
            return;
        }
        
        Vector2 direction = (targetPosition - position2d).normalized;

        rb.AddForce(direction*forceMagnitude, ForceMode2D.Force);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, rb.velocity);//initial_direction, Camera.main.transform.forward);//transform.forward, Camera.main.transform.forward);
    }

    public void DestroyBoat()
    {
        GameObject effectInstance = Instantiate(explosionParticleEffect, transform.position, transform.rotation);
        effectInstance.GetComponent<ParticleSystem>().Play();

        SpawnLifeboats lifeBoatSpawner = GetComponent<SpawnLifeboats>();
        lifeBoatSpawner.Spawn();
        
        Destroy(this.gameObject);
    }
}
