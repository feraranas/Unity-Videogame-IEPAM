using UnityEngine;
using UnityEngine.SceneManagement; // To restart, reload or change scenes
//using System.Collections; // stack
using System;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject gameOverUI;
    public Vidas vidas;


    // 20 preguntas por nivel
    public GameObject pregunta0;
    public GameObject pregunta1;
    public GameObject pregunta2;
    public GameObject pregunta3;
    public GameObject pregunta4;
    public GameObject pregunta5;
    public GameObject pregunta6;
    public GameObject pregunta7;
    public GameObject pregunta8;
    public GameObject pregunta9;
    public GameObject pregunta10;
    public GameObject pregunta11;
    public GameObject pregunta12;
    public GameObject pregunta13;
    public GameObject pregunta14;
    public GameObject pregunta15;
    public GameObject pregunta16;
    public GameObject pregunta17;
    public GameObject pregunta18;
    public GameObject pregunta19;
    public GameObject pregunta20;


    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    public void MenuPerdiste() {
        gameOverUI.SetActive(true);
    }

    
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Reload() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
