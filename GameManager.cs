using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    float restartDelay = 1.5f;

    public void CompleteLevel()
    {
        Debug.Log("Level WON!");
        completeLevelUI.SetActive(true);


    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            //Restart Game
            Invoke("Restart", restartDelay);

        }
    }
    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    
            
    
    
}
