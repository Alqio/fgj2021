using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueCollision : MonoBehaviour
{
    // private Collision2D collision;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        
        if (other.gameObject.tag == "Lifeboat")
        {
            Debug.Log("Rescued!");
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
