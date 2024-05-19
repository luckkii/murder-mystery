using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue5Screen : MonoBehaviour
{
    Clues clues;
    Clue5 clue5;
    DeClue5 deClue5;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue5 = FindObjectOfType<Clue5>();
        deClue5 = FindObjectOfType<DeClue5>();
        clues.gameObject.SetActive(true);
        clue5.gameObject.SetActive(false);
        deClue5.gameObject.SetActive(false);
    }

    public void LoadScreen5() {
        clues.gameObject.SetActive(false);
        clue5.gameObject.SetActive(true);
        deClue5.gameObject.SetActive(true);
    }

}
