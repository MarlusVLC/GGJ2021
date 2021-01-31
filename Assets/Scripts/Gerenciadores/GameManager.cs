﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

using Aux_Classes;

public class GameManager : MonoBehaviour
{
    // [SerializeField] private float sloMoScale;
    //
    private Dictionary<GameObject, RespawnState> _respawnStates = new Dictionary<GameObject, RespawnState>();
    // private bool _isTowerFocused;
    //
    // public delegate void EnterFocusMode();
    // public event EnterFocusMode enterFocus;
    //
    // public delegate void ExitFocusMode();
    // public event EnterFocusMode exitFocus;



    private static GameManager INSTANCE;
    public static GameManager getInstance
    {
        get { return INSTANCE; }
    }

    private void Awake()
    {
        //SINGLETON check
        if (INSTANCE != null && INSTANCE != this)
        {
            Destroy(this.gameObject);
        }
        //SINGLETON instantiate
        else
        {
            INSTANCE = this;
        }
        
    }

    private void Update()
    {

    }
    


    public void SetRespawnState(GameObject gameObject, Vector3 position, Vector3 velocity, float rotation)
    {
        RespawnState respawnState = new RespawnState(position, velocity, rotation);
    
    
        if (_respawnStates.ContainsKey(gameObject))
        {
            _respawnStates[gameObject] = respawnState;
        }
        else
        {
            _respawnStates.Add(gameObject, respawnState);
        }
    }
    
    public RespawnState GetRespawnState(GameObject gameObject)
    { 
        return _respawnStates[gameObject];
    }
    //
    //
    // public bool IsTowerFocused
    // {
    //     get => _isTowerFocused;
    //     set => _isTowerFocused = value;
    // }
    //
    // public void EnterFocus()
    // {
    //     _isTowerFocused = true;
    //     if (enterFocus != null)
    //             enterFocus();
    //     Time.timeScale = sloMoScale;
    //     Time.fixedDeltaTime = 0.02f * Time.timeScale;
    //
    // }
    //
    // public void ExitFocus()
    // {
    //     // _isTowerFocused = false;
    //     if (exitFocus != null)
    //         exitFocus();
    //     Time.timeScale = 1;
    //     Time.fixedDeltaTime = 0.02f * Time.timeScale;
    // }
}
