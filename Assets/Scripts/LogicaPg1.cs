using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaPg1 : MonoBehaviour
{

    public GameObject inputField;
    private int respuesta_correcta = 2;
    public TextMeshProUGUI respuesta;
    public GameManager gameManager;
    public Vidas vidas;
    public PlayerMovement playerMovement;
    private float Delay = 1f;
    private bool gameEnded = false;
    public GameObject puntaje;
    
    // Start is called before the first frame update
    void Start()
    {
        respuesta.text = "";
        
    }

    public void gameOver(){
        if (!gameEnded) {
            gameManager.pregunta1.SetActive(false);
            gameEnded = true;
            Debug.Log("Game Over");
            gameManager.MenuPerdiste(); 
        }
    }

    // Para respuestas
    public void caso_respuesta() {
        // Desaparece el panel de la pregunta
        gameManager.pregunta1.SetActive(false);

        // Abilita el player
        playerMovement.enabled = true;

        // Abilita el puntaje en el background
        puntaje.SetActive(true);
        
        Destroy(GameObject.FindWithTag("Obstacle1")); 
    }


    public void onButtonClick() {
        string texto = inputField.GetComponent<TMP_InputField>().text;
        if (texto != "") { 
            
            int answer = int.Parse(texto);
            
            if (answer == 1 || answer == 2 || answer == 3 || answer == 4) {
                if (answer == respuesta_correcta) {
                    // Despliega mensaje
                    respuesta.text = "¡Correcto! +1 Vida";
                    // Si la tiene correcta, llama a sumaVidas() y continua
                    vidas.sumaVidas();
                    Invoke("caso_respuesta", Delay);   
                } else {
                    // Despliega mensaje
                    respuesta.text = "¡Incorrecto!";
                    // Comprueba si se equivocó en su última oportunidad
                    if (vidas.numero_vidas == 0) Invoke("gameOver", Delay);
                    else Invoke("caso_respuesta", Delay);                      
                }
            }
            else {
                Debug.Log("No valido. Respuesta invalida.");
            }
        } else {
            Debug.Log("No valido. Ingresa un número");
        }
    }
}

