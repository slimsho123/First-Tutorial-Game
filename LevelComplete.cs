using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel()
    {
        Debug.Log("Fucntion has been called!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Function has called the load scene function!");
        Debug.Log("If this function is called then next level should be loaded!");
        Debug.Log("Check console and code for error if code is not loaded");


    }
}
