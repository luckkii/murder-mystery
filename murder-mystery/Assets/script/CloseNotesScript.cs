using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNotesScript : MonoBehaviour
{
   Clues clues;
   Notebook notebook;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        notebook = FindObjectOfType<Notebook>();
    }

    public void closeNotes(){
        clues.gameObject.SetActive(true);
        notebook.gameObject.SetActive(false);
    }

}
