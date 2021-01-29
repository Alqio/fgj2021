using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RightCube : MonoBehaviour
{


    public float moveSpeed = 1.5f;

    Vector2 move;

    PlayerControls controls;

    // Start is called before the first frame update
    void Awake()
    {
        controls = new PlayerControls();

        // controls.GameplaySticks.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        // controls.GameplaySticks.Move.canceled += ctx => move = Vector2.zero;

        controls.GameplayKeyboard.Arrows.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GameplayKeyboard.Arrows.canceled += ctx => move = Vector2.zero;
    }

    void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * moveSpeed * Time.deltaTime;
        transform.Translate(m, Space.World);
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
