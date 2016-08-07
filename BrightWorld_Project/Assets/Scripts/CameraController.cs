using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	GameObject player;
	public float horizontalFollow;
	public float verticalFollow;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update()
	{

		player = GameObject.FindGameObjectWithTag("Player");
		if (player.transform.position.x > transform.position.x)
		{
			if (player.transform.position.x > transform.position.x + horizontalFollow)
			{
				transform.position = new Vector3(player.transform.position.x - horizontalFollow, transform.position.y, transform.position.z);
			}
		}
		else if (player.transform.position.x < transform.position.x)
		{
			if (player.transform.position.x < transform.position.x - horizontalFollow)
			{
				transform.position = new Vector3(player.transform.position.x + horizontalFollow, transform.position.y, transform.position.z);
			}
		}

		if (player.transform.position.y > transform.position.y)
		{
			if (player.transform.position.y > transform.position.y + verticalFollow)
			{
				transform.position = new Vector3(transform.position.x, player.transform.position.y - verticalFollow, transform.position.z);
			}
		}
		else if (player.transform.position.y < transform.position.y)
		{
			if (player.transform.position.y < transform.position.y - verticalFollow)
			{
				transform.position = new Vector3(transform.position.x, player.transform.position.y + verticalFollow, transform.position.z);
			}
		}

	}

}
