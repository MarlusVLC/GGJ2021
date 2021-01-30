using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 _moveDirection;
    public float moveSpeed = 1;
    private float _defaultAngle;
    private float _moveDirectionAngle;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _defaultAngle = transform.rotation.eulerAngles.z;
    }

    void FixedUpdate()
    {
        if (_rb != null)
        {
            ApplyInput();
            Rotate();
        }
        else
        {
            Debug.Log("Rigid body not attached");
        }
    }

    public void ApplyInput()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");



        _moveDirection = new Vector2(xInput, yInput).normalized;
        

        _rb.AddForce(_moveDirection * moveSpeed);
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
