using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public TextMeshProUGUI level1score;
    public Image level1stars;
    public Sprite oneStarSprite;
    public Sprite twoStarsSprite;
    public Sprite threeStarsSprite;

    void Start () {
        if (PlayerPrefs.HasKey("bestTime1") && PlayerPrefs.HasKey("bestStars1")) {
            float bestTime1 = PlayerPrefs.GetFloat("bestTime1");
            float bestStars1 = PlayerPrefs.GetInt("bestStars1");
            TimeSpan timeSpan1 = TimeSpan.FromSeconds(bestTime1);
            level1score.text = "HIGH SCORE: " + timeSpan1.ToString("mm':'ss':'ff");
            if (bestStars1 == 1) {
                level1stars.sprite = oneStarSprite;
            } else if (bestStars1 == 2) {
                level1stars.sprite = twoStarsSprite;
            } else {
                level1stars.sprite = threeStarsSprite;
            }
        }
	}

    public void StartLevel1() {
        SceneManager.LoadScene("Level_1");
    }
}
