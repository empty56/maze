using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    public Timer timer;
    private void OnTriggerEnter(Collider other) {
       timer.StartTimer();
    }
}