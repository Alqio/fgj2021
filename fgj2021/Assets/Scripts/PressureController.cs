using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PressureController : MonoBehaviour
{


    public float moveSpeed = 1.5f;

    Vector2 moveRight;
    Vector2 moveLeft;

    PlayerControls controls;
    bool inverted = true;
    private List<GameObject> pressureAreas = new List<GameObject>();

    // Start is called before the first frame update
    void Awake()
    {
        pressureAreas.AddRange(GameObject.FindGameObjectsWithTag("HighPressure"));
        pressureAreas.AddRange(GameObject.FindGameObjectsWithTag("LowPressure"));

        controls = new PlayerControls();

        controls.GameplaySticks.MoveRight.performed += ctx => moveRight = ctx.ReadValue<Vector2>();
        controls.GameplaySticks.MoveRight.canceled += ctx => moveRight = Vector2.zero;
        controls.GameplaySticks.MoveLeft.performed += ctx => moveLeft = ctx.ReadValue<Vector2>();
        controls.GameplaySticks.MoveLeft.canceled += ctx => moveLeft = Vector2.zero;

        controls.GameplaySticks.Switch.performed += ctx => SwitchPolarity();


        controls.GameplayKeyboard.Arrows.performed += ctx => moveRight = ctx.ReadValue<Vector2>();
        controls.GameplayKeyboard.Arrows.canceled += ctx => moveRight = Vector2.zero;
        controls.GameplayKeyboard.WASD.performed += ctx => moveLeft = ctx.ReadValue<Vector2>();
        controls.GameplayKeyboard.WASD.canceled += ctx => moveLeft = Vector2.zero;

        controls.GameplayKeyboard.Switch.performed += ctx => SwitchPolarity();

        //controls.GameplayMouse.MoveMouse.performed += ctx => move = ctx.ReadValue<Vector2>();
        //controls.GameplayMouse.MoveMouse.canceled += ctx => move = Vector2.zero;


    }

    void Update()
    {
        Vector2 m1 = new Vector2(moveRight.x, moveRight.y) * moveSpeed * Time.deltaTime;
        Vector2 m2 = new Vector2(moveLeft.x, moveLeft.y) * moveSpeed * Time.deltaTime;
        /*if (!GetComponent<Wind>().IsTooCloseAfter(m))
        {
        }*/
        List<Vector2> moves = new List<Vector2>();
        moves.Add(m1);
        moves.Add(m2);

        if (inverted)
        {
            moves.Reverse();
        }
        for (int i = 0; i < pressureAreas.Count; i++)
        {
            pressureAreas[i].transform.Translate(moves[i], Space.World);
        }

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

    void SwitchPolarity()
    {
        inverted = !inverted;
    }


}
