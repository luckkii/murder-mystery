using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    Clues clues;
    Clue1 clue1;
    DeClue1 declue1;
    
    void Start()
    {   
        clues = FindObjectOfType<Clues>();
        clue1 = FindObjectOfType<Clue1>();
        declue1 = FindObjectOfType<DeClue1>();
        clues.gameObject.SetActive(true);
        clue1.gameObject.SetActive(false);  
        declue1.gameObject.SetActive(false);
    }

    public void LoadDecrypt() {    
        clues.gameObject.SetActive(false);
        clue1.gameObject.SetActive(true);
        declue1.gameObject.SetActive(true);
    }

    public void LoadClue() {
        clues.gameObject.SetActive(false);
        clue1.gameObject.SetActive(true);
    }
}
