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
        GameObject ship = Instantiate(gameObjectToSpawn, transform.position, transform.rotation);
        ship.GetComponent<ShipMovement>().targetPosition = targetPosition;
    }
}
