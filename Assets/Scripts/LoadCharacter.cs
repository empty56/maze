using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
    Animator animator;
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    public TMP_Text label;

    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = characterPrefabs[selectedCharacter];
        GameObject clone = Instantiate(prefab);
        prefab.SetActive(true);
        label.text = prefab.name;
    }
}
