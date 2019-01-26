
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeStart : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
