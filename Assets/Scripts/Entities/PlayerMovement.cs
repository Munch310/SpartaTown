using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    private PlayerController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;


    private Animator _mainSpriteAnimator;

    private void Awake()
    {
        _mainSpriteAnimator = GetComponentInChildren<Animator>();
        _controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    // 호출이 Update보다 느림.
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
        _mainSpriteAnimator.SetBool("IsMoving", _movementDirection.magnitude > 0f);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }
}
