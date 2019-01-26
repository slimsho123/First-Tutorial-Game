using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //This is a refrence variable for the physics
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
    // Physics of the player and the movement
	void FixedUpdate ()
    {
        //Add a foward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -2.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
