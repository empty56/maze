using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTimer : MonoBehaviour
{
    public Timer timer;
    private void OnTriggerEnter(Collider other) {
       timer.StopTimer();
    }
}