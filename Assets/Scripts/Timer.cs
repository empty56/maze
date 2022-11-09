using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    float currentTime;
    public bool timerStarted;
    public float time;

    void Start() {
        currentTime = 0;
        bool timerStarted = false;
    }

    void Update() {
        if(timerStarted == true)
        {
            currentTime += Time.deltaTime;
        }
    }
    public void StartTimer() {
        Debug.Log("Timer started");
        timerStarted = true;
    }    

    public void StopTimer() {
        Debug.Log("Timer stoped");
        time = currentTime;
        currentTime = 0;
        timerStarted = false;
    }    
}