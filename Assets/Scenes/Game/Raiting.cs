using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raiting : MonoBehaviour
{
    public static int RaitInt = 0;//Int переменная хранит число в рейтинге
    private string currentText = "";//переменная для корутины
    private string fullText;//переменная для корутины
    void Start()
    {
        RaitInt = PlayerPrefs.GetInt("rating");//присвоение к рейтингу из сейва
        fullText="Rating "+ Convert.ToString(RaitInt)+" ";//получаем строку со словом и числов рейтинга
        StartCoroutine(ShowText());//запускаем корутину
    }
    IEnumerator ShowText()//корутина
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(tex1.delay);
        }
    }
}
