using UnityEngine;
using System.Collections;

public class Killzone : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        LightManager.light = 0;
    }
}
