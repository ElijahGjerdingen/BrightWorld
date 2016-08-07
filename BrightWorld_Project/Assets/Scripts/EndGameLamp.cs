using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGameLamp : MonoBehaviour {

    void OnTriggerStay2D(Collider2D thing)
    {
        if (thing.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            SceneManager.LoadScene(4);
        }
    }
    }
