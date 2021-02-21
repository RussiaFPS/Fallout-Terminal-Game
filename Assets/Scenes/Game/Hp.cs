using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    public static string fullText = "";
    private static string currentText = "";
    public static Hp instance;

    void Awake()
    {
        instance = this;
    }
    public static void HP()
    {
        fullText = "Attempts Remaining: ";
        instance.GetComponent<Text>().text = currentText;
        for (int i = 0; i < tex2.hp; i++)
        {
            fullText = fullText + "X ";
        }
        instance.StartCoroutine(Hp.ShowText());
    }
    static IEnumerator ShowText()
    {
        for (int i = 0; i < Hp.fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            instance.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(tex1.delay);
        }
    }
}
