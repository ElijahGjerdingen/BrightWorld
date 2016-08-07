using UnityEngine;
using System.Collections;

public class Killzone : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            LightManager.light = 0;
        }
    }
}
