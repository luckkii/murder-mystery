using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    Clues clues;
    Notebook notebook;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        notebook = FindObjectOfType<Notebook>();

        clues.gameObject.SetActive(true);
        notebook.gameObject.SetActive(false);
    }

    public void LoadNotes(){
        if (clues.gameObject.activeSelf) {
            clues.gameObject.SetActive(false);
            notebook.gameObject.SetActive(true);
        }
        else {
            clues.gameObject.SetActive(true);
            notebook.gameObject.SetActive(false);
        }
    }
}
