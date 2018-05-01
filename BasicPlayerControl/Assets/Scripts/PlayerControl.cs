﻿using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
