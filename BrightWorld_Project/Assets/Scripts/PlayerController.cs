using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    float x = 0.0f;
    float y = 0.0f;

    bool jump = false;              // Condition for whether the player should jump.	
    public bool gamestarted = false;        // Is the player currently running?
    private bool grounded = false;          // Whether or not the player is grounded.
    private Rigidbody2D rigidBody;			// Reference to the player's rigidbody

    [SerializeField] public float speed = 0f;
    [SerializeField] public float jumpForce = 0f;        // Amount of force added when the player jumps.

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () 
    {
	    if(Input.GetKey(KeyCode.A))
        {
            rigidBody.velocity = new Vector2(-speed, rigidBody.velocity.y);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
        }
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            rigidBody.AddForce(new Vector2(0f, jumpForce));
            grounded = false;
        }
	}
    void OnCollisionEnter2D(Collision2D hit)
    {
        grounded = true;
    }
}
