using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

	private static double light;
	private static bool dark;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		light = LightManager.light;
		dark = LightManager.dark;

		if (light <= 50f && !dark) {
			SceneManager.LoadScene (1);
		}
		if (light >= 100f && dark) {
			SceneManager.LoadScene (0);
		}
	}

	void Awake(){
		DontDestroyOnLoad (this);
	}

}
