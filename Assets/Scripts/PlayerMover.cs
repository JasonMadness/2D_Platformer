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

    private Vector2 _rightDirection = Vector2.zero;
    private Vector2 _leftDirection = new(0, 180);
    private bool _isLookingRight = true;

    private float _minGroundDistance = 0.2f;
    private bool _isGrounded = false;

    private void Update()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _minGroundDistance, _groundLayer);
    }

    public void MoveRight()
    {
        if (_isLookingRight == false)
            LookRight();

        Move();
    }

    public void MoveLeft()
    {
        if (_isLookingRight)
            LookLeft();

        Move();
    }

    public void Jump()
    {
        if (_isGrounded)
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void LookRight()
    {
        transform.rotation = Quaternion.Euler(_rightDirection);
        _isLookingRight = true;
    }

    private void LookLeft()
    {
        transform.rotation = Quaternion.Euler(_leftDirection);
        _isLookingRight = false;
    }

    private void Move()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}