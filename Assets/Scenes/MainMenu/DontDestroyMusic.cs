using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    private static DontDestroyMusic instance;
    private AudioSource audioSrc;

    void Update()
    {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.volume = PlayerPrefs.GetFloat("v");
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
