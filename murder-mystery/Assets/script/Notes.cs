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
        Debug.Log("brah");
        clues.gameObject.SetActive(false);
        notebook.gameObject.SetActive(true);
    }
}
