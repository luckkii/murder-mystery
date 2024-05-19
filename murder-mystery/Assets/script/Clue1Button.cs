using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clue1Button : MonoBehaviour
{
    Clues clues;
    Clue1 clue1;
    Clue2 clue2;
    Clue3 clue3;
    Clue4 clue4;
    Clue5 clue5;
    Clue6 clue6;
    Clue8 clue8;
    // Notebook notebook;

    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue1 = FindObjectOfType<Clue1>();
        clue2 = FindObjectOfType<Clue2>();
        clue3 = FindObjectOfType<Clue3>();
        clue4 = FindObjectOfType<Clue4>();
        clue5 = FindObjectOfType<Clue5>();
        clue6 = FindObjectOfType<Clue6>();
        clue8 = FindObjectOfType<Clue8>();
        // notebook = FindObjectOfType<Notebook>();
        // notebook.gameObject.SetActive(true);
    }

    public void goHome(){
        clues.gameObject.SetActive(true);
        clue1.gameObject.SetActive(false);
        clue2.gameObject.SetActive(false);
        clue3.gameObject.SetActive(false);
        clue4.gameObject.SetActive(false);
        clue5.gameObject.SetActive(false);
        clue6.gameObject.SetActive(false);
        clue8.gameObject.SetActive(false);
        Debug.Log("grah");
        // notebook.gameObject.SetActive(false);
        Debug.Log("heloeoeoeooee");
    }
    
}