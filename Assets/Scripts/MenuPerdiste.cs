using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPerdiste : MonoBehaviour
{
    public void regresar_menu() {
        SceneManager.LoadScene("Menu");
    }
    public void reintentar() {
        SceneManager.LoadScene("Runner");
    }
}
