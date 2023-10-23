using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitPromptTrigger : MonoBehaviour
{

    [SerializeField] GameObject dizzyPromptText;
    [SerializeField] GameObject sitPromptText;

    // Start is called before the first frame update

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {

            dizzyPromptText.SetActive(false);
            sitPromptText.SetActive(true);

        }

    }

}
