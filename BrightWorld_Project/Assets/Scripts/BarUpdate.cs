using UnityEngine;
using System.Collections;

public class BarUpdate : MonoBehaviour {

	public UnityEngine.UI.Slider healthBarSlider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		healthBarSlider.value = (float) LightManager.light / 100f;
	}
}
