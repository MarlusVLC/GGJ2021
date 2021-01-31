using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    
    
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
