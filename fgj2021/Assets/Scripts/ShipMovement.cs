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

    public LayerMask layerMask;

    private MemoryCollider detector;
    public AudioClip sinkSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float random_x = Random.Range(-1.0f, 1.0f);
        float random_y = Random.Range(-1.0f, 1.0f);
        initialDirection = Vector2.right;//new Vector2(random_x, random_y);
        initialDirection.Normalize();
        lifeDuration = Random.Range(1500, 4000);
        // rb.AddForce(initialDirection*3.0f, ForceMode2D.Impulse);
        initialPosition = transform.position;

        detector = transform.Find("LifeDetector").GetComponent<MemoryCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position2d = new Vector2(transform.position.x, transform.position.y);
        float delta = (position2d - initialPosition).magnitude;

        float speed = rb.velocity.magnitude;
        if (delta > lifeDuration)// || speed <= 0)
        {
            
            DestroyBoat();
            return;
        }
        
        Vector2 target = GetTarget();
        Vector2 direction = (target - position2d).normalized;

        rb.AddForce(direction*forceMagnitude, ForceMode2D.Force);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, rb.velocity);//initial_direction, Camera.main.transform.forward);//transform.forward, Camera.main.transform.forward);
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }

    Vector2 GetTarget()
    {
        //Collider2D collider = Physics2D.OverlapBox(gameObject.transform.position, gameObject.transform.localScale * 3, 0.0f);
        GameObject[] allLifeBoats = GameObject.FindGameObjectsWithTag("Lifeboat");
        
        if(allLifeBoats.Length == 0)//collidersHit.Length == 0)
        {
            //Debug.Log("YES NO COLLISIONS");
            return targetPosition;
        }
        else
        {
           // Debug.Log("YES SOMETHING IS HERE!");
            int i = 0;
            while(i < allLifeBoats.Length)
            {
                GameObject targetObject = allLifeBoats[i];//.gameObject;
                if (targetObject != null)// && targetObject.tag == "LifeBoat")
                {
                    //Debug.Log("YES!");
                    if ((targetObject.transform.position - transform.position).magnitude < 100.0f)
                    {
                        return targetObject.transform.position;
                    }
                }
                i++;
            }
            //Debug.Log("YES NO!");
            return targetPosition;
        }

        
    }

    public void DestroyBoat()
    {
        Transform parent = GameObject.FindGameObjectWithTag("MainCanvas").gameObject.transform;
        GameObject effectInstance = Instantiate(explosionParticleEffect, transform.position, transform.rotation, parent);
        effectInstance.GetComponent<ParticleSystem>().Play();

        SpawnLifeboats lifeBoatSpawner = GetComponent<SpawnLifeboats>();
        AudioSource.PlayClipAtPoint(sinkSound, transform.position, 4f);

        lifeBoatSpawner.Spawn();
        Destroy(this.gameObject);
    }
}
