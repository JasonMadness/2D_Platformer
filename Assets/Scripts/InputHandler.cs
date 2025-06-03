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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _mover.Jump();
        }
    }
}
