using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue6Screen : MonoBehaviour
{
    Clues clues;
    Clue6 clue6;
    DeClue6 deClue6;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue6 = FindObjectOfType<Clue6>();
        deClue6 = FindObjectOfType<DeClue6>();
        clues.gameObject.SetActive(true);
        clue6.gameObject.SetActive(false);
        deClue6.gameObject.SetActive(false);
    }

    public void LoadScreen6() {
        clues.gameObject.SetActive(false);
        clue6.gameObject.SetActive(true);
        deClue6.gameObject.SetActive(true);
    }
}
