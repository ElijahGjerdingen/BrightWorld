using UnityEngine;
using System.Collections;

public class BlobJump : MonoBehaviour {

    private bool grounded = false;
    private Rigidbody2D rigidBody;
    private bool leftHit = false;
    [SerializeField] public float jumpForce = 350f;

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(-7.5f, 10.0f); 
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
            rigidBody.velocity = (new Vector2(0f, jumpForce));
            rigidBody.velocity = new Vector2(-7.5f, 10.0f);
            grounded = false;
            if (leftHit == true)
            {
                rigidBody.velocity += new Vector2(7.5f, -10.0f);
            }
        }
    }
}
