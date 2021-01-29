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

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        personName = GameManagerScript.Instance.getName();

        
        var forceDirection = new Vector2(Random.Range(0, 360), Random.Range(0, 360));

        movingVelocity = Random.Range(0.0f, 10f);
        rotationVelocity = Random.Range(0.0f, 10f);

        body.AddForce(forceDirection * movingVelocity);

    }

    void Update() {
        if (rotationVelocity > 0) {
            transform.Rotate(Vector3.left, 45 * Time.deltaTime * rotationVelocity);
            rotationVelocity -= 0.01f;
        }
        
    }

}
