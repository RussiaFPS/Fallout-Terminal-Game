using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Successful : MonoBehaviour
{
    public static float delay = 0.01f;
    public static string fullText = "Successful...Press Enter to continue... ";
    private static string currentText = "";
    void Start()
    {
        switch (tex2.hpCheck)
        {
            case 1:
                Raiting.RaitInt+= 4;
                break;
            case 2:
                Raiting.RaitInt += 3;
                break;
            case 3:
                Raiting.RaitInt += 2;
                break;
            case 4:
                Raiting.RaitInt ++;
                break;
            default:
                break;
        }
        PlayerPrefs.SetInt("rating",Raiting.RaitInt);
        StartCoroutine(ShowText());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) | (Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            tex1.SpeedStartStop = false;
            input.chekInput = false;
            tex2.fullText = "Attempts Remaining: ";
            test.fullText = "";
            SceneManager.LoadScene("Game");
        }
    }
    IEnumerator ShowText()
    {
        for (int i = 0; i < Successful.fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}
