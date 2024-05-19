using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue4Screen : MonoBehaviour
{
    Clues clues;
    Clue4 clue4;
    DeClue4 deClue4;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue4 = FindObjectOfType<Clue4>();
        deClue4 = FindObjectOfType<DeClue4>();
        clues.gameObject.SetActive(true);
        clue4.gameObject.SetActive(false);
        deClue4.gameObject.SetActive(false);
    }

    public void LoadScreen4() {
        clues.gameObject.SetActive(false);
        clue4.gameObject.SetActive(true);
        deClue4.gameObject.SetActive(true);
    }

}
