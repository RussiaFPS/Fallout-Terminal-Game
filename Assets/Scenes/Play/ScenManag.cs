using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenManag : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
