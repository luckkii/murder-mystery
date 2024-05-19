using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class murderFinder : MonoBehaviour
{
    Clues clues;
    BackgroundBulliten background;
    void Start()
    {
        background = FindObjectOfType<BackgroundBulliten>();
        clues = FindAnyObjectByType<Clues>();
    }

    public void solvedIt(){
        background.gameObject.SetActive(false);
        clues.gameObject.SetActive(false);
    }

}
