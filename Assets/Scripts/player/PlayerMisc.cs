using System;
using System.Collections;
using System.Collections.Generic;
using Aux_Classes;
using UnityEngine;

public class PlayerMisc : MonoBehaviour
{
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        GameManager.getInstance.SetRespawnState(gameObject, transform.position, Vector3.zero, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WhirlpoolsEye"))
        {
            Die();
        }
    }

    private void Die()
    {
        RespawnState respawnState = GameManager.getInstance.GetRespawnState(this.gameObject);
        transform.position = respawnState.Position;
        _rb.rotation = respawnState.Rotation;
        _rb.velocity = respawnState.Velocity;
    }
}
