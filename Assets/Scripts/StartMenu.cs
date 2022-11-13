using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    void Start() {
        int isFullscreen = PlayerPrefs.GetInt("isFullscreen");
        Screen.fullScreen = isFullscreen == 1 ? true : false;
    }
    public void QuitGame() {
        Application.Quit();
    }
}
