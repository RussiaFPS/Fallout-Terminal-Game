using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveIn : MonoBehaviour
{
    public InputField inputF;
    string textIn = "", textDef = "";
    public static int CountInput = 0;

    void Update()
    {
        if (tex1.SpeedStartStop == true  && (Input.GetKeyDown(KeyCode.Return) || (Input.GetKeyDown(KeyCode.KeypadEnter))))
        {
            tex1.CheckFastTextOut = true;
        }
        if (input.chekInput == true)
        {
            if (CountInput != tex2.hp)
            {
                if (Input.GetKeyDown(KeyCode.Return) || (Input.GetKeyDown(KeyCode.KeypadEnter)))
                {
                    textIn = inputF.text;
                    inputF.text = textDef;
                    inputF.ActivateInputField();
                }

                int srav = 0;
                string buf = "";
                for (int p = 0; p < 5; p++)
                {
                    buf =buf+ test.vic[p];
                }
                buf = buf.ToLower();
                //string buf = test.vic.ToLower();
                char[] mas1 = new char[buf.Length];
                for (int i = 0; i < buf.Length; i++)
                {
                    mas1[i] = buf[i];
                }
                if (textIn != "")
                {
                    string slovo = textIn;
                    slovo.ToLower();
                    if (slovo.ToLower() == buf.ToLower())
                    {
                        SceneManager.LoadScene("GameSecc");
                        tex2.hp = 0;
                    }
                    else
                    {
                        srav = 0;
                        char[] mas2 = new char[slovo.Length];
                        for (int i = 0; i < slovo.Length; i++)
                        {
                            mas2[i] = slovo[i];
                        }
                        bool checkPovtor = false;
                        List<char> list = mas2.ToList();
                        for (int j = 0; j < buf.Length; j++)
                        {
                            for (int p = 0; p < slovo.Length; p++)
                            {
                                if (mas1[j] == list[p])
                                {
                                    if (checkPovtor == false)
                                    {
                                        checkPovtor = true;
                                        srav++;
                                        list[p] = ' ';
                                    }
                                }
                            }
                            checkPovtor = false;
                        }
                        tex2.hp--;
                        if (tex2.hp != 0)
                        {
                            Hp.HP();
                            Srav.Sr(srav);
                            //новая попытка не проигрышь
                            //Console.Write("Likeness: ");
                            //Console.WriteLine(srav);

                        }
                        else
                        {
                            SceneManager.LoadScene("GameFail");
                            tex2.hp = 0;
                        }
                    }
                    textIn = "";
                }
            }
        }
    }
}
