using System;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private float _speed = 4f;
    [SerializeField] private float _jumpForce = 8f;

    private float _minGroundDistance = 0.2f;
    private bool _isGrounded = false;

    private void Update()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _minGroundDistance, _groundLayer);
    }

    public void MoveRight()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }

    public void MoveLeft()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }

    public void Jump()
    {
        if (_isGrounded)
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}