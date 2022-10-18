using UnityEngine;
using UnityEngine.SceneManagement;
public class SalirMenu : MonoBehaviour
{
    public void salir_menu() {
        SceneManager.LoadScene("Menu");
    }

    public void reiniciar_nivel(){
        SceneManager.LoadScene("Runner");
    }

    public void siguiente_nivel(){
        SceneManager.LoadScene("Runner2");
    }
}
