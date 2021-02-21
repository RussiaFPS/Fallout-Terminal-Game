using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class GraphicSettings : MonoBehaviour
{


    public Dropdown resolutionDrop;
    public Toggle togl;


    void Start()
    {
        resolutionDrop.value = PlayerPrefs.GetInt("Resolution");
        if (PlayerPrefs.GetInt("screen") == 0)
        {
            togl.isOn = false;
        }
        else
        {
            togl.isOn = true;
        }
    }


    public void Resol()
    {
        switch (resolutionDrop.value)
        {
            case 0:
                Screen.SetResolution(1280, 720, Screen.fullScreen);
                break;
            case 1:
                Screen.SetResolution(1366, 768, Screen.fullScreen);
                break;
            case 2:
                Screen.SetResolution(1600, 900, Screen.fullScreen);
                break;
            case 3:
                Screen.SetResolution(1920, 1080, Screen.fullScreen);
                break;
            case 4:
                Screen.SetResolution(2560, 1440, Screen.fullScreen);
                break;
            case 5:
                Screen.SetResolution(3840, 2160, Screen.fullScreen);
                break;
        }
        PlayerPrefs.SetInt("Resolution", resolutionDrop.value);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        PlayerPrefs.SetInt("screen", Convert.ToInt32(isFullscreen));
    }
}
