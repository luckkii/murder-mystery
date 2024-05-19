using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using UnityEngine;

public class Clue7Screen : MonoBehaviour
{
    Clues clues;
    Clue7 clue7;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue7 = FindObjectOfType<Clue7>();
        clues.gameObject.SetActive(true);
        clue7.gameObject.SetActive(false);
    }

    public void LoadScreen7() {
        clues.gameObject.SetActive(false);
        clue7.gameObject.SetActive(true);
    }
}
