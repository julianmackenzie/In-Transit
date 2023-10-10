using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class DizzyScript : MonoBehaviour
{

    public bool doWobble = false;


    public Vector3 leftWobbleThreshold = new Vector3(0f, 0f, 45f);
    public Vector3 rightWobbleThreshold   = new Vector3(0f, 0f, 135f);
    public float wobbleSpeed;


    private void OnEnable() {
        EventManager.DizzyTrigger += EventManagerOnDizzyTrigger;
    }


    private void OnDisable() {
        EventManager.DizzyTrigger -= EventManagerOnDizzyTrigger;
    }


    private void EventManagerOnDizzyTrigger() {
        doWobble = true;
    }



    void Update() {
        if (doWobble) {
            float wobble = (Mathf.Sin (Time.time * wobbleSpeed * Mathf.PI * 2.0f) + 1.0f) / 2.0f;
            transform.eulerAngles = Vector3.Lerp(leftWobbleThreshold, rightWobbleThreshold, wobble);
        }
    }



}
