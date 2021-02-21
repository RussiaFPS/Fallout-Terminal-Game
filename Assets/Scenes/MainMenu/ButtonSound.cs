using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSound : MonoBehaviour,IPointerEnterHandler
{
    public AudioSource mySource;
    public AudioClip myClip;

    void Start()
    {
        mySource.volume = 0.1f;
    }


    public void OnPointerEnter(PointerEventData myData)
    {
        mySource.PlayOneShot(myClip);
    }
}
