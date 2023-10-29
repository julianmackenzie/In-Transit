using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitPromptTrigger : MonoBehaviour
{


    [SerializeField] GameObject sitVoiceline;
    public AudioClip voiceline;

    AudioSource audioSource;

    // Start is called before the first frame update



    void Start() {
        audioSource = sitVoiceline.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {

            audioSource.PlayOneShot(voiceline, 1F);


        }

    }

}
