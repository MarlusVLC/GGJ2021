using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralBgSfxController : MonoBehaviour
{
    [SerializeField] AudioClip bgSfx0;
    
   private AudioSource _bgSfxManager;


   private void Awake()
   {
       _bgSfxManager = GetComponent<AudioSource>();
   }

   void Start()
    {

        _bgSfxManager.clip = bgSfx0;
        _bgSfxManager.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
