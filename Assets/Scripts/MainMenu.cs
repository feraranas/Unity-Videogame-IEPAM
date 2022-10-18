using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void jugar_basketball(){
        SceneManager.LoadScene("MiniBasket");
    }

    public void jugar_runner(){
        SceneManager.LoadScene("Runner");
    }

    public void salir(){
        Debug.Log("Salir");
        Application.Quit();
    }
}
