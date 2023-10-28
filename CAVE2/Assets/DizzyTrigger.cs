using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DizzyTrigger : MonoBehaviour
{
    public GameObject overwhelmedPromptText;
    public GameObject dizzyPromptText;

    private AudioSource audioSource; // added whoosh audio

    private void Start()
    {
        // Get the AudioSource component from this GameObject
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            EventManager.OnDizzyTrigger();

            overwhelmedPromptText.SetActive(false);
            dizzyPromptText.SetActive(true);

            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }

        }
    }


}
