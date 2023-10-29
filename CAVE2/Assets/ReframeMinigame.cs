using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.SceneManagement;

public class ReframeMinigame : MonoBehaviour
{

    [SerializeField] GameObject reframeEndingVoiceline;
    public AudioClip voiceline;
    AudioSource audioSource;



    public GameObject word1;
    public GameObject word2;

    public GameObject word3;


    bool w1 = false;
    bool w2 = false;
    bool w3 = false;

    bool gameWon = false;

    void Start() {
        audioSource = reframeEndingVoiceline.GetComponent<AudioSource>();
    }

    void Update() {
        if (word1.GetComponent<Collider>().enabled == false) {
            w1 = true;
        }
        if (word2.GetComponent<Collider>().enabled == false) {
            w2 = true;
        }
        if (word3.GetComponent<Collider>().enabled == false) {
            w3 = true;
        }

        if (w1 && w2 && w3) {
            
            if (!gameWon) {
                gameWon = true;
                audioSource.PlayOneShot(voiceline, 1F);
                StartCoroutine(MinigameWinCoroutine());
            }
            
        }
    }


    IEnumerator MinigameWinCoroutine() {
        yield return new WaitForSeconds(13.5f);

        SceneManager.LoadScene("Ending");
        
    }



}
