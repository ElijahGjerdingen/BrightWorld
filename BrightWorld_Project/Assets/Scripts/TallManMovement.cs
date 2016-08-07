using UnityEngine;
using System.Collections;

public class TallManMovement : MonoBehaviour {
    private bool leftHit = false;
    private Rigidbody2D rigidBody;
    public float speed = 5.0f;
    // Use this for initialization Hi
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(-5.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        rigidBody.velocity = new Vector2(-7.5f, -10.0f);
        if (leftHit == true)
        {
            rigidBody.velocity += new Vector2(7.5f, -10.0f);
        }
	}
}
