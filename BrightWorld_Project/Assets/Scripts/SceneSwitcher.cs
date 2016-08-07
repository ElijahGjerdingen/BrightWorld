using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

	private static double light;
	private static bool isDark;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		light = LightManager.light;
		isDark = LightManager.isDark;

		if (light <= 50f && !isDark) {
			SceneManager.LoadScene (1);
		}
		if (light >= 100f && isDark) {
			SceneManager.LoadScene (0);
			LightManager.isDark = false;
		}
		if (light <= 0f) {
			SceneManager.LoadScene (3);
			light = 1000;
			isDark = false;
		}
	}

	void Awake(){
		DontDestroyOnLoad (this);
		SceneManager.LoadScene (0);
	}

}
