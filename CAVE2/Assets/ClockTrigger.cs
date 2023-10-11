using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClockTrigger : MonoBehaviour
{

    [SerializeField] GameObject clock;
    [SerializeField] GameObject clockPromptText;

    [SerializeField] GameObject trainEnterZone;

 

    public GameObject trainObject;

    public float trainSpeed = 1.0f;

    Vector3 trainStopPosition = new Vector3(0, 2.25f, 7);  // position for train to stop at
    bool trainMove = false;  // Starting flag for train entering scene


    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            clock.SetActive(true);

            

            //clockPromptText.SetActive(false);

            trainMove = true;


        }
        
    }


    void Update() {
        if (trainMove) {
            trainObject.transform.position = Vector3.Lerp (trainObject.transform.position, trainStopPosition, Time.deltaTime * trainSpeed);  // move train into view
        }
        

    if (Vector3.Distance (trainObject.transform.position, trainStopPosition) < 0.02 && trainMove)  // stop train when it's in position and allow it to be entered
        trainMove = false;
        trainEnterZone.SetActive(true);

    }


}
