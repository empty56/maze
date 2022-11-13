using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPanel : MonoBehaviour
{
    public GameObject timerPanel;
    void Start()
    {
        int showTime = PlayerPrefs.GetInt("showTime");
        if (showTime == 0) {
            timerPanel.SetActive(false);
        }
    }
}
