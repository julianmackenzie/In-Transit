using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdChatterScript : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioSource audioSource; // added whoosh audio

    private void Start()
    {
        // Get the AudioSource component from this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {

            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }

        }
    }
}
