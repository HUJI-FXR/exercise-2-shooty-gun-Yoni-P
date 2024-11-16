using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    [SerializeField] private MovementScript movementScript;

    private Vector2 _curInput = Vector2.zero;

    private void Update()
    {
        HandleInput();
        movementScript.MovePlayer(_curInput);
    }

    private void HandleInput()
    {
        HandleHorizontalInput();
        HandleVerticalInput();
    }

    private void HandleVerticalInput()
    {
        _curInput.y = 0;
        if (Input.GetKey(KeyCode.W))
            _curInput.y = 1;
    }

    private void HandleHorizontalInput()
    {
        _curInput.x = 0;
        if (Input.GetKey(KeyCode.A))
            _curInput.x -= 1;
        if (Input.GetKey(KeyCode.D))
            _curInput.x += 1;
    }
}
