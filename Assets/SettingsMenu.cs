using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public Slider slider;
    public Toggle timerToggle;
    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdown;

    void Start() {
        slider.value = PlayerPrefs.GetFloat("volume");
        int showTime = PlayerPrefs.GetInt("showTime");
        Debug.Log("setting: " + showTime.ToString());
        timerToggle.isOn = showTime == 1 ? true : false;
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = resolutions.Length - 1; i >= 0; i--) {
            string option = resolutions[i].width + "x" + resolutions[i].height + "@" + resolutions[i].refreshRate + "Hz";
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height
             && resolutions[i].refreshRate == Screen.currentResolution.refreshRate) {
                currentResolutionIndex = resolutions.Length - 1 - i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex) {
        Resolution resolution = resolutions[resolutions.Length - 1 - resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen, resolution.refreshRate);
    }

    public void SetVolume(float volume) {
        PlayerPrefs.SetFloat("volume", volume);
    }

    public void SetFullscreen(bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
    }

    public void SetShowTimer(bool isShown) {
        PlayerPrefs.SetInt("showTime", (isShown ? 1 : 0));
    }
}
