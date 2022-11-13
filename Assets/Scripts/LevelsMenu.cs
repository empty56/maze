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
    public TextMeshProUGUI level2score;
    public Image level2stars;
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
        if (PlayerPrefs.HasKey("bestTime2") && PlayerPrefs.HasKey("bestStars2")) {
            float bestTime2 = PlayerPrefs.GetFloat("bestTime2");
            float bestStars2 = PlayerPrefs.GetInt("bestStars2");
            TimeSpan timeSpan2 = TimeSpan.FromSeconds(bestTime2);
            level2score.text = "HIGH SCORE: " + timeSpan2.ToString("mm':'ss':'ff");
            if (bestStars2 == 1) {
                level2stars.sprite = oneStarSprite;
            } else if (bestStars2 == 2) {
                level2stars.sprite = twoStarsSprite;
            } else {
                level2stars.sprite = threeStarsSprite;
            }
        }
	}

    public void StartLevel1() {
        SceneManager.LoadScene("Level_1");
    }

    public void StartLevel2() {
        SceneManager.LoadScene("Level_2");
    }
}
