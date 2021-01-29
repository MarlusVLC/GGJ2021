using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // [SerializeField] private float moveSpeed;
    // [SerializeField] private float stopingRate;
    [SerializeField] private float acceleration;
    [SerializeField] private float dampingBasic;
    
    private Vector2 _moveDirection;
    private Rigidbody2D _rb;
    private float _moveX, _moveY;
    private float _defaultAngle;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _defaultAngle = transform.rotation.eulerAngles.z;
    }
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
        Rotate();
    }

    void ProcessInputs()
    {
        _moveX = Input.GetAxisRaw("Horizontal");
        _moveY = Input.GetAxisRaw("Vertical");

        _moveDirection = new Vector2(_moveX, _moveY).normalized;
    }

    void Move()
    {
        // _rb.velocity = new Vector2(_moveDirection.x * moveSpeed, _moveDirection.y * moveSpeed);
        //
        _rb.AddForce(_moveDirection * acceleration);

        // if (_rb.velocity.magnitude > Vector2.zero.magnitude)
        // {
        //     _rb.velocity -= _moveDirection * stopingRate;
        // }
        _rb.velocity *= Mathf.Pow(1f - dampingBasic, Time.deltaTime * 10f);

    }

    void Rotate()
    {
        float angle = Mathf.Atan2(_moveDirection.y, _moveDirection.x) * Mathf.Rad2Deg + _defaultAngle;
        if (_moveDirection != Vector2.zero)
        {
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
