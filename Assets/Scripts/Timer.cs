using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    float currentTime;
    bool timerStarted;
    public String timeText;

    void Start() {
        currentTime = 0;
        bool timerStarted = false;
    }

    void Update() {
        if(timerStarted == true)
        {
            currentTime += Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timeText = time.ToString(@"mm\:ss\:fff");
    }
    public void StartTimer() {
        Debug.Log("Timer started");
        timerStarted = true;
    }    

    public void StopTimer() {
        Debug.Log("Timer stoped");
        Debug.Log(timeText);
        timerStarted = false;
    }    
}