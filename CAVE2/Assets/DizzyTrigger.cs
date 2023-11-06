using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DizzyTrigger : MonoBehaviour
{

    private AudioSource audioSource; // added whoosh audio

    
    [SerializeField] GameObject dizzyVoiceline;
    public AudioClip voiceline;

    AudioSource voicelineSource;

    bool hasTriggered;

    private void Start()
    {
        // Get the AudioSource component from this GameObject
        audioSource = GetComponent<AudioSource>();
        voicelineSource = dizzyVoiceline.GetComponent<AudioSource>();

        hasTriggered = false;
    }


    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && hasTriggered == false) {
            EventManager.OnDizzyTrigger();


            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }

            voicelineSource.PlayOneShot(voiceline, 1F);
            hasTriggered = true;

        }
    }


}
