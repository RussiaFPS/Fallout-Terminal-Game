using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tex3 : MonoBehaviour
{
    public static string fullText = "Password -> ";
    private static string currentText = "";
    public static tex3 instance;
    void Awake()
    {
        instance = this;
    }
    public static void T3()
    {       
        instance.StartCoroutine(tex3.ShowText());
        tex1.SpeedStartStop = false;
    }
    static IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            if (tex1.CheckFastTextOut == false)
            {
                currentText = fullText.Substring(0, i);
                instance.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(tex1.delay);
            }
            else
            {
                currentText = fullText.Substring(i);
                instance.GetComponent<Text>().text = fullText;
                break;
            }
        }
        input.InText();
    }
}
