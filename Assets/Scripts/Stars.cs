using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Stars : MonoBehaviour
{

    public TextMeshProUGUI textMesh;
    public GameObject endPanel;
    public Image starsImage;
    public Sprite oneStarSprite;
    public Sprite twoStarsSprite;
    public Sprite threeStarsSprite;
    public GameObject player;

    private int GetStars(int level, float time) {
        int stars = 0;
        if(level == 1)
        {
            if(time > 90)
            {
                stars = 1;
            }
            else if(time < 40)
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
            if(time > 400)
            {
                stars = 1;
            }
            else if(time < 180)
            {
                stars = 3;
            }
            else{
                stars = 2;
            }
        }
        else if(level == 3)
        {
            if(time > 150)
            {
                stars = 1;
            }
            else if(time < 100)
            {
                stars = 3;
            }
            else{
                stars = 2;
            }
        }
        return stars;
    }

    public void UpdateBestTime(float time, int level) {
        int stars = GetStars(level, time);
        
        if (stars == 1) {
            starsImage.sprite = oneStarSprite;
        } else if (stars == 2) {
            starsImage.sprite = twoStarsSprite;
        } else {
            starsImage.sprite = threeStarsSprite;
        }

        if(!PlayerPrefs.HasKey("bestTime" + level.ToString()) || time < PlayerPrefs.GetFloat("bestTime" + level.ToString()))
        {
            PlayerPrefs.SetFloat("bestTime" + level.ToString(), time);
            Debug.Log("Best time updated: " + time);
            PlayerPrefs.SetInt("bestStars" + level.ToString(), stars);
        }

        endPanel.SetActive(!endPanel.activeSelf);
        Cursor.visible = true; 
        TimeSpan timeSpan = TimeSpan.FromSeconds(time);
        textMesh.text = "Congratulations, you've finished the level in " + timeSpan.ToString("mm':'ss':'ff") + "!\nHere is your rating:";
        player.SetActive(false);
    }   

    public void BackToMainMenu() {
        SceneManager.LoadScene(0);
    }
    
}