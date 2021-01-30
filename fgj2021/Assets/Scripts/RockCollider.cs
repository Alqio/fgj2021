using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        
        if (other.gameObject.tag == "Lifeboat")
        {
            Destroy(other.gameObject);
            GameManagerScript.Instance.lifeBoatDeath(other.GetComponent<Variables>().personName);
        }
        else if (other.gameObject.tag == "Boat")
        {
            other.gameObject.GetComponent<ShipMovement>().DestroyBoat();
        }
    }
}
