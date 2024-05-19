using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue8Screen : MonoBehaviour
{
    Clues clues;
    Clue8 clue8;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue8 = FindObjectOfType<Clue8>();
        clues.gameObject.SetActive(true);
        clue8.gameObject.SetActive(false);
    }

    public void LoadScreen8() {
        clues.gameObject.SetActive(false);
        clue8.gameObject.SetActive(true);
    }

}
