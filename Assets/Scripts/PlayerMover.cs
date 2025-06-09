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

    private float _minGroundDistance = 0.1f;
    private bool _isGrounded = false;

    private bool _isRunning;
    private bool _isJumping;
    private bool _isFalling;

    public bool IsRunning => _isRunning;

    private void Update()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _minGroundDistance, _groundLayer);
        _isRunning = _isGrounded && _rigidbody.velocity != Vector2.zero;
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
        //transform.Translate(Vector3.right * _speed * Time.deltaTime);
        Vector2 moveDirection = _isLookingRight ? Vector2.right : Vector2.left;
        //_rigidbody.AddForce(moveDirection * _speed * Time.deltaTime);
        _rigidbody.velocity += (moveDirection * _speed).normalized;
        Debug.Log(_rigidbody.velocity);
    }
}