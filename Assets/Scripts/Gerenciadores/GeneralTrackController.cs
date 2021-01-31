using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralTrackController : MonoBehaviour
{
    private AudioSource _bgTrackManager;
    [SerializeField] AudioClip bgTrack0;


    private void Awake()
    {
        _bgTrackManager = GetComponent<AudioSource>();
    }

    void Start()
    {
        _bgTrackManager.clip = bgTrack0;
        _bgTrackManager.Play();
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}
