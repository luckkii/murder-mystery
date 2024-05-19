using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue3Screen : MonoBehaviour
{
    Clues clues;
    Clue3 clue3;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue3 = FindObjectOfType<Clue3>();
        clues.gameObject.SetActive(true);
        clue3.gameObject.SetActive(false);
    }
public void LoadScene3(){
        clues.gameObject.SetActive(false);
        clue3.gameObject.SetActive(true);
    }
}
