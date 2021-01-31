using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueCollision : MonoBehaviour
{

    public bool isDestroyed = false;
    // private Collision2D collision;
    // Start is called before the first frame update
    public AudioClip saveSound;

    void Start()
    {
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Lifeboat")
        {
            Debug.Log("Rescued!");
            AudioSource.PlayClipAtPoint(saveSound, transform.position, 100f);
            Destroy(other.gameObject);
            GameManagerScript.Instance.rescueLifeBoat();
        }
        else if (other.gameObject.tag == "Boat")
        {
            bool otherDestroyed = other.gameObject.GetComponent<RescueCollision>().isDestroyed;
            if (!otherDestroyed)
            {
                other.gameObject.GetComponent<ShipMovement>().DestroyBoat();
            }
            if (!isDestroyed)
            {
                this.gameObject.GetComponent<ShipMovement>().DestroyBoat();
                isDestroyed = true;
            }
        }
    }
}
