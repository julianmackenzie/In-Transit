using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DizzyTrigger : MonoBehaviour
{
    public GameObject overwhelmedPromptText;
    public GameObject dizzyPromptText;


    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            EventManager.OnDizzyTrigger();

            overwhelmedPromptText.SetActive(false);
            dizzyPromptText.SetActive(true);

        }
    }


}
