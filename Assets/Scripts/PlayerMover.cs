using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed = 4f;
    [SerializeField] private float _jumpForce = 8f;
    
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
        _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}