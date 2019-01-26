using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    
    public PlayerMovement movement;

     


    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Obstacles")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
