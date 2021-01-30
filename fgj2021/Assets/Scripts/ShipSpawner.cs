using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gameObjectToSpawn;
    public float spawnRate = 3.0f;
    // public Vector2 spawnDirection;

    public Vector2 targetPosition;

    void Start()
    {
        InvokeRepeating("SpawnShip", 0, spawnRate);
    }

    void SpawnShip()
    {
        Vector2 position = new Vector2(transform.position.x, transform.position.y);
        Vector2 directionToTarget = (position - targetPosition);
        Vector2 spawningBorderDirection = Vector2.Perpendicular(directionToTarget).normalized;

        float randomX = Random.Range(-150,150);
        float randomY = Random.Range(-150,150);

        float t = Random.Range(-350,350);

        Vector2 spawnPoint = position + spawningBorderDirection * t;

        // Vector2 offset = new Vector2(randomX, randomY);
        Quaternion spawnRotation = Quaternion.LookRotation(Vector3.forward, new Vector2(transform.position.x, transform.position.y) - targetPosition);

        // GameObject ship = Instantiate(gameObjectToSpawn, new Vector2(transform.position.x, transform.position.y) + offset, transform.rotation);
        Transform parent = GameObject.FindGameObjectWithTag("MainCanvas").gameObject.transform;
        GameObject ship = GameObject.Instantiate(gameObjectToSpawn, spawnPoint, spawnRotation, parent);

        ship.GetComponent<ShipMovement>().targetPosition = targetPosition;
    }
}
