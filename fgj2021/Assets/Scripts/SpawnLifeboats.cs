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

    // Update is called once per frame
    public void Spawn()
    {
        int spawnAmount = Random.Range(1, 5);

        for (var i = 0; i < spawnAmount; i++) {
            var x = tr.position.x + Random.Range(-0.2f, 0.2f);
            var y = tr.position.y + Random.Range(-0.2f, 0.2f);

            var rotX = Random.Range(0f, 360f);

            Quaternion rotation = Quaternion.Euler(0, 0, rotX);

            Transform parent = GameObject.FindGameObjectWithTag("MainCanvas").gameObject.transform;
            GameObject lifeboat = Instantiate(lifeboatPrefab, new Vector3(x, y, 0), rotation, parent);
            lifeboat.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);
        }
    }
}
