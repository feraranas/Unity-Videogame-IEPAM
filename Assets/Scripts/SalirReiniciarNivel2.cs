using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirReiniciarNivel2 : MonoBehaviour
{
    public void salir_menu() {
        SceneManager.LoadScene("Menu");
    }

    public void reiniciar_nivel(){
        SceneManager.LoadScene("Runner2");
    }
}
