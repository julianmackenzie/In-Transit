using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitPromptTrigger : MonoBehaviour
{


    [SerializeField] GameObject sitVoiceline;
    public AudioClip voiceline;

    AudioSource audioSource;

    bool hasTriggered;


    void Start() {
        audioSource = sitVoiceline.GetComponent<AudioSource>();
        hasTriggered = false;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && hasTriggered == false) {

            audioSource.PlayOneShot(voiceline, 1F);
            hasTriggered = true;


        }

    }

}
