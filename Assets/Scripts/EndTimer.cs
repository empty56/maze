using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EndTimer : MonoBehaviour
{
    public Timer timer;
    public Stars stars;

    private void OnTriggerEnter(Collider other) {

        if(timer.timerStarted == true)
        {
            timer.StopTimer();
            TimeSpan time = TimeSpan.FromSeconds(timer.time);
            Debug.Log(time.ToString(@"mm\:ss\:fff"));
            stars.UpdateBestTime(timer.time, 1);
        }
    }
}