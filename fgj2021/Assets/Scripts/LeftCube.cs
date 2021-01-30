using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeftCube : MonoBehaviour
{

    public float moveSpeed = 1.5f;


    Vector2 move;

    PlayerControls controls;

    // Start is called before the first frame update
    void Awake()
    {
        controls = new PlayerControls();

        controls.GameplaySticks.MoveLeft.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GameplaySticks.MoveLeft.canceled += ctx => move = Vector2.zero;

        controls.GameplayKeyboard.WASD.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GameplayKeyboard.WASD.canceled += ctx => move = Vector2.zero;
    }

    void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * moveSpeed * Time.deltaTime;
        if (!GetComponent<Wind>().IsTooCloseAfter(m))
        {
            transform.Translate(m, Space.World);
        }
    }

    void OnEnable()
    {
        controls.GameplaySticks.Enable();
        controls.GameplayKeyboard.Enable();

    }

    void OnDisable()
    {
        controls.GameplaySticks.Disable();
        controls.GameplayKeyboard.Disable();

    }

}
