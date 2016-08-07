using UnityEngine;
using System.Collections;

public class BlobJump : MonoBehaviour {

    private bool grounded = false;
    float xSpeed = -3.0f;
    private Rigidbody2D rigidBody;
    private bool leftHit = false;
    [SerializeField] public float jumpForce = 350f;
    public float jumpHeight = 5.0f;

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(-3.0f, 3.0f); 
	}
    void OnCollisionEnter2D(Collision2D hit)
    {
        grounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (grounded)
        {
            rigidBody.velocity = (new Vector2(xSpeed, jumpHeight));
            
            grounded = false;
            if (leftHit == true)
            {
                rigidBody.velocity += new Vector2(7.5f, -10.0f);
            }
        }
    }
}
