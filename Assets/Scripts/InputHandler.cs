using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private PlayerMover _mover;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _mover.MoveRight();
        }

        if (Input.GetKey(KeyCode.A))
        {
            _mover.MoveLeft();
        }
    }
}
