using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text score;

    void Start() {
        score.text = "";
    }
    
    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0");
    }
}
