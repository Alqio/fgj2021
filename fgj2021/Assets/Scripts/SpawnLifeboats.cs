using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLifeboats : MonoBehaviour
{

    public GameObject lifeboatPrefab;
    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Spawn() {
        int spawnAmount = Random.Range(0, 5);

        for (var i = 0; i < spawnAmount; i++) {
            var x = tr.position.x + Random.Range(-15, 15);
            var y = tr.position.x + Random.Range(-15, 15);

            var rotX = Random.Range(0f, 360f);
            var rotY = Random.Range(0f, 360f);

            Quaternion rotation = Quaternion.Euler(rotX, rotY, 0);

            GameObject lifeboat = Instantiate(lifeboatPrefab, new Vector2(x, y), rotation);

            //Variables variables = lifeboat.GetComponent<Variables>();
            
        }

    }

}
