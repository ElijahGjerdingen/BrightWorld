using UnityEngine;
using System.Collections;

public class SpriteManagerBlumper : MonoBehaviour {

	public Sprite friendlySprite;
	public Sprite enemySprite;
	private bool isFriendly;
    private Animator anim;

	// Use this for initialization
	void Start () {
		isFriendly = true;
        anim = GetComponent<Animator>();
    }

	void Awake(){
		DontDestroyOnLoad (this);
	}

	// Update is called once per frame
	void Update () {
		if (LightManager.isDark && isFriendly) {
            anim.SetTrigger("Dark");
            isFriendly = false;
			gameObject.layer = 13;
		} else {
			if (!LightManager.isDark && !isFriendly) {
				anim.SetTrigger("Light");
				isFriendly = true;
				gameObject.layer = 9;
			}
		}
	}
}
