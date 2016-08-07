using UnityEngine;
using System.Collections;

public class SpriteManagerPuffirhana : MonoBehaviour {

	public Sprite friendlySprite;
	public Sprite enemySprite;
	private bool isFriendly;

	// Use this for initialization
	void Start () {
		isFriendly = true;
	}

	void Awake(){
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
		if (LightManager.isDark && isFriendly) {
			GetComponent<SpriteRenderer>().sprite = enemySprite;
			isFriendly = false;
		} else {
			if (!LightManager.isDark && !isFriendly) {
				GetComponent<SpriteRenderer>().sprite = friendlySprite;
				isFriendly = true;
			}
		}
	}
}
