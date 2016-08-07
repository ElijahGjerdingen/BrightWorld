using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LightManager : MonoBehaviour {

    public Text lightTracker;
	public static double light = 100f;
	public static bool isDark = false;
	public double lightMoniter = light;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (lightTracker != null)
            lightTracker.text = (light/10) + " / " + "10";
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
