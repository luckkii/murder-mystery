using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clue1Button : MonoBehaviour
{
    Clues clues;
    Clue1 clue1;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue1 = FindObjectOfType<Clue1>();

        clue1.gameObject.SetActive(true);
        clues.gameObject.SetActive(false);
    }

    public void Clue1(){
        
    }
    
}
