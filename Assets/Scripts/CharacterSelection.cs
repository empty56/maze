using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSelection : MonoBehaviour
{
public int selectedCharacter = 0;
public GameObject[] characters;

    void Start()
    {
        ChangeCharacter();
    }

    public void NextCharacte()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void SelectCharacter()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
    }

    public void ChangeCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        characters[selectedCharacter].SetActive(true);
    }
}