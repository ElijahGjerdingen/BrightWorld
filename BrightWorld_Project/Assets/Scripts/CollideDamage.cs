using UnityEngine;
using System.Collections;


public class CollideDamage : MonoBehaviour {

    private bool cooldown = false;
    private int time;

    // Use this for initialization
    void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (cooldown)
        {
            time++;
            if (time == 60)
            {
                time = 0;
                cooldown = false;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Dark_Monster") && !cooldown)
        {
            LightManager.light -= 10;
            cooldown = true;
        }
    }
}
