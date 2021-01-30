using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSetup : MonoBehaviour
{
    public List<Sprite> sprites;

    // Start is called before the first frame update
    void Start()
    {
        int randomBoatIndex = Random.Range(0,sprites.Count);
        GetComponent<SpriteRenderer>().sprite = sprites[randomBoatIndex];
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.mass = (sprites.Count - randomBoatIndex)*80;
        GetComponent<CapsuleCollider2D>().size = GetComponent<SpriteRenderer>().sprite.bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
