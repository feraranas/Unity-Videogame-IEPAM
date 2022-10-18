using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBasket : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("MiniBasket");
    }

    public void regresarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
