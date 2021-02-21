using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameFail : MonoBehaviour
{
    public static float delay = 0.01f;
    public static string fullText;
    private static string currentText = "";
    void Start()
    {
        fullText = "Error...Press Enter to restart... " + test.vic;
        switch (tex2.hpCheck)
        {
            case 1:
                Raiting.RaitInt--;
                break;
            case 2:
                Raiting.RaitInt -= 2;
                break;
            case 3:
                Raiting.RaitInt -= 3;
                break;
            case 4:
                Raiting.RaitInt -= 4;
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
            fullText = "";
            SceneManager.LoadScene("Game");
        }
    }
    IEnumerator ShowText()
    {
        for (int i = 0; i < GameFail.fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}
