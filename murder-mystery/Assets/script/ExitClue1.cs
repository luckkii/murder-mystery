using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitClue1 : MonoBehaviour
{
    Clues clues;
    Clue1 clue1;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue1 = FindObjectOfType<Clue1>();

        clues.gameObject.SetActive(true);
        
    }

}
