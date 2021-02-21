using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    private AudioSource audioSrc;
    private float musicVolume = 1f;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        musicVolume = PlayerPrefs.GetFloat("v");
    }

    void Update()
    {
        audioSrc.volume = musicVolume;
    }
}
