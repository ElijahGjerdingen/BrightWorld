using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    float x = 0.0f;
    float y = 0.0f;

    bool jump = false;              // Condition for whether the player should jump.	
    [SerializeField] private bool grounded = false;
    private bool stillGrounded = false;
    private Rigidbody2D rigidBody;          // Reference to the player's rigidbody
    private Animator anim;					// Reference to the player's animator component.
    private double time;

    [SerializeField] public float speed = 0f;           // Speed the player runs
    [SerializeField] public float jumpForce = 0f;       // Amount of force added when the player jumps.

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    } // End Start()

    // Update is called once per frame
    void Update () 
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") == -1)
        {
            rigidBody.velocity = new Vector2(-speed, rigidBody.velocity.y);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("Run", true);
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetAxis("Horizontal") == 1)
        {
            rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run",false);
        }

        if ( ( Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0) ) && grounded)
        {
            rigidBody.velocity = (new Vector2(0f, jumpForce));
            grounded = false;
            anim.SetTrigger("Jump");
            anim.SetBool("Grounded", false);
        }
    } // End Update()

    void OnCollisionStay2D(Collision2D hit)
    {
        grounded = true;
        stillGrounded = true;
        anim.SetBool("Grounded", true);
    } // End OnCollisionEnter2D()
   
}
