using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Volume : MonoBehaviour
{
    public GameObject MusicSettings;
    public Slider sliderInstance;
    private float musicVolume=1f;
    void Start()
    {
        sliderInstance.value= PlayerPrefs.GetFloat("v");
        musicVolume =PlayerPrefs.GetFloat("v");
    }


    public void SetVolume(float vol)
    {
       musicVolume = vol;
       PlayerPrefs.SetFloat("v", musicVolume);
    }
    public void Back()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
