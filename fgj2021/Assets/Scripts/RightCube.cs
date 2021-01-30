using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RightCube : MonoBehaviour
{


    public float moveSpeed = 1.5f;

    Vector2 move;

    bool mouseDragging = false;
    Vector2 mousePivot;
    Vector2 mouseTarget;
    PlayerControls controls;

    // Start is called before the first frame update
    void Awake()
    {
        controls = new PlayerControls();

        controls.GameplaySticks.MoveRight.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GameplaySticks.MoveRight.canceled += ctx => move = Vector2.zero;

        controls.GameplayKeyboard.Arrows.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GameplayKeyboard.Arrows.canceled += ctx => move = Vector2.zero;

        controls.GameplayMouse.MoveMouse.performed += ctx =>
        {
            if (mouseDragging)
            {
                mouseTarget = ctx.ReadValue<Vector2>();
                move = (mouseTarget - mousePivot).normalized;
            }
            else
            {
                mousePivot = ctx.ReadValue<Vector2>();
                move = Vector2.zero;
            }
        };
        //controls.GameplayMouse.MoveMouse.canceled += ctx => move = Vector2.zero;

        controls.GameplayMouse.ClickMouse.performed += ctx => mouseDragging = true;
        controls.GameplayMouse.ClickMouse.canceled += ctx => mouseDragging = false;
    }

    void Update()
    {

        Vector2 m = new Vector2(move.x, move.y) * moveSpeed * Time.deltaTime;
        if (!GetComponent<Wind>().IsTooCloseAfter(m))
        {
        }
        transform.Translate(m, Space.World);
    }

    void OnEnable()
    {
        controls.GameplaySticks.Enable();
        controls.GameplayKeyboard.Enable();
        controls.GameplayMouse.Enable();


    }

    void OnDisable()
    {
        controls.GameplaySticks.Disable();
        controls.GameplayKeyboard.Disable();
        controls.GameplayMouse.Disable();

    }

}
