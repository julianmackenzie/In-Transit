using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClockTrigger : MonoBehaviour
{

    [SerializeField] GameObject clock;
    [SerializeField] GameObject clockPromptText;



    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            clock.SetActive(true);
            clockPromptText.SetActive(false);
            Destroy(gameObject);
        }
        
    }


}
