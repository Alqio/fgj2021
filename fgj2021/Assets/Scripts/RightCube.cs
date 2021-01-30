using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RightCube : MonoBehaviour
{


    public float moveSpeed = 1.5f;

    Vector2 move;

    PlayerControls controls;
    int selectedIndex;
    private List<GameObject> pressureAreas = new List<GameObject>();

    // Start is called before the first frame update
    void Awake()
    {
        pressureAreas.AddRange(GameObject.FindGameObjectsWithTag("HighPressure"));
        pressureAreas.AddRange(GameObject.FindGameObjectsWithTag("LowPressure"));

        controls = new PlayerControls();

        controls.GameplaySticks.MoveRight.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GameplaySticks.MoveRight.canceled += ctx => move = Vector2.zero;


        //controls.GameplayKeyboard.Arrows.performed += ctx => move = ctx.ReadValue<Vector2>();
        //controls.GameplayKeyboard.Arrows.canceled += ctx => move = Vector2.zero;
        controls.GameplayKeyboard.WASD.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GameplayKeyboard.WASD.canceled += ctx => move = Vector2.zero;


        //controls.GameplayMouse.MoveMouse.performed += ctx => move = ctx.ReadValue<Vector2>();
        //controls.GameplayMouse.MoveMouse.canceled += ctx => move = Vector2.zero;


    }

    void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * moveSpeed * Time.deltaTime;
        /*if (!GetComponent<Wind>().IsTooCloseAfter(m))
        {
        }*/
        pressureAreas[selectedIndex].transform.Translate(m, Space.World);
    }

    void OnEnable()
    {
        controls.GameplaySticks.Enable();
        controls.GameplayKeyboard.Enable();
        //controls.GameplayMouse.Enable();


    }

    void OnDisable()
    {
        controls.GameplaySticks.Disable();
        controls.GameplayKeyboard.Disable();
        //controls.GameplayMouse.Disable();

    }

    void IncreasePressureIndex()
    {
        if (selectedIndex == pressureAreas.Count - 1)
        {
            selectedIndex = 0;
        }
        else
        {
            selectedIndex += 1;
        }
    }
    void DecreasePressureIndex()
    {
        if (selectedIndex == 0)
        {
            selectedIndex = pressureAreas.Count - 1;
        }
        else
        {
            selectedIndex -= 1;
        }
    }

}
