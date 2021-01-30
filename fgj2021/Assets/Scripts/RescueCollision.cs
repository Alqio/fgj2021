using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueCollision : MonoBehaviour
{

    private bool isDestroyed = false;
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
            GameManagerScript.Instance.rescueLifeBoat();
        }
        else if (other.gameObject.tag == "Boat" && !isDestroyed)
        {
            isDestroyed = true;
            int rand_value = Random.Range(0,2);
            if (rand_value == 1)
            {
                other.gameObject.GetComponent<ShipMovement>().DestroyBoat();
            }
            else
            {
                this.gameObject.GetComponent<ShipMovement>().DestroyBoat();
            }
        }
    }
}
