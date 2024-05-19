using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue2Screen : MonoBehaviour
{
    Clues clues;
    Clue2 clue2;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue2 = FindObjectOfType<Clue2>();
        clues.gameObject.SetActive(true);
        clue2.gameObject.SetActive(false);
    }

    public void LoadScene2(){
        clues.gameObject.SetActive(false);
        clue2.gameObject.SetActive(true);
    }
}
