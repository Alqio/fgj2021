using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

    public string personName;
    private Transform trans;
    private Rigidbody2D body;

    private float movingVelocity;

    private float rotationVelocity;

    public List<Sprite> sprites;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        personName = GameManagerScript.Instance.getName();

        
        var forceDirection = new Vector2(Random.Range(-360, 360), Random.Range(-360, 360));

        movingVelocity = Random.Range(0.0f, 40f);
        rotationVelocity = Random.Range(0.0f, 30f);

        body.AddForce(forceDirection * movingVelocity);

        GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count - 1)];

    }

    void Update() {
        if (rotationVelocity > 0) {
            transform.eulerAngles = Vector3.forward * 45 * rotationVelocity;
            rotationVelocity -= 0.01f;
        }
        Debug.Log(trans.position.x);
    }

}
