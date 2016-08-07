using UnityEngine;
using System.Collections;

public class LightManager : MonoBehaviour {

	public static double light = 100f;
	public static bool isDark = false;
	public double lightMoniter = light;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		lightMoniter = light;
		if (light <= 50f) 
		{

			isDark = true;

		}
			

		if (!isDark) {

			light -= Time.deltaTime * 3.0;
		}

	}
}
