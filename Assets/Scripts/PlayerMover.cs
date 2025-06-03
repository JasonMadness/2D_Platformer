using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    
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
        
    }
}