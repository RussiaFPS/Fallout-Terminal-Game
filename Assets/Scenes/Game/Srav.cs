using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Srav : MonoBehaviour
{
    public static string fullText="";
    private static string currentText = "";
    public static Srav instance;
    void Awake()
    {
        instance = this;
    }
    public static void Sr(int srav)
    {
        fullText = "Likeness: ";
        instance.GetComponent<Text>().text = currentText;
        fullText = fullText + srav + " ";
        instance.StartCoroutine(ShowText());
    }
    static IEnumerator ShowText()
    {
        for (int i = 0; i < Srav.fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            instance.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(tex1.delay);
        }
    }

}
