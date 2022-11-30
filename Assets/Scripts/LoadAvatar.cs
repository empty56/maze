using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAvatar : MonoBehaviour
{
    Animator animator;
    public Avatar[] avatar;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        animator.avatar = avatar[selectedCharacter];
    }
}
