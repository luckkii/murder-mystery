using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class X_Button : MonoBehaviour
{   public Button button;
    public Clues clues;
    public Clue1 clue;
    // Start is called before the first frame update
    void Start()
    {
       button = FindObjectOfType<Button>();
       clues = FindObjectOfType<Clues>();
       clue = FindObjectOfType<Clue1>();

        button.gameObject.SetActive(false);
        clue.gameObject.SetActive(false);
        clues.gameObject.SetActive(true);
        Debug.Log("Mwah");
    }

    // Update is called once per frame
    public void exit(){
        Debug.Log("Grah");
        if (button.gameObject.activeSelf == true){
            Debug.Log("brah");
            button.gameObject.SetActive(false);
            clue.gameObject.SetActive(false);
            clues.gameObject.SetActive(true);
        }
    }
}
