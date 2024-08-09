using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlsManager : MonoBehaviour
{
    public PlayerControls playerControls;
    private InputAction move;
    private InputAction look;


    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        move = playerControls.keyboard.movement;
        move.Enable();

        look = playerControls.keyboard.look;
        look.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
        look.Disable();
    }

    public Vector2 getMovement()
    {
        return move.ReadValue<Vector2>();
    }

    public Vector2 getLook()
    {
        return move.ReadValue<Vector2>();
    }
}
