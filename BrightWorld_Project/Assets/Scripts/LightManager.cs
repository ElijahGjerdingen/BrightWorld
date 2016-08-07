using UnityEngine;
using System.Collections;

public class LightManager : MonoBehaviour {

	public static double light = 100f;
	public static bool dark = false;

	// Use this for initialization
	void Start () {

		if (light <= 50f) 
		{

			dark = true;

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (light <= 50f) 
		{

			dark = true;

		}

		if (!dark) {

			light -= Time.deltaTime * 3.0;
		}

	}
}
