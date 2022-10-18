using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteComponent : MonoBehaviour
{
    public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
