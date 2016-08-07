using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    float x = 0.0f;
    float y = 0.0f;

    [SerializeField]
    bool jump = false;              // Condition for whether the player should jump.	
    public float jumpForce = 1000.0f;        // Amount of force added when the player jumps.
    public bool gamestarted = false;        // Is the player currently running?
    private bool grounded = false;          // Whether or not the player is grounded.
    private Rigidbody2D rigidBody;			// Reference to the player's rigidbody

    public float speed = 0.01f;
    public float jumpHeight = 2.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Space) && grounded == true)
        {
            transform.position += Vector3.up * jumpHeight;
            grounded = false;
        }
	}
    void OnCollisionEnter2D(Collision2D hit)
    {
        grounded = true;
    }
}
