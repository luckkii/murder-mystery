using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    Clues clues;
    Clue1 clue1;
    
    void Start()
    {   
        clues = FindObjectOfType<Clues>();
        clue1 = FindObjectOfType<Clue1>();
        clues.gameObject.SetActive(true);
        clue1.gameObject.SetActive(false);  
    }

    public void LoadScene(){    
        clues.gameObject.SetActive(false);
        clue1.gameObject.SetActive(true);
    }
}
