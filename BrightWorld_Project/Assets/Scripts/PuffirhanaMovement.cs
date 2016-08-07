﻿using UnityEngine;
using System.Collections;

public class PuffirhanaMovement : MonoBehaviour {

    public float placex;
    public float placey;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float xSpeed = -3.0f;
    public float ySpeed = -0.5f;
    private bool leftHit = false;
    private bool rightHit = true;
    private Rigidbody2D rigidBody;
    public float speed = 5.0f;
    public GameObject gameObject;
    // Use this for initialization Hi
    void Start()
    {
        placex = gameObject.transform.position.x;
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(-3.0f, 0.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        placey = gameObject.transform.position.y;
        placex = gameObject.transform.position.x;
        if (placex >= maxX)
        {
            xSpeed = -3.0f;
            rigidBody.velocity = new Vector2(xSpeed, ySpeed);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (placex <= minX)
        {
            xSpeed = 3.0f;
            rigidBody.velocity = new Vector2(xSpeed, ySpeed);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        
        if (placey >= maxY)
        {
            ySpeed = -0.5f;
            rigidBody.velocity = new Vector2(xSpeed, ySpeed);
        }
        if (placey <= minY)
        {
            ySpeed = 0.5f;
            rigidBody.velocity = new Vector2(xSpeed, ySpeed);
        }
    }
}
