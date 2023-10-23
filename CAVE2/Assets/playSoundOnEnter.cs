using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundOnEnter : MonoBehaviour
{
    public AudioClip mySound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(mySound);
        }
    }
}
