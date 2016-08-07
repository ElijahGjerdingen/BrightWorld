using UnityEngine;
using System.Collections;

public class TallManMovement : MonoBehaviour {
    private bool leftHit = false;
    private Rigidbody2D rigidBody;
    public float speed = -2.0f;
    // Use this for initialization Hi
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(speed, 0.0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateMovement();
        
    }

    private void UpdateMovement()
    {
        rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
        Debug.Log(rigidBody.velocity.ToString());
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            speed = -speed;
            transform.localScale = new Vector3((transform.localScale.x * -1), transform.localScale.y, transform.localScale.z);
            Debug.Log(speed.ToString());
        }
    }
}
