using System;
using UnityEngine;

namespace player
{
    public class NewMovement : MonoBehaviour
    {
        [SerializeField] private float thrust;
        [SerializeField] private float turnThrust;
        
        private float thrustInput, turnInput;

        private Rigidbody2D _rb;


        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            thrustInput = Input.GetAxis("Vertical");
            turnInput = Input.GetAxis("Horizontal");
            

        }

        private void FixedUpdate()
        {
            _rb.AddRelativeForce(Vector2.up * (thrustInput * thrust));
            _rb.AddTorque(-turnInput * turnThrust);
            
        }
    }   
}