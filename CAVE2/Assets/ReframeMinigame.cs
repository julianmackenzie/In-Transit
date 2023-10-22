using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.SceneManagement;

public class ReframeMinigame : MonoBehaviour
{

    public GameObject word1;
    public GameObject word2;

    public GameObject word3;


    bool w1 = false;
    bool w2 = false;
    bool w3 = false;

    bool gameWon = false;

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
                StartCoroutine(MinigameWinCoroutine());
            }
            
        }
    }


    IEnumerator MinigameWinCoroutine() {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Ending");
        
    }



}
