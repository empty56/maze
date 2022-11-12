using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public void StartLevel1() {
        SceneManager.LoadScene("Level_1");
    }
}
