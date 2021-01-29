using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gameObjectToSpawn;
    public float spawnRate = 3.0f;

    void Start()
    {
        InvokeRepeating("SpawnShip", 0, spawnRate);
    }

    void SpawnShip()
    {
        Instantiate(gameObjectToSpawn, transform.position, transform.rotation);
    }
}