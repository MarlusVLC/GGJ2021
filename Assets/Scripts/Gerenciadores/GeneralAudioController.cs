using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralAudioController : MonoBehaviour
{
    [SerializeField] AudioClip bgTrack0;
    
    void Start()   
    {
        AudioManager.getInstance.PlayAudio(bgTrack0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
