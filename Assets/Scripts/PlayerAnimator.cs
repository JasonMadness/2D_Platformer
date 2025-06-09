using System;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string IsRunning = "IsRunning";

    private Animator _animator;
    private bool _isRunning;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
       // _animator
    }

    public void SetRunFlag(bool flag)
    {
        _animator.SetBool(IsRunning, flag);
    }
}
