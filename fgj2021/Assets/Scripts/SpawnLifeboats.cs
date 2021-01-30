using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLifeBoats : MonoBehaviour
{

    public GameObject lifeboatPrefab;
    private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
         tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    public void Spawn()
    {
        int spawnAmount = Random.Range(1, 5);

        for (var i = 0; i < spawnAmount; i++) {
            var x = tr.position.x + Random.Range(-0.2f, 0.2f);
            var y = tr.position.y + Random.Range(-0.2f, 0.2f);

            var rotX = Random.Range(0f, 360f);
            var rotY = Random.Range(0f, 360f);

            Quaternion rotation = Quaternion.Euler(rotX, 0, 0);

            GameObject lifeboat = Instantiate(lifeboatPrefab, new Vector3(x, y, 0), rotation);

            //Variables variables = lifeboat.GetComponent<Variables>()
        }
    }
}
