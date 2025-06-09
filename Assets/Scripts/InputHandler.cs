using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private PlayerMover _mover;
    [SerializeField] private PlayerAnimator _animator;

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
        
        _animator.SetRunFlag(_mover.IsRunning);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _mover.Jump();
        }
    }
}
