using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

	private static double light;
	private static bool isDark;
	private static bool gameover;

	// Use this for initialization
	void Start () {
		gameover = false;
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
		if (light <= 0f && !gameover) {
			gameover = true;
			SceneManager.LoadScene (3);
		}
	}

	void Awake(){
		DontDestroyOnLoad (this);
		SceneManager.LoadScene (0);
	}

}
