using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input : MonoBehaviour
{
    public static bool chekInput = false;
    public static void InText()
    {
            GameObject externalObject = GameObject.Find("InputField");
            InputField inputField = externalObject.GetComponent<InputField>();
            inputField.ActivateInputField();
            chekInput = true;
        
    }
}

