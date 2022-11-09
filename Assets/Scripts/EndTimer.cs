using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EndTimer : MonoBehaviour
{
    public Timer timer;
    public Stars stars;
    private String sceneName;

    // private void Start()
    // {
    //     m_Scene = SceneManager.GetActiveScene();
    //     sceneName = m_Scene.name;
    // }

    private void OnTriggerEnter(Collider other) {
        //after level menu code here

        if(timer.timerStarted == true)
        {
            timer.StopTimer();
            TimeSpan time = TimeSpan.FromSeconds(timer.time);
            Debug.Log(time.ToString(@"mm\:ss\:fff"));
            // int level = Int32.Parse(sceneName.Substring(6));
            stars.UpdateBestTime(timer.time, 1);
        }
    }
}