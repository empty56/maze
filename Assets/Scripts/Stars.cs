using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public float bestTime;
    public int stars;
    
    void Start() {
        bestTime = 0;
        stars = 0;
    }

    private void UpdateStars(int level) {
        if(level == 1)
        {
            if(bestTime > 90)
            {
                stars = 1;
            }
            else if(bestTime < 40)
            {
                stars = 3;
            }
            else{
                stars = 2;
            }
            Debug.Log("Start updated: " + stars);
        }
        else if(level == 2)
        {
            if(bestTime > 120)
            {
                stars = 1;
            }
            else if(bestTime < 60)
            {
                stars = 3;
            }
            else{
                stars = 2;
            }
        }
    }

    public void UpdateBestTime(float newBestTIme, int level) {
        if(newBestTIme < bestTime || bestTime == 0)
        {
            bestTime = newBestTIme;
            Debug.Log("Best time updated: " + bestTime);
            UpdateStars(level);
        }
    }   
    
}