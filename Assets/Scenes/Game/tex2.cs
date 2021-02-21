using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class tex2 : MonoBehaviour
{
    public static string fullText = "Attempts Remaining: ";
    private static string currentText = "";
    public static tex2 instance;
    public static int hp;
    public static int hpCheck;
    void Awake()
    { 
        instance = this; 
    }
    public static void T2()
    {
        hp = Random.Range(1, 4);
        hpCheck = hp;
        for (int i = 0; i < hp; i++)
        {
            fullText = fullText + "X ";
        }
        instance.StartCoroutine(tex2.ShowText());
    }
    static IEnumerator  ShowText()
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
        test.lvl1(tex2.hp);
    }
}
