using UnityEngine;
using System.Collections;

public class LightPostHeal : MonoBehaviour {

	private float healVal;

	// Use this for initialization
	void Start () {

		healVal = 30f;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D thing){
	
		if (thing.gameObject.layer == LayerMask.NameToLayer ("Player") && healVal > 0) {

			float val = 30f / 3 * Time.deltaTime;
			LightManager.light += val;
			healVal -= val;

		}
	
	}

}
