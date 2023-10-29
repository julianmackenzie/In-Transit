using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingClockTrigger : MonoBehaviour
{

    [SerializeField] GameObject clock;
    
    [SerializeField] GameObject trainPromptVoiceline;

    public AudioClip voiceline;
    public AudioClip trainsound;
    
    AudioSource audioSource;


 

    public GameObject trainObject;

    public float trainSpeed = 1.0f;

    Vector3 trainStopPosition = new Vector3(0, 2.25f, 7);  // position for train to stop at
    
    bool trainMove = false;  // Starting flag for train entering scene


    void Start() {
        audioSource = trainPromptVoiceline.GetComponent<AudioSource>();
    }

    bool audioPlayed = false;

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            clock.SetActive(true);

            if (audioPlayed == false) {
                audioSource.PlayOneShot(voiceline, 1F);
                
                audioPlayed = true;
                StartCoroutine(TrainArrive());
            }
            

        }
        
    }

    IEnumerator TrainArrive() {
        yield return new WaitForSeconds(14);
        trainMove = true;
        audioSource.PlayOneShot(trainsound, 0.6F);
    }



    void Update() {
        if (trainMove) {
            trainObject.transform.position = Vector3.Lerp (trainObject.transform.position, trainStopPosition, Time.deltaTime * trainSpeed);  // move train into view
        }
        


        if (Vector3.Distance (trainObject.transform.position, trainStopPosition) < .2 && trainMove) {
            // stop train when it's in position and allow it to be entered
            trainMove = false;
        }  

    }


}
