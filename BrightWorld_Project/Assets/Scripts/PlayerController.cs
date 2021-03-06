﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    float x = 0.0f;
    float y = 0.0f;

    bool jump = false;              // Condition for whether the player should jump.	
    public bool gamestarted = false;        // Is the player currently running?
    [SerializeField] private bool grounded = false;          // Whether or not the player is grounded.
    private Rigidbody2D rigidBody;          // Reference to the player's rigidbody
    private Animator anim;					// Reference to the player's animator component.

    [SerializeField] public float speed = 0f;
    [SerializeField] public float maxSpeed = 0f;
    [SerializeField] public float jumpForce = 0f;        // Amount of force added when the player jumps.

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () 
    {
	    if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") == -1)
        {
            if(speed < maxSpeed) {
                speed += 0.5f;
            }

            rigidBody.velocity = new Vector2(-speed, rigidBody.velocity.y);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("Running", true);
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetAxis("Horizontal") == 1)
        {
            if (speed < maxSpeed)
            {
                speed += 0.5f;
            }

            rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
            if(speed > 0){
                speed -= 0.5f;
            }
        }

        if ( ( Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0) ) && grounded)
        {
            rigidBody.velocity = (new Vector2(0f, jumpForce));
            grounded = false;
            anim.SetBool("Grounded", false);
            anim.SetTrigger("Jump");
        }
	}
    void OnCollisionEnter2D(Collision2D hit)
    {
        grounded = true;
        anim.SetBool("Grounded", true);

    }
}
