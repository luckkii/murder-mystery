using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue4Screen : MonoBehaviour
{
    Clues clues;
    Clue4 clue4;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue4 = FindObjectOfType<Clue4>();
        clues.gameObject.SetActive(true);
        clue4.gameObject.SetActive(false);
    }

    public void LoadScreen4() {
        clues.gameObject.SetActive(false);
        clue4.gameObject.SetActive(true);
    }

}
