using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tex1 : MonoBehaviour
{
    public static float delay;
    public static bool CheckFastTextOut;
    public static bool SpeedStartStop;
    public string fullText = "Welcome to ROBCO Industries (TM) Termlink\nPassword Required\n";
    private string currentText = "";
    void Start()
    {
        delay = 0.01f;
        CheckFastTextOut = false;
        SpeedStartStop = true;
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            if (tex1.CheckFastTextOut == false)
            { 
                currentText = fullText.Substring(0, i);
                this.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(delay);
            }else
            {
                currentText = fullText.Substring(i);
                this.GetComponent<Text>().text = fullText;
                break;
            }
        }
        tex2.T2();
    }
}
