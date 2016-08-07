using UnityEngine;
using System.Collections;

public class SpriteManagerPlayer : MonoBehaviour {

	public Sprite happyFace;
	public Sprite scaredFace;
	private bool isHappy;

	// Use this for initialization
	void Start () {
		isHappy = true;
	}
		
	// Update is called once per frame
	void Update () {
		if (LightManager.isDark && isHappy) {
			GetComponent<SpriteRenderer>().sprite = scaredFace;
			isHappy = false;
		} else {
			if (!LightManager.isDark && !isHappy) {
				GetComponent<SpriteRenderer>().sprite = happyFace;
				isHappy = true;
			}
		}
	}
}
