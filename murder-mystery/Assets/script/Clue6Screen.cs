using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue6Screen : MonoBehaviour
{
    Clues clues;
    Clue6 clue6;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue6 = FindObjectOfType<Clue6>();
        clues.gameObject.SetActive(true);
        clue6.gameObject.SetActive(false);
    }

    public void LoadScreen6() {
        clues.gameObject.SetActive(false);
        clue6.gameObject.SetActive(true);
    }
}
