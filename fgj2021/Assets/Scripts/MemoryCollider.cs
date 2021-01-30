using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCollider : MonoBehaviour
{
    public List<GameObject> collidingObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        collidingObjects.Add(other.gameObject);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        collidingObjects.Remove(other.gameObject);
    }
}
