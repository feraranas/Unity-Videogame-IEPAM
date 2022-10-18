using UnityEngine;
using UnityEngine.SceneManagement; // To restart, reload or change scenes

public class PlayerCollision : MonoBehaviour
{   
    // A reference to our PlayerMovement script
    public PlayerMovement playerMovement;
    public GameManager gameManager;
    public Vidas vidas;
    public GameObject puntaje;
    private float Delay = 1f;
    private int collisionNum;

    public void crash_mecanics() {
            
        // Habilita una pregunta en la pantalla
        if (collisionNum == 0)  gameManager.pregunta0.SetActive(true);
        if (collisionNum == 1)  gameManager.pregunta1.SetActive(true);
        if (collisionNum == 2)  gameManager.pregunta2.SetActive(true);
        if (collisionNum == 3)  gameManager.pregunta3.SetActive(true);
        if (collisionNum == 4)  gameManager.pregunta4.SetActive(true);
        if (collisionNum == 5)  gameManager.pregunta5.SetActive(true);
        if (collisionNum == 6)  gameManager.pregunta6.SetActive(true);
        if (collisionNum == 7)  gameManager.pregunta7.SetActive(true);
        if (collisionNum == 8)  gameManager.pregunta8.SetActive(true);
        if (collisionNum == 9)  gameManager.pregunta9.SetActive(true);
        if (collisionNum == 10)  gameManager.pregunta10.SetActive(true);
        if (collisionNum == 11)  gameManager.pregunta11.SetActive(true);
        if (collisionNum == 12)  gameManager.pregunta12.SetActive(true);
        if (collisionNum == 13)  gameManager.pregunta13.SetActive(true);
        if (collisionNum == 14)  gameManager.pregunta14.SetActive(true);
        if (collisionNum == 15)  gameManager.pregunta15.SetActive(true);
        if (collisionNum == 16)  gameManager.pregunta16.SetActive(true);
        if (collisionNum == 17)  gameManager.pregunta17.SetActive(true);
        if (collisionNum == 18)  gameManager.pregunta18.SetActive(true);
        if (collisionNum == 19)  gameManager.pregunta19.SetActive(true);
        if (collisionNum == 20)  gameManager.pregunta20.SetActive(true);
        if (collisionNum == 21)  gameManager.pregunta0.SetActive(true);
        if (collisionNum == 22)  gameManager.pregunta1.SetActive(true);
        if (collisionNum == 23)  gameManager.pregunta2.SetActive(true);
        if (collisionNum == 24)  gameManager.pregunta3.SetActive(true);
        if (collisionNum == 25)  gameManager.pregunta4.SetActive(true);
        if (collisionNum == 26)  gameManager.pregunta6.SetActive(true);
        if (collisionNum == 27)  gameManager.pregunta7.SetActive(true);
        if (collisionNum == 28)  gameManager.pregunta8.SetActive(true);
        if (collisionNum == 29)  gameManager.pregunta9.SetActive(true);
        if (collisionNum == 30)  gameManager.pregunta10.SetActive(true);
        if (collisionNum == 31)  gameManager.pregunta11.SetActive(true);
        if (collisionNum == 32)  gameManager.pregunta12.SetActive(true);
        if (collisionNum == 33)  gameManager.pregunta13.SetActive(true);
        if (collisionNum == 34)  gameManager.pregunta14.SetActive(true);
        if (collisionNum == 35)  gameManager.pregunta15.SetActive(true);
        if (collisionNum == 36)  gameManager.pregunta16.SetActive(true);
        if (collisionNum == 37)  gameManager.pregunta17.SetActive(true);
        if (collisionNum == 38)  gameManager.pregunta18.SetActive(true);
        if (collisionNum == 39)  gameManager.pregunta19.SetActive(true);
        if (collisionNum == 40)  gameManager.pregunta20.SetActive(true);
    }


    public void funcion_aux(){
        vidas.reduceVidas(); // Reduce 1 vida por colisión

        puntaje.SetActive(false); // Desabilita el puntaje en el background
            
        Invoke("crash_mecanics", Delay);
    }

    // Unity function already written 'OnCollisionEnter'
    // Objects need to have a Rigidbody & Collider for this to work
    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag != "Ground") {
            // Disabilita el player
            playerMovement.enabled = false; // GetComponent<PlayerMovement>().enabled = false;
        }
        if (collisionInfo.collider.tag == "Obstacle") {
            Destroy(GameObject.FindWithTag("Obstacle"));
            collisionNum = 0;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle1") {
            Destroy(GameObject.FindWithTag("Obstacle1"));
            collisionNum = 1;
            funcion_aux();
        }  else if (collisionInfo.collider.tag == "Obstacle2") {
            Destroy(GameObject.FindWithTag("Obstacle2"));
            collisionNum = 2;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle3") {
            Destroy(GameObject.FindWithTag("Obstacle3"));
            collisionNum = 3;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle4") {
            Destroy(GameObject.FindWithTag("Obstacle4"));
            collisionNum = 4;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle5") {
            Destroy(GameObject.FindWithTag("Obstacle5"));
            collisionNum = 5;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle6") {
            Destroy(GameObject.FindWithTag("Obstacle6"));
            collisionNum = 6;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle7") {
            Destroy(GameObject.FindWithTag("Obstacle7"));
            collisionNum = 7;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle8") {
            Destroy(GameObject.FindWithTag("Obstacle8"));
            collisionNum = 8;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle9") {
            Destroy(GameObject.FindWithTag("Obstacle9"));
            collisionNum = 9;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle10") {
            Destroy(GameObject.FindWithTag("Obstacle10"));
            collisionNum = 10;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle11") {
            Destroy(GameObject.FindWithTag("Obstacle11"));
            collisionNum = 11;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle12") {
            Destroy(GameObject.FindWithTag("Obstacle12"));
            collisionNum = 12;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle13") {
            Destroy(GameObject.FindWithTag("Obstacle13"));
            collisionNum = 13;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle14") {
            Destroy(GameObject.FindWithTag("Obstacle14"));
            collisionNum = 14;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle15") {
            Destroy(GameObject.FindWithTag("Obstacle15"));
            collisionNum = 15;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle16") {
            Destroy(GameObject.FindWithTag("Obstacle16"));
            collisionNum = 16;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle17") {
            Destroy(GameObject.FindWithTag("Obstacle17"));
            collisionNum = 17;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle18") {
            Destroy(GameObject.FindWithTag("Obstacle18"));
            collisionNum = 18;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle19") {
            Destroy(GameObject.FindWithTag("Obstacle19"));
            collisionNum = 19;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle20") {
            Destroy(GameObject.FindWithTag("Obstacle20"));
            collisionNum = 20;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle21") {
            Destroy(GameObject.FindWithTag("Obstacle21"));
            collisionNum = 21;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle22") {
            Destroy(GameObject.FindWithTag("Obstacle22"));
            collisionNum = 22;
            funcion_aux();
        }  else if (collisionInfo.collider.tag == "Obstacle23") {
            Destroy(GameObject.FindWithTag("Obstacle23"));
            collisionNum = 23;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle24") {
            Destroy(GameObject.FindWithTag("Obstacle24"));
            collisionNum = 24;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle25") {
            Destroy(GameObject.FindWithTag("Obstacle25"));
            collisionNum = 25;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle26") {
            Destroy(GameObject.FindWithTag("Obstacle26"));
            collisionNum = 26;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle27") {
            Destroy(GameObject.FindWithTag("Obstacle27"));
            collisionNum = 27;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle28") {
            Destroy(GameObject.FindWithTag("Obstacle28"));
            collisionNum = 28;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle29") {
            Destroy(GameObject.FindWithTag("Obstacle29"));
            collisionNum = 29;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle30") {
            Destroy(GameObject.FindWithTag("Obstacle30"));
            collisionNum = 30;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle31") {
            Destroy(GameObject.FindWithTag("Obstacle31"));
            collisionNum = 31;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle32") {
            Destroy(GameObject.FindWithTag("Obstacle32"));
            collisionNum = 32;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle33") {
            Destroy(GameObject.FindWithTag("Obstacle33"));
            collisionNum = 33;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle34") {
            Destroy(GameObject.FindWithTag("Obstacle34"));
            collisionNum = 34;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle35") {
            Destroy(GameObject.FindWithTag("Obstacle35"));
            collisionNum = 35;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle36") {
            Destroy(GameObject.FindWithTag("Obstacle36"));
            collisionNum = 36;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle37") {
            Destroy(GameObject.FindWithTag("Obstacle37"));
            collisionNum = 37;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle38") {
            Destroy(GameObject.FindWithTag("Obstacle38"));
            collisionNum = 38;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle39") {
            Destroy(GameObject.FindWithTag("Obstacle39"));
            collisionNum = 39;
            funcion_aux();
        } else if (collisionInfo.collider.tag == "Obstacle40") {
            Destroy(GameObject.FindWithTag("Obstacle40"));
            collisionNum = 40;
            funcion_aux();
        }
    }
}
