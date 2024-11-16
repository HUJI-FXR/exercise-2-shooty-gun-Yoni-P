using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float acceleration;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    
    private Rigidbody2D _rigidbody2D;
    private bool _isGrounded;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _isGrounded = true;
    }

    public void MovePlayer(Vector2 curInput)
    {
        float xVel = Mathf.Clamp(_rigidbody2D.velocity.x + curInput.x * acceleration, -speed, speed);

        _rigidbody2D.velocity = new Vector2(xVel, _rigidbody2D.velocity.y);

        if (curInput.y > 0 && _isGrounded)
            Jump();
    }

    private void Jump()
    {
        _rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        _isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            _isGrounded = true;
    }

    // private void OnCollisionExit2D(Collision2D other)
    // {
    //     if (other.gameObject.CompareTag("Ground"))
    //         _isGrounded = false;
    // }
}
