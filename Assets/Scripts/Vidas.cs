using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Vidas : MonoBehaviour
{
    public TMP_Text vidas;
    public int numero_vidas = 3;

    void Start() {
        vidas.text = numero_vidas.ToString();
    }
    
    public void reduceVidas()
    {
        numero_vidas = numero_vidas - 1;
    }

    public void sumaVidas()
    {
        numero_vidas = numero_vidas + 1;
    }
    
    // Update is called once per frame
    void FixedUpdate() {
        vidas.text = numero_vidas.ToString();
    }
}
